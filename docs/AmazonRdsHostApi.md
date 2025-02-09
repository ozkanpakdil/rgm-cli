# cli.Api.AmazonRdsHostApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiAmazonrdshostsRegionsGet**](AmazonRdsHostApi.md#apiamazonrdshostsregionsget) | **GET** /api/amazonrdshosts/regions |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePostgresinstancesGet**](AmazonRdsHostApi.md#apibasemonitorsbasemonitornameamazonrdshostsamazonrdshostnamepostgresinstancesget) | **GET** /api/basemonitors/{baseMonitorName}/amazonrdshosts/{amazonRdsHostName}/postgresinstances |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePut**](AmazonRdsHostApi.md#apibasemonitorsbasemonitornameamazonrdshostsamazonrdshostnameput) | **PUT** /api/basemonitors/{baseMonitorName}/amazonrdshosts/{amazonRdsHostName} |  |
| [**ApiBasemonitorsBaseMonitorNameAmazonrdshostsGet**](AmazonRdsHostApi.md#apibasemonitorsbasemonitornameamazonrdshostsget) | **GET** /api/basemonitors/{baseMonitorName}/amazonrdshosts |  |

<a id="apiamazonrdshostsregionsget"></a>
# **ApiAmazonrdshostsRegionsGet**
> AmazonRdsHostRegionDtoArrayJSendSuccess ApiAmazonrdshostsRegionsGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAmazonrdshostsRegionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsHostApi(config);

            try
            {
                AmazonRdsHostRegionDtoArrayJSendSuccess result = apiInstance.ApiAmazonrdshostsRegionsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsHostApi.ApiAmazonrdshostsRegionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAmazonrdshostsRegionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AmazonRdsHostRegionDtoArrayJSendSuccess> response = apiInstance.ApiAmazonrdshostsRegionsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsHostApi.ApiAmazonrdshostsRegionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AmazonRdsHostRegionDtoArrayJSendSuccess**](AmazonRdsHostRegionDtoArrayJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameamazonrdshostsamazonrdshostnamepostgresinstancesget"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePostgresinstancesGet**
> void ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePostgresinstancesGet (string amazonRdsHostName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePostgresinstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsHostApi(config);
            var amazonRdsHostName = "amazonRdsHostName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePostgresinstancesGet(amazonRdsHostName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsHostApi.ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePostgresinstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePostgresinstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePostgresinstancesGetWithHttpInfo(amazonRdsHostName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsHostApi.ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePostgresinstancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonRdsHostName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameamazonrdshostsamazonrdshostnameput"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePut**
> void ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePut (string amazonRdsHostName, string baseMonitorName, AmazonRdsHostDto? amazonRdsHostDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsHostApi(config);
            var amazonRdsHostName = "amazonRdsHostName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var amazonRdsHostDto = new AmazonRdsHostDto?(); // AmazonRdsHostDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePut(amazonRdsHostName, baseMonitorName, amazonRdsHostDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsHostApi.ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePutWithHttpInfo(amazonRdsHostName, baseMonitorName, amazonRdsHostDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsHostApi.ApiBasemonitorsBaseMonitorNameAmazonrdshostsAmazonRdsHostNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **amazonRdsHostName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **amazonRdsHostDto** | [**AmazonRdsHostDto?**](AmazonRdsHostDto?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameamazonrdshostsget"></a>
# **ApiBasemonitorsBaseMonitorNameAmazonrdshostsGet**
> void ApiBasemonitorsBaseMonitorNameAmazonrdshostsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameAmazonrdshostsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AmazonRdsHostApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdshostsGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmazonRdsHostApi.ApiBasemonitorsBaseMonitorNameAmazonrdshostsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameAmazonrdshostsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameAmazonrdshostsGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmazonRdsHostApi.ApiBasemonitorsBaseMonitorNameAmazonrdshostsGetWithHttpInfo: " + e.Message);
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

