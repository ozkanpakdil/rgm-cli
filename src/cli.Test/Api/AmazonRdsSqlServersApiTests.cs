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
///     Class for testing AmazonRdsSqlServersApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class AmazonRdsSqlServersApiTests : IDisposable
{
    private AmazonRdsSqlServersApi instance;

    public AmazonRdsSqlServersApiTests()
    {
        instance = new AmazonRdsSqlServersApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of AmazonRdsSqlServersApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' AmazonRdsSqlServersApi
        //Assert.IsType<AmazonRdsSqlServersApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameDelete
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameDeleteTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string amazonRdsSqlServerName = null;
        //string baseMonitorName = null;
        //instance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameDelete(amazonRdsSqlServerName, baseMonitorName);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string amazonRdsSqlServerName = null;
        //string baseMonitorName = null;
        //instance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameGet(amazonRdsSqlServerName, baseMonitorName);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsAmazonapiDelete
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsAmazonapiDeleteTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //DeleteAmazonApiCredentialsRequest? deleteAmazonApiCredentialsRequest = null;
        //instance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsAmazonapiDelete(baseMonitorName, deleteAmazonApiCredentialsRequest);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsPatch
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsPatchTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //UpdateAmazonRdsSqlServerRequest? updateAmazonRdsSqlServerRequest = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsPatch(baseMonitorName, updateAmazonRdsSqlServerRequest);
        //Assert.IsType<JSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //instance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversGet(baseMonitorName);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversInstanceNamePut
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversInstanceNamePutTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string instanceName = null;
        //string baseMonitorName = null;
        //AmazonRdsSqlServerDto? amazonRdsSqlServerDto = null;
        //instance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversInstanceNamePut(instanceName, baseMonitorName, amazonRdsSqlServerDto);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversPost
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversPostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //AddAmazonRdsSqlServerCommandDto? addAmazonRdsSqlServerCommandDto = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversPost(baseMonitorName, addAmazonRdsSqlServerCommandDto);
        //Assert.IsType<AmazonRdsSqlServerDtoJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversTestPost
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversTestPostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //AddAmazonRdsSqlServerCommandDto? addAmazonRdsSqlServerCommandDto = null;
        //instance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversTestPost(baseMonitorName, addAmazonRdsSqlServerCommandDto);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversValidatePost
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversValidatePostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //AddAmazonRdsSqlServerCommandDto? addAmazonRdsSqlServerCommandDto = null;
        //instance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversValidatePost(baseMonitorName, addAmazonRdsSqlServerCommandDto);
    }
}