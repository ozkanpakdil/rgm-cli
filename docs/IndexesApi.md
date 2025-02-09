# cli.Api.IndexesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameIndexesColumnsGet**](IndexesApi.md#apibasemonitorsbasemonitornameindexescolumnsget) | **GET** /api/basemonitors/{baseMonitorName}/indexes/columns |  |
| [**ApiBasemonitorsBaseMonitorNameIndexesDetailsGet**](IndexesApi.md#apibasemonitorsbasemonitornameindexesdetailsget) | **GET** /api/basemonitors/{baseMonitorName}/indexes/details |  |
| [**ApiBasemonitorsBaseMonitorNameIndexesGet**](IndexesApi.md#apibasemonitorsbasemonitornameindexesget) | **GET** /api/basemonitors/{baseMonitorName}/indexes |  |
| [**ApiBasemonitorsBaseMonitorNameIndexesUsageGet**](IndexesApi.md#apibasemonitorsbasemonitornameindexesusageget) | **GET** /api/basemonitors/{baseMonitorName}/indexes/usage |  |

<a id="apibasemonitorsbasemonitornameindexescolumnsget"></a>
# **ApiBasemonitorsBaseMonitorNameIndexesColumnsGet**
> IndexColumnDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameIndexesColumnsGet (string baseMonitorName, SqlInstanceIndexesChannelInstanceRef? cir = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameIndexesColumnsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IndexesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var cir = new SqlInstanceIndexesChannelInstanceRef?(); // SqlInstanceIndexesChannelInstanceRef? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                IndexColumnDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameIndexesColumnsGet(baseMonitorName, cir, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexesApi.ApiBasemonitorsBaseMonitorNameIndexesColumnsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameIndexesColumnsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IndexColumnDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameIndexesColumnsGetWithHttpInfo(baseMonitorName, cir, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexesApi.ApiBasemonitorsBaseMonitorNameIndexesColumnsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **cir** | [**SqlInstanceIndexesChannelInstanceRef?**](SqlInstanceIndexesChannelInstanceRef?.md) |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**IndexColumnDtoIEnumerableJSendSuccess**](IndexColumnDtoIEnumerableJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameindexesdetailsget"></a>
# **ApiBasemonitorsBaseMonitorNameIndexesDetailsGet**
> IndexDetailsDtoJSendSuccess ApiBasemonitorsBaseMonitorNameIndexesDetailsGet (string baseMonitorName, SqlInstanceIndexesChannelInstanceRef? cir = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameIndexesDetailsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IndexesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var cir = new SqlInstanceIndexesChannelInstanceRef?(); // SqlInstanceIndexesChannelInstanceRef? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                IndexDetailsDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameIndexesDetailsGet(baseMonitorName, cir, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexesApi.ApiBasemonitorsBaseMonitorNameIndexesDetailsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameIndexesDetailsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IndexDetailsDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameIndexesDetailsGetWithHttpInfo(baseMonitorName, cir, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexesApi.ApiBasemonitorsBaseMonitorNameIndexesDetailsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **cir** | [**SqlInstanceIndexesChannelInstanceRef?**](SqlInstanceIndexesChannelInstanceRef?.md) |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**IndexDetailsDtoJSendSuccess**](IndexDetailsDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameindexesget"></a>
# **ApiBasemonitorsBaseMonitorNameIndexesGet**
> IndexTableDataDtoJSendSuccess ApiBasemonitorsBaseMonitorNameIndexesGet (string baseMonitorName, SqlInstanceChannelInstanceRef? cir = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameIndexesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IndexesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var cir = new SqlInstanceChannelInstanceRef?(); // SqlInstanceChannelInstanceRef? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                IndexTableDataDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameIndexesGet(baseMonitorName, cir, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexesApi.ApiBasemonitorsBaseMonitorNameIndexesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameIndexesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IndexTableDataDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameIndexesGetWithHttpInfo(baseMonitorName, cir, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexesApi.ApiBasemonitorsBaseMonitorNameIndexesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **cir** | [**SqlInstanceChannelInstanceRef?**](SqlInstanceChannelInstanceRef?.md) |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**IndexTableDataDtoJSendSuccess**](IndexTableDataDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornameindexesusageget"></a>
# **ApiBasemonitorsBaseMonitorNameIndexesUsageGet**
> IndexUsageDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameIndexesUsageGet (string baseMonitorName, SqlInstanceIndexesChannelInstanceRef? cir = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameIndexesUsageGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IndexesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var cir = new SqlInstanceIndexesChannelInstanceRef?(); // SqlInstanceIndexesChannelInstanceRef? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                IndexUsageDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameIndexesUsageGet(baseMonitorName, cir, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IndexesApi.ApiBasemonitorsBaseMonitorNameIndexesUsageGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameIndexesUsageGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<IndexUsageDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameIndexesUsageGetWithHttpInfo(baseMonitorName, cir, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IndexesApi.ApiBasemonitorsBaseMonitorNameIndexesUsageGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **cir** | [**SqlInstanceIndexesChannelInstanceRef?**](SqlInstanceIndexesChannelInstanceRef?.md) |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**IndexUsageDtoIEnumerableJSendSuccess**](IndexUsageDtoIEnumerableJSendSuccess.md)

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

