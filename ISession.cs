using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlackBarLabs.Security.Authorization
{
    public interface ISession
    {
        [DataMember]
        Guid Id { get; set; }

        [IgnoreDataMember]
        Guid AuthorizationId { get; set; }

        [DataMember]
        AuthHeaderProps SessionHeader { get; set; }

        [DataMember]
        CredentialsType Credentials { get; set; }

        [DataMember]
        string RefreshToken { get; set; }
    }
}
