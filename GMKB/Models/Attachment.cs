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
    
    public partial class Attachment
    {
        public string RecID { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string ATTACHNAME { get; set; }
        public string ATTACHDESC { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public string Path { get; set; }
        public string Host { get; set; }
    }
}