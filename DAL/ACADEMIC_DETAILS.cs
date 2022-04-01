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
    
    public partial class ACADEMIC_DETAILS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACADEMIC_DETAILS()
        {
            this.APPLICANT = new HashSet<APPLICANT>();
            this.INCOMPLETE_APPLICATION = new HashSet<INCOMPLETE_APPLICATION>();
        }
    
        public long AcademicDetailsId { get; set; }
        public long PersonId { get; set; }
        public byte FacultyId { get; set; }
        public int DepartmentId { get; set; }
        public int ProgrammeId { get; set; }
        public long JambId { get; set; }
        public int OlevelId { get; set; }
        public string SchoolAttended { get; set; }
        public string CourseStudied { get; set; }
        public string CertificateObtained { get; set; }
        public string ClassOfCertificate { get; set; }
        public int CGPA { get; set; }
        public string JambRegNumber { get; set; }
        public long LevelId { get; set; }
    
        public virtual DEPARTMENT DEPARTMENT { get; set; }
        public virtual FACULTY FACULTY { get; set; }
        public virtual APPLICANT_SUBJECT APPLICANT_SUBJECT { get; set; }
        public virtual LEVEL LEVEL { get; set; }
        public virtual PERSON PERSON { get; set; }
        public virtual PROGRAMME PROGRAMME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPLICANT> APPLICANT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INCOMPLETE_APPLICATION> INCOMPLETE_APPLICATION { get; set; }
    }
}
