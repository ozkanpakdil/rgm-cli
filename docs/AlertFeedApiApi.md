# cli.Api.AlertFeedApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAlertsDetailsAlertIdGet**](AlertFeedApiApi.md#apibasemonitorsbasemonitornamealertsdetailsalertidget) | **GET** /api/basemonitors/{baseMonitorName}/alerts/details/{alertId} |  |
| [**ApiBasemonitorsBaseMonitorNameAlertsDetailsRelatedAlertIdGet**](AlertFeedApiApi.md#apibasemonitorsbasemonitornamealertsdetailsrelatedalertidget) | **GET** /api/basemonitors/{baseMonitorName}/alerts/details/related/{alertId} |  |
| [**ApiBasemonitorsBaseMonitorNameAlertsFeedGet**](AlertFeedApiApi.md#apibasemonitorsbasemonitornamealertsfeedget) | **GET** /api/basemonitors/{baseMonitorName}/alerts/feed |  |

<a id="apibasemonitorsbasemonitornamealertsdetailsalertidget"></a>
# **ApiBasemonitorsBaseMonitorNameAlertsDetailsAlertIdGet**
> RecentAlertDetailsDtoJSendSuccess ApiBasemonitorsBaseMonitorNameAlertsDetailsAlertIdGet (IntegerIdentifier alertId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAlertsDetailsAlertIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertFeedApiApi(config);
            var alertId = new IntegerIdentifier(); // IntegerIdentifier | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                RecentAlertDetailsDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsDetailsAlertIdGet(alertId, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertFeedApiApi.ApiBasemonitorsBaseMonitorNameAlertsDetailsAlertIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAlertsDetailsAlertIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RecentAlertDetailsDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsDetailsAlertIdGetWithHttpInfo(alertId, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertFeedApiApi.ApiBasemonitorsBaseMonitorNameAlertsDetailsAlertIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertId** | [**IntegerIdentifier**](IntegerIdentifier.md) |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**RecentAlertDetailsDtoJSendSuccess**](RecentAlertDetailsDtoJSendSuccess.md)

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
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamealertsdetailsrelatedalertidget"></a>
# **ApiBasemonitorsBaseMonitorNameAlertsDetailsRelatedAlertIdGet**
> AlertHistoryCommentsDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameAlertsDetailsRelatedAlertIdGet (IntegerIdentifier alertId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAlertsDetailsRelatedAlertIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertFeedApiApi(config);
            var alertId = new IntegerIdentifier(); // IntegerIdentifier | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AlertHistoryCommentsDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsDetailsRelatedAlertIdGet(alertId, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertFeedApiApi.ApiBasemonitorsBaseMonitorNameAlertsDetailsRelatedAlertIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAlertsDetailsRelatedAlertIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertHistoryCommentsDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsDetailsRelatedAlertIdGetWithHttpInfo(alertId, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertFeedApiApi.ApiBasemonitorsBaseMonitorNameAlertsDetailsRelatedAlertIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertId** | [**IntegerIdentifier**](IntegerIdentifier.md) |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**AlertHistoryCommentsDtoIEnumerableJSendSuccess**](AlertHistoryCommentsDtoIEnumerableJSendSuccess.md)

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
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamealertsfeedget"></a>
# **ApiBasemonitorsBaseMonitorNameAlertsFeedGet**
> ServerOverviewAlertsFeedModelDtoJSendSuccess ApiBasemonitorsBaseMonitorNameAlertsFeedGet (ChannelInstanceRef cir, DateTime minTime, DateTime maxTime, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAlertsFeedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertFeedApiApi(config);
            var cir = new ChannelInstanceRef(); // ChannelInstanceRef | 
            var minTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var maxTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                ServerOverviewAlertsFeedModelDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsFeedGet(cir, minTime, maxTime, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertFeedApiApi.ApiBasemonitorsBaseMonitorNameAlertsFeedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAlertsFeedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ServerOverviewAlertsFeedModelDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAlertsFeedGetWithHttpInfo(cir, minTime, maxTime, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertFeedApiApi.ApiBasemonitorsBaseMonitorNameAlertsFeedGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**ChannelInstanceRef**](ChannelInstanceRef.md) |  |  |
| **minTime** | **DateTime** |  |  |
| **maxTime** | **DateTime** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**ServerOverviewAlertsFeedModelDtoJSendSuccess**](ServerOverviewAlertsFeedModelDtoJSendSuccess.md)

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
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

