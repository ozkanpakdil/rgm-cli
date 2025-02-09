# cli.Api.AuthenticationPrincipalApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsGet**](AuthenticationPrincipalApiApi.md#apibasemonitorsbasemonitornameauthenticationprincipalsget) | **GET** /api/basemonitors/{baseMonitorName}/authentication/principals |  |
| [**ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPost**](AuthenticationPrincipalApiApi.md#apibasemonitorsbasemonitornameauthenticationprincipalspost) | **POST** /api/basemonitors/{baseMonitorName}/authentication/principals |  |
| [**ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameDelete**](AuthenticationPrincipalApiApi.md#apibasemonitorsbasemonitornameauthenticationprincipalsprincipalnamedelete) | **DELETE** /api/basemonitors/{baseMonitorName}/authentication/principals/{principalName} |  |
| [**ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameGet**](AuthenticationPrincipalApiApi.md#apibasemonitorsbasemonitornameauthenticationprincipalsprincipalnameget) | **GET** /api/basemonitors/{baseMonitorName}/authentication/principals/{principalName} |  |
| [**ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPut**](AuthenticationPrincipalApiApi.md#apibasemonitorsbasemonitornameauthenticationprincipalsput) | **PUT** /api/basemonitors/{baseMonitorName}/authentication/principals |  |

<a id="apibasemonitorsbasemonitornameauthenticationprincipalsget"></a>
# **ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsGet**
> AuthPrincipalDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthenticationPrincipalApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AuthPrincipalDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AuthPrincipalDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**AuthPrincipalDtoIEnumerableJSendSuccess**](AuthPrincipalDtoIEnumerableJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameauthenticationprincipalspost"></a>
# **ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPost**
> AuthPrincipalDtoJSendSuccess ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPost (string baseMonitorName, AuthPrincipalDto? authPrincipalDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthenticationPrincipalApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var authPrincipalDto = new AuthPrincipalDto?(); // AuthPrincipalDto? |  (optional) 

            try
            {
                AuthPrincipalDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPost(baseMonitorName, authPrincipalDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AuthPrincipalDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPostWithHttpInfo(baseMonitorName, authPrincipalDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **authPrincipalDto** | [**AuthPrincipalDto?**](AuthPrincipalDto?.md) |  | [optional]  |

### Return type

[**AuthPrincipalDtoJSendSuccess**](AuthPrincipalDtoJSendSuccess.md)

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
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameauthenticationprincipalsprincipalnamedelete"></a>
# **ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameDelete**
> JSendSuccess ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameDelete (string principalName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthenticationPrincipalApiApi(config);
            var principalName = "principalName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameDelete(principalName, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameDeleteWithHttpInfo(principalName, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **principalName** | **string** |  |  |
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
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameauthenticationprincipalsprincipalnameget"></a>
# **ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameGet**
> AuthPrincipalDtoJSendSuccess ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameGet (string principalName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthenticationPrincipalApiApi(config);
            var principalName = "principalName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AuthPrincipalDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameGet(principalName, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AuthPrincipalDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameGetWithHttpInfo(principalName, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **principalName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**AuthPrincipalDtoJSendSuccess**](AuthPrincipalDtoJSendSuccess.md)

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
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameauthenticationprincipalsput"></a>
# **ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPut**
> JSendSuccess ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPut (string baseMonitorName, AuthPrincipalDto? authPrincipalDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthenticationPrincipalApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var authPrincipalDto = new AuthPrincipalDto?(); // AuthPrincipalDto? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPut(baseMonitorName, authPrincipalDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPutWithHttpInfo(baseMonitorName, authPrincipalDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **authPrincipalDto** | [**AuthPrincipalDto?**](AuthPrincipalDto?.md) |  | [optional]  |

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
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

