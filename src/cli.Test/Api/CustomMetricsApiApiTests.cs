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
///     Class for testing CustomMetricsApiApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class CustomMetricsApiApiTests : IDisposable
{
    private CustomMetricsApiApi instance;

    public CustomMetricsApiApiTests()
    {
        instance = new CustomMetricsApiApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of CustomMetricsApiApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' CustomMetricsApiApi
        //Assert.IsType<CustomMetricsApiApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsDelete
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsDeleteTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsDelete(baseMonitorName);
        //Assert.IsType<StringJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsEnablePut
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsEnablePutTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //bool? enable = null;
        //List<IntegerIdentifier>? integerIdentifier = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsEnablePut(baseMonitorName, enable, integerIdentifier);
        //Assert.IsType<StringJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDatabasesGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDatabasesGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDatabasesGet(baseMonitorName);
        //Assert.IsType<DatabaseDtoIEnumerableJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDelete
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDeleteTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //List<IntegerIdentifier>? integerIdentifier = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDelete(baseMonitorName, integerIdentifier);
        //Assert.IsType<StringJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsEnablePut
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsEnablePutTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //bool? enable = null;
        //List<IntegerIdentifier>? integerIdentifier = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsEnablePut(baseMonitorName, enable, integerIdentifier);
        //Assert.IsType<StringJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsGet(baseMonitorName);
        //Assert.IsType<CustomMetricsGridDtoIEnumerableJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsMonitoredEntityTreeGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsMonitoredEntityTreeGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsMonitoredEntityTreeGet(baseMonitorName);
        //Assert.IsType<MonitoredEntityTreeDtoJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsPost
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsPostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //CustomMetricDto? customMetricDto = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsPost(baseMonitorName, customMetricDto);
        //Assert.IsType<IntegerIdentifierJSendSuccess>(response);
    }
}