# cli.Api.AvailabilityGroupAlertSettingsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdCommentsPatch**](AvailabilityGroupAlertSettingsApi.md#apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsagnamealertsettingsalerttypeidcommentspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/availabilitygroups/{agName}/alertsettings/{alertTypeId}/comments |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdGet**](AvailabilityGroupAlertSettingsApi.md#apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsagnamealertsettingsalerttypeidget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/availabilitygroups/{agName}/alertsettings/{alertTypeId} |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdNotificationsettingsPatch**](AvailabilityGroupAlertSettingsApi.md#apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsagnamealertsettingsalerttypeidnotificationsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/availabilitygroups/{agName}/alertsettings/{alertTypeId}/notificationsettings |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdSpecificsettingsPatch**](AvailabilityGroupAlertSettingsApi.md#apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsagnamealertsettingsalerttypeidspecificsettingspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/availabilitygroups/{agName}/alertsettings/{alertTypeId}/specificsettings |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdStatusPatch**](AvailabilityGroupAlertSettingsApi.md#apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsagnamealertsettingsalerttypeidstatuspatch) | **PATCH** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/availabilitygroups/{agName}/alertsettings/{alertTypeId}/status |  |

<a id="apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsagnamealertsettingsalerttypeidcommentspatch"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdCommentsPatch**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdCommentsPatch (string clusterName, string agName, long alertTypeId, string baseMonitorName, string? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdCommentsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AvailabilityGroupAlertSettingsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var agName = "agName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = "body_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdCommentsPatch(clusterName, agName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityGroupAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdCommentsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo(clusterName, agName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityGroupAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdCommentsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **agName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsagnamealertsettingsalerttypeidget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdGet**
> AlertSettingsDto ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdGet (string clusterName, string agName, long alertTypeId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AvailabilityGroupAlertSettingsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var agName = "agName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AlertSettingsDto result = apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdGet(clusterName, agName, alertTypeId, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityGroupAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertSettingsDto> response = apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdGetWithHttpInfo(clusterName, agName, alertTypeId, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityGroupAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **agName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsagnamealertsettingsalerttypeidnotificationsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdNotificationsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdNotificationsettingsPatch (string clusterName, string agName, long alertTypeId, string baseMonitorName, AlertNotificationSettingsDto? alertNotificationSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdNotificationsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AvailabilityGroupAlertSettingsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var agName = "agName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var alertNotificationSettingsDto = new AlertNotificationSettingsDto?(); // AlertNotificationSettingsDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdNotificationsettingsPatch(clusterName, agName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityGroupAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdNotificationsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo(clusterName, agName, alertTypeId, baseMonitorName, alertNotificationSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityGroupAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdNotificationsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **agName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsagnamealertsettingsalerttypeidspecificsettingspatch"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdSpecificsettingsPatch**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdSpecificsettingsPatch (string clusterName, string agName, long alertTypeId, string baseMonitorName, Dictionary<string, List>? requestBody = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdSpecificsettingsPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AvailabilityGroupAlertSettingsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var agName = "agName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var requestBody = new Dictionary<string, List>?(); // Dictionary<string, List>? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdSpecificsettingsPatch(clusterName, agName, alertTypeId, baseMonitorName, requestBody);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityGroupAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdSpecificsettingsPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo(clusterName, agName, alertTypeId, baseMonitorName, requestBody);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityGroupAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdSpecificsettingsPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **agName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsagnamealertsettingsalerttypeidstatuspatch"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdStatusPatch**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdStatusPatch (string clusterName, string agName, long alertTypeId, string baseMonitorName, int? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdStatusPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AvailabilityGroupAlertSettingsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var agName = "agName_example";  // string | 
            var alertTypeId = 789L;  // long | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdStatusPatch(clusterName, agName, alertTypeId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityGroupAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdStatusPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo(clusterName, agName, alertTypeId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityGroupAlertSettingsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAgNameAlertsettingsAlertTypeIdStatusPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **agName** | **string** |  |  |
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

