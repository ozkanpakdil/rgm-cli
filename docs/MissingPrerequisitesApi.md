# cli.Api.MissingPrerequisitesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameMissingPrerequisitesGet**](MissingPrerequisitesApi.md#apibasemonitorsbasemonitornamemissingprerequisitesget) | **GET** /api/basemonitors/{baseMonitorName}/missing-prerequisites |  |

<a id="apibasemonitorsbasemonitornamemissingprerequisitesget"></a>
# **ApiBasemonitorsBaseMonitorNameMissingPrerequisitesGet**
> void ApiBasemonitorsBaseMonitorNameMissingPrerequisitesGet (string baseMonitorName, string? instanceCir = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMissingPrerequisitesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MissingPrerequisitesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var instanceCir = "instanceCir_example";  // string? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameMissingPrerequisitesGet(baseMonitorName, instanceCir, startTime, endTime);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MissingPrerequisitesApi.ApiBasemonitorsBaseMonitorNameMissingPrerequisitesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMissingPrerequisitesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameMissingPrerequisitesGetWithHttpInfo(baseMonitorName, instanceCir, startTime, endTime);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MissingPrerequisitesApi.ApiBasemonitorsBaseMonitorNameMissingPrerequisitesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **instanceCir** | **string?** |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

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

