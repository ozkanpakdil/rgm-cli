# cli.Api.ErrorReportingApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiDiagnosticsErrorReportingDisablePost**](ErrorReportingApi.md#apidiagnosticserrorreportingdisablepost) | **POST** /api/diagnostics/errorReporting/disable |  |
| [**ApiDiagnosticsErrorReportingEnablePost**](ErrorReportingApi.md#apidiagnosticserrorreportingenablepost) | **POST** /api/diagnostics/errorReporting/enable |  |
| [**ApiDiagnosticsErrorReportingStatusGet**](ErrorReportingApi.md#apidiagnosticserrorreportingstatusget) | **GET** /api/diagnostics/errorReporting/status |  |
| [**ApiDiagnosticsErrorReportingTestGet**](ErrorReportingApi.md#apidiagnosticserrorreportingtestget) | **GET** /api/diagnostics/errorReporting/test |  |
| [**ApiDiagnosticsErrorReportingTestJsenderrorGet**](ErrorReportingApi.md#apidiagnosticserrorreportingtestjsenderrorget) | **GET** /api/diagnostics/errorReporting/test/jsenderror |  |

<a id="apidiagnosticserrorreportingdisablepost"></a>
# **ApiDiagnosticsErrorReportingDisablePost**
> void ApiDiagnosticsErrorReportingDisablePost ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsErrorReportingDisablePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ErrorReportingApi(config);

            try
            {
                apiInstance.ApiDiagnosticsErrorReportingDisablePost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ErrorReportingApi.ApiDiagnosticsErrorReportingDisablePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsErrorReportingDisablePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiDiagnosticsErrorReportingDisablePostWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ErrorReportingApi.ApiDiagnosticsErrorReportingDisablePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidiagnosticserrorreportingenablepost"></a>
# **ApiDiagnosticsErrorReportingEnablePost**
> void ApiDiagnosticsErrorReportingEnablePost ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsErrorReportingEnablePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ErrorReportingApi(config);

            try
            {
                apiInstance.ApiDiagnosticsErrorReportingEnablePost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ErrorReportingApi.ApiDiagnosticsErrorReportingEnablePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsErrorReportingEnablePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiDiagnosticsErrorReportingEnablePostWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ErrorReportingApi.ApiDiagnosticsErrorReportingEnablePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidiagnosticserrorreportingstatusget"></a>
# **ApiDiagnosticsErrorReportingStatusGet**
> ErrorReportingStatusDtoJSendSuccess ApiDiagnosticsErrorReportingStatusGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsErrorReportingStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ErrorReportingApi(config);

            try
            {
                ErrorReportingStatusDtoJSendSuccess result = apiInstance.ApiDiagnosticsErrorReportingStatusGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ErrorReportingApi.ApiDiagnosticsErrorReportingStatusGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsErrorReportingStatusGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ErrorReportingStatusDtoJSendSuccess> response = apiInstance.ApiDiagnosticsErrorReportingStatusGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ErrorReportingApi.ApiDiagnosticsErrorReportingStatusGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ErrorReportingStatusDtoJSendSuccess**](ErrorReportingStatusDtoJSendSuccess.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidiagnosticserrorreportingtestget"></a>
# **ApiDiagnosticsErrorReportingTestGet**
> void ApiDiagnosticsErrorReportingTestGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsErrorReportingTestGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ErrorReportingApi(config);

            try
            {
                apiInstance.ApiDiagnosticsErrorReportingTestGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ErrorReportingApi.ApiDiagnosticsErrorReportingTestGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsErrorReportingTestGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiDiagnosticsErrorReportingTestGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ErrorReportingApi.ApiDiagnosticsErrorReportingTestGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidiagnosticserrorreportingtestjsenderrorget"></a>
# **ApiDiagnosticsErrorReportingTestJsenderrorGet**
> void ApiDiagnosticsErrorReportingTestJsenderrorGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsErrorReportingTestJsenderrorGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ErrorReportingApi(config);

            try
            {
                apiInstance.ApiDiagnosticsErrorReportingTestJsenderrorGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ErrorReportingApi.ApiDiagnosticsErrorReportingTestJsenderrorGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsErrorReportingTestJsenderrorGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiDiagnosticsErrorReportingTestJsenderrorGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ErrorReportingApi.ApiDiagnosticsErrorReportingTestJsenderrorGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

