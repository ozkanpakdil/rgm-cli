# cli.Api.AuthDiagnosticsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiDiagnosticsAuthGet**](AuthDiagnosticsApi.md#apidiagnosticsauthget) | **GET** /api/diagnostics/auth |  |

<a id="apidiagnosticsauthget"></a>
# **ApiDiagnosticsAuthGet**
> void ApiDiagnosticsAuthGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiDiagnosticsAuthGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AuthDiagnosticsApi(config);

            try
            {
                apiInstance.ApiDiagnosticsAuthGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthDiagnosticsApi.ApiDiagnosticsAuthGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiDiagnosticsAuthGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiDiagnosticsAuthGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthDiagnosticsApi.ApiDiagnosticsAuthGetWithHttpInfo: " + e.Message);
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

