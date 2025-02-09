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
    ///  Class for testing AzureSqlServersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AzureSqlServersApiTests : IDisposable
    {
        private AzureSqlServersApi instance;

        public AzureSqlServersApiTests()
        {
            instance = new AzureSqlServersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AzureSqlServersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AzureSqlServersApi
            //Assert.IsType<AzureSqlServersApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuresqlserversDatabasesPost
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuresqlserversDatabasesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //SelectDatabasesAzureSqlServerModel? selectDatabasesAzureSqlServerModel = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameAzuresqlserversDatabasesPost(baseMonitorName, selectDatabasesAzureSqlServerModel);
            //Assert.IsType<DetectedAzureSqlDatabaseDtoArrayJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuresqlserversGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuresqlserversGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //instance.ApiBasemonitorsBaseMonitorNameAzuresqlserversGet(baseMonitorName);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesPatch
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //string baseMonitorName = null;
            //UpdateSelectedDatabasesModel? updateSelectedDatabasesModel = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesPatch(serverName, baseMonitorName, updateSelectedDatabasesModel);
            //Assert.IsType<JSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameFetchDatabasesGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameFetchDatabasesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //string baseMonitorName = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameFetchDatabasesGet(serverName, baseMonitorName);
            //Assert.IsType<AzureSqlDatabasesDtoJSendSuccess>(response);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string baseMonitorName = null;
            //string serverName = null;
            //string? azureSqlServerName = null;
            //instance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameGet(baseMonitorName, serverName, azureSqlServerName);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNamePut
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNamePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //string baseMonitorName = null;
            //AzureSqlServerDto? azureSqlServerDto = null;
            //instance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNamePut(serverName, baseMonitorName, azureSqlServerDto);
        }
    }
}
