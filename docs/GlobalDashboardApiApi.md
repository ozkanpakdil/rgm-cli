# cli.Api.GlobalDashboardApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameGlobaldashboardGet**](GlobalDashboardApiApi.md#apibasemonitorsbasemonitornameglobaldashboardget) | **GET** /api/basemonitors/{baseMonitorName}/globaldashboard |  |
| [**ApiGlobaldashboardAlertsGet**](GlobalDashboardApiApi.md#apiglobaldashboardalertsget) | **GET** /api/globaldashboard/alerts |  |
| [**ApiGlobaldashboardAlertsStagnantClearPost**](GlobalDashboardApiApi.md#apiglobaldashboardalertsstagnantclearpost) | **POST** /api/globaldashboard/alerts/stagnant/clear |  |
| [**ApiGlobaldashboardAlertsStagnantGet**](GlobalDashboardApiApi.md#apiglobaldashboardalertsstagnantget) | **GET** /api/globaldashboard/alerts/stagnant |  |
| [**ApiGlobaldashboardGet**](GlobalDashboardApiApi.md#apiglobaldashboardget) | **GET** /api/globaldashboard |  |

<a id="apibasemonitorsbasemonitornameglobaldashboardget"></a>
# **ApiBasemonitorsBaseMonitorNameGlobaldashboardGet**
> GlobalDashboardViewModelJSendSuccess ApiBasemonitorsBaseMonitorNameGlobaldashboardGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameGlobaldashboardGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GlobalDashboardApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                GlobalDashboardViewModelJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameGlobaldashboardGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalDashboardApiApi.ApiBasemonitorsBaseMonitorNameGlobaldashboardGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameGlobaldashboardGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GlobalDashboardViewModelJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameGlobaldashboardGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalDashboardApiApi.ApiBasemonitorsBaseMonitorNameGlobaldashboardGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**GlobalDashboardViewModelJSendSuccess**](GlobalDashboardViewModelJSendSuccess.md)

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

<a id="apiglobaldashboardalertsget"></a>
# **ApiGlobaldashboardAlertsGet**
> AlertSummaryViewModelJSendSuccess ApiGlobaldashboardAlertsGet (int? timeWindowMinutes = null, string? group = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiGlobaldashboardAlertsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GlobalDashboardApiApi(config);
            var timeWindowMinutes = 56;  // int? |  (optional) 
            var group = "group_example";  // string? |  (optional) 

            try
            {
                AlertSummaryViewModelJSendSuccess result = apiInstance.ApiGlobaldashboardAlertsGet(timeWindowMinutes, group);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalDashboardApiApi.ApiGlobaldashboardAlertsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiGlobaldashboardAlertsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertSummaryViewModelJSendSuccess> response = apiInstance.ApiGlobaldashboardAlertsGetWithHttpInfo(timeWindowMinutes, group);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalDashboardApiApi.ApiGlobaldashboardAlertsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **timeWindowMinutes** | **int?** |  | [optional]  |
| **group** | **string?** |  | [optional]  |

### Return type

[**AlertSummaryViewModelJSendSuccess**](AlertSummaryViewModelJSendSuccess.md)

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

<a id="apiglobaldashboardalertsstagnantclearpost"></a>
# **ApiGlobaldashboardAlertsStagnantClearPost**
> UnitJSendSuccess ApiGlobaldashboardAlertsStagnantClearPost ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiGlobaldashboardAlertsStagnantClearPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GlobalDashboardApiApi(config);

            try
            {
                UnitJSendSuccess result = apiInstance.ApiGlobaldashboardAlertsStagnantClearPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalDashboardApiApi.ApiGlobaldashboardAlertsStagnantClearPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiGlobaldashboardAlertsStagnantClearPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UnitJSendSuccess> response = apiInstance.ApiGlobaldashboardAlertsStagnantClearPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalDashboardApiApi.ApiGlobaldashboardAlertsStagnantClearPostWithHttpInfo: " + e.Message);
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

<a id="apiglobaldashboardalertsstagnantget"></a>
# **ApiGlobaldashboardAlertsStagnantGet**
> Int32JSendSuccess ApiGlobaldashboardAlertsStagnantGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiGlobaldashboardAlertsStagnantGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GlobalDashboardApiApi(config);

            try
            {
                Int32JSendSuccess result = apiInstance.ApiGlobaldashboardAlertsStagnantGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalDashboardApiApi.ApiGlobaldashboardAlertsStagnantGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiGlobaldashboardAlertsStagnantGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Int32JSendSuccess> response = apiInstance.ApiGlobaldashboardAlertsStagnantGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalDashboardApiApi.ApiGlobaldashboardAlertsStagnantGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Int32JSendSuccess**](Int32JSendSuccess.md)

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

<a id="apiglobaldashboardget"></a>
# **ApiGlobaldashboardGet**
> GlobalDashboardViewModelJSendSuccess ApiGlobaldashboardGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiGlobaldashboardGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GlobalDashboardApiApi(config);

            try
            {
                GlobalDashboardViewModelJSendSuccess result = apiInstance.ApiGlobaldashboardGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GlobalDashboardApiApi.ApiGlobaldashboardGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiGlobaldashboardGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GlobalDashboardViewModelJSendSuccess> response = apiInstance.ApiGlobaldashboardGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GlobalDashboardApiApi.ApiGlobaldashboardGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GlobalDashboardViewModelJSendSuccess**](GlobalDashboardViewModelJSendSuccess.md)

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

