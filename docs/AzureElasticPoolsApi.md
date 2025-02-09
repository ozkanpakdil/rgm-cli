# cli.Api.AzureElasticPoolsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameGet**](AzureElasticPoolsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolselasticpoolnameget) | **GET** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/elasticpools/{elasticPoolName} |  |
| [**ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsGet**](AzureElasticPoolsApi.md#apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolsget) | **GET** /api/basemonitors/{baseMonitorName}/azuresqlservers/{serverName}/elasticpools |  |

<a id="apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolselasticpoolnameget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameGet**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameGet (string serverName, string elasticPoolName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureElasticPoolsApi(config);
            var serverName = "serverName_example";  // string | 
            var elasticPoolName = "elasticPoolName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameGet(serverName, elasticPoolName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureElasticPoolsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameGetWithHttpInfo(serverName, elasticPoolName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureElasticPoolsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsElasticPoolNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **elasticPoolName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameazuresqlserversservernameelasticpoolsget"></a>
# **ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsGet**
> void ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsGet (string serverName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureElasticPoolsApi(config);
            var serverName = "serverName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsGet(serverName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureElasticPoolsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsGetWithHttpInfo(serverName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureElasticPoolsApi.ApiBasemonitorsBaseMonitorNameAzuresqlserversServerNameElasticpoolsGetWithHttpInfo: " + e.Message);
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

