/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using cli.Api;
using Xunit;

// uncomment below to import models
//using cli.Model;

namespace cli.Test.Api;

/// <summary>
///     Class for testing AzureManagedInstanceDatabasesApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class AzureManagedInstanceDatabasesApiTests : IDisposable
{
    private AzureManagedInstanceDatabasesApi instance;

    public AzureManagedInstanceDatabasesApiTests()
    {
        instance = new AzureManagedInstanceDatabasesApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of AzureManagedInstanceDatabasesApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' AzureManagedInstanceDatabasesApi
        //Assert.IsType<AzureManagedInstanceDatabasesApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string serverName = null;
        //string databaseName = null;
        //string baseMonitorName = null;
        //instance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameGet(serverName, databaseName, baseMonitorName);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string serverName = null;
        //string baseMonitorName = null;
        //instance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesGet(serverName, baseMonitorName);
    }
}