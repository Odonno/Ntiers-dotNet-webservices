//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace NorthwindDAL
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    [DataContract(IsReference = true)]
    public partial class Region
    {
        public Region()
        {
            this.Territories = new HashSet<Territories>();
        }

        [DataMember]
        public int RegionID { get; set; }
        [DataMember]
        public string RegionDescription { get; set; }

        
        public virtual ICollection<Territories> Territories { get; set; }
    }
}
