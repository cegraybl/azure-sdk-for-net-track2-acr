// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    /// <summary> The private link scope resource reference. </summary>
    public partial class OperationalInsightsPrivateLinkScopedResourceInfo
    {
        /// <summary> Initializes a new instance of OperationalInsightsPrivateLinkScopedResourceInfo. </summary>
        internal OperationalInsightsPrivateLinkScopedResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of OperationalInsightsPrivateLinkScopedResourceInfo. </summary>
        /// <param name="resourceId"> The full resource Id of the private link scope resource. </param>
        /// <param name="scopeId"> The private link scope unique Identifier. </param>
        internal OperationalInsightsPrivateLinkScopedResourceInfo(ResourceIdentifier resourceId, string scopeId)
        {
            ResourceId = resourceId;
            ScopeId = scopeId;
        }

        /// <summary> The full resource Id of the private link scope resource. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> The private link scope unique Identifier. </summary>
        public string ScopeId { get; }
    }
}
