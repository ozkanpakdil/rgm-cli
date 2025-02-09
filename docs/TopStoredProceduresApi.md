# cli.Api.TopStoredProceduresApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameSprocstatsGet**](TopStoredProceduresApi.md#apibasemonitorsbasemonitornamesprocstatsget) | **GET** /api/basemonitors/{baseMonitorName}/sprocstats |  |

<a id="apibasemonitorsbasemonitornamesprocstatsget"></a>
# **ApiBasemonitorsBaseMonitorNameSprocstatsGet**
> void ApiBasemonitorsBaseMonitorNameSprocstatsGet (string baseMonitorName, SqlInstanceChannelInstanceRef? cir = null, long? startTime = null, long? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameSprocstatsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TopStoredProceduresApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var cir = new SqlInstanceChannelInstanceRef?(); // SqlInstanceChannelInstanceRef? |  (optional) 
            var startTime = 789L;  // long? |  (optional) 
            var endTime = 789L;  // long? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameSprocstatsGet(baseMonitorName, cir, startTime, endTime);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TopStoredProceduresApi.ApiBasemonitorsBaseMonitorNameSprocstatsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameSprocstatsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameSprocstatsGetWithHttpInfo(baseMonitorName, cir, startTime, endTime);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TopStoredProceduresApi.ApiBasemonitorsBaseMonitorNameSprocstatsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **cir** | [**SqlInstanceChannelInstanceRef?**](SqlInstanceChannelInstanceRef?.md) |  | [optional]  |
| **startTime** | **long?** |  | [optional]  |
| **endTime** | **long?** |  | [optional]  |

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
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

