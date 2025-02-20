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
///     Class for testing AmazonRdsDatabasesApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class AmazonRdsDatabasesApiTests : IDisposable
{
    private AmazonRdsDatabasesApi instance;

    public AmazonRdsDatabasesApiTests()
    {
        instance = new AmazonRdsDatabasesApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of AmazonRdsDatabasesApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' AmazonRdsDatabasesApi
        //Assert.IsType<AmazonRdsDatabasesApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesDatabaseNameGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesDatabaseNameGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string serverName = null;
        //string databaseName = null;
        //string baseMonitorName = null;
        //instance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesDatabaseNameGet(serverName, databaseName, baseMonitorName);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string serverName = null;
        //string baseMonitorName = null;
        //instance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesGet(serverName, baseMonitorName);
    }
}