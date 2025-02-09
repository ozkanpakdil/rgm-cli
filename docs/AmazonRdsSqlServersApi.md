# cli.Api.AmazonRdsSqlServersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameDelete**](AmazonRdsSqlServersApi.md#apibasemonitorsbasemonitornameamazonrdssqlserversamazonrdssqlservernamedelete) | **DELETE** /api/basemonitors/{baseMonitorName}/amazonrdssqlservers/{amazonRdsSqlServerName} |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameGet**](AmazonRdsSqlServersApi.md#apibasemonitorsbasemonitornameamazonrdssqlserversamazonrdssqlservernameget) | **GET** /api/basemonitors/{baseMonitorName}/amazonrdssqlservers/{amazonRdsSqlServerName} |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsAmazonapiDelete**](AmazonRdsSqlServersApi.md#apibasemonitorsbasemonitornameamazonrdssqlserverscredentialsamazonapidelete) | **DELETE** /api/basemonitors/{baseMonitorName}/amazonrdssqlservers/credentials/amazonapi |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsPatch**](AmazonRdsSqlServersApi.md#apibasemonitorsbasemonitornameamazonrdssqlserverscredentialspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/amazonrdssqlservers/credentials |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversGet**](AmazonRdsSqlServersApi.md#apibasemonitorsbasemonitornameamazonrdssqlserversget) | **GET** /api/basemonitors/{baseMonitorName}/amazonrdssqlservers |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversInstanceNamePut**](AmazonRdsSqlServersApi.md#apibasemonitorsbasemonitornameamazonrdssqlserversinstancenameput) | **PUT** /api/basemonitors/{baseMonitorName}/amazonrdssqlservers/{instanceName} |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversPost**](AmazonRdsSqlServersApi.md#apibasemonitorsbasemonitornameamazonrdssqlserverspost) | **POST** /api/basemonitors/{baseMonitorName}/amazonrdssqlservers |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversTestPost**](AmazonRdsSqlServersApi.md#apibasemonitorsbasemonitornameamazonrdssqlserverstestpost) | **POST** /api/basemonitors/{baseMonitorName}/amazonrdssqlservers/test |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversValidatePost**](AmazonRdsSqlServersApi.md#apibasemonitorsbasemonitornameamazonrdssqlserversvalidatepost) | **POST** /api/basemonitors/{baseMonitorName}/amazonrdssqlservers/validate |  |

