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
///     Class for testing ConfigurationComplianceApiApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class ConfigurationComplianceApiApiTests : IDisposable
{
    private ConfigurationComplianceApiApi instance;

    public ConfigurationComplianceApiApiTests()
    {
        instance = new ConfigurationComplianceApiApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of ConfigurationComplianceApiApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' ConfigurationComplianceApiApi
        //Assert.IsType<ConfigurationComplianceApiApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationcomplianceDatabaseconfigurationoptionsCollectionDateGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationcomplianceDatabaseconfigurationoptionsCollectionDateGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //DateTime collectionDate = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceDatabaseconfigurationoptionsCollectionDateGet(collectionDate, baseMonitorName);
        //Assert.IsType<DatabaseConfigurationDtoIEnumerableJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationcomplianceServerconfigurationoptionsCollectionDateGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationcomplianceServerconfigurationoptionsCollectionDateGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //DateTime collectionDate = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceServerconfigurationoptionsCollectionDateGet(collectionDate, baseMonitorName);
        //Assert.IsType<ConfigurationComplianceDtoJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesGet(baseMonitorName);
        //Assert.IsType<ConfigurationComplianceTemplateDtoIEnumerableJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesIdPut
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesIdPutTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //Guid id = null;
        //string baseMonitorName = null;
        //ConfigurationComplianceTemplateCreateDto? configurationComplianceTemplateCreateDto = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesIdPut(id, baseMonitorName, configurationComplianceTemplateCreateDto);
        //Assert.IsType<ConfigurationComplianceTemplateDtoJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesPost
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesPostTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string baseMonitorName = null;
        //ConfigurationComplianceTemplateCreateDto? configurationComplianceTemplateCreateDto = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesPost(baseMonitorName, configurationComplianceTemplateCreateDto);
        //Assert.IsType<ConfigurationComplianceTemplateDtoJSendSuccess>(response);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesTemplateIdDelete
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesTemplateIdDeleteTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //Guid templateId = null;
        //string baseMonitorName = null;
        //var response = instance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesTemplateIdDelete(templateId, baseMonitorName);
        //Assert.IsType<JSendSuccess>(response);
    }
}