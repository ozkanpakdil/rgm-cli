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
///     Class for testing VolumeUsageApiApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class VolumeUsageApiApiTests : IDisposable
{
    private VolumeUsageApiApi instance;

    public VolumeUsageApiApiTests()
    {
        instance = new VolumeUsageApiApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of VolumeUsageApiApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' VolumeUsageApiApi
        //Assert.IsType<VolumeUsageApiApi>(instance);
    }

    /// <summary>
    ///     Test ApiEstateDiskUsageDisksPost
    /// </summary>
    [Fact]
    public void ApiEstateDiskUsageDisksPostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //DiskFilterInfoDto? diskFilterInfoDto = null;
        //var response = instance.ApiEstateDiskUsageDisksPost(diskFilterInfoDto);
        //Assert.IsType<VolumesViewModelJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiEstateDiskUsageHistoricUsagePost
    /// </summary>
    [Fact]
    public void ApiEstateDiskUsageHistoricUsagePostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //DiskFilterInfoDto? diskFilterInfoDto = null;
        //var response = instance.ApiEstateDiskUsageHistoricUsagePost(diskFilterInfoDto);
        //Assert.IsType<HistoricVolumeUsageViewModelJSendSuccess>(response);
    }
}