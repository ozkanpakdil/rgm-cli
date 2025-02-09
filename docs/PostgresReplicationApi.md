# cli.Api.PostgresReplicationApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNamePostgresreplicationGet**](PostgresReplicationApi.md#apibasemonitorsbasemonitornamepostgresreplicationget) | **GET** /api/basemonitors/{baseMonitorName}/postgresreplication |  |
| [**ApiBasemonitorsBaseMonitorNamePostgresreplicationSettingsGet**](PostgresReplicationApi.md#apibasemonitorsbasemonitornamepostgresreplicationsettingsget) | **GET** /api/basemonitors/{baseMonitorName}/postgresreplication/settings |  |
| [**ApiBasemonitorsBaseMonitorNamePostgresreplicationSlotsGet**](PostgresReplicationApi.md#apibasemonitorsbasemonitornamepostgresreplicationslotsget) | **GET** /api/basemonitors/{baseMonitorName}/postgresreplication/slots |  |
| [**ApiPostgresreplicationSecondaryGet**](PostgresReplicationApi.md#apipostgresreplicationsecondaryget) | **GET** /api/postgresreplication/secondary |  |

<a id="apibasemonitorsbasemonitornamepostgresreplicationget"></a>
# **ApiBasemonitorsBaseMonitorNamePostgresreplicationGet**
> PostgresReplicationDataDtoJSendSuccess ApiBasemonitorsBaseMonitorNamePostgresreplicationGet (string baseMonitorName, PostgresInstanceChannelInstanceRef? dbmsCir = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePostgresreplicationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PostgresReplicationApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var dbmsCir = new PostgresInstanceChannelInstanceRef?(); // PostgresInstanceChannelInstanceRef? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                PostgresReplicationDataDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresreplicationGet(baseMonitorName, dbmsCir, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostgresReplicationApi.ApiBasemonitorsBaseMonitorNamePostgresreplicationGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePostgresreplicationGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostgresReplicationDataDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresreplicationGetWithHttpInfo(baseMonitorName, dbmsCir, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostgresReplicationApi.ApiBasemonitorsBaseMonitorNamePostgresreplicationGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **dbmsCir** | [**PostgresInstanceChannelInstanceRef?**](PostgresInstanceChannelInstanceRef?.md) |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**PostgresReplicationDataDtoJSendSuccess**](PostgresReplicationDataDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamepostgresreplicationsettingsget"></a>
# **ApiBasemonitorsBaseMonitorNamePostgresreplicationSettingsGet**
> GroupedPostgresConfigurationOptionsDtoJSendSuccess ApiBasemonitorsBaseMonitorNamePostgresreplicationSettingsGet (string baseMonitorName, PostgresInstanceChannelInstanceRef? dbmsCir = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePostgresreplicationSettingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PostgresReplicationApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var dbmsCir = new PostgresInstanceChannelInstanceRef?(); // PostgresInstanceChannelInstanceRef? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                GroupedPostgresConfigurationOptionsDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresreplicationSettingsGet(baseMonitorName, dbmsCir, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostgresReplicationApi.ApiBasemonitorsBaseMonitorNamePostgresreplicationSettingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePostgresreplicationSettingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupedPostgresConfigurationOptionsDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresreplicationSettingsGetWithHttpInfo(baseMonitorName, dbmsCir, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostgresReplicationApi.ApiBasemonitorsBaseMonitorNamePostgresreplicationSettingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **dbmsCir** | [**PostgresInstanceChannelInstanceRef?**](PostgresInstanceChannelInstanceRef?.md) |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**GroupedPostgresConfigurationOptionsDtoJSendSuccess**](GroupedPostgresConfigurationOptionsDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornamepostgresreplicationslotsget"></a>
# **ApiBasemonitorsBaseMonitorNamePostgresreplicationSlotsGet**
> PostgresReplicationSlotsDataDtoJSendSuccess ApiBasemonitorsBaseMonitorNamePostgresreplicationSlotsGet (string baseMonitorName, PostgresInstanceChannelInstanceRef? dbmsCir = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePostgresreplicationSlotsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PostgresReplicationApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var dbmsCir = new PostgresInstanceChannelInstanceRef?(); // PostgresInstanceChannelInstanceRef? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                PostgresReplicationSlotsDataDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresreplicationSlotsGet(baseMonitorName, dbmsCir, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostgresReplicationApi.ApiBasemonitorsBaseMonitorNamePostgresreplicationSlotsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePostgresreplicationSlotsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostgresReplicationSlotsDataDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNamePostgresreplicationSlotsGetWithHttpInfo(baseMonitorName, dbmsCir, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostgresReplicationApi.ApiBasemonitorsBaseMonitorNamePostgresreplicationSlotsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **dbmsCir** | [**PostgresInstanceChannelInstanceRef?**](PostgresInstanceChannelInstanceRef?.md) |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**PostgresReplicationSlotsDataDtoJSendSuccess**](PostgresReplicationSlotsDataDtoJSendSuccess.md)

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

<a id="apipostgresreplicationsecondaryget"></a>
# **ApiPostgresreplicationSecondaryGet**
> PostgresSecondaryReplicationDataDtoJSendSuccess ApiPostgresreplicationSecondaryGet (PostgresInstanceChannelInstanceRef? dbmsCir = null, string? senderHost = null, string? clusterName = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiPostgresreplicationSecondaryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PostgresReplicationApi(config);
            var dbmsCir = new PostgresInstanceChannelInstanceRef?(); // PostgresInstanceChannelInstanceRef? |  (optional) 
            var senderHost = "senderHost_example";  // string? |  (optional) 
            var clusterName = "clusterName_example";  // string? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                PostgresSecondaryReplicationDataDtoJSendSuccess result = apiInstance.ApiPostgresreplicationSecondaryGet(dbmsCir, senderHost, clusterName, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PostgresReplicationApi.ApiPostgresreplicationSecondaryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiPostgresreplicationSecondaryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostgresSecondaryReplicationDataDtoJSendSuccess> response = apiInstance.ApiPostgresreplicationSecondaryGetWithHttpInfo(dbmsCir, senderHost, clusterName, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PostgresReplicationApi.ApiPostgresreplicationSecondaryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dbmsCir** | [**PostgresInstanceChannelInstanceRef?**](PostgresInstanceChannelInstanceRef?.md) |  | [optional]  |
| **senderHost** | **string?** |  | [optional]  |
| **clusterName** | **string?** |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**PostgresSecondaryReplicationDataDtoJSendSuccess**](PostgresSecondaryReplicationDataDtoJSendSuccess.md)

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

