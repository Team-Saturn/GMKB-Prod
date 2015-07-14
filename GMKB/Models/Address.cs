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
    
    public partial class Address
    {
        public string RecId { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public string AddressType { get; set; }
        public string AddressType_Valid { get; set; }
        public string Purpose { get; set; }
        public string Purpose_Valid { get; set; }
        public string DisplayText { get; set; }
        public string Description { get; set; }
        public string Locale { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<bool> DoNotContact { get; set; }
        public string McM_Bank_ID { get; set; }
        public string Email { get; set; }
        public string Email_Valid { get; set; }
        public string Locale_Valid { get; set; }
        public string PreferredFormat { get; set; }
        public string PreferredFormat_Valid { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string State_Valid { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Country_Valid { get; set; }
        public string McM_Contact_ID { get; set; }
        public string Phone { get; set; }
        public string Ext { get; set; }
        public string WebAddress { get; set; }
    }
}
