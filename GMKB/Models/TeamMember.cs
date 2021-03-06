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
    
    public partial class TeamMember
    {
        public string RecId { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string DisplayName { get; set; }
        public string Department { get; set; }
        public string Title { get; set; }
        public string Role { get; set; }
        public string Role_Valid { get; set; }
        public Nullable<bool> ExternalPartner { get; set; }
        public string TeamMemberType { get; set; }
        public string TeamMemberType_Valid { get; set; }
        public string AccountName { get; set; }
        public string ContactName { get; set; }
        public string EmployeeName { get; set; }
        public string AccountLink_RecID { get; set; }
        public string AccountLink_Category { get; set; }
        public string AccountLink_VRecID { get; set; }
        public string ContactLink_RecID { get; set; }
        public string ContactLink_Category { get; set; }
        public string ContactLink_VRecID { get; set; }
        public string EmployeeLink_RecID { get; set; }
        public string EmployeeLink_Category { get; set; }
        public string EmployeeLink_VRecID { get; set; }
        public Nullable<bool> ShowTeamMemberAccount { get; set; }
        public Nullable<bool> ShowTeamMemberContact { get; set; }
        public Nullable<bool> ShowTeamMemberEmployee { get; set; }
        public string AccountDepartment { get; set; }
        public string ContactDepartment { get; set; }
        public string EmployeeDepartment { get; set; }
        public string AccountTitle { get; set; }
        public string ContactTitle { get; set; }
        public string EmployeeTitle { get; set; }
    }
}
