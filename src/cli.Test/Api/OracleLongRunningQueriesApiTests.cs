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
    ///  Class for testing OracleLongRunningQueriesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OracleLongRunningQueriesApiTests : IDisposable
    {
        private OracleLongRunningQueriesApi instance;

        public OracleLongRunningQueriesApiTests()
        {
            instance = new OracleLongRunningQueriesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OracleLongRunningQueriesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OracleLongRunningQueriesApi
            //Assert.IsType<OracleLongRunningQueriesApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameOracleInstancesCirLongrunningqueriesGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameOracleInstancesCirLongrunningqueriesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //OracleInstanceChannelInstanceRef cir = null;
            //string baseMonitorName = null;
            //DateTime? startTime = null;
            //DateTime? endTime = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameOracleInstancesCirLongrunningqueriesGet(cir, baseMonitorName, startTime, endTime);
            //Assert.IsType<OracleLongRunningQueriesDtoJSendSuccess>(response);
        }
    }
}
