# cli.Api.AmazonAuroraClusterNodeApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAmazonauroraclustersNodesGet**](AmazonAuroraClusterNodeApi.md#apibasemonitorsbasemonitornameamazonauroraclustersnodesget) | **GET** /api/basemonitors/{baseMonitorName}/amazonauroraclusters/nodes |  |

<a id="apibasemonitorsbasemonitornameamazonauroraclustersnodesget"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonauroraclustersNodesGet**
> AmazonAuroraClusterNodeDtoArrayJSendSuccess ApiBasemonitorsBaseMonitorNameAmazonauroraclustersNodesGet (string baseMonitorName, PostgresInstanceChannelInstanceRef? cir = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonauroraclustersNodesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonAuroraClusterNodeApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var cir = new PostgresInstanceChannelInstanceRef?(); // PostgresInstanceChannelInstanceRef? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                AmazonAuroraClusterNodeDtoArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersNodesGet(baseMonitorName, cir, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonAuroraClusterNodeApi.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersNodesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonauroraclustersNodesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AmazonAuroraClusterNodeDtoArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersNodesGetWithHttpInfo(baseMonitorName, cir, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonAuroraClusterNodeApi.ApiBasemonitorsBaseMonitorNameAmazonauroraclustersNodesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **cir** | [**PostgresInstanceChannelInstanceRef?**](PostgresInstanceChannelInstanceRef?.md) |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**AmazonAuroraClusterNodeDtoArrayJSendSuccess**](AmazonAuroraClusterNodeDtoArrayJSendSuccess.md)

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

