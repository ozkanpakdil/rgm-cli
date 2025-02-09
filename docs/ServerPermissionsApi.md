# cli.Api.ServerPermissionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameServerPermissionsV2CirRunDateGet**](ServerPermissionsApi.md#apibasemonitorsbasemonitornameserverpermissionsv2cirrundateget) | **GET** /api/basemonitors/{baseMonitorName}/server-permissions/v2/{cir}/{runDate} |  |
| [**ApiBasemonitorsBaseMonitorNameServerPermissionsV2RunDateGet**](ServerPermissionsApi.md#apibasemonitorsbasemonitornameserverpermissionsv2rundateget) | **GET** /api/basemonitors/{baseMonitorName}/server-permissions/v2/{runDate} |  |
| [**ApiBasemonitorsBaseMonitorNameSqlinstancesCirPermissionsGet**](ServerPermissionsApi.md#apibasemonitorsbasemonitornamesqlinstancescirpermissionsget) | **GET** /api/basemonitors/{baseMonitorName}/sqlinstances/{cir}/permissions |  |
| [**ApiServerOverviewServerPermissionsReportGet**](ServerPermissionsApi.md#apiserveroverviewserverpermissionsreportget) | **GET** /api/server-overview/server-permissions/report |  |

<a id="apibasemonitorsbasemonitornameserverpermissionsv2cirrundateget"></a>
# **ApiBasemonitorsBaseMonitorNameServerPermissionsV2CirRunDateGet**
> OldServerPermissionsDtoJSendSuccess ApiBasemonitorsBaseMonitorNameServerPermissionsV2CirRunDateGet (SqlInstanceChannelInstanceRef cir, DateTime runDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameServerPermissionsV2CirRunDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ServerPermissionsApi(config);
            var cir = new SqlInstanceChannelInstanceRef(); // SqlInstanceChannelInstanceRef | 
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                OldServerPermissionsDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameServerPermissionsV2CirRunDateGet(cir, runDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServerPermissionsApi.ApiBasemonitorsBaseMonitorNameServerPermissionsV2CirRunDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameServerPermissionsV2CirRunDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OldServerPermissionsDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameServerPermissionsV2CirRunDateGetWithHttpInfo(cir, runDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServerPermissionsApi.ApiBasemonitorsBaseMonitorNameServerPermissionsV2CirRunDateGetWithHttpInfo: " + e.Message);
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
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornameserverpermissionsv2rundateget"></a>
# **ApiBasemonitorsBaseMonitorNameServerPermissionsV2RunDateGet**
> OldSummarizedServerPermissionsDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameServerPermissionsV2RunDateGet (DateTime runDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameServerPermissionsV2RunDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ServerPermissionsApi(config);
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                OldSummarizedServerPermissionsDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameServerPermissionsV2RunDateGet(runDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServerPermissionsApi.ApiBasemonitorsBaseMonitorNameServerPermissionsV2RunDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameServerPermissionsV2RunDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OldSummarizedServerPermissionsDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameServerPermissionsV2RunDateGetWithHttpInfo(runDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServerPermissionsApi.ApiBasemonitorsBaseMonitorNameServerPermissionsV2RunDateGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornamesqlinstancescirpermissionsget"></a>
# **ApiBasemonitorsBaseMonitorNameSqlinstancesCirPermissionsGet**
> ServerRoleViewModelDtoArrayJSendSuccess ApiBasemonitorsBaseMonitorNameSqlinstancesCirPermissionsGet (SqlInstanceChannelInstanceRef cir, string baseMonitorName, long? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameSqlinstancesCirPermissionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ServerPermissionsApi(config);
            var cir = new SqlInstanceChannelInstanceRef(); // SqlInstanceChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var endTime = 789L;  // long? |  (optional) 

            try
            {
                ServerRoleViewModelDtoArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameSqlinstancesCirPermissionsGet(cir, baseMonitorName, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServerPermissionsApi.ApiBasemonitorsBaseMonitorNameSqlinstancesCirPermissionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameSqlinstancesCirPermissionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ServerRoleViewModelDtoArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameSqlinstancesCirPermissionsGetWithHttpInfo(cir, baseMonitorName, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServerPermissionsApi.ApiBasemonitorsBaseMonitorNameSqlinstancesCirPermissionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**SqlInstanceChannelInstanceRef**](SqlInstanceChannelInstanceRef.md) |  |  |
| **baseMonitorName** | **string** |  |  |
| **endTime** | **long?** |  | [optional]  |

### Return type

[**ServerRoleViewModelDtoArrayJSendSuccess**](ServerRoleViewModelDtoArrayJSendSuccess.md)

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

<a id="apiserveroverviewserverpermissionsreportget"></a>
# **ApiServerOverviewServerPermissionsReportGet**
> void ApiServerOverviewServerPermissionsReportGet (SqlInstanceChannelInstanceRef? cir = null, long? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiServerOverviewServerPermissionsReportGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ServerPermissionsApi(config);
            var cir = new SqlInstanceChannelInstanceRef?(); // SqlInstanceChannelInstanceRef? |  (optional) 
            var endTime = 789L;  // long? |  (optional) 

            try
            {
                apiInstance.ApiServerOverviewServerPermissionsReportGet(cir, endTime);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ServerPermissionsApi.ApiServerOverviewServerPermissionsReportGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiServerOverviewServerPermissionsReportGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiServerOverviewServerPermissionsReportGetWithHttpInfo(cir, endTime);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ServerPermissionsApi.ApiServerOverviewServerPermissionsReportGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**SqlInstanceChannelInstanceRef?**](SqlInstanceChannelInstanceRef?.md) |  | [optional]  |
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

