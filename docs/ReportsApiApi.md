# cli.Api.ReportsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameReportServerconfigurationChannelInstanceRefGet**](ReportsApiApi.md#apibasemonitorsbasemonitornamereportserverconfigurationchannelinstancerefget) | **GET** /api/basemonitors/{baseMonitorName}/report/serverconfiguration/{channelInstanceRef} |  |

<a id="apibasemonitorsbasemonitornamereportserverconfigurationchannelinstancerefget"></a>
# **ApiBasemonitorsBaseMonitorNameReportServerconfigurationChannelInstanceRefGet**
> ServerConfigResultJSendSuccess ApiBasemonitorsBaseMonitorNameReportServerconfigurationChannelInstanceRefGet (string baseMonitorName, ChannelInstanceRef channelInstanceRef, DateTime start, DateTime end)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameReportServerconfigurationChannelInstanceRefGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ReportsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var channelInstanceRef = new ChannelInstanceRef(); // ChannelInstanceRef | 
            var start = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var end = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 

            try
            {
                ServerConfigResultJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameReportServerconfigurationChannelInstanceRefGet(baseMonitorName, channelInstanceRef, start, end);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportsApiApi.ApiBasemonitorsBaseMonitorNameReportServerconfigurationChannelInstanceRefGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameReportServerconfigurationChannelInstanceRefGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ServerConfigResultJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameReportServerconfigurationChannelInstanceRefGetWithHttpInfo(baseMonitorName, channelInstanceRef, start, end);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportsApiApi.ApiBasemonitorsBaseMonitorNameReportServerconfigurationChannelInstanceRefGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **channelInstanceRef** | [**ChannelInstanceRef**](ChannelInstanceRef.md) |  |  |
| **start** | **DateTime** |  |  |
| **end** | **DateTime** |  |  |

### Return type

[**ServerConfigResultJSendSuccess**](ServerConfigResultJSendSuccess.md)

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

