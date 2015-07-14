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
    
    public partial class Discount
    {
        public string RecId { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string ParentLink_VRecID { get; set; }
        public string AccountType { get; set; }
        public string AccountType_Valid { get; set; }
        public string Country { get; set; }
        public string Country_Valid { get; set; }
        public string DiscountType { get; set; }
        public string DiscountType_Valid { get; set; }
        public Nullable<decimal> DiscountValue { get; set; }
        public string DiscountValue_Valid { get; set; }
        public string Instructions { get; set; }
        public string OfferingLink_RecID { get; set; }
        public string OfferingLink_Category { get; set; }
        public string OfferingLink_VRecID { get; set; }
        public string PLLink_RecID { get; set; }
        public string PLLink_Category { get; set; }
        public string PLLink_VRecID { get; set; }
        public string Territory { get; set; }
        public string Territory_Valid { get; set; }
        public string TypeOfCurrency { get; set; }
        public string TypeOfCurrency_Valid { get; set; }
        public Nullable<bool> UseAccountType { get; set; }
        public Nullable<bool> UseCountry { get; set; }
        public Nullable<bool> UseTerritory { get; set; }
        public string CURRENCYCODE { get; set; }
        public string CURRENCYCODE_Valid { get; set; }
        public Nullable<decimal> DiscountValuePct { get; set; }
        public string DiscountValuePct_Valid { get; set; }
        public Nullable<bool> ShowDiscountPct { get; set; }
        public string PrimaryCurrencyCode { get; set; }
        public Nullable<decimal> m_DiscountValue__TCV { get; set; }
        public Nullable<decimal> m_DiscountValue__PCV { get; set; }
        public Nullable<bool> ShowDiscountAmt { get; set; }
    }
}
