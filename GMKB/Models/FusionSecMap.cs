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
    
    public partial class FusionSecMap
    {
        public string RecID { get; set; }
        public string UserType { get; set; }
        public string LoginID { get; set; }
        public string AuthID { get; set; }
        public string AuthSource { get; set; }
        public string BusObID { get; set; }
        public string BusObName { get; set; }
        public string BusUnitDefID { get; set; }
        public string GroupID { get; set; }
        public string GroupName { get; set; }
        public Nullable<bool> TrackPresence { get; set; }
        public bool Lockout { get; set; }
        public Nullable<System.DateTime> LastLogin { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModUser { get; set; }
    }
}
