# cli.Api.AdditionalMonitoringSettingsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsGet**](AdditionalMonitoringSettingsApiApi.md#apibasemonitorsbasemonitornameconfigurationadditionalmonitoringsettingsget) | **GET** /api/basemonitors/{baseMonitorName}/configuration/additionalMonitoringSettings |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsPost**](AdditionalMonitoringSettingsApiApi.md#apibasemonitorsbasemonitornameconfigurationadditionalmonitoringsettingspost) | **POST** /api/basemonitors/{baseMonitorName}/configuration/additionalMonitoringSettings |  |

<a id="apibasemonitorsbasemonitornameconfigurationadditionalmonitoringsettingsget"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsGet**
> AdditionalMonitoringConfigItemIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AdditionalMonitoringSettingsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AdditionalMonitoringConfigItemIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdditionalMonitoringSettingsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AdditionalMonitoringConfigItemIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdditionalMonitoringSettingsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**AdditionalMonitoringConfigItemIEnumerableJSendSuccess**](AdditionalMonitoringConfigItemIEnumerableJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameconfigurationadditionalmonitoringsettingspost"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsPost (string baseMonitorName, List<AdditionalMonitoringConfigurationEntry>? additionalMonitoringConfigurationEntry = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AdditionalMonitoringSettingsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var additionalMonitoringConfigurationEntry = new List<AdditionalMonitoringConfigurationEntry>?(); // List<AdditionalMonitoringConfigurationEntry>? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsPost(baseMonitorName, additionalMonitoringConfigurationEntry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AdditionalMonitoringSettingsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsPostWithHttpInfo(baseMonitorName, additionalMonitoringConfigurationEntry);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AdditionalMonitoringSettingsApiApi.ApiBasemonitorsBaseMonitorNameConfigurationAdditionalMonitoringSettingsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **additionalMonitoringConfigurationEntry** | [**List&lt;AdditionalMonitoringConfigurationEntry&gt;?**](AdditionalMonitoringConfigurationEntry.md) |  | [optional]  |

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
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

