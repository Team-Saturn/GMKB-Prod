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
    
    public partial class Territory
    {
        public string RecId { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Territory1 { get; set; }
        public string ParentTerritoryLink_RecID { get; set; }
        public string ParentTerritoryLink_Category { get; set; }
        public string ParentTerritoryName { get; set; }
        public string LeadRecipient { get; set; }
        public Nullable<bool> ParentTerritoryNotEqual { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string LeadRecipientLink_RecID { get; set; }
        public string LeadRecipientLink_Category { get; set; }
        public string LeadRecipientLink_VRecID { get; set; }
        public string QuoteApprovalAuthori_RecID { get; set; }
        public string QuoteApprovalAuthori_Category { get; set; }
        public string QuoteApprovalAuthori_VRecID { get; set; }
        public string QuoteApprovalAuthority { get; set; }
        public Nullable<int> Hierarchy_Left { get; set; }
        public Nullable<int> Hierarchy_Right { get; set; }
    }
}
