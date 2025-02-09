# cli.Api.JobsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiEstateJobsHistoryGet**](JobsApiApi.md#apiestatejobshistoryget) | **GET** /api/estate/jobs/history |  |
| [**ApiEstateJobsPost**](JobsApiApi.md#apiestatejobspost) | **POST** /api/estate/jobs |  |

<a id="apiestatejobshistoryget"></a>
# **ApiEstateJobsHistoryGet**
> List&lt;JobHistoryViewModel&gt; ApiEstateJobsHistoryGet (int? daysHistory = null, string? baseMonitorName = null, SqlInstanceAgentJobChannelInstanceRef? jobCir = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiEstateJobsHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new JobsApiApi(config);
            var daysHistory = 56;  // int? |  (optional) 
            var baseMonitorName = "baseMonitorName_example";  // string? |  (optional) 
            var jobCir = new SqlInstanceAgentJobChannelInstanceRef?(); // SqlInstanceAgentJobChannelInstanceRef? |  (optional) 

            try
            {
                List<JobHistoryViewModel> result = apiInstance.ApiEstateJobsHistoryGet(daysHistory, baseMonitorName, jobCir);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApiApi.ApiEstateJobsHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEstateJobsHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<JobHistoryViewModel>> response = apiInstance.ApiEstateJobsHistoryGetWithHttpInfo(daysHistory, baseMonitorName, jobCir);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApiApi.ApiEstateJobsHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **daysHistory** | **int?** |  | [optional]  |
| **baseMonitorName** | **string?** |  | [optional]  |
| **jobCir** | [**SqlInstanceAgentJobChannelInstanceRef?**](SqlInstanceAgentJobChannelInstanceRef?.md) |  | [optional]  |

### Return type

[**List&lt;JobHistoryViewModel&gt;**](JobHistoryViewModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiestatejobspost"></a>
# **ApiEstateJobsPost**
> JobsViewModel ApiEstateJobsPost (JobFilterInfo? jobFilterInfo = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiEstateJobsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new JobsApiApi(config);
            var jobFilterInfo = new JobFilterInfo?(); // JobFilterInfo? |  (optional) 

            try
            {
                JobsViewModel result = apiInstance.ApiEstateJobsPost(jobFilterInfo);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApiApi.ApiEstateJobsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEstateJobsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JobsViewModel> response = apiInstance.ApiEstateJobsPostWithHttpInfo(jobFilterInfo);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApiApi.ApiEstateJobsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobFilterInfo** | [**JobFilterInfo?**](JobFilterInfo?.md) |  | [optional]  |

### Return type

[**JobsViewModel**](JobsViewModel.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

