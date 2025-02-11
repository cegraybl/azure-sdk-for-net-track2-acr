// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServices.Models
{
    /// <summary> DNSZone information for Microsoft.RecoveryServices. </summary>
    public partial class DnsZoneResponse : DnsZone
    {
        /// <summary> Initializes a new instance of DnsZoneResponse. </summary>
        public DnsZoneResponse()
        {
            RequiredZoneNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DnsZoneResponse. </summary>
        /// <param name="subResource"> Subresource type for vault AzureBackup, AzureBackup_secondary or AzureSiteRecovery. </param>
        /// <param name="requiredZoneNames"> The private link resource Private link DNS zone names. </param>
        internal DnsZoneResponse(VaultSubResourceType? subResource, IList<string> requiredZoneNames) : base(subResource)
        {
            RequiredZoneNames = requiredZoneNames;
        }

        /// <summary> The private link resource Private link DNS zone names. </summary>
        public IList<string> RequiredZoneNames { get; }
    }
}
