# cli.Api.DiagnosticsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameDiagnosticsTasksGet**](DiagnosticsApiApi.md#apibasemonitorsbasemonitornamediagnosticstasksget) | **GET** /api/basemonitors/{baseMonitorName}/diagnostics/tasks |  |
| [**ApiBasemonitorsBaseMonitorNameDiagnosticsThreadPoolGet**](DiagnosticsApiApi.md#apibasemonitorsbasemonitornamediagnosticsthreadpoolget) | **GET** /api/basemonitors/{baseMonitorName}/diagnostics/threadPool |  |
| [**ApiDiagnosticsThreadPoolGet**](DiagnosticsApiApi.md#apidiagnosticsthreadpoolget) | **GET** /api/diagnostics/threadPool |  |
| [**ApiDiagnosticsUserGet**](DiagnosticsApiApi.md#apidiagnosticsuserget) | **GET** /api/diagnostics/user |  |

<a id="apibasemonitorsbasemonitornamediagnosticstasksget"></a>
# **ApiBasemonitorsBaseMonitorNameDiagnosticsTasksGet**
> TaskQueueStatsJSendSuccess ApiBasemonitorsBaseMonitorNameDiagnosticsTasksGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameDiagnosticsTasksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DiagnosticsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                TaskQueueStatsJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameDiagnosticsTasksGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagnosticsApiApi.ApiBasemonitorsBaseMonitorNameDiagnosticsTasksGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameDiagnosticsTasksGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TaskQueueStatsJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameDiagnosticsTasksGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagnosticsApiApi.ApiBasemonitorsBaseMonitorNameDiagnosticsTasksGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**TaskQueueStatsJSendSuccess**](TaskQueueStatsJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamediagnosticsthreadpoolget"></a>
# **ApiBasemonitorsBaseMonitorNameDiagnosticsThreadPoolGet**
> void ApiBasemonitorsBaseMonitorNameDiagnosticsThreadPoolGet (string baseMonitorName, int? minThreads = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameDiagnosticsThreadPoolGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DiagnosticsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var minThreads = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameDiagnosticsThreadPoolGet(baseMonitorName, minThreads);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagnosticsApiApi.ApiBasemonitorsBaseMonitorNameDiagnosticsThreadPoolGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameDiagnosticsThreadPoolGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameDiagnosticsThreadPoolGetWithHttpInfo(baseMonitorName, minThreads);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagnosticsApiApi.ApiBasemonitorsBaseMonitorNameDiagnosticsThreadPoolGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **minThreads** | **int?** |  | [optional]  |

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

<a id="apidiagnosticsthreadpoolget"></a>
# **ApiDiagnosticsThreadPoolGet**
> void ApiDiagnosticsThreadPoolGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsThreadPoolGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DiagnosticsApiApi(config);

            try
            {
                apiInstance.ApiDiagnosticsThreadPoolGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagnosticsApiApi.ApiDiagnosticsThreadPoolGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsThreadPoolGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiDiagnosticsThreadPoolGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagnosticsApiApi.ApiDiagnosticsThreadPoolGetWithHttpInfo: " + e.Message);
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
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apidiagnosticsuserget"></a>
# **ApiDiagnosticsUserGet**
> AuthenticatedUserDtoJSendSuccess ApiDiagnosticsUserGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsUserGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DiagnosticsApiApi(config);

            try
            {
                AuthenticatedUserDtoJSendSuccess result = apiInstance.ApiDiagnosticsUserGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiagnosticsApiApi.ApiDiagnosticsUserGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsUserGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AuthenticatedUserDtoJSendSuccess> response = apiInstance.ApiDiagnosticsUserGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiagnosticsApiApi.ApiDiagnosticsUserGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AuthenticatedUserDtoJSendSuccess**](AuthenticatedUserDtoJSendSuccess.md)

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

