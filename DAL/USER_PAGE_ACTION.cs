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
    
    public partial class USER_PAGE_ACTION
    {
        public int UserPageAction { get; set; }
        public int UserModuled { get; set; }
        public int PageActionId { get; set; }
        public System.DateTime DateAdded { get; set; }
    
        public virtual PAGE_ACTION PAGE_ACTION { get; set; }
        public virtual USER_MODULE USER_MODULE { get; set; }
    }
}
