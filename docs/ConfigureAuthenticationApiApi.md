# cli.Api.ConfigureAuthenticationApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiConfigurationAuthAdDomainDelete**](ConfigureAuthenticationApiApi.md#apiconfigurationauthaddomaindelete) | **DELETE** /api/configuration/auth/ad/domain |  |
| [**ApiConfigurationAuthAdDomainPost**](ConfigureAuthenticationApiApi.md#apiconfigurationauthaddomainpost) | **POST** /api/configuration/auth/ad/domain |  |
| [**ApiConfigurationAuthAdDomainTestPost**](ConfigureAuthenticationApiApi.md#apiconfigurationauthaddomaintestpost) | **POST** /api/configuration/auth/ad/domain/test |  |
| [**ApiConfigurationAuthAdGet**](ConfigureAuthenticationApiApi.md#apiconfigurationauthadget) | **GET** /api/configuration/auth/ad |  |
| [**ApiConfigurationAuthAdPut**](ConfigureAuthenticationApiApi.md#apiconfigurationauthadput) | **PUT** /api/configuration/auth/ad |  |
| [**ApiConfigurationAuthOidcGet**](ConfigureAuthenticationApiApi.md#apiconfigurationauthoidcget) | **GET** /api/configuration/auth/oidc |  |
| [**ApiConfigurationAuthOidcPut**](ConfigureAuthenticationApiApi.md#apiconfigurationauthoidcput) | **PUT** /api/configuration/auth/oidc |  |
| [**ApiConfigurationAuthPost**](ConfigureAuthenticationApiApi.md#apiconfigurationauthpost) | **POST** /api/configuration/auth |  |

<a id="apiconfigurationauthaddomaindelete"></a>
# **ApiConfigurationAuthAdDomainDelete**
> JSendSuccess ApiConfigurationAuthAdDomainDelete (DeleteDomainConnectionRequest? deleteDomainConnectionRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiConfigurationAuthAdDomainDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureAuthenticationApiApi(config);
            var deleteDomainConnectionRequest = new DeleteDomainConnectionRequest?(); // DeleteDomainConnectionRequest? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiConfigurationAuthAdDomainDelete(deleteDomainConnectionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthAdDomainDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiConfigurationAuthAdDomainDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiConfigurationAuthAdDomainDeleteWithHttpInfo(deleteDomainConnectionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthAdDomainDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deleteDomainConnectionRequest** | [**DeleteDomainConnectionRequest?**](DeleteDomainConnectionRequest?.md) |  | [optional]  |

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

<a id="apiconfigurationauthaddomainpost"></a>
# **ApiConfigurationAuthAdDomainPost**
> JSendSuccess ApiConfigurationAuthAdDomainPost (ActiveDirectoryDomainViewModel? activeDirectoryDomainViewModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiConfigurationAuthAdDomainPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureAuthenticationApiApi(config);
            var activeDirectoryDomainViewModel = new ActiveDirectoryDomainViewModel?(); // ActiveDirectoryDomainViewModel? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiConfigurationAuthAdDomainPost(activeDirectoryDomainViewModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthAdDomainPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiConfigurationAuthAdDomainPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiConfigurationAuthAdDomainPostWithHttpInfo(activeDirectoryDomainViewModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthAdDomainPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activeDirectoryDomainViewModel** | [**ActiveDirectoryDomainViewModel?**](ActiveDirectoryDomainViewModel?.md) |  | [optional]  |

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

<a id="apiconfigurationauthaddomaintestpost"></a>
# **ApiConfigurationAuthAdDomainTestPost**
> JSendSuccess ApiConfigurationAuthAdDomainTestPost (ActiveDirectoryDomainViewModel? activeDirectoryDomainViewModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiConfigurationAuthAdDomainTestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureAuthenticationApiApi(config);
            var activeDirectoryDomainViewModel = new ActiveDirectoryDomainViewModel?(); // ActiveDirectoryDomainViewModel? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiConfigurationAuthAdDomainTestPost(activeDirectoryDomainViewModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthAdDomainTestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiConfigurationAuthAdDomainTestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiConfigurationAuthAdDomainTestPostWithHttpInfo(activeDirectoryDomainViewModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthAdDomainTestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **activeDirectoryDomainViewModel** | [**ActiveDirectoryDomainViewModel?**](ActiveDirectoryDomainViewModel?.md) |  | [optional]  |

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

<a id="apiconfigurationauthadget"></a>
# **ApiConfigurationAuthAdGet**
> AuthenticationViewModelJSendSuccess ApiConfigurationAuthAdGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiConfigurationAuthAdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureAuthenticationApiApi(config);

            try
            {
                AuthenticationViewModelJSendSuccess result = apiInstance.ApiConfigurationAuthAdGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthAdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiConfigurationAuthAdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AuthenticationViewModelJSendSuccess> response = apiInstance.ApiConfigurationAuthAdGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthAdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AuthenticationViewModelJSendSuccess**](AuthenticationViewModelJSendSuccess.md)

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

<a id="apiconfigurationauthadput"></a>
# **ApiConfigurationAuthAdPut**
> JSendSuccess ApiConfigurationAuthAdPut (SwitchToActiveDirectoryNewSettingsRequest? switchToActiveDirectoryNewSettingsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiConfigurationAuthAdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureAuthenticationApiApi(config);
            var switchToActiveDirectoryNewSettingsRequest = new SwitchToActiveDirectoryNewSettingsRequest?(); // SwitchToActiveDirectoryNewSettingsRequest? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiConfigurationAuthAdPut(switchToActiveDirectoryNewSettingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthAdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiConfigurationAuthAdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiConfigurationAuthAdPutWithHttpInfo(switchToActiveDirectoryNewSettingsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthAdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **switchToActiveDirectoryNewSettingsRequest** | [**SwitchToActiveDirectoryNewSettingsRequest?**](SwitchToActiveDirectoryNewSettingsRequest?.md) |  | [optional]  |

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

<a id="apiconfigurationauthoidcget"></a>
# **ApiConfigurationAuthOidcGet**
> OpenIdConnectSettingsDtoJSendSuccess ApiConfigurationAuthOidcGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiConfigurationAuthOidcGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureAuthenticationApiApi(config);

            try
            {
                OpenIdConnectSettingsDtoJSendSuccess result = apiInstance.ApiConfigurationAuthOidcGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthOidcGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiConfigurationAuthOidcGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OpenIdConnectSettingsDtoJSendSuccess> response = apiInstance.ApiConfigurationAuthOidcGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthOidcGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OpenIdConnectSettingsDtoJSendSuccess**](OpenIdConnectSettingsDtoJSendSuccess.md)

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

<a id="apiconfigurationauthoidcput"></a>
# **ApiConfigurationAuthOidcPut**
> JSendSuccess ApiConfigurationAuthOidcPut (OpenIdConnectSettingsDto? openIdConnectSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiConfigurationAuthOidcPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureAuthenticationApiApi(config);
            var openIdConnectSettingsDto = new OpenIdConnectSettingsDto?(); // OpenIdConnectSettingsDto? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiConfigurationAuthOidcPut(openIdConnectSettingsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthOidcPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiConfigurationAuthOidcPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiConfigurationAuthOidcPutWithHttpInfo(openIdConnectSettingsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthOidcPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **openIdConnectSettingsDto** | [**OpenIdConnectSettingsDto?**](OpenIdConnectSettingsDto?.md) |  | [optional]  |

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

<a id="apiconfigurationauthpost"></a>
# **ApiConfigurationAuthPost**
> JSendSuccess ApiConfigurationAuthPost (SwitchAuthenticationTypeDto? switchAuthenticationTypeDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiConfigurationAuthPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureAuthenticationApiApi(config);
            var switchAuthenticationTypeDto = new SwitchAuthenticationTypeDto?(); // SwitchAuthenticationTypeDto? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiConfigurationAuthPost(switchAuthenticationTypeDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiConfigurationAuthPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiConfigurationAuthPostWithHttpInfo(switchAuthenticationTypeDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureAuthenticationApiApi.ApiConfigurationAuthPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **switchAuthenticationTypeDto** | [**SwitchAuthenticationTypeDto?**](SwitchAuthenticationTypeDto?.md) |  | [optional]  |

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

