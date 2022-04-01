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
    
    public partial class DEPARTMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DEPARTMENT()
        {
            this.ACADEMIC_DETAILS = new HashSet<ACADEMIC_DETAILS>();
            this.PROGRAMME = new HashSet<PROGRAMME>();
            this.STUDENT = new HashSet<STUDENT>();
        }
    
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public byte FacultyId { get; set; }
        public byte SchoolId { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACADEMIC_DETAILS> ACADEMIC_DETAILS { get; set; }
        public virtual FACULTY FACULTY { get; set; }
        public virtual SCHOOL SCHOOL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROGRAMME> PROGRAMME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STUDENT> STUDENT { get; set; }
    }
}
