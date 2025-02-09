# cli.Api.SqlServerLicensingApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiEstateSqlServerLicensingGet**](SqlServerLicensingApiApi.md#apiestatesqlserverlicensingget) | **GET** /api/estate/sql-server-licensing |  |

<a id="apiestatesqlserverlicensingget"></a>
# **ApiEstateSqlServerLicensingGet**
> void ApiEstateSqlServerLicensingGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiEstateSqlServerLicensingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new SqlServerLicensingApiApi(config);

            try
            {
                apiInstance.ApiEstateSqlServerLicensingGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SqlServerLicensingApiApi.ApiEstateSqlServerLicensingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiEstateSqlServerLicensingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiEstateSqlServerLicensingGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SqlServerLicensingApiApi.ApiEstateSqlServerLicensingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

