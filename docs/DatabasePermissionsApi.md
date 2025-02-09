# cli.Api.DatabasePermissionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryV2RunDateGet**](DatabasePermissionsApi.md#apibasemonitorsbasemonitornamedatabasepermissionssummaryv2rundateget) | **GET** /api/basemonitors/{baseMonitorName}/database-permissions-summary/v2/{runDate} |  |
| [**ApiBasemonitorsBaseMonitorNameDatabasePermissionsV2CirDatabaseNameRunDateGet**](DatabasePermissionsApi.md#apibasemonitorsbasemonitornamedatabasepermissionsv2cirdatabasenamerundateget) | **GET** /api/basemonitors/{baseMonitorName}/database-permissions/v2/{cir}/{databaseName}/{runDate} |  |

<a id="apibasemonitorsbasemonitornamedatabasepermissionssummaryv2rundateget"></a>
# **ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryV2RunDateGet**
> OldDatabasePermissionsDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryV2RunDateGet (DateTime runDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryV2RunDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabasePermissionsApi(config);
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                OldDatabasePermissionsDtoIEnumerableJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryV2RunDateGet(runDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabasePermissionsApi.ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryV2RunDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryV2RunDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OldDatabasePermissionsDtoIEnumerableJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryV2RunDateGetWithHttpInfo(runDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabasePermissionsApi.ApiBasemonitorsBaseMonitorNameDatabasePermissionsSummaryV2RunDateGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornamedatabasepermissionsv2cirdatabasenamerundateget"></a>
# **ApiBasemonitorsBaseMonitorNameDatabasePermissionsV2CirDatabaseNameRunDateGet**
> OldDatabasePermissionsDtoJSendSuccess ApiBasemonitorsBaseMonitorNameDatabasePermissionsV2CirDatabaseNameRunDateGet (SqlInstanceChannelInstanceRef cir, string databaseName, DateTime runDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameDatabasePermissionsV2CirDatabaseNameRunDateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabasePermissionsApi(config);
            var cir = new SqlInstanceChannelInstanceRef(); // SqlInstanceChannelInstanceRef | 
            var databaseName = "databaseName_example";  // string | 
            var runDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                OldDatabasePermissionsDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameDatabasePermissionsV2CirDatabaseNameRunDateGet(cir, databaseName, runDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabasePermissionsApi.ApiBasemonitorsBaseMonitorNameDatabasePermissionsV2CirDatabaseNameRunDateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameDatabasePermissionsV2CirDatabaseNameRunDateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<OldDatabasePermissionsDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameDatabasePermissionsV2CirDatabaseNameRunDateGetWithHttpInfo(cir, databaseName, runDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabasePermissionsApi.ApiBasemonitorsBaseMonitorNameDatabasePermissionsV2CirDatabaseNameRunDateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cir** | [**SqlInstanceChannelInstanceRef**](SqlInstanceChannelInstanceRef.md) |  |  |
| **databaseName** | **string** |  |  |
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

