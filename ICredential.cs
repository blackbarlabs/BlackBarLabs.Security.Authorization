using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlackBarLabs.Security.Authorization
{
    public interface ICredential
    {
        [DataMember]
        CredentialValidationMethodTypes Method { get; set; }

        [DataMember]
        Uri Provider { get; set; }

        [DataMember]
        string UserId { get; set; }

        [DataMember]
        string Token { get; set; }

        [DataMember]
        Uri[] ClaimsProviders { get; set; }
    }
}
