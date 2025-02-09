# cli.Api.AmazonAuroraClusterApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAmazonAuroraClusterNamePostgresinstancesGet**](AmazonAuroraClusterApi.md#apibasemonitorsbasemonitornameamazonauroraclustersamazonauroraclusternamepostgresinstancesget) | **GET** /api/basemonitors/{baseMonitorName}/amazonauroraclusters/{amazonAuroraClusterName}/postgresinstances |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAuroraClusterNamePut**](AmazonAuroraClusterApi.md#apibasemonitorsbasemonitornameamazonauroraclustersauroraclusternameput) | **PUT** /api/basemonitors/{baseMonitorName}/amazonauroraclusters/{auroraClusterName} |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonauroraclustersGet**](AmazonAuroraClusterApi.md#apibasemonitorsbasemonitornameamazonauroraclustersget) | **GET** /api/basemonitors/{baseMonitorName}/amazonauroraclusters |  |

<a id="apibasemonitorsbasemonitornameamazonauroraclustersamazonauroraclusternamepostgresinstancesget"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAmazonAuroraClusterNamePostgresinstancesGet**
> void ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAmazonAuroraClusterNamePostgresinstancesGet (string amazonAuroraClusterName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAmazonAuroraClusterNamePostgresinstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonAuroraClusterApi(config);
            var amazonAuroraClusterName = "amazonAuroraClusterName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAmazonAuroraClusterNamePostgresinstancesGet(amazonAuroraClusterName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonAuroraClusterApi.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAmazonAuroraClusterNamePostgresinstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAmazonAuroraClusterNamePostgresinstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAmazonAuroraClusterNamePostgresinstancesGetWithHttpInfo(amazonAuroraClusterName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonAuroraClusterApi.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAmazonAuroraClusterNamePostgresinstancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonAuroraClusterName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameamazonauroraclustersauroraclusternameput"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAuroraClusterNamePut**
> void ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAuroraClusterNamePut (string auroraClusterName, string baseMonitorName, AmazonAuroraClusterDto? amazonAuroraClusterDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAuroraClusterNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonAuroraClusterApi(config);
            var auroraClusterName = "auroraClusterName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var amazonAuroraClusterDto = new AmazonAuroraClusterDto?(); // AmazonAuroraClusterDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAuroraClusterNamePut(auroraClusterName, baseMonitorName, amazonAuroraClusterDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonAuroraClusterApi.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAuroraClusterNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAuroraClusterNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAuroraClusterNamePutWithHttpInfo(auroraClusterName, baseMonitorName, amazonAuroraClusterDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonAuroraClusterApi.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersAuroraClusterNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **auroraClusterName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **amazonAuroraClusterDto** | [**AmazonAuroraClusterDto?**](AmazonAuroraClusterDto?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameamazonauroraclustersget"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonauroraclustersGet**
> void ApiBasemonitorsBaseMonitorNameAmazonauroraclustersGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonauroraclustersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonAuroraClusterApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonAuroraClusterApi.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonauroraclustersGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonAuroraClusterApi.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersGetWithHttpInfo: " + e.Message);
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

