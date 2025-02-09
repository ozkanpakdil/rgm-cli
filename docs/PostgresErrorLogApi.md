# cli.Api.PostgresErrorLogApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNamePostgresErrorLogGetErrorLogsGet**](PostgresErrorLogApi.md#apibasemonitorsbasemonitornamepostgreserrorloggeterrorlogsget) | **GET** /api/basemonitors/{baseMonitorName}/PostgresErrorLog/GetErrorLogs |  |

<a id="apibasemonitorsbasemonitornamepostgreserrorloggeterrorlogsget"></a>
# **ApiBasemonitorsBaseMonitorNamePostgresErrorLogGetErrorLogsGet**
> ServerOverviewPostgresErrorLogDtoJSendSuccess ApiBasemonitorsBaseMonitorNamePostgresErrorLogGetErrorLogsGet (string baseMonitorName, PostgresInstanceChannelInstanceRef? dbmsCir = null, DateTime? startTime = null, DateTime? endTime = null, int? pageNumber = null, int? pageSize = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePostgresErrorLogGetErrorLogsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PostgresErrorLogApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var dbmsCir = new PostgresInstanceChannelInstanceRef?(); // PostgresInstanceChannelInstanceRef? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var pageNumber = 1;  // int? |  (optional)  (default to 1)
            var pageSize = 10;  // int? |  (optional)  (default to 10)

            try
            {
                ServerOverviewPostgresErrorLogDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresErrorLogGetErrorLogsGet(baseMonitorName, dbmsCir, startTime, endTime, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostgresErrorLogApi.ApiBasemonitorsBaseMonitorNamePostgresErrorLogGetErrorLogsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePostgresErrorLogGetErrorLogsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ServerOverviewPostgresErrorLogDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresErrorLogGetErrorLogsGetWithHttpInfo(baseMonitorName, dbmsCir, startTime, endTime, pageNumber, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostgresErrorLogApi.ApiBasemonitorsBaseMonitorNamePostgresErrorLogGetErrorLogsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **dbmsCir** | [**PostgresInstanceChannelInstanceRef?**](PostgresInstanceChannelInstanceRef?.md) |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |
| **pageNumber** | **int?** |  | [optional] [default to 1] |
| **pageSize** | **int?** |  | [optional] [default to 10] |

### Return type

[**ServerOverviewPostgresErrorLogDtoJSendSuccess**](ServerOverviewPostgresErrorLogDtoJSendSuccess.md)

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

