# cli.Api.SqlServerInstanceJobsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsGet**](SqlServerInstanceJobsApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamejobsget) | **GET** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName}/instances/{instanceName}/jobs |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsJobNameGet**](SqlServerInstanceJobsApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamejobsjobnameget) | **GET** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName}/instances/{instanceName}/jobs/{jobName} |  |

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamejobsget"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsGet**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsGet (string linuxMachineName, string instanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SqlServerInstanceJobsApi(config);
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsGet(linuxMachineName, instanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlServerInstanceJobsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsGetWithHttpInfo(linuxMachineName, instanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlServerInstanceJobsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamejobsjobnameget"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsJobNameGet**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsJobNameGet (string linuxMachineName, string instanceName, string jobName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsJobNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SqlServerInstanceJobsApi(config);
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var jobName = "jobName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsJobNameGet(linuxMachineName, instanceName, jobName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlServerInstanceJobsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsJobNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsJobNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsJobNameGetWithHttpInfo(linuxMachineName, instanceName, jobName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlServerInstanceJobsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameJobsJobNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linuxMachineName** | **string** |  |  |
| **instanceName** | **string** |  |  |
| **jobName** | **string** |  |  |
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

