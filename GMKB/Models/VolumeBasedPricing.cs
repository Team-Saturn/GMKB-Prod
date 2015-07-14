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
    
    public partial class VolumeBasedPricing
    {
        public string RecId { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string ParentLink_VRecID { get; set; }
        public Nullable<int> MaxUnits { get; set; }
        public Nullable<int> MinUnits { get; set; }
        public string MinUnits_Valid { get; set; }
        public string Territory { get; set; }
        public string Territory_Valid { get; set; }
        public string TypeOfCurrency { get; set; }
        public string TypeOfCurrency_Valid { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string Pricing { get; set; }
        public string Pricing_Valid { get; set; }
        public string Instruction { get; set; }
        public string CURRENCYCODE { get; set; }
        public string PrimaryCurrencyCode { get; set; }
        public Nullable<decimal> m_Amount__TCV { get; set; }
        public Nullable<decimal> m_Amount__PCV { get; set; }
    }
}
