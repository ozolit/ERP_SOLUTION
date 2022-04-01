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
    
    public partial class PERSON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSON()
        {
            this.ACADEMIC_DETAILS = new HashSet<ACADEMIC_DETAILS>();
            this.APPLICANT = new HashSet<APPLICANT>();
            this.APPLICANT1 = new HashSet<APPLICANT>();
            this.BUS_DESCRIPTION = new HashSet<BUS_DESCRIPTION>();
            this.INCOMPLETE_APPLICATION = new HashSet<INCOMPLETE_APPLICATION>();
            this.PARENT_DETAILS = new HashSet<PARENT_DETAILS>();
            this.SPONSOR_DETAILS = new HashSet<SPONSOR_DETAILS>();
            this.STUDENT_HOSTEL_ROOM_BUNK = new HashSet<STUDENT_HOSTEL_ROOM_BUNK>();
            this.USER_MODULE = new HashSet<USER_MODULE>();
            this.USER_MODULE_ROLE = new HashSet<USER_MODULE_ROLE>();
        }
    
        public long PersonId { get; set; }
        public long PersonTypeId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<long> GenderId { get; set; }
        public string DateOfBirth { get; set; }
        public string ContactAddress { get; set; }
        public string PamanentHomeAddress { get; set; }
        public Nullable<long> CountryId { get; set; }
        public Nullable<long> StateId { get; set; }
        public Nullable<long> LGAId { get; set; }
        public long TribeId { get; set; }
        public string HomeTown { get; set; }
        public long MaritalStatusId { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }
        public System.DateTime DateEntered { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACADEMIC_DETAILS> ACADEMIC_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPLICANT> APPLICANT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPLICANT> APPLICANT1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BUS_DESCRIPTION> BUS_DESCRIPTION { get; set; }
        public virtual COUNTRY COUNTRY { get; set; }
        public virtual GENDER GENDER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INCOMPLETE_APPLICATION> INCOMPLETE_APPLICATION { get; set; }
        public virtual LGA LGA { get; set; }
        public virtual MARITAL_STATUS MARITAL_STATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PARENT_DETAILS> PARENT_DETAILS { get; set; }
        public virtual PERSON_TYPE PERSON_TYPE { get; set; }
        public virtual STATE STATE { get; set; }
        public virtual TRIBE TRIBE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPONSOR_DETAILS> SPONSOR_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STUDENT_HOSTEL_ROOM_BUNK> STUDENT_HOSTEL_ROOM_BUNK { get; set; }
        public virtual STUDENT STUDENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_MODULE> USER_MODULE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER_MODULE_ROLE> USER_MODULE_ROLE { get; set; }
    }
}