# Upcoming breaking changes in Azure PowerShell

The breaking changes listed in this article are planned for the next major release of the Az
PowerShell module unless otherwise noted. Per our
[Support lifecycle](azureps-support-lifecycle.md), breaking changes in Azure PowerShell occur twice
a year with major versions of the Az PowerShell module.

Preview modules are not included in this list. Read more about [module version types](azureps-support-lifecycle.md#module-version-types).

## Az.Compute

### `New-AzVM`

- Cmdlet breaking-change will happen to all parameter sets
  - The default VM size will change from 'Standard_D2s_v3' to 'Standard_D2s_v5'.
  - This change is expected to take effect from Az.Compute version: 11.0.0 and Az version: 15.0.0

### `New-AzVmss`

- Cmdlet breaking-change will happen to all parameter sets
  - In the next breaking change period (Nov 2025), the default VM size will change from 'Standard_Ds1_v2' to 'Standard_D2s_v5'.
  - This change is expected to take effect from Az.Compute version: 11.0.0 and Az version: 15.0.0

## Az.ContainerInstance

### `New-AzContainerGroup`

- Parameter breaking-change will happen to all parameter sets
  - `-OSType`
    - The parameter : 'OSType' is changing.
    - This change will take effect on '5/21/2025'- The change is expected to take effect from Az version : '14.0.0'
    - The change is expected to take effect from version : '5.0.0'

### `New-AzContainerInstanceContainerGroupProfile`

- Parameter breaking-change will happen to all parameter sets
  - `-OSType`
    - The parameter : 'OSType' is changing.
    - Change description : Removing the default value of OSType parameter. 
    - This change will take effect on '5/21/2025'- The change is expected to take effect from Az version : '14.0.0'
    - The change is expected to take effect from version : '5.0.0'

## Az.DevCenter

### `Connect-AzDevCenterAdminCatalog`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Connect-AzDevCenterAdminCatalog' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Connect-AzDevCenterAdminProjectCatalog`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Connect-AzDevCenterAdminProjectCatalog' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminAttachedNetwork`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminAttachedNetwork' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminCatalog`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminCatalog' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminCatalogSyncErrorDetail`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminCatalogSyncErrorDetail' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminCustomizationTask`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminCustomizationTask' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminCustomizationTaskErrorDetail`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminCustomizationTaskErrorDetail' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminDevBoxDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminDevBoxDefinition' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminDevCenter`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminDevCenter' is replacing this cmdlet.
  - Change description : PlanId will be removed from the DevCenter output. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminEnvironmentDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminEnvironmentDefinition' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminEnvironmentDefinitionErrorDetail`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminEnvironmentDefinitionErrorDetail' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminEnvironmentType`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminEnvironmentType' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminGallery`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminGallery' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminImage`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminImage' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminImageVersion`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminImageVersion' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

- Cmdlet breaking-change will happen to parameter set `GetAzDevCenterAdminImageVersion_List`
  The cmdlet parameter set is being deprecated. There will be no replacement for it.
  - Change description : The default parameter set will change from list dev center image versions to list project image versions. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminNetworkConnection`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminNetworkConnection' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminNetworkConnectionHealthDetail`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminNetworkConnectionHealthDetail' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminOperationStatus`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminOperationStatus' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminPlan`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet is being deprecated. There will be no replacement for it.
  - Change description : The Plan and PlanMember resources will be removed. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminPlanMember`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet is being deprecated. There will be no replacement for it.
  - Change description : The Plan and PlanMember resources will be removed. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminPool`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminPool' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminProject`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminProject' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminProjectAllowedEnvironmentType`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminProjectAllowedEnvironmentType' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminProjectCatalog`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminProjectCatalog' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminProjectCatalogSyncErrorDetail`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminProjectCatalogSyncErrorDetail' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminProjectEnvironmentDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminProjectEnvironmentDefinition' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminProjectEnvironmentDefinitionErrorDetail`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminProjectEnvironmentDefinitionErrorDetail' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminProjectEnvironmentType`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminProjectEnvironmentType' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminProjectInheritedSetting`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Get-AzDevCenterAdminProjectInheritedSetting' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Get-AzDevCenterAdminSchedule`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Invoke-AzDevCenterAdminExecuteCheckNameAvailability`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Invoke-AzDevCenterAdminExecuteCheckNameAvailability' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Invoke-AzDevCenterAdminExecuteCheckScopedNameAvailability`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Invoke-AzDevCenterAdminExecuteCheckScopedNameAvailability' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminAttachedNetwork`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminCatalog`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminDevBoxDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminDevCenter`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'New-AzDevCenterAdminDevCenter' is replacing this cmdlet.
  - Change description : PlanId will be removed from the DevCenter output. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

- Parameter breaking-change will happen to all parameter sets
  - `-PlanId`
    - The parameter : 'PlanId' is changing.
    - Change description : PlanId parameter will be removed. 
    - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
    - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminEnvironmentType`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'New-AzDevCenterAdminEnvironmentType' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminGallery`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminNetworkConnection`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminPlan`

- Cmdlet breaking-change will happen to all parameter sets
  The Plan resource will be deprecated
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminPlanMember`

- Cmdlet breaking-change will happen to all parameter sets
  The PlanMember resource will be deprecated
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminPool`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminProject`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminProjectCatalog`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminProjectEnvironmentType`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterAdminSchedule`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `New-AzDevCenterUserDevBox`

- Parameter breaking-change will happen to all parameter sets
  - `-LocalAdministrator`
    - The parameter : 'LocalAdministrator' is changing.
    - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
    - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminAttachedNetwork`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Remove-AzDevCenterAdminAttachedNetwork' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminCatalog`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Remove-AzDevCenterAdminCatalog' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminDevBoxDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Remove-AzDevCenterAdminDevBoxDefinition' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminDevCenter`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Remove-AzDevCenterAdminDevCenter' is replacing this cmdlet.
  - Change description : PlanId will be removed from the DevCenter output. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminEnvironmentType`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Remove-AzDevCenterAdminEnvironmentType' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminGallery`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Remove-AzDevCenterAdminGallery' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminNetworkConnection`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Remove-AzDevCenterAdminNetworkConnection' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminPlan`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet is being deprecated. There will be no replacement for it.
  - Change description : The Plan and PlanMember resources will be removed. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminPlanMember`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet is being deprecated. There will be no replacement for it.
  - Change description : The Plan and PlanMember resources will be removed. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminPool`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Remove-AzDevCenterAdminPool' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminProject`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Remove-AzDevCenterAdminProject' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminProjectCatalog`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Remove-AzDevCenterAdminProjectCatalog' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminProjectEnvironmentType`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Remove-AzDevCenterAdminProjectEnvironmentType' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterAdminSchedule`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterUserDevBox`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type is changing from the existing type :'OperationStatus' to the new type :'OperationStatus'
  - The following properties in the output type are being deprecated : 'Property'
  - The following properties are being added to the output type : 'Property'
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Remove-AzDevCenterUserEnvironment`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type is changing from the existing type :'OperationStatus' to the new type :'OperationStatus'
  - The following properties in the output type are being deprecated : 'Property'
  - The following properties are being added to the output type : 'Property'
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Repair-AzDevCenterUserDevBox`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type is changing from the existing type :'OperationStatus' to the new type :'OperationStatus'
  - The following properties in the output type are being deprecated : 'Property'
  - The following properties are being added to the output type : 'Property'
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Restart-AzDevCenterUserDevBox`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type is changing from the existing type :'OperationStatus' to the new type :'OperationStatus'
  - The following properties in the output type are being deprecated : 'Property'
  - The following properties are being added to the output type : 'Property'
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Start-AzDevCenterAdminNetworkConnectionHealthCheck`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Start-AzDevCenterAdminNetworkConnectionHealthCheck' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Start-AzDevCenterAdminPoolHealthCheck`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Start-AzDevCenterAdminPoolHealthCheck' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Start-AzDevCenterUserDevBox`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type is changing from the existing type :'OperationStatus' to the new type :'OperationStatus'
  - The following properties in the output type are being deprecated : 'Property'
  - The following properties are being added to the output type : 'Property'
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Stop-AzDevCenterUserDevBox`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type is changing from the existing type :'OperationStatus' to the new type :'OperationStatus'
  - The following properties in the output type are being deprecated : 'Property'
  - The following properties are being added to the output type : 'Property'
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Sync-AzDevCenterAdminCatalog`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Sync-AzDevCenterAdminCatalog' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Sync-AzDevCenterAdminProjectCatalog`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Sync-AzDevCenterAdminProjectCatalog' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Update-AzDevCenterAdminCatalog`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Update-AzDevCenterAdminCatalog' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Update-AzDevCenterAdminDevBoxDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Update-AzDevCenterAdminDevBoxDefinition' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Update-AzDevCenterAdminDevCenter`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Update-AzDevCenterAdminDevCenter' is replacing this cmdlet.
  - Change description : PlanId will be removed from the DevCenter output. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

- Parameter breaking-change will happen to all parameter sets
  - `-PlanId`
    - The parameter : 'PlanId' is changing.
    - Change description : PlanId parameter will be removed. 
    - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
    - The change is expected to take effect from version : '3.0.0'

### `Update-AzDevCenterAdminEnvironmentType`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Update-AzDevCenterAdminEnvironmentType' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Update-AzDevCenterAdminNetworkConnection`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Update-AzDevCenterAdminNetworkConnection' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Update-AzDevCenterAdminPlan`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet is being deprecated. There will be no replacement for it.
  - Change description : The Plan and PlanMember resources will be removed. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Update-AzDevCenterAdminPlanMember`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet is being deprecated. There will be no replacement for it.
  - Change description : The Plan and PlanMember resources will be removed. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Update-AzDevCenterAdminPool`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Update-AzDevCenterAdminPool' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Update-AzDevCenterAdminProject`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Update-AzDevCenterAdminProject' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Update-AzDevCenterAdminProjectCatalog`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Update-AzDevCenterAdminProjectCatalog' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Update-AzDevCenterAdminProjectEnvironmentType`

- Cmdlet breaking-change will happen to all parameter sets
  The cmdlet 'Update-AzDevCenterAdminProjectEnvironmentType' is replacing this cmdlet.
  - Change description : PlanName and MemberName will be removed from the InputObject parameter. 
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

### `Update-AzDevCenterAdminSchedule`

- Cmdlet breaking-change will happen to all parameter sets
  MemberName and PlanName will be removed from InputObject
  - This change will take effect on '11/18/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '3.0.0'

## Az.ManagedServices

### `Get-AzManagedServicesAssignment`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignment' is changing
  - The following properties in the output type are being deprecated : 'Authorization[]' 'EligibleAuthorization[]'
  - The following properties are being added to the output type : 'List[Authorization]' 'List[EligibleAuthorization]'
  - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '9.0.0'

### `Get-AzManagedServicesDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinition' is changing
  - The following properties in the output type are being deprecated : 'Authorization[]' 'EligibleAuthorization[]'
  - The following properties are being added to the output type : 'List[Authorization]' 'List[EligibleAuthorization]'
  - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '9.0.0'

### `New-AzManagedServicesAssignment`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationAssignment' is changing
  - The following properties in the output type are being deprecated : 'Authorization[]' 'EligibleAuthorization[]'
  - The following properties are being added to the output type : 'List[Authorization]' 'List[EligibleAuthorization]'
  - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '9.0.0'

### `New-AzManagedServicesAuthorizationObject`

- Parameter breaking-change will happen to all parameter sets
  - `-DelegatedRoleDefinitionId`
    - The parameter : 'DelegatedRoleDefinitionId' is changing.
    The type of the parameter is changing from 'Array' to 'List'.
    - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
    - The change is expected to take effect from version : '9.0.0'

### `New-AzManagedServicesDefinition`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.PowerShell.Cmdlets.ManagedServices.Models.Api20200201Preview.IRegistrationDefinition' is changing
  - The following properties in the output type are being deprecated : 'Authorization' 'EligibleAuthorization' 'DelegatedRoleDefinitionId[]' 'JustInTimeAccessPolicyManagedByTenantApprover[]'
  - The following properties are being added to the output type : 'List[Authorization]' 'List[EligibleAuthorization]' 'List[DelegatedRoleDefinitionId]' 'List[JustInTimeAccessPolicyManagedByTenantApprover]'
  - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '9.0.0'

- Parameter breaking-change will happen to all parameter sets
  - `-Authorization`
    - The parameter : 'Authorization' is changing.
    The type of the parameter is changing from 'Array' to 'List'.
    - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
    - The change is expected to take effect from version : '9.0.0'
  - `-EligibleAuthorization`
    - The parameter : 'EligibleAuthorization' is changing.
    The type of the parameter is changing from 'Array' to 'List'.
    - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
    - The change is expected to take effect from version : '9.0.0'

### `New-AzManagedServicesEligibleAuthorizationObject`

- Parameter breaking-change will happen to all parameter sets
  - `-JustInTimeAccessPolicyManagedByTenantApprover`
    - The parameter : 'JustInTimeAccessPolicyManagedByTenantApprover' is changing.
    The type of the parameter is changing from 'Array' to 'List'.
    - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
    - The change is expected to take effect from version : '9.0.0'

## Az.RecoveryServices

### `Get-AzRecoveryServicesBackupSchedulePolicyObject`

- Cmdlet breaking-change will happen to all parameter sets
  - May 2025 onwards, this command will return a schedule policy object for Enhanced policy by default for AzureVM workload
  - This change is expected to take effect from Az.RecoveryServices version: 8.0.0 and Az version: 14.0.0

## Az.Relay

### `Get-AzRelayNamespace`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.IRelayNamespace' is changing
  - The following properties in the output type are being deprecated : 'PrivateEndpointConnection'
  - The following properties are being added to the output type : 'List[PrivateEndpointConnection]'
  - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '9.0.0'

### `Get-AzRelayNamespaceNetworkRuleSet`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.PowerShell.Cmdlets.Relay.Models.Api20211101.INetworkRuleSet' is changing
  - The following properties in the output type are being deprecated : 'IPRule'
  - The following properties are being added to the output type : 'List[IPRule]'
  - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '9.0.0'

## Az.Resources

### `Get-AzRoleManagementPolicy`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicy' is changing
  - The following properties in the output type are being deprecated : 'EffectiveRule[]' 'Rule[]'
  - The following properties are being added to the output type : 'List[EffectiveRule]' 'List[Rule]'
  - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '9.0.0'

### `Update-AzRoleManagementPolicy`

- Cmdlet breaking-change will happen to all parameter sets
  - The output type 'Microsoft.Azure.PowerShell.Cmdlets.Resources.Authorization.Models.Api20201001Preview.IRoleManagementPolicy' is changing
  - The following properties in the output type are being deprecated : 'EffectiveRule[]' 'Rule[]'
  - The following properties are being added to the output type : 'List[EffectiveRule]' 'List[Rule]'
  - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
  - The change is expected to take effect from version : '9.0.0'

- Parameter breaking-change will happen to all parameter sets
  - `-Rule`
    - The parameter : 'Rule' is changing.
    The type of the parameter is changing from 'Array' to 'List'.
    - This change will take effect on '11/3/2025'- The change is expected to take effect from Az version : '15.0.0'
    - The change is expected to take effect from version : '9.0.0'
