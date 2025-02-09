# cli.Api.MySqlTopQueriesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameMySqlInstancesCirTopqueriesGet**](MySqlTopQueriesApi.md#apibasemonitorsbasemonitornamemysqlinstancescirtopqueriesget) | **GET** /api/basemonitors/{baseMonitorName}/mySqlInstances/{cir}/topqueries |  |
| [**ApiBasemonitorsBaseMonitorNameMySqlInstancesTopqueriesHistoryGet**](MySqlTopQueriesApi.md#apibasemonitorsbasemonitornamemysqlinstancestopquerieshistoryget) | **GET** /api/basemonitors/{baseMonitorName}/mySqlInstances/topqueries/history |  |

<a id="apibasemonitorsbasemonitornamemysqlinstancescirtopqueriesget"></a>
# **ApiBasemonitorsBaseMonitorNameMySqlInstancesCirTopqueriesGet**
> MySqlTopQueriesDtoJSendSuccess ApiBasemonitorsBaseMonitorNameMySqlInstancesCirTopqueriesGet (MySqlInstanceChannelInstanceRef cir, string baseMonitorName, DateTime? startTime = null, DateTime? endTime = null, int? maxResults = null, string? queryText = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMySqlInstancesCirTopqueriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MySqlTopQueriesApi(config);
            var cir = new MySqlInstanceChannelInstanceRef(); // MySqlInstanceChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var maxResults = 56;  // int? |  (optional) 
            var queryText = "queryText_example";  // string? |  (optional) 

            try
            {
                MySqlTopQueriesDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMySqlInstancesCirTopqueriesGet(cir, baseMonitorName, startTime, endTime, maxResults, queryText);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MySqlTopQueriesApi.ApiBasemonitorsBaseMonitorNameMySqlInstancesCirTopqueriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMySqlInstancesCirTopqueriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MySqlTopQueriesDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMySqlInstancesCirTopqueriesGetWithHttpInfo(cir, baseMonitorName, startTime, endTime, maxResults, queryText);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MySqlTopQueriesApi.ApiBasemonitorsBaseMonitorNameMySqlInstancesCirTopqueriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**MySqlInstanceChannelInstanceRef**](MySqlInstanceChannelInstanceRef.md) |  |  |
| **baseMonitorName** | **string** |  |  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |
| **maxResults** | **int?** |  | [optional]  |
| **queryText** | **string?** |  | [optional]  |

### Return type

[**MySqlTopQueriesDtoJSendSuccess**](MySqlTopQueriesDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamemysqlinstancestopquerieshistoryget"></a>
# **ApiBasemonitorsBaseMonitorNameMySqlInstancesTopqueriesHistoryGet**
> MySqlTopQueryPropertyQueryHistoryWithoutPlanKeyDtoJSendSuccess ApiBasemonitorsBaseMonitorNameMySqlInstancesTopqueriesHistoryGet (MySqlInstanceTopQueriesChannelInstanceRef cir, string baseMonitorName, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMySqlInstancesTopqueriesHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MySqlTopQueriesApi(config);
            var cir = new MySqlInstanceTopQueriesChannelInstanceRef(); // MySqlInstanceTopQueriesChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                MySqlTopQueryPropertyQueryHistoryWithoutPlanKeyDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMySqlInstancesTopqueriesHistoryGet(cir, baseMonitorName, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MySqlTopQueriesApi.ApiBasemonitorsBaseMonitorNameMySqlInstancesTopqueriesHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMySqlInstancesTopqueriesHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MySqlTopQueryPropertyQueryHistoryWithoutPlanKeyDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMySqlInstancesTopqueriesHistoryGetWithHttpInfo(cir, baseMonitorName, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MySqlTopQueriesApi.ApiBasemonitorsBaseMonitorNameMySqlInstancesTopqueriesHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**MySqlInstanceTopQueriesChannelInstanceRef**](MySqlInstanceTopQueriesChannelInstanceRef.md) |  |  |
| **baseMonitorName** | **string** |  |  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**MySqlTopQueryPropertyQueryHistoryWithoutPlanKeyDtoJSendSuccess**](MySqlTopQueryPropertyQueryHistoryWithoutPlanKeyDtoJSendSuccess.md)

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

