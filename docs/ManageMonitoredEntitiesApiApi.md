# cli.Api.ManageMonitoredEntitiesApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameMonitoredserversEditcredentialsPost**](ManageMonitoredEntitiesApiApi.md#apibasemonitorsbasemonitornamemonitoredserverseditcredentialspost) | **POST** /api/basemonitors/{baseMonitorName}/monitoredservers/editcredentials |  |
| [**ApiBasemonitorsBaseMonitorNameMonitoredserversGet**](ManageMonitoredEntitiesApiApi.md#apibasemonitorsbasemonitornamemonitoredserversget) | **GET** /api/basemonitors/{baseMonitorName}/monitoredservers |  |
| [**ApiBasemonitorsBaseMonitorNameMonitoredserversRemovePost**](ManageMonitoredEntitiesApiApi.md#apibasemonitorsbasemonitornamemonitoredserversremovepost) | **POST** /api/basemonitors/{baseMonitorName}/monitoredservers/remove |  |
| [**ApiBasemonitorsBaseMonitorNameMonitoredserversRemoveinstancePost**](ManageMonitoredEntitiesApiApi.md#apibasemonitorsbasemonitornamemonitoredserversremoveinstancepost) | **POST** /api/basemonitors/{baseMonitorName}/monitoredservers/removeinstance |  |
| [**ApiBasemonitorsBaseMonitorNameMonitoredserversRetryPost**](ManageMonitoredEntitiesApiApi.md#apibasemonitorsbasemonitornamemonitoredserversretrypost) | **POST** /api/basemonitors/{baseMonitorName}/monitoredservers/retry |  |
| [**ApiBasemonitorsBaseMonitorNameMonitoredserversSqlserversPost**](ManageMonitoredEntitiesApiApi.md#apibasemonitorsbasemonitornamemonitoredserverssqlserverspost) | **POST** /api/basemonitors/{baseMonitorName}/monitoredservers/sqlservers |  |
| [**ApiBasemonitorsBaseMonitorNameMonitoredserversSuspendPost**](ManageMonitoredEntitiesApiApi.md#apibasemonitorsbasemonitornamemonitoredserverssuspendpost) | **POST** /api/basemonitors/{baseMonitorName}/monitoredservers/suspend |  |

<a id="apibasemonitorsbasemonitornamemonitoredserverseditcredentialspost"></a>
# **ApiBasemonitorsBaseMonitorNameMonitoredserversEditcredentialsPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameMonitoredserversEditcredentialsPost (string baseMonitorName, SentEditCredentialsRequest? sentEditCredentialsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMonitoredserversEditcredentialsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageMonitoredEntitiesApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var sentEditCredentialsRequest = new SentEditCredentialsRequest?(); // SentEditCredentialsRequest? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversEditcredentialsPost(baseMonitorName, sentEditCredentialsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversEditcredentialsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMonitoredserversEditcredentialsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversEditcredentialsPostWithHttpInfo(baseMonitorName, sentEditCredentialsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversEditcredentialsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **sentEditCredentialsRequest** | [**SentEditCredentialsRequest?**](SentEditCredentialsRequest?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornamemonitoredserversget"></a>
# **ApiBasemonitorsBaseMonitorNameMonitoredserversGet**
> ManageEntityViewModelArrayJSendSuccess ApiBasemonitorsBaseMonitorNameMonitoredserversGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMonitoredserversGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageMonitoredEntitiesApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                ManageEntityViewModelArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMonitoredserversGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ManageEntityViewModelArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**ManageEntityViewModelArrayJSendSuccess**](ManageEntityViewModelArrayJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamemonitoredserversremovepost"></a>
# **ApiBasemonitorsBaseMonitorNameMonitoredserversRemovePost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameMonitoredserversRemovePost (string baseMonitorName, RemoveEntityRequest? removeEntityRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMonitoredserversRemovePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageMonitoredEntitiesApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var removeEntityRequest = new RemoveEntityRequest?(); // RemoveEntityRequest? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversRemovePost(baseMonitorName, removeEntityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversRemovePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMonitoredserversRemovePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversRemovePostWithHttpInfo(baseMonitorName, removeEntityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversRemovePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **removeEntityRequest** | [**RemoveEntityRequest?**](RemoveEntityRequest?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornamemonitoredserversremoveinstancepost"></a>
# **ApiBasemonitorsBaseMonitorNameMonitoredserversRemoveinstancePost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameMonitoredserversRemoveinstancePost (string baseMonitorName, RemoveUninstalledInstanceRequest? removeUninstalledInstanceRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMonitoredserversRemoveinstancePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageMonitoredEntitiesApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var removeUninstalledInstanceRequest = new RemoveUninstalledInstanceRequest?(); // RemoveUninstalledInstanceRequest? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversRemoveinstancePost(baseMonitorName, removeUninstalledInstanceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversRemoveinstancePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMonitoredserversRemoveinstancePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversRemoveinstancePostWithHttpInfo(baseMonitorName, removeUninstalledInstanceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversRemoveinstancePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **removeUninstalledInstanceRequest** | [**RemoveUninstalledInstanceRequest?**](RemoveUninstalledInstanceRequest?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornamemonitoredserversretrypost"></a>
# **ApiBasemonitorsBaseMonitorNameMonitoredserversRetryPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameMonitoredserversRetryPost (string baseMonitorName, RetryEntityRequest? retryEntityRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMonitoredserversRetryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageMonitoredEntitiesApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var retryEntityRequest = new RetryEntityRequest?(); // RetryEntityRequest? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversRetryPost(baseMonitorName, retryEntityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversRetryPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMonitoredserversRetryPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversRetryPostWithHttpInfo(baseMonitorName, retryEntityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversRetryPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **retryEntityRequest** | [**RetryEntityRequest?**](RetryEntityRequest?.md) |  | [optional]  |

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
| **422** | Unprocessable Content |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamemonitoredserverssqlserverspost"></a>
# **ApiBasemonitorsBaseMonitorNameMonitoredserversSqlserversPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameMonitoredserversSqlserversPost (string baseMonitorName, AddSqlServerRequest? addSqlServerRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMonitoredserversSqlserversPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageMonitoredEntitiesApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var addSqlServerRequest = new AddSqlServerRequest?(); // AddSqlServerRequest? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversSqlserversPost(baseMonitorName, addSqlServerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversSqlserversPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMonitoredserversSqlserversPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversSqlserversPostWithHttpInfo(baseMonitorName, addSqlServerRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversSqlserversPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **addSqlServerRequest** | [**AddSqlServerRequest?**](AddSqlServerRequest?.md) |  | [optional]  |

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
| **400** | Bad Request |  -  |
| **409** | Conflict |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamemonitoredserverssuspendpost"></a>
# **ApiBasemonitorsBaseMonitorNameMonitoredserversSuspendPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameMonitoredserversSuspendPost (string baseMonitorName, SuspendEntityRequest? suspendEntityRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMonitoredserversSuspendPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageMonitoredEntitiesApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var suspendEntityRequest = new SuspendEntityRequest?(); // SuspendEntityRequest? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversSuspendPost(baseMonitorName, suspendEntityRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversSuspendPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMonitoredserversSuspendPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredserversSuspendPostWithHttpInfo(baseMonitorName, suspendEntityRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageMonitoredEntitiesApiApi.ApiBasemonitorsBaseMonitorNameMonitoredserversSuspendPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **suspendEntityRequest** | [**SuspendEntityRequest?**](SuspendEntityRequest?.md) |  | [optional]  |

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

