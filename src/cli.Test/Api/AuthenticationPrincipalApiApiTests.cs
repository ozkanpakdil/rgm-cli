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
///     Class for testing AuthenticationPrincipalApiApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class AuthenticationPrincipalApiApiTests : IDisposable
{
    private AuthenticationPrincipalApiApi instance;

    public AuthenticationPrincipalApiApiTests()
    {
        instance = new AuthenticationPrincipalApiApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of AuthenticationPrincipalApiApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' AuthenticationPrincipalApiApi
        //Assert.IsType<AuthenticationPrincipalApiApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsGet(baseMonitorName);
        //Assert.IsType<AuthPrincipalDtoIEnumerableJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPost
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //AuthPrincipalDto? authPrincipalDto = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPost(baseMonitorName, authPrincipalDto);
        //Assert.IsType<AuthPrincipalDtoJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameDelete
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameDeleteTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string principalName = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameDelete(principalName, baseMonitorName);
        //Assert.IsType<JSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string principalName = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameGet(principalName, baseMonitorName);
        //Assert.IsType<AuthPrincipalDtoJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPut
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPutTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //AuthPrincipalDto? authPrincipalDto = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPut(baseMonitorName, authPrincipalDto);
        //Assert.IsType<JSendSuccess>(response);
    }
}