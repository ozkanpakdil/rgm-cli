# cli.Api.PostgresDatabasesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNamePostgresdatabaseoverviewGet**](PostgresDatabasesApi.md#apibasemonitorsbasemonitornamepostgresdatabaseoverviewget) | **GET** /api/basemonitors/{baseMonitorName}/postgresdatabaseoverview |  |
| [**ApiBasemonitorsBaseMonitorNamePostgresserversServerNameDatabasesGet**](PostgresDatabasesApi.md#apibasemonitorsbasemonitornamepostgresserversservernamedatabasesget) | **GET** /api/basemonitors/{baseMonitorName}/postgresservers/{serverName}/databases |  |

<a id="apibasemonitorsbasemonitornamepostgresdatabaseoverviewget"></a>
# **ApiBasemonitorsBaseMonitorNamePostgresdatabaseoverviewGet**
> void ApiBasemonitorsBaseMonitorNamePostgresdatabaseoverviewGet (string baseMonitorName, PostgresInstanceDatabaseChannelInstanceRef? databaseCir = null, long? startTime = null, long? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePostgresdatabaseoverviewGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PostgresDatabasesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var databaseCir = new PostgresInstanceDatabaseChannelInstanceRef?(); // PostgresInstanceDatabaseChannelInstanceRef? |  (optional) 
            var startTime = 789L;  // long? |  (optional) 
            var endTime = 789L;  // long? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNamePostgresdatabaseoverviewGet(baseMonitorName, databaseCir, startTime, endTime);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostgresDatabasesApi.ApiBasemonitorsBaseMonitorNamePostgresdatabaseoverviewGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePostgresdatabaseoverviewGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNamePostgresdatabaseoverviewGetWithHttpInfo(baseMonitorName, databaseCir, startTime, endTime);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostgresDatabasesApi.ApiBasemonitorsBaseMonitorNamePostgresdatabaseoverviewGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **databaseCir** | [**PostgresInstanceDatabaseChannelInstanceRef?**](PostgresInstanceDatabaseChannelInstanceRef?.md) |  | [optional]  |
| **startTime** | **long?** |  | [optional]  |
| **endTime** | **long?** |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornamepostgresserversservernamedatabasesget"></a>
# **ApiBasemonitorsBaseMonitorNamePostgresserversServerNameDatabasesGet**
> void ApiBasemonitorsBaseMonitorNamePostgresserversServerNameDatabasesGet (string serverName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePostgresserversServerNameDatabasesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PostgresDatabasesApi(config);
            var serverName = "serverName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNamePostgresserversServerNameDatabasesGet(serverName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostgresDatabasesApi.ApiBasemonitorsBaseMonitorNamePostgresserversServerNameDatabasesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePostgresserversServerNameDatabasesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNamePostgresserversServerNameDatabasesGetWithHttpInfo(serverName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostgresDatabasesApi.ApiBasemonitorsBaseMonitorNamePostgresserversServerNameDatabasesGetWithHttpInfo: " + e.Message);
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

