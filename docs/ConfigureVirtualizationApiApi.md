# cli.Api.ConfigureVirtualizationApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameVmwarehostsGet**](ConfigureVirtualizationApiApi.md#apibasemonitorsbasemonitornamevmwarehostsget) | **GET** /api/basemonitors/{baseMonitorName}/vmwarehosts |  |
| [**ApiBasemonitorsBaseMonitorNameVmwarehostsServerNameDelete**](ConfigureVirtualizationApiApi.md#apibasemonitorsbasemonitornamevmwarehostsservernamedelete) | **DELETE** /api/basemonitors/{baseMonitorName}/vmwarehosts/{serverName} |  |
| [**ApiBasemonitorsBaseMonitorNameVmwarehostsServerNamePost**](ConfigureVirtualizationApiApi.md#apibasemonitorsbasemonitornamevmwarehostsservernamepost) | **POST** /api/basemonitors/{baseMonitorName}/vmwarehosts/{serverName} |  |

<a id="apibasemonitorsbasemonitornamevmwarehostsget"></a>
# **ApiBasemonitorsBaseMonitorNameVmwarehostsGet**
> VMServerStatusArrayJSendSuccess ApiBasemonitorsBaseMonitorNameVmwarehostsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameVmwarehostsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureVirtualizationApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                VMServerStatusArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameVmwarehostsGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureVirtualizationApiApi.ApiBasemonitorsBaseMonitorNameVmwarehostsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameVmwarehostsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<VMServerStatusArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameVmwarehostsGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureVirtualizationApiApi.ApiBasemonitorsBaseMonitorNameVmwarehostsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**VMServerStatusArrayJSendSuccess**](VMServerStatusArrayJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamevmwarehostsservernamedelete"></a>
# **ApiBasemonitorsBaseMonitorNameVmwarehostsServerNameDelete**
> JSendSuccess ApiBasemonitorsBaseMonitorNameVmwarehostsServerNameDelete (string serverName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameVmwarehostsServerNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureVirtualizationApiApi(config);
            var serverName = "serverName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameVmwarehostsServerNameDelete(serverName, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureVirtualizationApiApi.ApiBasemonitorsBaseMonitorNameVmwarehostsServerNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameVmwarehostsServerNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameVmwarehostsServerNameDeleteWithHttpInfo(serverName, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureVirtualizationApiApi.ApiBasemonitorsBaseMonitorNameVmwarehostsServerNameDeleteWithHttpInfo: " + e.Message);
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

[**JSendSuccess**](JSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamevmwarehostsservernamepost"></a>
# **ApiBasemonitorsBaseMonitorNameVmwarehostsServerNamePost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameVmwarehostsServerNamePost (string serverName, string baseMonitorName, VMwareCredentials? vMwareCredentials = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameVmwarehostsServerNamePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigureVirtualizationApiApi(config);
            var serverName = "serverName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var vMwareCredentials = new VMwareCredentials?(); // VMwareCredentials? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameVmwarehostsServerNamePost(serverName, baseMonitorName, vMwareCredentials);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigureVirtualizationApiApi.ApiBasemonitorsBaseMonitorNameVmwarehostsServerNamePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameVmwarehostsServerNamePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameVmwarehostsServerNamePostWithHttpInfo(serverName, baseMonitorName, vMwareCredentials);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ConfigureVirtualizationApiApi.ApiBasemonitorsBaseMonitorNameVmwarehostsServerNamePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **serverName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **vMwareCredentials** | [**VMwareCredentials?**](VMwareCredentials?.md) |  | [optional]  |

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
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

