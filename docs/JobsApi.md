# cli.Api.JobsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsGet**](JobsApi.md#apibasemonitorsbasemonitornameclustersclusternameinstancesinstancenamejobsget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/instances/{instanceName}/jobs |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsJobNameGet**](JobsApi.md#apibasemonitorsbasemonitornameclustersclusternameinstancesinstancenamejobsjobnameget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/instances/{instanceName}/jobs/{jobName} |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsGet**](JobsApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesinstancenamejobsget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/instances/{instanceName}/jobs |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsJobNameGet**](JobsApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesinstancenamejobsjobnameget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/instances/{instanceName}/jobs/{jobName} |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsGet**](JobsApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesinstancenamejobsget) | **GET** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/instances/{instanceName}/jobs |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsJobNameGet**](JobsApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesinstancenamejobsjobnameget) | **GET** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/instances/{instanceName}/jobs/{jobName} |  |

<a id="apibasemonitorsbasemonitornameclustersclusternameinstancesinstancenamejobsget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsGet (string clusterName, string instanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new JobsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsGet(clusterName, instanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsGetWithHttpInfo(clusterName, instanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornameclustersclusternameinstancesinstancenamejobsjobnameget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsJobNameGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsJobNameGet (string clusterName, string instanceName, string jobName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsJobNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new JobsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var jobName = "jobName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsJobNameGet(clusterName, instanceName, jobName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsJobNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsJobNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsJobNameGetWithHttpInfo(clusterName, instanceName, jobName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameJobsJobNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **instanceName** | **string** |  |  |
| **jobName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesinstancenamejobsget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsGet (string clusterName, string machineName, string instanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new JobsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsGet(clusterName, machineName, instanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsGetWithHttpInfo(clusterName, machineName, instanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesinstancenamejobsjobnameget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsJobNameGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsJobNameGet (string clusterName, string machineName, string instanceName, string jobName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsJobNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new JobsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var jobName = "jobName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsJobNameGet(clusterName, machineName, instanceName, jobName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsJobNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsJobNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsJobNameGetWithHttpInfo(clusterName, machineName, instanceName, jobName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameJobsJobNameGetWithHttpInfo: " + e.Message);
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
| **jobName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesinstancenamejobsget"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsGet**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsGet (string machineName, string instanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new JobsApi(config);
            var machineName = "machineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsGet(machineName, instanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsGetWithHttpInfo(machineName, instanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesinstancenamejobsjobnameget"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsJobNameGet**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsJobNameGet (string machineName, string instanceName, string jobName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsJobNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new JobsApi(config);
            var machineName = "machineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var jobName = "jobName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsJobNameGet(machineName, instanceName, jobName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsJobNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsJobNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsJobNameGetWithHttpInfo(machineName, instanceName, jobName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameJobsJobNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
| **instanceName** | **string** |  |  |
| **jobName** | **string** |  |  |
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

