# cli.Api.ManageUsersApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiUsersAddEditPrincipalPost**](ManageUsersApiApi.md#apiusersaddeditprincipalpost) | **POST** /api/users/addEditPrincipal |  |
| [**ApiUsersPrincipaleditorPost**](ManageUsersApiApi.md#apiusersprincipaleditorpost) | **POST** /api/users/principaleditor |  |
| [**ApiUsersPrincipalsGet**](ManageUsersApiApi.md#apiusersprincipalsget) | **GET** /api/users/principals |  |
| [**ApiUsersPrincipalsPrincipalNameDelete**](ManageUsersApiApi.md#apiusersprincipalsprincipalnamedelete) | **DELETE** /api/users/principals/{principalName} |  |

<a id="apiusersaddeditprincipalpost"></a>
# **ApiUsersAddEditPrincipalPost**
> JSendSuccess ApiUsersAddEditPrincipalPost (PrincipalEditorDto? principalEditorDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiUsersAddEditPrincipalPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageUsersApiApi(config);
            var principalEditorDto = new PrincipalEditorDto?(); // PrincipalEditorDto? |  (optional) 

            try
            {
                JSendSuccess result = apiInstance.ApiUsersAddEditPrincipalPost(principalEditorDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageUsersApiApi.ApiUsersAddEditPrincipalPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersAddEditPrincipalPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiUsersAddEditPrincipalPostWithHttpInfo(principalEditorDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageUsersApiApi.ApiUsersAddEditPrincipalPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **principalEditorDto** | [**PrincipalEditorDto?**](PrincipalEditorDto?.md) |  | [optional]  |

### Return type

[**JSendSuccess**](JSendSuccess.md)

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
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersprincipaleditorpost"></a>
# **ApiUsersPrincipaleditorPost**
> PrincipalEditorDtoJSendSuccess ApiUsersPrincipaleditorPost (PrincipalDto? principalDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiUsersPrincipaleditorPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageUsersApiApi(config);
            var principalDto = new PrincipalDto?(); // PrincipalDto? |  (optional) 

            try
            {
                PrincipalEditorDtoJSendSuccess result = apiInstance.ApiUsersPrincipaleditorPost(principalDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageUsersApiApi.ApiUsersPrincipaleditorPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersPrincipaleditorPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PrincipalEditorDtoJSendSuccess> response = apiInstance.ApiUsersPrincipaleditorPostWithHttpInfo(principalDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageUsersApiApi.ApiUsersPrincipaleditorPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **principalDto** | [**PrincipalDto?**](PrincipalDto?.md) |  | [optional]  |

### Return type

[**PrincipalEditorDtoJSendSuccess**](PrincipalEditorDtoJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiusersprincipalsget"></a>
# **ApiUsersPrincipalsGet**
> PrincipalDtoArrayJSendSuccess ApiUsersPrincipalsGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiUsersPrincipalsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageUsersApiApi(config);

            try
            {
                PrincipalDtoArrayJSendSuccess result = apiInstance.ApiUsersPrincipalsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageUsersApiApi.ApiUsersPrincipalsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersPrincipalsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PrincipalDtoArrayJSendSuccess> response = apiInstance.ApiUsersPrincipalsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageUsersApiApi.ApiUsersPrincipalsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**PrincipalDtoArrayJSendSuccess**](PrincipalDtoArrayJSendSuccess.md)

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

<a id="apiusersprincipalsprincipalnamedelete"></a>
# **ApiUsersPrincipalsPrincipalNameDelete**
> JSendSuccess ApiUsersPrincipalsPrincipalNameDelete (string principalName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiUsersPrincipalsPrincipalNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ManageUsersApiApi(config);
            var principalName = "principalName_example";  // string | 

            try
            {
                JSendSuccess result = apiInstance.ApiUsersPrincipalsPrincipalNameDelete(principalName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManageUsersApiApi.ApiUsersPrincipalsPrincipalNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiUsersPrincipalsPrincipalNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<JSendSuccess> response = apiInstance.ApiUsersPrincipalsPrincipalNameDeleteWithHttpInfo(principalName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManageUsersApiApi.ApiUsersPrincipalsPrincipalNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **principalName** | **string** |  |  |

### Return type

[**JSendSuccess**](JSendSuccess.md)

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

