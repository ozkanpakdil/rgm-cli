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
///     Class for testing AlertSuppressionWindowsApiApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class AlertSuppressionWindowsApiApiTests : IDisposable
{
    private AlertSuppressionWindowsApiApi instance;

    public AlertSuppressionWindowsApiApiTests()
    {
        instance = new AlertSuppressionWindowsApiApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of AlertSuppressionWindowsApiApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' AlertSuppressionWindowsApiApi
        //Assert.IsType<AlertSuppressionWindowsApiApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsByNamesGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsByNamesGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //List<string>? names = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsByNamesGet(baseMonitorName, names);
        //Assert.IsType<AlertSuppressionWindowDtoIEnumerableJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsGet(baseMonitorName);
        //Assert.IsType<AlertSuppressionWindowDtoIEnumerableJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdDelete
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdDeleteTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //IntegerIdentifier id = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdDelete(id, baseMonitorName);
        //Assert.IsType<BooleanJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //IntegerIdentifier id = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdGet(id, baseMonitorName);
        //Assert.IsType<AlertSuppressionWindowDtoJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdPut
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdPutTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //IntegerIdentifier id = null;
        //string baseMonitorName = null;
        //AlertSuppressionWindowEditDto? alertSuppressionWindowEditDto = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdPut(id, baseMonitorName, alertSuppressionWindowEditDto);
        //Assert.IsType<AlertSuppressionWindowDtoJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsPost
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsPostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //AlertSuppressionWindowEditDto? alertSuppressionWindowEditDto = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsPost(baseMonitorName, alertSuppressionWindowEditDto);
        //Assert.IsType<AlertSuppressionWindowDtoJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsTargetsGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsTargetsGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsTargetsGet(baseMonitorName);
        //Assert.IsType<AlertSuppressionTargetDtoIEnumerableJSendSuccess>(response);
    }
}