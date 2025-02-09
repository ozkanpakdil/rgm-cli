# cli.Api.OracleTopQueriesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameOracleInstancesCirTopqueriesGet**](OracleTopQueriesApi.md#apibasemonitorsbasemonitornameoracleinstancescirtopqueriesget) | **GET** /api/basemonitors/{baseMonitorName}/oracleInstances/{cir}/topqueries |  |
| [**ApiBasemonitorsBaseMonitorNameOracleInstancesTopqueriesHistoryGet**](OracleTopQueriesApi.md#apibasemonitorsbasemonitornameoracleinstancestopquerieshistoryget) | **GET** /api/basemonitors/{baseMonitorName}/oracleInstances/topqueries/history |  |

<a id="apibasemonitorsbasemonitornameoracleinstancescirtopqueriesget"></a>
# **ApiBasemonitorsBaseMonitorNameOracleInstancesCirTopqueriesGet**
> OracleTopQueriesDtoJSendSuccess ApiBasemonitorsBaseMonitorNameOracleInstancesCirTopqueriesGet (OracleInstanceChannelInstanceRef cir, string baseMonitorName, DateTime? startTime = null, DateTime? endTime = null, int? maxResults = null, string? queryText = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameOracleInstancesCirTopqueriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OracleTopQueriesApi(config);
            var cir = new OracleInstanceChannelInstanceRef(); // OracleInstanceChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var maxResults = 56;  // int? |  (optional) 
            var queryText = "queryText_example";  // string? |  (optional) 

            try
            {
                OracleTopQueriesDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameOracleInstancesCirTopqueriesGet(cir, baseMonitorName, startTime, endTime, maxResults, queryText);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OracleTopQueriesApi.ApiBasemonitorsBaseMonitorNameOracleInstancesCirTopqueriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameOracleInstancesCirTopqueriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OracleTopQueriesDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameOracleInstancesCirTopqueriesGetWithHttpInfo(cir, baseMonitorName, startTime, endTime, maxResults, queryText);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OracleTopQueriesApi.ApiBasemonitorsBaseMonitorNameOracleInstancesCirTopqueriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**OracleInstanceChannelInstanceRef**](OracleInstanceChannelInstanceRef.md) |  |  |
| **baseMonitorName** | **string** |  |  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |
| **maxResults** | **int?** |  | [optional]  |
| **queryText** | **string?** |  | [optional]  |

### Return type

[**OracleTopQueriesDtoJSendSuccess**](OracleTopQueriesDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameoracleinstancestopquerieshistoryget"></a>
# **ApiBasemonitorsBaseMonitorNameOracleInstancesTopqueriesHistoryGet**
> OracleTopQueryPropertyQueryHistoryWithoutPlanKeyDtoJSendSuccess ApiBasemonitorsBaseMonitorNameOracleInstancesTopqueriesHistoryGet (OracleInstanceTopQueriesChannelInstanceRef cir, string baseMonitorName, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameOracleInstancesTopqueriesHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OracleTopQueriesApi(config);
            var cir = new OracleInstanceTopQueriesChannelInstanceRef(); // OracleInstanceTopQueriesChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                OracleTopQueryPropertyQueryHistoryWithoutPlanKeyDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameOracleInstancesTopqueriesHistoryGet(cir, baseMonitorName, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OracleTopQueriesApi.ApiBasemonitorsBaseMonitorNameOracleInstancesTopqueriesHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameOracleInstancesTopqueriesHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OracleTopQueryPropertyQueryHistoryWithoutPlanKeyDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameOracleInstancesTopqueriesHistoryGetWithHttpInfo(cir, baseMonitorName, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OracleTopQueriesApi.ApiBasemonitorsBaseMonitorNameOracleInstancesTopqueriesHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**OracleInstanceTopQueriesChannelInstanceRef**](OracleInstanceTopQueriesChannelInstanceRef.md) |  |  |
| **baseMonitorName** | **string** |  |  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**OracleTopQueryPropertyQueryHistoryWithoutPlanKeyDtoJSendSuccess**](OracleTopQueryPropertyQueryHistoryWithoutPlanKeyDtoJSendSuccess.md)

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

