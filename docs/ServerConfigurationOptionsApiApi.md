# cli.Api.ServerConfigurationOptionsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiEstateConfigurationOptionsChangesGet**](ServerConfigurationOptionsApiApi.md#apiestateconfigurationoptionschangesget) | **GET** /api/estate/configuration-options/changes |  |
| [**ApiEstateConfigurationOptionsDownloadGet**](ServerConfigurationOptionsApiApi.md#apiestateconfigurationoptionsdownloadget) | **GET** /api/estate/configuration-options/download |  |
| [**ApiEstateConfigurationOptionsNewGet**](ServerConfigurationOptionsApiApi.md#apiestateconfigurationoptionsnewget) | **GET** /api/estate/configuration-options/new |  |
| [**GetInstanceRefsForComparison**](ServerConfigurationOptionsApiApi.md#getinstancerefsforcomparison) | **GET** /api/estate/configuration-options/GetInstanceRefsForComparison |  |
| [**GetServerConfigurationOptions**](ServerConfigurationOptionsApiApi.md#getserverconfigurationoptions) | **GET** /api/estate/configuration-options/GetServerConfigurationOptions |  |

<a id="apiestateconfigurationoptionschangesget"></a>
# **ApiEstateConfigurationOptionsChangesGet**
> void ApiEstateConfigurationOptionsChangesGet (int? dateRange = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiEstateConfigurationOptionsChangesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ServerConfigurationOptionsApiApi(config);
            var dateRange = 56;  // int? |  (optional) 

            try
            {
                apiInstance.ApiEstateConfigurationOptionsChangesGet(dateRange);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServerConfigurationOptionsApiApi.ApiEstateConfigurationOptionsChangesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEstateConfigurationOptionsChangesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiEstateConfigurationOptionsChangesGetWithHttpInfo(dateRange);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServerConfigurationOptionsApiApi.ApiEstateConfigurationOptionsChangesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dateRange** | **int?** |  | [optional]  |

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

<a id="apiestateconfigurationoptionsdownloadget"></a>
# **ApiEstateConfigurationOptionsDownloadGet**
> void ApiEstateConfigurationOptionsDownloadGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiEstateConfigurationOptionsDownloadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ServerConfigurationOptionsApiApi(config);

            try
            {
                apiInstance.ApiEstateConfigurationOptionsDownloadGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServerConfigurationOptionsApiApi.ApiEstateConfigurationOptionsDownloadGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEstateConfigurationOptionsDownloadGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiEstateConfigurationOptionsDownloadGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServerConfigurationOptionsApiApi.ApiEstateConfigurationOptionsDownloadGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiestateconfigurationoptionsnewget"></a>
# **ApiEstateConfigurationOptionsNewGet**
> void ApiEstateConfigurationOptionsNewGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiEstateConfigurationOptionsNewGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ServerConfigurationOptionsApiApi(config);

            try
            {
                apiInstance.ApiEstateConfigurationOptionsNewGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServerConfigurationOptionsApiApi.ApiEstateConfigurationOptionsNewGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEstateConfigurationOptionsNewGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiEstateConfigurationOptionsNewGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServerConfigurationOptionsApiApi.ApiEstateConfigurationOptionsNewGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getinstancerefsforcomparison"></a>
# **GetInstanceRefsForComparison**
> void GetInstanceRefsForComparison ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetInstanceRefsForComparisonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ServerConfigurationOptionsApiApi(config);

            try
            {
                apiInstance.GetInstanceRefsForComparison();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServerConfigurationOptionsApiApi.GetInstanceRefsForComparison: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetInstanceRefsForComparisonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetInstanceRefsForComparisonWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServerConfigurationOptionsApiApi.GetInstanceRefsForComparisonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getserverconfigurationoptions"></a>
# **GetServerConfigurationOptions**
> void GetServerConfigurationOptions (string? cir = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetServerConfigurationOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ServerConfigurationOptionsApiApi(config);
            var cir = "cir_example";  // string? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                apiInstance.GetServerConfigurationOptions(cir, endTime);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServerConfigurationOptionsApiApi.GetServerConfigurationOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServerConfigurationOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetServerConfigurationOptionsWithHttpInfo(cir, endTime);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServerConfigurationOptionsApiApi.GetServerConfigurationOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | **string?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

