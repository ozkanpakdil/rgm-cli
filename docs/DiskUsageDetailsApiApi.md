# cli.Api.DiskUsageDetailsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiEstateDiskUsageDetailsGet**](DiskUsageDetailsApiApi.md#apiestatediskusagedetailsget) | **GET** /api/estate/disk-usage-details |  |

<a id="apiestatediskusagedetailsget"></a>
# **ApiEstateDiskUsageDetailsGet**
> DatabaseFileUsageViewModelJSendSuccess ApiEstateDiskUsageDetailsGet (ChannelInstanceRef? diskCir = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiEstateDiskUsageDetailsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DiskUsageDetailsApiApi(config);
            var diskCir = new ChannelInstanceRef?(); // ChannelInstanceRef? |  (optional) 

            try
            {
                DatabaseFileUsageViewModelJSendSuccess result = apiInstance.ApiEstateDiskUsageDetailsGet(diskCir);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiskUsageDetailsApiApi.ApiEstateDiskUsageDetailsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEstateDiskUsageDetailsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DatabaseFileUsageViewModelJSendSuccess> response = apiInstance.ApiEstateDiskUsageDetailsGetWithHttpInfo(diskCir);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiskUsageDetailsApiApi.ApiEstateDiskUsageDetailsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diskCir** | [**ChannelInstanceRef?**](ChannelInstanceRef?.md) |  | [optional]  |

### Return type

[**DatabaseFileUsageViewModelJSendSuccess**](DatabaseFileUsageViewModelJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | Unprocessable Content |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

