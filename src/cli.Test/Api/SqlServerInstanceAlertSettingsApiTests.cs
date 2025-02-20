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
///     Class for testing SqlServerInstanceAlertSettingsApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class SqlServerInstanceAlertSettingsApiTests : IDisposable
{
    private SqlServerInstanceAlertSettingsApi instance;

    public SqlServerInstanceAlertSettingsApiTests()
    {
        instance = new SqlServerInstanceAlertSettingsApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of SqlServerInstanceAlertSettingsApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' SqlServerInstanceAlertSettingsApi
        //Assert.IsType<SqlServerInstanceAlertSettingsApi>(instance);
    }

    /// <summary>
    ///     Test
    ///     ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdCommentsPatch
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdCommentsPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string instanceName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //string linuxMachineName = null;
        //string? body = null;
        //instance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdCommentsPatch(instanceName, alertTypeId, baseMonitorName, linuxMachineName, body);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdGet
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string instanceName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //string linuxMachineName = null;
        //instance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdGet(instanceName, alertTypeId, baseMonitorName, linuxMachineName);
    }

    /// <summary>
    ///     Test
    ///     ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdNotificationsettingsPatch
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdNotificationsettingsPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string instanceName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //string linuxMachineName = null;
        //AlertNotificationSettingsDto? alertNotificationSettingsDto = null;
        //instance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdNotificationsettingsPatch(instanceName, alertTypeId, baseMonitorName, linuxMachineName, alertNotificationSettingsDto);
    }

    /// <summary>
    ///     Test
    ///     ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdSpecificsettingsPatch
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdSpecificsettingsPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string instanceName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //string linuxMachineName = null;
        //Hashtable? requestBody = null;
        //instance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdSpecificsettingsPatch(instanceName, alertTypeId, baseMonitorName, linuxMachineName, requestBody);
    }

    /// <summary>
    ///     Test
    ///     ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdStatusPatch
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdStatusPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string instanceName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //string linuxMachineName = null;
        //int? body = null;
        //instance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameAlertsettingsAlertTypeIdStatusPatch(instanceName, alertTypeId, baseMonitorName, linuxMachineName, body);
    }
}