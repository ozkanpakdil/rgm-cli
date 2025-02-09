# cli.Api.DatabaseConfigurationOptionsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAllDatabaseConfigurationOptions**](DatabaseConfigurationOptionsApiApi.md#getalldatabaseconfigurationoptions) | **GET** /api/estate/configuration-options/GetAllDatabaseConfigurationOptions |  |
| [**GetDatabaseConfigurationOptions**](DatabaseConfigurationOptionsApiApi.md#getdatabaseconfigurationoptions) | **GET** /api/basemonitors/{baseMonitorName}/estate/configuration-options/GetDatabaseConfigurationOptions |  |
| [**GetDatabaseConfigurationOptionsMetadata**](DatabaseConfigurationOptionsApiApi.md#getdatabaseconfigurationoptionsmetadata) | **GET** /api/estate/configuration-options/GetDatabaseConfigurationOptionsMetadata |  |
| [**GetDatabaseRefsForComparison**](DatabaseConfigurationOptionsApiApi.md#getdatabaserefsforcomparison) | **GET** /api/estate/configuration-options/GetDatabaseRefsForComparison |  |
| [**GetServerInstanceRefsForComparison**](DatabaseConfigurationOptionsApiApi.md#getserverinstancerefsforcomparison) | **GET** /api/estate/configuration-options/GetServerInstanceRefsForComparison |  |

<a id="getalldatabaseconfigurationoptions"></a>
# **GetAllDatabaseConfigurationOptions**
> void GetAllDatabaseConfigurationOptions ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetAllDatabaseConfigurationOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabaseConfigurationOptionsApiApi(config);

            try
            {
                apiInstance.GetAllDatabaseConfigurationOptions();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabaseConfigurationOptionsApiApi.GetAllDatabaseConfigurationOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllDatabaseConfigurationOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetAllDatabaseConfigurationOptionsWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabaseConfigurationOptionsApiApi.GetAllDatabaseConfigurationOptionsWithHttpInfo: " + e.Message);
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

<a id="getdatabaseconfigurationoptions"></a>
# **GetDatabaseConfigurationOptions**
> void GetDatabaseConfigurationOptions (string baseMonitorName, string? databaseCir = null, long? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetDatabaseConfigurationOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabaseConfigurationOptionsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var databaseCir = "databaseCir_example";  // string? |  (optional) 
            var endTime = 789L;  // long? |  (optional) 

            try
            {
                apiInstance.GetDatabaseConfigurationOptions(baseMonitorName, databaseCir, endTime);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabaseConfigurationOptionsApiApi.GetDatabaseConfigurationOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatabaseConfigurationOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetDatabaseConfigurationOptionsWithHttpInfo(baseMonitorName, databaseCir, endTime);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabaseConfigurationOptionsApiApi.GetDatabaseConfigurationOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **databaseCir** | **string?** |  | [optional]  |
| **endTime** | **long?** |  | [optional]  |

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

<a id="getdatabaseconfigurationoptionsmetadata"></a>
# **GetDatabaseConfigurationOptionsMetadata**
> void GetDatabaseConfigurationOptionsMetadata ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetDatabaseConfigurationOptionsMetadataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabaseConfigurationOptionsApiApi(config);

            try
            {
                apiInstance.GetDatabaseConfigurationOptionsMetadata();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabaseConfigurationOptionsApiApi.GetDatabaseConfigurationOptionsMetadata: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatabaseConfigurationOptionsMetadataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetDatabaseConfigurationOptionsMetadataWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabaseConfigurationOptionsApiApi.GetDatabaseConfigurationOptionsMetadataWithHttpInfo: " + e.Message);
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

<a id="getdatabaserefsforcomparison"></a>
# **GetDatabaseRefsForComparison**
> void GetDatabaseRefsForComparison (string? cir = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetDatabaseRefsForComparisonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabaseConfigurationOptionsApiApi(config);
            var cir = "cir_example";  // string? |  (optional) 

            try
            {
                apiInstance.GetDatabaseRefsForComparison(cir);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabaseConfigurationOptionsApiApi.GetDatabaseRefsForComparison: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatabaseRefsForComparisonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetDatabaseRefsForComparisonWithHttpInfo(cir);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabaseConfigurationOptionsApiApi.GetDatabaseRefsForComparisonWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | **string?** |  | [optional]  |

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

<a id="getserverinstancerefsforcomparison"></a>
# **GetServerInstanceRefsForComparison**
> void GetServerInstanceRefsForComparison ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GetServerInstanceRefsForComparisonExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabaseConfigurationOptionsApiApi(config);

            try
            {
                apiInstance.GetServerInstanceRefsForComparison();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabaseConfigurationOptionsApiApi.GetServerInstanceRefsForComparison: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServerInstanceRefsForComparisonWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.GetServerInstanceRefsForComparisonWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabaseConfigurationOptionsApiApi.GetServerInstanceRefsForComparisonWithHttpInfo: " + e.Message);
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

