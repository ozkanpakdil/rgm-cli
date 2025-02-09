# cli.Api.RpcDiagnosticsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiDiagnosticsRpcDisableGet**](RpcDiagnosticsApi.md#apidiagnosticsrpcdisableget) | **GET** /api/diagnostics/rpc/disable |  |
| [**ApiDiagnosticsRpcDisableRequestGet**](RpcDiagnosticsApi.md#apidiagnosticsrpcdisablerequestget) | **GET** /api/diagnostics/rpc/disableRequest |  |
| [**ApiDiagnosticsRpcEnableGet**](RpcDiagnosticsApi.md#apidiagnosticsrpcenableget) | **GET** /api/diagnostics/rpc/enable |  |
| [**ApiDiagnosticsRpcEnableRequestGet**](RpcDiagnosticsApi.md#apidiagnosticsrpcenablerequestget) | **GET** /api/diagnostics/rpc/enableRequest |  |
| [**ApiDiagnosticsRpcGet**](RpcDiagnosticsApi.md#apidiagnosticsrpcget) | **GET** /api/diagnostics/rpc |  |
| [**ApiDiagnosticsRpcResetGet**](RpcDiagnosticsApi.md#apidiagnosticsrpcresetget) | **GET** /api/diagnostics/rpc/reset |  |
| [**ApiDiagnosticsRpcStatusGet**](RpcDiagnosticsApi.md#apidiagnosticsrpcstatusget) | **GET** /api/diagnostics/rpc/status |  |
| [**ApiDiagnosticsRpcStatusRequestGet**](RpcDiagnosticsApi.md#apidiagnosticsrpcstatusrequestget) | **GET** /api/diagnostics/rpc/statusRequest |  |

<a id="apidiagnosticsrpcdisableget"></a>
# **ApiDiagnosticsRpcDisableGet**
> UnitJSendSuccess ApiDiagnosticsRpcDisableGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsRpcDisableGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RpcDiagnosticsApi(config);

            try
            {
                UnitJSendSuccess result = apiInstance.ApiDiagnosticsRpcDisableGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcDisableGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsRpcDisableGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UnitJSendSuccess> response = apiInstance.ApiDiagnosticsRpcDisableGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcDisableGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UnitJSendSuccess**](UnitJSendSuccess.md)

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

<a id="apidiagnosticsrpcdisablerequestget"></a>
# **ApiDiagnosticsRpcDisableRequestGet**
> UnitJSendSuccess ApiDiagnosticsRpcDisableRequestGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsRpcDisableRequestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RpcDiagnosticsApi(config);

            try
            {
                UnitJSendSuccess result = apiInstance.ApiDiagnosticsRpcDisableRequestGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcDisableRequestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsRpcDisableRequestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UnitJSendSuccess> response = apiInstance.ApiDiagnosticsRpcDisableRequestGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcDisableRequestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UnitJSendSuccess**](UnitJSendSuccess.md)

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

<a id="apidiagnosticsrpcenableget"></a>
# **ApiDiagnosticsRpcEnableGet**
> UnitJSendSuccess ApiDiagnosticsRpcEnableGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsRpcEnableGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RpcDiagnosticsApi(config);

            try
            {
                UnitJSendSuccess result = apiInstance.ApiDiagnosticsRpcEnableGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcEnableGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsRpcEnableGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UnitJSendSuccess> response = apiInstance.ApiDiagnosticsRpcEnableGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcEnableGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UnitJSendSuccess**](UnitJSendSuccess.md)

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

<a id="apidiagnosticsrpcenablerequestget"></a>
# **ApiDiagnosticsRpcEnableRequestGet**
> UnitJSendSuccess ApiDiagnosticsRpcEnableRequestGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsRpcEnableRequestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RpcDiagnosticsApi(config);

            try
            {
                UnitJSendSuccess result = apiInstance.ApiDiagnosticsRpcEnableRequestGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcEnableRequestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsRpcEnableRequestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UnitJSendSuccess> response = apiInstance.ApiDiagnosticsRpcEnableRequestGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcEnableRequestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UnitJSendSuccess**](UnitJSendSuccess.md)

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

<a id="apidiagnosticsrpcget"></a>
# **ApiDiagnosticsRpcGet**
> void ApiDiagnosticsRpcGet (string? format = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsRpcGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RpcDiagnosticsApi(config);
            var format = "\"json\"";  // string? |  (optional)  (default to "json")

            try
            {
                apiInstance.ApiDiagnosticsRpcGet(format);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsRpcGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiDiagnosticsRpcGetWithHttpInfo(format);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **format** | **string?** |  | [optional] [default to &quot;json&quot;] |

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

<a id="apidiagnosticsrpcresetget"></a>
# **ApiDiagnosticsRpcResetGet**
> UnitJSendSuccess ApiDiagnosticsRpcResetGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsRpcResetGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RpcDiagnosticsApi(config);

            try
            {
                UnitJSendSuccess result = apiInstance.ApiDiagnosticsRpcResetGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcResetGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsRpcResetGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UnitJSendSuccess> response = apiInstance.ApiDiagnosticsRpcResetGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcResetGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UnitJSendSuccess**](UnitJSendSuccess.md)

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

<a id="apidiagnosticsrpcstatusget"></a>
# **ApiDiagnosticsRpcStatusGet**
> RpcStatusDtoJSendSuccess ApiDiagnosticsRpcStatusGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsRpcStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RpcDiagnosticsApi(config);

            try
            {
                RpcStatusDtoJSendSuccess result = apiInstance.ApiDiagnosticsRpcStatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsRpcStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RpcStatusDtoJSendSuccess> response = apiInstance.ApiDiagnosticsRpcStatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RpcStatusDtoJSendSuccess**](RpcStatusDtoJSendSuccess.md)

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

<a id="apidiagnosticsrpcstatusrequestget"></a>
# **ApiDiagnosticsRpcStatusRequestGet**
> RpcStatusDtoJSendSuccess ApiDiagnosticsRpcStatusRequestGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsRpcStatusRequestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new RpcDiagnosticsApi(config);

            try
            {
                RpcStatusDtoJSendSuccess result = apiInstance.ApiDiagnosticsRpcStatusRequestGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcStatusRequestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsRpcStatusRequestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RpcStatusDtoJSendSuccess> response = apiInstance.ApiDiagnosticsRpcStatusRequestGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RpcDiagnosticsApi.ApiDiagnosticsRpcStatusRequestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RpcStatusDtoJSendSuccess**](RpcStatusDtoJSendSuccess.md)

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

