//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebRole1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DealTask
    {
        public int id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
        public int status { get; set; }
        public int type { get; set; }
        public int dealID { get; set; }
        public string TaskContent { get; set; }
    
        public virtual Deal Deal { get; set; }
        public virtual TaskStatu TaskStatu { get; set; }
        public virtual TaskType TaskType { get; set; }
    }
}
