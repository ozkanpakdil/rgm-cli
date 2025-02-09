# cli.Api.MonitoredOracleInstancesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameOracleinstancesPost**](MonitoredOracleInstancesApi.md#apibasemonitorsbasemonitornameoracleinstancespost) | **POST** /api/basemonitors/{baseMonitorName}/oracleinstances |  |

<a id="apibasemonitorsbasemonitornameoracleinstancespost"></a>
# **ApiBasemonitorsBaseMonitorNameOracleinstancesPost**
> AddInstanceResultJSendSuccess ApiBasemonitorsBaseMonitorNameOracleinstancesPost (string baseMonitorName, AddOracleInstanceRequest? addOracleInstanceRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameOracleinstancesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MonitoredOracleInstancesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var addOracleInstanceRequest = new AddOracleInstanceRequest?(); // AddOracleInstanceRequest? |  (optional) 

            try
            {
                AddInstanceResultJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameOracleinstancesPost(baseMonitorName, addOracleInstanceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoredOracleInstancesApi.ApiBasemonitorsBaseMonitorNameOracleinstancesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameOracleinstancesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddInstanceResultJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameOracleinstancesPostWithHttpInfo(baseMonitorName, addOracleInstanceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MonitoredOracleInstancesApi.ApiBasemonitorsBaseMonitorNameOracleinstancesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **addOracleInstanceRequest** | [**AddOracleInstanceRequest?**](AddOracleInstanceRequest?.md) |  | [optional]  |

### Return type

[**AddInstanceResultJSendSuccess**](AddInstanceResultJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **422** | Unprocessable Content |  -  |
| **409** | Conflict |  -  |
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

