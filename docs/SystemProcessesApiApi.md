# cli.Api.SystemProcessesApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSystemProcesses**](SystemProcessesApiApi.md#getsystemprocesses) | **POST** /api/basemonitors/{baseMonitorName}/alerts/systemProcesses |  |

<a id="getsystemprocesses"></a>
# **GetSystemProcesses**
> SystemProcessDtoIEnumerableJSendSuccess GetSystemProcesses (RootMonitoredEntityType rootMonitoredEntityType, string baseMonitorName, ClusterChannelInstanceRef? clusterCir = null, ChannelInstanceRef? hostMachineCir = null, SqlInstanceChannelInstanceRef? sqlInstanceCir = null, DateTime? dateRaised = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetSystemProcessesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SystemProcessesApiApi(config);
            var rootMonitoredEntityType = (RootMonitoredEntityType) "0";  // RootMonitoredEntityType | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var clusterCir = new ClusterChannelInstanceRef?(); // ClusterChannelInstanceRef? |  (optional) 
            var hostMachineCir = new ChannelInstanceRef?(); // ChannelInstanceRef? |  (optional) 
            var sqlInstanceCir = new SqlInstanceChannelInstanceRef?(); // SqlInstanceChannelInstanceRef? |  (optional) 
            var dateRaised = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                SystemProcessDtoIEnumerableJSendSuccess result = apiInstance.GetSystemProcesses(rootMonitoredEntityType, baseMonitorName, clusterCir, hostMachineCir, sqlInstanceCir, dateRaised);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemProcessesApiApi.GetSystemProcesses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSystemProcessesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SystemProcessDtoIEnumerableJSendSuccess> response = apiInstance.GetSystemProcessesWithHttpInfo(rootMonitoredEntityType, baseMonitorName, clusterCir, hostMachineCir, sqlInstanceCir, dateRaised);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemProcessesApiApi.GetSystemProcessesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rootMonitoredEntityType** | **RootMonitoredEntityType** |  |  |
| **baseMonitorName** | **string** |  |  |
| **clusterCir** | [**ClusterChannelInstanceRef?**](ClusterChannelInstanceRef?.md) |  | [optional]  |
| **hostMachineCir** | [**ChannelInstanceRef?**](ChannelInstanceRef?.md) |  | [optional]  |
| **sqlInstanceCir** | [**SqlInstanceChannelInstanceRef?**](SqlInstanceChannelInstanceRef?.md) |  | [optional]  |
| **dateRaised** | **DateTime?** |  | [optional]  |

### Return type

[**SystemProcessDtoIEnumerableJSendSuccess**](SystemProcessDtoIEnumerableJSendSuccess.md)

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

