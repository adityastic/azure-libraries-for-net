// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Single item in List or Get Alias(Disaster Recovery configuration)
    /// operation
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ArmDisasterRecoveryInner : NestedResourceInner
    {
        /// <summary>
        /// Initializes a new instance of the ArmDisasterRecoveryInner class.
        /// </summary>
        public ArmDisasterRecoveryInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ArmDisasterRecoveryInner class.
        /// </summary>
        /// <param name="provisioningState">Provisioning state of the
        /// Alias(Disaster Recovery configuration) - possible values 'Accepted'
        /// or 'Succeeded' or 'Failed'. Possible values include: 'Accepted',
        /// 'Succeeded', 'Failed'</param>
        /// <param name="partnerNamespace">ARM Id of the Primary/Secondary
        /// eventhub namespace name, which is part of GEO DR pairning</param>
        /// <param name="alternateName">Alternate name specified when alias and
        /// namespace names are same.</param>
        /// <param name="role">role of namespace in GEO DR - possible values
        /// 'Primary' or 'PrimaryNotReplicating' or 'Secondary'. Possible
        /// values include: 'Primary', 'PrimaryNotReplicating',
        /// 'Secondary'</param>
        public ArmDisasterRecoveryInner(string id = default(string), string name = default(string), string type = default(string), ProvisioningStateDR? provisioningState = default(ProvisioningStateDR?), string partnerNamespace = default(string), string alternateName = default(string), RoleDisasterRecovery? role = default(RoleDisasterRecovery?))
            : base(id, name, type)
        {
            ProvisioningState = provisioningState;
            PartnerNamespace = partnerNamespace;
            AlternateName = alternateName;
            Role = role;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets provisioning state of the Alias(Disaster Recovery
        /// configuration) - possible values 'Accepted' or 'Succeeded' or
        /// 'Failed'. Possible values include: 'Accepted', 'Succeeded',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningStateDR? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets ARM Id of the Primary/Secondary eventhub namespace
        /// name, which is part of GEO DR pairning
        /// </summary>
        [JsonProperty(PropertyName = "properties.partnerNamespace")]
        public string PartnerNamespace { get; set; }

        /// <summary>
        /// Gets or sets alternate name specified when alias and namespace
        /// names are same.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alternateName")]
        public string AlternateName { get; set; }

        /// <summary>
        /// Gets role of namespace in GEO DR - possible values 'Primary' or
        /// 'PrimaryNotReplicating' or 'Secondary'. Possible values include:
        /// 'Primary', 'PrimaryNotReplicating', 'Secondary'
        /// </summary>
        [JsonProperty(PropertyName = "properties.role")]
        public RoleDisasterRecovery? Role { get; private set; }

    }
}