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
///     Class for testing AzureElasticPoolsApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class AzureElasticPoolsApiTests : IDisposable
{
    private AzureElasticPoolsApi instance;

    public AzureElasticPoolsApiTests()
    {
        instance = new AzureElasticPoolsApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of AzureElasticPoolsApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' AzureElasticPoolsApi
        //Assert.IsType<AzureElasticPoolsApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string serverName = null;
        //string elasticPoolName = null;
        //string baseMonitorName = null;
        //instance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameGet(serverName, elasticPoolName, baseMonitorName);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string serverName = null;
        //string baseMonitorName = null;
        //instance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsGet(serverName, baseMonitorName);
    }
}