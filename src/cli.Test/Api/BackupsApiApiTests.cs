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
///     Class for testing BackupsApiApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class BackupsApiApiTests : IDisposable
{
    private BackupsApiApi instance;

    public BackupsApiApiTests()
    {
        instance = new BackupsApiApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of BackupsApiApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' BackupsApiApi
        //Assert.IsType<BackupsApiApi>(instance);
    }

    /// <summary>
    ///     Test ApiEstateBackupsGet
    /// </summary>
    [Fact]
    public void ApiEstateBackupsGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //var response = instance.ApiEstateBackupsGet();
        //Assert.IsType<DatabaseBackupInfoDto>(response);
    }

    /// <summary>
    ///     Test ApiEstateBackupsHistoryPost
    /// </summary>
    [Fact]
    public void ApiEstateBackupsHistoryPostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //List<string>? requestBody = null;
        //var response = instance.ApiEstateBackupsHistoryPost(requestBody);
        //Assert.IsType<BackupHistoriesDto>(response);
    }
}