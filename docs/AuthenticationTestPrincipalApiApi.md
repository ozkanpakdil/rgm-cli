# cli.Api.AuthenticationTestPrincipalApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestGroupPost**](AuthenticationTestPrincipalApiApi.md#apibasemonitorsbasemonitornameauthenticationprincipalsprincipalnametestgrouppost) | **POST** /api/basemonitors/{baseMonitorName}/authentication/principals/{principalName}/testGroup |  |
| [**ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestMonitoredObjectPost**](AuthenticationTestPrincipalApiApi.md#apibasemonitorsbasemonitornameauthenticationprincipalsprincipalnametestmonitoredobjectpost) | **POST** /api/basemonitors/{baseMonitorName}/authentication/principals/{principalName}/testMonitoredObject |  |

<a id="apibasemonitorsbasemonitornameauthenticationprincipalsprincipalnametestgrouppost"></a>
# **ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestGroupPost**
> AccessReportJSendSuccess ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestGroupPost (string principalName, string baseMonitorName, Guid? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestGroupPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthenticationTestPrincipalApiApi(config);
            var principalName = "principalName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = "body_example";  // Guid? |  (optional) 

            try
            {
                AccessReportJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestGroupPost(principalName, baseMonitorName, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationTestPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestGroupPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestGroupPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessReportJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestGroupPostWithHttpInfo(principalName, baseMonitorName, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationTestPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestGroupPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **principalName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **body** | **Guid?** |  | [optional]  |

### Return type

[**AccessReportJSendSuccess**](AccessReportJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameauthenticationprincipalsprincipalnametestmonitoredobjectpost"></a>
# **ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestMonitoredObjectPost**
> AccessReportJSendSuccess ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestMonitoredObjectPost (string principalName, string baseMonitorName, AccessRequest? accessRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestMonitoredObjectPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthenticationTestPrincipalApiApi(config);
            var principalName = "principalName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var accessRequest = new AccessRequest?(); // AccessRequest? |  (optional) 

            try
            {
                AccessReportJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestMonitoredObjectPost(principalName, baseMonitorName, accessRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationTestPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestMonitoredObjectPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestMonitoredObjectPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AccessReportJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestMonitoredObjectPostWithHttpInfo(principalName, baseMonitorName, accessRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationTestPrincipalApiApi.ApiBasemonitorsBaseMonitorNameAuthenticationPrincipalsPrincipalNameTestMonitoredObjectPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **principalName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **accessRequest** | [**AccessRequest?**](AccessRequest?.md) |  | [optional]  |

### Return type

[**AccessReportJSendSuccess**](AccessReportJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

