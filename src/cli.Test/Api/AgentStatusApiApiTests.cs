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
///     Class for testing AgentStatusApiApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class AgentStatusApiApiTests : IDisposable
{
    private AgentStatusApiApi instance;

    public AgentStatusApiApiTests()
    {
        instance = new AgentStatusApiApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of AgentStatusApiApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' AgentStatusApiApi
        //Assert.IsType<AgentStatusApiApi>(instance);
    }

    /// <summary>
    ///     Test ApiAgentsGet
    /// </summary>
    [Fact]
    public void ApiAgentsGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //var response = instance.ApiAgentsGet();
        //Assert.IsType<AgentStatusDtoArrayJSendSuccess>(response);
    }
}