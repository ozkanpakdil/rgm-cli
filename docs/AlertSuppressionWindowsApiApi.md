# cli.Api.AlertSuppressionWindowsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsByNamesGet**](AlertSuppressionWindowsApiApi.md#apibasemonitorsbasemonitornamealertsuppressionwindowsbynamesget) | **GET** /api/basemonitors/{baseMonitorName}/alertsuppressionwindows/ByNames |  |
| [**ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsGet**](AlertSuppressionWindowsApiApi.md#apibasemonitorsbasemonitornamealertsuppressionwindowsget) | **GET** /api/basemonitors/{baseMonitorName}/alertsuppressionwindows |  |
| [**ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdDelete**](AlertSuppressionWindowsApiApi.md#apibasemonitorsbasemonitornamealertsuppressionwindowsiddelete) | **DELETE** /api/basemonitors/{baseMonitorName}/alertsuppressionwindows/{id} |  |
| [**ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdGet**](AlertSuppressionWindowsApiApi.md#apibasemonitorsbasemonitornamealertsuppressionwindowsidget) | **GET** /api/basemonitors/{baseMonitorName}/alertsuppressionwindows/{id} |  |
| [**ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdPut**](AlertSuppressionWindowsApiApi.md#apibasemonitorsbasemonitornamealertsuppressionwindowsidput) | **PUT** /api/basemonitors/{baseMonitorName}/alertsuppressionwindows/{id} |  |
| [**ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsPost**](AlertSuppressionWindowsApiApi.md#apibasemonitorsbasemonitornamealertsuppressionwindowspost) | **POST** /api/basemonitors/{baseMonitorName}/alertsuppressionwindows |  |
| [**ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsTargetsGet**](AlertSuppressionWindowsApiApi.md#apibasemonitorsbasemonitornamealertsuppressionwindowstargetsget) | **GET** /api/basemonitors/{baseMonitorName}/alertsuppressionwindows/targets |  |

<a id="apibasemonitorsbasemonitornamealertsuppressionwindowsbynamesget"></a>
# **ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsByNamesGet**
> AlertSuppressionWindowDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsByNamesGet (string baseMonitorName, List<string>? names = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsByNamesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertSuppressionWindowsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var names = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                AlertSuppressionWindowDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsByNamesGet(baseMonitorName, names);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsByNamesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsByNamesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertSuppressionWindowDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsByNamesGetWithHttpInfo(baseMonitorName, names);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsByNamesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **names** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

[**AlertSuppressionWindowDtoIEnumerableJSendSuccess**](AlertSuppressionWindowDtoIEnumerableJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamealertsuppressionwindowsget"></a>
# **ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsGet**
> AlertSuppressionWindowDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertSuppressionWindowsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AlertSuppressionWindowDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertSuppressionWindowDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**AlertSuppressionWindowDtoIEnumerableJSendSuccess**](AlertSuppressionWindowDtoIEnumerableJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamealertsuppressionwindowsiddelete"></a>
# **ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdDelete**
> BooleanJSendSuccess ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdDelete (IntegerIdentifier id, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertSuppressionWindowsApiApi(config);
            var id = new IntegerIdentifier(); // IntegerIdentifier | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                BooleanJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdDelete(id, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BooleanJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdDeleteWithHttpInfo(id, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | [**IntegerIdentifier**](IntegerIdentifier.md) |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**BooleanJSendSuccess**](BooleanJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamealertsuppressionwindowsidget"></a>
# **ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdGet**
> AlertSuppressionWindowDtoJSendSuccess ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdGet (IntegerIdentifier id, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertSuppressionWindowsApiApi(config);
            var id = new IntegerIdentifier(); // IntegerIdentifier | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AlertSuppressionWindowDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdGet(id, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertSuppressionWindowDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdGetWithHttpInfo(id, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | [**IntegerIdentifier**](IntegerIdentifier.md) |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**AlertSuppressionWindowDtoJSendSuccess**](AlertSuppressionWindowDtoJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamealertsuppressionwindowsidput"></a>
# **ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdPut**
> AlertSuppressionWindowDtoJSendSuccess ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdPut (IntegerIdentifier id, string baseMonitorName, AlertSuppressionWindowEditDto? alertSuppressionWindowEditDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertSuppressionWindowsApiApi(config);
            var id = new IntegerIdentifier(); // IntegerIdentifier | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var alertSuppressionWindowEditDto = new AlertSuppressionWindowEditDto?(); // AlertSuppressionWindowEditDto? |  (optional) 

            try
            {
                AlertSuppressionWindowDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdPut(id, baseMonitorName, alertSuppressionWindowEditDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertSuppressionWindowDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdPutWithHttpInfo(id, baseMonitorName, alertSuppressionWindowEditDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | [**IntegerIdentifier**](IntegerIdentifier.md) |  |  |
| **baseMonitorName** | **string** |  |  |
| **alertSuppressionWindowEditDto** | [**AlertSuppressionWindowEditDto?**](AlertSuppressionWindowEditDto?.md) |  | [optional]  |

### Return type

[**AlertSuppressionWindowDtoJSendSuccess**](AlertSuppressionWindowDtoJSendSuccess.md)

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
| **409** | Conflict |  -  |
| **422** | Unprocessable Content |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamealertsuppressionwindowspost"></a>
# **ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsPost**
> AlertSuppressionWindowDtoJSendSuccess ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsPost (string baseMonitorName, AlertSuppressionWindowEditDto? alertSuppressionWindowEditDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertSuppressionWindowsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var alertSuppressionWindowEditDto = new AlertSuppressionWindowEditDto?(); // AlertSuppressionWindowEditDto? |  (optional) 

            try
            {
                AlertSuppressionWindowDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsPost(baseMonitorName, alertSuppressionWindowEditDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertSuppressionWindowDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsPostWithHttpInfo(baseMonitorName, alertSuppressionWindowEditDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **alertSuppressionWindowEditDto** | [**AlertSuppressionWindowEditDto?**](AlertSuppressionWindowEditDto?.md) |  | [optional]  |

### Return type

[**AlertSuppressionWindowDtoJSendSuccess**](AlertSuppressionWindowDtoJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Content |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamealertsuppressionwindowstargetsget"></a>
# **ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsTargetsGet**
> AlertSuppressionTargetDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsTargetsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsTargetsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertSuppressionWindowsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AlertSuppressionTargetDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsTargetsGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsTargetsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsTargetsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertSuppressionTargetDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsTargetsGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertSuppressionWindowsApiApi.ApiBasemonitorsBaseMonitorNameAlertsuppressionwindowsTargetsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**AlertSuppressionTargetDtoIEnumerableJSendSuccess**](AlertSuppressionTargetDtoIEnumerableJSendSuccess.md)

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

