//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerDemographics
    {
        public CustomerDemographics()
        {
            this.Customers = new HashSet<Customers>();
        }
    
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
    
        public virtual ICollection<Customers> Customers { get; set; }
    }
}