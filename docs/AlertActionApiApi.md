# cli.Api.AlertActionApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAlertAlertIdClearPost**](AlertActionApiApi.md#apibasemonitorsbasemonitornamealertalertidclearpost) | **POST** /api/basemonitors/{baseMonitorName}/alert/{alertId}/clear |  |
| [**ApiBasemonitorsBaseMonitorNameAlertAlertIdUnclearPost**](AlertActionApiApi.md#apibasemonitorsbasemonitornamealertalertidunclearpost) | **POST** /api/basemonitors/{baseMonitorName}/alert/{alertId}/unclear |  |

<a id="apibasemonitorsbasemonitornamealertalertidclearpost"></a>
# **ApiBasemonitorsBaseMonitorNameAlertAlertIdClearPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameAlertAlertIdClearPost (IntegerIdentifier alertId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAlertAlertIdClearPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertActionApiApi(config);
            var alertId = new IntegerIdentifier(); // IntegerIdentifier | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAlertAlertIdClearPost(alertId, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertActionApiApi.ApiBasemonitorsBaseMonitorNameAlertAlertIdClearPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAlertAlertIdClearPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAlertAlertIdClearPostWithHttpInfo(alertId, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertActionApiApi.ApiBasemonitorsBaseMonitorNameAlertAlertIdClearPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertId** | [**IntegerIdentifier**](IntegerIdentifier.md) |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**JSendSuccess**](JSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamealertalertidunclearpost"></a>
# **ApiBasemonitorsBaseMonitorNameAlertAlertIdUnclearPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameAlertAlertIdUnclearPost (IntegerIdentifier alertId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAlertAlertIdUnclearPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertActionApiApi(config);
            var alertId = new IntegerIdentifier(); // IntegerIdentifier | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAlertAlertIdUnclearPost(alertId, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertActionApiApi.ApiBasemonitorsBaseMonitorNameAlertAlertIdUnclearPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAlertAlertIdUnclearPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAlertAlertIdUnclearPostWithHttpInfo(alertId, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertActionApiApi.ApiBasemonitorsBaseMonitorNameAlertAlertIdUnclearPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertId** | [**IntegerIdentifier**](IntegerIdentifier.md) |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**JSendSuccess**](JSendSuccess.md)

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

