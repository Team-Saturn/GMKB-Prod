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
    
    public partial class GA_AlertHist
    {
        public long AlertHistID { get; set; }
        public Nullable<long> AlertID { get; set; }
        public Nullable<long> AlertType { get; set; }
        public Nullable<long> AlertFreq { get; set; }
        public string McM_csi { get; set; }
        public string Email { get; set; }
        public Nullable<short> SentStatus { get; set; }
        public Nullable<System.DateTime> SentDate { get; set; }
        public string McMProduct { get; set; }
        public string McMType { get; set; }
        public string Category { get; set; }
        public Nullable<decimal> DailyDeviation { get; set; }
        public Nullable<decimal> DailyMean { get; set; }
        public Nullable<decimal> DailyCount { get; set; }
        public Nullable<decimal> WeeklyDeviation { get; set; }
        public Nullable<decimal> WeeklyMean { get; set; }
        public Nullable<decimal> WeeklyCount { get; set; }
        public Nullable<decimal> MonthlyDeviation { get; set; }
        public Nullable<decimal> MonthlyMean { get; set; }
        public Nullable<decimal> MonthlyCount { get; set; }
        public Nullable<System.DateTime> LastAlert { get; set; }
    }
}
