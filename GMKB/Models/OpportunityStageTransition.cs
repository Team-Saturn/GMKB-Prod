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
    
    public partial class OpportunityStageTransition
    {
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string GeographyName { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public Nullable<decimal> NeedsAnalysis { get; set; }
        public Nullable<decimal> Negotiation { get; set; }
        public string OpportunityName { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string ParentLink_VRecID { get; set; }
        public Nullable<decimal> ProposalRequested { get; set; }
        public Nullable<decimal> Qualified { get; set; }
        public string RecId { get; set; }
        public string RegionName { get; set; }
        public string TerritoryName { get; set; }
    }
}