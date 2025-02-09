# cli.Api.StandaloneMachineDiskAlertSettingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdCommentsPatch**](StandaloneMachineDiskAlertSettingsApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksdisknamealertsettingsalerttypeidcommentspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/disks/{diskName}/alertsettings/{alertTypeId}/comments |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdGet**](StandaloneMachineDiskAlertSettingsApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksdisknamealertsettingsalerttypeidget) | **GET** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/disks/{diskName}/alertsettings/{alertTypeId} |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdNotificationsettingsPatch**](StandaloneMachineDiskAlertSettingsApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksdisknamealertsettingsalerttypeidnotificationsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/disks/{diskName}/alertsettings/{alertTypeId}/notificationsettings |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdSpecificsettingsPatch**](StandaloneMachineDiskAlertSettingsApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksdisknamealertsettingsalerttypeidspecificsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/disks/{diskName}/alertsettings/{alertTypeId}/specificsettings |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdStatusPatch**](StandaloneMachineDiskAlertSettingsApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksdisknamealertsettingsalerttypeidstatuspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/disks/{diskName}/alertsettings/{alertTypeId}/status |  |

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksdisknamealertsettingsalerttypeidcommentspatch"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdCommentsPatch**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdCommentsPatch (string machineName, string diskName, long alertTypeId, string baseMonitorName, string? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdCommentsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new StandaloneMachineDiskAlertSettingsApi(config);
            var machineName = "machineName_example";  // string | 
            var diskName = "diskName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = "body_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdCommentsPatch(machineName, diskName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StandaloneMachineDiskAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdCommentsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo(machineName, diskName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StandaloneMachineDiskAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
| **diskName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksdisknamealertsettingsalerttypeidget"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdGet**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdGet (string machineName, string diskName, long alertTypeId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new StandaloneMachineDiskAlertSettingsApi(config);
            var machineName = "machineName_example";  // string | 
            var diskName = "diskName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdGet(machineName, diskName, alertTypeId, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StandaloneMachineDiskAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdGetWithHttpInfo(machineName, diskName, alertTypeId, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StandaloneMachineDiskAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
| **diskName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksdisknamealertsettingsalerttypeidnotificationsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdNotificationsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdNotificationsettingsPatch (string machineName, string diskName, long alertTypeId, string baseMonitorName, AlertNotificationSettingsDto? alertNotificationSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdNotificationsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new StandaloneMachineDiskAlertSettingsApi(config);
            var machineName = "machineName_example";  // string | 
            var diskName = "diskName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var alertNotificationSettingsDto = new AlertNotificationSettingsDto?(); // AlertNotificationSettingsDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdNotificationsettingsPatch(machineName, diskName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StandaloneMachineDiskAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdNotificationsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo(machineName, diskName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StandaloneMachineDiskAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
| **diskName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksdisknamealertsettingsalerttypeidspecificsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdSpecificsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdSpecificsettingsPatch (string machineName, string diskName, long alertTypeId, string baseMonitorName, Dictionary<string, List>? requestBody = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdSpecificsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new StandaloneMachineDiskAlertSettingsApi(config);
            var machineName = "machineName_example";  // string | 
            var diskName = "diskName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var requestBody = new Dictionary<string, List>?(); // Dictionary<string, List>? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdSpecificsettingsPatch(machineName, diskName, alertTypeId, baseMonitorName, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StandaloneMachineDiskAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdSpecificsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo(machineName, diskName, alertTypeId, baseMonitorName, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StandaloneMachineDiskAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
| **diskName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenamedisksdisknamealertsettingsalerttypeidstatuspatch"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdStatusPatch**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdStatusPatch (string machineName, string diskName, long alertTypeId, string baseMonitorName, int? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdStatusPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new StandaloneMachineDiskAlertSettingsApi(config);
            var machineName = "machineName_example";  // string | 
            var diskName = "diskName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdStatusPatch(machineName, diskName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StandaloneMachineDiskAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdStatusPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo(machineName, diskName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StandaloneMachineDiskAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameDisksDiskNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
| **diskName** | **string** |  |  |
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

