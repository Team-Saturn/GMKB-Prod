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
    
    public partial class Campaign
    {
        public string RecId { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Status_Valid { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string EndDate_Valid { get; set; }
        public string OwnerType { get; set; }
        public string Owner { get; set; }
        public string Owner_Valid { get; set; }
        public string OwnerTeam { get; set; }
        public string CampaignType { get; set; }
        public string CampaignType_Valid { get; set; }
        public string DisplayName { get; set; }
        public string Target { get; set; }
        public string Target_Valid { get; set; }
        public Nullable<decimal> EstimatedSizeOfCampaign { get; set; }
        public Nullable<short> ExpectedResponseRate { get; set; }
        public Nullable<short> ExpectedConversionRate { get; set; }
        public Nullable<short> ExpectedGrossMargin { get; set; }
        public Nullable<bool> IndefiniteDuration { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> ExpectedROI { get; set; }
        public string CampaignID { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string KeyCodeType { get; set; }
        public string KeyCodeType_Valid { get; set; }
        public string CURRENCYCODE { get; set; }
        public string CURRENCYCODE_Valid { get; set; }
        public Nullable<bool> Tracking { get; set; }
        public string LoginID { get; set; }
        public string PrimaryCurrencyCode { get; set; }
        public Nullable<decimal> m_ExpectedSalesPerConvers__TCV { get; set; }
        public Nullable<decimal> m_ExpectedSalesPerConvers__PCV { get; set; }
        public Nullable<decimal> m_EstimatedCost__TCV { get; set; }
        public Nullable<decimal> m_EstimatedCost__PCV { get; set; }
        public Nullable<decimal> m_ExpectedSales__TCV { get; set; }
        public Nullable<decimal> m_ExpectedSales__PCV { get; set; }
        public Nullable<decimal> m_ExpectedGrossProfit__TCV { get; set; }
        public Nullable<decimal> m_ExpectedGrossProfit__PCV { get; set; }
        public Nullable<bool> ActiveCampaign { get; set; }
        public string PhoneNumber { get; set; }
        public string ProgramLink_RecID { get; set; }
        public string ProgramLink_Category { get; set; }
        public string ProgramLink_VRecID { get; set; }
        public string ActivateCampaignLinking { get; set; }
    }
}
