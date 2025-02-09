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
    ///  Class for testing TopQueriesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TopQueriesApiTests : IDisposable
    {
        private TopQueriesApi instance;

        public TopQueriesApiTests()
        {
            instance = new TopQueriesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TopQueriesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TopQueriesApi
            //Assert.IsType<TopQueriesApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameTopqueriesAnalysequeryGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameTopqueriesAnalysequeryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //SqlInstanceTopQueriesChannelInstanceRef? cir = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameTopqueriesAnalysequeryGet(baseMonitorName, cir);
            //Assert.IsType<FragmentAnalysisIssueWithIdDtoArrayJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameTopqueriesGetGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameTopqueriesGetGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //ChannelInstanceRef? cir = null;
            //string? selectedWait = null;
            //IntegerIdentifier? alertId = null;
            //DateTime? startTime = null;
            //DateTime? endTime = null;
            //string? sqlQueryTextFragment = null;
            //bool? groupResults = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameTopqueriesGetGet(baseMonitorName, cir, selectedWait, alertId, startTime, endTime, sqlQueryTextFragment, groupResults);
            //Assert.IsType<TopQueryDtoGroupedTopQueryDtoOneOfArrayJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameTopqueriesQueryhistoryGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameTopqueriesQueryhistoryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //SqlInstanceTopQueriesChannelInstanceRef? cir = null;
            //DateTime? startTime = null;
            //DateTime? endTime = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameTopqueriesQueryhistoryGet(baseMonitorName, cir, startTime, endTime);
            //Assert.IsType<TopQueryPropertySqlServerQueryHistoryPlanKeyDtoQueryHistoryDtoJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameTopqueriesTrackedqueryrecordsGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameTopqueriesTrackedqueryrecordsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //SqlInstanceChannelInstanceRef? cir = null;
            //DateTime? startTime = null;
            //DateTime? endTime = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameTopqueriesTrackedqueryrecordsGet(baseMonitorName, cir, startTime, endTime);
            //Assert.IsType<TopQueryDtoTopQueryOutOfRangeDtoOneOfArrayJSendSuccess>(response);
        }
    }
}
