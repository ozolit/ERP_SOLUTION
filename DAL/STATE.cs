//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_SOLUTION.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class STATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STATE()
        {
            this.LGA = new HashSet<LGA>();
            this.PERSON = new HashSet<PERSON>();
        }
    
        public long StateId { get; set; }
        public long CountryId { get; set; }
        public long Name { get; set; }
    
        public virtual COUNTRY COUNTRY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LGA> LGA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSON> PERSON { get; set; }
    }
}