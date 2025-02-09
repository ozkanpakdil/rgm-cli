# cli.Api.TopQueriesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameTopqueriesAnalysequeryGet**](TopQueriesApi.md#apibasemonitorsbasemonitornametopqueriesanalysequeryget) | **GET** /api/basemonitors/{baseMonitorName}/topqueries/analysequery |  |
| [**ApiBasemonitorsBaseMonitorNameTopqueriesGetGet**](TopQueriesApi.md#apibasemonitorsbasemonitornametopqueriesgetget) | **GET** /api/basemonitors/{baseMonitorName}/topqueries/get |  |
| [**ApiBasemonitorsBaseMonitorNameTopqueriesQueryhistoryGet**](TopQueriesApi.md#apibasemonitorsbasemonitornametopqueriesqueryhistoryget) | **GET** /api/basemonitors/{baseMonitorName}/topqueries/queryhistory |  |
| [**ApiBasemonitorsBaseMonitorNameTopqueriesTrackedqueryrecordsGet**](TopQueriesApi.md#apibasemonitorsbasemonitornametopqueriestrackedqueryrecordsget) | **GET** /api/basemonitors/{baseMonitorName}/topqueries/trackedqueryrecords |  |

<a id="apibasemonitorsbasemonitornametopqueriesanalysequeryget"></a>
# **ApiBasemonitorsBaseMonitorNameTopqueriesAnalysequeryGet**
> FragmentAnalysisIssueWithIdDtoArrayJSendSuccess ApiBasemonitorsBaseMonitorNameTopqueriesAnalysequeryGet (string baseMonitorName, SqlInstanceTopQueriesChannelInstanceRef? cir = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameTopqueriesAnalysequeryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TopQueriesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var cir = new SqlInstanceTopQueriesChannelInstanceRef?(); // SqlInstanceTopQueriesChannelInstanceRef? |  (optional) 

            try
            {
                FragmentAnalysisIssueWithIdDtoArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameTopqueriesAnalysequeryGet(baseMonitorName, cir);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TopQueriesApi.ApiBasemonitorsBaseMonitorNameTopqueriesAnalysequeryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameTopqueriesAnalysequeryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<FragmentAnalysisIssueWithIdDtoArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameTopqueriesAnalysequeryGetWithHttpInfo(baseMonitorName, cir);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TopQueriesApi.ApiBasemonitorsBaseMonitorNameTopqueriesAnalysequeryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **cir** | [**SqlInstanceTopQueriesChannelInstanceRef?**](SqlInstanceTopQueriesChannelInstanceRef?.md) |  | [optional]  |

### Return type

[**FragmentAnalysisIssueWithIdDtoArrayJSendSuccess**](FragmentAnalysisIssueWithIdDtoArrayJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornametopqueriesgetget"></a>
# **ApiBasemonitorsBaseMonitorNameTopqueriesGetGet**
> TopQueryDtoGroupedTopQueryDtoOneOfArrayJSendSuccess ApiBasemonitorsBaseMonitorNameTopqueriesGetGet (string baseMonitorName, ChannelInstanceRef? cir = null, string? selectedWait = null, IntegerIdentifier? alertId = null, DateTime? startTime = null, DateTime? endTime = null, string? sqlQueryTextFragment = null, bool? groupResults = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameTopqueriesGetGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TopQueriesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var cir = new ChannelInstanceRef?(); // ChannelInstanceRef? |  (optional) 
            var selectedWait = "selectedWait_example";  // string? |  (optional) 
            var alertId = new IntegerIdentifier?(); // IntegerIdentifier? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var sqlQueryTextFragment = "sqlQueryTextFragment_example";  // string? |  (optional) 
            var groupResults = true;  // bool? |  (optional)  (default to true)

            try
            {
                TopQueryDtoGroupedTopQueryDtoOneOfArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameTopqueriesGetGet(baseMonitorName, cir, selectedWait, alertId, startTime, endTime, sqlQueryTextFragment, groupResults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TopQueriesApi.ApiBasemonitorsBaseMonitorNameTopqueriesGetGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameTopqueriesGetGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TopQueryDtoGroupedTopQueryDtoOneOfArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameTopqueriesGetGetWithHttpInfo(baseMonitorName, cir, selectedWait, alertId, startTime, endTime, sqlQueryTextFragment, groupResults);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TopQueriesApi.ApiBasemonitorsBaseMonitorNameTopqueriesGetGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **cir** | [**ChannelInstanceRef?**](ChannelInstanceRef?.md) |  | [optional]  |
| **selectedWait** | **string?** |  | [optional]  |
| **alertId** | [**IntegerIdentifier?**](IntegerIdentifier?.md) |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |
| **sqlQueryTextFragment** | **string?** |  | [optional]  |
| **groupResults** | **bool?** |  | [optional] [default to true] |

### Return type

[**TopQueryDtoGroupedTopQueryDtoOneOfArrayJSendSuccess**](TopQueryDtoGroupedTopQueryDtoOneOfArrayJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornametopqueriesqueryhistoryget"></a>
# **ApiBasemonitorsBaseMonitorNameTopqueriesQueryhistoryGet**
> TopQueryPropertySqlServerQueryHistoryPlanKeyDtoQueryHistoryDtoJSendSuccess ApiBasemonitorsBaseMonitorNameTopqueriesQueryhistoryGet (string baseMonitorName, SqlInstanceTopQueriesChannelInstanceRef? cir = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameTopqueriesQueryhistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TopQueriesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var cir = new SqlInstanceTopQueriesChannelInstanceRef?(); // SqlInstanceTopQueriesChannelInstanceRef? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                TopQueryPropertySqlServerQueryHistoryPlanKeyDtoQueryHistoryDtoJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameTopqueriesQueryhistoryGet(baseMonitorName, cir, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TopQueriesApi.ApiBasemonitorsBaseMonitorNameTopqueriesQueryhistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameTopqueriesQueryhistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TopQueryPropertySqlServerQueryHistoryPlanKeyDtoQueryHistoryDtoJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameTopqueriesQueryhistoryGetWithHttpInfo(baseMonitorName, cir, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TopQueriesApi.ApiBasemonitorsBaseMonitorNameTopqueriesQueryhistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **cir** | [**SqlInstanceTopQueriesChannelInstanceRef?**](SqlInstanceTopQueriesChannelInstanceRef?.md) |  | [optional]  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

### Return type

[**TopQueryPropertySqlServerQueryHistoryPlanKeyDtoQueryHistoryDtoJSendSuccess**](TopQueryPropertySqlServerQueryHistoryPlanKeyDtoQueryHistoryDtoJSendSuccess.md)

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

<a id="apibasemonitorsbasemonitornametopqueriestrackedqueryrecordsget"></a>
# **ApiBasemonitorsBaseMonitorNameTopqueriesTrackedqueryrecordsGet**
> TopQueryDtoTopQueryOutOfRangeDtoOneOfArrayJSendSuccess ApiBasemonitorsBaseMonitorNameTopqueriesTrackedqueryrecordsGet (string baseMonitorName, SqlInstanceChannelInstanceRef? cir = null, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameTopqueriesTrackedqueryrecordsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new TopQueriesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var cir = new SqlInstanceChannelInstanceRef?(); // SqlInstanceChannelInstanceRef? |  (optional) 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                TopQueryDtoTopQueryOutOfRangeDtoOneOfArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameTopqueriesTrackedqueryrecordsGet(baseMonitorName, cir, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TopQueriesApi.ApiBasemonitorsBaseMonitorNameTopqueriesTrackedqueryrecordsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameTopqueriesTrackedqueryrecordsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TopQueryDtoTopQueryOutOfRangeDtoOneOfArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameTopqueriesTrackedqueryrecordsGetWithHttpInfo(baseMonitorName, cir, startTime, endTime);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TopQueriesApi.ApiBasemonitorsBaseMonitorNameTopqueriesTrackedqueryrecordsGetWithHttpInfo: " + e.Message);
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

[**TopQueryDtoTopQueryOutOfRangeDtoOneOfArrayJSendSuccess**](TopQueryDtoTopQueryOutOfRangeDtoOneOfArrayJSendSuccess.md)

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

