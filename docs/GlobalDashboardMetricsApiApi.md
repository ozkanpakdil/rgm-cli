# cli.Api.GlobalDashboardMetricsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameGlobaldashboardMonitoredentitymetricdataGet**](GlobalDashboardMetricsApiApi.md#apibasemonitorsbasemonitornameglobaldashboardmonitoredentitymetricdataget) | **GET** /api/basemonitors/{baseMonitorName}/globaldashboard/monitoredentitymetricdata |  |

<a id="apibasemonitorsbasemonitornameglobaldashboardmonitoredentitymetricdataget"></a>
# **ApiBasemonitorsBaseMonitorNameGlobaldashboardMonitoredentitymetricdataGet**
> DoubleNullableArrayIEnumerableArrayJSendSuccess ApiBasemonitorsBaseMonitorNameGlobaldashboardMonitoredentitymetricdataGet (ChannelInstanceRef cir, string type, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameGlobaldashboardMonitoredentitymetricdataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GlobalDashboardMetricsApiApi(config);
            var cir = new ChannelInstanceRef(); // ChannelInstanceRef | 
            var type = "type_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                DoubleNullableArrayIEnumerableArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameGlobaldashboardMonitoredentitymetricdataGet(cir, type, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalDashboardMetricsApiApi.ApiBasemonitorsBaseMonitorNameGlobaldashboardMonitoredentitymetricdataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameGlobaldashboardMonitoredentitymetricdataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DoubleNullableArrayIEnumerableArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameGlobaldashboardMonitoredentitymetricdataGetWithHttpInfo(cir, type, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalDashboardMetricsApiApi.ApiBasemonitorsBaseMonitorNameGlobaldashboardMonitoredentitymetricdataGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**ChannelInstanceRef**](ChannelInstanceRef.md) |  |  |
| **type** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**DoubleNullableArrayIEnumerableArrayJSendSuccess**](DoubleNullableArrayIEnumerableArrayJSendSuccess.md)

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

