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
///     Class for testing JobsApiApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class JobsApiApiTests : IDisposable
{
    private JobsApiApi instance;

    public JobsApiApiTests()
    {
        instance = new JobsApiApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of JobsApiApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' JobsApiApi
        //Assert.IsType<JobsApiApi>(instance);
    }

    /// <summary>
    ///     Test ApiEstateJobsHistoryGet
    /// </summary>
    [Fact]
    public void ApiEstateJobsHistoryGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //int? daysHistory = null;
        //string? baseMonitorName = null;
        //SqlInstanceAgentJobChannelInstanceRef? jobCir = null;
        //var response = instance.ApiEstateJobsHistoryGet(daysHistory, baseMonitorName, jobCir);
        //Assert.IsType<List<JobHistoryViewModel>>(response);
    }

    /// <summary>
    ///     Test ApiEstateJobsPost
    /// </summary>
    [Fact]
    public void ApiEstateJobsPostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //JobFilterInfo? jobFilterInfo = null;
        //var response = instance.ApiEstateJobsPost(jobFilterInfo);
        //Assert.IsType<JobsViewModel>(response);
    }
}