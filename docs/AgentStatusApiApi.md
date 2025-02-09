# cli.Api.AgentStatusApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiAgentsGet**](AgentStatusApiApi.md#apiagentsget) | **GET** /api/agents |  |

<a id="apiagentsget"></a>
# **ApiAgentsGet**
> AgentStatusDtoArrayJSendSuccess ApiAgentsGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAgentsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AgentStatusApiApi(config);

            try
            {
                AgentStatusDtoArrayJSendSuccess result = apiInstance.ApiAgentsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgentStatusApiApi.ApiAgentsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAgentsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AgentStatusDtoArrayJSendSuccess> response = apiInstance.ApiAgentsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AgentStatusApiApi.ApiAgentsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**AgentStatusDtoArrayJSendSuccess**](AgentStatusDtoArrayJSendSuccess.md)

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

