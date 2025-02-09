# cli.Api.StandaloneMachineAlertSettingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdCommentsPatch**](StandaloneMachineAlertSettingsApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenamealertsettingsalerttypeidcommentspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/alertsettings/{alertTypeId}/comments |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdGet**](StandaloneMachineAlertSettingsApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenamealertsettingsalerttypeidget) | **GET** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/alertsettings/{alertTypeId} |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatch**](StandaloneMachineAlertSettingsApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenamealertsettingsalerttypeidnotificationsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/alertsettings/{alertTypeId}/notificationsettings |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatch**](StandaloneMachineAlertSettingsApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenamealertsettingsalerttypeidspecificsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/alertsettings/{alertTypeId}/specificsettings |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdStatusPatch**](StandaloneMachineAlertSettingsApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenamealertsettingsalerttypeidstatuspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/alertsettings/{alertTypeId}/status |  |

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenamealertsettingsalerttypeidcommentspatch"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdCommentsPatch**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdCommentsPatch (string machineName, long alertTypeId, string baseMonitorName, string? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdCommentsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new StandaloneMachineAlertSettingsApi(config);
            var machineName = "machineName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = "body_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdCommentsPatch(machineName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StandaloneMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdCommentsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo(machineName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StandaloneMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenamealertsettingsalerttypeidget"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdGet**
> AlertSettingsDto ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdGet (string machineName, long alertTypeId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new StandaloneMachineAlertSettingsApi(config);
            var machineName = "machineName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AlertSettingsDto result = apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdGet(machineName, alertTypeId, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StandaloneMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertSettingsDto> response = apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdGetWithHttpInfo(machineName, alertTypeId, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StandaloneMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenamealertsettingsalerttypeidnotificationsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatch (string machineName, long alertTypeId, string baseMonitorName, AlertNotificationSettingsDto? alertNotificationSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new StandaloneMachineAlertSettingsApi(config);
            var machineName = "machineName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var alertNotificationSettingsDto = new AlertNotificationSettingsDto?(); // AlertNotificationSettingsDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatch(machineName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StandaloneMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo(machineName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StandaloneMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenamealertsettingsalerttypeidspecificsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatch (string machineName, long alertTypeId, string baseMonitorName, Dictionary<string, List>? requestBody = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new StandaloneMachineAlertSettingsApi(config);
            var machineName = "machineName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var requestBody = new Dictionary<string, List>?(); // Dictionary<string, List>? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatch(machineName, alertTypeId, baseMonitorName, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StandaloneMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo(machineName, alertTypeId, baseMonitorName, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StandaloneMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenamealertsettingsalerttypeidstatuspatch"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdStatusPatch**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdStatusPatch (string machineName, long alertTypeId, string baseMonitorName, int? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdStatusPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new StandaloneMachineAlertSettingsApi(config);
            var machineName = "machineName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdStatusPatch(machineName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StandaloneMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdStatusPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo(machineName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StandaloneMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
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

