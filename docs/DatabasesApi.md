# cli.Api.DatabasesApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameGet**](DatabasesApi.md#apibasemonitorsbasemonitornameclustersclusternameinstancesinstancenamedatabasesdatabasenameget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/instances/{instanceName}/databases/{databaseName} |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesGet**](DatabasesApi.md#apibasemonitorsbasemonitornameclustersclusternameinstancesinstancenamedatabasesget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/instances/{instanceName}/databases |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGet**](DatabasesApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesinstancenamedatabasesdatabasenameget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/instances/{instanceName}/databases/{databaseName} |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesGet**](DatabasesApi.md#apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesinstancenamedatabasesget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/machines/{machineName}/instances/{instanceName}/databases |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGet**](DatabasesApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesinstancenamedatabasesdatabasenameget) | **GET** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/instances/{instanceName}/databases/{databaseName} |  |
| [**ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesGet**](DatabasesApi.md#apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesinstancenamedatabasesget) | **GET** /api/basemonitors/{baseMonitorName}/standalonemachines/{machineName}/instances/{instanceName}/databases |  |

<a id="apibasemonitorsbasemonitornameclustersclusternameinstancesinstancenamedatabasesdatabasenameget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameGet (string clusterName, string instanceName, string databaseName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabasesApi(config);
            var clusterName = "clusterName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameGet(clusterName, instanceName, databaseName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabasesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameGetWithHttpInfo(clusterName, instanceName, databaseName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabasesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesDatabaseNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **instanceName** | **string** |  |  |
| **databaseName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternameinstancesinstancenamedatabasesget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesGet (string clusterName, string instanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabasesApi(config);
            var clusterName = "clusterName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesGet(clusterName, instanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabasesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesGetWithHttpInfo(clusterName, instanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabasesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameInstancesInstanceNameDatabasesGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesinstancenamedatabasesdatabasenameget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGet (string clusterName, string machineName, string instanceName, string databaseName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabasesApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGet(clusterName, machineName, instanceName, databaseName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabasesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGetWithHttpInfo(clusterName, machineName, instanceName, databaseName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabasesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGetWithHttpInfo: " + e.Message);
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
| **databaseName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternamemachinesmachinenameinstancesinstancenamedatabasesget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesGet (string clusterName, string machineName, string instanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabasesApi(config);
            var clusterName = "clusterName_example";  // string | 
            var machineName = "machineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesGet(clusterName, machineName, instanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabasesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesGetWithHttpInfo(clusterName, machineName, instanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabasesApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameMachinesMachineNameInstancesInstanceNameDatabasesGetWithHttpInfo: " + e.Message);
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesinstancenamedatabasesdatabasenameget"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGet**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGet (string machineName, string instanceName, string databaseName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabasesApi(config);
            var machineName = "machineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var databaseName = "databaseName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGet(machineName, instanceName, databaseName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabasesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGetWithHttpInfo(machineName, instanceName, databaseName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabasesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesDatabaseNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **machineName** | **string** |  |  |
| **instanceName** | **string** |  |  |
| **databaseName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornamestandalonemachinesmachinenameinstancesinstancenamedatabasesget"></a>
# **ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesGet**
> void ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesGet (string machineName, string instanceName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DatabasesApi(config);
            var machineName = "machineName_example";  // string | 
            var instanceName = "instanceName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesGet(machineName, instanceName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatabasesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesGetWithHttpInfo(machineName, instanceName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatabasesApi.ApiBasemonitorsBaseMonitorNameStandalonemachinesMachineNameInstancesInstanceNameDatabasesGetWithHttpInfo: " + e.Message);
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

