# cli.Api.DisksApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksDiskNameGet**](DisksApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamedisksdisknameget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/disks/{diskName} |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksGet**](DisksApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamedisksget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/disks |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameGet**](DisksApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksdisknameget) | **GET** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/disks/{diskName} |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksGet**](DisksApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksget) | **GET** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/disks |  |

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamedisksdisknameget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksDiskNameGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksDiskNameGet (string clusterName, string machineName, string diskName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksDiskNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DisksApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var diskName = "diskName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksDiskNameGet(clusterName, machineName, diskName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisksApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksDiskNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksDiskNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksDiskNameGetWithHttpInfo(clusterName, machineName, diskName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisksApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksDiskNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamedisksget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksGet (string clusterName, string machineName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DisksApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksGet(clusterName, machineName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisksApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksGetWithHttpInfo(clusterName, machineName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisksApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameDisksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksdisknameget"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameGet**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameGet (string machineName, string diskName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DisksApi(config);
            var machineName = "machineName_example";  // string | 
            var diskName = "diskName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameGet(machineName, diskName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisksApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameGetWithHttpInfo(machineName, diskName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisksApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksget"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksGet**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksGet (string machineName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DisksApi(config);
            var machineName = "machineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksGet(machineName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisksApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksGetWithHttpInfo(machineName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisksApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksGetWithHttpInfo: " + e.Message);
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

