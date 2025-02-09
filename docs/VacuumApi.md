# cli.Api.VacuumApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetDetailedVacuumDataGet**](VacuumApi.md#apibasemonitorsbasemonitornamepostgresserversdbmscirgetdetailedvacuumdataget) | **GET** /api/basemonitors/{baseMonitorName}/postgresservers/{dbmsCir}/GetDetailedVacuumData |  |
| [**ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetVacuumDataGet**](VacuumApi.md#apibasemonitorsbasemonitornamepostgresserversdbmscirgetvacuumdataget) | **GET** /api/basemonitors/{baseMonitorName}/postgresservers/{dbmsCir}/GetVacuumData |  |

<a id="apibasemonitorsbasemonitornamepostgresserversdbmscirgetdetailedvacuumdataget"></a>
# **ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetDetailedVacuumDataGet**
> void ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetDetailedVacuumDataGet (PostgresInstanceDatabaseTableChannelInstanceRef dbmsCir, string baseMonitorName, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetDetailedVacuumDataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new VacuumApi(config);
            var dbmsCir = new PostgresInstanceDatabaseTableChannelInstanceRef(); // PostgresInstanceDatabaseTableChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetDetailedVacuumDataGet(dbmsCir, baseMonitorName, startTime, endTime);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VacuumApi.ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetDetailedVacuumDataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetDetailedVacuumDataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetDetailedVacuumDataGetWithHttpInfo(dbmsCir, baseMonitorName, startTime, endTime);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VacuumApi.ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetDetailedVacuumDataGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dbmsCir** | [**PostgresInstanceDatabaseTableChannelInstanceRef**](PostgresInstanceDatabaseTableChannelInstanceRef.md) |  |  |
| **baseMonitorName** | **string** |  |  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornamepostgresserversdbmscirgetvacuumdataget"></a>
# **ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetVacuumDataGet**
> void ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetVacuumDataGet (PostgresInstanceChannelInstanceRef dbmsCir, string baseMonitorName, DateTime? startTime = null, DateTime? endTime = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetVacuumDataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new VacuumApi(config);
            var dbmsCir = new PostgresInstanceChannelInstanceRef(); // PostgresInstanceChannelInstanceRef | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var startTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 
            var endTime = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetVacuumDataGet(dbmsCir, baseMonitorName, startTime, endTime);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling VacuumApi.ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetVacuumDataGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetVacuumDataGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetVacuumDataGetWithHttpInfo(dbmsCir, baseMonitorName, startTime, endTime);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling VacuumApi.ApiBasemonitorsBaseMonitorNamePostgresserversDbmsCirGetVacuumDataGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dbmsCir** | [**PostgresInstanceChannelInstanceRef**](PostgresInstanceChannelInstanceRef.md) |  |  |
| **baseMonitorName** | **string** |  |  |
| **startTime** | **DateTime?** |  | [optional]  |
| **endTime** | **DateTime?** |  | [optional]  |

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

