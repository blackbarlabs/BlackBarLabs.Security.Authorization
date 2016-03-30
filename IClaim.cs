using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackBarLabs.Security.Authorization
{
    public interface IClaim
    {
        Guid AuthorizationId { get; set; }

        /// <summary>
        /// Issuer of the claim
        /// </summary>
        Uri Issuer { get; set; }

        /// <summary>
        /// Type of cliam: http://schemas.xmlsoap.org/ws/2009/09/identity/claims/*
        /// </summary>
        Uri Type { get; set; }

        /// <summary>
        /// Value of the claim
        /// </summary>
        string Value { get; set; }
        
        string Signature { get; set; }
    }
}
