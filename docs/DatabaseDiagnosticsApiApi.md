# cli.Api.DatabaseDiagnosticsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameDiagnosticsGetDataTableSizesGet**](DatabaseDiagnosticsApiApi.md#apibasemonitorsbasemonitornamediagnosticsgetdatatablesizesget) | **GET** /api/basemonitors/{baseMonitorName}/diagnostics/getDataTableSizes |  |
| [**ApiDiagnosticsGetDatabaseTimingsGet**](DatabaseDiagnosticsApiApi.md#apidiagnosticsgetdatabasetimingsget) | **GET** /api/diagnostics/getDatabaseTimings |  |

<a id="apibasemonitorsbasemonitornamediagnosticsgetdatatablesizesget"></a>
# **ApiBasemonitorsBaseMonitorNameDiagnosticsGetDataTableSizesGet**
> DataTableSizeDtoArrayJSendSuccess ApiBasemonitorsBaseMonitorNameDiagnosticsGetDataTableSizesGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameDiagnosticsGetDataTableSizesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabaseDiagnosticsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                DataTableSizeDtoArrayJSendSuccess result = apiInstance.ApiBasemonitorsBaseMonitorNameDiagnosticsGetDataTableSizesGet(baseMonitorName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabaseDiagnosticsApiApi.ApiBasemonitorsBaseMonitorNameDiagnosticsGetDataTableSizesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameDiagnosticsGetDataTableSizesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DataTableSizeDtoArrayJSendSuccess> response = apiInstance.ApiBasemonitorsBaseMonitorNameDiagnosticsGetDataTableSizesGetWithHttpInfo(baseMonitorName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabaseDiagnosticsApiApi.ApiBasemonitorsBaseMonitorNameDiagnosticsGetDataTableSizesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

### Return type

[**DataTableSizeDtoArrayJSendSuccess**](DataTableSizeDtoArrayJSendSuccess.md)

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

<a id="apidiagnosticsgetdatabasetimingsget"></a>
# **ApiDiagnosticsGetDatabaseTimingsGet**
> DatabaseDiagnosticsDtoArrayJSendSuccess ApiDiagnosticsGetDatabaseTimingsGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsGetDatabaseTimingsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabaseDiagnosticsApiApi(config);

            try
            {
                DatabaseDiagnosticsDtoArrayJSendSuccess result = apiInstance.ApiDiagnosticsGetDatabaseTimingsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabaseDiagnosticsApiApi.ApiDiagnosticsGetDatabaseTimingsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsGetDatabaseTimingsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DatabaseDiagnosticsDtoArrayJSendSuccess> response = apiInstance.ApiDiagnosticsGetDatabaseTimingsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabaseDiagnosticsApiApi.ApiDiagnosticsGetDatabaseTimingsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**DatabaseDiagnosticsDtoArrayJSendSuccess**](DatabaseDiagnosticsDtoArrayJSendSuccess.md)

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

