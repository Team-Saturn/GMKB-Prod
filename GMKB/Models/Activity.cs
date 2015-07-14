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
    
    public partial class Activity
    {
        public string AccountName { get; set; }
        public string ActivityResult { get; set; }
        public string ActivityResult_Valid { get; set; }
        public string ActivityType { get; set; }
        public string ActivityType_Valid { get; set; }
        public Nullable<int> ActualDemo { get; set; }
        public Nullable<int> ActualDisCall { get; set; }
        public Nullable<int> ActualDisMeet { get; set; }
        public Nullable<int> ActualFace { get; set; }
        public Nullable<int> ActualInbound { get; set; }
        public Nullable<int> ActualLiveEvt { get; set; }
        public Nullable<int> ActualOutbound { get; set; }
        public Nullable<int> ActualPOC { get; set; }
        public Nullable<int> ActualProposal { get; set; }
        public Nullable<int> ActualPtnCall { get; set; }
        public Nullable<int> ActualPtnMeet { get; set; }
        public Nullable<int> ActualTradeShow { get; set; }
        public Nullable<int> ActualUserGrp { get; set; }
        public Nullable<int> ActualWebinar { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public Nullable<System.DateTime> DueDateTime { get; set; }
        public string DueDateTime_Valid { get; set; }
        public string EmployeeFullName { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public string EndDateTime_Valid { get; set; }
        public string EntryID { get; set; }
        public Nullable<byte> FiscalYearLastMonth { get; set; }
        public string ForecastMonth { get; set; }
        public string ForecastQuarter { get; set; }
        public string ForecastWeek { get; set; }
        public string ForecastYear { get; set; }
        public Nullable<byte> GeographyCode { get; set; }
        public string GeographyName { get; set; }
        public string GeographyName_Valid { get; set; }
        public Nullable<int> HierarchyID { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string LeadName { get; set; }
        public string OpportunityName { get; set; }
        public string Owner { get; set; }
        public string Owner_Valid { get; set; }
        public string OwnerTeam { get; set; }
        public string OwnerType { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string ParentName { get; set; }
        public Nullable<int> PlannedDemo { get; set; }
        public Nullable<int> PlannedDisCall { get; set; }
        public Nullable<int> PlannedDisMeet { get; set; }
        public Nullable<int> PlannedFace { get; set; }
        public Nullable<int> PlannedInbound { get; set; }
        public Nullable<int> PlannedLiveEvt { get; set; }
        public Nullable<int> PlannedOutbound { get; set; }
        public Nullable<int> PlannedPOC { get; set; }
        public Nullable<int> PlannedProposal { get; set; }
        public Nullable<int> PlannedPtnCall { get; set; }
        public Nullable<int> PlannedPtnMeet { get; set; }
        public Nullable<int> PlannedTradeShow { get; set; }
        public Nullable<int> PlannedUserGrp { get; set; }
        public Nullable<int> PlannedWebinar { get; set; }
        public string PopulateSalesAcitivyFields { get; set; }
        public string Priority { get; set; }
        public string Priority_Valid { get; set; }
        public string Purpose { get; set; }
        public string Purpose_Valid { get; set; }
        public string RecId { get; set; }
        public Nullable<byte> RegionCode { get; set; }
        public string RegionName { get; set; }
        public string RegionName_Valid { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public string Status { get; set; }
        public string Status_Valid { get; set; }
        public string Subject { get; set; }
        public Nullable<byte> TerritoryCode { get; set; }
        public string TerritoryName { get; set; }
        public string TerritoryName_Valid { get; set; }
        public string ActivityLocation { get; set; }
        public string ActivityLocation_Valid { get; set; }
        public string ExternalCalendarLinkID { get; set; }
        public string Notes { get; set; }
        public Nullable<short> PercentComplete { get; set; }
        public Nullable<short> TimeLength { get; set; }
        public Nullable<bool> AllDayEvent { get; set; }
        public string ConversationIndex { get; set; }
        public Nullable<bool> Reminder { get; set; }
        public Nullable<short> ReminderTime { get; set; }
        public Nullable<System.DateTime> DateRejected { get; set; }
        public Nullable<System.DateTime> DueTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string ExternalTaskLinkID { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
    }
}
