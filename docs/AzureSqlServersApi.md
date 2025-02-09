# cli.Api.AzureSqlServersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversDatabasesPost**](AzureSqlServersApi.md#apibasemonitorsbasemonitornameazuresqlserversdatabasespost) | **POST** /api/basemonitors/{baseMonitorName}/azuresqlservers/databases |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversGet**](AzureSqlServersApi.md#apibasemonitorsbasemonitornameazuresqlserversget) | **GET** /api/basemonitors/{baseMonitorName}/azuresqlservers |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesPatch**](AzureSqlServersApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamedatabasespatch) | **PATCH** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/databases |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameFetchDatabasesGet**](AzureSqlServersApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamefetchdatabasesget) | **GET** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/fetchDatabases |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameGet**](AzureSqlServersApi.md#apibasemonitorsbasemonitornameazuresqlserversservernameget) | **GET** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNamePut**](AzureSqlServersApi.md#apibasemonitorsbasemonitornameazuresqlserversservernameput) | **PUT** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName} |  |

<a id="apibasemonitorsbasemonitornameazuresqlserversdatabasespost"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversDatabasesPost**
> DetectedAzureSqlDatabaseDtoArrayJSendSuccess ApiBasemonitorsBaseMonitorNameAzuresqlserversDatabasesPost (string baseMonitorName, SelectDatabasesAzureSqlServerModel? selectDatabasesAzureSqlServerModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversDatabasesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlServersApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var selectDatabasesAzureSqlServerModel = new SelectDatabasesAzureSqlServerModel?(); // SelectDatabasesAzureSqlServerModel? |  (optional) 

            try
            {
                DetectedAzureSqlDatabaseDtoArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversDatabasesPost(baseMonitorName, selectDatabasesAzureSqlServerModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlServersApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversDatabasesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversDatabasesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DetectedAzureSqlDatabaseDtoArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversDatabasesPostWithHttpInfo(baseMonitorName, selectDatabasesAzureSqlServerModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlServersApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversDatabasesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **selectDatabasesAzureSqlServerModel** | [**SelectDatabasesAzureSqlServerModel?**](SelectDatabasesAzureSqlServerModel?.md) |  | [optional]  |

### Return type

[**DetectedAzureSqlDatabaseDtoArrayJSendSuccess**](DetectedAzureSqlDatabaseDtoArrayJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameazuresqlserversget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversGet**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlServersApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlServersApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlServersApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamedatabasespatch"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesPatch**
> JSendSuccess ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesPatch (string serverName, string baseMonitorName, UpdateSelectedDatabasesModel? updateSelectedDatabasesModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlServersApi(config);
            var serverName = "serverName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var updateSelectedDatabasesModel = new UpdateSelectedDatabasesModel?(); // UpdateSelectedDatabasesModel? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesPatch(serverName, baseMonitorName, updateSelectedDatabasesModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlServersApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesPatchWithHttpInfo(serverName, baseMonitorName, updateSelectedDatabasesModel);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlServersApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **updateSelectedDatabasesModel** | [**UpdateSelectedDatabasesModel?**](UpdateSelectedDatabasesModel?.md) |  | [optional]  |

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
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamefetchdatabasesget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameFetchDatabasesGet**
> AzureSqlDatabasesDtoJSendSuccess ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameFetchDatabasesGet (string serverName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameFetchDatabasesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlServersApi(config);
            var serverName = "serverName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AzureSqlDatabasesDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameFetchDatabasesGet(serverName, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlServersApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameFetchDatabasesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameFetchDatabasesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AzureSqlDatabasesDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameFetchDatabasesGetWithHttpInfo(serverName, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlServersApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameFetchDatabasesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**AzureSqlDatabasesDtoJSendSuccess**](AzureSqlDatabasesDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernameget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameGet**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameGet (string baseMonitorName, string serverName, string? azureSqlServerName = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlServersApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var serverName = "serverName_example";  // string | 
            var azureSqlServerName = "azureSqlServerName_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameGet(baseMonitorName, serverName, azureSqlServerName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlServersApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameGetWithHttpInfo(baseMonitorName, serverName, azureSqlServerName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlServersApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **serverName** | **string** |  |  |
| **azureSqlServerName** | **string?** |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernameput"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNamePut**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNamePut (string serverName, string baseMonitorName, AzureSqlServerDto? azureSqlServerDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlServersApi(config);
            var serverName = "serverName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var azureSqlServerDto = new AzureSqlServerDto?(); // AzureSqlServerDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNamePut(serverName, baseMonitorName, azureSqlServerDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlServersApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNamePutWithHttpInfo(serverName, baseMonitorName, azureSqlServerDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlServersApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **azureSqlServerDto** | [**AzureSqlServerDto?**](AzureSqlServerDto?.md) |  | [optional]  |

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

