/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using cli.Client;
using cli.Api;
// uncomment below to import models
//using cli.Model;

namespace cli.Test.Api
{
    /// <summary>
    ///  Class for testing DatabaseAlertSettingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DatabaseAlertSettingsApiTests : IDisposable
    {
        private DatabaseAlertSettingsApi instance;

        public DatabaseAlertSettingsApiTests()
        {
            instance = new DatabaseAlertSettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatabaseAlertSettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DatabaseAlertSettingsApi
            //Assert.IsType<DatabaseAlertSettingsApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clusterName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //string? body = null;
            //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch(clusterName, instanceName, databaseName, alertTypeId, baseMonitorName, body);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clusterName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet(clusterName, instanceName, databaseName, alertTypeId, baseMonitorName);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clusterName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //AlertNotificationSettingsDto? alertNotificationSettingsDto = null;
            //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch(clusterName, instanceName, databaseName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clusterName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //Hashtable? requestBody = null;
            //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch(clusterName, instanceName, databaseName, alertTypeId, baseMonitorName, requestBody);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clusterName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //int? body = null;
            //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch(clusterName, instanceName, databaseName, alertTypeId, baseMonitorName, body);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clusterName = null;
            //string machineName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //string? body = null;
            //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch(clusterName, machineName, instanceName, databaseName, alertTypeId, baseMonitorName, body);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clusterName = null;
            //string machineName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet(clusterName, machineName, instanceName, databaseName, alertTypeId, baseMonitorName);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clusterName = null;
            //string machineName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //AlertNotificationSettingsDto? alertNotificationSettingsDto = null;
            //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch(clusterName, machineName, instanceName, databaseName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clusterName = null;
            //string machineName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //Hashtable? requestBody = null;
            //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch(clusterName, machineName, instanceName, databaseName, alertTypeId, baseMonitorName, requestBody);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clusterName = null;
            //string machineName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //int? body = null;
            //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch(clusterName, machineName, instanceName, databaseName, alertTypeId, baseMonitorName, body);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string machineName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //string? body = null;
            //instance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch(machineName, instanceName, databaseName, alertTypeId, baseMonitorName, body);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string machineName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //instance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet(machineName, instanceName, databaseName, alertTypeId, baseMonitorName);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string machineName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //AlertNotificationSettingsDto? alertNotificationSettingsDto = null;
            //instance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch(machineName, instanceName, databaseName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string machineName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //Hashtable? requestBody = null;
            //instance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch(machineName, instanceName, databaseName, alertTypeId, baseMonitorName, requestBody);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string machineName = null;
            //string instanceName = null;
            //string databaseName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //int? body = null;
            //instance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch(machineName, instanceName, databaseName, alertTypeId, baseMonitorName, body);
        }
    }
}
