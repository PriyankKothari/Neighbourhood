//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Data;
using System.Diagnostics;
using System.Linq;
using Datacom.IRIS.DomainModel.Domain;

namespace Datacom.IRIS.DataAccess
{
    public partial interface IObjectContext
    {
    
            #region ObjectSet Properties
    		
    	ObjectSet<Address> Address { get; }
    	ObjectSet<Contact> Contact { get; }
    	ObjectSet<ContactAddress> ContactAddress { get; }
    	ObjectSet<Email> Email { get; }
    	ObjectSet<Name> Name { get; }
    	ObjectSet<Website> Website { get; }
    	ObjectSet<Note> Note { get; }
    	ObjectSet<ActivityObjectRelationship> ActivityObjectRelationship { get; }
    	ObjectSet<Location> Location { get; }
    	ObjectSet<IRISMessage> IRISMessage { get; }
    	ObjectSet<Favourite> Favourite { get; }
    	ObjectSet<Delegation> Delegation { get; }
    	ObjectSet<IRISBusinessIDPattern> IRISBusinessIDPattern { get; }
    	ObjectSet<ContactSubLink> ContactSubLink { get; }
    	ObjectSet<LocationGroup> LocationGroup { get; }
    	ObjectSet<TaskDefinition> TaskDefinitions { get; }
    	ObjectSet<WorkflowDefinition> WorkflowDefinitions { get; }
    	ObjectSet<Function> Function { get; }
    	ObjectSet<Group> Group { get; }
    	ObjectSet<GroupPermission> GroupPermission { get; }
    	ObjectSet<Permission> Permission { get; }
    	ObjectSet<User> User { get; }
    	ObjectSet<UserGroup> UserGroup { get; }
    	ObjectSet<ReferenceDataCollection> ReferenceDataCollection { get; }
    	ObjectSet<ReferenceDataValue> ReferenceDataValue { get; }
    	ObjectSet<FunctionObjectPermission> FunctionObjectPermission { get; }
    	ObjectSet<IRISObject> IRISObject { get; }
    	ObjectSet<ActivityObjectRelationshipType> ActivityObjectRelationshipType { get; }
    	ObjectSet<ReferenceDataValueAttribute> ReferenceDataValueAttribute { get; }
    	ObjectSet<DataSecurity> DataSecurity { get; }
    	ObjectSet<AppSetting> AppSetting { get; }
    	ObjectSet<SearchIndex> SearchIndex { get; }
    	ObjectSet<SearchKeyword> SearchKeyword { get; }
    	ObjectSet<SearchResult> SearchResult { get; }
    	ObjectSet<SearchResultSpatial> SearchResultSpatial { get; }
    	ObjectSet<SearchTerm> SearchTerm { get; }
    	ObjectSet<TaskInstance> TaskInstances { get; }
    	ObjectSet<WorkflowInstance> WorkflowInstances { get; }
    	ObjectSet<Calendar> Calendar { get; }
    	ObjectSet<Hold> Hold { get; }
    	ObjectSet<NonWorkDay> NonWorkDay { get; }
    	ObjectSet<TimeFrame> TimeFrame { get; }
    	ObjectSet<HelpContent> HelpContent { get; }
    	ObjectSet<HelpLink> HelpLink { get; }
    	ObjectSet<Clock> Clock { get; }
    	ObjectSet<ObjectTypeCalendar> ObjectTypeCalendar { get; }
    	ObjectSet<WorkflowSuspension> WorkflowSuspension { get; }
    	ObjectSet<Activity> Activities { get; }
    	ObjectSet<Appeal> Appeals { get; }
    	ObjectSet<Application> Applications { get; }
    	ObjectSet<Objection> Objections { get; }
    	ObjectSet<ActivityCondition> ActivityConditions { get; }
    	ObjectSet<ActivityOutcome> ActivityOutcomes { get; }
    	ObjectSet<ActivitySpecialEventDate> ActivitySpecialEventDates { get; }
    	ObjectSet<Authorisation> Authorisations { get; }
    	ObjectSet<AuthorisationCondition> AuthorisationConditions { get; }
    	ObjectSet<AuthorisationSpecialEventDate> AuthorisationSpecialEventDates { get; }
    	ObjectSet<Condition> Conditions { get; }
    	ObjectSet<Parameter> Parameters { get; }
    	ObjectSet<EmailTemplate> EmailTemplates { get; }
    	ObjectSet<WorkflowCallMapping> WorkflowCallMappings { get; }
    	ObjectSet<OtherIdentifier> OtherIdentifiers { get; }
    	ObjectSet<ActivityPlan> ActivityPlans { get; }
    	ObjectSet<AuthorisationPlan> AuthorisationPlans { get; }
    	ObjectSet<Plan> Plans { get; }
    	ObjectSet<Policy> Policies { get; }
    	ObjectSet<RuleObjective> RuleObjectives { get; }
    	ObjectSet<AuthorisationGroup> AuthorisationGroups { get; }
    	ObjectSet<ConditionScheduleCondition> ConditionScheduleConditions { get; }
    	ObjectSet<ConditionSchedule> ConditionSchedules { get; }
    	ObjectSet<MilestoneDate> MilestoneDates { get; }
    	ObjectSet<TimeRecord> TimeRecords { get; }
    	ObjectSet<SearchHeader> SearchHeader { get; }
    	ObjectSet<AuthorisationCharge> AuthorisationCharge { get; }
    	ObjectSet<ServiceAddress> ServiceAddresses { get; }
    	ObjectSet<WorkflowCallInstance> WorkflowCallInstances { get; }
    	ObjectSet<InstancesTable> InstancesTable { get; }
    	ObjectSet<Status> Statuses { get; }
    	ObjectSet<WorkflowRunningInstance> WorkflowRunningInstances { get; }
    	ObjectSet<LibraryCondition> LibraryCondition { get; }
    	ObjectSet<ThirdPartyInvolvement> ThirdPartyInvolvement { get; }
    	ObjectSet<OnlineServicesAccount> OnlineServicesAccount { get; }
    	ObjectSet<PhoneNumber> PhoneNumber { get; }
    	ObjectSet<AppealAppellant> AppealAppellants { get; }
    	ObjectSet<CustomLink> CustomLinks { get; }
    	ObjectSet<MobileInspector> MobileInspectors { get; }
    	ObjectSet<MobileInspectorFunction> MobileInspectorFunctions { get; }
    	ObjectSet<ReferenceDataValueWording> ReferenceDataValueWordings { get; }
    	ObjectSet<ObjectInspectionTypeMapping> ObjectInspectionTypeMappings { get; }
    	ObjectSet<TaskDefinitionOutcomeMapping> TaskDefinitionOutcomeMappings { get; }
    	ObjectSet<RelatedAuthorisation> RelatedAuthorisations { get; }
    	ObjectSet<AdHocData> AdHocData { get; }
    	ObjectSet<Answer> Answer { get; }
    	ObjectSet<CDFList> CDFList { get; }
    	ObjectSet<CDFListQuestionDefinition> CDFListQuestionDefinition { get; }
    	ObjectSet<QuestionDefinition> QuestionDefinition { get; }
    	ObjectSet<ExposedStoredProcedure> ExposedStoredProcedures { get; }
    	ObjectSet<SurveyCategory> SurveyCategories { get; }
    	ObjectSet<SurveyCategoryQuestionDefinition> SurveyCategoryQuestionDefinitions { get; }
    	ObjectSet<Survey> Surveys { get; }
    	ObjectSet<CDFFormattedAnswer> CDFFormattedAnswers { get; }
    	ObjectSet<TaskMappedField> TaskMappedFields { get; }
    	ObjectSet<NavigationHistory> NavigationHistories { get; }
    	ObjectSet<Sequence> Sequence { get; }
    	ObjectSet<WarningMessage> WarningMessage { get; }
    	ObjectSet<IRISObjectDetail> IRISObjectDetails { get; }
    	ObjectSet<ContactBulkLoadItem> ContactBulkLoadItems { get; }
    	ObjectSet<Inspection_Batch_Create> Inspection_Batch_Create { get; }
    	ObjectSet<LookupStreet> LookupStreet { get; }
    	ObjectSet<LookupSuburb> LookupSuburb { get; }
    	ObjectSet<LookupTownCity> LookupTownCity { get; }
    	ObjectSet<ContactGroup> ContactGroup { get; }
    	ObjectSet<ContactGroupMember> ContactGroupMember { get; }
    	ObjectSet<ContactGroupQuestionDefinition> ContactGroupQuestionDefinition { get; }
    	ObjectSet<JFCAssociatedContact> JFCAssociatedContacts { get; }
    	ObjectSet<ContactVerification> ContactVerifications { get; }
    	ObjectSet<Enforcement> Enforcements { get; }
    	ObjectSet<EnforcementAllegedOffence> EnforcementAllegedOffences { get; }
    	ObjectSet<EnforcementActionAllegedOffence> EnforcementActionAllegedOffences { get; }
    	ObjectSet<EnforcementActionOfficerResponsible> EnforcementActionOfficerResponsibles { get; }
    	ObjectSet<EnforcementActionProsecutionCharge> EnforcementActionProsecutionCharges { get; }
    	ObjectSet<EnforcementActionProsecutionSentence> EnforcementActionProsecutionSentences { get; }
    	ObjectSet<EnforcementActionRecipientOrRespondent> EnforcementActionRecipientOrRespondents { get; }
    	ObjectSet<EnforcementAllegedOffencePlan> EnforcementAllegedOffencePlans { get; }
    	ObjectSet<EnforcementAction> EnforcementActions { get; }
    	ObjectSet<EnforcementActionProsecutionDefendant> EnforcementActionProsecutionDefendants { get; }
    	ObjectSet<EnforcementAllegedOffenceOffender> EnforcementAllegedOffenceOffenders { get; }
    	ObjectSet<ManagementSite> ManagementSites { get; }
    	ObjectSet<Species> Species { get; }
    	ObjectSet<MngtSiteLandTenure> MngtSiteLandTenures { get; }
    	ObjectSet<MngtSiteLandManagementPlan> MngtSiteLandManagementPlans { get; }
    	ObjectSet<MngtSiteBiodiversityConsvSpecies> MngtSiteBiodiversityConsvSpecies { get; }
    	ObjectSet<MngtSiteBiodiversityEcoFeature> MngtSiteBiodiversityEcoFeatures { get; }
    	ObjectSet<MngtSiteIndustryPurpose> MngtSiteIndustryPurposes { get; }
    	ObjectSet<MngtSiteThreatSpecies> MngtSiteThreatSpecies { get; }
    	ObjectSet<MngtSiteClassification> MngtSiteClassifications { get; }
    	ObjectSet<MngtSiteOtherManagementIssue> MngtSiteOtherManagementIssues { get; }
    	ObjectSet<MngtSiteSiteProtection> MngtSiteSiteProtections { get; }
    	ObjectSet<SitePlan> SitePlans { get; }
    	ObjectSet<SpeciesStatus> SpeciesStatus { get; }
    	ObjectSet<Observation> Observations { get; }
    	ObjectSet<ObservationFurtherAction> ObservationFurtherActions { get; }
    	ObjectSet<ObservationSelectedLandUseIndicator> ObservationSelectedLandUseIndicators { get; }
    	ObjectSet<ObservationComplianceParameter> ObservationComplianceParameters { get; }
    	ObjectSet<ObservationObservingOfficer> ObservationObservingOfficers { get; }
    	ObjectSet<SpeciesType> SpeciesTypes { get; }
    	ObjectSet<ObservationMngtSpeciesCount> ObservationMngtSpeciesCounts { get; }
    	ObjectSet<ObservationMngtSpeciesCountItem> ObservationMngtSpeciesCountItems { get; }
    	ObjectSet<ObservationMngtSitePlan> ObservationMngtSitePlans { get; }
    	ObjectSet<ObservationComplianceAuthorisation> ObservationComplianceAuthorisations { get; }
    	ObjectSet<ObservationComplianceCondition> ObservationComplianceConditions { get; }
    	ObjectSet<AuthorisationComplianceCondition> AuthorisationComplianceConditions { get; }
    	ObjectSet<Request> Request { get; }
    	ObjectSet<ActualEquipmentMaterial> ActualEquipmentMaterials { get; }
    	ObjectSet<ActualEquipmentMaterialAuthorisation> ActualEquipmentMaterialAuthorisations { get; }
    	ObjectSet<ActualLabour> ActualLabours { get; }
    	ObjectSet<ActualLabourAuthorisation> ActualLabourAuthorisations { get; }
    	ObjectSet<ObservationMngtLine> ObservationMngtLines { get; }
    	ObjectSet<ObservationMngtLineMonitoring> ObservationMngtLineMonitorings { get; }
    	ObjectSet<ObservationMngtLineResult> ObservationMngtLineResults { get; }
    	ObjectSet<ObservationMngtLineResultItem> ObservationMngtLineResultItems { get; }
    	ObjectSet<ObservationRequestSpeciesCount> ObservationRequestSpeciesCounts { get; }
    	ObjectSet<ObservationRequestSpeciesCountItem> ObservationRequestSpeciesCountItems { get; }
    	ObjectSet<RegimeActivityComplianceCondition> RegimeActivityComplianceConditions { get; }
    	ObjectSet<RegimeActivityDamFurtherAction> RegimeActivityDamFurtherActions { get; }
    	ObjectSet<RegimeActivityDamReport> RegimeActivityDamReports { get; }
    	ObjectSet<RegimeActivity> RegimeActivity { get; }
    	ObjectSet<SampleResult> SampleResults { get; }
    	ObjectSet<DamRegister> DamRegisters { get; }
    	ObjectSet<RegimeActivitySchedule> RegimeActivitySchedule { get; }
    	ObjectSet<RegimeActivityMngtSite> RegimeActivityMngtSites { get; }
    	ObjectSet<RegimeActivityResourceNeeded> RegimeActivityResourceNeededs { get; }
    	ObjectSet<RegimeActivityComplianceAuthorisation> RegimeActivityComplianceAuthorisations { get; }
    	ObjectSet<EstimationLabour> EstimationLabours { get; }
    	ObjectSet<EstimationLabourAuthorisation> EstimationLabourAuthorisations { get; }
    	ObjectSet<EquipmentMaterial> EquipmentMaterials { get; }
    	ObjectSet<EquipmentMaterialAuthorisation> EquipmentMaterialAuthorisations { get; }
    	ObjectSet<ReferenceDataValueRate> ReferenceDataValueRates { get; }
    	ObjectSet<Programme> Programme { get; }
    	ObjectSet<Regime> Regime { get; }
    	ObjectSet<RegimeEnvironmentPlan> RegimeEnvironmentPlan { get; }
    	ObjectSet<RegimeMngtPlan> RegimeMngtPlans { get; }
    	ObjectSet<Remediation> Remediations { get; }
    	ObjectSet<RemediationPlantingSpecies> RemediationPlantingSpecies { get; }
    	ObjectSet<RemediationShootingPest> RemediationShootingPests { get; }
    	ObjectSet<RemediationTrappingPest> RemediationTrappingPests { get; }
    	ObjectSet<RemediationSitePlan> RemediationSitePlans { get; }
    	ObjectSet<RemediationItem> RemediationItems { get; }
    	ObjectSet<RemediationTreatment> RemediationTreatments { get; }
    	ObjectSet<PropertyDataDVRUpload> PropertyDataDVRUploads { get; }
    	ObjectSet<PropertyDataImportMessage> PropertyDataImportMessages { get; }
    	ObjectSet<PropertyDataValuation> PropertyDataValuations { get; }
    	ObjectSet<PropertyDataOwner> PropertyDataOwners { get; }
    	ObjectSet<PropertyDataRatepayer> PropertyDataRatepayers { get; }
    	ObjectSet<GeneralRegister> GeneralRegisters { get; }
    	ObjectSet<ContactQuery> ContactQueries { get; }
    	ObjectSet<DocumentTemplate> DocumentTemplates { get; }
    	ObjectSet<Report> Reports { get; }
    	ObjectSet<DirectDocumentReferenceCriteria> DirectDocumentReferenceCriterias { get; }
    	ObjectSet<MobileDocumentReferenceCriteria> MobileDocumentReferenceCriterias { get; }
    	ObjectSet<RequestOfficerResponsible> RequestOfficerResponsible { get; }
    	ObjectSet<RequestSubjectTransportRoutes> RequestSubjectTransportRoutes { get; }
    	ObjectSet<RequestTypeIncidentBreaches> RequestTypeIncidentBreaches { get; }
    	ObjectSet<RequestTypeIncidentCauseEffect> RequestTypeIncidentCauseEffect { get; }
    	ObjectSet<RequestTypeIncidentFurtherAction> RequestTypeIncidentFurtherAction { get; }
    	ObjectSet<RequestTypeIncidentResourceType> RequestTypeIncidentResourceType { get; }
    	ObjectSet<RequestSubjectBiosecuritySpecies> RequestSubjectBiosecuritySpecies { get; }
    	ObjectSet<RequestPlan> RequestPlan { get; }
    	ObjectSet<RequestTypeRFS> RequestTypeRFS { get; }
    	ObjectSet<RequestTypeIncident> RequestTypeIncident { get; }
    	ObjectSet<SelectedLandUseSiteClassification> SelectedLandUseSiteClassifications { get; }
    	ObjectSet<SelectedLandUseSiteContaminant> SelectedLandUseSiteContaminants { get; }
    	ObjectSet<SelectedLandUseSiteHAIL> SelectedLandUseSiteHAILs { get; }
    	ObjectSet<SelectedLandUseSiteRapidRiskScreening> SelectedLandUseSiteRapidRiskScreenings { get; }
    	ObjectSet<SelectedLandUseSiteTankPull> SelectedLandUseSiteTankPulls { get; }
    	ObjectSet<SelectedLandUseSite> SelectedLandUseSites { get; }

