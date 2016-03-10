using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BlackBarLabs.Security.Authorization
{
    [DataContract]
    public class AuthHeaderProps
    {
        #region Properties
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Value { get; set; }
        #endregion
    }
}
