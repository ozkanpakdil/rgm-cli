# cli.Api.PostgresTopQueriesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNamePostgresInstancesCirTopqueriesGet**](PostgresTopQueriesApi.md#apibasemonitorsbasemonitornamepostgresinstancescirtopqueriesget) | **GET** /api/basemonitors/{baseMonitorName}/postgresInstances/{cir}/topqueries |  |
| [**ApiBasemonitorsBaseMonitorNamePostgresInstancesTopqueriesHistoryGet**](PostgresTopQueriesApi.md#apibasemonitorsbasemonitornamepostgresinstancestopquerieshistoryget) | **GET** /api/basemonitors/{baseMonitorName}/postgresInstances/topqueries/history |  |

<a id="apibasemonitorsbasemonitornamepostgresinstancescirtopqueriesget"></a>
# **ApiBasemonitorsBaseMonitorNamePostgresInstancesCirTopqueriesGet**
> PostgresTopQueriesDtoJSendSuccess ApiBasemonitorsBaseMonitorNamePostgresInstancesCirTopqueriesGet (ChannelInstanceRef cir, string baseMonitorName, DateTime? startTime = null, DateTime? endTime = null, int? maxResults = null, string? queryText = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePostgresInstancesCirTopqueriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PostgresTopQueriesApi(config);
            var cir = new ChannelInstanceRef(); // ChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var maxResults = 56;  // int? |  (optional) 
            var queryText = "queryText_example";  // string? |  (optional) 

            try
            {
                PostgresTopQueriesDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresInstancesCirTopqueriesGet(cir, baseMonitorName, startTime, endTime, maxResults, queryText);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostgresTopQueriesApi.ApiBasemonitorsBaseMonitorNamePostgresInstancesCirTopqueriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePostgresInstancesCirTopqueriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostgresTopQueriesDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresInstancesCirTopqueriesGetWithHttpInfo(cir, baseMonitorName, startTime, endTime, maxResults, queryText);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostgresTopQueriesApi.ApiBasemonitorsBaseMonitorNamePostgresInstancesCirTopqueriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**ChannelInstanceRef**](ChannelInstanceRef.md) |  |  |
| **baseMonitorName** | **string** |  |  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |
| **maxResults** | **int?** |  | [optional]  |
| **queryText** | **string?** |  | [optional]  |

### Return type

[**PostgresTopQueriesDtoJSendSuccess**](PostgresTopQueriesDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamepostgresinstancestopquerieshistoryget"></a>
# **ApiBasemonitorsBaseMonitorNamePostgresInstancesTopqueriesHistoryGet**
> PostgresTopQueryPropertyPostgresQueryHistoryPlanKeyDtoQueryHistoryDtoJSendSuccess ApiBasemonitorsBaseMonitorNamePostgresInstancesTopqueriesHistoryGet (PostgresInstanceTopQueriesChannelInstanceRef cir, string baseMonitorName, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePostgresInstancesTopqueriesHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PostgresTopQueriesApi(config);
            var cir = new PostgresInstanceTopQueriesChannelInstanceRef(); // PostgresInstanceTopQueriesChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                PostgresTopQueryPropertyPostgresQueryHistoryPlanKeyDtoQueryHistoryDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresInstancesTopqueriesHistoryGet(cir, baseMonitorName, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostgresTopQueriesApi.ApiBasemonitorsBaseMonitorNamePostgresInstancesTopqueriesHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePostgresInstancesTopqueriesHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostgresTopQueryPropertyPostgresQueryHistoryPlanKeyDtoQueryHistoryDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresInstancesTopqueriesHistoryGetWithHttpInfo(cir, baseMonitorName, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostgresTopQueriesApi.ApiBasemonitorsBaseMonitorNamePostgresInstancesTopqueriesHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**PostgresInstanceTopQueriesChannelInstanceRef**](PostgresInstanceTopQueriesChannelInstanceRef.md) |  |  |
| **baseMonitorName** | **string** |  |  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**PostgresTopQueryPropertyPostgresQueryHistoryPlanKeyDtoQueryHistoryDtoJSendSuccess**](PostgresTopQueryPropertyPostgresQueryHistoryPlanKeyDtoQueryHistoryDtoJSendSuccess.md)

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

