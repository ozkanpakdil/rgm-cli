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
    ///  Class for testing BaseMonitorsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BaseMonitorsApiTests : IDisposable
    {
        private BaseMonitorsApi instance;

        public BaseMonitorsApiTests()
        {
            instance = new BaseMonitorsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BaseMonitorsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BaseMonitorsApi
            //Assert.IsType<BaseMonitorsApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameGet(baseMonitorName);
            //Assert.IsType<BaseMonitorDtoJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameStatusGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameStatusGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameStatusGet(baseMonitorName);
            //Assert.IsType<BaseMonitorModelJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiBasemonitorsGet();
            //Assert.IsType<BaseMonitorDtoArrayJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsSetconfigurationPost
        /// </summary>
        [Fact]
        public void ApiBasemonitorsSetconfigurationPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BaseMonitorConfigurationRequest? baseMonitorConfigurationRequest = null;
            //var response = instance.ApiBasemonitorsSetconfigurationPost(baseMonitorConfigurationRequest);
            //Assert.IsType<JSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsSetprimaryPost
        /// </summary>
        [Fact]
        public void ApiBasemonitorsSetprimaryPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BaseMonitorPrimaryRequestDto? baseMonitorPrimaryRequestDto = null;
            //var response = instance.ApiBasemonitorsSetprimaryPost(baseMonitorPrimaryRequestDto);
            //Assert.IsType<JSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsTestconnectionGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsTestconnectionGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ApiBasemonitorsTestconnectionGet();
            //Assert.IsType<BooleanJSendSuccess>(response);
        }
    }
}
