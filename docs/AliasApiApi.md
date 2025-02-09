# cli.Api.AliasApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameMonitoredentitiesAliasPost**](AliasApiApi.md#apibasemonitorsbasemonitornamemonitoredentitiesaliaspost) | **POST** /api/basemonitors/{baseMonitorName}/monitoredentities/alias |  |

<a id="apibasemonitorsbasemonitornamemonitoredentitiesaliaspost"></a>
# **ApiBasemonitorsBaseMonitorNameMonitoredentitiesAliasPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameMonitoredentitiesAliasPost (string baseMonitorName, SaveAliasRequest? saveAliasRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMonitoredentitiesAliasPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AliasApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var saveAliasRequest = new SaveAliasRequest?(); // SaveAliasRequest? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredentitiesAliasPost(baseMonitorName, saveAliasRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AliasApiApi.ApiBasemonitorsBaseMonitorNameMonitoredentitiesAliasPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMonitoredentitiesAliasPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameMonitoredentitiesAliasPostWithHttpInfo(baseMonitorName, saveAliasRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AliasApiApi.ApiBasemonitorsBaseMonitorNameMonitoredentitiesAliasPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **saveAliasRequest** | [**SaveAliasRequest?**](SaveAliasRequest?.md) |  | [optional]  |

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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