            #endregion

            #region Function Imports
    	
    	void AddSpatialResult(Nullable<long> searchHeaderID, string spatialIDs);    
    	void ReIndexSearchIndexSpatialID(Nullable<long> iRISObjectID);    
    	void RunSearch(Nullable<long> searchHeaderID);    
    	ObjectResult<SearchIndex> SelectSearchResultsByPage(Nullable<long> searchHeaderID, string sortExpression, Nullable<int> pageSize, Nullable<int> pageCount, string excludeObjectIDs, ObjectParameter searchCount);    
    	void AdvancedSearchLocation(Nullable<long> scopeObjectTypeID, Nullable<long> userID, Nullable<bool> isSpatialSearch, string spatialIDs, string commonName, string description, string featureTypeIDs, Nullable<System.DateTime> createdFrom, Nullable<System.DateTime> createdTo, Nullable<bool> restricted, string restrictedComments, string legalDescription, Nullable<long> locationGroupIRISObjectID, string basicSearchKeywords, string contactOrganisationPersonName, string linkedContactRelationshipTypeIDs, string cdfCriteria, ObjectParameter errorCode, ObjectParameter searchHeaderID);    
    	void ReIndexObject(Nullable<long> objectID, string objectType, Nullable<System.DateTime> onlyRefreshIndexOlderThan);    
    	void CalculateElapsedWorkingDays(Nullable<long> iRISObjectID, ObjectParameter elapsedWorkingDays);    
    	void CalculateDueDate(Nullable<long> iRISObjectID, ObjectParameter dueDate);    
    	void CalculateMilestoneAndMilestoneDate(Nullable<long> applicationID, ObjectParameter milestone, ObjectParameter milestoneDate);    
    	void AdvancedSearchApplication(Nullable<long> scopeObjectTypeID, Nullable<long> userID, Nullable<bool> isSpatialSearch, string spatialIDs, Nullable<long> applicationTypeID, Nullable<long> applicationPurposeID, string activityTypeIDs, string activitySubTypeIDs, string applicationStatusIDs, Nullable<System.DateTime> lodgedFrom, Nullable<System.DateTime> lodgedTo, Nullable<long> officerResponsible, string description, string basicSearchKeywords, string contactOrganisationPersonName, string linkedContactRelationshipTypeIDs, string cdfCriteria, ObjectParameter errorCode, ObjectParameter searchHeaderID);    
    	void PopulateLinkDetails(Nullable<long> iRISObjectID);    
    	void AdvancedSearchAuthorisation(Nullable<long> scopeObjectTypeID, Nullable<long> userID, Nullable<bool> isSpatialSearch, string spatialIDs, Nullable<long> authorisationTypeID, string activityTypeIDs, string activitySubTypeIDs, string authorisationStatusIDs, Nullable<System.DateTime> commencedFrom, Nullable<System.DateTime> commencedTo, Nullable<long> officerResponsible, string description, string basicSearchKeywords, string contactOrganisationPersonName, string linkedContactRelationshipTypeIDs, string cdfCriteria, ObjectParameter errorCode, ObjectParameter searchHeaderID);    
    	void CalculateDateUsingCalendar(Nullable<long> iRISObjectID, Nullable<System.DateTime> fromDate, Nullable<int> numDays, Nullable<bool> workingDays, Nullable<bool> ignoreHold, ObjectParameter resultDate);    
    	void CreateSearch(string searchCriteria, Nullable<long> scopeObjectTypeID, Nullable<long> scopeSubClass1ID, Nullable<long> userID, Nullable<bool> isSpatialSearch, ObjectParameter searchHeaderID, ObjectParameter errorCode);    
    	void PopulateObjectID(Nullable<long> linkID, Nullable<long> iRISObjectID);    
    	void AdvancedSearchRegime(Nullable<long> scopeObjectTypeID, Nullable<long> userID, Nullable<bool> isSpatialSearch, string spatialIDs, string regimeTypeIDs, string classificationIDs, string regimeActivityTypeIDs, string activityName, string officerResponsibleIDs, string description, string regimeStatusIDs, string regimeFinancialYearIDs, string basicSearchKeywords, string contactOrganisationPersonName, string linkedContactRelationshipTypeIDs, string cdfCriteria, ObjectParameter errorCode, ObjectParameter searchHeaderID);    
    	void PopulateWeekends(Nullable<long> calendarID, Nullable<System.DateTime> loopDate, Nullable<System.DateTime> endDate, string createdBy);    
    	void BatchJob_Authorisations_NotYetCommenced();    
    	ObjectResult<BatchJob_Authorisations_AuthorisationRenewalAdvice_Result> BatchJob_Authorisations_AuthorisationRenewalAdvice();    
    	void BatchJob_Authorisations_AuthorisationExpiry();    
    	void BatchJob_Authorisations_AuthorisationExpiryS124Protection();    
    	void GetPreviousTaskCompletionDate(Nullable<System.Guid> currentWorkflowInstanceUID, ObjectParameter previousTaskCompletionDate);    
    	void AdvancedSearchProgramme(Nullable<long> scopeObjectTypeID, Nullable<long> userID, Nullable<bool> isSpatialSearch, string spatialIDs, Nullable<System.DateTime> startDateFrom, Nullable<System.DateTime> startDateTo, Nullable<System.DateTime> endDateFrom, Nullable<System.DateTime> endDateTo, string programmeTypeIDs, string priorityIDs, string officerResponsibleIDs, string description, string basicSearchKeywords, string contactOrganisationPersonName, string linkedContactRelationshipTypeIDs, string cdfCriteria, ObjectParameter errorCode, ObjectParameter searchHeaderID);    
    	ObjectResult<BatchJob_RegimeActivity_ActivityScheduling_Result> BatchJob_RegimeActivity_ActivityScheduling(Nullable<System.DateTime> day, string regimeTypeCode, Nullable<long> regimeActivityIRISObjectID);    
    	void BatchJob_Search_DeleteOldSearchResults();    
    	void AdvancedSearchRequest(Nullable<long> scopeObjectTypeID, Nullable<long> userID, Nullable<bool> isSpatialSearch, string spatialIDs, string requestTypeIDs, string requestSubjectTypeIDs, string requestSubjectIDs, string requestPriorityIDs, Nullable<long> officerResponsible, string requestOrganisationPersonName, string requestContactRelationshipTypeIDs, string requestDetails, Nullable<System.DateTime> requestDateFrom, Nullable<System.DateTime> requestDateTo, string requestStatusIDs, string basicSearchKeywords, Nullable<long> speciesTypeID, Nullable<long> speciesID, string linkedContactOrganisationPersonName, string linkedContactRelationshipTypeIDs, string cdfCriteria, ObjectParameter errorCode, ObjectParameter searchHeaderID);    
    	void Workflow_CopyCallMappings(Nullable<long> sourceWorkflowDefinitionID, Nullable<long> targetWorkflowDefinitionID, Nullable<System.DateTime> startDate, string createdBy, Nullable<System.DateTime> dateCreated);    
    	void Workflow_CopyTaskDefinitions(Nullable<long> sourceWorkflowDefinitionID, Nullable<long> targetWorkflowDefinitionID, string modifiedBy, Nullable<System.DateTime> lastModified);    
    	void PopulateInheritedIRISObjectSecurityContext(Nullable<long> iRISObjectID);    
    	ObjectResult<User> ListUsersWithEditAccessToIRISObjects(string iRISObjectIDs, Nullable<bool> onlyIncludeActiveUser, Nullable<bool> ignoreDataSecurity);    
    	ObjectResult<Group> ListGroupsWithEditAccessToIRISObjects(string iRISObjectIDs);    
    	void HasAssociateGeometry(Nullable<long> iRISObjectID, ObjectParameter hasAssociateGeometry);    
    	ObjectResult<Group> ListGroupsWithEditOrEventAccessToIRISObjects(string iRISObjectIDs);    
    	ObjectResult<Nullable<long>> ListTaskInstancesAssignedToUser(Nullable<long> userID, Nullable<long> groupID);    
    	ObjectResult<User> ListUsersWithEditOrEventAccessToIRISObjects(string iRISObjectIDs, Nullable<bool> onlyIncludeActiveUser, Nullable<bool> ignoreDataSecurity);    
    	ObjectResult<Nullable<long>> BulkReassignOfficerResponsible(Nullable<long> fromOfficerResponsibleID, Nullable<long> toOfficerResponsibleID, string currentUserAccountName, Nullable<long> userID, Nullable<long> groupID);    
    	ObjectResult<Nullable<long>> ListIRISObjectIDsForOfficerResponsible(Nullable<long> userID);    
    	ObjectResult<BatchRollForwardAnnualChargeResult> RollForwardAnnualCharges(Nullable<long> matchingYear, Nullable<long> matchingPeriod, Nullable<long> toYear, Nullable<long> toPeriod, string currentUserAccountName);    
    	void CalculateWorkingDays(Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<long> applicationID, ObjectParameter numWorkingDays);    
    	void AdvancedSearchGeneralRegister(Nullable<long> scopeObjectTypeID, Nullable<long> userID, Nullable<bool> isSpatialSearch, string spatialIDs, Nullable<long> registerTypeID, string registerStatusIDs, string basicSearchKeywords, string contactOrganisationPersonName, string linkedContactRelationshipTypeIDs, string cdfCriteria, ObjectParameter errorCode, ObjectParameter searchHeaderID);    
    	ObjectResult<string> GetBusinessDataXML(Nullable<long> iRISObjectId, string objectTypeCode, Nullable<long> parentIRISObjectId);    
    	ObjectResult<IRISObject> BatchJob_GetIRISObjectWithoutWorkflowForLastNumberDays(Nullable<int> numberOfDays, string objectType);    
    	ObjectResult<IRISObject> BatchJob_GetRegimeActivityForMobileForLastNumberDays(Nullable<int> numberOfDays);    
    	void DeleteObject(Nullable<long> objectId, string objectTypeCode);    
    	void DeleteSpatialLocation(Nullable<long> iRISObjectID);    
    	void GetLatestSingleSpatialLocation(Nullable<long> iRISObjectID, ObjectParameter xcoordinate, ObjectParameter ycoordinate);    
    	void GetMergedToContactID(Nullable<long> contactID, ObjectParameter mergedToContactID);    
    	ObjectResult<string> GetOnlineServiceObjectDetailsXML(Nullable<long> objectId, string objectTypeCode);    
    	void UpdateActivityObjectRelationshipReference(string tableName, string columnName, Nullable<long> oldLinkID, Nullable<long> newLinkID);    
    	void CalculateFinalDateForFilingChargingDocuments(Nullable<long> enforcementID, ObjectParameter dueDate);    
    	ObjectResult<string> GetRegisterObjectDetailsXML(Nullable<long> objectId);    
    	void CreateSearchV2(string searchCriteria, Nullable<long> scopeObjectTypeID, Nullable<long> scopeSubClass1ID, Nullable<long> userID, Nullable<bool> isSpatialSearch, ObjectParameter searchHeaderID, ObjectParameter errorCode);    
    	void RunSearchV2(Nullable<long> searchHeaderID);    
    	ObjectResult<SearchIndex> SelectSearchResultsByPageV2(Nullable<long> searchHeaderID, string sortExpression, Nullable<int> pageSize, Nullable<int> pageCount, string excludeObjectIDs, ObjectParameter searchCount);    
    	void DeleteSearchSuggestion(Nullable<long> searchHeaderId);    
    	ObjectResult<Nullable<int>> GetSearchResultsCount(string searchCriteria, Nullable<long> scopeObjectTypeId, Nullable<long> userId);    
    	ObjectResult<SearchSuggestions> GetSearchSuggestions(string searchCriteria, Nullable<long> scopeObjectTypeId, Nullable<long> userId);    
    	ObjectResult<string> GetCDFListNameWithMissingMandatoryAnswer(Nullable<long> iRISObjectID);    
    	void IndexForCDFSearchableQuestionDefinition(Nullable<long> questionDefinitionId);    
    	void CopyActivityCDFAnswersToAuthorisation(Nullable<long> authorisationID);    
    	ObjectResult<ParentReferenceDataSummary> ListReferenceDataCollectionParentValues(Nullable<long> collectionID);    
    	void ReIndexIRISObject(Nullable<long> irisObjectId);    
    	ObjectResult<LinkedObjectDTO> ListLinkedObjects(string userName, Nullable<long> iRISObjectID, Nullable<bool> includeExpiredLinks, string searchForObjectTypeIDsSummary, string includedObjectTypeCodes, string excludedObjectTypeCodes, string includeRelationshipTypeCodes, string excludeRelationshipTypeCodes, string sortColumn, string sortDirection, Nullable<int> pageSize, Nullable<int> pageNumber);    
    	ObjectResult<ActivityObjectRelationship> ListActivityObjectRelationships(string userName, string activityObjectRelationshipIDs);    
    	void ContactBulkLoadItemDelete(Nullable<System.Guid> batchGuid);    
    	void AdvancedSearchContact(Nullable<long> scopeObjectTypeID, Nullable<long> userID, Nullable<bool> isSpatialSearch, string spatialIDs, Nullable<long> contactID, Nullable<bool> includeDuplicates, Nullable<bool> excludeDeceased, string firstName, string lastName, string orgName, Nullable<long> orgCompanyNumber, Nullable<int> streetNumber, string streetAlpha, string streetName, string suburb, string phoneNumber, string towncityUrban, string towncityDelivery, string deliveryServiceIdentifier, string boxLobby, string address, Nullable<long> countryID, string basicSearchKeywords, string contactOrganisationPersonName, string linkedContactRelationshipTypeIDs, string cdfCriteria, ObjectParameter errorCode, ObjectParameter searchHeaderID);    
    	void DuplicateContactSearch(Nullable<long> scopeObjectTypeID, Nullable<long> userID, Nullable<bool> isSpatialSearch, string spatialIDs, string firstName, string lastName, string organisationName, string emailAddress, string websiteURL, string phoneNumber, string deliveryServiceIdentifier, string deliveryBoxLobby, string deliveryTownCity, string urbanStreetName, string urbanSuburb, string urbanTownCity, string overseasAddressLine1, string overseasAddressLine2, string overseasAddressLine3, string overseasAddressLine4, string overseasAddressLine5, Nullable<long> overseasCountryREFID, ObjectParameter errorCode, ObjectParameter searchHeaderID);    
    	ObjectResult<GetChangedContacts_Result> GetChangedContacts(Nullable<System.DateTime> changedSince);    
    	void CalculateInformationSwornDueDate(Nullable<long> enforcementID, ObjectParameter dueDate);    
    	void CalculateInfringementNoticeServedDueDate(Nullable<long> iRISObjectID, ObjectParameter dueDate);    
    	void AdvancedSearchEnforcement(Nullable<long> scopeObjectTypeID, Nullable<long> userID, Nullable<bool> isSpatialSearch, string spatialIDs, string briefDescription, Nullable<long> actionREFID, Nullable<long> actionTypeREFID, Nullable<long> actREFID, Nullable<long> offenceSectionREFID, Nullable<long> natureOfOffenceREFID, Nullable<System.DateTime> offenceStart, Nullable<System.DateTime> offenceEnd, Nullable<long> officerResponsible, Nullable<long> statusREFID, string basicSearchKeywords, string contactOrganisationPersonName, string linkedContactRelationshipTypeIDs, string cdfCriteria, ObjectParameter errorCode, ObjectParameter searchHeaderID);    
    	void AdvancedSearchManagementSite(Nullable<long> scopeObjectTypeID, Nullable<long> userID, Nullable<bool> isSpatialSearch, string spatialIDs, string managementSiteTypeID, string managementSiteSubtypeIDs, Nullable<long> officerResponsibleID, Nullable<long> habitatID, Nullable<long> statusID, Nullable<long> classificationTypeID, string classificationIDs, Nullable<long> conservationSpeciesTypeID, Nullable<long> conservationSpeciesID, Nullable<long> threatSpeciesTypeID, Nullable<long> threatSpeciesID, Nullable<long> industryPurposeID, Nullable<long> situationID, string description, string basicSearchKeywords, string contactOrganisationPersonName, string linkedContactRelationshipTypeIDs, string cdfCriteria, ObjectParameter errorCode, ObjectParameter searchHeaderID);    
    	void ObservationMngtMonitoring_TargetSpeciesResultPercent(Nullable<long> observationMngtID, ObjectParameter lineMonitoringTargetSpeciesResultPercent);    
    	ObjectResult<ObservationRemediationSummary> GetListObservationRemediationSummary(Nullable<long> iRISObjectID, string userName);    
    	void LinkObservationToManagementSite(Nullable<long> observationID, Nullable<long> managementSiteID, string currentUser);    
    	ObjectResult<RegimeActivity> UpdateRegimeActivitiesOfficerResponsibleForRegime(Nullable<long> regimeID, Nullable<long> officerResponsiblePreviousID, Nullable<long> officerResponsibleCurrentID, string currentUserAccountName);    
    	ObjectResult<GetEstimateRatesByFinancialYearId_Result> GetEstimateRatesByFinancialYearId(Nullable<long> financialYearId);    
    	ObjectResult<GetEstimateRatesForFinancialYearId_Result> GetEstimateRatesForFinancialYearId(Nullable<long> financialYearId);    
    	ObjectResult<GetEstimateRatesFromFinancialYearId_Result> GetEstimateRatesFromFinancialYearId(Nullable<long> financialYearId);    
    	ObjectResult<GetReferenceDataValueRatesByFinancialYearId_Result> GetReferenceDataValueRatesByFinancialYearId(Nullable<long> financialYearId);    
    	ObjectResult<ObservationRemediationSummary> ListObservationRemediationSummary(Nullable<long> iRISObjectID, string userName);    
    	void PropertyDataImportReset();    
    	void PropertyDataImport(Nullable<long> propertyDataDVRUploadID);    
    	void PropertyDataImportDelete(Nullable<long> propertyDataDVRUploadID);    
    	void AdvancedSearchSLUS(Nullable<long> scopeObjectTypeID, Nullable<long> userID, string siteDescription, Nullable<bool> isSpatialSearch, string spatialIDs, string siteStatusIDs, string siteClassificationIDs, string siteClassificationContextIDs, string siteHAILGroupIDs, string siteHAILCategoryIDs, string siteContaminantTypeIDs, string siteContaminantIDs, string basicSearchKeywords, string contactOrganisationPersonName, string linkedContactRelationshipTypeIDs, string cdfCriteria, ObjectParameter errorCode, ObjectParameter searchHeaderID);    

            #endregion

    }
}
