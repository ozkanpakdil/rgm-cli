# cli.Api.MonitoredMongoDbInstancesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameMongodbinstancesPost**](MonitoredMongoDbInstancesApi.md#apibasemonitorsbasemonitornamemongodbinstancespost) | **POST** /api/basemonitors/{baseMonitorName}/mongodbinstances |  |

<a id="apibasemonitorsbasemonitornamemongodbinstancespost"></a>
# **ApiBasemonitorsBaseMonitorNameMongodbinstancesPost**
> AddInstanceResultJSendSuccess ApiBasemonitorsBaseMonitorNameMongodbinstancesPost (string baseMonitorName, AddMongoDbInstanceRequest? addMongoDbInstanceRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMongodbinstancesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MonitoredMongoDbInstancesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var addMongoDbInstanceRequest = new AddMongoDbInstanceRequest?(); // AddMongoDbInstanceRequest? |  (optional) 

            try
            {
                AddInstanceResultJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMongodbinstancesPost(baseMonitorName, addMongoDbInstanceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoredMongoDbInstancesApi.ApiBasemonitorsBaseMonitorNameMongodbinstancesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMongodbinstancesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddInstanceResultJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMongodbinstancesPostWithHttpInfo(baseMonitorName, addMongoDbInstanceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MonitoredMongoDbInstancesApi.ApiBasemonitorsBaseMonitorNameMongodbinstancesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **addMongoDbInstanceRequest** | [**AddMongoDbInstanceRequest?**](AddMongoDbInstanceRequest?.md) |  | [optional]  |

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
| **422** | Unprocessable Content |  -  |
| **409** | Conflict |  -  |
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

