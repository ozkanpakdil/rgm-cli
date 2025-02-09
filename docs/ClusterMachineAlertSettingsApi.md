# cli.Api.ClusterMachineAlertSettingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdCommentsPatch**](ClusterMachineAlertSettingsApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamealertsettingsalerttypeidcommentspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/alertsettings/{alertTypeId}/comments |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdGet**](ClusterMachineAlertSettingsApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamealertsettingsalerttypeidget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/alertsettings/{alertTypeId} |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatch**](ClusterMachineAlertSettingsApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamealertsettingsalerttypeidnotificationsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/alertsettings/{alertTypeId}/notificationsettings |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatch**](ClusterMachineAlertSettingsApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamealertsettingsalerttypeidspecificsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/alertsettings/{alertTypeId}/specificsettings |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdStatusPatch**](ClusterMachineAlertSettingsApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamealertsettingsalerttypeidstatuspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/alertsettings/{alertTypeId}/status |  |

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamealertsettingsalerttypeidcommentspatch"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdCommentsPatch**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdCommentsPatch (string clusterName, string machineName, long alertTypeId, string baseMonitorName, string? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdCommentsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClusterMachineAlertSettingsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = "body_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdCommentsPatch(clusterName, machineName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdCommentsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo(clusterName, machineName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamealertsettingsalerttypeidget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdGet**
> AlertSettingsDto ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdGet (string clusterName, string machineName, long alertTypeId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClusterMachineAlertSettingsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AlertSettingsDto result = apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdGet(clusterName, machineName, alertTypeId, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertSettingsDto> response = apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdGetWithHttpInfo(clusterName, machineName, alertTypeId, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamealertsettingsalerttypeidnotificationsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatch (string clusterName, string machineName, long alertTypeId, string baseMonitorName, AlertNotificationSettingsDto? alertNotificationSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClusterMachineAlertSettingsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var alertNotificationSettingsDto = new AlertNotificationSettingsDto?(); // AlertNotificationSettingsDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatch(clusterName, machineName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo(clusterName, machineName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamealertsettingsalerttypeidspecificsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatch (string clusterName, string machineName, long alertTypeId, string baseMonitorName, Dictionary<string, List>? requestBody = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClusterMachineAlertSettingsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var requestBody = new Dictionary<string, List>?(); // Dictionary<string, List>? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatch(clusterName, machineName, alertTypeId, baseMonitorName, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo(clusterName, machineName, alertTypeId, baseMonitorName, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenamealertsettingsalerttypeidstatuspatch"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdStatusPatch**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdStatusPatch (string clusterName, string machineName, long alertTypeId, string baseMonitorName, int? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdStatusPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ClusterMachineAlertSettingsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdStatusPatch(clusterName, machineName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ClusterMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdStatusPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo(clusterName, machineName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ClusterMachineAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
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

