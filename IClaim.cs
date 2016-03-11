using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBarLabs.Security.Authorization
{
    public interface IClaim
    {
        /// <summary>
        /// Issuer of the claim
        /// </summary>
        string Issuer { get; set; }

        /// <summary>
        /// Original issuer of the claim.
        /// </summary>
        string OriginalIssuer { get; set; }

        /// <summary>
        /// A dictionary that contains additional properties associated with this claim.
        /// </summary>
        IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Type of cliam: http://schemas.xmlsoap.org/ws/2009/09/identity/claims/*
        /// </summary>
        Uri Type { get; set; }

        /// <summary>
        /// Value of the claim
        /// </summary>
        string Value { get; set; }

        /// <summary>
        /// Value type of the claim (type that is serialized into the string in the <code>Value</code> Property).
        /// </summary>
        string ValueType { get; set; }
    }
}
