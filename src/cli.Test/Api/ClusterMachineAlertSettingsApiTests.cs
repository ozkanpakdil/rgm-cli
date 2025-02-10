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
///     Class for testing ClusterMachineAlertSettingsApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class ClusterMachineAlertSettingsApiTests : IDisposable
{
    private ClusterMachineAlertSettingsApi instance;

    public ClusterMachineAlertSettingsApiTests()
    {
        instance = new ClusterMachineAlertSettingsApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of ClusterMachineAlertSettingsApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' ClusterMachineAlertSettingsApi
        //Assert.IsType<ClusterMachineAlertSettingsApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdCommentsPatch
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdCommentsPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string clusterName = null;
        //string machineName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //string? body = null;
        //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdCommentsPatch(clusterName, machineName, alertTypeId, baseMonitorName, body);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string clusterName = null;
        //string machineName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdGet(clusterName, machineName, alertTypeId, baseMonitorName);
        //Assert.IsType<AlertSettingsDto>(response);
    }

    /// <summary>
    ///     Test
    ///     ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatch
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string clusterName = null;
        //string machineName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //AlertNotificationSettingsDto? alertNotificationSettingsDto = null;
        //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatch(clusterName, machineName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
    }

    /// <summary>
    ///     Test
    ///     ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatch
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string clusterName = null;
        //string machineName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //Hashtable? requestBody = null;
        //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatch(clusterName, machineName, alertTypeId, baseMonitorName, requestBody);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdStatusPatch
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdStatusPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string clusterName = null;
        //string machineName = null;
        //long alertTypeId = null;
        //string baseMonitorName = null;
        //int? body = null;
        //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdStatusPatch(clusterName, machineName, alertTypeId, baseMonitorName, body);
    }
}