# cli.Api.QueryRecommendationsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameRecommendationsInstanceSqlInstanceCirQueryplanPlanHandleCreateDateDatabaseNameGet**](QueryRecommendationsApiApi.md#apibasemonitorsbasemonitornamerecommendationsinstancesqlinstancecirqueryplanplanhandlecreatedatedatabasenameget) | **GET** /api/basemonitors/{baseMonitorName}/recommendations/instance/{sqlInstanceCir}/queryplan/{planHandle}/{createDate}/{databaseName} |  |
| [**ApiBasemonitorsBaseMonitorNameRecommendationsPost**](QueryRecommendationsApiApi.md#apibasemonitorsbasemonitornamerecommendationspost) | **POST** /api/basemonitors/{baseMonitorName}/recommendations |  |
| [**ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesPost**](QueryRecommendationsApiApi.md#apibasemonitorsbasemonitornamerecommendationspostgresinstancespost) | **POST** /api/basemonitors/{baseMonitorName}/recommendations/postgresinstances |  |
| [**ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesQueryplanGet**](QueryRecommendationsApiApi.md#apibasemonitorsbasemonitornamerecommendationspostgresinstancesqueryplanget) | **GET** /api/basemonitors/{baseMonitorName}/recommendations/postgresinstances/queryplan |  |

<a id="apibasemonitorsbasemonitornamerecommendationsinstancesqlinstancecirqueryplanplanhandlecreatedatedatabasenameget"></a>
# **ApiBasemonitorsBaseMonitorNameRecommendationsInstanceSqlInstanceCirQueryplanPlanHandleCreateDateDatabaseNameGet**
> QueryRecommendationDtoArrayJSendSuccess ApiBasemonitorsBaseMonitorNameRecommendationsInstanceSqlInstanceCirQueryplanPlanHandleCreateDateDatabaseNameGet (SqlInstanceChannelInstanceRef sqlInstanceCir, string planHandle, DateTime createDate, string databaseName, DateTime startDate, DateTime endDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameRecommendationsInstanceSqlInstanceCirQueryplanPlanHandleCreateDateDatabaseNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryRecommendationsApiApi(config);
            var sqlInstanceCir = new SqlInstanceChannelInstanceRef(); // SqlInstanceChannelInstanceRef | 
            var planHandle = "planHandle_example";  // string | 
            var createDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var databaseName = "databaseName_example";  // string | 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                QueryRecommendationDtoArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameRecommendationsInstanceSqlInstanceCirQueryplanPlanHandleCreateDateDatabaseNameGet(sqlInstanceCir, planHandle, createDate, databaseName, startDate, endDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryRecommendationsApiApi.ApiBasemonitorsBaseMonitorNameRecommendationsInstanceSqlInstanceCirQueryplanPlanHandleCreateDateDatabaseNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameRecommendationsInstanceSqlInstanceCirQueryplanPlanHandleCreateDateDatabaseNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<QueryRecommendationDtoArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameRecommendationsInstanceSqlInstanceCirQueryplanPlanHandleCreateDateDatabaseNameGetWithHttpInfo(sqlInstanceCir, planHandle, createDate, databaseName, startDate, endDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryRecommendationsApiApi.ApiBasemonitorsBaseMonitorNameRecommendationsInstanceSqlInstanceCirQueryplanPlanHandleCreateDateDatabaseNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sqlInstanceCir** | [**SqlInstanceChannelInstanceRef**](SqlInstanceChannelInstanceRef.md) |  |  |
| **planHandle** | **string** |  |  |
| **createDate** | **DateTime** |  |  |
| **databaseName** | **string** |  |  |
| **startDate** | **DateTime** |  |  |
| **endDate** | **DateTime** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**QueryRecommendationDtoArrayJSendSuccess**](QueryRecommendationDtoArrayJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | Unprocessable Content |  -  |
| **404** | Not Found |  -  |
| **503** | Service Unavailable |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamerecommendationspost"></a>
# **ApiBasemonitorsBaseMonitorNameRecommendationsPost**
> QueryRecommendationDtoQueryRecommendationCollectionDtoArrayJSendSuccess ApiBasemonitorsBaseMonitorNameRecommendationsPost (string baseMonitorName, QueryRecommendationsRequestDto? queryRecommendationsRequestDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameRecommendationsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryRecommendationsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var queryRecommendationsRequestDto = new QueryRecommendationsRequestDto?(); // QueryRecommendationsRequestDto? |  (optional) 

            try
            {
                QueryRecommendationDtoQueryRecommendationCollectionDtoArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameRecommendationsPost(baseMonitorName, queryRecommendationsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryRecommendationsApiApi.ApiBasemonitorsBaseMonitorNameRecommendationsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameRecommendationsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<QueryRecommendationDtoQueryRecommendationCollectionDtoArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameRecommendationsPostWithHttpInfo(baseMonitorName, queryRecommendationsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryRecommendationsApiApi.ApiBasemonitorsBaseMonitorNameRecommendationsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **queryRecommendationsRequestDto** | [**QueryRecommendationsRequestDto?**](QueryRecommendationsRequestDto?.md) |  | [optional]  |

### Return type

[**QueryRecommendationDtoQueryRecommendationCollectionDtoArrayJSendSuccess**](QueryRecommendationDtoQueryRecommendationCollectionDtoArrayJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | Unprocessable Content |  -  |
| **503** | Service Unavailable |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamerecommendationspostgresinstancespost"></a>
# **ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesPost**
> PostgresQueryRecommendationDtoPostgresQueryRecommendationCollectionDtoArrayJSendSuccess ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesPost (string baseMonitorName, PostgresQueryRecommendationsRequestDto? postgresQueryRecommendationsRequestDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryRecommendationsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var postgresQueryRecommendationsRequestDto = new PostgresQueryRecommendationsRequestDto?(); // PostgresQueryRecommendationsRequestDto? |  (optional) 

            try
            {
                PostgresQueryRecommendationDtoPostgresQueryRecommendationCollectionDtoArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesPost(baseMonitorName, postgresQueryRecommendationsRequestDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryRecommendationsApiApi.ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostgresQueryRecommendationDtoPostgresQueryRecommendationCollectionDtoArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesPostWithHttpInfo(baseMonitorName, postgresQueryRecommendationsRequestDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryRecommendationsApiApi.ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **postgresQueryRecommendationsRequestDto** | [**PostgresQueryRecommendationsRequestDto?**](PostgresQueryRecommendationsRequestDto?.md) |  | [optional]  |

### Return type

[**PostgresQueryRecommendationDtoPostgresQueryRecommendationCollectionDtoArrayJSendSuccess**](PostgresQueryRecommendationDtoPostgresQueryRecommendationCollectionDtoArrayJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | Unprocessable Content |  -  |
| **503** | Service Unavailable |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamerecommendationspostgresinstancesqueryplanget"></a>
# **ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesQueryplanGet**
> PostgresQueryRecommendationDtoArrayJSendSuccess ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesQueryplanGet (PostgresInstanceChannelInstanceRef postgresInstanceCir, string queryHash, string databaseName, string queryId, string userId, string databaseId, bool topLevel, string planHash, DateTime startDate, DateTime endDate, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesQueryplanGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new QueryRecommendationsApiApi(config);
            var postgresInstanceCir = new PostgresInstanceChannelInstanceRef(); // PostgresInstanceChannelInstanceRef | 
            var queryHash = "queryHash_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var queryId = "queryId_example";  // string | 
            var userId = "userId_example";  // string | 
            var databaseId = "databaseId_example";  // string | 
            var topLevel = true;  // bool | 
            var planHash = "planHash_example";  // string | 
            var startDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var endDate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                PostgresQueryRecommendationDtoArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesQueryplanGet(postgresInstanceCir, queryHash, databaseName, queryId, userId, databaseId, topLevel, planHash, startDate, endDate, baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling QueryRecommendationsApiApi.ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesQueryplanGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesQueryplanGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostgresQueryRecommendationDtoArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesQueryplanGetWithHttpInfo(postgresInstanceCir, queryHash, databaseName, queryId, userId, databaseId, topLevel, planHash, startDate, endDate, baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling QueryRecommendationsApiApi.ApiBasemonitorsBaseMonitorNameRecommendationsPostgresinstancesQueryplanGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **postgresInstanceCir** | [**PostgresInstanceChannelInstanceRef**](PostgresInstanceChannelInstanceRef.md) |  |  |
| **queryHash** | **string** |  |  |
| **databaseName** | **string** |  |  |
| **queryId** | **string** |  |  |
| **userId** | **string** |  |  |
| **databaseId** | **string** |  |  |
| **topLevel** | **bool** |  |  |
| **planHash** | **string** |  |  |
| **startDate** | **DateTime** |  |  |
| **endDate** | **DateTime** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

[**PostgresQueryRecommendationDtoArrayJSendSuccess**](PostgresQueryRecommendationDtoArrayJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **422** | Unprocessable Content |  -  |
| **503** | Service Unavailable |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

