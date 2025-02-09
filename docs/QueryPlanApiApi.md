# cli.Api.QueryPlanApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameQueryplansActualplanRuntimemetricsPost**](QueryPlanApiApi.md#apibasemonitorsbasemonitornamequeryplansactualplanruntimemetricspost) | **POST** /api/basemonitors/{baseMonitorName}/queryplans/actualplan/runtimemetrics |  |
| [**ApiBasemonitorsBaseMonitorNameQueryplansGet**](QueryPlanApiApi.md#apibasemonitorsbasemonitornamequeryplansget) | **GET** /api/basemonitors/{baseMonitorName}/queryplans |  |
| [**ApiBasemonitorsBaseMonitorNameQueryplansSqlinstancesCirActualplanCompatibilityGet**](QueryPlanApiApi.md#apibasemonitorsbasemonitornamequeryplanssqlinstancesciractualplancompatibilityget) | **GET** /api/basemonitors/{baseMonitorName}/queryplans/sqlinstances/{cir}/actualplan/compatibility |  |

<a id="apibasemonitorsbasemonitornamequeryplansactualplanruntimemetricspost"></a>
# **ApiBasemonitorsBaseMonitorNameQueryplansActualplanRuntimemetricsPost**
> ActualPlanRuntimeMetricsDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameQueryplansActualplanRuntimemetricsPost (string baseMonitorName, ActualPlanRuntimeMetricsPostDto? actualPlanRuntimeMetricsPostDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameQueryplansActualplanRuntimemetricsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryPlanApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var actualPlanRuntimeMetricsPostDto = new ActualPlanRuntimeMetricsPostDto?(); // ActualPlanRuntimeMetricsPostDto? |  (optional) 

            try
            {
                ActualPlanRuntimeMetricsDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameQueryplansActualplanRuntimemetricsPost(baseMonitorName, actualPlanRuntimeMetricsPostDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryPlanApiApi.ApiBasemonitorsBaseMonitorNameQueryplansActualplanRuntimemetricsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameQueryplansActualplanRuntimemetricsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ActualPlanRuntimeMetricsDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameQueryplansActualplanRuntimemetricsPostWithHttpInfo(baseMonitorName, actualPlanRuntimeMetricsPostDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryPlanApiApi.ApiBasemonitorsBaseMonitorNameQueryplansActualplanRuntimemetricsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **actualPlanRuntimeMetricsPostDto** | [**ActualPlanRuntimeMetricsPostDto?**](ActualPlanRuntimeMetricsPostDto?.md) |  | [optional]  |

### Return type

[**ActualPlanRuntimeMetricsDtoIEnumerableJSendSuccess**](ActualPlanRuntimeMetricsDtoIEnumerableJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamequeryplansget"></a>
# **ApiBasemonitorsBaseMonitorNameQueryplansGet**
> void ApiBasemonitorsBaseMonitorNameQueryplansGet (string baseMonitorName, string? queryCir = null, string? planHash = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameQueryplansGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryPlanApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var queryCir = "queryCir_example";  // string? |  (optional) 
            var planHash = "planHash_example";  // string? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameQueryplansGet(baseMonitorName, queryCir, planHash, startTime, endTime);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryPlanApiApi.ApiBasemonitorsBaseMonitorNameQueryplansGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameQueryplansGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameQueryplansGetWithHttpInfo(baseMonitorName, queryCir, planHash, startTime, endTime);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryPlanApiApi.ApiBasemonitorsBaseMonitorNameQueryplansGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **queryCir** | **string?** |  | [optional]  |
| **planHash** | **string?** |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamequeryplanssqlinstancesciractualplancompatibilityget"></a>
# **ApiBasemonitorsBaseMonitorNameQueryplansSqlinstancesCirActualplanCompatibilityGet**
> ActualPlanCompatibilityDtoJSendSuccess ApiBasemonitorsBaseMonitorNameQueryplansSqlinstancesCirActualplanCompatibilityGet (SqlInstanceChannelInstanceRef cir, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameQueryplansSqlinstancesCirActualplanCompatibilityGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryPlanApiApi(config);
            var cir = new SqlInstanceChannelInstanceRef(); // SqlInstanceChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                ActualPlanCompatibilityDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameQueryplansSqlinstancesCirActualplanCompatibilityGet(cir, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryPlanApiApi.ApiBasemonitorsBaseMonitorNameQueryplansSqlinstancesCirActualplanCompatibilityGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameQueryplansSqlinstancesCirActualplanCompatibilityGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ActualPlanCompatibilityDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameQueryplansSqlinstancesCirActualplanCompatibilityGetWithHttpInfo(cir, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryPlanApiApi.ApiBasemonitorsBaseMonitorNameQueryplansSqlinstancesCirActualplanCompatibilityGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**SqlInstanceChannelInstanceRef**](SqlInstanceChannelInstanceRef.md) |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**ActualPlanCompatibilityDtoJSendSuccess**](ActualPlanCompatibilityDtoJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

