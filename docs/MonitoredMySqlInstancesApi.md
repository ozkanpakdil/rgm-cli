# cli.Api.MonitoredMySqlInstancesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameMysqlinstancesPost**](MonitoredMySqlInstancesApi.md#apibasemonitorsbasemonitornamemysqlinstancespost) | **POST** /api/basemonitors/{baseMonitorName}/mysqlinstances |  |

<a id="apibasemonitorsbasemonitornamemysqlinstancespost"></a>
# **ApiBasemonitorsBaseMonitorNameMysqlinstancesPost**
> AddInstanceResultJSendSuccess ApiBasemonitorsBaseMonitorNameMysqlinstancesPost (string baseMonitorName, AddMySqlInstanceRequest? addMySqlInstanceRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMysqlinstancesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MonitoredMySqlInstancesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var addMySqlInstanceRequest = new AddMySqlInstanceRequest?(); // AddMySqlInstanceRequest? |  (optional) 

            try
            {
                AddInstanceResultJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMysqlinstancesPost(baseMonitorName, addMySqlInstanceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoredMySqlInstancesApi.ApiBasemonitorsBaseMonitorNameMysqlinstancesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMysqlinstancesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddInstanceResultJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMysqlinstancesPostWithHttpInfo(baseMonitorName, addMySqlInstanceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MonitoredMySqlInstancesApi.ApiBasemonitorsBaseMonitorNameMysqlinstancesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **addMySqlInstanceRequest** | [**AddMySqlInstanceRequest?**](AddMySqlInstanceRequest?.md) |  | [optional]  |

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

