# cli.Api.AzureManagedInstanceDatabasesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameGet**](AzureManagedInstanceDatabasesApi.md#apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesdatabasenameget) | **GET** /api/basemonitors/{baseMonitorName}/azuremanagedinstances/{serverName}/databases/{databaseName} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesGet**](AzureManagedInstanceDatabasesApi.md#apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesget) | **GET** /api/basemonitors/{baseMonitorName}/azuremanagedinstances/{serverName}/databases |  |

<a id="apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesdatabasenameget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameGet**
> void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameGet (string serverName, string databaseName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstanceDatabasesApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameGet(serverName, databaseName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstanceDatabasesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameGetWithHttpInfo(serverName, databaseName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstanceDatabasesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesDatabaseNameGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornameazuremanagedinstancesservernamedatabasesget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesGet**
> void ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesGet (string serverName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureManagedInstanceDatabasesApi(config);
            var serverName = "serverName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesGet(serverName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureManagedInstanceDatabasesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesGetWithHttpInfo(serverName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureManagedInstanceDatabasesApi.ApiBasemonitorsBaseMonitorNameAzuremanagedinstancesServerNameDatabasesGetWithHttpInfo: " + e.Message);
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

