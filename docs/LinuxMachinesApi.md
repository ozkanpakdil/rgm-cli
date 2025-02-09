# cli.Api.LinuxMachinesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesGet**](LinuxMachinesApi.md#apibasemonitorsbasemonitornamelinuxmachinesget) | **GET** /api/basemonitors/{baseMonitorName}/linuxmachines |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameDelete**](LinuxMachinesApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenamedelete) | **DELETE** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName} |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameGet**](LinuxMachinesApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameget) | **GET** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName} |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesGet**](LinuxMachinesApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesget) | **GET** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName}/instances |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNamePut**](LinuxMachinesApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenameput) | **PUT** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName}/instances/{instanceName} |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePostgresinstancesGet**](LinuxMachinesApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenamepostgresinstancesget) | **GET** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName}/postgresinstances |  |
| [**ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePut**](LinuxMachinesApi.md#apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameput) | **PUT** /api/basemonitors/{baseMonitorName}/linuxmachines/{linuxMachineName} |  |

<a id="apibasemonitorsbasemonitornamelinuxmachinesget"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesGet**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LinuxMachinesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesGetWithHttpInfo: " + e.Message);
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
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenamedelete"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameDelete**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameDelete (string linuxMachineName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LinuxMachinesApi(config);
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameDelete(linuxMachineName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameDeleteWithHttpInfo(linuxMachineName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linuxMachineName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameget"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameGet**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameGet (string linuxMachineName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LinuxMachinesApi(config);
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameGet(linuxMachineName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameGetWithHttpInfo(linuxMachineName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linuxMachineName** | **string** |  |  |
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
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesget"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesGet**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesGet (string linuxMachineName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LinuxMachinesApi(config);
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesGet(linuxMachineName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesGetWithHttpInfo(linuxMachineName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linuxMachineName** | **string** |  |  |
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
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameinstancesinstancenameput"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNamePut**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNamePut (string linuxMachineName, string instanceName, string baseMonitorName, HostedSqlServerInstanceDto? hostedSqlServerInstanceDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LinuxMachinesApi(config);
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var hostedSqlServerInstanceDto = new HostedSqlServerInstanceDto?(); // HostedSqlServerInstanceDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNamePut(linuxMachineName, instanceName, baseMonitorName, hostedSqlServerInstanceDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNamePutWithHttpInfo(linuxMachineName, instanceName, baseMonitorName, hostedSqlServerInstanceDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNameInstancesInstanceNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linuxMachineName** | **string** |  |  |
| **instanceName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **hostedSqlServerInstanceDto** | [**HostedSqlServerInstanceDto?**](HostedSqlServerInstanceDto?.md) |  | [optional]  |

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
| **204** | No Content |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenamepostgresinstancesget"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePostgresinstancesGet**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePostgresinstancesGet (string linuxMachineName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePostgresinstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LinuxMachinesApi(config);
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePostgresinstancesGet(linuxMachineName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePostgresinstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePostgresinstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePostgresinstancesGetWithHttpInfo(linuxMachineName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePostgresinstancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linuxMachineName** | **string** |  |  |
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
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apibasemonitorsbasemonitornamelinuxmachineslinuxmachinenameput"></a>
# **ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePut**
> void ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePut (string linuxMachineName, string baseMonitorName, LinuxMachineDto? linuxMachineDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LinuxMachinesApi(config);
            var linuxMachineName = "linuxMachineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var linuxMachineDto = new LinuxMachineDto?(); // LinuxMachineDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePut(linuxMachineName, baseMonitorName, linuxMachineDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePutWithHttpInfo(linuxMachineName, baseMonitorName, linuxMachineDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LinuxMachinesApi.ApiBasemonitorsBaseMonitorNameLinuxmachinesLinuxMachineNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **linuxMachineName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **linuxMachineDto** | [**LinuxMachineDto?**](LinuxMachineDto?.md) |  | [optional]  |

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
| **204** | No Content |  -  |
| **404** | Not Found |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

