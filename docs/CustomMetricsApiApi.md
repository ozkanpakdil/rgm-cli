# cli.Api.CustomMetricsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsDelete**](CustomMetricsApiApi.md#apibasemonitorsbasemonitornameconfigurationcustommetricsalertsdelete) | **DELETE** /api/basemonitors/{baseMonitorName}/configuration/custom-metrics/alerts |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsEnablePut**](CustomMetricsApiApi.md#apibasemonitorsbasemonitornameconfigurationcustommetricsalertsenableput) | **PUT** /api/basemonitors/{baseMonitorName}/configuration/custom-metrics/alerts/enable |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDatabasesGet**](CustomMetricsApiApi.md#apibasemonitorsbasemonitornameconfigurationcustommetricsdatabasesget) | **GET** /api/basemonitors/{baseMonitorName}/configuration/custom-metrics/databases |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDelete**](CustomMetricsApiApi.md#apibasemonitorsbasemonitornameconfigurationcustommetricsdelete) | **DELETE** /api/basemonitors/{baseMonitorName}/configuration/custom-metrics |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsEnablePut**](CustomMetricsApiApi.md#apibasemonitorsbasemonitornameconfigurationcustommetricsenableput) | **PUT** /api/basemonitors/{baseMonitorName}/configuration/custom-metrics/enable |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsGet**](CustomMetricsApiApi.md#apibasemonitorsbasemonitornameconfigurationcustommetricsget) | **GET** /api/basemonitors/{baseMonitorName}/configuration/custom-metrics |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsMonitoredEntityTreeGet**](CustomMetricsApiApi.md#apibasemonitorsbasemonitornameconfigurationcustommetricsmonitoredentitytreeget) | **GET** /api/basemonitors/{baseMonitorName}/configuration/custom-metrics/monitored-entity-tree |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsPost**](CustomMetricsApiApi.md#apibasemonitorsbasemonitornameconfigurationcustommetricspost) | **POST** /api/basemonitors/{baseMonitorName}/configuration/custom-metrics |  |

<a id="apibasemonitorsbasemonitornameconfigurationcustommetricsalertsdelete"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsDelete**
> StringJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsDelete (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CustomMetricsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                StringJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsDelete(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StringJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsDeleteWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**StringJSendSuccess**](StringJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameconfigurationcustommetricsalertsenableput"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsEnablePut**
> StringJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsEnablePut (string baseMonitorName, bool? enable = null, List<IntegerIdentifier>? integerIdentifier = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsEnablePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CustomMetricsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var enable = true;  // bool? |  (optional) 
            var integerIdentifier = new List<IntegerIdentifier>?(); // List<IntegerIdentifier>? |  (optional) 

            try
            {
                StringJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsEnablePut(baseMonitorName, enable, integerIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsEnablePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsEnablePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StringJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsEnablePutWithHttpInfo(baseMonitorName, enable, integerIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsAlertsEnablePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **enable** | **bool?** |  | [optional]  |
| **integerIdentifier** | [**List&lt;IntegerIdentifier&gt;?**](IntegerIdentifier.md) |  | [optional]  |

### Return type

[**StringJSendSuccess**](StringJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameconfigurationcustommetricsdatabasesget"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDatabasesGet**
> DatabaseDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDatabasesGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDatabasesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CustomMetricsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                DatabaseDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDatabasesGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDatabasesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDatabasesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DatabaseDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDatabasesGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDatabasesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**DatabaseDtoIEnumerableJSendSuccess**](DatabaseDtoIEnumerableJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameconfigurationcustommetricsdelete"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDelete**
> StringJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDelete (string baseMonitorName, List<IntegerIdentifier>? integerIdentifier = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CustomMetricsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var integerIdentifier = new List<IntegerIdentifier>?(); // List<IntegerIdentifier>? |  (optional) 

            try
            {
                StringJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDelete(baseMonitorName, integerIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StringJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDeleteWithHttpInfo(baseMonitorName, integerIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **integerIdentifier** | [**List&lt;IntegerIdentifier&gt;?**](IntegerIdentifier.md) |  | [optional]  |

### Return type

[**StringJSendSuccess**](StringJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameconfigurationcustommetricsenableput"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsEnablePut**
> StringJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsEnablePut (string baseMonitorName, bool? enable = null, List<IntegerIdentifier>? integerIdentifier = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsEnablePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CustomMetricsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var enable = true;  // bool? |  (optional) 
            var integerIdentifier = new List<IntegerIdentifier>?(); // List<IntegerIdentifier>? |  (optional) 

            try
            {
                StringJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsEnablePut(baseMonitorName, enable, integerIdentifier);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsEnablePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsEnablePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<StringJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsEnablePutWithHttpInfo(baseMonitorName, enable, integerIdentifier);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsEnablePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **enable** | **bool?** |  | [optional]  |
| **integerIdentifier** | [**List&lt;IntegerIdentifier&gt;?**](IntegerIdentifier.md) |  | [optional]  |

### Return type

[**StringJSendSuccess**](StringJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameconfigurationcustommetricsget"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsGet**
> CustomMetricsGridDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CustomMetricsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                CustomMetricsGridDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CustomMetricsGridDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**CustomMetricsGridDtoIEnumerableJSendSuccess**](CustomMetricsGridDtoIEnumerableJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameconfigurationcustommetricsmonitoredentitytreeget"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsMonitoredEntityTreeGet**
> MonitoredEntityTreeDtoJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsMonitoredEntityTreeGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsMonitoredEntityTreeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CustomMetricsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                MonitoredEntityTreeDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsMonitoredEntityTreeGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsMonitoredEntityTreeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsMonitoredEntityTreeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MonitoredEntityTreeDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsMonitoredEntityTreeGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsMonitoredEntityTreeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**MonitoredEntityTreeDtoJSendSuccess**](MonitoredEntityTreeDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameconfigurationcustommetricspost"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsPost**
> IntegerIdentifierJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsPost (string baseMonitorName, CustomMetricDto? customMetricDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CustomMetricsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var customMetricDto = new CustomMetricDto?(); // CustomMetricDto? |  (optional) 

            try
            {
                IntegerIdentifierJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsPost(baseMonitorName, customMetricDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IntegerIdentifierJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsPostWithHttpInfo(baseMonitorName, customMetricDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomMetricsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationCustomMetricsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **customMetricDto** | [**CustomMetricDto?**](CustomMetricDto?.md) |  | [optional]  |

### Return type

[**IntegerIdentifierJSendSuccess**](IntegerIdentifierJSendSuccess.md)

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

