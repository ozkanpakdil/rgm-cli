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
    ///  Class for testing ServerPermissionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ServerPermissionsApiTests : IDisposable
    {
        private ServerPermissionsApi instance;

        public ServerPermissionsApiTests()
        {
            instance = new ServerPermissionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ServerPermissionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ServerPermissionsApi
            //Assert.IsType<ServerPermissionsApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameServerPermissionsV2CirRunDateGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameServerPermissionsV2CirRunDateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SqlInstanceChannelInstanceRef cir = null;
            //DateTime runDate = null;
            //string baseMonitorName = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameServerPermissionsV2CirRunDateGet(cir, runDate, baseMonitorName);
            //Assert.IsType<OldServerPermissionsDtoJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameServerPermissionsV2RunDateGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameServerPermissionsV2RunDateGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime runDate = null;
            //string baseMonitorName = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameServerPermissionsV2RunDateGet(runDate, baseMonitorName);
            //Assert.IsType<OldSummarizedServerPermissionsDtoIEnumerableJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameSqlinstancesCirPermissionsGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameSqlinstancesCirPermissionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SqlInstanceChannelInstanceRef cir = null;
            //string baseMonitorName = null;
            //long? endTime = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameSqlinstancesCirPermissionsGet(cir, baseMonitorName, endTime);
            //Assert.IsType<ServerRoleViewModelDtoArrayJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiServerOverviewServerPermissionsReportGet
        /// </summary>
        [Fact]
        public void ApiServerOverviewServerPermissionsReportGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SqlInstanceChannelInstanceRef? cir = null;
            //long? endTime = null;
            //instance.ApiServerOverviewServerPermissionsReportGet(cir, endTime);
        }
    }
}
