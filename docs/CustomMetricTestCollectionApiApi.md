# cli.Api.CustomMetricTestCollectionApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionDelete**](CustomMetricTestCollectionApiApi.md#apibasemonitorsbasemonitornameconfigurationcustommetricstestcollectiondelete) | **DELETE** /api/basemonitors/{baseMonitorName}/configuration/custom-metrics/test-collection |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionGet**](CustomMetricTestCollectionApiApi.md#apibasemonitorsbasemonitornameconfigurationcustommetricstestcollectionget) | **GET** /api/basemonitors/{baseMonitorName}/configuration/custom-metrics/test-collection |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionPost**](CustomMetricTestCollectionApiApi.md#apibasemonitorsbasemonitornameconfigurationcustommetricstestcollectionpost) | **POST** /api/basemonitors/{baseMonitorName}/configuration/custom-metrics/test-collection |  |

<a id="apibasemonitorsbasemonitornameconfigurationcustommetricstestcollectiondelete"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionDelete**
> JSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionDelete (string baseMonitorName, Guid? handle = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CustomMetricTestCollectionApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var handle = "handle_example";  // Guid? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionDelete(baseMonitorName, handle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomMetricTestCollectionApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionDeleteWithHttpInfo(baseMonitorName, handle);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomMetricTestCollectionApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **handle** | **Guid?** |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameconfigurationcustommetricstestcollectionget"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionGet**
> TestCollectionStatusJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionGet (string baseMonitorName, Guid? handle = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CustomMetricTestCollectionApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var handle = "handle_example";  // Guid? |  (optional) 

            try
            {
                TestCollectionStatusJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionGet(baseMonitorName, handle);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomMetricTestCollectionApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TestCollectionStatusJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionGetWithHttpInfo(baseMonitorName, handle);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomMetricTestCollectionApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **handle** | **Guid?** |  | [optional]  |

### Return type

[**TestCollectionStatusJSendSuccess**](TestCollectionStatusJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameconfigurationcustommetricstestcollectionpost"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionPost**
> GuidJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionPost (string baseMonitorName, TestCollectionRequest? testCollectionRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CustomMetricTestCollectionApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var testCollectionRequest = new TestCollectionRequest?(); // TestCollectionRequest? |  (optional) 

            try
            {
                GuidJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionPost(baseMonitorName, testCollectionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomMetricTestCollectionApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GuidJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionPostWithHttpInfo(baseMonitorName, testCollectionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomMetricTestCollectionApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsTestCollectionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **testCollectionRequest** | [**TestCollectionRequest?**](TestCollectionRequest?.md) |  | [optional]  |

### Return type

[**GuidJSendSuccess**](GuidJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

