// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Abstract base class for token filters.
    /// <see href="https://docs.microsoft.com/rest/api/searchservice/Custom-analyzers-in-Azure-Search" />
    /// </summary>
    public partial class TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the TokenFilter class.
        /// </summary>
        public TokenFilter() { }

        /// <summary>
        /// Initializes a new instance of the TokenFilter class.
        /// </summary>
        public TokenFilter(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Gets or sets the name of the token filter. It must only contain
        /// letters, digits, spaces, dashes or underscores, can only start
        /// and end with alphanumeric characters, and is limited to 128
        /// characters.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
