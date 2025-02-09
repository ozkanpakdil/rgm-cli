# cli.Api.OracleLongRunningQueriesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameOracleInstancesCirLongrunningqueriesGet**](OracleLongRunningQueriesApi.md#apibasemonitorsbasemonitornameoracleinstancescirlongrunningqueriesget) | **GET** /api/basemonitors/{baseMonitorName}/oracleInstances/{cir}/longrunningqueries |  |

<a id="apibasemonitorsbasemonitornameoracleinstancescirlongrunningqueriesget"></a>
# **ApiBasemonitorsBaseMonitorNameOracleInstancesCirLongrunningqueriesGet**
> OracleLongRunningQueriesDtoJSendSuccess ApiBasemonitorsBaseMonitorNameOracleInstancesCirLongrunningqueriesGet (OracleInstanceChannelInstanceRef cir, string baseMonitorName, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameOracleInstancesCirLongrunningqueriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OracleLongRunningQueriesApi(config);
            var cir = new OracleInstanceChannelInstanceRef(); // OracleInstanceChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                OracleLongRunningQueriesDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameOracleInstancesCirLongrunningqueriesGet(cir, baseMonitorName, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OracleLongRunningQueriesApi.ApiBasemonitorsBaseMonitorNameOracleInstancesCirLongrunningqueriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameOracleInstancesCirLongrunningqueriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OracleLongRunningQueriesDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameOracleInstancesCirLongrunningqueriesGetWithHttpInfo(cir, baseMonitorName, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OracleLongRunningQueriesApi.ApiBasemonitorsBaseMonitorNameOracleInstancesCirLongrunningqueriesGetWithHttpInfo: " + e.Message);
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

### Return type

[**OracleLongRunningQueriesDtoJSendSuccess**](OracleLongRunningQueriesDtoJSendSuccess.md)

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

