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
    ///  Class for testing DisksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DisksApiTests : IDisposable
    {
        private DisksApi instance;

        public DisksApiTests()
        {
            instance = new DisksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DisksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DisksApi
            //Assert.IsType<DisksApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksDiskNameGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksDiskNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clusterName = null;
            //string machineName = null;
            //string diskName = null;
            //string baseMonitorName = null;
            //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksDiskNameGet(clusterName, machineName, diskName, baseMonitorName);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clusterName = null;
            //string machineName = null;
            //string baseMonitorName = null;
            //instance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksGet(clusterName, machineName, baseMonitorName);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string machineName = null;
            //string diskName = null;
            //string baseMonitorName = null;
            //instance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameGet(machineName, diskName, baseMonitorName);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string machineName = null;
            //string baseMonitorName = null;
            //instance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksGet(machineName, baseMonitorName);
        }
    }
}
