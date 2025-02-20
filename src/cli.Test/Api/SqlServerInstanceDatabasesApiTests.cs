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
///     Class for testing SqlServerInstanceDatabasesApi
/// </summary>
/// <remarks>
///     This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
///     Please update the test case below to test the API endpoint.
/// </remarks>
public class SqlServerInstanceDatabasesApiTests : IDisposable
{
    private SqlServerInstanceDatabasesApi instance;

    public SqlServerInstanceDatabasesApiTests()
    {
        instance = new SqlServerInstanceDatabasesApi();
    }

    public void Dispose()
    {
        // Cleanup when everything is done.
    }

    /// <summary>
    ///     Test an instance of SqlServerInstanceDatabasesApi
    /// </summary>
    [Fact]
    public void InstanceTest()
    {
        // TODO uncomment below to test 'IsType' SqlServerInstanceDatabasesApi
        //Assert.IsType<SqlServerInstanceDatabasesApi>(instance);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameGet
    /// </summary>
    [Fact]
    public void
        ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string linuxMachineName = null;
        //string instanceName = null;
        //string databaseName = null;
        //string baseMonitorName = null;
        //instance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameGet(linuxMachineName, instanceName, databaseName, baseMonitorName);
    }

    /// <summary>
    ///     Test ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesGet
    /// </summary>
    [Fact]
    public void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesGetTest()
    {
        // TODO uncomment below to test the method and replace null with proper value
        //string linuxMachineName = null;
        //string instanceName = null;
        //string baseMonitorName = null;
        //instance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesGet(linuxMachineName, instanceName, baseMonitorName);
    }
}