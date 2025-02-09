# cli.Api.AzureElasticPoolAlertSettingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdCommentsPatch**](AzureElasticPoolAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolselasticpoolnamealertsettingsalerttypeidcommentspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/elasticpools/{elasticPoolName}/alertsettings/{alertTypeId}/comments |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdGet**](AzureElasticPoolAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolselasticpoolnamealertsettingsalerttypeidget) | **GET** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/elasticpools/{elasticPoolName}/alertsettings/{alertTypeId} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdNotificationsettingsPatch**](AzureElasticPoolAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolselasticpoolnamealertsettingsalerttypeidnotificationsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/elasticpools/{elasticPoolName}/alertsettings/{alertTypeId}/notificationsettings |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdSpecificsettingsPatch**](AzureElasticPoolAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolselasticpoolnamealertsettingsalerttypeidspecificsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/elasticpools/{elasticPoolName}/alertsettings/{alertTypeId}/specificsettings |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdStatusPatch**](AzureElasticPoolAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolselasticpoolnamealertsettingsalerttypeidstatuspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/elasticpools/{elasticPoolName}/alertsettings/{alertTypeId}/status |  |

<a id="apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolselasticpoolnamealertsettingsalerttypeidcommentspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdCommentsPatch**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdCommentsPatch (string serverName, string elasticPoolName, long alertTypeId, string baseMonitorName, string? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdCommentsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureElasticPoolAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var elasticPoolName = "elasticPoolName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = "body_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdCommentsPatch(serverName, elasticPoolName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureElasticPoolAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdCommentsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo(serverName, elasticPoolName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureElasticPoolAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **elasticPoolName** | **string** |  |  |
| **alertTypeId** | **long** |  |  |
| **baseMonitorName** | **string** |  |  |
| **body** | **string?** |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolselasticpoolnamealertsettingsalerttypeidget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdGet**
> AlertSettingsDto ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdGet (string serverName, string elasticPoolName, long alertTypeId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureElasticPoolAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var elasticPoolName = "elasticPoolName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AlertSettingsDto result = apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdGet(serverName, elasticPoolName, alertTypeId, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureElasticPoolAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertSettingsDto> response = apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdGetWithHttpInfo(serverName, elasticPoolName, alertTypeId, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureElasticPoolAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **elasticPoolName** | **string** |  |  |
| **alertTypeId** | **long** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**AlertSettingsDto**](AlertSettingsDto.md)

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
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolselasticpoolnamealertsettingsalerttypeidnotificationsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdNotificationsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdNotificationsettingsPatch (string serverName, string elasticPoolName, long alertTypeId, string baseMonitorName, AlertNotificationSettingsDto? alertNotificationSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdNotificationsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureElasticPoolAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var elasticPoolName = "elasticPoolName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var alertNotificationSettingsDto = new AlertNotificationSettingsDto?(); // AlertNotificationSettingsDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdNotificationsettingsPatch(serverName, elasticPoolName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureElasticPoolAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdNotificationsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo(serverName, elasticPoolName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureElasticPoolAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **elasticPoolName** | **string** |  |  |
| **alertTypeId** | **long** |  |  |
| **baseMonitorName** | **string** |  |  |
| **alertNotificationSettingsDto** | [**AlertNotificationSettingsDto?**](AlertNotificationSettingsDto?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolselasticpoolnamealertsettingsalerttypeidspecificsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdSpecificsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdSpecificsettingsPatch (string serverName, string elasticPoolName, long alertTypeId, string baseMonitorName, Dictionary<string, List>? requestBody = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdSpecificsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureElasticPoolAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var elasticPoolName = "elasticPoolName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var requestBody = new Dictionary<string, List>?(); // Dictionary<string, List>? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdSpecificsettingsPatch(serverName, elasticPoolName, alertTypeId, baseMonitorName, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureElasticPoolAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdSpecificsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo(serverName, elasticPoolName, alertTypeId, baseMonitorName, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureElasticPoolAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **elasticPoolName** | **string** |  |  |
| **alertTypeId** | **long** |  |  |
| **baseMonitorName** | **string** |  |  |
| **requestBody** | [**Dictionary&lt;string, List&gt;?**](List.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolselasticpoolnamealertsettingsalerttypeidstatuspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdStatusPatch**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdStatusPatch (string serverName, string elasticPoolName, long alertTypeId, string baseMonitorName, int? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdStatusPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureElasticPoolAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var elasticPoolName = "elasticPoolName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdStatusPatch(serverName, elasticPoolName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureElasticPoolAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdStatusPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo(serverName, elasticPoolName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureElasticPoolAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **elasticPoolName** | **string** |  |  |
| **alertTypeId** | **long** |  |  |
| **baseMonitorName** | **string** |  |  |
| **body** | **int?** |  | [optional]  |

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

