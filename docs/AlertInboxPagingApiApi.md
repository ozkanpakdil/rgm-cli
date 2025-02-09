# cli.Api.AlertInboxPagingApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AlertReport**](AlertInboxPagingApiApi.md#alertreport) | **POST** /api/Alerts/alertsgroupinbox/alertreport |  |
| [**AlertsInboxLoad**](AlertInboxPagingApiApi.md#alertsinboxload) | **POST** /api/Alerts/alertsgroupinbox/load |  |
| [**AlertsInboxMoveNewer**](AlertInboxPagingApiApi.md#alertsinboxmovenewer) | **POST** /api/Alerts/alertsgroupinbox/moveNewer |  |
| [**AlertsInboxMoveNewest**](AlertInboxPagingApiApi.md#alertsinboxmovenewest) | **POST** /api/Alerts/alertsgroupinbox/moveNewest |  |
| [**AlertsInboxMoveOlder**](AlertInboxPagingApiApi.md#alertsinboxmoveolder) | **POST** /api/Alerts/alertsgroupinbox/moveOlder |  |
| [**AlertsInboxMoveOldest**](AlertInboxPagingApiApi.md#alertsinboxmoveoldest) | **POST** /api/Alerts/alertsgroupinbox/moveOldest |  |

<a id="alertreport"></a>
# **AlertReport**
> GroupOfAlertsDto AlertReport (int? pageSize = null, bool? isGrouped = null, long? timeRange = null, long? endDate = null, AlertReportTimeRangeType? timeRangeType = null, List<string>? channelInstanceRefs = null, AlertsFilterTimeRangeTypeDto? timeRangeType2 = null, int? timeRangeRelativeMinutes = null, long? timeRangeFromDateTime = null, long? timeRangeToDateTime = null, AlertsFilterTimeWindowModesDto? timeRangeTimeWindowMode = null, bool? includeStatusSeverityHigh = null, bool? includeStatusSeverityMedium = null, bool? includeStatusSeverityLow = null, bool? includeStatusReadYes = null, bool? includeStatusReadNo = null, bool? includeStatusClearedYes = null, bool? includeStatusClearedNo = null, bool? includeStatusStatusEvent = null, bool? includeStatusStatusActive = null, bool? includeStatusStatusEnded = null, bool? includeStatusCommentYes = null, bool? includeStatusCommentNo = null, List<string>? includeAlertTypeIds = null, List<TagDto>? selectedTags = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertReportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxPagingApiApi(config);
            var pageSize = 56;  // int? |  (optional) 
            var isGrouped = true;  // bool? |  (optional) 
            var timeRange = 789L;  // long? |  (optional) 
            var endDate = 789L;  // long? |  (optional) 
            var timeRangeType = new AlertReportTimeRangeType?(); // AlertReportTimeRangeType? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 
            var timeRangeType2 = new AlertsFilterTimeRangeTypeDto?(); // AlertsFilterTimeRangeTypeDto? |  (optional) 
            var timeRangeRelativeMinutes = 56;  // int? |  (optional) 
            var timeRangeFromDateTime = 789L;  // long? |  (optional) 
            var timeRangeToDateTime = 789L;  // long? |  (optional) 
            var timeRangeTimeWindowMode = new AlertsFilterTimeWindowModesDto?(); // AlertsFilterTimeWindowModesDto? |  (optional) 
            var includeStatusSeverityHigh = true;  // bool? |  (optional) 
            var includeStatusSeverityMedium = true;  // bool? |  (optional) 
            var includeStatusSeverityLow = true;  // bool? |  (optional) 
            var includeStatusReadYes = true;  // bool? |  (optional) 
            var includeStatusReadNo = true;  // bool? |  (optional) 
            var includeStatusClearedYes = true;  // bool? |  (optional) 
            var includeStatusClearedNo = true;  // bool? |  (optional) 
            var includeStatusStatusEvent = true;  // bool? |  (optional) 
            var includeStatusStatusActive = true;  // bool? |  (optional) 
            var includeStatusStatusEnded = true;  // bool? |  (optional) 
            var includeStatusCommentYes = true;  // bool? |  (optional) 
            var includeStatusCommentNo = true;  // bool? |  (optional) 
            var includeAlertTypeIds = new List<string>?(); // List<string>? |  (optional) 
            var selectedTags = new List<TagDto>?(); // List<TagDto>? |  (optional) 

            try
            {
                GroupOfAlertsDto result = apiInstance.AlertReport(pageSize, isGrouped, timeRange, endDate, timeRangeType, channelInstanceRefs, timeRangeType2, timeRangeRelativeMinutes, timeRangeFromDateTime, timeRangeToDateTime, timeRangeTimeWindowMode, includeStatusSeverityHigh, includeStatusSeverityMedium, includeStatusSeverityLow, includeStatusReadYes, includeStatusReadNo, includeStatusClearedYes, includeStatusClearedNo, includeStatusStatusEvent, includeStatusStatusActive, includeStatusStatusEnded, includeStatusCommentYes, includeStatusCommentNo, includeAlertTypeIds, selectedTags);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxPagingApiApi.AlertReport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertReportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<GroupOfAlertsDto> response = apiInstance.AlertReportWithHttpInfo(pageSize, isGrouped, timeRange, endDate, timeRangeType, channelInstanceRefs, timeRangeType2, timeRangeRelativeMinutes, timeRangeFromDateTime, timeRangeToDateTime, timeRangeTimeWindowMode, includeStatusSeverityHigh, includeStatusSeverityMedium, includeStatusSeverityLow, includeStatusReadYes, includeStatusReadNo, includeStatusClearedYes, includeStatusClearedNo, includeStatusStatusEvent, includeStatusStatusActive, includeStatusStatusEnded, includeStatusCommentYes, includeStatusCommentNo, includeAlertTypeIds, selectedTags);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxPagingApiApi.AlertReportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **int?** |  | [optional]  |
| **isGrouped** | **bool?** |  | [optional]  |
| **timeRange** | **long?** |  | [optional]  |
| **endDate** | **long?** |  | [optional]  |
| **timeRangeType** | [**AlertReportTimeRangeType?**](AlertReportTimeRangeType?.md) |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **timeRangeType2** | [**AlertsFilterTimeRangeTypeDto?**](AlertsFilterTimeRangeTypeDto?.md) |  | [optional]  |
| **timeRangeRelativeMinutes** | **int?** |  | [optional]  |
| **timeRangeFromDateTime** | **long?** |  | [optional]  |
| **timeRangeToDateTime** | **long?** |  | [optional]  |
| **timeRangeTimeWindowMode** | [**AlertsFilterTimeWindowModesDto?**](AlertsFilterTimeWindowModesDto?.md) |  | [optional]  |
| **includeStatusSeverityHigh** | **bool?** |  | [optional]  |
| **includeStatusSeverityMedium** | **bool?** |  | [optional]  |
| **includeStatusSeverityLow** | **bool?** |  | [optional]  |
| **includeStatusReadYes** | **bool?** |  | [optional]  |
| **includeStatusReadNo** | **bool?** |  | [optional]  |
| **includeStatusClearedYes** | **bool?** |  | [optional]  |
| **includeStatusClearedNo** | **bool?** |  | [optional]  |
| **includeStatusStatusEvent** | **bool?** |  | [optional]  |
| **includeStatusStatusActive** | **bool?** |  | [optional]  |
| **includeStatusStatusEnded** | **bool?** |  | [optional]  |
| **includeStatusCommentYes** | **bool?** |  | [optional]  |
| **includeStatusCommentNo** | **bool?** |  | [optional]  |
| **includeAlertTypeIds** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **selectedTags** | [**List&lt;TagDto&gt;?**](TagDto.md) |  | [optional]  |

### Return type

[**GroupOfAlertsDto**](GroupOfAlertsDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="alertsinboxload"></a>
# **AlertsInboxLoad**
> void AlertsInboxLoad (string? startTicks = null, long? alertId = null, List<string>? channelInstanceRefs = null, int? pageSize = null, bool? isGrouped = null, FilterSettingsDto? filterSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxLoadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxPagingApiApi(config);
            var startTicks = "startTicks_example";  // string? |  (optional) 
            var alertId = 789L;  // long? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var isGrouped = true;  // bool? |  (optional)  (default to true)
            var filterSettingsDto = new FilterSettingsDto?(); // FilterSettingsDto? |  (optional) 

            try
            {
                apiInstance.AlertsInboxLoad(startTicks, alertId, channelInstanceRefs, pageSize, isGrouped, filterSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxPagingApiApi.AlertsInboxLoad: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxLoadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxLoadWithHttpInfo(startTicks, alertId, channelInstanceRefs, pageSize, isGrouped, filterSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxPagingApiApi.AlertsInboxLoadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTicks** | **string?** |  | [optional]  |
| **alertId** | **long?** |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **isGrouped** | **bool?** |  | [optional] [default to true] |
| **filterSettingsDto** | [**FilterSettingsDto?**](FilterSettingsDto?.md) |  | [optional]  |

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

<a id="alertsinboxmovenewer"></a>
# **AlertsInboxMoveNewer**
> void AlertsInboxMoveNewer (string? startTicks = null, long? alertId = null, List<string>? channelInstanceRefs = null, int? pageSize = null, bool? isGrouped = null, FilterSettingsDto? filterSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxMoveNewerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxPagingApiApi(config);
            var startTicks = "startTicks_example";  // string? |  (optional) 
            var alertId = 789L;  // long? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var isGrouped = true;  // bool? |  (optional)  (default to true)
            var filterSettingsDto = new FilterSettingsDto?(); // FilterSettingsDto? |  (optional) 

            try
            {
                apiInstance.AlertsInboxMoveNewer(startTicks, alertId, channelInstanceRefs, pageSize, isGrouped, filterSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxPagingApiApi.AlertsInboxMoveNewer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxMoveNewerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxMoveNewerWithHttpInfo(startTicks, alertId, channelInstanceRefs, pageSize, isGrouped, filterSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxPagingApiApi.AlertsInboxMoveNewerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTicks** | **string?** |  | [optional]  |
| **alertId** | **long?** |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **isGrouped** | **bool?** |  | [optional] [default to true] |
| **filterSettingsDto** | [**FilterSettingsDto?**](FilterSettingsDto?.md) |  | [optional]  |

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

<a id="alertsinboxmovenewest"></a>
# **AlertsInboxMoveNewest**
> void AlertsInboxMoveNewest (List<string>? channelInstanceRefs = null, int? pageSize = null, bool? isGrouped = null, FilterSettingsDto? filterSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxMoveNewestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxPagingApiApi(config);
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var isGrouped = true;  // bool? |  (optional)  (default to true)
            var filterSettingsDto = new FilterSettingsDto?(); // FilterSettingsDto? |  (optional) 

            try
            {
                apiInstance.AlertsInboxMoveNewest(channelInstanceRefs, pageSize, isGrouped, filterSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxPagingApiApi.AlertsInboxMoveNewest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxMoveNewestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxMoveNewestWithHttpInfo(channelInstanceRefs, pageSize, isGrouped, filterSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxPagingApiApi.AlertsInboxMoveNewestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **isGrouped** | **bool?** |  | [optional] [default to true] |
| **filterSettingsDto** | [**FilterSettingsDto?**](FilterSettingsDto?.md) |  | [optional]  |

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

<a id="alertsinboxmoveolder"></a>
# **AlertsInboxMoveOlder**
> void AlertsInboxMoveOlder (string? startTicks = null, long? alertId = null, List<string>? channelInstanceRefs = null, int? pageSize = null, bool? isGrouped = null, FilterSettingsDto? filterSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxMoveOlderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxPagingApiApi(config);
            var startTicks = "startTicks_example";  // string? |  (optional) 
            var alertId = 789L;  // long? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var isGrouped = true;  // bool? |  (optional)  (default to true)
            var filterSettingsDto = new FilterSettingsDto?(); // FilterSettingsDto? |  (optional) 

            try
            {
                apiInstance.AlertsInboxMoveOlder(startTicks, alertId, channelInstanceRefs, pageSize, isGrouped, filterSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxPagingApiApi.AlertsInboxMoveOlder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxMoveOlderWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxMoveOlderWithHttpInfo(startTicks, alertId, channelInstanceRefs, pageSize, isGrouped, filterSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxPagingApiApi.AlertsInboxMoveOlderWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startTicks** | **string?** |  | [optional]  |
| **alertId** | **long?** |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **isGrouped** | **bool?** |  | [optional] [default to true] |
| **filterSettingsDto** | [**FilterSettingsDto?**](FilterSettingsDto?.md) |  | [optional]  |

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

<a id="alertsinboxmoveoldest"></a>
# **AlertsInboxMoveOldest**
> void AlertsInboxMoveOldest (List<string>? channelInstanceRefs = null, int? pageSize = null, bool? isGrouped = null, FilterSettingsDto? filterSettingsDto = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxMoveOldestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxPagingApiApi(config);
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var isGrouped = true;  // bool? |  (optional)  (default to true)
            var filterSettingsDto = new FilterSettingsDto?(); // FilterSettingsDto? |  (optional) 

            try
            {
                apiInstance.AlertsInboxMoveOldest(channelInstanceRefs, pageSize, isGrouped, filterSettingsDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxPagingApiApi.AlertsInboxMoveOldest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxMoveOldestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxMoveOldestWithHttpInfo(channelInstanceRefs, pageSize, isGrouped, filterSettingsDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxPagingApiApi.AlertsInboxMoveOldestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **isGrouped** | **bool?** |  | [optional] [default to true] |
| **filterSettingsDto** | [**FilterSettingsDto?**](FilterSettingsDto?.md) |  | [optional]  |

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

