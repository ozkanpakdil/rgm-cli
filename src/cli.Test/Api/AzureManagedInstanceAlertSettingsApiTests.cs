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
    ///  Class for testing AzureManagedInstanceAlertSettingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AzureManagedInstanceAlertSettingsApiTests : IDisposable
    {
        private AzureManagedInstanceAlertSettingsApi instance;

        public AzureManagedInstanceAlertSettingsApiTests()
        {
            instance = new AzureManagedInstanceAlertSettingsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AzureManagedInstanceAlertSettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AzureManagedInstanceAlertSettingsApi
            //Assert.IsType<AzureManagedInstanceAlertSettingsApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdCommentsPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdCommentsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //string? body = null;
            //instance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdCommentsPatch(serverName, alertTypeId, baseMonitorName, body);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //instance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdGet(serverName, alertTypeId, baseMonitorName);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdNotificationsettingsPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdNotificationsettingsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //AlertNotificationSettingsDto? alertNotificationSettingsDto = null;
            //instance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdNotificationsettingsPatch(serverName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdSpecificsettingsPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdSpecificsettingsPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //Hashtable? requestBody = null;
            //instance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdSpecificsettingsPatch(serverName, alertTypeId, baseMonitorName, requestBody);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdStatusPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdStatusPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //long alertTypeId = null;
            //string baseMonitorName = null;
            //int? body = null;
            //instance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameAlertsettingsAlertTypeIdStatusPatch(serverName, alertTypeId, baseMonitorName, body);
        }
    }
}
