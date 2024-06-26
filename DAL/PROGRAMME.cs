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
    
    public partial class PROGRAMME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROGRAMME()
        {
            this.ACADEMIC_DETAILS = new HashSet<ACADEMIC_DETAILS>();
            this.APPLICANT = new HashSet<APPLICANT>();
            this.APPLICANT1 = new HashSet<APPLICANT>();
            this.HOSTEL_PROGRAMME_ACCESS = new HashSet<HOSTEL_PROGRAMME_ACCESS>();
            this.STUDENT = new HashSet<STUDENT>();
            this.STUDENT1 = new HashSet<STUDENT>();
        }
    
        public int ProgrammeId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public byte SchoolId { get; set; }
        public bool IsActive { get; set; }
        public string Code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACADEMIC_DETAILS> ACADEMIC_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPLICANT> APPLICANT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPLICANT> APPLICANT1 { get; set; }
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOSTEL_PROGRAMME_ACCESS> HOSTEL_PROGRAMME_ACCESS { get; set; }
        public virtual SCHOOL SCHOOL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STUDENT> STUDENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STUDENT> STUDENT1 { get; set; }
    }
}
