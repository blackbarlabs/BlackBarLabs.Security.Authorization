using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlackBarLabs.Security.Authorization
{
    public interface IAuthorization
    {
        [DataMember]
        Guid Id { get; set; }

        [DataMember]
        CredentialsType[] CredentialProviders { get; set; }

    }
}
