# cli.Api.LinuxMachinesDisksApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksDiskNameGet**](LinuxMachinesDisksApi.md#apibasemonitorsbasemonitornamelinuxmachinesmachinenamedisksdisknameget) | **GET** /api/basemonitors/{baseMonitorName}/linuxmachines/{machineName}/disks/{diskName} |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksGet**](LinuxMachinesDisksApi.md#apibasemonitorsbasemonitornamelinuxmachinesmachinenamedisksget) | **GET** /api/basemonitors/{baseMonitorName}/linuxmachines/{machineName}/disks |  |

<a id="apibasemonitorsbasemonitornamelinuxmachinesmachinenamedisksdisknameget"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksDiskNameGet**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksDiskNameGet (string machineName, string diskName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksDiskNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LinuxMachinesDisksApi(config);
            var machineName = "machineName_example";  // string | 
            var diskName = "diskName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksDiskNameGet(machineName, diskName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinuxMachinesDisksApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksDiskNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksDiskNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksDiskNameGetWithHttpInfo(machineName, diskName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinuxMachinesDisksApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksDiskNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
| **diskName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamelinuxmachinesmachinenamedisksget"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksGet**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksGet (string machineName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LinuxMachinesDisksApi(config);
            var machineName = "machineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksGet(machineName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinuxMachinesDisksApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksGetWithHttpInfo(machineName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinuxMachinesDisksApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesMachineNameDisksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
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

