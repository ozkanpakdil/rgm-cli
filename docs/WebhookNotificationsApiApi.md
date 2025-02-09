# cli.Api.WebhookNotificationsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameWebhooknotificationsTestPost**](WebhookNotificationsApiApi.md#apibasemonitorsbasemonitornamewebhooknotificationstestpost) | **POST** /api/basemonitors/{baseMonitorName}/webhooknotifications/test |  |

<a id="apibasemonitorsbasemonitornamewebhooknotificationstestpost"></a>
# **ApiBasemonitorsBaseMonitorNameWebhooknotificationsTestPost**
> void ApiBasemonitorsBaseMonitorNameWebhooknotificationsTestPost (string baseMonitorName, WebhookTestRequestCommandDto? webhookTestRequestCommandDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameWebhooknotificationsTestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WebhookNotificationsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var webhookTestRequestCommandDto = new WebhookTestRequestCommandDto?(); // WebhookTestRequestCommandDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameWebhooknotificationsTestPost(baseMonitorName, webhookTestRequestCommandDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WebhookNotificationsApiApi.ApiBasemonitorsBaseMonitorNameWebhooknotificationsTestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameWebhooknotificationsTestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameWebhooknotificationsTestPostWithHttpInfo(baseMonitorName, webhookTestRequestCommandDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling WebhookNotificationsApiApi.ApiBasemonitorsBaseMonitorNameWebhooknotificationsTestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **webhookTestRequestCommandDto** | [**WebhookTestRequestCommandDto?**](WebhookTestRequestCommandDto?.md) |  | [optional]  |

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

