# cli.Api.ForecastApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet**](ForecastApi.md#apibasemonitorsbasemonitornamesqlinstancescircpualertforecastget) | **GET** /api/basemonitors/{baseMonitorName}/sqlinstances/{cir}/cpu-alert-forecast |  |

<a id="apibasemonitorsbasemonitornamesqlinstancescircpualertforecastget"></a>
# **ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet**
> DoubleArrayIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet (GroupOrCir cir, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ForecastApi(config);
            var cir = new GroupOrCir(); // GroupOrCir | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                DoubleArrayIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet(cir, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForecastApi.ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DoubleArrayIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGetWithHttpInfo(cir, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ForecastApi.ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**GroupOrCir**](GroupOrCir.md) |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**DoubleArrayIEnumerableJSendSuccess**](DoubleArrayIEnumerableJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

