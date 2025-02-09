# cli.Api.AlertsGroupDetailsApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GroupedAlertsDetails**](AlertsGroupDetailsApiApi.md#groupedalertsdetails) | **POST** /api/basemonitors/{baseMonitorName}/alerts/alertsgroupdetails |  |

<a id="groupedalertsdetails"></a>
# **GroupedAlertsDetails**
> AlertGroupDetailsJSendSuccess GroupedAlertsDetails (string baseMonitorName, ChannelInstanceRef? groupCir = null, long? asOfTicks = null, int? skip = null, int? limit = null, FilterSettingsDto? filterSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class GroupedAlertsDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertsGroupDetailsApiApi(config);
            var baseMonitorName = "baseMonitorName_example";  // string | 
            var groupCir = new ChannelInstanceRef?(); // ChannelInstanceRef? |  (optional) 
            var asOfTicks = 789L;  // long? |  (optional) 
            var skip = 0;  // int? |  (optional)  (default to 0)
            var limit = 100;  // int? |  (optional)  (default to 100)
            var filterSettingsDto = new FilterSettingsDto?(); // FilterSettingsDto? |  (optional) 

            try
            {
                AlertGroupDetailsJSendSuccess result = apiInstance.GroupedAlertsDetails(baseMonitorName, groupCir, asOfTicks, skip, limit, filterSettingsDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertsGroupDetailsApiApi.GroupedAlertsDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupedAlertsDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<AlertGroupDetailsJSendSuccess> response = apiInstance.GroupedAlertsDetailsWithHttpInfo(baseMonitorName, groupCir, asOfTicks, skip, limit, filterSettingsDto);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertsGroupDetailsApiApi.GroupedAlertsDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **baseMonitorName** | **string** |  |  |
| **groupCir** | [**ChannelInstanceRef?**](ChannelInstanceRef?.md) |  | [optional]  |
| **asOfTicks** | **long?** |  | [optional]  |
| **skip** | **int?** |  | [optional] [default to 0] |
| **limit** | **int?** |  | [optional] [default to 100] |
| **filterSettingsDto** | [**FilterSettingsDto?**](FilterSettingsDto?.md) |  | [optional]  |

### Return type

[**AlertGroupDetailsJSendSuccess**](AlertGroupDetailsJSendSuccess.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

