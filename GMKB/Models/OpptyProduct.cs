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
    
    public partial class OpptyProduct
    {
        public string OpptyProductType { get; set; }
        public string RecId { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string OpportunityLink_RecID { get; set; }
        public string OpportunityLink_Category { get; set; }
        public string OpportunityLink_VRecID { get; set; }
        public string BriefDescription { get; set; }
        public string LineItemName { get; set; }
        public string QuoteNo_LnkKey { get; set; }
        public string CURRENCYCODE { get; set; }
        public Nullable<bool> IsOptional { get; set; }
        public Nullable<bool> IsDiscountPercentage { get; set; }
        public Nullable<bool> IsServiceType { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Quantity_Valid { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string ParentLink_VRecID { get; set; }
        public string AccountLink_RecID { get; set; }
        public string AccountLink_Category { get; set; }
        public string AccountLink_VRecID { get; set; }
        public string PrimaryCurrencyCode { get; set; }
        public Nullable<decimal> ExtendedPrice__TCV { get; set; }
        public Nullable<decimal> ExtendedPrice__PCV { get; set; }
        public Nullable<decimal> QuotedTotal__TCV { get; set; }
        public Nullable<decimal> QuotedTotal__PCV { get; set; }
        public Nullable<decimal> DiscountPerUnit__TCV { get; set; }
        public Nullable<decimal> DiscountPerUnit__PCV { get; set; }
        public Nullable<decimal> ListPrice__TCV { get; set; }
        public Nullable<decimal> ListPrice__PCV { get; set; }
        public Nullable<decimal> QuotedUnitPrice__TCV { get; set; }
        public Nullable<decimal> QuotedUnitPrice__PCV { get; set; }
        public Nullable<decimal> TaxAmountActual__TCV { get; set; }
        public Nullable<decimal> TaxAmountActual__PCV { get; set; }
        public string AccountOrderLink_RecID { get; set; }
        public string AccountOrderLink_Category { get; set; }
        public string AccountOrderLink_VRecID { get; set; }
        public Nullable<byte> GeographyCode { get; set; }
        public string GeographyName { get; set; }
        public Nullable<int> HierarchyID { get; set; }
        public Nullable<byte> RegionCode { get; set; }
        public string RegionName { get; set; }
        public Nullable<byte> TerritoryCode { get; set; }
        public string TerritoryName { get; set; }
        public string OpportunityOwnerName { get; set; }
        public Nullable<decimal> DiscountPerUnitPercentage { get; set; }
        public Nullable<bool> Taxable { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public string OfferingLink_RecID { get; set; }
        public string OfferingLink_Category { get; set; }
        public string OfferingLink_VRecID { get; set; }
        public Nullable<bool> Recurring { get; set; }
        public string Manufacturer { get; set; }
        public string ProductCode { get; set; }
        public string ProductLine { get; set; }
        public string ProductSKU { get; set; }
        public string Frequency { get; set; }
        public string Frequency_Valid { get; set; }
        public string Category2 { get; set; }
        public string Category2_Valid { get; set; }
        public string Status2 { get; set; }
        public string Status2_Valid { get; set; }
        public string ProductType2 { get; set; }
        public string ProductType2_Valid { get; set; }
        public string DiscountType { get; set; }
        public Nullable<decimal> TaxAmount__TCV { get; set; }
        public Nullable<decimal> TaxAmount__PCV { get; set; }
        public Nullable<decimal> TaxManual__TCV { get; set; }
        public Nullable<decimal> TaxManual__PCV { get; set; }
        public string RevenueType { get; set; }
        public string RevenueType_Valid { get; set; }
        public Nullable<decimal> QuoteDiscountPercent { get; set; }
        public Nullable<decimal> QuoteDiscount__TCV { get; set; }
        public Nullable<decimal> QuoteDiscount__PCV { get; set; }
        public string AccountName_Valid { get; set; }
        public string BriefDescription_Valid { get; set; }
        public string Category { get; set; }
        public string Category_Valid { get; set; }
        public string DiscountAccountCountry { get; set; }
        public string DiscountAccountTerritory { get; set; }
        public string DiscountAccountType { get; set; }
        public string DiscountAccountType_Valid { get; set; }
        public string IsDiscountPercentage_Valid { get; set; }
        public Nullable<bool> IsIncrementalVBP { get; set; }
        public string IsIncrementalVBP_Valid { get; set; }
        public string IsOptional_Valid { get; set; }
        public string IsServiceType_Valid { get; set; }
        public Nullable<bool> IsVolumeBasedPricing { get; set; }
        public string IsVolumeBasedPricing_Valid { get; set; }
        public string OpportunityName_Valid { get; set; }
        public string PricingMethod { get; set; }
        public string ProductLine_Valid { get; set; }
        public string ProductLineRecId { get; set; }
        public string ProductLineRecId_Valid { get; set; }
        public string ProductType { get; set; }
        public string ProductType_Valid { get; set; }
        public string Status { get; set; }
        public string Status_Valid { get; set; }
        public Nullable<decimal> Cost__TCV { get; set; }
        public string CostTCV_Valid { get; set; }
        public Nullable<decimal> Cost__PCV { get; set; }
        public string ExtendedPriceTCV_Valid { get; set; }
        public string DiscountPerUnitTCV_Valid { get; set; }
        public string ListPriceTCV_Valid { get; set; }
        public Nullable<decimal> MSRP__TCV { get; set; }
        public string MSRPTCV_Valid { get; set; }
        public Nullable<decimal> MSRP__PCV { get; set; }
        public string QuotedTotalTCV_Valid { get; set; }
        public string QuotedUnitPriceTCV_Valid { get; set; }
        public string TaxAmountTCV_Valid { get; set; }
        public string TaxAmountActualTCV_Valid { get; set; }
        public string TaxManualTCV_Valid { get; set; }
        public Nullable<bool> IsValidCurrencyCode { get; set; }
        public string TextMessage_Valid { get; set; }
        public Nullable<decimal> mTotalDiscountPCV { get; set; }
        public Nullable<decimal> mTotalDiscount { get; set; }
        public Nullable<decimal> mTotalCostPCV { get; set; }
        public Nullable<decimal> mTotalCost { get; set; }
        public Nullable<byte> RecCounter { get; set; }
        public string ForecastYear { get; set; }
        public string ForecastQuarter { get; set; }
        public Nullable<byte> FiscalYearLastMonth { get; set; }
    }
}