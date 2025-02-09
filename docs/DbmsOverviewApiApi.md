# cli.Api.DbmsOverviewApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameDbmsoverviewStatusGet**](DbmsOverviewApiApi.md#apibasemonitorsbasemonitornamedbmsoverviewstatusget) | **GET** /api/basemonitors/{baseMonitorName}/dbmsoverview/status |  |

<a id="apibasemonitorsbasemonitornamedbmsoverviewstatusget"></a>
# **ApiBasemonitorsBaseMonitorNameDbmsoverviewStatusGet**
> ServerOverviewStatusModelDtoJSendSuccess ApiBasemonitorsBaseMonitorNameDbmsoverviewStatusGet (string baseMonitorName, ChannelInstanceRef dbmsCir)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameDbmsoverviewStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DbmsOverviewApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var dbmsCir = new ChannelInstanceRef(); // ChannelInstanceRef | 

            try
            {
                ServerOverviewStatusModelDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameDbmsoverviewStatusGet(baseMonitorName, dbmsCir);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DbmsOverviewApiApi.ApiBasemonitorsBaseMonitorNameDbmsoverviewStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameDbmsoverviewStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ServerOverviewStatusModelDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameDbmsoverviewStatusGetWithHttpInfo(baseMonitorName, dbmsCir);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DbmsOverviewApiApi.ApiBasemonitorsBaseMonitorNameDbmsoverviewStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **dbmsCir** | [**ChannelInstanceRef**](ChannelInstanceRef.md) |  |  |

### Return type

[**ServerOverviewStatusModelDtoJSendSuccess**](ServerOverviewStatusModelDtoJSendSuccess.md)

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

