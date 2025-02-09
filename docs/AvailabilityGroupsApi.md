# cli.Api.AvailabilityGroupsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet**](AvailabilityGroupsApi.md#apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsavailabilitygroupnameget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/availabilitygroups/{availabilityGroupName} |  |
| [**ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet**](AvailabilityGroupsApi.md#apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsget) | **GET** /api/basemonitors/{baseMonitorName}/clusters/{clusterName}/availabilitygroups |  |

<a id="apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsavailabilitygroupnameget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet (string clusterName, string availabilityGroupName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AvailabilityGroupsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var availabilityGroupName = "availabilityGroupName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet(clusterName, availabilityGroupName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityGroupsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGetWithHttpInfo(clusterName, availabilityGroupName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityGroupsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clusterName** | **string** |  |  |
| **availabilityGroupName** | **string** |  |  |
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

<a id="apibasemonitorsbasemonitornameclustersclusternameavailabilitygroupsget"></a>
# **ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet**
> void ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet (string clusterName, string baseMonitorName)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AvailabilityGroupsApi(config);
            var clusterName = "clusterName_example";  // string | 
            var baseMonitorName = "baseMonitorName_example";  // string | 

            try
            {
                apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet(clusterName, baseMonitorName);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AvailabilityGroupsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGetWithHttpInfo(clusterName, baseMonitorName);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AvailabilityGroupsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGetWithHttpInfo: " + e.Message);
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

