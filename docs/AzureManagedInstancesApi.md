# cli.Api.AzureManagedInstancesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameDelete**](AzureManagedInstancesApi.md#apibasemonitorsbasemonitornameazuremanagedinstancesazuremanagedinstancenamedelete) | **DELETE** /api/basemonitors/{baseMonitorName}/azuremanagedinstances/{azureManagedInstanceName} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameGet**](AzureManagedInstancesApi.md#apibasemonitorsbasemonitornameazuremanagedinstancesazuremanagedinstancenameget) | **GET** /api/basemonitors/{baseMonitorName}/azuremanagedinstances/{azureManagedInstanceName} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesGet**](AzureManagedInstancesApi.md#apibasemonitorsbasemonitornameazuremanagedinstancesget) | **GET** /api/basemonitors/{baseMonitorName}/azuremanagedinstances |  |
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesInstanceNamePut**](AzureManagedInstancesApi.md#apibasemonitorsbasemonitornameazuremanagedinstancesinstancenameput) | **PUT** /api/basemonitors/{baseMonitorName}/azuremanagedinstances/{instanceName} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesPost**](AzureManagedInstancesApi.md#apibasemonitorsbasemonitornameazuremanagedinstancespost) | **POST** /api/basemonitors/{baseMonitorName}/azuremanagedinstances |  |
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesValidatePost**](AzureManagedInstancesApi.md#apibasemonitorsbasemonitornameazuremanagedinstancesvalidatepost) | **POST** /api/basemonitors/{baseMonitorName}/azuremanagedinstances/validate |  |

<a id="apibasemonitorsbasemonitornameazuremanagedinstancesazuremanagedinstancenamedelete"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameDelete**
> void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameDelete (string azureManagedInstanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstancesApi(config);
            var azureManagedInstanceName = "azureManagedInstanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameDelete(azureManagedInstanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstancesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameDeleteWithHttpInfo(azureManagedInstanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstancesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **azureManagedInstanceName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameazuremanagedinstancesazuremanagedinstancenameget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameGet**
> void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameGet (string azureManagedInstanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstancesApi(config);
            var azureManagedInstanceName = "azureManagedInstanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameGet(azureManagedInstanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstancesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameGetWithHttpInfo(azureManagedInstanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstancesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesAzureManagedInstanceNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **azureManagedInstanceName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameazuremanagedinstancesget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesGet**
> void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstancesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstancesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstancesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameazuremanagedinstancesinstancenameput"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesInstanceNamePut**
> void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesInstanceNamePut (string instanceName, string baseMonitorName, AzureManagedInstanceDto? azureManagedInstanceDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesInstanceNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstancesApi(config);
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var azureManagedInstanceDto = new AzureManagedInstanceDto?(); // AzureManagedInstanceDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesInstanceNamePut(instanceName, baseMonitorName, azureManagedInstanceDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstancesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesInstanceNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesInstanceNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesInstanceNamePutWithHttpInfo(instanceName, baseMonitorName, azureManagedInstanceDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstancesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesInstanceNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **azureManagedInstanceDto** | [**AzureManagedInstanceDto?**](AzureManagedInstanceDto?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameazuremanagedinstancespost"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesPost**
> AzureManagedInstanceDtoJSendSuccess ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesPost (string baseMonitorName, AddAzureManagedInstanceCommandDto? addAzureManagedInstanceCommandDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstancesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var addAzureManagedInstanceCommandDto = new AddAzureManagedInstanceCommandDto?(); // AddAzureManagedInstanceCommandDto? |  (optional) 

            try
            {
                AzureManagedInstanceDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesPost(baseMonitorName, addAzureManagedInstanceCommandDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstancesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AzureManagedInstanceDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesPostWithHttpInfo(baseMonitorName, addAzureManagedInstanceCommandDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstancesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **addAzureManagedInstanceCommandDto** | [**AddAzureManagedInstanceCommandDto?**](AddAzureManagedInstanceCommandDto?.md) |  | [optional]  |

### Return type

[**AzureManagedInstanceDtoJSendSuccess**](AzureManagedInstanceDtoJSendSuccess.md)

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
| **422** | Unprocessable Content |  -  |
| **409** | Conflict |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameazuremanagedinstancesvalidatepost"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesValidatePost**
> void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesValidatePost (string baseMonitorName, AddAzureManagedInstanceCommandDto? addAzureManagedInstanceCommandDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesValidatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstancesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var addAzureManagedInstanceCommandDto = new AddAzureManagedInstanceCommandDto?(); // AddAzureManagedInstanceCommandDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesValidatePost(baseMonitorName, addAzureManagedInstanceCommandDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstancesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesValidatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesValidatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesValidatePostWithHttpInfo(baseMonitorName, addAzureManagedInstanceCommandDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstancesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesValidatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **addAzureManagedInstanceCommandDto** | [**AddAzureManagedInstanceCommandDto?**](AddAzureManagedInstanceCommandDto?.md) |  | [optional]  |

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

