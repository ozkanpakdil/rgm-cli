# cli.Api.SqlServerInstanceDatabasesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameGet**](SqlServerInstanceDatabasesApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesdatabasenameget) | **GET** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName}/instances/{instanceName}/databases/{databaseName} |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesGet**](SqlServerInstanceDatabasesApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesget) | **GET** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName}/instances/{instanceName}/databases |  |

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesdatabasenameget"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameGet**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameGet (string linuxMachineName, string instanceName, string databaseName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SqlServerInstanceDatabasesApi(config);
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameGet(linuxMachineName, instanceName, databaseName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlServerInstanceDatabasesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameGetWithHttpInfo(linuxMachineName, instanceName, databaseName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlServerInstanceDatabasesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linuxMachineName** | **string** |  |  |
| **instanceName** | **string** |  |  |
| **databaseName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesget"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesGet**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesGet (string linuxMachineName, string instanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SqlServerInstanceDatabasesApi(config);
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesGet(linuxMachineName, instanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlServerInstanceDatabasesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesGetWithHttpInfo(linuxMachineName, instanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlServerInstanceDatabasesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linuxMachineName** | **string** |  |  |
| **instanceName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

