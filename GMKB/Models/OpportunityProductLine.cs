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
    
    public partial class OpportunityProductLine
    {
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LineItem { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string ParentLink_VRecID { get; set; }
        public string PrimaryCurrencyCode { get; set; }
        public string RecId { get; set; }
        public Nullable<decimal> Revenue1 { get; set; }
        public Nullable<decimal> Revenue1PCV { get; set; }
        public Nullable<decimal> Revenue2 { get; set; }
        public Nullable<decimal> Revenue2PCV { get; set; }
        public Nullable<decimal> Revenue3 { get; set; }
        public Nullable<decimal> Revenue3PCV { get; set; }
        public Nullable<decimal> Revenue4 { get; set; }
        public Nullable<decimal> Revenue4PCV { get; set; }
        public string TransactionCurrencyCode { get; set; }
        public string TransactionCurrencyC_Valid { get; set; }
    }
}