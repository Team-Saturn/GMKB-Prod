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
    
    public partial class Notification
    {
        public string RecId { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string Body { get; set; }
        public string EmailAddressList { get; set; }
        public string ErrorDesc { get; set; }
        public string FromLink_RecID { get; set; }
        public string FromLink_Category { get; set; }
        public string Priority { get; set; }
        public string Priority_Valid { get; set; }
        public string Status { get; set; }
        public string Status_Valid { get; set; }
        public string Subject { get; set; }
        public string Transport { get; set; }
        public string EmailAddressCC { get; set; }
        public string EmailAddressBCC { get; set; }
        public string FromEmployeeRecID { get; set; }
        public string BodyFormat { get; set; }
        public string BodyFormat_Valid { get; set; }
        public string FromAddress { get; set; }
    }
}
