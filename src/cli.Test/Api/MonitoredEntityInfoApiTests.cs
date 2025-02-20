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
///     Class for testing MonitoredEntityInfoApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class MonitoredEntityInfoApiTests : IDisposable
{
    private MonitoredEntityInfoApi instance;

    public MonitoredEntityInfoApiTests()
    {
        instance = new MonitoredEntityInfoApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of MonitoredEntityInfoApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' MonitoredEntityInfoApi
        //Assert.IsType<MonitoredEntityInfoApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameMonitoredEntityInfoGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameMonitoredEntityInfoGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //DateTime? runDate = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameMonitoredEntityInfoGet(baseMonitorName, runDate);
        //Assert.IsType<MonitoredEntityInfoDtoIEnumerableJSendSuccess>(response);
    }
}