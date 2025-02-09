# cli.Api.AzureSqlDatabaseAlertSettingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch**](AzureSqlDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenamealertsettingsalerttypeidcommentspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/databases/{databaseName}/alertsettings/{alertTypeId}/comments |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet**](AzureSqlDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenamealertsettingsalerttypeidget) | **GET** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/databases/{databaseName}/alertsettings/{alertTypeId} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch**](AzureSqlDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenamealertsettingsalerttypeidnotificationsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/databases/{databaseName}/alertsettings/{alertTypeId}/notificationsettings |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch**](AzureSqlDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenamealertsettingsalerttypeidspecificsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/databases/{databaseName}/alertsettings/{alertTypeId}/specificsettings |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch**](AzureSqlDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenamealertsettingsalerttypeidstatuspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/databases/{databaseName}/alertsettings/{alertTypeId}/status |  |

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenamealertsettingsalerttypeidcommentspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch (string serverName, string databaseName, long alertTypeId, string baseMonitorName, string? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlDatabaseAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = "body_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch(serverName, databaseName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo(serverName, databaseName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **databaseName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenamealertsettingsalerttypeidget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet (string serverName, string databaseName, long alertTypeId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlDatabaseAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet(serverName, databaseName, alertTypeId, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetWithHttpInfo(serverName, databaseName, alertTypeId, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **databaseName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenamealertsettingsalerttypeidnotificationsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch (string serverName, string databaseName, long alertTypeId, string baseMonitorName, AlertNotificationSettingsDto? alertNotificationSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlDatabaseAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var alertNotificationSettingsDto = new AlertNotificationSettingsDto?(); // AlertNotificationSettingsDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch(serverName, databaseName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo(serverName, databaseName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **databaseName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenamealertsettingsalerttypeidspecificsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch (string serverName, string databaseName, long alertTypeId, string baseMonitorName, Dictionary<string, List>? requestBody = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlDatabaseAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var requestBody = new Dictionary<string, List>?(); // Dictionary<string, List>? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch(serverName, databaseName, alertTypeId, baseMonitorName, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo(serverName, databaseName, alertTypeId, baseMonitorName, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **databaseName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenamealertsettingsalerttypeidstatuspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch (string serverName, string databaseName, long alertTypeId, string baseMonitorName, int? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlDatabaseAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch(serverName, databaseName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo(serverName, databaseName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **databaseName** | **string** |  |  |
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

