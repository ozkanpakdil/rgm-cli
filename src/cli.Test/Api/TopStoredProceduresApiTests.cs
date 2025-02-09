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
    ///  Class for testing TopStoredProceduresApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TopStoredProceduresApiTests : IDisposable
    {
        private TopStoredProceduresApi instance;

        public TopStoredProceduresApiTests()
        {
            instance = new TopStoredProceduresApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TopStoredProceduresApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TopStoredProceduresApi
            //Assert.IsType<TopStoredProceduresApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameSprocstatsGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameSprocstatsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //SqlInstanceChannelInstanceRef? cir = null;
            //long? startTime = null;
            //long? endTime = null;
            //instance.ApiBasemonitorsBaseMonitorNameSprocstatsGet(baseMonitorName, cir, startTime, endTime);
        }
    }
}
