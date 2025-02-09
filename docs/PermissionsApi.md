# cli.Api.PermissionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameDatabasePermissionsCirRunDateGet**](PermissionsApi.md#apibasemonitorsbasemonitornamedatabasepermissionscirrundateget) | **GET** /api/basemonitors/{baseMonitorName}/database-permissions/{cir}/{runDate} |  |
| [**ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryRunDateGet**](PermissionsApi.md#apibasemonitorsbasemonitornamedatabasepermissionssummaryrundateget) | **GET** /api/basemonitors/{baseMonitorName}/database-permissions-summary/{runDate} |  |
| [**ApiBasemonitorsBaseMonitorNameServerPermissionsCirRunDateGet**](PermissionsApi.md#apibasemonitorsbasemonitornameserverpermissionscirrundateget) | **GET** /api/basemonitors/{baseMonitorName}/server-permissions/{cir}/{runDate} |  |
| [**ApiBasemonitorsBaseMonitorNameServerPermissionsRunDateGet**](PermissionsApi.md#apibasemonitorsbasemonitornameserverpermissionsrundateget) | **GET** /api/basemonitors/{baseMonitorName}/server-permissions/{runDate} |  |
| [**ApiBasemonitorsBaseMonitorNameUserPermissionsRunDateGet**](PermissionsApi.md#apibasemonitorsbasemonitornameuserpermissionsrundateget) | **GET** /api/basemonitors/{baseMonitorName}/user-permissions/{runDate} |  |

<a id="apibasemonitorsbasemonitornamedatabasepermissionscirrundateget"></a>
# **ApiBasemonitorsBaseMonitorNameDatabasePermissionsCirRunDateGet**
> OldDatabasePermissionsDtoJSendSuccess ApiBasemonitorsBaseMonitorNameDatabasePermissionsCirRunDateGet (SqlInstanceChannelInstanceRef cir, DateTime runDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameDatabasePermissionsCirRunDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PermissionsApi(config);
            var cir = new SqlInstanceChannelInstanceRef(); // SqlInstanceChannelInstanceRef | 
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                OldDatabasePermissionsDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameDatabasePermissionsCirRunDateGet(cir, runDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.ApiBasemonitorsBaseMonitorNameDatabasePermissionsCirRunDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameDatabasePermissionsCirRunDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OldDatabasePermissionsDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameDatabasePermissionsCirRunDateGetWithHttpInfo(cir, runDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.ApiBasemonitorsBaseMonitorNameDatabasePermissionsCirRunDateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**SqlInstanceChannelInstanceRef**](SqlInstanceChannelInstanceRef.md) |  |  |
| **runDate** | **DateTime** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**OldDatabasePermissionsDtoJSendSuccess**](OldDatabasePermissionsDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamedatabasepermissionssummaryrundateget"></a>
# **ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryRunDateGet**
> OldDatabasePermissionsDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryRunDateGet (DateTime runDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryRunDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PermissionsApi(config);
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                OldDatabasePermissionsDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryRunDateGet(runDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryRunDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryRunDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OldDatabasePermissionsDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryRunDateGetWithHttpInfo(runDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryRunDateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runDate** | **DateTime** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**OldDatabasePermissionsDtoIEnumerableJSendSuccess**](OldDatabasePermissionsDtoIEnumerableJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameserverpermissionscirrundateget"></a>
# **ApiBasemonitorsBaseMonitorNameServerPermissionsCirRunDateGet**
> OldServerPermissionsDtoJSendSuccess ApiBasemonitorsBaseMonitorNameServerPermissionsCirRunDateGet (SqlInstanceChannelInstanceRef cir, DateTime runDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameServerPermissionsCirRunDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PermissionsApi(config);
            var cir = new SqlInstanceChannelInstanceRef(); // SqlInstanceChannelInstanceRef | 
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                OldServerPermissionsDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameServerPermissionsCirRunDateGet(cir, runDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.ApiBasemonitorsBaseMonitorNameServerPermissionsCirRunDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameServerPermissionsCirRunDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OldServerPermissionsDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameServerPermissionsCirRunDateGetWithHttpInfo(cir, runDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.ApiBasemonitorsBaseMonitorNameServerPermissionsCirRunDateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**SqlInstanceChannelInstanceRef**](SqlInstanceChannelInstanceRef.md) |  |  |
| **runDate** | **DateTime** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**OldServerPermissionsDtoJSendSuccess**](OldServerPermissionsDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameserverpermissionsrundateget"></a>
# **ApiBasemonitorsBaseMonitorNameServerPermissionsRunDateGet**
> OldSummarizedServerPermissionsDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameServerPermissionsRunDateGet (DateTime runDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameServerPermissionsRunDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PermissionsApi(config);
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                OldSummarizedServerPermissionsDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameServerPermissionsRunDateGet(runDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.ApiBasemonitorsBaseMonitorNameServerPermissionsRunDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameServerPermissionsRunDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OldSummarizedServerPermissionsDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameServerPermissionsRunDateGetWithHttpInfo(runDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.ApiBasemonitorsBaseMonitorNameServerPermissionsRunDateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runDate** | **DateTime** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**OldSummarizedServerPermissionsDtoIEnumerableJSendSuccess**](OldSummarizedServerPermissionsDtoIEnumerableJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameuserpermissionsrundateget"></a>
# **ApiBasemonitorsBaseMonitorNameUserPermissionsRunDateGet**
> OldUserPermissionAndMonitoredEntityDtoJSendSuccess ApiBasemonitorsBaseMonitorNameUserPermissionsRunDateGet (DateTime runDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameUserPermissionsRunDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PermissionsApi(config);
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                OldUserPermissionAndMonitoredEntityDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameUserPermissionsRunDateGet(runDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PermissionsApi.ApiBasemonitorsBaseMonitorNameUserPermissionsRunDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameUserPermissionsRunDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OldUserPermissionAndMonitoredEntityDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameUserPermissionsRunDateGetWithHttpInfo(runDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PermissionsApi.ApiBasemonitorsBaseMonitorNameUserPermissionsRunDateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runDate** | **DateTime** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**OldUserPermissionAndMonitoredEntityDtoJSendSuccess**](OldUserPermissionAndMonitoredEntityDtoJSendSuccess.md)

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

