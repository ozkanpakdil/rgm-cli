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
    ///  Class for testing ConfigureVirtualizationApiApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConfigureVirtualizationApiApiTests : IDisposable
    {
        private ConfigureVirtualizationApiApi instance;

        public ConfigureVirtualizationApiApiTests()
        {
            instance = new ConfigureVirtualizationApiApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConfigureVirtualizationApiApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ConfigureVirtualizationApiApi
            //Assert.IsType<ConfigureVirtualizationApiApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameVmwarehostsGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameVmwarehostsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameVmwarehostsGet(baseMonitorName);
            //Assert.IsType<VMServerStatusArrayJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameVmwarehostsServerNameDelete
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameVmwarehostsServerNameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //string baseMonitorName = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameVmwarehostsServerNameDelete(serverName, baseMonitorName);
            //Assert.IsType<JSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameVmwarehostsServerNamePost
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameVmwarehostsServerNamePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //string baseMonitorName = null;
            //VMwareCredentials? vMwareCredentials = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameVmwarehostsServerNamePost(serverName, baseMonitorName, vMwareCredentials);
            //Assert.IsType<JSendSuccess>(response);
        }
    }
}
