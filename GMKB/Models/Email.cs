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
    
    public partial class Email
    {
        public string RecId { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Attachments { get; set; }
        public string BCC { get; set; }
        public string CC { get; set; }
        public string DisplayText { get; set; }
        public string EmailBody { get; set; }
        public string EntryID { get; set; }
        public string FlowDirection { get; set; }
        public string FlowDirection_Valid { get; set; }
        public string FromAddress { get; set; }
        public string Layout { get; set; }
        public string MessageID { get; set; }
        public string OriginalSender { get; set; }
        public Nullable<byte> PriorityNumber { get; set; }
        public Nullable<System.DateTime> ReceivedDateTime { get; set; }
        public Nullable<System.DateTime> SentDateTime { get; set; }
        public string SourceApplication { get; set; }
        public string Subject { get; set; }
        public string ToAddress { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string ParentLink1_RecID { get; set; }
        public string ParentLink1_Category { get; set; }
        public string ExternalID { get; set; }
        public string Category { get; set; }
        public string Category_Valid { get; set; }
        public Nullable<short> AttachmentCount { get; set; }
        public Nullable<bool> HasAttachment { get; set; }
        public string MailListLink_RecID { get; set; }
        public string MailListLink_Category { get; set; }
        public string MailListLink_VRecID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactFullName { get; set; }
        public string ContactFullName_Valid { get; set; }
        public string ContactRecID { get; set; }
        public Nullable<bool> IsReadOnly { get; set; }
    }
}
