// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Linq;

    /// <summary>
    /// SAP Business Warehouse Open Hub Destination Linked Service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SapOpenHub")]
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class SapOpenHubLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the SapOpenHubLinkedService class.
        /// </summary>
        public SapOpenHubLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SapOpenHubLinkedService class.
        /// </summary>

        /// <param name="additionalProperties">The nested object which contains the information and credential which can
        /// be used to connect with related store or compute resource.
        /// </param>

        /// <param name="connectVia">The integration runtime reference.
        /// </param>

        /// <param name="description">Linked service description.
        /// </param>

        /// <param name="parameters">Parameters for linked service.
        /// </param>

        /// <param name="annotations">List of tags that can be used for describing the linked service.
        /// </param>

        /// <param name="server">Host name of the SAP BW instance where the open hub destination is located.
        /// Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="systemNumber">System number of the BW system where the open hub destination is located.
        /// (Usually a two-digit decimal number represented as a string.) Type: string
        /// (or Expression with resultType string).
        /// </param>

        /// <param name="clientId">Client ID of the client on the BW system where the open hub destination is
        /// located. (Usually a three-digit decimal number represented as a string)
        /// Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="language">Language of the BW system where the open hub destination is located. The
        /// default value is EN. Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="systemId">SystemID of the SAP system where the table is located. Type: string (or
        /// Expression with resultType string).
        /// </param>

        /// <param name="userName">Username to access the SAP BW server where the open hub destination is
        /// located. Type: string (or Expression with resultType string).
        /// </param>

        /// <param name="password">Password to access the SAP BW server where the open hub destination is
        /// located.
        /// </param>

        /// <param name="messageServer">The hostname of the SAP Message Server. Type: string (or Expression with
        /// resultType string).
        /// </param>

        /// <param name="messageServerService">The service name or port number of the Message Server. Type: string (or
        /// Expression with resultType string).
        /// </param>

        /// <param name="logonGroup">The Logon Group for the SAP System. Type: string (or Expression with
        /// resultType string).
        /// </param>

        /// <param name="encryptedCredential">The encrypted credential used for authentication. Credentials are encrypted
        /// using the integration runtime credential manager. Type: string.
        /// </param>
        public SapOpenHubLinkedService(System.Collections.Generic.IDictionary<string, object> additionalProperties = default(System.Collections.Generic.IDictionary<string, object>), IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), System.Collections.Generic.IDictionary<string, ParameterSpecification> parameters = default(System.Collections.Generic.IDictionary<string, ParameterSpecification>), System.Collections.Generic.IList<object> annotations = default(System.Collections.Generic.IList<object>), object server = default(object), object systemNumber = default(object), object clientId = default(object), object language = default(object), object systemId = default(object), object userName = default(object), SecretBase password = default(SecretBase), object messageServer = default(object), object messageServerService = default(object), object logonGroup = default(object), string encryptedCredential = default(string))

        : base(additionalProperties, connectVia, description, parameters, annotations)
        {
            this.Server = server;
            this.SystemNumber = systemNumber;
            this.ClientId = clientId;
            this.Language = language;
            this.SystemId = systemId;
            this.UserName = userName;
            this.Password = password;
            this.MessageServer = messageServer;
            this.MessageServerService = messageServerService;
            this.LogonGroup = logonGroup;
            this.EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets host name of the SAP BW instance where the open hub
        /// destination is located. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.server")]
        public object Server {get; set; }

        /// <summary>
        /// Gets or sets system number of the BW system where the open hub destination
        /// is located. (Usually a two-digit decimal number represented as a string.)
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.systemNumber")]
        public object SystemNumber {get; set; }

        /// <summary>
        /// Gets or sets client ID of the client on the BW system where the open hub
        /// destination is located. (Usually a three-digit decimal number represented
        /// as a string) Type: string (or Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.clientId")]
        public object ClientId {get; set; }

        /// <summary>
        /// Gets or sets language of the BW system where the open hub destination is
        /// located. The default value is EN. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.language")]
        public object Language {get; set; }

        /// <summary>
        /// Gets or sets systemID of the SAP system where the table is located. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.systemId")]
        public object SystemId {get; set; }

        /// <summary>
        /// Gets or sets username to access the SAP BW server where the open hub
        /// destination is located. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.userName")]
        public object UserName {get; set; }

        /// <summary>
        /// Gets or sets password to access the SAP BW server where the open hub
        /// destination is located.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password {get; set; }

        /// <summary>
        /// Gets or sets the hostname of the SAP Message Server. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.messageServer")]
        public object MessageServer {get; set; }

        /// <summary>
        /// Gets or sets the service name or port number of the Message Server. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.messageServerService")]
        public object MessageServerService {get; set; }

        /// <summary>
        /// Gets or sets the Logon Group for the SAP System. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.logonGroup")]
        public object LogonGroup {get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication. Credentials
        /// are encrypted using the integration runtime credential manager. Type:
        /// string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public string EncryptedCredential {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();











        }
    }
}