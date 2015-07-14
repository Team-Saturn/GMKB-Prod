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
    using System.ComponentModel.DataAnnotations;
    
    public partial class Case
    {
        public string RecId { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string CreatedBy { get; set; }
        public string OwnerType { get; set; }
        public string Owner { get; set; }
        public string Owner_Valid { get; set; }
        public string OwnerTeam { get; set; }
        public string OwnerTeam_Valid { get; set; }
        [Display(Name = "Case Number")]
        public Nullable<decimal> CaseNumber { get; set; }
        public string Status { get; set; }
        public string Status_Valid { get; set; }
        public string Priority { get; set; }
        public string Priority_Valid { get; set; }
        public string CaseType { get; set; }
        public string CaseType_Valid { get; set; }
        public string Category { get; set; }
        public string Category_Valid { get; set; }
        public string Source { get; set; }
        public string Source_Valid { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DueOn { get; set; }
        public string DueOn_Valid { get; set; }
        public string CauseCode { get; set; }
        public string CauseCode_Valid { get; set; }
        public string Resolution { get; set; }
        public string FirstCallResolution { get; set; }
        public string FirstCallResolution_Valid { get; set; }
        public string ResolutionCategory { get; set; }
        public string ResolutionCategory_Valid { get; set; }
        public string ContactLink_RecID { get; set; }
        public string ContactLink_Category { get; set; }
        public string ContactLink_VRecID { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactExt { get; set; }
        public string ClosedBy { get; set; }
        public Nullable<System.DateTime> ClosedDateTime { get; set; }
        public string PrimaryProductLink_RecID { get; set; }
        public string PrimaryProductLink_Category { get; set; }
        public string PrimaryProductLink_VRecID { get; set; }
        public string IPCCContactLink { get; set; }
        public string DisplayName { get; set; }
        public string PrimaryEmail { get; set; }
        public string CaseAccount { get; set; }
        public string EmpLink_RecID { get; set; }
        public string EmpLink_Category { get; set; }
        public string EmpLink_VRecID { get; set; }
        public Nullable<bool> McMAtRisk { get; set; }
        public string McMProduct { get; set; }
        public string McMProduct_Valid { get; set; }
        public string BugzillaProduct { get; set; }
        public string BugzillaComponent { get; set; }
        public Nullable<System.DateTime> McM_AutoClosedDateTime { get; set; }
        public string OwnerEmail { get; set; }
        public string McM_data_center { get; set; }
        public string BugzillaBank { get; set; }
        public Nullable<bool> McM_Anonymous_Flag { get; set; }
        public string McM_Sent_From_Email { get; set; }
        public string McM_Sent_To_Email { get; set; }
        public string Department { get; set; }
        public string Department_Valid { get; set; }
        public string McM_csi { get; set; }
        public string AccountLink_RecID { get; set; }
        public string AccountLink_Category { get; set; }
        public string AccountLink_VRecID { get; set; }
        public string McMGridRowColor { get; set; }
        public Nullable<System.DateTime> McM_DateTime_Active { get; set; }
        public Nullable<System.DateTime> McM_DateTime_InProgress { get; set; }
        [Display(Name = "DateTimeResolved")]
        public Nullable<System.DateTime> McM_DateTime_Resolved { get; set; }
        public Nullable<System.DateTime> McM_DateTime_Closed { get; set; }
        public Nullable<int> McM_Duration_from_Active { get; set; }
        public Nullable<int> McM_Duration_from_Logged { get; set; }
        public Nullable<int> McM_Duration_from_InProgress { get; set; }
        public Nullable<int> McM_Duration_from_Resolved { get; set; }
        public Nullable<System.DateTime> McM_Twenty_Mins_from_Logged { get; set; }
        public Nullable<bool> McM_ML_Connection { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<bool> EOY { get; set; }
        public Nullable<bool> NightCall { get; set; }
        public Nullable<bool> UsedOverride { get; set; }
        public Nullable<bool> MaintCustData { get; set; }
        public Nullable<bool> WebexUsed { get; set; }
        public Nullable<System.DateTime> McM_DateTime_Reopened { get; set; }
        public Nullable<System.DateTime> McM_Twenty_Mins { get; set; }
        public Nullable<bool> McM_Reopened_Flag { get; set; }
        public string McM_Confidential { get; set; }
        public string McM_Note_Alert { get; set; }
        public Nullable<System.DateTime> McM_Fifteen_Mins_from_Logged { get; set; }
        public Nullable<System.DateTime> McM_WaitStatus_Alert { get; set; }
        public string Speed_dial { get; set; }
        public Nullable<bool> McM_SetupTraining { get; set; }
        public Nullable<bool> McM_Twenty_Mins_Logical { get; set; }
        public Nullable<bool> McM_Fifteen_Mins_Logical { get; set; }
        public Nullable<bool> McM_QandD_Logical { get; set; }
        public string McM_QandD_Text { get; set; }
        public Nullable<bool> McM_Secon_Level_Support { get; set; }
        public Nullable<bool> McM_Programming_Assistance { get; set; }
        public Nullable<bool> McM_Training_logical { get; set; }
        public Nullable<bool> McM_Projects_logical { get; set; }
        public Nullable<bool> McM_Verifications_logical { get; set; }
        public Nullable<bool> McM_Deployment_logical { get; set; }
        public string McM_AtRiskReason_Text { get; set; }
        public string McM_Cause { get; set; }
        public string McM_Cause_Valid { get; set; }
        public Nullable<bool> CaseSurveySent { get; set; }
        public Nullable<bool> TransferLogical { get; set; }
        public string McM_BugNumber { get; set; }
        public string McM_BillPay_Customer { get; set; }
        public Nullable<bool> McM_IS_Tech { get; set; }
    }
}
