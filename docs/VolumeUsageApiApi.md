# cli.Api.VolumeUsageApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiEstateDiskUsageDisksPost**](VolumeUsageApiApi.md#apiestatediskusagediskspost) | **POST** /api/estate/disk-usage/disks |  |
| [**ApiEstateDiskUsageHistoricUsagePost**](VolumeUsageApiApi.md#apiestatediskusagehistoricusagepost) | **POST** /api/estate/disk-usage/historic-usage |  |

<a id="apiestatediskusagediskspost"></a>
# **ApiEstateDiskUsageDisksPost**
> VolumesViewModelJSendSuccess ApiEstateDiskUsageDisksPost (DiskFilterInfoDto? diskFilterInfoDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiEstateDiskUsageDisksPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new VolumeUsageApiApi(config);
            var diskFilterInfoDto = new DiskFilterInfoDto?(); // DiskFilterInfoDto? |  (optional) 

            try
            {
                VolumesViewModelJSendSuccess result = apiInstance.ApiEstateDiskUsageDisksPost(diskFilterInfoDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumeUsageApiApi.ApiEstateDiskUsageDisksPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEstateDiskUsageDisksPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VolumesViewModelJSendSuccess> response = apiInstance.ApiEstateDiskUsageDisksPostWithHttpInfo(diskFilterInfoDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumeUsageApiApi.ApiEstateDiskUsageDisksPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diskFilterInfoDto** | [**DiskFilterInfoDto?**](DiskFilterInfoDto?.md) |  | [optional]  |

### Return type

[**VolumesViewModelJSendSuccess**](VolumesViewModelJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiestatediskusagehistoricusagepost"></a>
# **ApiEstateDiskUsageHistoricUsagePost**
> HistoricVolumeUsageViewModelJSendSuccess ApiEstateDiskUsageHistoricUsagePost (DiskFilterInfoDto? diskFilterInfoDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiEstateDiskUsageHistoricUsagePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new VolumeUsageApiApi(config);
            var diskFilterInfoDto = new DiskFilterInfoDto?(); // DiskFilterInfoDto? |  (optional) 

            try
            {
                HistoricVolumeUsageViewModelJSendSuccess result = apiInstance.ApiEstateDiskUsageHistoricUsagePost(diskFilterInfoDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VolumeUsageApiApi.ApiEstateDiskUsageHistoricUsagePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEstateDiskUsageHistoricUsagePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<HistoricVolumeUsageViewModelJSendSuccess> response = apiInstance.ApiEstateDiskUsageHistoricUsagePostWithHttpInfo(diskFilterInfoDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VolumeUsageApiApi.ApiEstateDiskUsageHistoricUsagePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **diskFilterInfoDto** | [**DiskFilterInfoDto?**](DiskFilterInfoDto?.md) |  | [optional]  |

### Return type

[**HistoricVolumeUsageViewModelJSendSuccess**](HistoricVolumeUsageViewModelJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

