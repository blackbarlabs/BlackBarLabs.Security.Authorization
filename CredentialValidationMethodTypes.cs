using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBarLabs.Security.Authorization
{
    public enum CredentialValidationMethodTypes
    {
        OpenIdConnect,
        Facebook,
        Twitter,
        Google,
        Implicit,
        Voucher,
    }
}
