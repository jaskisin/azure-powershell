using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

using Tools.Common.Models;

namespace VersionController.Netcore.Models
{
    internal class ModuleHelper
    {
        /// <summary>
        /// Get the version of latest Az.Accounts in LTS status from PSGallery
        /// </summary>
        /// <returns></returns>
        internal static string GetLatestAccountsVersionFromPSGallery(ReleaseType releaseType = ReleaseType.STS)
        {
            var script = releaseType == ReleaseType.STS
                ? $"Find-PSResource -Name Az.Accounts -Version *"
                : $"Find-PSResource -Name Az -Version *";

            var results = InvokePowerShellScript<PSObject>(script);

            var filteredResults = releaseType == ReleaseType.LTS
                ? results.Where(r => new AzurePSVersion(r.Properties["Version"].Value.ToString()).Major % 2 == 0)
                : results;

            var sortedResults = filteredResults.OrderByDescending(r => new AzurePSVersion(r.Properties["Version"].Value.ToString()));

            if (!sortedResults.Any())
            {
                return null;
            }

            var latestModule = sortedResults.First();
            if (releaseType == ReleaseType.STS)
            {
                return latestModule.Properties["Version"].Value.ToString();
            }

            var dependencies = latestModule.Properties["Dependencies"].Value as System.Collections.ArrayList;
            var accountDependency = dependencies?.Cast<PSObject>().FirstOrDefault(d => d.Properties["Name"].Value.ToString().Equals("Az.Accounts"));
            // The dependency version is a version range, e.g. '[11.5.0, 12.0.0)', we take the lower bound.
            return accountDependency?.Properties["VersionRange"].Value.ToString().Split(',')[0].TrimStart('[');
        }

        /// <summary>
        /// Get version from PSGallery and merge into one list.
        /// </summary>
        /// <returns>A list of version</returns>
        internal static List<AzurePSVersion> GetAllVersionsFromGallery(string moduleName)
        {
            var script = $"Find-PSResource -Name {moduleName} -Prerelease";
            var results = InvokePowerShellScript<PSObject>(script);
            return results.Select(r => new AzurePSVersion(r.Properties["Version"].Value.ToString())).ToList();
        }

        private static IEnumerable<T> InvokePowerShellScript<T>(string script)
        {
            using (var powershell = PowerShell.Create())
            {
                var fullScript = new System.Text.StringBuilder();
                if (!string.IsNullOrEmpty(System.Environment.GetEnvironmentVariable("DEFAULT_PS_REPOSITORY_URL")))
                {
                    var repository = System.Environment.GetEnvironmentVariable("DEFAULT_PS_REPOSITORY_NAME");
                    var accessToken = System.Environment.GetEnvironmentVariable("SYSTEM_ACCESS_TOKEN");
                    fullScript.AppendLine($"$AccessToken = '{accessToken}' | ConvertTo-SecureString -AsPlainText -Force");
                    fullScript.AppendLine($"$creds = New-Object System.Management.Automation.PSCredential('user', $AccessToken)");
                    fullScript.AppendLine($"{script} -Repository {repository} -Credential $creds");
                }
                else
                {
                    fullScript.AppendLine($"{script} -Repository PSGallery");
                }

                powershell.AddScript(fullScript.ToString());
                return powershell.Invoke<T>();
            }
        }


        /// <summary>
        /// Under the same Major version, check if there exist preview version in gallery that has greater version.
        /// </summary>
        /// <returns>True if exist a version, false otherwise.</returns>
        internal static AzurePSVersion GetLatestVersionFromGalleryUnderSameMajorVersion(AzurePSVersion bumpedVersion, List<AzurePSVersion> galleryVersion, bool IsPreview)
        {
            var maxVersionInGallery = new AzurePSVersion(0, 0, 0);

            foreach (var version in galleryVersion)
            {
                if (version.Major == bumpedVersion.Major && (version.IsPreview == IsPreview) && version > maxVersionInGallery)
                {
                    maxVersionInGallery = version;
                }
            }
            return maxVersionInGallery;
        }
    }
}
