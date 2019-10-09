// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Cosmos DB resource throughput object
    /// </summary>
    public partial class ThroughputResource
    {
        /// <summary>
        /// Initializes a new instance of the ThroughputResource class.
        /// </summary>
        public ThroughputResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThroughputResource class.
        /// </summary>
        /// <param name="throughput">Value of the Cosmos DB resource
        /// throughput</param>
        public ThroughputResource(int throughput)
        {
            Throughput = throughput;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value of the Cosmos DB resource throughput
        /// </summary>
        [JsonProperty(PropertyName = "throughput")]
        public int Throughput { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}