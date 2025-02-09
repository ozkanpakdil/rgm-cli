# cli.Api.ConfigurationComplianceApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameConfigurationcomplianceDatabaseconfigurationoptionsCollectionDateGet**](ConfigurationComplianceApiApi.md#apibasemonitorsbasemonitornameconfigurationcompliancedatabaseconfigurationoptionscollectiondateget) | **GET** /api/basemonitors/{baseMonitorName}/configurationcompliance/databaseconfigurationoptions/{collectionDate} |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationcomplianceServerconfigurationoptionsCollectionDateGet**](ConfigurationComplianceApiApi.md#apibasemonitorsbasemonitornameconfigurationcomplianceserverconfigurationoptionscollectiondateget) | **GET** /api/basemonitors/{baseMonitorName}/configurationcompliance/serverconfigurationoptions/{collectionDate} |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesGet**](ConfigurationComplianceApiApi.md#apibasemonitorsbasemonitornameconfigurationcompliancetemplatesget) | **GET** /api/basemonitors/{baseMonitorName}/configurationcompliance/templates |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesIdPut**](ConfigurationComplianceApiApi.md#apibasemonitorsbasemonitornameconfigurationcompliancetemplatesidput) | **PUT** /api/basemonitors/{baseMonitorName}/configurationcompliance/templates/{id} |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesPost**](ConfigurationComplianceApiApi.md#apibasemonitorsbasemonitornameconfigurationcompliancetemplatespost) | **POST** /api/basemonitors/{baseMonitorName}/configurationcompliance/templates |  |
| [**ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesTemplateIdDelete**](ConfigurationComplianceApiApi.md#apibasemonitorsbasemonitornameconfigurationcompliancetemplatestemplateiddelete) | **DELETE** /api/basemonitors/{baseMonitorName}/configurationcompliance/templates/{templateId} |  |

<a id="apibasemonitorsbasemonitornameconfigurationcompliancedatabaseconfigurationoptionscollectiondateget"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationcomplianceDatabaseconfigurationoptionsCollectionDateGet**
> DatabaseConfigurationDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationcomplianceDatabaseconfigurationoptionsCollectionDateGet (DateTime collectionDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationcomplianceDatabaseconfigurationoptionsCollectionDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigurationComplianceApiApi(config);
            var collectionDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                DatabaseConfigurationDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceDatabaseconfigurationoptionsCollectionDateGet(collectionDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationComplianceApiApi.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceDatabaseconfigurationoptionsCollectionDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationcomplianceDatabaseconfigurationoptionsCollectionDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DatabaseConfigurationDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceDatabaseconfigurationoptionsCollectionDateGetWithHttpInfo(collectionDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationComplianceApiApi.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceDatabaseconfigurationoptionsCollectionDateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionDate** | **DateTime** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**DatabaseConfigurationDtoIEnumerableJSendSuccess**](DatabaseConfigurationDtoIEnumerableJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameconfigurationcomplianceserverconfigurationoptionscollectiondateget"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationcomplianceServerconfigurationoptionsCollectionDateGet**
> ConfigurationComplianceDtoJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationcomplianceServerconfigurationoptionsCollectionDateGet (DateTime collectionDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationcomplianceServerconfigurationoptionsCollectionDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigurationComplianceApiApi(config);
            var collectionDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                ConfigurationComplianceDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceServerconfigurationoptionsCollectionDateGet(collectionDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationComplianceApiApi.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceServerconfigurationoptionsCollectionDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationcomplianceServerconfigurationoptionsCollectionDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConfigurationComplianceDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceServerconfigurationoptionsCollectionDateGetWithHttpInfo(collectionDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationComplianceApiApi.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceServerconfigurationoptionsCollectionDateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **collectionDate** | **DateTime** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**ConfigurationComplianceDtoJSendSuccess**](ConfigurationComplianceDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameconfigurationcompliancetemplatesget"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesGet**
> ConfigurationComplianceTemplateDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigurationComplianceApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                ConfigurationComplianceTemplateDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationComplianceApiApi.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConfigurationComplianceTemplateDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationComplianceApiApi.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**ConfigurationComplianceTemplateDtoIEnumerableJSendSuccess**](ConfigurationComplianceTemplateDtoIEnumerableJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameconfigurationcompliancetemplatesidput"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesIdPut**
> ConfigurationComplianceTemplateDtoJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesIdPut (Guid id, string baseMonitorName, ConfigurationComplianceTemplateCreateDto? configurationComplianceTemplateCreateDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigurationComplianceApiApi(config);
            var id = "id_example";  // Guid | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var configurationComplianceTemplateCreateDto = new ConfigurationComplianceTemplateCreateDto?(); // ConfigurationComplianceTemplateCreateDto? |  (optional) 

            try
            {
                ConfigurationComplianceTemplateDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesIdPut(id, baseMonitorName, configurationComplianceTemplateCreateDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationComplianceApiApi.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConfigurationComplianceTemplateDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesIdPutWithHttpInfo(id, baseMonitorName, configurationComplianceTemplateCreateDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationComplianceApiApi.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesIdPutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **baseMonitorName** | **string** |  |  |
| **configurationComplianceTemplateCreateDto** | [**ConfigurationComplianceTemplateCreateDto?**](ConfigurationComplianceTemplateCreateDto?.md) |  | [optional]  |

### Return type

[**ConfigurationComplianceTemplateDtoJSendSuccess**](ConfigurationComplianceTemplateDtoJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Content |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameconfigurationcompliancetemplatespost"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesPost**
> ConfigurationComplianceTemplateDtoJSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesPost (string baseMonitorName, ConfigurationComplianceTemplateCreateDto? configurationComplianceTemplateCreateDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigurationComplianceApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var configurationComplianceTemplateCreateDto = new ConfigurationComplianceTemplateCreateDto?(); // ConfigurationComplianceTemplateCreateDto? |  (optional) 

            try
            {
                ConfigurationComplianceTemplateDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesPost(baseMonitorName, configurationComplianceTemplateCreateDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationComplianceApiApi.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ConfigurationComplianceTemplateDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesPostWithHttpInfo(baseMonitorName, configurationComplianceTemplateCreateDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationComplianceApiApi.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **configurationComplianceTemplateCreateDto** | [**ConfigurationComplianceTemplateCreateDto?**](ConfigurationComplianceTemplateCreateDto?.md) |  | [optional]  |

### Return type

[**ConfigurationComplianceTemplateDtoJSendSuccess**](ConfigurationComplianceTemplateDtoJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **409** | Conflict |  -  |
| **422** | Unprocessable Content |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameconfigurationcompliancetemplatestemplateiddelete"></a>
# **ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesTemplateIdDelete**
> JSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesTemplateIdDelete (Guid templateId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesTemplateIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigurationComplianceApiApi(config);
            var templateId = "templateId_example";  // Guid | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesTemplateIdDelete(templateId, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigurationComplianceApiApi.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesTemplateIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesTemplateIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesTemplateIdDeleteWithHttpInfo(templateId, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigurationComplianceApiApi.ApiBasemonitorsBaseMonitorNameConfigurationcomplianceTemplatesTemplateIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **Guid** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**JSendSuccess**](JSendSuccess.md)

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

