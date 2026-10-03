using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UzenetkuldoWCF.Models
{
    [DataContract]
    public class Uzenet
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Szoveg { get; set; }

        [DataMember]
        public DateTime KuldesiIdo { get; set; }

        [DataMember]
        public string UzenetTipus { get; set; }

        [DataMember]
        public string Telefon { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}