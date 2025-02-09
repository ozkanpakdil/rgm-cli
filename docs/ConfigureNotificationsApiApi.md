# cli.Api.ConfigureNotificationsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendbasemonitorerrortestemailPost**](ConfigureNotificationsApiApi.md#apibasemonitorsbasemonitornameconfigurationnotificationsendbasemonitorerrortestemailpost) | **POST** /api/basemonitors/{baseMonitorName}/configuration/notification/sendbasemonitorerrortestemail |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendtestemailPost**](ConfigureNotificationsApiApi.md#apibasemonitorsbasemonitornameconfigurationnotificationsendtestemailpost) | **POST** /api/basemonitors/{baseMonitorName}/configuration/notification/sendtestemail |  |

<a id="apibasemonitorsbasemonitornameconfigurationnotificationsendbasemonitorerrortestemailpost"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendbasemonitorerrortestemailPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendbasemonitorerrortestemailPost (string baseMonitorName, NotificationSettingsDto? notificationSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendbasemonitorerrortestemailPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureNotificationsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var notificationSettingsDto = new NotificationSettingsDto?(); // NotificationSettingsDto? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendbasemonitorerrortestemailPost(baseMonitorName, notificationSettingsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureNotificationsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendbasemonitorerrortestemailPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendbasemonitorerrortestemailPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendbasemonitorerrortestemailPostWithHttpInfo(baseMonitorName, notificationSettingsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureNotificationsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendbasemonitorerrortestemailPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **notificationSettingsDto** | [**NotificationSettingsDto?**](NotificationSettingsDto?.md) |  | [optional]  |

### Return type

[**JSendSuccess**](JSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | Unprocessable Content |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameconfigurationnotificationsendtestemailpost"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendtestemailPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendtestemailPost (string baseMonitorName, NotificationSettingsDto? notificationSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendtestemailPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureNotificationsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var notificationSettingsDto = new NotificationSettingsDto?(); // NotificationSettingsDto? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendtestemailPost(baseMonitorName, notificationSettingsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureNotificationsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendtestemailPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendtestemailPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendtestemailPostWithHttpInfo(baseMonitorName, notificationSettingsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureNotificationsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationNotificationSendtestemailPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **notificationSettingsDto** | [**NotificationSettingsDto?**](NotificationSettingsDto?.md) |  | [optional]  |

### Return type

[**JSendSuccess**](JSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | Unprocessable Content |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

