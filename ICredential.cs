using System;
using System.Runtime.Serialization;

namespace BlackBarLabs.Security.Authorization
{
    public interface ICredential
    {
        [DataMember]
        Guid AuthorizationId { get; set; }

        [DataMember]
        CredentialValidationMethodTypes Method { get; set; }

        [DataMember]
        Uri Provider { get; set; }

        [DataMember]
        string UserId { get; set; }

        [DataMember]
        string Token { get; set; }
    }
}
