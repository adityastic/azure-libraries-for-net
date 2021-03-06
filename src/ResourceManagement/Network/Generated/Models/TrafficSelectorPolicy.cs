// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An traffic selector policy for a virtual network gateway connection.
    /// </summary>
    public partial class TrafficSelectorPolicy
    {
        /// <summary>
        /// Initializes a new instance of the TrafficSelectorPolicy class.
        /// </summary>
        public TrafficSelectorPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrafficSelectorPolicy class.
        /// </summary>
        /// <param name="localAddressRanges">A collection of local address
        /// spaces in CIDR format.</param>
        /// <param name="remoteAddressRanges">A collection of remote address
        /// spaces in CIDR format.</param>
        public TrafficSelectorPolicy(IList<string> localAddressRanges, IList<string> remoteAddressRanges)
        {
            LocalAddressRanges = localAddressRanges;
            RemoteAddressRanges = remoteAddressRanges;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a collection of local address spaces in CIDR format.
        /// </summary>
        [JsonProperty(PropertyName = "localAddressRanges")]
        public IList<string> LocalAddressRanges { get; set; }

        /// <summary>
        /// Gets or sets a collection of remote address spaces in CIDR format.
        /// </summary>
        [JsonProperty(PropertyName = "remoteAddressRanges")]
        public IList<string> RemoteAddressRanges { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LocalAddressRanges == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LocalAddressRanges");
            }
            if (RemoteAddressRanges == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RemoteAddressRanges");
            }
        }
    }
}
