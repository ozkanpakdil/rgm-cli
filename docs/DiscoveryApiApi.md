# cli.Api.DiscoveryApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelDiscovery**](DiscoveryApiApi.md#canceldiscovery) | **POST** /api/basemonitors/{baseMonitorName}/discovery/cancel |  |
| [**DownloadDiscovery**](DiscoveryApiApi.md#downloaddiscovery) | **GET** /api/basemonitors/{baseMonitorName}/discovery/download |  |
| [**GetAzureDetectionResult**](DiscoveryApiApi.md#getazuredetectionresult) | **POST** /api/basemonitors/{baseMonitorName}/discovery/getazure |  |
| [**GetDiscoveryResult**](DiscoveryApiApi.md#getdiscoveryresult) | **GET** /api/basemonitors/{baseMonitorName}/discovery |  |
| [**GetRdsDetectionResult**](DiscoveryApiApi.md#getrdsdetectionresult) | **POST** /api/basemonitors/{baseMonitorName}/discovery/getrds |  |
| [**StartDiscovery**](DiscoveryApiApi.md#startdiscovery) | **POST** /api/basemonitors/{baseMonitorName}/discovery/start |  |

<a id="canceldiscovery"></a>
# **CancelDiscovery**
> UnitJSendSuccess CancelDiscovery (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class CancelDiscoveryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DiscoveryApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                UnitJSendSuccess result = apiInstance.CancelDiscovery(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscoveryApiApi.CancelDiscovery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelDiscoveryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UnitJSendSuccess> response = apiInstance.CancelDiscoveryWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscoveryApiApi.CancelDiscoveryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**UnitJSendSuccess**](UnitJSendSuccess.md)

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

<a id="downloaddiscovery"></a>
# **DownloadDiscovery**
> void DownloadDiscovery (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class DownloadDiscoveryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DiscoveryApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.DownloadDiscovery(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscoveryApiApi.DownloadDiscovery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadDiscoveryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DownloadDiscoveryWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscoveryApiApi.DownloadDiscoveryWithHttpInfo: " + e.Message);
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
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getazuredetectionresult"></a>
# **GetAzureDetectionResult**
> void GetAzureDetectionResult (string baseMonitorName, AzureDetectionOptionsDto? azureDetectionOptionsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetAzureDetectionResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DiscoveryApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var azureDetectionOptionsDto = new AzureDetectionOptionsDto?(); // AzureDetectionOptionsDto? |  (optional) 

            try
            {
                apiInstance.GetAzureDetectionResult(baseMonitorName, azureDetectionOptionsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscoveryApiApi.GetAzureDetectionResult: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAzureDetectionResultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetAzureDetectionResultWithHttpInfo(baseMonitorName, azureDetectionOptionsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscoveryApiApi.GetAzureDetectionResultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **azureDetectionOptionsDto** | [**AzureDetectionOptionsDto?**](AzureDetectionOptionsDto?.md) |  | [optional]  |

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

<a id="getdiscoveryresult"></a>
# **GetDiscoveryResult**
> DiscoveryResultDtoJSendSuccess GetDiscoveryResult (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetDiscoveryResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DiscoveryApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                DiscoveryResultDtoJSendSuccess result = apiInstance.GetDiscoveryResult(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscoveryApiApi.GetDiscoveryResult: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDiscoveryResultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiscoveryResultDtoJSendSuccess> response = apiInstance.GetDiscoveryResultWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscoveryApiApi.GetDiscoveryResultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**DiscoveryResultDtoJSendSuccess**](DiscoveryResultDtoJSendSuccess.md)

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

<a id="getrdsdetectionresult"></a>
# **GetRdsDetectionResult**
> void GetRdsDetectionResult (string baseMonitorName, RdsDetectionOptionsDto? rdsDetectionOptionsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetRdsDetectionResultExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DiscoveryApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var rdsDetectionOptionsDto = new RdsDetectionOptionsDto?(); // RdsDetectionOptionsDto? |  (optional) 

            try
            {
                apiInstance.GetRdsDetectionResult(baseMonitorName, rdsDetectionOptionsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscoveryApiApi.GetRdsDetectionResult: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRdsDetectionResultWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetRdsDetectionResultWithHttpInfo(baseMonitorName, rdsDetectionOptionsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscoveryApiApi.GetRdsDetectionResultWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **rdsDetectionOptionsDto** | [**RdsDetectionOptionsDto?**](RdsDetectionOptionsDto?.md) |  | [optional]  |

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

<a id="startdiscovery"></a>
# **StartDiscovery**
> UnitJSendSuccess StartDiscovery (string baseMonitorName, DiscoveryOptionsDto? discoveryOptionsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class StartDiscoveryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DiscoveryApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var discoveryOptionsDto = new DiscoveryOptionsDto?(); // DiscoveryOptionsDto? |  (optional) 

            try
            {
                UnitJSendSuccess result = apiInstance.StartDiscovery(baseMonitorName, discoveryOptionsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DiscoveryApiApi.StartDiscovery: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StartDiscoveryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<UnitJSendSuccess> response = apiInstance.StartDiscoveryWithHttpInfo(baseMonitorName, discoveryOptionsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DiscoveryApiApi.StartDiscoveryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **discoveryOptionsDto** | [**DiscoveryOptionsDto?**](DiscoveryOptionsDto?.md) |  | [optional]  |

### Return type

[**UnitJSendSuccess**](UnitJSendSuccess.md)

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

