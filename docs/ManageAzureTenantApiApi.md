# cli.Api.ManageAzureTenantApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAzuretenantsGet**](ManageAzureTenantApiApi.md#apibasemonitorsbasemonitornameazuretenantsget) | **GET** /api/basemonitors/{baseMonitorName}/azuretenants |  |
| [**ApiBasemonitorsBaseMonitorNameAzuretenantsIdDelete**](ManageAzureTenantApiApi.md#apibasemonitorsbasemonitornameazuretenantsiddelete) | **DELETE** /api/basemonitors/{baseMonitorName}/azuretenants/{id} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuretenantsPost**](ManageAzureTenantApiApi.md#apibasemonitorsbasemonitornameazuretenantspost) | **POST** /api/basemonitors/{baseMonitorName}/azuretenants |  |
| [**ApiBasemonitorsBaseMonitorNameAzuretenantsTestPost**](ManageAzureTenantApiApi.md#apibasemonitorsbasemonitornameazuretenantstestpost) | **POST** /api/basemonitors/{baseMonitorName}/azuretenants/test |  |

<a id="apibasemonitorsbasemonitornameazuretenantsget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuretenantsGet**
> AzureTenantDtoArrayJSendSuccess ApiBasemonitorsBaseMonitorNameAzuretenantsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuretenantsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageAzureTenantApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AzureTenantDtoArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAzuretenantsGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageAzureTenantApiApi.ApiBasemonitorsBaseMonitorNameAzuretenantsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuretenantsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AzureTenantDtoArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAzuretenantsGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageAzureTenantApiApi.ApiBasemonitorsBaseMonitorNameAzuretenantsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**AzureTenantDtoArrayJSendSuccess**](AzureTenantDtoArrayJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameazuretenantsiddelete"></a>
# **ApiBasemonitorsBaseMonitorNameAzuretenantsIdDelete**
> JSendSuccess ApiBasemonitorsBaseMonitorNameAzuretenantsIdDelete (Guid id, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuretenantsIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageAzureTenantApiApi(config);
            var id = "id_example";  // Guid | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAzuretenantsIdDelete(id, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageAzureTenantApiApi.ApiBasemonitorsBaseMonitorNameAzuretenantsIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuretenantsIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAzuretenantsIdDeleteWithHttpInfo(id, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageAzureTenantApiApi.ApiBasemonitorsBaseMonitorNameAzuretenantsIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
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

<a id="apibasemonitorsbasemonitornameazuretenantspost"></a>
# **ApiBasemonitorsBaseMonitorNameAzuretenantsPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameAzuretenantsPost (string baseMonitorName, CreateAzureTenantDto? createAzureTenantDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuretenantsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageAzureTenantApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var createAzureTenantDto = new CreateAzureTenantDto?(); // CreateAzureTenantDto? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAzuretenantsPost(baseMonitorName, createAzureTenantDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageAzureTenantApiApi.ApiBasemonitorsBaseMonitorNameAzuretenantsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuretenantsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAzuretenantsPostWithHttpInfo(baseMonitorName, createAzureTenantDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageAzureTenantApiApi.ApiBasemonitorsBaseMonitorNameAzuretenantsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **createAzureTenantDto** | [**CreateAzureTenantDto?**](CreateAzureTenantDto?.md) |  | [optional]  |

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
| **422** | Unprocessable Content |  -  |
| **409** | Conflict |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameazuretenantstestpost"></a>
# **ApiBasemonitorsBaseMonitorNameAzuretenantsTestPost**
> CloudServiceTestConnectionResultDtoJSendSuccess ApiBasemonitorsBaseMonitorNameAzuretenantsTestPost (string baseMonitorName, CreateAzureTenantDto? createAzureTenantDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuretenantsTestPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageAzureTenantApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var createAzureTenantDto = new CreateAzureTenantDto?(); // CreateAzureTenantDto? |  (optional) 

            try
            {
                CloudServiceTestConnectionResultDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAzuretenantsTestPost(baseMonitorName, createAzureTenantDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageAzureTenantApiApi.ApiBasemonitorsBaseMonitorNameAzuretenantsTestPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuretenantsTestPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CloudServiceTestConnectionResultDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAzuretenantsTestPostWithHttpInfo(baseMonitorName, createAzureTenantDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageAzureTenantApiApi.ApiBasemonitorsBaseMonitorNameAzuretenantsTestPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **createAzureTenantDto** | [**CreateAzureTenantDto?**](CreateAzureTenantDto?.md) |  | [optional]  |

### Return type

[**CloudServiceTestConnectionResultDtoJSendSuccess**](CloudServiceTestConnectionResultDtoJSendSuccess.md)

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

