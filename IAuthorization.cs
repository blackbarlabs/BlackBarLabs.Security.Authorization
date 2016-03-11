using System;
using System.Runtime.Serialization;

namespace BlackBarLabs.Security.Authorization
{
    public interface IAuthorization
    {
        [DataMember]
        Guid Id { get; set; }

        [DataMember]
        CredentialsType[] CredentialProviders { get; set; }

        [DataMember]
        Uri [] ClaimsProviders { get; set; }
    }
}
