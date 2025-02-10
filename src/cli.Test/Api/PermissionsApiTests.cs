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
///     Class for testing PermissionsApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class PermissionsApiTests : IDisposable
{
    private PermissionsApi instance;

    public PermissionsApiTests()
    {
        instance = new PermissionsApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of PermissionsApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' PermissionsApi
        //Assert.IsType<PermissionsApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameDatabasePermissionsCirRunDateGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameDatabasePermissionsCirRunDateGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //SqlInstanceChannelInstanceRef cir = null;
        //DateTime runDate = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameDatabasePermissionsCirRunDateGet(cir, runDate, baseMonitorName);
        //Assert.IsType<OldDatabasePermissionsDtoJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryRunDateGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryRunDateGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //DateTime runDate = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryRunDateGet(runDate, baseMonitorName);
        //Assert.IsType<OldDatabasePermissionsDtoIEnumerableJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameServerPermissionsCirRunDateGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameServerPermissionsCirRunDateGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //SqlInstanceChannelInstanceRef cir = null;
        //DateTime runDate = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameServerPermissionsCirRunDateGet(cir, runDate, baseMonitorName);
        //Assert.IsType<OldServerPermissionsDtoJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameServerPermissionsRunDateGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameServerPermissionsRunDateGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //DateTime runDate = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameServerPermissionsRunDateGet(runDate, baseMonitorName);
        //Assert.IsType<OldSummarizedServerPermissionsDtoIEnumerableJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameUserPermissionsRunDateGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameUserPermissionsRunDateGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //DateTime runDate = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameUserPermissionsRunDateGet(runDate, baseMonitorName);
        //Assert.IsType<OldUserPermissionAndMonitoredEntityDtoJSendSuccess>(response);
    }
}