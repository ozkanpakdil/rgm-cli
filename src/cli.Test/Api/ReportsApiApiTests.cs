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
    ///  Class for testing ReportsApiApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReportsApiApiTests : IDisposable
    {
        private ReportsApiApi instance;

        public ReportsApiApiTests()
        {
            instance = new ReportsApiApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReportsApiApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReportsApiApi
            //Assert.IsType<ReportsApiApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameReportServerconfigurationChannelInstanceRefGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameReportServerconfigurationChannelInstanceRefGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //ChannelInstanceRef channelInstanceRef = null;
            //DateTime start = null;
            //DateTime end = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameReportServerconfigurationChannelInstanceRefGet(baseMonitorName, channelInstanceRef, start, end);
            //Assert.IsType<ServerConfigResultJSendSuccess>(response);
        }
    }
}
