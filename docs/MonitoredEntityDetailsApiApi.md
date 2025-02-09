# cli.Api.MonitoredEntityDetailsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameMonitoredentitiesCirLogGet**](MonitoredEntityDetailsApiApi.md#apibasemonitorsbasemonitornamemonitoredentitiescirlogget) | **GET** /api/basemonitors/{baseMonitorName}/monitoredentities/{cir}/log |  |

<a id="apibasemonitorsbasemonitornamemonitoredentitiescirlogget"></a>
# **ApiBasemonitorsBaseMonitorNameMonitoredentitiesCirLogGet**
> MonitoredEntityDetailsModelDtoJSendSuccess ApiBasemonitorsBaseMonitorNameMonitoredentitiesCirLogGet (ChannelInstanceRef cir, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMonitoredentitiesCirLogGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MonitoredEntityDetailsApiApi(config);
            var cir = new ChannelInstanceRef(); // ChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                MonitoredEntityDetailsModelDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredentitiesCirLogGet(cir, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoredEntityDetailsApiApi.ApiBasemonitorsBaseMonitorNameMonitoredentitiesCirLogGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMonitoredentitiesCirLogGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MonitoredEntityDetailsModelDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredentitiesCirLogGetWithHttpInfo(cir, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MonitoredEntityDetailsApiApi.ApiBasemonitorsBaseMonitorNameMonitoredentitiesCirLogGetWithHttpInfo: " + e.Message);
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

[**MonitoredEntityDetailsModelDtoJSendSuccess**](MonitoredEntityDetailsModelDtoJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

