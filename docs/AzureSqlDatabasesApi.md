# cli.Api.AzureSqlDatabasesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameGet**](AzureSqlDatabasesApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenameget) | **GET** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/databases/{databaseName} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNamePut**](AzureSqlDatabasesApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenameput) | **PUT** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/databases/{databaseName} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesGet**](AzureSqlDatabasesApi.md#apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesget) | **GET** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/databases |  |

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenameget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameGet**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameGet (string serverName, string databaseName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlDatabasesApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameGet(serverName, databaseName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlDatabasesApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameGetWithHttpInfo(serverName, databaseName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlDatabasesApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **databaseName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesdatabasenameput"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNamePut**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNamePut (string serverName, string databaseName, string baseMonitorName, AzureSqlDatabaseDto? azureSqlDatabaseDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlDatabasesApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var azureSqlDatabaseDto = new AzureSqlDatabaseDto?(); // AzureSqlDatabaseDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNamePut(serverName, databaseName, baseMonitorName, azureSqlDatabaseDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlDatabasesApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNamePutWithHttpInfo(serverName, databaseName, baseMonitorName, azureSqlDatabaseDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlDatabasesApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesDatabaseNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **databaseName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **azureSqlDatabaseDto** | [**AzureSqlDatabaseDto?**](AzureSqlDatabaseDto?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernamedatabasesget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesGet**
> AzureSqlDatabaseDtoArrayJSendSuccess ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesGet (string serverName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureSqlDatabasesApi(config);
            var serverName = "serverName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                AzureSqlDatabaseDtoArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesGet(serverName, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureSqlDatabasesApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AzureSqlDatabaseDtoArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesGetWithHttpInfo(serverName, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureSqlDatabasesApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameDatabasesGetWithHttpInfo: " + e.Message);
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

[**AzureSqlDatabaseDtoArrayJSendSuccess**](AzureSqlDatabaseDtoArrayJSendSuccess.md)

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

