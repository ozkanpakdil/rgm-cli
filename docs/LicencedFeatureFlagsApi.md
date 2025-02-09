# cli.Api.LicencedFeatureFlagsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiLicencedfeatureflagsGet**](LicencedFeatureFlagsApi.md#apilicencedfeatureflagsget) | **GET** /api/licencedfeatureflags |  |

<a id="apilicencedfeatureflagsget"></a>
# **ApiLicencedfeatureflagsGet**
> LicencedFeatureFlagJSendSuccess ApiLicencedfeatureflagsGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiLicencedfeatureflagsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LicencedFeatureFlagsApi(config);

            try
            {
                LicencedFeatureFlagJSendSuccess result = apiInstance.ApiLicencedfeatureflagsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LicencedFeatureFlagsApi.ApiLicencedfeatureflagsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiLicencedfeatureflagsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<LicencedFeatureFlagJSendSuccess> response = apiInstance.ApiLicencedfeatureflagsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LicencedFeatureFlagsApi.ApiLicencedfeatureflagsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**LicencedFeatureFlagJSendSuccess**](LicencedFeatureFlagJSendSuccess.md)

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

