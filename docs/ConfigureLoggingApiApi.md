# cli.Api.ConfigureLoggingApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost**](ConfigureLoggingApiApi.md#apibasemonitorsbasemonitornameconfigurationloggingpost) | **POST** /api/basemonitors/{baseMonitorName}/configuration/logging |  |
| [**ApiConfigurationLoggingPerformancePost**](ConfigureLoggingApiApi.md#apiconfigurationloggingperformancepost) | **POST** /api/configuration/logging/performance |  |
| [**ApiConfigurationLoggingPost**](ConfigureLoggingApiApi.md#apiconfigurationloggingpost) | **POST** /api/configuration/logging |  |

<a id="apibasemonitorsbasemonitornameconfigurationloggingpost"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost (string baseMonitorName, LogLevelSwitchParamsDto? logLevelSwitchParamsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationLoggingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureLoggingApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var logLevelSwitchParamsDto = new LogLevelSwitchParamsDto?(); // LogLevelSwitchParamsDto? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost(baseMonitorName, logLevelSwitchParamsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureLoggingApiApi.ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationLoggingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationLoggingPostWithHttpInfo(baseMonitorName, logLevelSwitchParamsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureLoggingApiApi.ApiBasemonitorsBaseMonitorNameConfigurationLoggingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **logLevelSwitchParamsDto** | [**LogLevelSwitchParamsDto?**](LogLevelSwitchParamsDto?.md) |  | [optional]  |

### Return type

[**JSendSuccess**](JSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiconfigurationloggingperformancepost"></a>
# **ApiConfigurationLoggingPerformancePost**
> JSendSuccess ApiConfigurationLoggingPerformancePost (int? enabledSeconds = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiConfigurationLoggingPerformancePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureLoggingApiApi(config);
            var enabledSeconds = 56;  // int? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiConfigurationLoggingPerformancePost(enabledSeconds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureLoggingApiApi.ApiConfigurationLoggingPerformancePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiConfigurationLoggingPerformancePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiConfigurationLoggingPerformancePostWithHttpInfo(enabledSeconds);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureLoggingApiApi.ApiConfigurationLoggingPerformancePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **enabledSeconds** | **int?** |  | [optional]  |

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

<a id="apiconfigurationloggingpost"></a>
# **ApiConfigurationLoggingPost**
> JSendSuccess ApiConfigurationLoggingPost (LogLevelSwitchParamsDto? logLevelSwitchParamsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiConfigurationLoggingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureLoggingApiApi(config);
            var logLevelSwitchParamsDto = new LogLevelSwitchParamsDto?(); // LogLevelSwitchParamsDto? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiConfigurationLoggingPost(logLevelSwitchParamsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureLoggingApiApi.ApiConfigurationLoggingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiConfigurationLoggingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiConfigurationLoggingPostWithHttpInfo(logLevelSwitchParamsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureLoggingApiApi.ApiConfigurationLoggingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **logLevelSwitchParamsDto** | [**LogLevelSwitchParamsDto?**](LogLevelSwitchParamsDto?.md) |  | [optional]  |

### Return type

[**JSendSuccess**](JSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

