# cli.Api.UserPermissionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameUserPermissionsV2RunDateGet**](UserPermissionsApi.md#apibasemonitorsbasemonitornameuserpermissionsv2rundateget) | **GET** /api/basemonitors/{baseMonitorName}/user-permissions/v2/{runDate} |  |

<a id="apibasemonitorsbasemonitornameuserpermissionsv2rundateget"></a>
# **ApiBasemonitorsBaseMonitorNameUserPermissionsV2RunDateGet**
> OldUserPermissionAndMonitoredEntityDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameUserPermissionsV2RunDateGet (DateTime runDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameUserPermissionsV2RunDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserPermissionsApi(config);
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                OldUserPermissionAndMonitoredEntityDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameUserPermissionsV2RunDateGet(runDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPermissionsApi.ApiBasemonitorsBaseMonitorNameUserPermissionsV2RunDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameUserPermissionsV2RunDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OldUserPermissionAndMonitoredEntityDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameUserPermissionsV2RunDateGetWithHttpInfo(runDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPermissionsApi.ApiBasemonitorsBaseMonitorNameUserPermissionsV2RunDateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runDate** | **DateTime** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**OldUserPermissionAndMonitoredEntityDtoIEnumerableJSendSuccess**](OldUserPermissionAndMonitoredEntityDtoIEnumerableJSendSuccess.md)

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

