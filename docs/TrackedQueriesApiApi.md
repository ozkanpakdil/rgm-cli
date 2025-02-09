# cli.Api.TrackedQueriesApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameTrackedqueriesGet**](TrackedQueriesApiApi.md#apibasemonitorsbasemonitornametrackedqueriesget) | **GET** /api/basemonitors/{baseMonitorName}/trackedqueries |  |
| [**Track**](TrackedQueriesApiApi.md#track) | **POST** /api/basemonitors/{baseMonitorName}/trackedqueries/track |  |
| [**Untrack**](TrackedQueriesApiApi.md#untrack) | **DELETE** /api/basemonitors/{baseMonitorName}/trackedqueries/untrack |  |

<a id="apibasemonitorsbasemonitornametrackedqueriesget"></a>
# **ApiBasemonitorsBaseMonitorNameTrackedqueriesGet**
> void ApiBasemonitorsBaseMonitorNameTrackedqueriesGet (string baseMonitorName, SqlInstanceChannelInstanceRef? cir = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameTrackedqueriesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TrackedQueriesApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var cir = new SqlInstanceChannelInstanceRef?(); // SqlInstanceChannelInstanceRef? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameTrackedqueriesGet(baseMonitorName, cir);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackedQueriesApiApi.ApiBasemonitorsBaseMonitorNameTrackedqueriesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameTrackedqueriesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameTrackedqueriesGetWithHttpInfo(baseMonitorName, cir);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackedQueriesApiApi.ApiBasemonitorsBaseMonitorNameTrackedqueriesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **cir** | [**SqlInstanceChannelInstanceRef?**](SqlInstanceChannelInstanceRef?.md) |  | [optional]  |

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

<a id="track"></a>
# **Track**
> void Track (string baseMonitorName, Object? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class TrackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TrackedQueriesApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = null;  // Object? |  (optional) 

            try
            {
                apiInstance.Track(baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackedQueriesApiApi.Track: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TrackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.TrackWithHttpInfo(baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackedQueriesApiApi.TrackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **body** | **Object?** |  | [optional]  |

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

<a id="untrack"></a>
# **Untrack**
> void Untrack (string baseMonitorName, SqlInstanceTopQueriesChannelInstanceRef? sqlInstanceTopQueriesChannelInstanceRef = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class UntrackExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TrackedQueriesApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var sqlInstanceTopQueriesChannelInstanceRef = new SqlInstanceTopQueriesChannelInstanceRef?(); // SqlInstanceTopQueriesChannelInstanceRef? |  (optional) 

            try
            {
                apiInstance.Untrack(baseMonitorName, sqlInstanceTopQueriesChannelInstanceRef);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackedQueriesApiApi.Untrack: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UntrackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.UntrackWithHttpInfo(baseMonitorName, sqlInstanceTopQueriesChannelInstanceRef);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackedQueriesApiApi.UntrackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **sqlInstanceTopQueriesChannelInstanceRef** | [**SqlInstanceTopQueriesChannelInstanceRef?**](SqlInstanceTopQueriesChannelInstanceRef?.md) |  | [optional]  |

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

