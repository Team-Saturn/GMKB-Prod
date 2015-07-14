﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    //dbcontex file listing 7-12
    
    public partial class SaturnEntities : DbContext
    {
        public SaturnEntities()
            : base("name=SaturnEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountIndustry> AccountIndustries { get; set; }
        public virtual DbSet<AccountOrder> AccountOrders { get; set; }
        public virtual DbSet<AccountServiceContractAggr> AccountServiceContractAggrs { get; set; }
        public virtual DbSet<AccountStatu> AccountStatus { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<ActivityLocation> ActivityLocations { get; set; }
        public virtual DbSet<ActivityPriority> ActivityPriorities { get; set; }
        public virtual DbSet<ActivityPurpose> ActivityPurposes { get; set; }
        public virtual DbSet<ActivityResult> ActivityResults { get; set; }
        public virtual DbSet<ActivityStatu> ActivityStatus { get; set; }
        public virtual DbSet<ActivityType> ActivityTypes { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressCountry> AddressCountries { get; set; }
        public virtual DbSet<AddressLocale> AddressLocales { get; set; }
        public virtual DbSet<AddressPurpose> AddressPurposes { get; set; }
        public virtual DbSet<AddressState> AddressStates { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<AggrOpptyStageTransition> AggrOpptyStageTransitions { get; set; }
        public virtual DbSet<AggrSalesRepDiscount> AggrSalesRepDiscounts { get; set; }
        public virtual DbSet<AlternatePricing> AlternatePricings { get; set; }
        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<AuditHistory> AuditHistories { get; set; }
        public virtual DbSet<AverageDealSize> AverageDealSizes { get; set; }
        public virtual DbSet<BundleItem> BundleItems { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<CampaignCategory> CampaignCategories { get; set; }
        public virtual DbSet<CampaignCategory1> CampaignCategories1 { get; set; }
        public virtual DbSet<CampaignKeyCode> CampaignKeyCodes { get; set; }
        public virtual DbSet<CampaignOverview> CampaignOverviews { get; set; }
        public virtual DbSet<CampaignStatu> CampaignStatus { get; set; }
        public virtual DbSet<CampaignTarget> CampaignTargets { get; set; }
        public virtual DbSet<CampaignTask> CampaignTasks { get; set; }
        public virtual DbSet<CampaignTaskNotificationConfig> CampaignTaskNotificationConfigs { get; set; }
        public virtual DbSet<CampaignTemplate> CampaignTemplates { get; set; }
        public virtual DbSet<CampaignType> CampaignTypes { get; set; }
        public virtual DbSet<CaseCategory> CaseCategories { get; set; }
        public virtual DbSet<CaseCauseCode> CaseCauseCodes { get; set; }
        public virtual DbSet<CaseCaus> CaseCauses { get; set; }
        public virtual DbSet<CaseResolutionCategory> CaseResolutionCategories { get; set; }
        public virtual DbSet<Case> Cases { get; set; }
        public virtual DbSet<CaseSource> CaseSources { get; set; }
        public virtual DbSet<CaseStatu> CaseStatus { get; set; }
        public virtual DbSet<CaseType> CaseTypes { get; set; }
        public virtual DbSet<Cell> Cells { get; set; }
        public virtual DbSet<CertificatePrerequisite> CertificatePrerequisites { get; set; }
        public virtual DbSet<Certification> Certifications { get; set; }
        public virtual DbSet<CompetitionRating> CompetitionRatings { get; set; }
        public virtual DbSet<CompetitionStatu> CompetitionStatus { get; set; }
        public virtual DbSet<Competitor> Competitors { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactSource> ContactSources { get; set; }
        public virtual DbSet<ContactType> ContactTypes { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<ContractTab> ContractTabs { get; set; }
        public virtual DbSet<ContractType> ContractTypes { get; set; }
        public virtual DbSet<CurrencyCode> CurrencyCodes { get; set; }
        public virtual DbSet<CurrencySymbol> CurrencySymbols { get; set; }
        public virtual DbSet<DebitCardInstantIssue> DebitCardInstantIssues { get; set; }
        public virtual DbSet<DepositPlatform> DepositPlatforms { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<DiscountType> DiscountTypes { get; set; }
        public virtual DbSet<DracoActivity> DracoActivities { get; set; }
        public virtual DbSet<DracoActivityFactory> DracoActivityFactories { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<EmailFormat> EmailFormats { get; set; }
        public virtual DbSet<EmployeeForecastEmp> EmployeeForecastEmps { get; set; }
        public virtual DbSet<EmployeeForecastTerritory> EmployeeForecastTerritories { get; set; }
        public virtual DbSet<EmployeeOpptyTerritory> EmployeeOpptyTerritories { get; set; }
        public virtual DbSet<EmployeeQuotaEmployee> EmployeeQuotaEmployees { get; set; }
        public virtual DbSet<EmployeeQuotaTerritory> EmployeeQuotaTerritories { get; set; }
        public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }
        public virtual DbSet<FMgmtDashBoard> FMgmtDashBoards { get; set; }
        public virtual DbSet<Forecast> Forecasts { get; set; }
        public virtual DbSet<ForecastAdjustment> ForecastAdjustments { get; set; }
        public virtual DbSet<ForecastStatu> ForecastStatus { get; set; }
        public virtual DbSet<FusionAppDefDelete> FusionAppDefDeletes { get; set; }
        public virtual DbSet<FusionAppDef> FusionAppDefs { get; set; }
        public virtual DbSet<FusionApplication> FusionApplications { get; set; }
        public virtual DbSet<FusionAsd> FusionAsds { get; set; }
        public virtual DbSet<FusionAttachment> FusionAttachments { get; set; }
        public virtual DbSet<FusionBusProc> FusionBusProcs { get; set; }
        public virtual DbSet<FusionCounterRanx> FusionCounterRanges { get; set; }
        public virtual DbSet<FusionCounter> FusionCounters { get; set; }
        public virtual DbSet<FusionDefDelete> FusionDefDeletes { get; set; }
        public virtual DbSet<FusionDef> FusionDefs { get; set; }
        public virtual DbSet<FusionDictionary> FusionDictionaries { get; set; }
        public virtual DbSet<FusionImage> FusionImages { get; set; }
        public virtual DbSet<FusionLink> FusionLinks { get; set; }
        public virtual DbSet<FusionQueryGroup> FusionQueryGroups { get; set; }
        public virtual DbSet<FusionQuickAction> FusionQuickActions { get; set; }
        public virtual DbSet<FusionReport> FusionReports { get; set; }
        public virtual DbSet<FusionSecMap> FusionSecMaps { get; set; }
        public virtual DbSet<FusionSessionTracker> FusionSessionTrackers { get; set; }
        public virtual DbSet<FusionSetting> FusionSettings { get; set; }
        public virtual DbSet<FusionUpdatePackage> FusionUpdatePackages { get; set; }
        public virtual DbSet<FusionUser> FusionUsers { get; set; }
        public virtual DbSet<FusionVersion> FusionVersions { get; set; }
        public virtual DbSet<GA_AlertHist> GA_AlertHist { get; set; }
        public virtual DbSet<GA_Alerts> GA_Alerts { get; set; }
        public virtual DbSet<GA_Settings> GA_Settings { get; set; }
        public virtual DbSet<Influencer> Influencers { get; set; }
        public virtual DbSet<InfluencerRating> InfluencerRatings { get; set; }
        public virtual DbSet<InfluencerResponseMode> InfluencerResponseModes { get; set; }
        public virtual DbSet<Influencer1> Influencers1 { get; set; }
        public virtual DbSet<InfluencerType> InfluencerTypes { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<IssueStatu> IssueStatus { get; set; }
        public virtual DbSet<JobClass> JobClasses { get; set; }
        public virtual DbSet<JobTitile> JobTitiles { get; set; }
        public virtual DbSet<Lead> Leads { get; set; }
        public virtual DbSet<LeadCategory> LeadCategories { get; set; }
        public virtual DbSet<LeadCompanySize> LeadCompanySizes { get; set; }
        public virtual DbSet<LeadQualQuestion> LeadQualQuestions { get; set; }
        public virtual DbSet<LeadRoutingConfiguration> LeadRoutingConfigurations { get; set; }
        public virtual DbSet<LeadSource> LeadSources { get; set; }
        public virtual DbSet<LeadStatu> LeadStatus { get; set; }
        public virtual DbSet<LeadStatusforEmployee> LeadStatusforEmployees { get; set; }
        public virtual DbSet<LeadTimeToPurchase> LeadTimeToPurchases { get; set; }
        public virtual DbSet<LoanPlatform> LoanPlatforms { get; set; }
        public virtual DbSet<MailingList> MailingLists { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<MarketingListMember> MarketingListMembers { get; set; }
        public virtual DbSet<MarketSegment> MarketSegments { get; set; }
        public virtual DbSet<McM_Charter_Code> McM_Charter_Code { get; set; }
        public virtual DbSet<McM_Core_Type> McM_Core_Type { get; set; }
        public virtual DbSet<McM_ProductTab> McM_ProductTab { get; set; }
        public virtual DbSet<McMAccountManager> McMAccountManagers { get; set; }
        public virtual DbSet<McMBankMapping> McMBankMappings { get; set; }
        public virtual DbSet<McMBankPerformance> McMBankPerformances { get; set; }
        public virtual DbSet<McMBankVisitReport> McMBankVisitReports { get; set; }
        public virtual DbSet<McMBugzilla> McMBugzillas { get; set; }
        public virtual DbSet<McMBugzillaComponent> McMBugzillaComponents { get; set; }
        public virtual DbSet<McMBugzillaProduct> McMBugzillaProducts { get; set; }
        public virtual DbSet<McMCategory> McMCategories { get; set; }
        public virtual DbSet<McMProcessEvent> McMProcessEvents { get; set; }
        public virtual DbSet<McMProduct> McMProducts { get; set; }
        public virtual DbSet<McMReleaseVersion> McMReleaseVersions { get; set; }
        public virtual DbSet<McMType> McMTypes { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MessageType> MessageTypes { get; set; }
        public virtual DbSet<Methodology> Methodologies { get; set; }
        public virtual DbSet<Month_Valid> Month_Valid { get; set; }
        public virtual DbSet<NAICSCode> NAICSCodes { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<NoteType> NoteTypes { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationStatu> NotificationStatus { get; set; }
        public virtual DbSet<Offering> Offerings { get; set; }
        public virtual DbSet<Opportunity> Opportunities { get; set; }
        public virtual DbSet<OpportunityAlertConfiguration> OpportunityAlertConfigurations { get; set; }
        public virtual DbSet<OpportunityCode> OpportunityCodes { get; set; }
        public virtual DbSet<OpportunityLeadRating> OpportunityLeadRatings { get; set; }
        public virtual DbSet<OpportunityProductLine> OpportunityProductLines { get; set; }
        public virtual DbSet<OpportunityProductType> OpportunityProductTypes { get; set; }
        public virtual DbSet<OpportunitySource> OpportunitySources { get; set; }
        public virtual DbSet<OpportunityStageTransition> OpportunityStageTransitions { get; set; }
        public virtual DbSet<OpportunityStatu> OpportunityStatus { get; set; }
        public virtual DbSet<OpportunityTemplate> OpportunityTemplates { get; set; }
        public virtual DbSet<OpptyProduct> OpptyProducts { get; set; }
        public virtual DbSet<Ownership> Ownerships { get; set; }
        public virtual DbSet<PainPoint> PainPoints { get; set; }
        public virtual DbSet<PainPoint_Valid> PainPoint_Valid { get; set; }
        public virtual DbSet<Partner> Partners { get; set; }
        public virtual DbSet<PartnerCertification> PartnerCertifications { get; set; }
        public virtual DbSet<PartnerContact> PartnerContacts { get; set; }
        public virtual DbSet<PartnerContract> PartnerContracts { get; set; }
        public virtual DbSet<PartnerLevel> PartnerLevels { get; set; }
        public virtual DbSet<PartnerMargin> PartnerMargins { get; set; }
        public virtual DbSet<PartnerStatu> PartnerStatus { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PermissionStatu> PermissionStatus { get; set; }
        public virtual DbSet<Pricing> Pricings { get; set; }
        public virtual DbSet<PricingInstruction> PricingInstructions { get; set; }
        public virtual DbSet<PricingType> PricingTypes { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<ProductACH> ProductACHes { get; set; }
        public virtual DbSet<ProductALM> ProductALMs { get; set; }
        public virtual DbSet<ProductATM> ProductATMs { get; set; }
        public virtual DbSet<ProductBillPay> ProductBillPays { get; set; }
        public virtual DbSet<ProductBranchCapture> ProductBranchCaptures { get; set; }
        public virtual DbSet<ProductBSA> ProductBSAs { get; set; }
        public virtual DbSet<ProductBSAUDIT> ProductBSAUDITs { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductCheckImageSystem> ProductCheckImageSystems { get; set; }
        public virtual DbSet<ProductCheckRecovery> ProductCheckRecoveries { get; set; }
        public virtual DbSet<ProductCheckWriter> ProductCheckWriters { get; set; }
        public virtual DbSet<ProductCIP> ProductCIPs { get; set; }
        public virtual DbSet<ProductCllReport> ProductCllReports { get; set; }
        public virtual DbSet<ProductCommline> ProductCommlines { get; set; }
        public virtual DbSet<ProductCRInterface> ProductCRInterfaces { get; set; }
        public virtual DbSet<ProductCRM> ProductCRMs { get; set; }
        public virtual DbSet<ProductCVCAL> ProductCVCALs { get; set; }
        public virtual DbSet<ProductDebitCard> ProductDebitCards { get; set; }
        public virtual DbSet<ProductDeposit> ProductDeposits { get; set; }
        public virtual DbSet<ProductDisasterCommLine> ProductDisasterCommLines { get; set; }
        public virtual DbSet<ProductDLinksCreditTracking> ProductDLinksCreditTrackings { get; set; }
        public virtual DbSet<ProductDocumentStorage> ProductDocumentStorages { get; set; }
        public virtual DbSet<ProductDRService> ProductDRServices { get; set; }
        public virtual DbSet<ProductEmailStatement> ProductEmailStatements { get; set; }
        public virtual DbSet<ProductEnotice> ProductEnotices { get; set; }
        public virtual DbSet<ProductEsafeBrand> ProductEsafeBrands { get; set; }
        public virtual DbSet<ProductFinCEN> ProductFinCENs { get; set; }
        public virtual DbSet<ProductHotSite> ProductHotSites { get; set; }
        public virtual DbSet<ProductIMarketingSub> ProductIMarketingSubs { get; set; }
        public virtual DbSet<ProductIMobileApp> ProductIMobileApps { get; set; }
        public virtual DbSet<ProductInt> ProductInts { get; set; }
        public virtual DbSet<ProductIntCashMgmt> ProductIntCashMgmts { get; set; }
        public virtual DbSet<ProductIntDesign> ProductIntDesigns { get; set; }
        public virtual DbSet<ProductInternet> ProductInternets { get; set; }
        public virtual DbSet<ProductIntPositivePay> ProductIntPositivePays { get; set; }
        public virtual DbSet<ProductIntProvider> ProductIntProviders { get; set; }
        public virtual DbSet<ProductIPFM> ProductIPFMs { get; set; }
        public virtual DbSet<ProductLine> ProductLines { get; set; }
        public virtual DbSet<ProductLoanPricing> ProductLoanPricings { get; set; }
        public virtual DbSet<ProductLoansPlu> ProductLoansPlus { get; set; }
        public virtual DbSet<ProductMerchantCapture> ProductMerchantCaptures { get; set; }
        public virtual DbSet<ProductMerchService> ProductMerchServices { get; set; }
        public virtual DbSet<ProductMLAlert> ProductMLAlerts { get; set; }
        public virtual DbSet<ProductMobileBanking> ProductMobileBankings { get; set; }
        public virtual DbSet<ProductMSIStatement> ProductMSIStatements { get; set; }
        public virtual DbSet<ProductNetAudit> ProductNetAudits { get; set; }
        public virtual DbSet<ProductNetBackup> ProductNetBackups { get; set; }
        public virtual DbSet<ProductNetManagement> ProductNetManagements { get; set; }
        public virtual DbSet<ProductOFAC> ProductOFACs { get; set; }
        public virtual DbSet<ProductOriginationACH> ProductOriginationACHes { get; set; }
        public virtual DbSet<ProductPCEncryption> ProductPCEncryptions { get; set; }
        public virtual DbSet<ProductPinnedPOS> ProductPinnedPOS { get; set; }
        public virtual DbSet<ProductPrft> ProductPrfts { get; set; }
        public virtual DbSet<ProductProfitability> ProductProfitabilities { get; set; }
        public virtual DbSet<ProductRealtimeDenial> ProductRealtimeDenials { get; set; }
        public virtual DbSet<ProductRegCC> ProductRegCCs { get; set; }
        public virtual DbSet<ProductRemittanceProcessing> ProductRemittanceProcessings { get; set; }
        public virtual DbSet<ProductRewardsChecking> ProductRewardsCheckings { get; set; }
        public virtual DbSet<ProductSecAudit> ProductSecAudits { get; set; }
        public virtual DbSet<ProductSecureEm> ProductSecureEms { get; set; }
        public virtual DbSet<ProductStatu> ProductStatus { get; set; }
        public virtual DbSet<ProductStmtPrint> ProductStmtPrints { get; set; }
        public virtual DbSet<ProductSupp> ProductSupps { get; set; }
        public virtual DbSet<ProductTeller> ProductTellers { get; set; }
        public virtual DbSet<ProductTrain> ProductTrains { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<ProductUnxBkup> ProductUnxBkups { get; set; }
        public virtual DbSet<ProductVenMgmt> ProductVenMgmts { get; set; }
        public virtual DbSet<ProductVoice> ProductVoices { get; set; }
        public virtual DbSet<ProductWebAudit> ProductWebAudits { get; set; }
        public virtual DbSet<ProductWre> ProductWres { get; set; }
        public virtual DbSet<ProfileDegree> ProfileDegrees { get; set; }
        public virtual DbSet<ProfileDepartment> ProfileDepartments { get; set; }
        public virtual DbSet<ProfilePrefix> ProfilePrefixes { get; set; }
        public virtual DbSet<ProfileStatu> ProfileStatus { get; set; }
        public virtual DbSet<ProfileSuffix> ProfileSuffixes { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<ProgramLevel> ProgramLevels { get; set; }
        public virtual DbSet<QualQuestionAnswer> QualQuestionAnswers { get; set; }
        public virtual DbSet<QualQuestion> QualQuestions { get; set; }
        public virtual DbSet<Quarter_Valid> Quarter_Valid { get; set; }
        public virtual DbSet<QueuedUpdate> QueuedUpdates { get; set; }
        public virtual DbSet<Quota> Quotas { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<QuoteApprovalConfiguration> QuoteApprovalConfigurations { get; set; }
        public virtual DbSet<QuoteStatu> QuoteStatus { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<ReasonCode> ReasonCodes { get; set; }
        public virtual DbSet<RecurringRevenue> RecurringRevenues { get; set; }
        public virtual DbSet<RecurringRevenueByTerritory> RecurringRevenueByTerritories { get; set; }
        public virtual DbSet<Referral> Referrals { get; set; }
        public virtual DbSet<ReferralType> ReferralTypes { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Response> Responses { get; set; }
        public virtual DbSet<RevenueType> RevenueTypes { get; set; }
        public virtual DbSet<RMA> RMAs { get; set; }
        public virtual DbSet<RMAReason> RMAReasons { get; set; }
        public virtual DbSet<SalesActivity> SalesActivities { get; set; }
        public virtual DbSet<SalesTerritory> SalesTerritories { get; set; }
        public virtual DbSet<ScheduledJob> ScheduledJobs { get; set; }
        public virtual DbSet<ScheduledJobHistory> ScheduledJobHistories { get; set; }
        public virtual DbSet<Seed> Seeds { get; set; }
        public virtual DbSet<Segment> Segments { get; set; }
        public virtual DbSet<ServerInformation> ServerInformations { get; set; }
        public virtual DbSet<ServiceContract> ServiceContracts { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Stage> Stages { get; set; }
        public virtual DbSet<StandardForecast> StandardForecasts { get; set; }
        public virtual DbSet<StandardUserTeam> StandardUserTeams { get; set; }
        public virtual DbSet<Subscription> Subscriptions { get; set; }
        public virtual DbSet<SubscriptionDestination> SubscriptionDestinations { get; set; }
        public virtual DbSet<SuppressionList> SuppressionLists { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamMember> TeamMembers { get; set; }
        public virtual DbSet<TeamMemberRole> TeamMemberRoles { get; set; }
        public virtual DbSet<Territory> Territories { get; set; }
        public virtual DbSet<TerritoryPricing> TerritoryPricings { get; set; }
        public virtual DbSet<TimeUnit> TimeUnits { get; set; }
        public virtual DbSet<UserPresence> UserPresences { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorStatu> VendorStatus { get; set; }
        public virtual DbSet<VolumeBasedPricing> VolumeBasedPricings { get; set; }
        public virtual DbSet<ConfigOpportunityProductLine> ConfigOpportunityProductLines { get; set; }
        public virtual DbSet<GA_DepartmentReports> GA_DepartmentReports { get; set; }
        public virtual DbSet<McM_AuditHistory> McM_AuditHistory { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
    }
}
