# cli.Api.AzureCloudCostsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAzureCloudCosts**](AzureCloudCostsApi.md#getazurecloudcosts) | **GET** /api/basemonitors/{baseMonitorName}/cloud-costs/azure |  |

<a id="getazurecloudcosts"></a>
# **GetAzureCloudCosts**
> void GetAzureCloudCosts (string baseMonitorName, string? dbmsCir = null, long? startTime = null, long? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetAzureCloudCostsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureCloudCostsApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var dbmsCir = "dbmsCir_example";  // string? |  (optional) 
            var startTime = 789L;  // long? |  (optional) 
            var endTime = 789L;  // long? |  (optional) 

            try
            {
                apiInstance.GetAzureCloudCosts(baseMonitorName, dbmsCir, startTime, endTime);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureCloudCostsApi.GetAzureCloudCosts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAzureCloudCostsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetAzureCloudCostsWithHttpInfo(baseMonitorName, dbmsCir, startTime, endTime);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureCloudCostsApi.GetAzureCloudCostsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **dbmsCir** | **string?** |  | [optional]  |
| **startTime** | **long?** |  | [optional]  |
| **endTime** | **long?** |  | [optional]  |

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

