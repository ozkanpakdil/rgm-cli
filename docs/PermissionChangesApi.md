# cli.Api.PermissionChangesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNamePermissionChangesGet**](PermissionChangesApi.md#apibasemonitorsbasemonitornamepermissionchangesget) | **GET** /api/basemonitors/{baseMonitorName}/permission-changes |  |

<a id="apibasemonitorsbasemonitornamepermissionchangesget"></a>
# **ApiBasemonitorsBaseMonitorNamePermissionChangesGet**
> PermissionChangeDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNamePermissionChangesGet (string baseMonitorName, DateTime? startDate = null, DateTime? endDate = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePermissionChangesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PermissionChangesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                PermissionChangeDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNamePermissionChangesGet(baseMonitorName, startDate, endDate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionChangesApi.ApiBasemonitorsBaseMonitorNamePermissionChangesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePermissionChangesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PermissionChangeDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNamePermissionChangesGetWithHttpInfo(baseMonitorName, startDate, endDate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionChangesApi.ApiBasemonitorsBaseMonitorNamePermissionChangesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **startDate** | **DateTime?** |  | [optional]  |
| **endDate** | **DateTime?** |  | [optional]  |

### Return type

[**PermissionChangeDtoIEnumerableJSendSuccess**](PermissionChangeDtoIEnumerableJSendSuccess.md)

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

