// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Profile properties required for profile update
    /// </summary>
    public partial class ProfileUpdateParameters : IResource
    {
        /// <summary>
        /// Initializes a new instance of the ProfileUpdateParameters class.
        /// </summary>
        public ProfileUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the ProfileUpdateParameters class.
        /// </summary>
        public ProfileUpdateParameters(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary>
        /// Profile tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Tags == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tags");
            }
        }
    }
}
