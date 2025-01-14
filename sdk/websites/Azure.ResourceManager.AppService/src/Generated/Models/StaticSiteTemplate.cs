// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Template Options for the static site. </summary>
    public partial class StaticSiteTemplate
    {
        /// <summary> Initializes a new instance of StaticSiteTemplate. </summary>
        public StaticSiteTemplate()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteTemplate. </summary>
        /// <param name="templateRepositoryUri"> URL of the template repository. The newly generated repository will be based on this one. </param>
        /// <param name="owner"> Owner of the newly generated repository. </param>
        /// <param name="repositoryName"> Name of the newly generated repository. </param>
        /// <param name="description"> Description of the newly generated repository. </param>
        /// <param name="isPrivate"> Whether or not the newly generated repository is a private repository. Defaults to false (i.e. public). </param>
        internal StaticSiteTemplate(Uri templateRepositoryUri, string owner, string repositoryName, string description, bool? isPrivate)
        {
            TemplateRepositoryUri = templateRepositoryUri;
            Owner = owner;
            RepositoryName = repositoryName;
            Description = description;
            IsPrivate = isPrivate;
        }

        /// <summary> URL of the template repository. The newly generated repository will be based on this one. </summary>
        public Uri TemplateRepositoryUri { get; set; }
        /// <summary> Owner of the newly generated repository. </summary>
        public string Owner { get; set; }
        /// <summary> Name of the newly generated repository. </summary>
        public string RepositoryName { get; set; }
        /// <summary> Description of the newly generated repository. </summary>
        public string Description { get; set; }
        /// <summary> Whether or not the newly generated repository is a private repository. Defaults to false (i.e. public). </summary>
        public bool? IsPrivate { get; set; }
    }
}
