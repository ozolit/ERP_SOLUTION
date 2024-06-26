﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ERPEntities : DbContext
    {
        public ERPEntities()
            : base("name=ERPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACADEMIC_DETAILS> ACADEMIC_DETAILS { get; set; }
        public virtual DbSet<ACCESS_CONTROL> ACCESS_CONTROL { get; set; }
        public virtual DbSet<ADMISSION_STATUS> ADMISSION_STATUS { get; set; }
        public virtual DbSet<APPLICANT> APPLICANT { get; set; }
        public virtual DbSet<APPLICANT_SUBJECT> APPLICANT_SUBJECT { get; set; }
        public virtual DbSet<BUNK> BUNK { get; set; }
        public virtual DbSet<BUNK_TYPE> BUNK_TYPE { get; set; }
        public virtual DbSet<BUS_DESCRIPTION> BUS_DESCRIPTION { get; set; }
        public virtual DbSet<CENTER> CENTER { get; set; }
        public virtual DbSet<CLASS> CLASS { get; set; }
        public virtual DbSet<CONTINUOUS_EDUCATION> CONTINUOUS_EDUCATION { get; set; }
        public virtual DbSet<COUNTRY> COUNTRY { get; set; }
        public virtual DbSet<COURSES> COURSES { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENT { get; set; }
        public virtual DbSet<EMPLOYMENT_STATUS> EMPLOYMENT_STATUS { get; set; }
        public virtual DbSet<ENTRY_TYPE> ENTRY_TYPE { get; set; }
        public virtual DbSet<EXAM> EXAM { get; set; }
        public virtual DbSet<EXAM_TYPE> EXAM_TYPE { get; set; }
        public virtual DbSet<EXAM_YEAR> EXAM_YEAR { get; set; }
        public virtual DbSet<FACULTY> FACULTY { get; set; }
        public virtual DbSet<FEES> FEES { get; set; }
        public virtual DbSet<GENDER> GENDER { get; set; }
        public virtual DbSet<GRADE> GRADE { get; set; }
        public virtual DbSet<HOSTEL> HOSTEL { get; set; }
        public virtual DbSet<HOSTEL_BLOCK> HOSTEL_BLOCK { get; set; }
        public virtual DbSet<HOSTEL_PROGRAMME_ACCESS> HOSTEL_PROGRAMME_ACCESS { get; set; }
        public virtual DbSet<HOSTEL_TYPE> HOSTEL_TYPE { get; set; }
        public virtual DbSet<INCOMPLETE_APPLICATION> INCOMPLETE_APPLICATION { get; set; }
        public virtual DbSet<LEVEL> LEVEL { get; set; }
        public virtual DbSet<LGA> LGA { get; set; }
        public virtual DbSet<MARITAL_STATUS> MARITAL_STATUS { get; set; }
        public virtual DbSet<MODULE> MODULE { get; set; }
        public virtual DbSet<NEXT_KIN_DETAILS> NEXT_KIN_DETAILS { get; set; }
        public virtual DbSet<PAGE> PAGE { get; set; }
        public virtual DbSet<PAGE_ACTION> PAGE_ACTION { get; set; }
        public virtual DbSet<PARENT_DETAILS> PARENT_DETAILS { get; set; }
        public virtual DbSet<PAYMENT_TYPE> PAYMENT_TYPE { get; set; }
        public virtual DbSet<PERSON> PERSON { get; set; }
        public virtual DbSet<PERSON_TYPE> PERSON_TYPE { get; set; }
        public virtual DbSet<PROGRAMME> PROGRAMME { get; set; }
        public virtual DbSet<RELATIONSHIP> RELATIONSHIP { get; set; }
        public virtual DbSet<ROLE> ROLE { get; set; }
        public virtual DbSet<ROLE_PAGE_RIGHT> ROLE_PAGE_RIGHT { get; set; }
        public virtual DbSet<ROOM> ROOM { get; set; }
        public virtual DbSet<SCHOOL> SCHOOL { get; set; }
        public virtual DbSet<SCHOOL_TYPE> SCHOOL_TYPE { get; set; }
        public virtual DbSet<SCORE> SCORE { get; set; }
        public virtual DbSet<SEMESTER> SEMESTER { get; set; }
        public virtual DbSet<SESSION> SESSION { get; set; }
        public virtual DbSet<SPONSOR_DETAILS> SPONSOR_DETAILS { get; set; }
        public virtual DbSet<STATE> STATE { get; set; }
        public virtual DbSet<STUDENT> STUDENT { get; set; }
        public virtual DbSet<STUDENT_HOSTEL_ROOM_BUNK> STUDENT_HOSTEL_ROOM_BUNK { get; set; }
        public virtual DbSet<STUDENT_SESSION_DETAIL> STUDENT_SESSION_DETAIL { get; set; }
        public virtual DbSet<SUBJECT> SUBJECT { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TRIBE> TRIBE { get; set; }
        public virtual DbSet<USER_MODULE> USER_MODULE { get; set; }
        public virtual DbSet<USER_MODULE_ROLE> USER_MODULE_ROLE { get; set; }
        public virtual DbSet<USER_PAGE_ACTION> USER_PAGE_ACTION { get; set; }
    }
}
