// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of the operations resource.
    /// </summary>
    public partial class OperationProperties
    {
        /// <summary>
        /// Initializes a new instance of the OperationProperties class.
        /// </summary>
        public OperationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationProperties class.
        /// </summary>

        /// <param name="serviceSpecification">Service specification for the operations resource.
        /// </param>
        public OperationProperties(OperationResourceServiceSpecification serviceSpecification = default(OperationResourceServiceSpecification))

        {
            this.ServiceSpecification = serviceSpecification;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets service specification for the operations resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serviceSpecification")]
        public OperationResourceServiceSpecification ServiceSpecification {get; set; }
    }
}