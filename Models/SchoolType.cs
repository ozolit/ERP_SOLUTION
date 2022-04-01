using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_SOLUTION.Models
{
    public class SchoolType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long AddedBy { get; set; }
        public bool IsRemoved { get; set; }
    }
}