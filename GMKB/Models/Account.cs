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
    
    public partial class Account
    {
        public string AccountName { get; set; }
        public string AccountRating { get; set; }
        public string AccountRating_Valid { get; set; }
        public string AccountType { get; set; }
        public string AccountType_Valid { get; set; }
        public Nullable<decimal> AnnualRevenuePCV { get; set; }
        public Nullable<decimal> AnnualRevenueTCV { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string Description { get; set; }
        public string DisplayName { get; set; }
        public string Employees { get; set; }
        public string Employees_Valid { get; set; }
        public Nullable<byte> GeographyCode { get; set; }
        public string GeographyName { get; set; }
        public Nullable<bool> HasOrders { get; set; }
        public Nullable<int> HierarchyID { get; set; }
        public string Industry { get; set; }
        public string Industry_Valid { get; set; }
        public string LastModBy { get; set; }
        public Nullable<System.DateTime> LastModDateTime { get; set; }
        public string MarketSegment { get; set; }
        public string MarketSegment_Valid { get; set; }
        public string NAICSCode { get; set; }
        public string Owner { get; set; }
        public string Owner_Valid { get; set; }
        public string Ownership { get; set; }
        public string Ownership_Valid { get; set; }
        public string OwnerTeam { get; set; }
        public string OwnerType { get; set; }
        public string ParentAccountLink_RecID { get; set; }
        public string ParentAccountLink_Category { get; set; }
        public string ParentAccountLink_VRecID { get; set; }
        public string ParentAccountName { get; set; }
        public Nullable<bool> ParentAccountNotEqual { get; set; }
        public string ParentLink_RecID { get; set; }
        public string ParentLink_Category { get; set; }
        public string ParentLink_VRecID { get; set; }
        public string PhoneLink_RecID { get; set; }
        public string PhoneLink_Category { get; set; }
        public string PhoneLink_VRecID { get; set; }
        public string PreferredMethodContact { get; set; }
        public string PreferredMethodConta_Valid { get; set; }
        public string PrimaryAddressLink_RecID { get; set; }
        public string PrimaryAddressLink_Category { get; set; }
        public string PrimaryAddressLink_VRecID { get; set; }
        public string PrimaryContactLink_RecID { get; set; }
        public string PrimaryContactLink_Category { get; set; }
        public string PrimaryContactLink_VRecID { get; set; }
        public string PrimaryCurrencyCode { get; set; }
        public string PrimaryEmail { get; set; }
        public string PrimaryEmailLink_RecID { get; set; }
        public string PrimaryEmailLink_Category { get; set; }
        public string PrimaryEmailLink_VRecID { get; set; }
        public string PrimaryPartnerLink_RecID { get; set; }
        public string PrimaryPartnerLink_Category { get; set; }
        public string PrimaryPartnerLink_VRecID { get; set; }
        public string PrimaryPartnerName { get; set; }
        public string PrimaryWebLink_RecID { get; set; }
        public string PrimaryWebLink_Category { get; set; }
        public string PrimaryWebLink_VRecID { get; set; }
        public string RecId { get; set; }
        public Nullable<bool> Referenceable { get; set; }
        public Nullable<byte> RegionCode { get; set; }
        public string RegionName { get; set; }
        public string Status { get; set; }
        public string Status_Valid { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public string Territory { get; set; }
        public string Territory_Valid { get; set; }
        public Nullable<byte> TerritoryCode { get; set; }
        public string TerritoryName { get; set; }
        public string TickerSymbol { get; set; }
        public string TransactionCurrencyCode { get; set; }
        public Nullable<decimal> McM_MonthlyRevenue { get; set; }
        public Nullable<bool> McM_AtRisk { get; set; }
        public string McM_csi { get; set; }
        public string McM_bank_group { get; set; }
        public string McM_core_sales_rep { get; set; }
        public Nullable<bool> McM_connected { get; set; }
        public string McM_aba { get; set; }
        public Nullable<bool> McM_am_visits { get; set; }
        public string McM_data_center { get; set; }
        public string McM_data_center_Valid { get; set; }
        public string McM_links_sales_rep { get; set; }
        public Nullable<System.DateTime> McM_date_of_conversion { get; set; }
        public string McM_cert { get; set; }
        public Nullable<System.DateTime> McM_current_contract_ends { get; set; }
        public Nullable<decimal> McM_monthly_billing { get; set; }
        public Nullable<bool> McM_od_plan_with_outside_cmpny { get; set; }
        public string McM_Bank_ID { get; set; }
        public string McM_Parent_Bank_ID { get; set; }
        public Nullable<bool> McM_account_analysis { get; set; }
        public Nullable<bool> McM_accounts_payable { get; set; }
        public Nullable<bool> McM_billing_buckets { get; set; }
        public Nullable<bool> McM_alm_extract { get; set; }
        public Nullable<bool> McM_call_report_workpapers { get; set; }
        public Nullable<bool> McM_call_report_interface { get; set; }
        public Nullable<bool> McM_cash_management { get; set; }
        public Nullable<bool> McM_checkmate_loans { get; set; }
        public Nullable<bool> McM_code_seven_loans_amortized { get; set; }
        public Nullable<bool> McM_cra_tracking_vendor { get; set; }
        public Nullable<bool> McM_credit_life_and_ah_ins { get; set; }
        public Nullable<bool> McM_credit_reporting { get; set; }
        public string McM_credit_reporting_is_with { get; set; }
        public string McM_crm_vendor { get; set; }
        public string McM_deposit_platform { get; set; }
        public Nullable<bool> McM_escrow { get; set; }
        public Nullable<bool> McM_fasb { get; set; }
        public Nullable<bool> McM_fidm { get; set; }
        public Nullable<bool> McM_fraud_protection { get; set; }
        public Nullable<bool> McM_heloc { get; set; }
        public Nullable<bool> McM_hsas { get; set; }
        public Nullable<bool> McM_loan_coupons { get; set; }
        public string McM_loan_platform { get; set; }
        public Nullable<bool> McM_mcm_loan_pricing { get; set; }
        public Nullable<bool> McM_scanning { get; set; }
        public Nullable<bool> McM_multi_input { get; set; }
        public Nullable<bool> McM_new_branch_gl { get; set; }
        public Nullable<bool> McM_note_pad_system { get; set; }
        public string McM_od_outside_company { get; set; }
        public Nullable<bool> McM_over_draft_plan { get; set; }
        public Nullable<bool> McM_overdraft_limits { get; set; }
        public Nullable<bool> McM_pc_transfer { get; set; }
        public Nullable<bool> McM_mcm_profitability { get; set; }
        public Nullable<bool> McM_positive_pay_in_dda { get; set; }
        public Nullable<bool> McM_reminder_system { get; set; }
        public Nullable<bool> McM_report_system { get; set; }
        public Nullable<bool> McM_report_system_server { get; set; }
        public Nullable<bool> McM_mcm_rewards_checking { get; set; }
        public Nullable<bool> McM_safe_deposit_box_system { get; set; }
        public Nullable<bool> McM_second_files { get; set; }
        public Nullable<bool> McM_stock_holder_system { get; set; }
        public Nullable<bool> McM_sweeps { get; set; }
        public Nullable<bool> McM_time_clock { get; set; }
        public Nullable<bool> McM_tt_codes_on_checks { get; set; }
        public Nullable<bool> McM_user_gl { get; set; }
        public Nullable<bool> McM_ach { get; set; }
        public string McM_ach_Valid { get; set; }
        public string McM_bsa { get; set; }
        public string McM_bsa_Valid { get; set; }
        public string McM_deposit { get; set; }
        public string McM_deposit_Valid { get; set; }
        public string McM_document_storage { get; set; }
        public string McM_document_storage_Valid { get; set; }
        public Nullable<bool> McM_email_statements { get; set; }
        public string McM_email_statements_Valid { get; set; }
        public string McM_check_image_system { get; set; }
        public string McM_check_image_system_Valid { get; set; }
        public string McM_check_writer { get; set; }
        public string McM_check_writer_Valid { get; set; }
        public string McM_merchant_capture { get; set; }
        public string McM_merchant_capture_Valid { get; set; }
        public string McM_mobile_banking { get; set; }
        public string McM_mobile_banking_Valid { get; set; }
        public string McM_bill_pay { get; set; }
        public string McM_bill_pay_Valid { get; set; }
        public string McM_supplies { get; set; }
        public string McM_supplies_Valid { get; set; }
        public string McM_teller { get; set; }
        public string McM_teller_Valid { get; set; }
        public string McM_voice { get; set; }
        public string McM_voice_Valid { get; set; }
        public string McM_vendor_management { get; set; }
        public string McM_vendor_management_Valid { get; set; }
        public string McM_internet { get; set; }
        public string McM_internet_Valid { get; set; }
        public Nullable<bool> McM_real_time_internet { get; set; }
        public Nullable<bool> McM_internet_positive_pay { get; set; }
        public string McM_internet_positive_pay_Valid { get; set; }
        public string McM_internet_cash_management { get; set; }
        public string McM_internet_cash_management_Valid { get; set; }
        public string McM_atm { get; set; }
        public string McM_atm_Valid { get; set; }
        public Nullable<System.DateTime> McM_atm_expiration { get; set; }
        public Nullable<bool> McM_atm_real_time { get; set; }
        public string McM_debit_cards { get; set; }
        public string McM_debit_cards_Valid { get; set; }
        public Nullable<System.DateTime> McM_debit_card_expiration { get; set; }
        public Nullable<bool> McM_debit_card_real_time { get; set; }
        public Nullable<bool> McM_card_sentry { get; set; }
        public Nullable<bool> McM_hot_site { get; set; }
        public string McM_hot_site_Valid { get; set; }
        public string McM_unix_backup { get; set; }
        public string McM_unix_backup_Valid { get; set; }
        public string McM_rewards_checking { get; set; }
        public string McM_rewards_checking_Valid { get; set; }
        public string McM_ofac { get; set; }
        public string McM_ofac_Valid { get; set; }
        public Nullable<bool> McM_fincen { get; set; }
        public string McM_fincen_Valid { get; set; }
        public string McM_cip { get; set; }
        public string McM_cip_Valid { get; set; }
        public Nullable<bool> McM_wire { get; set; }
        public string McM_wire_Valid { get; set; }
        public Nullable<bool> McM_training { get; set; }
        public string McM_training_Valid { get; set; }
        public string McM_commlines { get; set; }
        public string McM_commlines_Valid { get; set; }
        public string McM_secure_email { get; set; }
        public string McM_secure_email_Valid { get; set; }
        public string McM_internet_provider { get; set; }
        public string McM_internet_provider_Valid { get; set; }
        public string McM_network_management { get; set; }
        public string McM_network_management_Valid { get; set; }
        public string McM_internet_design { get; set; }
        public string McM_internet_design_Valid { get; set; }
        public string McM_intranet { get; set; }
        public string McM_intranet_Valid { get; set; }
        public string McM_loan_pricing { get; set; }
        public string McM_loan_pricing_Valid { get; set; }
        public string McM_alm { get; set; }
        public string McM_alm_Valid { get; set; }
        public string McM_network_backup { get; set; }
        public string McM_network_backup_Valid { get; set; }
        public string McM_statement_printing { get; set; }
        public string McM_statement_printing_Valid { get; set; }
        public string McM_pc_encryption { get; set; }
        public string McM_pc_encryption_Valid { get; set; }
        public string McM_profitability { get; set; }
        public string McM_profitability_Valid { get; set; }
        public string McM_nat { get; set; }
        public string McM_commlinks { get; set; }
        public string McM_unix { get; set; }
        public string McM_net { get; set; }
        public string McM_gix { get; set; }
        public string McM_gca { get; set; }
        public string McM_gpod { get; set; }
        public string McM_tlinks { get; set; }
        public string McM_csp { get; set; }
        public string McM_eft { get; set; }
        public string McM_doclinks { get; set; }
        public string McM_mcmdrive { get; set; }
        public string McM_bsalinks { get; set; }
        public string McM_mercap { get; set; }
        public string McM_fedline { get; set; }
        public Nullable<System.DateTime> McM_date_of_deconversion { get; set; }
        public string BugzillaBank { get; set; }
        public Nullable<bool> McM_Anonymous_Flag { get; set; }
        public string McM_Account_Manager { get; set; }
        public string McM_Account_Manager_Valid { get; set; }
        public string McM_City { get; set; }
        public Nullable<bool> McM_regz { get; set; }
        public string McM_Speed_Dial { get; set; }
        public string McM_CurrentRelease { get; set; }
        public string McM_achOrigination { get; set; }
        public string McM_achOrigination_Valid { get; set; }
        public string McM_branch_capture_option { get; set; }
        public string McM_branch_capture_option_Valid { get; set; }
        public string McM_bsa_audit { get; set; }
        public string McM_bsa_audit_Valid { get; set; }
        public Nullable<bool> McM_call_report { get; set; }
        public string McM_call_report_Valid { get; set; }
        public Nullable<bool> McM_call_rpt_int { get; set; }
        public string McM_call_rpt_int_Valid { get; set; }
        public string McM_crd_sentry { get; set; }
        public string McM_crd_sentry_Valid { get; set; }
        public string McM_crdsent_ppos { get; set; }
        public string McM_crdsent_ppos_Valid { get; set; }
        public Nullable<bool> McM_crdsentry_RTD { get; set; }
        public string McM_crdsentry_RTD_Valid { get; set; }
        public string McM_check_recovery { get; set; }
        public string McM_check_recovery_Valid { get; set; }
        public Nullable<bool> McM_Dlink_crTracking { get; set; }
        public string McM_Dlink_crTracking_Valid { get; set; }
        public Nullable<bool> McM_enotice { get; set; }
        public string McM_enotice_Valid { get; set; }
        public Nullable<bool> McM_eSafe_branding { get; set; }
        public string McM_eSafe_branding_Valid { get; set; }
        public Nullable<bool> McM_internet_marketingsub { get; set; }
        public string McM_internet_marketingsub_Valid { get; set; }
        public string McM_internet_mobileapp { get; set; }
        public string McM_internet_mobileapp_Valid { get; set; }
        public Nullable<bool> McM_internet_PFM { get; set; }
        public string McM_internet_PFM_Valid { get; set; }
        public string McM_loans_plus { get; set; }
        public string McM_loans_plus_Valid { get; set; }
        public string McM_merchant_services { get; set; }
        public string McM_merchant_services_Valid { get; set; }
        public Nullable<bool> McM_moneylinks_alerts { get; set; }
        public string McM_moneylinks_alerts_Valid { get; set; }
        public string McM_msi_statements { get; set; }
        public string McM_msi_statements_Valid { get; set; }
        public Nullable<bool> McM_network_audit { get; set; }
        public string McM_network_audit_Valid { get; set; }
        public Nullable<bool> McM_regcc { get; set; }
        public string McM_regcc_Valid { get; set; }
        public Nullable<bool> McM_secure_audit { get; set; }
        public string McM_secure_audit_Valid { get; set; }
        public Nullable<bool> McM_website_audit { get; set; }
        public string McM_website_audit_Valid { get; set; }
        public string McM_Mailing_Address { get; set; }
        public string McM_Prev_Vendor { get; set; }
        public string McM_Decon_Comment { get; set; }
        public Nullable<System.DateTime> McM_DC_move_date { get; set; }
        public Nullable<decimal> McM_Billable_AssetsPCV { get; set; }
        public Nullable<decimal> McM_Billable_Assets { get; set; }
        public Nullable<decimal> McM_Fax { get; set; }
        public Nullable<bool> McM_ACH_Contract { get; set; }
        public Nullable<System.DateTime> McM_ACH_Install { get; set; }
        public Nullable<bool> McM_ACHORIGINATION_Contract { get; set; }
        public Nullable<System.DateTime> McM_ACHORGINATION_INSTALL { get; set; }
        public Nullable<bool> McM_ALM_Contract { get; set; }
        public Nullable<System.DateTime> McM_ALM_Install { get; set; }
        public Nullable<bool> McM_ATM_Contract { get; set; }
        public Nullable<System.DateTime> McM_ATM_Install { get; set; }
        public Nullable<bool> McM_BillPay_Contract { get; set; }
        public Nullable<System.DateTime> McM_BillPay_Install { get; set; }
        public Nullable<bool> McM_BranchCap_Contract { get; set; }
        public Nullable<System.DateTime> McM_BranchCap_Install { get; set; }
        public Nullable<bool> McM_BSA_Contract { get; set; }
        public Nullable<System.DateTime> McM_BSA_Install { get; set; }
        public Nullable<bool> McM_BSAAudit_Contract { get; set; }
        public Nullable<System.DateTime> McM_BSAAudit_Install { get; set; }
        public Nullable<bool> McM_CallReport_Contract { get; set; }
        public Nullable<System.DateTime> McM_CallReport_Install { get; set; }
        public Nullable<bool> McM_CallReportInter_Contract { get; set; }
        public Nullable<System.DateTime> McM_CallReportInter_Install { get; set; }
        public Nullable<bool> McM_CardSentry_Contract { get; set; }
        public Nullable<System.DateTime> McM_CardSentry_Install { get; set; }
        public Nullable<bool> McM_CardSentryPinned_Contract { get; set; }
        public Nullable<System.DateTime> McM_CardSentryPinned_Install { get; set; }
        public Nullable<bool> McM_CardSentryRTD_Contract { get; set; }
        public Nullable<System.DateTime> McM_CardSentryRTD_Install { get; set; }
        public Nullable<bool> McM_CheckImage_Contract { get; set; }
        public Nullable<System.DateTime> McM_CheckImage_Install { get; set; }
        public Nullable<bool> McM_CheckRecovery_Contract { get; set; }
        public Nullable<System.DateTime> McM_CheckRecovery_Install { get; set; }
        public Nullable<bool> McM_CheckWriter_Contract { get; set; }
        public Nullable<System.DateTime> McM_CheckWriter_Install { get; set; }
        public Nullable<bool> McM_CIP_Contract { get; set; }
        public Nullable<System.DateTime> McM_CIP_Install { get; set; }
        public Nullable<bool> McM_CommLines_Contract { get; set; }
        public Nullable<System.DateTime> McM_CommLines_Install { get; set; }
        public Nullable<bool> McM_document_storage_contract { get; set; }
        public Nullable<System.DateTime> McM_document_storage_Install { get; set; }
        public Nullable<bool> MCM_email_statements_logical { get; set; }
        public Nullable<System.DateTime> MCM_email_statment_Install { get; set; }
        public Nullable<bool> MCM_enotices_logical { get; set; }
        public Nullable<System.DateTime> MCM_enotice_Install { get; set; }
        public Nullable<bool> MCM_eSafe_branding_logical { get; set; }
        public Nullable<System.DateTime> MCM_eSafe_branding_Install { get; set; }
        public Nullable<bool> MCM_fincen_logical { get; set; }
        public Nullable<System.DateTime> MCM_fincen_Install { get; set; }
        public Nullable<bool> McM_hot_site_logical { get; set; }
        public Nullable<System.DateTime> McM_hot_site_install { get; set; }
        public Nullable<bool> McM_internet_logical { get; set; }
        public Nullable<System.DateTime> McM_internet_install { get; set; }
        public Nullable<bool> McM_internet_cash_mgmt_logical { get; set; }
        public Nullable<System.DateTime> McM_internet_cash_mgmt_install { get; set; }
        public Nullable<bool> McM_internet_design_logical { get; set; }
        public Nullable<System.DateTime> McM_internet_design_install { get; set; }
        public Nullable<bool> McM_internet_marketing_logical { get; set; }
        public Nullable<System.DateTime> McM_internet_marketing_install { get; set; }
        public Nullable<bool> McM_internet_mobileapp_logical { get; set; }
        public Nullable<System.DateTime> McM_internet_mobileapp_install { get; set; }
        public Nullable<bool> McM_internet_PFM_logical { get; set; }
        public Nullable<System.DateTime> McM_internet_PFM_install { get; set; }
        public Nullable<bool> McM_internet_positivepay_logic { get; set; }
        public Nullable<System.DateTime> McM_internet_positivepay_insta { get; set; }
        public Nullable<bool> McM_internet_provider_logical { get; set; }
        public Nullable<System.DateTime> McM_internet_provider_install { get; set; }
        public Nullable<bool> McM_intranet_logical { get; set; }
        public Nullable<System.DateTime> McM_intranet_install { get; set; }
        public Nullable<bool> McM_Loan_pricing_logical { get; set; }
        public Nullable<System.DateTime> McM_Loan_pricing_install { get; set; }
        public Nullable<bool> McM_loans_plus_logical { get; set; }
        public Nullable<System.DateTime> McM_loans_plus_install { get; set; }
        public Nullable<bool> McM_merchant_capture_logical { get; set; }
        public Nullable<System.DateTime> McM_merchant_capture_Install { get; set; }
        public Nullable<bool> McM_merchant_services_logical { get; set; }
        public Nullable<System.DateTime> McM_merchant_services_install { get; set; }
        public Nullable<bool> McM_mobile_banking_logical { get; set; }
        public Nullable<System.DateTime> McM_mobile_banking_install { get; set; }
        public Nullable<bool> McM_moneylinks_alerts_logical { get; set; }
        public Nullable<System.DateTime> McM_moneylinks_alert_install { get; set; }
        public Nullable<bool> McM_msi_statements_logical { get; set; }
        public Nullable<System.DateTime> McM_msi_statements_install { get; set; }
        public Nullable<bool> McM_debit_cards_logical { get; set; }
        public Nullable<System.DateTime> McM_debit_cards_install { get; set; }
        public Nullable<bool> McM_deposit_logical { get; set; }
        public Nullable<System.DateTime> McM_deposit_install { get; set; }
        public Nullable<bool> McM_doclinks_logical { get; set; }
        public Nullable<System.DateTime> McM_doclinks_install { get; set; }
        public Nullable<bool> McM_network_audit_logical { get; set; }
        public Nullable<System.DateTime> McM_network_audit_install { get; set; }
        public Nullable<bool> McM_network_backup_logical { get; set; }
        public Nullable<System.DateTime> McM_network_backup_install { get; set; }
        public Nullable<bool> McM_network_management_logical { get; set; }
        public Nullable<System.DateTime> McM_network_management_install { get; set; }
        public Nullable<bool> McM_ofac_logical { get; set; }
        public Nullable<System.DateTime> McM_ofac_install { get; set; }
        public Nullable<bool> McM_pc_encryption_logical { get; set; }
        public Nullable<System.DateTime> McM_pc_encryption_install { get; set; }
        public Nullable<bool> McM_profitability_logical { get; set; }
        public Nullable<System.DateTime> McM_profitability_install { get; set; }
        public Nullable<bool> McM_regcc_logical { get; set; }
        public Nullable<System.DateTime> McM_regcc_install { get; set; }
        public Nullable<bool> McM_rewards_checking_logical { get; set; }
        public Nullable<System.DateTime> McM_rewards_checking_install { get; set; }
        public Nullable<bool> McM_secure_email_logical { get; set; }
        public Nullable<System.DateTime> McM_secure_email_install { get; set; }
        public Nullable<bool> McM_secure_audit_logical { get; set; }
        public Nullable<System.DateTime> McM_secure_audit_install { get; set; }
        public Nullable<bool> McM_statement_printing_logical { get; set; }
        public Nullable<System.DateTime> McM_statement_printing_install { get; set; }
        public Nullable<bool> McM_supplies_logical { get; set; }
        public Nullable<System.DateTime> McM_supplies_install { get; set; }
        public Nullable<bool> McM_teller_logical { get; set; }
        public Nullable<System.DateTime> McM_teller_install { get; set; }
        public Nullable<bool> McM_training_logical { get; set; }
        public Nullable<System.DateTime> McM_training_install { get; set; }
        public Nullable<bool> McM_unix_backup_logical { get; set; }
        public Nullable<System.DateTime> McM_unix_backup_install { get; set; }
        public Nullable<bool> McM_vendor_management_logical { get; set; }
        public Nullable<System.DateTime> McM_vendor_management_install { get; set; }
        public Nullable<bool> McM_voice_logical { get; set; }
        public Nullable<System.DateTime> McM_voice_install { get; set; }
        public Nullable<bool> McM_website_audit_logical { get; set; }
        public Nullable<System.DateTime> McM_website_audit_install { get; set; }
        public Nullable<bool> McM_wire_logical { get; set; }
        public Nullable<System.DateTime> McM_wire_install { get; set; }
        public Nullable<System.DateTime> McM_real_time_internet_install { get; set; }
        public Nullable<System.DateTime> McM_atm_real_time_install { get; set; }
        public Nullable<System.DateTime> McM_debit_card_real_time_insta { get; set; }
        public Nullable<bool> McM_debit_card_real_time_logic { get; set; }
        public Nullable<bool> McM_atm_real_time_logical { get; set; }
        public Nullable<bool> McM_real_time_internet_logical { get; set; }
        public string McM_survey_number { get; set; }
        public string McM_survey_number_Valid { get; set; }
        public string McM_core { get; set; }
        public string McM_core_Valid { get; set; }
        public string McM_LoanPlatform { get; set; }
        public string McM_LoanPlatform_Valid { get; set; }
        public Nullable<bool> McM_LoanPlatform_Logical { get; set; }
        public Nullable<System.DateTime> McM_LoanPlatform_install { get; set; }
        public string McM_DepositPlatform { get; set; }
        public string McM_DepositPlatform_Valid { get; set; }
        public Nullable<bool> McM_DepositPlatform_Logical { get; set; }
        public Nullable<System.DateTime> McM_DepositPlatform_Install { get; set; }
        public string McM_Bank_Code { get; set; }
        public string McM_Bank_Code_Valid { get; set; }
        public string McM_Mobile_App { get; set; }
        public string McM_Mobile_App_Valid { get; set; }
        public Nullable<bool> McM_Mobile_App_Logical { get; set; }
        public Nullable<System.DateTime> McM_Mobile_App_Install { get; set; }
        public Nullable<bool> McM_beta_bank_logical { get; set; }
        public string McM_Debit_Card_Instant_Issue { get; set; }
        public string McM_Debit_Card_Instant_Issue_Valid { get; set; }
        public Nullable<bool> McM_Debit_Card_Instant_Logical { get; set; }
        public Nullable<System.DateTime> McM_Debit_Card_Instant_Install { get; set; }
        public string McM_New_RSSDNumber { get; set; }
        public string McM_Ne_CharterNumber { get; set; }
        public string McM_AtRiskReason { get; set; }
        public string McM_atrisk_Text { get; set; }
        public string McM_DisasterRecovery { get; set; }
        public string McM_DisasterRecovery_Valid { get; set; }
        public Nullable<bool> McM_DisasterRecovery_Logical { get; set; }
        public Nullable<System.DateTime> McM_DisasterRecovery_Install { get; set; }
        public string McM_NCUA_charter { get; set; }
        public Nullable<bool> McM_Reference_logical { get; set; }
        public Nullable<bool> McM_Showcase_logical { get; set; }
        public string McM_PriorCore { get; set; }
        public Nullable<bool> McM_Meridian2go { get; set; }
        public Nullable<bool> McM_Meridian2go_contract { get; set; }
        public Nullable<System.DateTime> McM_Meridian2go_install { get; set; }
        public Nullable<bool> McM_CSInet_logical { get; set; }
        public Nullable<bool> McM_CSInet_Contract { get; set; }
        public Nullable<System.DateTime> McM_CSInet_Install { get; set; }
        public Nullable<bool> McM_WatW_Logical { get; set; }
        public Nullable<bool> McM_WatW_Contract { get; set; }
        public Nullable<System.DateTime> McM_WatW_Install { get; set; }
        public Nullable<bool> McM_CRM_Logical { get; set; }
        public Nullable<bool> McM_CRM_Contract { get; set; }
        public Nullable<System.DateTime> McM_CRM_Install { get; set; }
        public Nullable<bool> McM_CardSentry { get; set; }
        public string McM_Call_Report2 { get; set; }
        public string McM_Call_Report2_Valid { get; set; }
        public string McM_CRM { get; set; }
        public string McM_CRM_Valid { get; set; }
        public Nullable<bool> McM_CSI_Email { get; set; }
        public Nullable<System.DateTime> McM_CSI_Email_Install { get; set; }
        public Nullable<bool> McM_POP3_Email { get; set; }
        public Nullable<System.DateTime> McM_POP3_Email_Install { get; set; }
        public Nullable<bool> McM_Secure_Mobile_Email { get; set; }
        public Nullable<System.DateTime> McM_Secur_Mobile_Email_Install { get; set; }
        public string McM_DisasterCommLines { get; set; }
        public string McM_DisasterCommLines_Valid { get; set; }
        public Nullable<System.DateTime> McM_DisasterCommLines_Install { get; set; }
        public Nullable<bool> McM_DisasterCommLines_Contract { get; set; }
        public string McM_FinancialMgmtDB { get; set; }
        public string McM_FinancialMgmtDB_Valid { get; set; }
        public Nullable<System.DateTime> McM_FinancialMgmtDB_Install { get; set; }
        public Nullable<bool> McM_FinancialMgmtDB_Contract { get; set; }
        public Nullable<bool> McM_IH_TRU_Servers { get; set; }
        public Nullable<System.DateTime> McM_IH_TRU_Servers_Install { get; set; }
        public Nullable<bool> McM_Drive_Core { get; set; }
        public Nullable<System.DateTime> McM_Drive_Core_Install { get; set; }
        public Nullable<bool> McM_Drive_Images { get; set; }
        public Nullable<System.DateTime> McM_Drive_Images_Install { get; set; }
        public Nullable<bool> McM_External_Transfers_A2A { get; set; }
        public Nullable<System.DateTime> McM_External_transfer_A2A { get; set; }
        public Nullable<bool> McM_Quicken { get; set; }
        public Nullable<System.DateTime> McM_Quicken_Install { get; set; }
        public Nullable<bool> McM_QuickBooks { get; set; }
        public Nullable<System.DateTime> McM_QuickBooks_Install { get; set; }
        public Nullable<bool> McM_Tokens { get; set; }
        public Nullable<System.DateTime> McM_Tokens_Install { get; set; }
        public Nullable<bool> McM_LockTiteEncrypt { get; set; }
        public Nullable<System.DateTime> McM_LockTiteEncrypt_Install { get; set; }
        public Nullable<bool> McM_LockTite_Vault { get; set; }
        public Nullable<bool> McM_LockTiteValue { get; set; }
        public Nullable<System.DateTime> McM_LockTiteVault_Install { get; set; }
        public Nullable<bool> McM_NMS { get; set; }
        public Nullable<System.DateTime> McM_NMS_Install { get; set; }
        public Nullable<bool> McM_Fiserv { get; set; }
        public Nullable<System.DateTime> McM_Fiserv_Install { get; set; }
        public Nullable<bool> McM_MSI { get; set; }
        public Nullable<System.DateTime> McM_MSI_Install { get; set; }
        public Nullable<bool> McM_ProfitStars { get; set; }
        public Nullable<System.DateTime> McM_ProfitStars_Install { get; set; }
        public Nullable<bool> McM_Summit { get; set; }
        public Nullable<System.DateTime> McM_Summit_Install { get; set; }
        public Nullable<bool> McM_Wausau { get; set; }
        public Nullable<System.DateTime> McM_Wausau_Install { get; set; }
        public Nullable<bool> McM_AndroidPlatform { get; set; }
        public Nullable<System.DateTime> McM_AndroidPlatform_Install { get; set; }
        public Nullable<bool> McM_iOSPlatform { get; set; }
        public Nullable<System.DateTime> McM_iOSPlatform_Install { get; set; }
        public Nullable<bool> McM_iPadPlatform { get; set; }
        public Nullable<System.DateTime> McM_iPadPlatform_Install { get; set; }
        public Nullable<bool> McM_CIPStorage { get; set; }
        public Nullable<System.DateTime> McM_CIPStorage_Install { get; set; }
        public Nullable<bool> McM_Card_onoff { get; set; }
        public Nullable<System.DateTime> McM_card_onoff_Install { get; set; }
        public Nullable<bool> McM_MobileBillPay { get; set; }
        public Nullable<System.DateTime> McM_MobileBillPay_Install { get; set; }
        public Nullable<bool> McM_Mobile_Remote_Deposit { get; set; }
        public Nullable<System.DateTime> McM_MobilRemoteDeposit_Install { get; set; }
        public Nullable<bool> McM_OutofWallet { get; set; }
        public Nullable<System.DateTime> McM_OutofWallet_Install { get; set; }
        public Nullable<bool> McM_Bankers_GPS { get; set; }
        public Nullable<System.DateTime> McM_Bankers_GPS_Install { get; set; }
        public Nullable<bool> McM_LoanRelationshipPricing { get; set; }
        public Nullable<System.DateTime> McM_LoanRelationPricinInstall { get; set; }
        public Nullable<bool> McM_MarginPerformer { get; set; }
        public Nullable<System.DateTime> McM_MarginPerformer_Install { get; set; }
        public Nullable<bool> McM_Profitability_Performer { get; set; }
        public Nullable<System.DateTime> McM_Profitabi_Performer_Instal { get; set; }
        public Nullable<bool> McM_Risk_GPS { get; set; }
        public Nullable<System.DateTime> McM_Risk_GPS_Install { get; set; }
        public Nullable<bool> McM_WatchDogWireInt { get; set; }
        public Nullable<System.DateTime> McM_WatchDogWireInt_Install { get; set; }
        public string McM_RemittancProcessing { get; set; }
        public string McM_RemittancProcessing_Valid { get; set; }
        public Nullable<System.DateTime> McM_RemitanceProcesing_Instal { get; set; }
        public Nullable<bool> McM_RemitanceProcesin_Contract { get; set; }
        public Nullable<bool> McM_BlackWhiteLogo { get; set; }
        public Nullable<System.DateTime> McM_BlackWhiteLogo_Install { get; set; }
        public Nullable<bool> McM_DoubleWindowEnvelopes { get; set; }
        public Nullable<System.DateTime> McM_DoubleWindowEnvel_Install { get; set; }
        public Nullable<bool> McM_DoubleWindowEnvel_Contract { get; set; }
        public Nullable<bool> McM_SIPRouter { get; set; }
        public Nullable<System.DateTime> McM_SIPRouter_Install { get; set; }
        public Nullable<bool> McM_TollFreeNumber { get; set; }
        public Nullable<System.DateTime> McM_TollFreeNumber_Install { get; set; }
        public Nullable<bool> McM_Board_Portal { get; set; }
        public Nullable<System.DateTime> McM_BoardPortal_Install { get; set; }
        public Nullable<bool> McM_Voice_RealTime { get; set; }
        public Nullable<System.DateTime> McM_Voice_RealTime_Install { get; set; }
        public Nullable<bool> McM_OutOfBand_IB_Logical { get; set; }
        public Nullable<System.DateTime> McM_OutOfBand_IB_Install { get; set; }
        public Nullable<bool> McM_OutOfWallet_IB_Logical { get; set; }
        public Nullable<System.DateTime> McM_OutofWallet_IB_Install { get; set; }
        public Nullable<bool> McM_Tokens_M2G_Logical { get; set; }
        public Nullable<System.DateTime> McM_Tokens_M2G_Install { get; set; }
        public Nullable<bool> McM_OutOfBand_M2G_Logical { get; set; }
        public Nullable<System.DateTime> McM_OutOfBand_M2G_Install { get; set; }
        public Nullable<bool> McM_SecureConnect { get; set; }
        public Nullable<bool> McM_SecureConnect_Contract { get; set; }
        public Nullable<System.DateTime> McM_SecureConnect_Install { get; set; }
        public Nullable<System.DateTime> McM_BankFiles { get; set; }
        public Nullable<System.DateTime> McM_GLFiles { get; set; }
        public Nullable<bool> McM_IRS_Tax_Form_Logical { get; set; }
        public Nullable<System.DateTime> McM_IRS_Tax_Form_Date { get; set; }
        public Nullable<bool> McM_Spin_Payments_logical { get; set; }
        public Nullable<System.DateTime> McM_Spin_Payments_Date { get; set; }
        public Nullable<bool> McM_EOY_BankFiles { get; set; }
        public Nullable<bool> McM_EOY_GLFiles { get; set; }
        public Nullable<bool> McM_TellerCapture { get; set; }
        public Nullable<System.DateTime> McM_TellerCapture_Install { get; set; }
        public string P_Street { get; set; }
        public string P_City { get; set; }
        public string P_State { get; set; }
        public string P_Zip { get; set; }
        public string M_Street { get; set; }
        public string M_City { get; set; }
        public string M_State { get; set; }
        public string M_Zip { get; set; }
        public Nullable<short> McM_Number_of_Branches { get; set; }
        public Nullable<bool> McM_Loan_Upload_Logical { get; set; }
        public Nullable<bool> McM_Deposit_Upload_Logical { get; set; }
        public Nullable<bool> McM_CIP_Storage { get; set; }
        public Nullable<System.DateTime> McM_CIP_Storage_Install { get; set; }
        public Nullable<bool> McM_CardProfit_Retention { get; set; }
        public Nullable<System.DateTime> McM_CardProfit_Reten_Install { get; set; }
        public Nullable<bool> McM_PEP { get; set; }
        public Nullable<System.DateTime> McM_PEP_Install { get; set; }
        public Nullable<bool> McM_ApplePay { get; set; }
        public Nullable<System.DateTime> McM_ApplePay_Install { get; set; }
        public Nullable<bool> McM_TerminalServer { get; set; }
        public Nullable<bool> McM_2ndBeta { get; set; }
    }
}
