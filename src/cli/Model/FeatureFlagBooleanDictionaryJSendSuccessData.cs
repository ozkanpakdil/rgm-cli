/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace cli.Model;

/// <summary>
///     FeatureFlagBooleanDictionaryJSendSuccessData
/// </summary>
[DataContract(Name = "FeatureFlagBooleanDictionaryJSendSuccess_data")]
public class FeatureFlagBooleanDictionaryJSendSuccessData : IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="FeatureFlagBooleanDictionaryJSendSuccessData" /> class.
    /// </summary>
    /// <param name="licensing">licensing.</param>
    /// <param name="forceOfflineLicensing">forceOfflineLicensing.</param>
    /// <param name="subscriptionsUseUatPermits">subscriptionsUseUatPermits.</param>
    /// <param name="errorReporting">errorReporting.</param>
    /// <param name="instanceDiscovery">instanceDiscovery.</param>
    /// <param name="multiBaseMonitorInstanceDiscovery">multiBaseMonitorInstanceDiscovery.</param>
    /// <param name="registryReading">registryReading.</param>
    /// <param name="scriptAlertResponse">scriptAlertResponse.</param>
    /// <param name="enumerateGroupMembership">enumerateGroupMembership.</param>
    /// <param name="alwaysRedactQueryPlanParameters">alwaysRedactQueryPlanParameters.</param>
    /// <param name="showPreviewAlertEmail">showPreviewAlertEmail.</param>
    /// <param name="allowVersionMismatchBetweenWebsiteAndBaseMonitors">allowVersionMismatchBetweenWebsiteAndBaseMonitors.</param>
    /// <param name="allowVersionMismatchBetweenWebsiteAndPowerShellModule">allowVersionMismatchBetweenWebsiteAndPowerShellModule.</param>
    /// <param name="azureMiReplicationLinks">azureMiReplicationLinks.</param>
    /// <param name="azureSqlDatabaseReplicationLinks">azureSqlDatabaseReplicationLinks.</param>
    /// <param name="cloudCosts">cloudCosts.</param>
    /// <param name="garbageCollectionFur">garbageCollectionFur.</param>
    /// <param name="uiTestBench">uiTestBench.</param>
    /// <param name="errorReportingTesting">errorReportingTesting.</param>
    /// <param name="networkConnectionStatsFur">networkConnectionStatsFur.</param>
    /// <param name="highAvailability">highAvailability.</param>
    /// <param name="linuxSupport">linuxSupport.</param>
    /// <param name="showLinkToLinuxTestnet">showLinkToLinuxTestnet.</param>
    /// <param name="diagnosticsVisible">diagnosticsVisible.</param>
    /// <param name="optimizeForKnownStatistics">optimizeForKnownStatistics.</param>
    /// <param name="multiBaseMonitorGlobalDashboard">multiBaseMonitorGlobalDashboard.</param>
    /// <param name="fastBaseMonitorShutdown">fastBaseMonitorShutdown.</param>
    /// <param name="useContentSecurityPolicyNonce">useContentSecurityPolicyNonce.</param>
    /// <param name="recordDatabaseTimings">recordDatabaseTimings.</param>
    /// <param name="machineLearningForecastEvaluation">machineLearningForecastEvaluation.</param>
    /// <param name="machineLearningForecasting">machineLearningForecasting.</param>
    /// <param name="crossDbMonitoring">crossDbMonitoring.</param>
    /// <param name="crossDbHostlessMonitoring">crossDbHostlessMonitoring.</param>
    /// <param name="nonParallelPermissionSampling">nonParallelPermissionSampling.</param>
    /// <param name="perpetualLicense">perpetualLicense.</param>
    /// <param name="publicApi">publicApi.</param>
    /// <param name="bulkCustomMetricCollection">bulkCustomMetricCollection.</param>
    /// <param name="useAws">useAws.</param>
    /// <param name="saaS">saaS.</param>
    /// <param name="testFlagWithNoAttributes">testFlagWithNoAttributes.</param>
    /// <param name="testFlagWithEnabledByDefaultAttribute">testFlagWithEnabledByDefaultAttribute.</param>
    /// <param name="testFlagWithEnabledInTestNetAttribute">testFlagWithEnabledInTestNetAttribute.</param>
    /// <param name="testFlagWithEnabledInDemoSiteAttribute">testFlagWithEnabledInDemoSiteAttribute.</param>
    /// <param name="removeUndetectedSqlServers">removeUndetectedSqlServers.</param>
    /// <param name="timescaleDBRepository">timescaleDBRepository.</param>
    /// <param name="ignoreQueryThrottlingFilters">ignoreQueryThrottlingFilters.</param>
    /// <param name="xeLongRunningQueryStartAndEndTimeSampling">xeLongRunningQueryStartAndEndTimeSampling.</param>
    /// <param name="newPermissionsData">newPermissionsData.</param>
    /// <param name="useNewCreateCustomMetricPage">useNewCreateCustomMetricPage.</param>
    /// <param name="oidcAuthCode">oidcAuthCode.</param>
    /// <param name="postgresIndexes">postgresIndexes.</param>
    /// <param name="greaterThanOrEqualToComparatorInComplianceTemplates">greaterThanOrEqualToComparatorInComplianceTemplates.</param>
    public FeatureFlagBooleanDictionaryJSendSuccessData(bool licensing = default, bool forceOfflineLicensing = default,
        bool subscriptionsUseUatPermits = default, bool errorReporting = default, bool instanceDiscovery = default,
        bool multiBaseMonitorInstanceDiscovery = default, bool registryReading = default,
        bool scriptAlertResponse = default, bool enumerateGroupMembership = default,
        bool alwaysRedactQueryPlanParameters = default, bool showPreviewAlertEmail = default,
        bool allowVersionMismatchBetweenWebsiteAndBaseMonitors = default,
        bool allowVersionMismatchBetweenWebsiteAndPowerShellModule = default, bool azureMiReplicationLinks = default,
        bool azureSqlDatabaseReplicationLinks = default, bool cloudCosts = default, bool garbageCollectionFur = default,
        bool uiTestBench = default, bool errorReportingTesting = default, bool networkConnectionStatsFur = default,
        bool highAvailability = default, bool linuxSupport = default, bool showLinkToLinuxTestnet = default,
        bool diagnosticsVisible = default, bool optimizeForKnownStatistics = default,
        bool multiBaseMonitorGlobalDashboard = default, bool fastBaseMonitorShutdown = default,
        bool useContentSecurityPolicyNonce = default, bool recordDatabaseTimings = default,
        bool machineLearningForecastEvaluation = default, bool machineLearningForecasting = default,
        bool crossDbMonitoring = default, bool crossDbHostlessMonitoring = default,
        bool nonParallelPermissionSampling = default, bool perpetualLicense = default, bool publicApi = default,
        bool bulkCustomMetricCollection = default, bool useAws = default, bool saaS = default,
        bool testFlagWithNoAttributes = default, bool testFlagWithEnabledByDefaultAttribute = default,
        bool testFlagWithEnabledInTestNetAttribute = default, bool testFlagWithEnabledInDemoSiteAttribute = default,
        bool removeUndetectedSqlServers = default, bool timescaleDBRepository = default,
        bool ignoreQueryThrottlingFilters = default, bool xeLongRunningQueryStartAndEndTimeSampling = default,
        bool newPermissionsData = default, bool useNewCreateCustomMetricPage = default, bool oidcAuthCode = default,
        bool postgresIndexes = default, bool greaterThanOrEqualToComparatorInComplianceTemplates = default)
    {
        Licensing = licensing;
        ForceOfflineLicensing = forceOfflineLicensing;
        SubscriptionsUseUatPermits = subscriptionsUseUatPermits;
        ErrorReporting = errorReporting;
        InstanceDiscovery = instanceDiscovery;
        MultiBaseMonitorInstanceDiscovery = multiBaseMonitorInstanceDiscovery;
        RegistryReading = registryReading;
        ScriptAlertResponse = scriptAlertResponse;
        EnumerateGroupMembership = enumerateGroupMembership;
        AlwaysRedactQueryPlanParameters = alwaysRedactQueryPlanParameters;
        ShowPreviewAlertEmail = showPreviewAlertEmail;
        AllowVersionMismatchBetweenWebsiteAndBaseMonitors = allowVersionMismatchBetweenWebsiteAndBaseMonitors;
        AllowVersionMismatchBetweenWebsiteAndPowerShellModule = allowVersionMismatchBetweenWebsiteAndPowerShellModule;
        AzureMiReplicationLinks = azureMiReplicationLinks;
        AzureSqlDatabaseReplicationLinks = azureSqlDatabaseReplicationLinks;
        CloudCosts = cloudCosts;
        GarbageCollectionFur = garbageCollectionFur;
        UiTestBench = uiTestBench;
        ErrorReportingTesting = errorReportingTesting;
        NetworkConnectionStatsFur = networkConnectionStatsFur;
        HighAvailability = highAvailability;
        LinuxSupport = linuxSupport;
        ShowLinkToLinuxTestnet = showLinkToLinuxTestnet;
        DiagnosticsVisible = diagnosticsVisible;
        OptimizeForKnownStatistics = optimizeForKnownStatistics;
        MultiBaseMonitorGlobalDashboard = multiBaseMonitorGlobalDashboard;
        FastBaseMonitorShutdown = fastBaseMonitorShutdown;
        UseContentSecurityPolicyNonce = useContentSecurityPolicyNonce;
        RecordDatabaseTimings = recordDatabaseTimings;
        MachineLearningForecastEvaluation = machineLearningForecastEvaluation;
        MachineLearningForecasting = machineLearningForecasting;
        CrossDbMonitoring = crossDbMonitoring;
        CrossDbHostlessMonitoring = crossDbHostlessMonitoring;
        NonParallelPermissionSampling = nonParallelPermissionSampling;
        PerpetualLicense = perpetualLicense;
        PublicApi = publicApi;
        BulkCustomMetricCollection = bulkCustomMetricCollection;
        UseAws = useAws;
        SaaS = saaS;
        TestFlagWithNoAttributes = testFlagWithNoAttributes;
        TestFlagWithEnabledByDefaultAttribute = testFlagWithEnabledByDefaultAttribute;
        TestFlagWithEnabledInTestNetAttribute = testFlagWithEnabledInTestNetAttribute;
        TestFlagWithEnabledInDemoSiteAttribute = testFlagWithEnabledInDemoSiteAttribute;
        RemoveUndetectedSqlServers = removeUndetectedSqlServers;
        TimescaleDBRepository = timescaleDBRepository;
        IgnoreQueryThrottlingFilters = ignoreQueryThrottlingFilters;
        XeLongRunningQueryStartAndEndTimeSampling = xeLongRunningQueryStartAndEndTimeSampling;
        NewPermissionsData = newPermissionsData;
        UseNewCreateCustomMetricPage = useNewCreateCustomMetricPage;
        OidcAuthCode = oidcAuthCode;
        PostgresIndexes = postgresIndexes;
        GreaterThanOrEqualToComparatorInComplianceTemplates = greaterThanOrEqualToComparatorInComplianceTemplates;
    }

    /// <summary>
    ///     Gets or Sets Licensing
    /// </summary>
    [DataMember(Name = "Licensing", EmitDefaultValue = true)]
    public bool Licensing { get; set; }

    /// <summary>
    ///     Gets or Sets ForceOfflineLicensing
    /// </summary>
    [DataMember(Name = "ForceOfflineLicensing", EmitDefaultValue = true)]
    public bool ForceOfflineLicensing { get; set; }

    /// <summary>
    ///     Gets or Sets SubscriptionsUseUatPermits
    /// </summary>
    [DataMember(Name = "SubscriptionsUseUatPermits", EmitDefaultValue = true)]
    public bool SubscriptionsUseUatPermits { get; set; }

    /// <summary>
    ///     Gets or Sets ErrorReporting
    /// </summary>
    [DataMember(Name = "ErrorReporting", EmitDefaultValue = true)]
    public bool ErrorReporting { get; set; }

    /// <summary>
    ///     Gets or Sets InstanceDiscovery
    /// </summary>
    [DataMember(Name = "InstanceDiscovery", EmitDefaultValue = true)]
    public bool InstanceDiscovery { get; set; }

    /// <summary>
    ///     Gets or Sets MultiBaseMonitorInstanceDiscovery
    /// </summary>
    [DataMember(Name = "MultiBaseMonitorInstanceDiscovery", EmitDefaultValue = true)]
    public bool MultiBaseMonitorInstanceDiscovery { get; set; }

    /// <summary>
    ///     Gets or Sets RegistryReading
    /// </summary>
    [DataMember(Name = "RegistryReading", EmitDefaultValue = true)]
    public bool RegistryReading { get; set; }

    /// <summary>
    ///     Gets or Sets ScriptAlertResponse
    /// </summary>
    [DataMember(Name = "ScriptAlertResponse", EmitDefaultValue = true)]
    public bool ScriptAlertResponse { get; set; }

    /// <summary>
    ///     Gets or Sets EnumerateGroupMembership
    /// </summary>
    [DataMember(Name = "EnumerateGroupMembership", EmitDefaultValue = true)]
    public bool EnumerateGroupMembership { get; set; }

    /// <summary>
    ///     Gets or Sets AlwaysRedactQueryPlanParameters
    /// </summary>
    [DataMember(Name = "AlwaysRedactQueryPlanParameters", EmitDefaultValue = true)]
    public bool AlwaysRedactQueryPlanParameters { get; set; }

    /// <summary>
    ///     Gets or Sets ShowPreviewAlertEmail
    /// </summary>
    [DataMember(Name = "ShowPreviewAlertEmail", EmitDefaultValue = true)]
    public bool ShowPreviewAlertEmail { get; set; }

    /// <summary>
    ///     Gets or Sets AllowVersionMismatchBetweenWebsiteAndBaseMonitors
    /// </summary>
    [DataMember(Name = "AllowVersionMismatchBetweenWebsiteAndBaseMonitors", EmitDefaultValue = true)]
    public bool AllowVersionMismatchBetweenWebsiteAndBaseMonitors { get; set; }

    /// <summary>
    ///     Gets or Sets AllowVersionMismatchBetweenWebsiteAndPowerShellModule
    /// </summary>
    [DataMember(Name = "AllowVersionMismatchBetweenWebsiteAndPowerShellModule", EmitDefaultValue = true)]
    public bool AllowVersionMismatchBetweenWebsiteAndPowerShellModule { get; set; }

    /// <summary>
    ///     Gets or Sets AzureMiReplicationLinks
    /// </summary>
    [DataMember(Name = "AzureMiReplicationLinks", EmitDefaultValue = true)]
    public bool AzureMiReplicationLinks { get; set; }

    /// <summary>
    ///     Gets or Sets AzureSqlDatabaseReplicationLinks
    /// </summary>
    [DataMember(Name = "AzureSqlDatabaseReplicationLinks", EmitDefaultValue = true)]
    public bool AzureSqlDatabaseReplicationLinks { get; set; }

    /// <summary>
    ///     Gets or Sets CloudCosts
    /// </summary>
    [DataMember(Name = "CloudCosts", EmitDefaultValue = true)]
    public bool CloudCosts { get; set; }

    /// <summary>
    ///     Gets or Sets GarbageCollectionFur
    /// </summary>
    [DataMember(Name = "GarbageCollectionFur", EmitDefaultValue = true)]
    public bool GarbageCollectionFur { get; set; }

    /// <summary>
    ///     Gets or Sets UiTestBench
    /// </summary>
    [DataMember(Name = "UiTestBench", EmitDefaultValue = true)]
    public bool UiTestBench { get; set; }

    /// <summary>
    ///     Gets or Sets ErrorReportingTesting
    /// </summary>
    [DataMember(Name = "ErrorReportingTesting", EmitDefaultValue = true)]
    public bool ErrorReportingTesting { get; set; }

    /// <summary>
    ///     Gets or Sets NetworkConnectionStatsFur
    /// </summary>
    [DataMember(Name = "NetworkConnectionStatsFur", EmitDefaultValue = true)]
    public bool NetworkConnectionStatsFur { get; set; }

    /// <summary>
    ///     Gets or Sets HighAvailability
    /// </summary>
    [DataMember(Name = "HighAvailability", EmitDefaultValue = true)]
    public bool HighAvailability { get; set; }

    /// <summary>
    ///     Gets or Sets LinuxSupport
    /// </summary>
    [DataMember(Name = "LinuxSupport", EmitDefaultValue = true)]
    public bool LinuxSupport { get; set; }

    /// <summary>
    ///     Gets or Sets ShowLinkToLinuxTestnet
    /// </summary>
    [DataMember(Name = "ShowLinkToLinuxTestnet", EmitDefaultValue = true)]
    public bool ShowLinkToLinuxTestnet { get; set; }

    /// <summary>
    ///     Gets or Sets DiagnosticsVisible
    /// </summary>
    [DataMember(Name = "DiagnosticsVisible", EmitDefaultValue = true)]
    public bool DiagnosticsVisible { get; set; }

    /// <summary>
    ///     Gets or Sets OptimizeForKnownStatistics
    /// </summary>
    [DataMember(Name = "OptimizeForKnownStatistics", EmitDefaultValue = true)]
    public bool OptimizeForKnownStatistics { get; set; }

    /// <summary>
    ///     Gets or Sets MultiBaseMonitorGlobalDashboard
    /// </summary>
    [DataMember(Name = "MultiBaseMonitorGlobalDashboard", EmitDefaultValue = true)]
    public bool MultiBaseMonitorGlobalDashboard { get; set; }

    /// <summary>
    ///     Gets or Sets FastBaseMonitorShutdown
    /// </summary>
    [DataMember(Name = "FastBaseMonitorShutdown", EmitDefaultValue = true)]
    public bool FastBaseMonitorShutdown { get; set; }

    /// <summary>
    ///     Gets or Sets UseContentSecurityPolicyNonce
    /// </summary>
    [DataMember(Name = "UseContentSecurityPolicyNonce", EmitDefaultValue = true)]
    public bool UseContentSecurityPolicyNonce { get; set; }

    /// <summary>
    ///     Gets or Sets RecordDatabaseTimings
    /// </summary>
    [DataMember(Name = "RecordDatabaseTimings", EmitDefaultValue = true)]
    public bool RecordDatabaseTimings { get; set; }

    /// <summary>
    ///     Gets or Sets MachineLearningForecastEvaluation
    /// </summary>
    [DataMember(Name = "MachineLearningForecastEvaluation", EmitDefaultValue = true)]
    public bool MachineLearningForecastEvaluation { get; set; }

    /// <summary>
    ///     Gets or Sets MachineLearningForecasting
    /// </summary>
    [DataMember(Name = "MachineLearningForecasting", EmitDefaultValue = true)]
    public bool MachineLearningForecasting { get; set; }

    /// <summary>
    ///     Gets or Sets CrossDbMonitoring
    /// </summary>
    [DataMember(Name = "CrossDbMonitoring", EmitDefaultValue = true)]
    public bool CrossDbMonitoring { get; set; }

    /// <summary>
    ///     Gets or Sets CrossDbHostlessMonitoring
    /// </summary>
    [DataMember(Name = "CrossDbHostlessMonitoring", EmitDefaultValue = true)]
    public bool CrossDbHostlessMonitoring { get; set; }

    /// <summary>
    ///     Gets or Sets NonParallelPermissionSampling
    /// </summary>
    [DataMember(Name = "NonParallelPermissionSampling", EmitDefaultValue = true)]
    public bool NonParallelPermissionSampling { get; set; }

    /// <summary>
    ///     Gets or Sets PerpetualLicense
    /// </summary>
    [DataMember(Name = "PerpetualLicense", EmitDefaultValue = true)]
    public bool PerpetualLicense { get; set; }

    /// <summary>
    ///     Gets or Sets PublicApi
    /// </summary>
    [DataMember(Name = "PublicApi", EmitDefaultValue = true)]
    public bool PublicApi { get; set; }

    /// <summary>
    ///     Gets or Sets BulkCustomMetricCollection
    /// </summary>
    [DataMember(Name = "BulkCustomMetricCollection", EmitDefaultValue = true)]
    public bool BulkCustomMetricCollection { get; set; }

    /// <summary>
    ///     Gets or Sets UseAws
    /// </summary>
    [DataMember(Name = "UseAws", EmitDefaultValue = true)]
    public bool UseAws { get; set; }

    /// <summary>
    ///     Gets or Sets SaaS
    /// </summary>
    [DataMember(Name = "SaaS", EmitDefaultValue = true)]
    public bool SaaS { get; set; }

    /// <summary>
    ///     Gets or Sets TestFlagWithNoAttributes
    /// </summary>
    [DataMember(Name = "TestFlag_WithNoAttributes", EmitDefaultValue = true)]
    public bool TestFlagWithNoAttributes { get; set; }

    /// <summary>
    ///     Gets or Sets TestFlagWithEnabledByDefaultAttribute
    /// </summary>
    [DataMember(Name = "TestFlag_WithEnabledByDefaultAttribute", EmitDefaultValue = true)]
    public bool TestFlagWithEnabledByDefaultAttribute { get; set; }

    /// <summary>
    ///     Gets or Sets TestFlagWithEnabledInTestNetAttribute
    /// </summary>
    [DataMember(Name = "TestFlag_WithEnabledInTestNetAttribute", EmitDefaultValue = true)]
    public bool TestFlagWithEnabledInTestNetAttribute { get; set; }

    /// <summary>
    ///     Gets or Sets TestFlagWithEnabledInDemoSiteAttribute
    /// </summary>
    [DataMember(Name = "TestFlag_WithEnabledInDemoSiteAttribute", EmitDefaultValue = true)]
    public bool TestFlagWithEnabledInDemoSiteAttribute { get; set; }

    /// <summary>
    ///     Gets or Sets RemoveUndetectedSqlServers
    /// </summary>
    [DataMember(Name = "RemoveUndetectedSqlServers", EmitDefaultValue = true)]
    public bool RemoveUndetectedSqlServers { get; set; }

    /// <summary>
    ///     Gets or Sets TimescaleDBRepository
    /// </summary>
    [DataMember(Name = "TimescaleDBRepository", EmitDefaultValue = true)]
    public bool TimescaleDBRepository { get; set; }

    /// <summary>
    ///     Gets or Sets IgnoreQueryThrottlingFilters
    /// </summary>
    [DataMember(Name = "IgnoreQueryThrottlingFilters", EmitDefaultValue = true)]
    public bool IgnoreQueryThrottlingFilters { get; set; }

    /// <summary>
    ///     Gets or Sets XeLongRunningQueryStartAndEndTimeSampling
    /// </summary>
    [DataMember(Name = "XeLongRunningQueryStartAndEndTimeSampling", EmitDefaultValue = true)]
    public bool XeLongRunningQueryStartAndEndTimeSampling { get; set; }

    /// <summary>
    ///     Gets or Sets NewPermissionsData
    /// </summary>
    [DataMember(Name = "NewPermissionsData", EmitDefaultValue = true)]
    public bool NewPermissionsData { get; set; }

    /// <summary>
    ///     Gets or Sets UseNewCreateCustomMetricPage
    /// </summary>
    [DataMember(Name = "UseNewCreateCustomMetricPage", EmitDefaultValue = true)]
    public bool UseNewCreateCustomMetricPage { get; set; }

    /// <summary>
    ///     Gets or Sets OidcAuthCode
    /// </summary>
    [DataMember(Name = "OidcAuthCode", EmitDefaultValue = true)]
    public bool OidcAuthCode { get; set; }

    /// <summary>
    ///     Gets or Sets PostgresIndexes
    /// </summary>
    [DataMember(Name = "PostgresIndexes", EmitDefaultValue = true)]
    public bool PostgresIndexes { get; set; }

    /// <summary>
    ///     Gets or Sets GreaterThanOrEqualToComparatorInComplianceTemplates
    /// </summary>
    [DataMember(Name = "GreaterThanOrEqualToComparatorInComplianceTemplates", EmitDefaultValue = true)]
    public bool GreaterThanOrEqualToComparatorInComplianceTemplates { get; set; }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
    {
        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FeatureFlagBooleanDictionaryJSendSuccessData {\n");
        sb.Append("  Licensing: ").Append(Licensing).Append("\n");
        sb.Append("  ForceOfflineLicensing: ").Append(ForceOfflineLicensing).Append("\n");
        sb.Append("  SubscriptionsUseUatPermits: ").Append(SubscriptionsUseUatPermits).Append("\n");
        sb.Append("  ErrorReporting: ").Append(ErrorReporting).Append("\n");
        sb.Append("  InstanceDiscovery: ").Append(InstanceDiscovery).Append("\n");
        sb.Append("  MultiBaseMonitorInstanceDiscovery: ").Append(MultiBaseMonitorInstanceDiscovery).Append("\n");
        sb.Append("  RegistryReading: ").Append(RegistryReading).Append("\n");
        sb.Append("  ScriptAlertResponse: ").Append(ScriptAlertResponse).Append("\n");
        sb.Append("  EnumerateGroupMembership: ").Append(EnumerateGroupMembership).Append("\n");
        sb.Append("  AlwaysRedactQueryPlanParameters: ").Append(AlwaysRedactQueryPlanParameters).Append("\n");
        sb.Append("  ShowPreviewAlertEmail: ").Append(ShowPreviewAlertEmail).Append("\n");
        sb.Append("  AllowVersionMismatchBetweenWebsiteAndBaseMonitors: ")
            .Append(AllowVersionMismatchBetweenWebsiteAndBaseMonitors).Append("\n");
        sb.Append("  AllowVersionMismatchBetweenWebsiteAndPowerShellModule: ")
            .Append(AllowVersionMismatchBetweenWebsiteAndPowerShellModule).Append("\n");
        sb.Append("  AzureMiReplicationLinks: ").Append(AzureMiReplicationLinks).Append("\n");
        sb.Append("  AzureSqlDatabaseReplicationLinks: ").Append(AzureSqlDatabaseReplicationLinks).Append("\n");
        sb.Append("  CloudCosts: ").Append(CloudCosts).Append("\n");
        sb.Append("  GarbageCollectionFur: ").Append(GarbageCollectionFur).Append("\n");
        sb.Append("  UiTestBench: ").Append(UiTestBench).Append("\n");
        sb.Append("  ErrorReportingTesting: ").Append(ErrorReportingTesting).Append("\n");
        sb.Append("  NetworkConnectionStatsFur: ").Append(NetworkConnectionStatsFur).Append("\n");
        sb.Append("  HighAvailability: ").Append(HighAvailability).Append("\n");
        sb.Append("  LinuxSupport: ").Append(LinuxSupport).Append("\n");
        sb.Append("  ShowLinkToLinuxTestnet: ").Append(ShowLinkToLinuxTestnet).Append("\n");
        sb.Append("  DiagnosticsVisible: ").Append(DiagnosticsVisible).Append("\n");
        sb.Append("  OptimizeForKnownStatistics: ").Append(OptimizeForKnownStatistics).Append("\n");
        sb.Append("  MultiBaseMonitorGlobalDashboard: ").Append(MultiBaseMonitorGlobalDashboard).Append("\n");
        sb.Append("  FastBaseMonitorShutdown: ").Append(FastBaseMonitorShutdown).Append("\n");
        sb.Append("  UseContentSecurityPolicyNonce: ").Append(UseContentSecurityPolicyNonce).Append("\n");
        sb.Append("  RecordDatabaseTimings: ").Append(RecordDatabaseTimings).Append("\n");
        sb.Append("  MachineLearningForecastEvaluation: ").Append(MachineLearningForecastEvaluation).Append("\n");
        sb.Append("  MachineLearningForecasting: ").Append(MachineLearningForecasting).Append("\n");
        sb.Append("  CrossDbMonitoring: ").Append(CrossDbMonitoring).Append("\n");
        sb.Append("  CrossDbHostlessMonitoring: ").Append(CrossDbHostlessMonitoring).Append("\n");
        sb.Append("  NonParallelPermissionSampling: ").Append(NonParallelPermissionSampling).Append("\n");
        sb.Append("  PerpetualLicense: ").Append(PerpetualLicense).Append("\n");
        sb.Append("  PublicApi: ").Append(PublicApi).Append("\n");
        sb.Append("  BulkCustomMetricCollection: ").Append(BulkCustomMetricCollection).Append("\n");
        sb.Append("  UseAws: ").Append(UseAws).Append("\n");
        sb.Append("  SaaS: ").Append(SaaS).Append("\n");
        sb.Append("  TestFlagWithNoAttributes: ").Append(TestFlagWithNoAttributes).Append("\n");
        sb.Append("  TestFlagWithEnabledByDefaultAttribute: ").Append(TestFlagWithEnabledByDefaultAttribute)
            .Append("\n");
        sb.Append("  TestFlagWithEnabledInTestNetAttribute: ").Append(TestFlagWithEnabledInTestNetAttribute)
            .Append("\n");
        sb.Append("  TestFlagWithEnabledInDemoSiteAttribute: ").Append(TestFlagWithEnabledInDemoSiteAttribute)
            .Append("\n");
        sb.Append("  RemoveUndetectedSqlServers: ").Append(RemoveUndetectedSqlServers).Append("\n");
        sb.Append("  TimescaleDBRepository: ").Append(TimescaleDBRepository).Append("\n");
        sb.Append("  IgnoreQueryThrottlingFilters: ").Append(IgnoreQueryThrottlingFilters).Append("\n");
        sb.Append("  XeLongRunningQueryStartAndEndTimeSampling: ").Append(XeLongRunningQueryStartAndEndTimeSampling)
            .Append("\n");
        sb.Append("  NewPermissionsData: ").Append(NewPermissionsData).Append("\n");
        sb.Append("  UseNewCreateCustomMetricPage: ").Append(UseNewCreateCustomMetricPage).Append("\n");
        sb.Append("  OidcAuthCode: ").Append(OidcAuthCode).Append("\n");
        sb.Append("  PostgresIndexes: ").Append(PostgresIndexes).Append("\n");
        sb.Append("  GreaterThanOrEqualToComparatorInComplianceTemplates: ")
            .Append(GreaterThanOrEqualToComparatorInComplianceTemplates).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    ///     Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}