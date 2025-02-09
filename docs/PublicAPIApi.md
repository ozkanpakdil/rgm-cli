# cli.Api.PublicAPIApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiV1AlertsGet**](PublicAPIApi.md#apiv1alertsget) | **GET** /api/v1/alerts |  |
| [**ApiV1AlertsTypesGet**](PublicAPIApi.md#apiv1alertstypesget) | **GET** /api/v1/alerts/types |  |
| [**ApiV1BackupsGet**](PublicAPIApi.md#apiv1backupsget) | **GET** /api/v1/backups |  |
| [**ApiV1DiskUsageGet**](PublicAPIApi.md#apiv1diskusageget) | **GET** /api/v1/disk-usage |  |
| [**ApiV1MetricsGet**](PublicAPIApi.md#apiv1metricsget) | **GET** /api/v1/metrics |  |
| [**ApiV1MetricsTypesGet**](PublicAPIApi.md#apiv1metricstypesget) | **GET** /api/v1/metrics/types |  |
| [**ApiV1MonitoredEntitiesGet**](PublicAPIApi.md#apiv1monitoredentitiesget) | **GET** /api/v1/monitored-entities |  |
| [**ApiV1MonitoredEntitiesTypesGet**](PublicAPIApi.md#apiv1monitoredentitiestypesget) | **GET** /api/v1/monitored-entities/types |  |

<a id="apiv1alertsget"></a>
# **ApiV1AlertsGet**
> AlertDetailDtoArrayJSendSuccess ApiV1AlertsGet (string alertTypeId, string? monitoredEntityId = null, DateTime? start = null, DateTime? end = null, int? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiV1AlertsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PublicAPIApi(config);
            var alertTypeId = "alertTypeId_example";  // string | 
            var monitoredEntityId = "monitoredEntityId_example";  // string? |  (optional) 
            var start = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var end = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var limit = 56;  // int? |  (optional) 

            try
            {
                AlertDetailDtoArrayJSendSuccess result = apiInstance.ApiV1AlertsGet(alertTypeId, monitoredEntityId, start, end, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAPIApi.ApiV1AlertsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1AlertsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertDetailDtoArrayJSendSuccess> response = apiInstance.ApiV1AlertsGetWithHttpInfo(alertTypeId, monitoredEntityId, start, end, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAPIApi.ApiV1AlertsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertTypeId** | **string** |  |  |
| **monitoredEntityId** | **string?** |  | [optional]  |
| **start** | **DateTime?** |  | [optional]  |
| **end** | **DateTime?** |  | [optional]  |
| **limit** | **int?** |  | [optional]  |

### Return type

[**AlertDetailDtoArrayJSendSuccess**](AlertDetailDtoArrayJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **416** | Range Not Satisfiable |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1alertstypesget"></a>
# **ApiV1AlertsTypesGet**
> AlertTypeDtoArrayJSendSuccess ApiV1AlertsTypesGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiV1AlertsTypesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PublicAPIApi(config);

            try
            {
                AlertTypeDtoArrayJSendSuccess result = apiInstance.ApiV1AlertsTypesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAPIApi.ApiV1AlertsTypesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1AlertsTypesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertTypeDtoArrayJSendSuccess> response = apiInstance.ApiV1AlertsTypesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAPIApi.ApiV1AlertsTypesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AlertTypeDtoArrayJSendSuccess**](AlertTypeDtoArrayJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1backupsget"></a>
# **ApiV1BackupsGet**
> DatabaseBackupDtoArrayJSendSuccess ApiV1BackupsGet (string? monitoredEntityId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiV1BackupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PublicAPIApi(config);
            var monitoredEntityId = "monitoredEntityId_example";  // string? |  (optional) 

            try
            {
                DatabaseBackupDtoArrayJSendSuccess result = apiInstance.ApiV1BackupsGet(monitoredEntityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAPIApi.ApiV1BackupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1BackupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DatabaseBackupDtoArrayJSendSuccess> response = apiInstance.ApiV1BackupsGetWithHttpInfo(monitoredEntityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAPIApi.ApiV1BackupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **monitoredEntityId** | **string?** |  | [optional]  |

### Return type

[**DatabaseBackupDtoArrayJSendSuccess**](DatabaseBackupDtoArrayJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1diskusageget"></a>
# **ApiV1DiskUsageGet**
> DiskUsageDtoArrayJSendSuccess ApiV1DiskUsageGet (string? monitoredEntityId = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiV1DiskUsageGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PublicAPIApi(config);
            var monitoredEntityId = "monitoredEntityId_example";  // string? |  (optional) 

            try
            {
                DiskUsageDtoArrayJSendSuccess result = apiInstance.ApiV1DiskUsageGet(monitoredEntityId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAPIApi.ApiV1DiskUsageGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1DiskUsageGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DiskUsageDtoArrayJSendSuccess> response = apiInstance.ApiV1DiskUsageGetWithHttpInfo(monitoredEntityId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAPIApi.ApiV1DiskUsageGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **monitoredEntityId** | **string?** |  | [optional]  |

### Return type

[**DiskUsageDtoArrayJSendSuccess**](DiskUsageDtoArrayJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1metricsget"></a>
# **ApiV1MetricsGet**
> MetricDtoArrayJSendSuccess ApiV1MetricsGet (string metricTypeId, string? monitoredEntityId = null, DateTime? start = null, DateTime? end = null, int? maxSampleCount = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiV1MetricsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PublicAPIApi(config);
            var metricTypeId = "metricTypeId_example";  // string | 
            var monitoredEntityId = "monitoredEntityId_example";  // string? |  (optional) 
            var start = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var end = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var maxSampleCount = 56;  // int? |  (optional) 

            try
            {
                MetricDtoArrayJSendSuccess result = apiInstance.ApiV1MetricsGet(metricTypeId, monitoredEntityId, start, end, maxSampleCount);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAPIApi.ApiV1MetricsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1MetricsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MetricDtoArrayJSendSuccess> response = apiInstance.ApiV1MetricsGetWithHttpInfo(metricTypeId, monitoredEntityId, start, end, maxSampleCount);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAPIApi.ApiV1MetricsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **metricTypeId** | **string** |  |  |
| **monitoredEntityId** | **string?** |  | [optional]  |
| **start** | **DateTime?** |  | [optional]  |
| **end** | **DateTime?** |  | [optional]  |
| **maxSampleCount** | **int?** |  | [optional]  |

### Return type

[**MetricDtoArrayJSendSuccess**](MetricDtoArrayJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **416** | Range Not Satisfiable |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1metricstypesget"></a>
# **ApiV1MetricsTypesGet**
> MetricTypeDtoArrayJSendSuccess ApiV1MetricsTypesGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiV1MetricsTypesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PublicAPIApi(config);

            try
            {
                MetricTypeDtoArrayJSendSuccess result = apiInstance.ApiV1MetricsTypesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAPIApi.ApiV1MetricsTypesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1MetricsTypesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MetricTypeDtoArrayJSendSuccess> response = apiInstance.ApiV1MetricsTypesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAPIApi.ApiV1MetricsTypesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MetricTypeDtoArrayJSendSuccess**](MetricTypeDtoArrayJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1monitoredentitiesget"></a>
# **ApiV1MonitoredEntitiesGet**
> MonitoredEntityDtoArrayJSendSuccess ApiV1MonitoredEntitiesGet (EntityType? entityType = null, string? filter = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiV1MonitoredEntitiesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PublicAPIApi(config);
            var entityType = new EntityType?(); // EntityType? |  (optional) 
            var filter = "\"\"";  // string? |  (optional)  (default to "")

            try
            {
                MonitoredEntityDtoArrayJSendSuccess result = apiInstance.ApiV1MonitoredEntitiesGet(entityType, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAPIApi.ApiV1MonitoredEntitiesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1MonitoredEntitiesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<MonitoredEntityDtoArrayJSendSuccess> response = apiInstance.ApiV1MonitoredEntitiesGetWithHttpInfo(entityType, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAPIApi.ApiV1MonitoredEntitiesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **entityType** | [**EntityType?**](EntityType?.md) |  | [optional]  |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |

### Return type

[**MonitoredEntityDtoArrayJSendSuccess**](MonitoredEntityDtoArrayJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiv1monitoredentitiestypesget"></a>
# **ApiV1MonitoredEntitiesTypesGet**
> EntityTypeArrayJSendSuccess ApiV1MonitoredEntitiesTypesGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiV1MonitoredEntitiesTypesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new PublicAPIApi(config);

            try
            {
                EntityTypeArrayJSendSuccess result = apiInstance.ApiV1MonitoredEntitiesTypesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PublicAPIApi.ApiV1MonitoredEntitiesTypesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiV1MonitoredEntitiesTypesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<EntityTypeArrayJSendSuccess> response = apiInstance.ApiV1MonitoredEntitiesTypesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PublicAPIApi.ApiV1MonitoredEntitiesTypesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**EntityTypeArrayJSendSuccess**](EntityTypeArrayJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

