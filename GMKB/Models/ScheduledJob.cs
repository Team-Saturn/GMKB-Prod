//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GMKB.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScheduledJob
    {
        public string RecId { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string JobName { get; set; }
        public string JobClass { get; set; }
        public string JobClass_Valid { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public string QueryGroup { get; set; }
        public string JobType { get; set; }
        public string JobData { get; set; }
        public Nullable<System.DateTime> ActiveEndDate { get; set; }
        public Nullable<System.DateTime> ActiveEndTime { get; set; }
        public Nullable<System.DateTime> ActiveStartDate { get; set; }
        public Nullable<System.DateTime> ActiveStartTime { get; set; }
        public Nullable<decimal> FreqInterval { get; set; }
        public Nullable<decimal> FreqType { get; set; }
        public Nullable<bool> IsRecurring { get; set; }
        public Nullable<System.DateTime> NextRunTime { get; set; }
        public string Units { get; set; }
        public string Units_Valid { get; set; }
        public string QueryGroupName { get; set; }
    }
}
