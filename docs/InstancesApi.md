# cli.Api.InstancesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesGet**](InstancesApi.md#apibasemonitorsbasemonitornameclustersclusternameinstancesget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/instances |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameGet**](InstancesApi.md#apibasemonitorsbasemonitornameclustersclusternameinstancesinstancenameget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/instances/{instanceName} |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNamePut**](InstancesApi.md#apibasemonitorsbasemonitornameclustersclusternameinstancesinstancenameput) | **PUT** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/instances/{instanceName} |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesGet**](InstancesApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/instances |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameGet**](InstancesApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesinstancenameget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/instances/{instanceName} |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNamePut**](InstancesApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesinstancenameput) | **PUT** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/instances/{instanceName} |  |
| [**ApiBasemonitorsBaseMonitorNameInstancesGet**](InstancesApi.md#apibasemonitorsbasemonitornameinstancesget) | **GET** /api/basemonitors/{baseMonitorName}/instances |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesGet**](InstancesApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesget) | **GET** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/instances |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameGet**](InstancesApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesinstancenameget) | **GET** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/instances/{instanceName} |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNamePut**](InstancesApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesinstancenameput) | **PUT** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/instances/{instanceName} |  |

<a id="apibasemonitorsbasemonitornameclustersclusternameinstancesget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesGet (string clusterName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InstancesApi(config);
            var clusterName = "clusterName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesGet(clusterName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesGetWithHttpInfo(clusterName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternameinstancesinstancenameget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameGet (string clusterName, string instanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InstancesApi(config);
            var clusterName = "clusterName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameGet(clusterName, instanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameGetWithHttpInfo(clusterName, instanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **instanceName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternameinstancesinstancenameput"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNamePut**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNamePut (string clusterName, string instanceName, string baseMonitorName, ClusterInstanceDto? clusterInstanceDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InstancesApi(config);
            var clusterName = "clusterName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var clusterInstanceDto = new ClusterInstanceDto?(); // ClusterInstanceDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNamePut(clusterName, instanceName, baseMonitorName, clusterInstanceDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNamePutWithHttpInfo(clusterName, instanceName, baseMonitorName, clusterInstanceDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **instanceName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **clusterInstanceDto** | [**ClusterInstanceDto?**](ClusterInstanceDto?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesGet (string clusterName, string machineName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InstancesApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesGet(clusterName, machineName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesGetWithHttpInfo(clusterName, machineName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **machineName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesinstancenameget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameGet (string clusterName, string machineName, string instanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InstancesApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameGet(clusterName, machineName, instanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameGetWithHttpInfo(clusterName, machineName, instanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **machineName** | **string** |  |  |
| **instanceName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesinstancenameput"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNamePut**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNamePut (string clusterName, string machineName, string instanceName, string baseMonitorName, MachineInstanceDto? machineInstanceDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InstancesApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var machineInstanceDto = new MachineInstanceDto?(); // MachineInstanceDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNamePut(clusterName, machineName, instanceName, baseMonitorName, machineInstanceDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNamePutWithHttpInfo(clusterName, machineName, instanceName, baseMonitorName, machineInstanceDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **machineName** | **string** |  |  |
| **instanceName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **machineInstanceDto** | [**MachineInstanceDto?**](MachineInstanceDto?.md) |  | [optional]  |

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

<a id="apibasemonitorsbasemonitornameinstancesget"></a>
# **ApiBasemonitorsBaseMonitorNameInstancesGet**
> void ApiBasemonitorsBaseMonitorNameInstancesGet (string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameInstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InstancesApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameInstancesGet(baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameInstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameInstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameInstancesGetWithHttpInfo(baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameInstancesGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesget"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesGet**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesGet (string machineName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InstancesApi(config);
            var machineName = "machineName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesGet(machineName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesGetWithHttpInfo(machineName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesinstancenameget"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameGet**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameGet (string machineName, string instanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InstancesApi(config);
            var machineName = "machineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameGet(machineName, instanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameGetWithHttpInfo(machineName, instanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
| **instanceName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesinstancenameput"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNamePut**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNamePut (string machineName, string instanceName, string baseMonitorName, MachineInstanceDto? machineInstanceDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNamePutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InstancesApi(config);
            var machineName = "machineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var machineInstanceDto = new MachineInstanceDto?(); // MachineInstanceDto? |  (optional) 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNamePut(machineName, instanceName, baseMonitorName, machineInstanceDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNamePut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNamePutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNamePutWithHttpInfo(machineName, instanceName, baseMonitorName, machineInstanceDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstancesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNamePutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
| **instanceName** | **string** |  |  |
| **baseMonitorName** | **string** |  |  |
| **machineInstanceDto** | [**MachineInstanceDto?**](MachineInstanceDto?.md) |  | [optional]  |

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

