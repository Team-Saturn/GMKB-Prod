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
    
    public partial class Message
    {
        public string MessageType { get; set; }
        public string RecId { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Body { get; set; }
        public string CcAddress { get; set; }
        public string FromAddress { get; set; }
        public string Subject { get; set; }
        public string ToAddress { get; set; }
        public string Notes { get; set; }
        public string BccAddress { get; set; }
        public string OpportunityLink_RecID { get; set; }
        public string OpportunityLink_Category { get; set; }
        public string OpportunityLink_VRecID { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string ParentLink_VRecID { get; set; }
        public Nullable<bool> NewAnnouncement { get; set; }
    }
}
