# cli.Api.MonitoredEntityInfoApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameMonitoredEntityInfoGet**](MonitoredEntityInfoApi.md#apibasemonitorsbasemonitornamemonitoredentityinfoget) | **GET** /api/basemonitors/{baseMonitorName}/monitored-entity-info |  |

<a id="apibasemonitorsbasemonitornamemonitoredentityinfoget"></a>
# **ApiBasemonitorsBaseMonitorNameMonitoredEntityInfoGet**
> MonitoredEntityInfoDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameMonitoredEntityInfoGet (string baseMonitorName, DateTime? runDate = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMonitoredEntityInfoGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MonitoredEntityInfoApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                MonitoredEntityInfoDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredEntityInfoGet(baseMonitorName, runDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoredEntityInfoApi.ApiBasemonitorsBaseMonitorNameMonitoredEntityInfoGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMonitoredEntityInfoGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MonitoredEntityInfoDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredEntityInfoGetWithHttpInfo(baseMonitorName, runDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MonitoredEntityInfoApi.ApiBasemonitorsBaseMonitorNameMonitoredEntityInfoGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **runDate** | **DateTime?** |  | [optional]  |

### Return type

[**MonitoredEntityInfoDtoIEnumerableJSendSuccess**](MonitoredEntityInfoDtoIEnumerableJSendSuccess.md)

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

