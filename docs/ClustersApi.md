# cli.Api.ClustersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameGet**](ClustersApi.md#apibasemonitorsbasemonitornameclustersclusternameget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName} |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNamePut**](ClustersApi.md#apibasemonitorsbasemonitornameclustersclusternameput) | **PUT** /api/basemonitors/{baseMonitorName}/clusters/{clusterName} |  |
| [**ApiBasemonitorsBaseMonitorNameClustersGet**](ClustersApi.md#apibasemonitorsbasemonitornameclustersget) | **GET** /api/basemonitors/{baseMonitorName}/clusters |  |

<a id="apibasemonitorsbasemonitornameclustersclusternameget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameGet (string clusterName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClustersApi(config);
            var clusterName = "clusterName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameGet(clusterName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClustersApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameGetWithHttpInfo(clusterName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClustersApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornameclustersclusternameput"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNamePut**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNamePut (string clusterName, string baseMonitorName, ClusterDto? clusterDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClustersApi(config);
            var clusterName = "clusterName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var clusterDto = new ClusterDto?(); // ClusterDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNamePut(clusterName, baseMonitorName, clusterDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClustersApi.ApiBasemonitorsBaseMonitorNameClustersClusterNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNamePutWithHttpInfo(clusterName, baseMonitorName, clusterDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClustersApi.ApiBasemonitorsBaseMonitorNameClustersClusterNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **clusterDto** | [**ClusterDto?**](ClusterDto?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameclustersget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersGet**
> void ApiBasemonitorsBaseMonitorNameClustersGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClustersApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClustersApi.ApiBasemonitorsBaseMonitorNameClustersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClustersApi.ApiBasemonitorsBaseMonitorNameClustersGetWithHttpInfo: " + e.Message);
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

