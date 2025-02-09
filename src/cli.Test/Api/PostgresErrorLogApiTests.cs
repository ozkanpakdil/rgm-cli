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
    ///  Class for testing PostgresErrorLogApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PostgresErrorLogApiTests : IDisposable
    {
        private PostgresErrorLogApi instance;

        public PostgresErrorLogApiTests()
        {
            instance = new PostgresErrorLogApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PostgresErrorLogApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PostgresErrorLogApi
            //Assert.IsType<PostgresErrorLogApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNamePostgresErrorLogGetErrorLogsGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNamePostgresErrorLogGetErrorLogsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //PostgresInstanceChannelInstanceRef? dbmsCir = null;
            //DateTime? startTime = null;
            //DateTime? endTime = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNamePostgresErrorLogGetErrorLogsGet(baseMonitorName, dbmsCir, startTime, endTime, pageNumber, pageSize);
            //Assert.IsType<ServerOverviewPostgresErrorLogDtoJSendSuccess>(response);
        }
    }
}
