# cli.Api.MachinesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesGet**](MachinesApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameGet**](MachinesApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName} |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesGet**](MachinesApi.md#apibasemonitorsbasemonitornamestandalonemachinesget) | **GET** /api/basemonitors/{baseMonitorName}/standalonemachines |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameGet**](MachinesApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenameget) | **GET** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName} |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNamePut**](MachinesApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenameput) | **PUT** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName} |  |

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesGet (string clusterName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MachinesApi(config);
            var clusterName = "clusterName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesGet(clusterName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MachinesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesGetWithHttpInfo(clusterName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MachinesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameGet (string clusterName, string machineName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MachinesApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameGet(clusterName, machineName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MachinesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameGetWithHttpInfo(clusterName, machineName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MachinesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesget"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesGet**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MachinesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MachinesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MachinesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenameget"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameGet**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameGet (string machineName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MachinesApi(config);
            var machineName = "machineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameGet(machineName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MachinesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameGetWithHttpInfo(machineName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MachinesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenameput"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNamePut**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNamePut (string machineName, string baseMonitorName, StandaloneMachineDto? standaloneMachineDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MachinesApi(config);
            var machineName = "machineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var standaloneMachineDto = new StandaloneMachineDto?(); // StandaloneMachineDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNamePut(machineName, baseMonitorName, standaloneMachineDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MachinesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNamePutWithHttpInfo(machineName, baseMonitorName, standaloneMachineDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MachinesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **standaloneMachineDto** | [**StandaloneMachineDto?**](StandaloneMachineDto?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

