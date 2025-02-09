# cli.Api.SqlDeadlockReportApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDeadlocks**](SqlDeadlockReportApi.md#getdeadlocks) | **GET** /api/reports/deadlocks |  |

<a id="getdeadlocks"></a>
# **GetDeadlocks**
> void GetDeadlocks (long? start = null, long? end = null, string? reportPickledCir = null, string? sqlServerDisplayName = null, string? overrideServer = null, string? maxResult = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetDeadlocksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SqlDeadlockReportApi(config);
            var start = 789L;  // long? |  (optional) 
            var end = 789L;  // long? |  (optional) 
            var reportPickledCir = "reportPickledCir_example";  // string? |  (optional) 
            var sqlServerDisplayName = "sqlServerDisplayName_example";  // string? |  (optional) 
            var overrideServer = "overrideServer_example";  // string? |  (optional) 
            var maxResult = "maxResult_example";  // string? |  (optional) 

            try
            {
                apiInstance.GetDeadlocks(start, end, reportPickledCir, sqlServerDisplayName, overrideServer, maxResult);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlDeadlockReportApi.GetDeadlocks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDeadlocksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetDeadlocksWithHttpInfo(start, end, reportPickledCir, sqlServerDisplayName, overrideServer, maxResult);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlDeadlockReportApi.GetDeadlocksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **start** | **long?** |  | [optional]  |
| **end** | **long?** |  | [optional]  |
| **reportPickledCir** | **string?** |  | [optional]  |
| **sqlServerDisplayName** | **string?** |  | [optional]  |
| **overrideServer** | **string?** |  | [optional]  |
| **maxResult** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | UnprocessableEntity |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

