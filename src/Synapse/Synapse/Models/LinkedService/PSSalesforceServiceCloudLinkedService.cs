// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Linked service for Salesforce Service Cloud.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SalesforceServiceCloud")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSSalesforceServiceCloudLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PSSalesforceServiceCloudLinkedService class.
        /// </summary>
        public PSSalesforceServiceCloudLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of Salesforce Service Cloud instance. Default
        /// is 'https://login.salesforce.com'. To copy data from sandbox,
        /// specify 'https://test.salesforce.com'. To copy data from custom
        /// domain, specify, for example, 'https://[domain].my.salesforce.com'.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.environmentUrl")]
        public object EnvironmentUrl { get; set; }

        /// <summary>
        /// Gets or sets the username for Basic authentication of the
        /// Salesforce instance. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets the password for Basic authentication of the
        /// Salesforce instance.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets the security token is required to remotely access
        /// Salesforce instance.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.securityToken")]
        public SecretBase SecurityToken { get; set; }

        /// <summary>
        /// Gets or sets extended properties appended to the connection string.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.extendedProperties")]
        public object ExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new SalesforceServiceCloudLinkedService();
            linkedService.EnvironmentUrl = this.EnvironmentUrl;
            linkedService.Username = this.Username;
            linkedService.Password = this.Password;
            linkedService.SecurityToken = this.SecurityToken;
            linkedService.ExtendedProperties = this.ExtendedProperties;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            SetProperties(linkedService);
            return linkedService;
        }
    }
}

