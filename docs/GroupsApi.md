# cli.Api.GroupsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameGroupsGet**](GroupsApi.md#apibasemonitorsbasemonitornamegroupsget) | **GET** /api/basemonitors/{baseMonitorName}/groups |  |
| [**ApiBasemonitorsBaseMonitorNameGroupsGroupIdDelete**](GroupsApi.md#apibasemonitorsbasemonitornamegroupsgroupiddelete) | **DELETE** /api/basemonitors/{baseMonitorName}/groups/{groupId} |  |
| [**ApiBasemonitorsBaseMonitorNameGroupsGroupIdGroupsGet**](GroupsApi.md#apibasemonitorsbasemonitornamegroupsgroupidgroupsget) | **GET** /api/basemonitors/{baseMonitorName}/groups/{groupId}/groups |  |
| [**ApiBasemonitorsBaseMonitorNameGroupsGroupNameGet**](GroupsApi.md#apibasemonitorsbasemonitornamegroupsgroupnameget) | **GET** /api/basemonitors/{baseMonitorName}/groups/{groupName} |  |
| [**ApiBasemonitorsBaseMonitorNameGroupsParentGroupIdGroupsPost**](GroupsApi.md#apibasemonitorsbasemonitornamegroupsparentgroupidgroupspost) | **POST** /api/basemonitors/{baseMonitorName}/groups/{parentGroupId}/groups |  |
| [**ApiBasemonitorsBaseMonitorNameMainGroupsGet**](GroupsApi.md#apibasemonitorsbasemonitornamemaingroupsget) | **GET** /api/basemonitors/{baseMonitorName}/mainGroups |  |
| [**ApiBasemonitorsBaseMonitorNameMainGroupsPost**](GroupsApi.md#apibasemonitorsbasemonitornamemaingroupspost) | **POST** /api/basemonitors/{baseMonitorName}/mainGroups |  |

<a id="apibasemonitorsbasemonitornamegroupsget"></a>
# **ApiBasemonitorsBaseMonitorNameGroupsGet**
> void ApiBasemonitorsBaseMonitorNameGroupsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GroupsApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameGroupsGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameGroupsGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

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
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamegroupsgroupiddelete"></a>
# **ApiBasemonitorsBaseMonitorNameGroupsGroupIdDelete**
> void ApiBasemonitorsBaseMonitorNameGroupsGroupIdDelete (Guid groupId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameGroupsGroupIdDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GroupsApi(config);
            var groupId = "groupId_example";  // Guid | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameGroupsGroupIdDelete(groupId, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameGroupsGroupIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameGroupsGroupIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameGroupsGroupIdDeleteWithHttpInfo(groupId, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameGroupsGroupIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** |  |  |
| **baseMonitorName** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamegroupsgroupidgroupsget"></a>
# **ApiBasemonitorsBaseMonitorNameGroupsGroupIdGroupsGet**
> void ApiBasemonitorsBaseMonitorNameGroupsGroupIdGroupsGet (Guid groupId, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameGroupsGroupIdGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GroupsApi(config);
            var groupId = "groupId_example";  // Guid | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameGroupsGroupIdGroupsGet(groupId, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameGroupsGroupIdGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameGroupsGroupIdGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameGroupsGroupIdGroupsGetWithHttpInfo(groupId, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameGroupsGroupIdGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupId** | **Guid** |  |  |
| **baseMonitorName** | **string** |  |  |

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
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamegroupsgroupnameget"></a>
# **ApiBasemonitorsBaseMonitorNameGroupsGroupNameGet**
> void ApiBasemonitorsBaseMonitorNameGroupsGroupNameGet (string groupName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameGroupsGroupNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GroupsApi(config);
            var groupName = "groupName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameGroupsGroupNameGet(groupName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameGroupsGroupNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameGroupsGroupNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameGroupsGroupNameGetWithHttpInfo(groupName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameGroupsGroupNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |

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
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamegroupsparentgroupidgroupspost"></a>
# **ApiBasemonitorsBaseMonitorNameGroupsParentGroupIdGroupsPost**
> void ApiBasemonitorsBaseMonitorNameGroupsParentGroupIdGroupsPost (Guid parentGroupId, string baseMonitorName, string? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameGroupsParentGroupIdGroupsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GroupsApi(config);
            var parentGroupId = "parentGroupId_example";  // Guid | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = "body_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameGroupsParentGroupIdGroupsPost(parentGroupId, baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameGroupsParentGroupIdGroupsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameGroupsParentGroupIdGroupsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameGroupsParentGroupIdGroupsPostWithHttpInfo(parentGroupId, baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameGroupsParentGroupIdGroupsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **parentGroupId** | **Guid** |  |  |
| **baseMonitorName** | **string** |  |  |
| **body** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamemaingroupsget"></a>
# **ApiBasemonitorsBaseMonitorNameMainGroupsGet**
> void ApiBasemonitorsBaseMonitorNameMainGroupsGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMainGroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GroupsApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameMainGroupsGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameMainGroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMainGroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameMainGroupsGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameMainGroupsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |

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
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamemaingroupspost"></a>
# **ApiBasemonitorsBaseMonitorNameMainGroupsPost**
> void ApiBasemonitorsBaseMonitorNameMainGroupsPost (string baseMonitorName, string? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameMainGroupsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GroupsApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var body = "body_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameMainGroupsPost(baseMonitorName, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameMainGroupsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameMainGroupsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameMainGroupsPostWithHttpInfo(baseMonitorName, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupsApi.ApiBasemonitorsBaseMonitorNameMainGroupsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **body** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

