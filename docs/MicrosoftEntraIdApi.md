# cli.Api.MicrosoftEntraIdApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameMicrosoftentraidsGet**](MicrosoftEntraIdApi.md#apibasemonitorsbasemonitornamemicrosoftentraidsget) | **GET** /api/basemonitors/{baseMonitorName}/microsoftentraids |  |
| [**ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdDelete**](MicrosoftEntraIdApi.md#apibasemonitorsbasemonitornamemicrosoftentraidsiddelete) | **DELETE** /api/basemonitors/{baseMonitorName}/microsoftentraids/{id} |  |
| [**ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdGet**](MicrosoftEntraIdApi.md#apibasemonitorsbasemonitornamemicrosoftentraidsidget) | **GET** /api/basemonitors/{baseMonitorName}/microsoftentraids/{id} |  |
| [**ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdPut**](MicrosoftEntraIdApi.md#apibasemonitorsbasemonitornamemicrosoftentraidsidput) | **PUT** /api/basemonitors/{baseMonitorName}/microsoftentraids/{id} |  |
| [**ApiBasemonitorsBaseMonitorNameMicrosoftentraidsPost**](MicrosoftEntraIdApi.md#apibasemonitorsbasemonitornamemicrosoftentraidspost) | **POST** /api/basemonitors/{baseMonitorName}/microsoftentraids |  |
| [**ApiBasemonitorsBaseMonitorNameMicrosoftentraidsTestPost**](MicrosoftEntraIdApi.md#apibasemonitorsbasemonitornamemicrosoftentraidstestpost) | **POST** /api/basemonitors/{baseMonitorName}/microsoftentraids/test |  |

<a id="apibasemonitorsbasemonitornamemicrosoftentraidsget"></a>
# **ApiBasemonitorsBaseMonitorNameMicrosoftentraidsGet**
> void ApiBasemonitorsBaseMonitorNameMicrosoftentraidsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMicrosoftentraidsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MicrosoftEntraIdApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrosoftEntraIdApi.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMicrosoftentraidsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrosoftEntraIdApi.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

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
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamemicrosoftentraidsiddelete"></a>
# **ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdDelete**
> void ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdDelete (Guid id, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MicrosoftEntraIdApi(config);
            var id = "id_example";  // Guid | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdDelete(id, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrosoftEntraIdApi.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdDeleteWithHttpInfo(id, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrosoftEntraIdApi.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **baseMonitorName** | **string** |  |  |

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
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamemicrosoftentraidsidget"></a>
# **ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdGet**
> void ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdGet (Guid id, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MicrosoftEntraIdApi(config);
            var id = "id_example";  // Guid | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdGet(id, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrosoftEntraIdApi.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdGetWithHttpInfo(id, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrosoftEntraIdApi.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **baseMonitorName** | **string** |  |  |

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
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamemicrosoftentraidsidput"></a>
# **ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdPut**
> void ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdPut (Guid id, string baseMonitorName, MicrosoftEntraIdDto? microsoftEntraIdDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MicrosoftEntraIdApi(config);
            var id = "id_example";  // Guid | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var microsoftEntraIdDto = new MicrosoftEntraIdDto?(); // MicrosoftEntraIdDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdPut(id, baseMonitorName, microsoftEntraIdDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrosoftEntraIdApi.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdPutWithHttpInfo(id, baseMonitorName, microsoftEntraIdDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrosoftEntraIdApi.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **baseMonitorName** | **string** |  |  |
| **microsoftEntraIdDto** | [**MicrosoftEntraIdDto?**](MicrosoftEntraIdDto?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **409** | Conflict |  -  |
| **404** | Not Found |  -  |
| **204** | No Content |  -  |
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamemicrosoftentraidspost"></a>
# **ApiBasemonitorsBaseMonitorNameMicrosoftentraidsPost**
> AddMicrosoftEntraIdResultJSendSuccess ApiBasemonitorsBaseMonitorNameMicrosoftentraidsPost (string baseMonitorName, AddMicrosoftEntraIdRequest? addMicrosoftEntraIdRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMicrosoftentraidsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MicrosoftEntraIdApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var addMicrosoftEntraIdRequest = new AddMicrosoftEntraIdRequest?(); // AddMicrosoftEntraIdRequest? |  (optional) 

            try
            {
                AddMicrosoftEntraIdResultJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsPost(baseMonitorName, addMicrosoftEntraIdRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrosoftEntraIdApi.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMicrosoftentraidsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddMicrosoftEntraIdResultJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsPostWithHttpInfo(baseMonitorName, addMicrosoftEntraIdRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrosoftEntraIdApi.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **addMicrosoftEntraIdRequest** | [**AddMicrosoftEntraIdRequest?**](AddMicrosoftEntraIdRequest?.md) |  | [optional]  |

### Return type

[**AddMicrosoftEntraIdResultJSendSuccess**](AddMicrosoftEntraIdResultJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **422** | Unprocessable Content |  -  |
| **409** | Conflict |  -  |
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamemicrosoftentraidstestpost"></a>
# **ApiBasemonitorsBaseMonitorNameMicrosoftentraidsTestPost**
> void ApiBasemonitorsBaseMonitorNameMicrosoftentraidsTestPost (string baseMonitorName, AddMicrosoftEntraIdRequest? addMicrosoftEntraIdRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMicrosoftentraidsTestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MicrosoftEntraIdApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var addMicrosoftEntraIdRequest = new AddMicrosoftEntraIdRequest?(); // AddMicrosoftEntraIdRequest? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsTestPost(baseMonitorName, addMicrosoftEntraIdRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicrosoftEntraIdApi.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsTestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMicrosoftentraidsTestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsTestPostWithHttpInfo(baseMonitorName, addMicrosoftEntraIdRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicrosoftEntraIdApi.ApiBasemonitorsBaseMonitorNameMicrosoftentraidsTestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **addMicrosoftEntraIdRequest** | [**AddMicrosoftEntraIdRequest?**](AddMicrosoftEntraIdRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

