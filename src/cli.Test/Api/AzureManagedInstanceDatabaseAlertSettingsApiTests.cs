/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using cli.Api;
using Xunit;

// uncomment below to import models
//using cli.Model;

namespace cli.Test.Api;

/// <summary>
///     Class for testing AzureManagedInstanceDatabaseAlertSettingsApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class AzureManagedInstanceDatabaseAlertSettingsApiTests : IDisposable
{
    private AzureManagedInstanceDatabaseAlertSettingsApi instance;

    public AzureManagedInstanceDatabaseAlertSettingsApiTests()
    {
        instance = new AzureManagedInstanceDatabaseAlertSettingsApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of AzureManagedInstanceDatabaseAlertSettingsApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' AzureManagedInstanceDatabaseAlertSettingsApi
        //Assert.IsType<AzureManagedInstanceDatabaseAlertSettingsApi>(instance);
    }

    /// <summary>
    ///     Test
    ///     ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string serverName = null;
        //string databaseName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //string? body = null;
        //instance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch(serverName, databaseName, alertTypeId, baseMonitorName, body);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string serverName = null;
        //string databaseName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //instance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet(serverName, databaseName, alertTypeId, baseMonitorName);
    }

    /// <summary>
    ///     Test
    ///     ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string serverName = null;
        //string databaseName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //AlertNotificationSettingsDto? alertNotificationSettingsDto = null;
        //instance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch(serverName, databaseName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
    }

    /// <summary>
    ///     Test
    ///     ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string serverName = null;
        //string databaseName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //Hashtable? requestBody = null;
        //instance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch(serverName, databaseName, alertTypeId, baseMonitorName, requestBody);
    }

    /// <summary>
    ///     Test
    ///     ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string serverName = null;
        //string databaseName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //int? body = null;
        //instance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch(serverName, databaseName, alertTypeId, baseMonitorName, body);
    }
}