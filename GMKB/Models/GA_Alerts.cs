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
    
    public partial class GA_Alerts
    {
        public long AlertID { get; set; }
        public Nullable<int> Locked { get; set; }
        public string McM_csi { get; set; }
        public Nullable<long> AlertType { get; set; }
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
        public Nullable<System.DateTime> LastDailyAlert { get; set; }
        public Nullable<System.DateTime> LastWeeklyAlert { get; set; }
        public Nullable<System.DateTime> LastMonthlyAlert { get; set; }
        public Nullable<decimal> AlertSD { get; set; }
    }
}