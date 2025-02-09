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
    ///  Class for testing AzureSqlDatabasesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AzureSqlDatabasesApiTests : IDisposable
    {
        private AzureSqlDatabasesApi instance;

        public AzureSqlDatabasesApiTests()
        {
            instance = new AzureSqlDatabasesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AzureSqlDatabasesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AzureSqlDatabasesApi
            //Assert.IsType<AzureSqlDatabasesApi>(instance);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //string databaseName = null;
            //string baseMonitorName = null;
            //instance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameGet(serverName, databaseName, baseMonitorName);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNamePut
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNamePutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //string databaseName = null;
            //string baseMonitorName = null;
            //AzureSqlDatabaseDto? azureSqlDatabaseDto = null;
            //instance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNamePut(serverName, databaseName, baseMonitorName, azureSqlDatabaseDto);
        }

        /// <summary>
        /// Test ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesGet
        /// </summary>
        [Fact]
        public void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string serverName = null;
            //string baseMonitorName = null;
            //var response = instance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesGet(serverName, baseMonitorName);
            //Assert.IsType<AzureSqlDatabaseDtoArrayJSendSuccess>(response);
        }
    }
}
