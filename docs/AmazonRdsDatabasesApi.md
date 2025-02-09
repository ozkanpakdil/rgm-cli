# cli.Api.AmazonRdsDatabasesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesDatabaseNameGet**](AmazonRdsDatabasesApi.md#apibasemonitorsbasemonitornameamazonrdssqlserversservernamedatabasesdatabasenameget) | **GET** /api/basemonitors/{baseMonitorName}/amazonrdssqlservers/{serverName}/databases/{databaseName} |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesGet**](AmazonRdsDatabasesApi.md#apibasemonitorsbasemonitornameamazonrdssqlserversservernamedatabasesget) | **GET** /api/basemonitors/{baseMonitorName}/amazonrdssqlservers/{serverName}/databases |  |

<a id="apibasemonitorsbasemonitornameamazonrdssqlserversservernamedatabasesdatabasenameget"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesDatabaseNameGet**
> void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesDatabaseNameGet (string serverName, string databaseName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesDatabaseNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsDatabasesApi(config);
            var serverName = "serverName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesDatabaseNameGet(serverName, databaseName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsDatabasesApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesDatabaseNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesDatabaseNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesDatabaseNameGetWithHttpInfo(serverName, databaseName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsDatabasesApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesDatabaseNameGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornameamazonrdssqlserversservernamedatabasesget"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesGet**
> void ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesGet (string serverName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsDatabasesApi(config);
            var serverName = "serverName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesGet(serverName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsDatabasesApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesGetWithHttpInfo(serverName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsDatabasesApi.ApiBasemonitorsBaseMonitorNameAmazonrdssqlserversServerNameDatabasesGetWithHttpInfo: " + e.Message);
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

