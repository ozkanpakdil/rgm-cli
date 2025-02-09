# cli.Api.AzureManagedInstanceDatabaseAlertSettingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch**](AzureManagedInstanceDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesdatabasenamealertsettingsalerttypeidcommentspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuremanagedinstances/{serverName}/databases/{databaseName}/alertsettings/{alertTypeId}/comments |  |
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet**](AzureManagedInstanceDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesdatabasenamealertsettingsalerttypeidget) | **GET** /api/basemonitors/{baseMonitorName}/azuremanagedinstances/{serverName}/databases/{databaseName}/alertsettings/{alertTypeId} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch**](AzureManagedInstanceDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesdatabasenamealertsettingsalerttypeidnotificationsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuremanagedinstances/{serverName}/databases/{databaseName}/alertsettings/{alertTypeId}/notificationsettings |  |
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch**](AzureManagedInstanceDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesdatabasenamealertsettingsalerttypeidspecificsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuremanagedinstances/{serverName}/databases/{databaseName}/alertsettings/{alertTypeId}/specificsettings |  |
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch**](AzureManagedInstanceDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesdatabasenamealertsettingsalerttypeidstatuspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuremanagedinstances/{serverName}/databases/{databaseName}/alertsettings/{alertTypeId}/status |  |

<a id="apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesdatabasenamealertsettingsalerttypeidcommentspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch**
> void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch (string serverName, string databaseName, long alertTypeId, string baseMonitorName, string? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstanceDatabaseAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = "body_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch(serverName, databaseName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo(serverName, databaseName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesdatabasenamealertsettingsalerttypeidget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet**
> void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet (string serverName, string databaseName, long alertTypeId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstanceDatabaseAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet(serverName, databaseName, alertTypeId, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetWithHttpInfo(serverName, databaseName, alertTypeId, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesdatabasenamealertsettingsalerttypeidnotificationsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch (string serverName, string databaseName, long alertTypeId, string baseMonitorName, AlertNotificationSettingsDto? alertNotificationSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstanceDatabaseAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var alertNotificationSettingsDto = new AlertNotificationSettingsDto?(); // AlertNotificationSettingsDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch(serverName, databaseName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo(serverName, databaseName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesdatabasenamealertsettingsalerttypeidspecificsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch (string serverName, string databaseName, long alertTypeId, string baseMonitorName, Dictionary<string, List>? requestBody = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstanceDatabaseAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var requestBody = new Dictionary<string, List>?(); // Dictionary<string, List>? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch(serverName, databaseName, alertTypeId, baseMonitorName, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo(serverName, databaseName, alertTypeId, baseMonitorName, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesdatabasenamealertsettingsalerttypeidstatuspatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch**
> void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch (string serverName, string databaseName, long alertTypeId, string baseMonitorName, int? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstanceDatabaseAlertSettingsApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch(serverName, databaseName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo(serverName, databaseName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo: " + e.Message);
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

