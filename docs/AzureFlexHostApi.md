# cli.Api.AzureFlexHostApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePostgresinstancesGet**](AzureFlexHostApi.md#apibasemonitorsbasemonitornameazureflexhostsazureflexhostnamepostgresinstancesget) | **GET** /api/basemonitors/{baseMonitorName}/azureflexhosts/{azureFlexHostName}/postgresinstances |  |
| [**ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePut**](AzureFlexHostApi.md#apibasemonitorsbasemonitornameazureflexhostsazureflexhostnameput) | **PUT** /api/basemonitors/{baseMonitorName}/azureflexhosts/{azureFlexHostName} |  |
| [**ApiBasemonitorsBaseMonitorNameAzureflexhostsGet**](AzureFlexHostApi.md#apibasemonitorsbasemonitornameazureflexhostsget) | **GET** /api/basemonitors/{baseMonitorName}/azureflexhosts |  |

<a id="apibasemonitorsbasemonitornameazureflexhostsazureflexhostnamepostgresinstancesget"></a>
# **ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePostgresinstancesGet**
> void ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePostgresinstancesGet (string azureFlexHostName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePostgresinstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureFlexHostApi(config);
            var azureFlexHostName = "azureFlexHostName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePostgresinstancesGet(azureFlexHostName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureFlexHostApi.ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePostgresinstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePostgresinstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePostgresinstancesGetWithHttpInfo(azureFlexHostName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureFlexHostApi.ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePostgresinstancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **azureFlexHostName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameazureflexhostsazureflexhostnameput"></a>
# **ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePut**
> void ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePut (string azureFlexHostName, string baseMonitorName, AzureFlexHostDto? azureFlexHostDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureFlexHostApi(config);
            var azureFlexHostName = "azureFlexHostName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var azureFlexHostDto = new AzureFlexHostDto?(); // AzureFlexHostDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePut(azureFlexHostName, baseMonitorName, azureFlexHostDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureFlexHostApi.ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePutWithHttpInfo(azureFlexHostName, baseMonitorName, azureFlexHostDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureFlexHostApi.ApiBasemonitorsBaseMonitorNameAzureflexhostsAzureFlexHostNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **azureFlexHostName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **azureFlexHostDto** | [**AzureFlexHostDto?**](AzureFlexHostDto?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameazureflexhostsget"></a>
# **ApiBasemonitorsBaseMonitorNameAzureflexhostsGet**
> void ApiBasemonitorsBaseMonitorNameAzureflexhostsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAzureflexhostsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AzureFlexHostApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAzureflexhostsGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AzureFlexHostApi.ApiBasemonitorsBaseMonitorNameAzureflexhostsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAzureflexhostsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAzureflexhostsGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AzureFlexHostApi.ApiBasemonitorsBaseMonitorNameAzureflexhostsGetWithHttpInfo: " + e.Message);
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

