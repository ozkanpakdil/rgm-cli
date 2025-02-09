# cli.Api.FurApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiFeatureUsageEventNamePost**](FurApi.md#apifeatureusageeventnamepost) | **POST** /api/feature-usage/{eventName} |  |
| [**ApiFeedbackSubjectFeedbackPost**](FurApi.md#apifeedbacksubjectfeedbackpost) | **POST** /api/feedback/{subject}/{feedback} |  |

<a id="apifeatureusageeventnamepost"></a>
# **ApiFeatureUsageEventNamePost**
> UnitJSendSuccess ApiFeatureUsageEventNamePost (string eventName, Object? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiFeatureUsageEventNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FurApi(config);
            var eventName = "eventName_example";  // string | 
            var body = null;  // Object? |  (optional) 

            try
            {
                UnitJSendSuccess result = apiInstance.ApiFeatureUsageEventNamePost(eventName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FurApi.ApiFeatureUsageEventNamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiFeatureUsageEventNamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UnitJSendSuccess> response = apiInstance.ApiFeatureUsageEventNamePostWithHttpInfo(eventName, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FurApi.ApiFeatureUsageEventNamePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventName** | **string** |  |  |
| **body** | **Object?** |  | [optional]  |

### Return type

[**UnitJSendSuccess**](UnitJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apifeedbacksubjectfeedbackpost"></a>
# **ApiFeedbackSubjectFeedbackPost**
> UnitJSendSuccess ApiFeedbackSubjectFeedbackPost (string subject, string feedback)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiFeedbackSubjectFeedbackPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new FurApi(config);
            var subject = "subject_example";  // string | 
            var feedback = "feedback_example";  // string | 

            try
            {
                UnitJSendSuccess result = apiInstance.ApiFeedbackSubjectFeedbackPost(subject, feedback);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FurApi.ApiFeedbackSubjectFeedbackPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiFeedbackSubjectFeedbackPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UnitJSendSuccess> response = apiInstance.ApiFeedbackSubjectFeedbackPostWithHttpInfo(subject, feedback);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FurApi.ApiFeedbackSubjectFeedbackPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subject** | **string** |  |  |
| **feedback** | **string** |  |  |

### Return type

[**UnitJSendSuccess**](UnitJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