<a id="apibasemonitorsbasemonitornameamazonrdssqlserversamazonrdssqlservernamedelete"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameDelete**
> void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameDelete (string amazonRdsSqlServerName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsSqlServersApi(config);
            var amazonRdsSqlServerName = "amazonRdsSqlServerName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameDelete(amazonRdsSqlServerName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameDeleteWithHttpInfo(amazonRdsSqlServerName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonRdsSqlServerName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameamazonrdssqlserversamazonrdssqlservernameget"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameGet**
> void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameGet (string amazonRdsSqlServerName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsSqlServersApi(config);
            var amazonRdsSqlServerName = "amazonRdsSqlServerName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameGet(amazonRdsSqlServerName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameGetWithHttpInfo(amazonRdsSqlServerName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversAmazonRdsSqlServerNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonRdsSqlServerName** | **string** |  |  |
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
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameamazonrdssqlserverscredentialsamazonapidelete"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsAmazonapiDelete**
> void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsAmazonapiDelete (string baseMonitorName, DeleteAmazonApiCredentialsRequest? deleteAmazonApiCredentialsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsAmazonapiDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsSqlServersApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var deleteAmazonApiCredentialsRequest = new DeleteAmazonApiCredentialsRequest?(); // DeleteAmazonApiCredentialsRequest? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsAmazonapiDelete(baseMonitorName, deleteAmazonApiCredentialsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsAmazonapiDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsAmazonapiDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsAmazonapiDeleteWithHttpInfo(baseMonitorName, deleteAmazonApiCredentialsRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsAmazonapiDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **deleteAmazonApiCredentialsRequest** | [**DeleteAmazonApiCredentialsRequest?**](DeleteAmazonApiCredentialsRequest?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameamazonrdssqlserverscredentialspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsPatch**
> JSendSuccess ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsPatch (string baseMonitorName, UpdateAmazonRdsSqlServerRequest? updateAmazonRdsSqlServerRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsSqlServersApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var updateAmazonRdsSqlServerRequest = new UpdateAmazonRdsSqlServerRequest?(); // UpdateAmazonRdsSqlServerRequest? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsPatch(baseMonitorName, updateAmazonRdsSqlServerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsPatchWithHttpInfo(baseMonitorName, updateAmazonRdsSqlServerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversCredentialsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **updateAmazonRdsSqlServerRequest** | [**UpdateAmazonRdsSqlServerRequest?**](UpdateAmazonRdsSqlServerRequest?.md) |  | [optional]  |

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
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameamazonrdssqlserversget"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversGet**
> void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsSqlServersApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversGetWithHttpInfo: " + e.Message);
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
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameamazonrdssqlserversinstancenameput"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversInstanceNamePut**
> void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversInstanceNamePut (string instanceName, string baseMonitorName, AmazonRdsSqlServerDto? amazonRdsSqlServerDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversInstanceNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsSqlServersApi(config);
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var amazonRdsSqlServerDto = new AmazonRdsSqlServerDto?(); // AmazonRdsSqlServerDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversInstanceNamePut(instanceName, baseMonitorName, amazonRdsSqlServerDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversInstanceNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversInstanceNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversInstanceNamePutWithHttpInfo(instanceName, baseMonitorName, amazonRdsSqlServerDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversInstanceNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **amazonRdsSqlServerDto** | [**AmazonRdsSqlServerDto?**](AmazonRdsSqlServerDto?.md) |  | [optional]  |

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
| **204** | No Content |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameamazonrdssqlserverspost"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversPost**
> AmazonRdsSqlServerDtoJSendSuccess ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversPost (string baseMonitorName, AddAmazonRdsSqlServerCommandDto? addAmazonRdsSqlServerCommandDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsSqlServersApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var addAmazonRdsSqlServerCommandDto = new AddAmazonRdsSqlServerCommandDto?(); // AddAmazonRdsSqlServerCommandDto? |  (optional) 

            try
            {
                AmazonRdsSqlServerDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversPost(baseMonitorName, addAmazonRdsSqlServerCommandDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AmazonRdsSqlServerDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversPostWithHttpInfo(baseMonitorName, addAmazonRdsSqlServerCommandDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **addAmazonRdsSqlServerCommandDto** | [**AddAmazonRdsSqlServerCommandDto?**](AddAmazonRdsSqlServerCommandDto?.md) |  | [optional]  |

### Return type

[**AmazonRdsSqlServerDtoJSendSuccess**](AmazonRdsSqlServerDtoJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | Unprocessable Content |  -  |
| **409** | Conflict |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameamazonrdssqlserverstestpost"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversTestPost**
> void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversTestPost (string baseMonitorName, AddAmazonRdsSqlServerCommandDto? addAmazonRdsSqlServerCommandDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversTestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsSqlServersApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var addAmazonRdsSqlServerCommandDto = new AddAmazonRdsSqlServerCommandDto?(); // AddAmazonRdsSqlServerCommandDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversTestPost(baseMonitorName, addAmazonRdsSqlServerCommandDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversTestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversTestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversTestPostWithHttpInfo(baseMonitorName, addAmazonRdsSqlServerCommandDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversTestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **addAmazonRdsSqlServerCommandDto** | [**AddAmazonRdsSqlServerCommandDto?**](AddAmazonRdsSqlServerCommandDto?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameamazonrdssqlserversvalidatepost"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversValidatePost**
> void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversValidatePost (string baseMonitorName, AddAmazonRdsSqlServerCommandDto? addAmazonRdsSqlServerCommandDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversValidatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsSqlServersApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var addAmazonRdsSqlServerCommandDto = new AddAmazonRdsSqlServerCommandDto?(); // AddAmazonRdsSqlServerCommandDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversValidatePost(baseMonitorName, addAmazonRdsSqlServerCommandDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversValidatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversValidatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversValidatePostWithHttpInfo(baseMonitorName, addAmazonRdsSqlServerCommandDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsSqlServersApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversValidatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **addAmazonRdsSqlServerCommandDto** | [**AddAmazonRdsSqlServerCommandDto?**](AddAmazonRdsSqlServerCommandDto?.md) |  | [optional]  |

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

