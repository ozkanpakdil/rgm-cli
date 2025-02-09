# cli.Api.FeatureFlagsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameFeatureflagsGet**](FeatureFlagsApi.md#apibasemonitorsbasemonitornamefeatureflagsget) | **GET** /api/basemonitors/{baseMonitorName}/featureflags |  |
| [**ApiFeatureflagsGet**](FeatureFlagsApi.md#apifeatureflagsget) | **GET** /api/featureflags |  |

<a id="apibasemonitorsbasemonitornamefeatureflagsget"></a>
# **ApiBasemonitorsBaseMonitorNameFeatureflagsGet**
> FeatureFlagBooleanDictionaryJSendSuccess ApiBasemonitorsBaseMonitorNameFeatureflagsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameFeatureflagsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                FeatureFlagBooleanDictionaryJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameFeatureflagsGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.ApiBasemonitorsBaseMonitorNameFeatureflagsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameFeatureflagsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlagBooleanDictionaryJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameFeatureflagsGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.ApiBasemonitorsBaseMonitorNameFeatureflagsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**FeatureFlagBooleanDictionaryJSendSuccess**](FeatureFlagBooleanDictionaryJSendSuccess.md)

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

<a id="apifeatureflagsget"></a>
# **ApiFeatureflagsGet**
> FeatureFlagBooleanDictionaryJSendSuccess ApiFeatureflagsGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiFeatureflagsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FeatureFlagsApi(config);

            try
            {
                FeatureFlagBooleanDictionaryJSendSuccess result = apiInstance.ApiFeatureflagsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FeatureFlagsApi.ApiFeatureflagsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiFeatureflagsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FeatureFlagBooleanDictionaryJSendSuccess> response = apiInstance.ApiFeatureflagsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FeatureFlagsApi.ApiFeatureflagsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**FeatureFlagBooleanDictionaryJSendSuccess**](FeatureFlagBooleanDictionaryJSendSuccess.md)

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

