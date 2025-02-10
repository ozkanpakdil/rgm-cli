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
///     Class for testing AuthenticationTestPrincipalApiApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class AuthenticationTestPrincipalApiApiTests : IDisposable
{
    private AuthenticationTestPrincipalApiApi instance;

    public AuthenticationTestPrincipalApiApiTests()
    {
        instance = new AuthenticationTestPrincipalApiApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of AuthenticationTestPrincipalApiApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' AuthenticationTestPrincipalApiApi
        //Assert.IsType<AuthenticationTestPrincipalApiApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestGroupPost
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestGroupPostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string principalName = null;
        //string baseMonitorName = null;
        //Guid? body = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestGroupPost(principalName, baseMonitorName, body);
        //Assert.IsType<AccessReportJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestMonitoredObjectPost
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestMonitoredObjectPostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string principalName = null;
        //string baseMonitorName = null;
        //AccessRequest? accessRequest = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestMonitoredObjectPost(principalName, baseMonitorName, accessRequest);
        //Assert.IsType<AccessReportJSendSuccess>(response);
    }
}