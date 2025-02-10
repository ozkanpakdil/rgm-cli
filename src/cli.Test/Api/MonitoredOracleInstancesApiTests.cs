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
///     Class for testing MonitoredOracleInstancesApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class MonitoredOracleInstancesApiTests : IDisposable
{
    private MonitoredOracleInstancesApi instance;

    public MonitoredOracleInstancesApiTests()
    {
        instance = new MonitoredOracleInstancesApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of MonitoredOracleInstancesApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' MonitoredOracleInstancesApi
        //Assert.IsType<MonitoredOracleInstancesApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameOracleinstancesPost
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameOracleinstancesPostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //AddOracleInstanceRequest? addOracleInstanceRequest = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameOracleinstancesPost(baseMonitorName, addOracleInstanceRequest);
        //Assert.IsType<AddInstanceResultJSendSuccess>(response);
    }
}