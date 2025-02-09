# cli.Api.AzureSqlServerAlertSettingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdCommentsPatch**](AzureSqlServerAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamealertsettingsalerttypeidcommentspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/alertsettings/{alertTypeId}/comments |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdGet**](AzureSqlServerAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamealertsettingsalerttypeidget) | **GET** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/alertsettings/{alertTypeId} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdNotificationsettingsPatch**](AzureSqlServerAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamealertsettingsalerttypeidnotificationsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/alertsettings/{alertTypeId}/notificationsettings |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdSpecificsettingsPatch**](AzureSqlServerAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamealertsettingsalerttypeidspecificsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/alertsettings/{alertTypeId}/specificsettings |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdStatusPatch**](AzureSqlServerAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamealertsettingsalerttypeidstatuspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/alertsettings/{alertTypeId}/status |  |

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamealertsettingsalerttypeidcommentspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdCommentsPatch**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdCommentsPatch (string serverName, long alertTypeId, string baseMonitorName, string? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdCommentsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlServerAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = "body_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdCommentsPatch(serverName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlServerAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdCommentsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo(serverName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlServerAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamealertsettingsalerttypeidget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdGet**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdGet (string serverName, long alertTypeId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlServerAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdGet(serverName, alertTypeId, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlServerAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdGetWithHttpInfo(serverName, alertTypeId, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlServerAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **alertTypeId** | **long** |  |  |
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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamealertsettingsalerttypeidnotificationsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdNotificationsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdNotificationsettingsPatch (string serverName, long alertTypeId, string baseMonitorName, AlertNotificationSettingsDto? alertNotificationSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdNotificationsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlServerAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var alertNotificationSettingsDto = new AlertNotificationSettingsDto?(); // AlertNotificationSettingsDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdNotificationsettingsPatch(serverName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlServerAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdNotificationsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo(serverName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlServerAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamealertsettingsalerttypeidspecificsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdSpecificsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdSpecificsettingsPatch (string serverName, long alertTypeId, string baseMonitorName, Dictionary<string, List>? requestBody = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdSpecificsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlServerAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var requestBody = new Dictionary<string, List>?(); // Dictionary<string, List>? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdSpecificsettingsPatch(serverName, alertTypeId, baseMonitorName, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlServerAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdSpecificsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo(serverName, alertTypeId, baseMonitorName, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlServerAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamealertsettingsalerttypeidstatuspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdStatusPatch**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdStatusPatch (string serverName, long alertTypeId, string baseMonitorName, int? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdStatusPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlServerAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdStatusPatch(serverName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlServerAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdStatusPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo(serverName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlServerAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
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

