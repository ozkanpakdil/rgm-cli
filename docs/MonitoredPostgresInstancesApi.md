# cli.Api.MonitoredPostgresInstancesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNamePostgresinstancesInstanceNamePut**](MonitoredPostgresInstancesApi.md#apibasemonitorsbasemonitornamepostgresinstancesinstancenameput) | **PUT** /api/basemonitors/{baseMonitorName}/postgresinstances/{instanceName} |  |
| [**ApiBasemonitorsBaseMonitorNamePostgresinstancesPost**](MonitoredPostgresInstancesApi.md#apibasemonitorsbasemonitornamepostgresinstancespost) | **POST** /api/basemonitors/{baseMonitorName}/postgresinstances |  |

<a id="apibasemonitorsbasemonitornamepostgresinstancesinstancenameput"></a>
# **ApiBasemonitorsBaseMonitorNamePostgresinstancesInstanceNamePut**
> void ApiBasemonitorsBaseMonitorNamePostgresinstancesInstanceNamePut (string instanceName, string baseMonitorName, PostgresServerAliasUpdateDto? postgresServerAliasUpdateDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePostgresinstancesInstanceNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MonitoredPostgresInstancesApi(config);
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var postgresServerAliasUpdateDto = new PostgresServerAliasUpdateDto?(); // PostgresServerAliasUpdateDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNamePostgresinstancesInstanceNamePut(instanceName, baseMonitorName, postgresServerAliasUpdateDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoredPostgresInstancesApi.ApiBasemonitorsBaseMonitorNamePostgresinstancesInstanceNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePostgresinstancesInstanceNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNamePostgresinstancesInstanceNamePutWithHttpInfo(instanceName, baseMonitorName, postgresServerAliasUpdateDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MonitoredPostgresInstancesApi.ApiBasemonitorsBaseMonitorNamePostgresinstancesInstanceNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instanceName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **postgresServerAliasUpdateDto** | [**PostgresServerAliasUpdateDto?**](PostgresServerAliasUpdateDto?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornamepostgresinstancespost"></a>
# **ApiBasemonitorsBaseMonitorNamePostgresinstancesPost**
> AddPostgresInstanceResultJSendSuccess ApiBasemonitorsBaseMonitorNamePostgresinstancesPost (string baseMonitorName, AddPostgresInstanceRequest? addPostgresInstanceRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePostgresinstancesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new MonitoredPostgresInstancesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var addPostgresInstanceRequest = new AddPostgresInstanceRequest?(); // AddPostgresInstanceRequest? |  (optional) 

            try
            {
                AddPostgresInstanceResultJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresinstancesPost(baseMonitorName, addPostgresInstanceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MonitoredPostgresInstancesApi.ApiBasemonitorsBaseMonitorNamePostgresinstancesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePostgresinstancesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AddPostgresInstanceResultJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresinstancesPostWithHttpInfo(baseMonitorName, addPostgresInstanceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MonitoredPostgresInstancesApi.ApiBasemonitorsBaseMonitorNamePostgresinstancesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **addPostgresInstanceRequest** | [**AddPostgresInstanceRequest?**](AddPostgresInstanceRequest?.md) |  | [optional]  |

### Return type

[**AddPostgresInstanceResultJSendSuccess**](AddPostgresInstanceResultJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **422** | Unprocessable Content |  -  |
| **409** | Conflict |  -  |
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

