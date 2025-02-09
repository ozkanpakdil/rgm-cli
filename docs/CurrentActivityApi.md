# cli.Api.CurrentActivityApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameInstancesCirCurrentActivityGet**](CurrentActivityApi.md#apibasemonitorsbasemonitornameinstancescircurrentactivityget) | **GET** /api/basemonitors/{baseMonitorName}/instances/{cir}/current-activity |  |

<a id="apibasemonitorsbasemonitornameinstancescircurrentactivityget"></a>
# **ApiBasemonitorsBaseMonitorNameInstancesCirCurrentActivityGet**
> CurrentActivityDtoJSendSuccess ApiBasemonitorsBaseMonitorNameInstancesCirCurrentActivityGet (ChannelInstanceRef cir, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameInstancesCirCurrentActivityGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CurrentActivityApi(config);
            var cir = new ChannelInstanceRef(); // ChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                CurrentActivityDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameInstancesCirCurrentActivityGet(cir, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CurrentActivityApi.ApiBasemonitorsBaseMonitorNameInstancesCirCurrentActivityGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameInstancesCirCurrentActivityGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CurrentActivityDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameInstancesCirCurrentActivityGetWithHttpInfo(cir, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CurrentActivityApi.ApiBasemonitorsBaseMonitorNameInstancesCirCurrentActivityGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**ChannelInstanceRef**](ChannelInstanceRef.md) |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**CurrentActivityDtoJSendSuccess**](CurrentActivityDtoJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **504** | Gateway Timeout |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

