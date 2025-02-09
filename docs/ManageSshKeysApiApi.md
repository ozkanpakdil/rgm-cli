# cli.Api.ManageSshKeysApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameSshkeysGet**](ManageSshKeysApiApi.md#apibasemonitorsbasemonitornamesshkeysget) | **GET** /api/basemonitors/{baseMonitorName}/sshkeys |  |
| [**ApiBasemonitorsBaseMonitorNameSshkeysIdDelete**](ManageSshKeysApiApi.md#apibasemonitorsbasemonitornamesshkeysiddelete) | **DELETE** /api/basemonitors/{baseMonitorName}/sshkeys/{id} |  |
| [**ApiBasemonitorsBaseMonitorNameSshkeysIdGet**](ManageSshKeysApiApi.md#apibasemonitorsbasemonitornamesshkeysidget) | **GET** /api/basemonitors/{baseMonitorName}/sshkeys/{id} |  |
| [**ApiBasemonitorsBaseMonitorNameSshkeysPost**](ManageSshKeysApiApi.md#apibasemonitorsbasemonitornamesshkeyspost) | **POST** /api/basemonitors/{baseMonitorName}/sshkeys |  |

<a id="apibasemonitorsbasemonitornamesshkeysget"></a>
# **ApiBasemonitorsBaseMonitorNameSshkeysGet**
> SshPrivateKeyDtoArrayJSendSuccess ApiBasemonitorsBaseMonitorNameSshkeysGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameSshkeysGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageSshKeysApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                SshPrivateKeyDtoArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameSshkeysGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageSshKeysApiApi.ApiBasemonitorsBaseMonitorNameSshkeysGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameSshkeysGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SshPrivateKeyDtoArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameSshkeysGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageSshKeysApiApi.ApiBasemonitorsBaseMonitorNameSshkeysGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**SshPrivateKeyDtoArrayJSendSuccess**](SshPrivateKeyDtoArrayJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamesshkeysiddelete"></a>
# **ApiBasemonitorsBaseMonitorNameSshkeysIdDelete**
> JSendSuccess ApiBasemonitorsBaseMonitorNameSshkeysIdDelete (Guid id, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameSshkeysIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageSshKeysApiApi(config);
            var id = "id_example";  // Guid | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameSshkeysIdDelete(id, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageSshKeysApiApi.ApiBasemonitorsBaseMonitorNameSshkeysIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameSshkeysIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameSshkeysIdDeleteWithHttpInfo(id, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageSshKeysApiApi.ApiBasemonitorsBaseMonitorNameSshkeysIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
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

<a id="apibasemonitorsbasemonitornamesshkeysidget"></a>
# **ApiBasemonitorsBaseMonitorNameSshkeysIdGet**
> SshPrivateKeyDtoJSendSuccess ApiBasemonitorsBaseMonitorNameSshkeysIdGet (Guid id, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameSshkeysIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageSshKeysApiApi(config);
            var id = "id_example";  // Guid | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                SshPrivateKeyDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameSshkeysIdGet(id, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageSshKeysApiApi.ApiBasemonitorsBaseMonitorNameSshkeysIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameSshkeysIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SshPrivateKeyDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameSshkeysIdGetWithHttpInfo(id, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageSshKeysApiApi.ApiBasemonitorsBaseMonitorNameSshkeysIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**SshPrivateKeyDtoJSendSuccess**](SshPrivateKeyDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamesshkeyspost"></a>
# **ApiBasemonitorsBaseMonitorNameSshkeysPost**
> JSendSuccess ApiBasemonitorsBaseMonitorNameSshkeysPost (string baseMonitorName, CreateSshPrivateKeyCommandDto? createSshPrivateKeyCommandDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameSshkeysPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageSshKeysApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var createSshPrivateKeyCommandDto = new CreateSshPrivateKeyCommandDto?(); // CreateSshPrivateKeyCommandDto? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameSshkeysPost(baseMonitorName, createSshPrivateKeyCommandDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageSshKeysApiApi.ApiBasemonitorsBaseMonitorNameSshkeysPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameSshkeysPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameSshkeysPostWithHttpInfo(baseMonitorName, createSshPrivateKeyCommandDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageSshKeysApiApi.ApiBasemonitorsBaseMonitorNameSshkeysPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **createSshPrivateKeyCommandDto** | [**CreateSshPrivateKeyCommandDto?**](CreateSshPrivateKeyCommandDto?.md) |  | [optional]  |

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

