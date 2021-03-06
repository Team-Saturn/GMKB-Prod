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
    
    public partial class QueuedUpdate
    {
        public string RecId { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<int> QueuedUpdateID { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string IncDec { get; set; }
        public string IncDec_Valid { get; set; }
        public string UpdateType { get; set; }
        public string UpdateType_Valid { get; set; }
        public Nullable<short> UpdateValue { get; set; }
        public Nullable<bool> Orderable { get; set; }
        public Nullable<bool> ApplyQueuedUpdate { get; set; }
        public string QueuedUpdateStatus { get; set; }
        public string QueuedUpdateStatus_Valid { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string ParentLink_VRecID { get; set; }
        public Nullable<bool> LinkQueuedUpdate { get; set; }
        public Nullable<short> UpdateValuePct { get; set; }
        public string UpdateValuePct_Valid { get; set; }
        public string PrimaryCurrencyCode { get; set; }
        public string TransactionCurrencyCode { get; set; }
        public string TransactionCurrencyC_Valid { get; set; }
        public Nullable<decimal> mUpdateValuePCV { get; set; }
        public Nullable<decimal> mUpdateValueTCV { get; set; }
        public Nullable<bool> ShowUpdateValue { get; set; }
        public Nullable<bool> ShowUpdateValuePct { get; set; }
        public string Pricing { get; set; }
        public string Pricing_Valid { get; set; }
        public Nullable<short> PricingValuePct { get; set; }
        public Nullable<int> mPricingValuePCV { get; set; }
        public Nullable<int> mPricingValueTCV { get; set; }
        public Nullable<bool> ShowPricingPct { get; set; }
        public Nullable<bool> ShowPricingAmt { get; set; }
        public string PricingText { get; set; }
        public Nullable<bool> ShowPricingValue { get; set; }
    }
}
