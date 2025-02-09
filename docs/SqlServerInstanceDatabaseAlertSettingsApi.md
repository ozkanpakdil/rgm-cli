# cli.Api.SqlServerInstanceDatabaseAlertSettingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch**](SqlServerInstanceDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesdatabasenamealertsettingsalerttypeidcommentspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName}/instances/{instanceName}/databases/{databaseName}/alertsettings/{alertTypeId}/comments |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet**](SqlServerInstanceDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesdatabasenamealertsettingsalerttypeidget) | **GET** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName}/instances/{instanceName}/databases/{databaseName}/alertsettings/{alertTypeId} |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch**](SqlServerInstanceDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesdatabasenamealertsettingsalerttypeidnotificationsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName}/instances/{instanceName}/databases/{databaseName}/alertsettings/{alertTypeId}/notificationsettings |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch**](SqlServerInstanceDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesdatabasenamealertsettingsalerttypeidspecificsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName}/instances/{instanceName}/databases/{databaseName}/alertsettings/{alertTypeId}/specificsettings |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch**](SqlServerInstanceDatabaseAlertSettingsApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesdatabasenamealertsettingsalerttypeidstatuspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName}/instances/{instanceName}/databases/{databaseName}/alertsettings/{alertTypeId}/status |  |

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesdatabasenamealertsettingsalerttypeidcommentspatch"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch (string instanceName, string databaseName, long alertTypeId, string baseMonitorName, string linuxMachineName, string? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SqlServerInstanceDatabaseAlertSettingsApi(config);
            var instanceName = "instanceName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var body = "body_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch(instanceName, databaseName, alertTypeId, baseMonitorName, linuxMachineName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlServerInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo(instanceName, databaseName, alertTypeId, baseMonitorName, linuxMachineName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlServerInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceName** | **string** |  |  |
| **databaseName** | **string** |  |  |
| **alertTypeId** | **long** |  |  |
| **baseMonitorName** | **string** |  |  |
| **linuxMachineName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesdatabasenamealertsettingsalerttypeidget"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet (string instanceName, string databaseName, long alertTypeId, string baseMonitorName, string linuxMachineName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SqlServerInstanceDatabaseAlertSettingsApi(config);
            var instanceName = "instanceName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var linuxMachineName = "linuxMachineName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet(instanceName, databaseName, alertTypeId, baseMonitorName, linuxMachineName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlServerInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetWithHttpInfo(instanceName, databaseName, alertTypeId, baseMonitorName, linuxMachineName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlServerInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceName** | **string** |  |  |
| **databaseName** | **string** |  |  |
| **alertTypeId** | **long** |  |  |
| **baseMonitorName** | **string** |  |  |
| **linuxMachineName** | **string** |  |  |

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

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesdatabasenamealertsettingsalerttypeidnotificationsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch (string instanceName, string databaseName, long alertTypeId, string baseMonitorName, string linuxMachineName, AlertNotificationSettingsDto? alertNotificationSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SqlServerInstanceDatabaseAlertSettingsApi(config);
            var instanceName = "instanceName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var alertNotificationSettingsDto = new AlertNotificationSettingsDto?(); // AlertNotificationSettingsDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch(instanceName, databaseName, alertTypeId, baseMonitorName, linuxMachineName, alertNotificationSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlServerInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo(instanceName, databaseName, alertTypeId, baseMonitorName, linuxMachineName, alertNotificationSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlServerInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceName** | **string** |  |  |
| **databaseName** | **string** |  |  |
| **alertTypeId** | **long** |  |  |
| **baseMonitorName** | **string** |  |  |
| **linuxMachineName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesdatabasenamealertsettingsalerttypeidspecificsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch (string instanceName, string databaseName, long alertTypeId, string baseMonitorName, string linuxMachineName, Dictionary<string, List>? requestBody = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SqlServerInstanceDatabaseAlertSettingsApi(config);
            var instanceName = "instanceName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var requestBody = new Dictionary<string, List>?(); // Dictionary<string, List>? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch(instanceName, databaseName, alertTypeId, baseMonitorName, linuxMachineName, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlServerInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo(instanceName, databaseName, alertTypeId, baseMonitorName, linuxMachineName, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlServerInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceName** | **string** |  |  |
| **databaseName** | **string** |  |  |
| **alertTypeId** | **long** |  |  |
| **baseMonitorName** | **string** |  |  |
| **linuxMachineName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenamedatabasesdatabasenamealertsettingsalerttypeidstatuspatch"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch (string instanceName, string databaseName, long alertTypeId, string baseMonitorName, string linuxMachineName, int? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SqlServerInstanceDatabaseAlertSettingsApi(config);
            var instanceName = "instanceName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var body = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch(instanceName, databaseName, alertTypeId, baseMonitorName, linuxMachineName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlServerInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo(instanceName, databaseName, alertTypeId, baseMonitorName, linuxMachineName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlServerInstanceDatabaseAlertSettingsApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNameDatabasesDatabaseNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceName** | **string** |  |  |
| **databaseName** | **string** |  |  |
| **alertTypeId** | **long** |  |  |
| **baseMonitorName** | **string** |  |  |
| **linuxMachineName** | **string** |  |  |
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

