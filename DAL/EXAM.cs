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
    
    public partial class EXAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EXAM()
        {
            this.APPLICANT_SUBJECT = new HashSet<APPLICANT_SUBJECT>();
        }
    
        public int ExamId { get; set; }
        public byte ExamTypeId { get; set; }
        public long ApplicantId { get; set; }
        public int TotalScore { get; set; }
        public string ExamNumber { get; set; }
        public int ExamYear { get; set; }
    
        public virtual APPLICANT APPLICANT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPLICANT_SUBJECT> APPLICANT_SUBJECT { get; set; }
        public virtual EXAM_TYPE EXAM_TYPE { get; set; }
    }
}