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
    
    public partial class HOSTEL_PROGRAMME_ACCESS
    {
        public int HostelProgrammeAccessId { get; set; }
        public int HostelId { get; set; }
        public int ProgrammeId { get; set; }
        public int SessionId { get; set; }
        public int SemesterId { get; set; }
    
        public virtual HOSTEL HOSTEL { get; set; }
        public virtual PROGRAMME PROGRAMME { get; set; }
        public virtual SEMESTER SEMESTER { get; set; }
        public virtual SESSION SESSION { get; set; }
    }
}