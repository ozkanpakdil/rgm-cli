# cli.Api.AlertInboxApiApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AlertsInboxAddAlertComment**](AlertInboxApiApi.md#alertsinboxaddalertcomment) | **POST** /api/Alerts/alertsgroupinbox/add-alert-comment |  |
| [**AlertsInboxAddGroupComment**](AlertInboxApiApi.md#alertsinboxaddgroupcomment) | **POST** /api/Alerts/alertsgroupinbox/add-group-comment |  |
| [**AlertsInboxClear**](AlertInboxApiApi.md#alertsinboxclear) | **POST** /api/Alerts/alertsgroupinbox/clear |  |
| [**AlertsInboxClearAlert**](AlertInboxApiApi.md#alertsinboxclearalert) | **POST** /api/Alerts/alertsgroupinbox/clearalert |  |
| [**AlertsInboxDeleteCustomFilter**](AlertInboxApiApi.md#alertsinboxdeletecustomfilter) | **POST** /api/Alerts/alertsgroupinbox/deletecustomfilter |  |
| [**AlertsInboxRead**](AlertInboxApiApi.md#alertsinboxread) | **POST** /api/Alerts/alertsgroupinbox/read |  |
| [**AlertsInboxReadAlert**](AlertInboxApiApi.md#alertsinboxreadalert) | **POST** /api/Alerts/alertsgroupinbox/readalert |  |
| [**AlertsInboxSaveCustomFilter**](AlertInboxApiApi.md#alertsinboxsavecustomfilter) | **POST** /api/Alerts/alertsgroupinbox/savecustomfilter |  |
| [**AlertsInboxUnclear**](AlertInboxApiApi.md#alertsinboxunclear) | **POST** /api/Alerts/alertsgroupinbox/unclear |  |
| [**AlertsInboxUnclearAlert**](AlertInboxApiApi.md#alertsinboxunclearalert) | **POST** /api/Alerts/alertsgroupinbox/unclearalert |  |
| [**AlertsInboxUnread**](AlertInboxApiApi.md#alertsinboxunread) | **POST** /api/Alerts/alertsgroupinbox/unread |  |
| [**AlertsInboxUnreadAlert**](AlertInboxApiApi.md#alertsinboxunreadalert) | **POST** /api/Alerts/alertsgroupinbox/unreadalert |  |
| [**ApiAlertsAlertsgroupinboxAddAlertCommentjsonPost**](AlertInboxApiApi.md#apialertsalertsgroupinboxaddalertcommentjsonpost) | **POST** /api/Alerts/alertsgroupinbox/add-alert-commentjson |  |
| [**ApiAlertsAlertsgroupinboxAddGroupCommentjsonPost**](AlertInboxApiApi.md#apialertsalertsgroupinboxaddgroupcommentjsonpost) | **POST** /api/Alerts/alertsgroupinbox/add-group-commentjson |  |
| [**ApiAlertsAlertsgroupinboxClearalertjsonPost**](AlertInboxApiApi.md#apialertsalertsgroupinboxclearalertjsonpost) | **POST** /api/Alerts/alertsgroupinbox/clearalertjson |  |
| [**ApiAlertsAlertsgroupinboxClearjsonPost**](AlertInboxApiApi.md#apialertsalertsgroupinboxclearjsonpost) | **POST** /api/Alerts/alertsgroupinbox/clearjson |  |
| [**ApiAlertsAlertsgroupinboxDeletecustomfilterjsonPost**](AlertInboxApiApi.md#apialertsalertsgroupinboxdeletecustomfilterjsonpost) | **POST** /api/Alerts/alertsgroupinbox/deletecustomfilterjson |  |
| [**ApiAlertsAlertsgroupinboxReadalertjsonPost**](AlertInboxApiApi.md#apialertsalertsgroupinboxreadalertjsonpost) | **POST** /api/Alerts/alertsgroupinbox/readalertjson |  |
| [**ApiAlertsAlertsgroupinboxReadjsonPost**](AlertInboxApiApi.md#apialertsalertsgroupinboxreadjsonpost) | **POST** /api/Alerts/alertsgroupinbox/readjson |  |
| [**ApiAlertsAlertsgroupinboxSavecustomfilterjsonPost**](AlertInboxApiApi.md#apialertsalertsgroupinboxsavecustomfilterjsonpost) | **POST** /api/Alerts/alertsgroupinbox/savecustomfilterjson |  |
| [**ApiAlertsAlertsgroupinboxUnclearalertjsonPost**](AlertInboxApiApi.md#apialertsalertsgroupinboxunclearalertjsonpost) | **POST** /api/Alerts/alertsgroupinbox/unclearalertjson |  |
| [**ApiAlertsAlertsgroupinboxUnclearjsonPost**](AlertInboxApiApi.md#apialertsalertsgroupinboxunclearjsonpost) | **POST** /api/Alerts/alertsgroupinbox/unclearjson |  |
| [**ApiAlertsAlertsgroupinboxUnreadalertjsonPost**](AlertInboxApiApi.md#apialertsalertsgroupinboxunreadalertjsonpost) | **POST** /api/Alerts/alertsgroupinbox/unreadalertjson |  |
| [**ApiAlertsAlertsgroupinboxUnreadjsonPost**](AlertInboxApiApi.md#apialertsalertsgroupinboxunreadjsonpost) | **POST** /api/Alerts/alertsgroupinbox/unreadjson |  |

<a id="alertsinboxaddalertcomment"></a>
# **AlertsInboxAddAlertComment**
> void AlertsInboxAddAlertComment (string? author = null, string? comment = null, string? lastUpdate = null, List<GroupIdDto>? selectedGroupIds = null, List<QualifiedAlertIdDto>? selectedAlertIds = null, AlertsFilterTimeRangeTypeDto? filterSettingsTimeRangeType = null, int? filterSettingsTimeRangeRelativeMinutes = null, long? filterSettingsTimeRangeFromDateTime = null, long? filterSettingsTimeRangeToDateTime = null, AlertsFilterTimeWindowModesDto? filterSettingsTimeRangeTimeWindowMode = null, bool? filterSettingsIncludeStatusSeverityHigh = null, bool? filterSettingsIncludeStatusSeverityMedium = null, bool? filterSettingsIncludeStatusSeverityLow = null, bool? filterSettingsIncludeStatusReadYes = null, bool? filterSettingsIncludeStatusReadNo = null, bool? filterSettingsIncludeStatusClearedYes = null, bool? filterSettingsIncludeStatusClearedNo = null, bool? filterSettingsIncludeStatusStatusEvent = null, bool? filterSettingsIncludeStatusStatusActive = null, bool? filterSettingsIncludeStatusStatusEnded = null, bool? filterSettingsIncludeStatusCommentYes = null, bool? filterSettingsIncludeStatusCommentNo = null, List<string>? filterSettingsIncludeAlertTypeIds = null, List<TagDto>? filterSettingsSelectedTags = null, List<string>? channelInstanceRefs = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxAddAlertCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var author = "author_example";  // string? |  (optional) 
            var comment = "comment_example";  // string? |  (optional) 
            var lastUpdate = "lastUpdate_example";  // string? |  (optional) 
            var selectedGroupIds = new List<GroupIdDto>?(); // List<GroupIdDto>? |  (optional) 
            var selectedAlertIds = new List<QualifiedAlertIdDto>?(); // List<QualifiedAlertIdDto>? |  (optional) 
            var filterSettingsTimeRangeType = new AlertsFilterTimeRangeTypeDto?(); // AlertsFilterTimeRangeTypeDto? |  (optional) 
            var filterSettingsTimeRangeRelativeMinutes = 56;  // int? |  (optional) 
            var filterSettingsTimeRangeFromDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeToDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeTimeWindowMode = new AlertsFilterTimeWindowModesDto?(); // AlertsFilterTimeWindowModesDto? |  (optional) 
            var filterSettingsIncludeStatusSeverityHigh = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityMedium = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityLow = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEvent = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusActive = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEnded = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeAlertTypeIds = new List<string>?(); // List<string>? |  (optional) 
            var filterSettingsSelectedTags = new List<TagDto>?(); // List<TagDto>? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                apiInstance.AlertsInboxAddAlertComment(author, comment, lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxAddAlertComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxAddAlertCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxAddAlertCommentWithHttpInfo(author, comment, lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxAddAlertCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **author** | **string?** |  | [optional]  |
| **comment** | **string?** |  | [optional]  |
| **lastUpdate** | **string?** |  | [optional]  |
| **selectedGroupIds** | [**List&lt;GroupIdDto&gt;?**](GroupIdDto.md) |  | [optional]  |
| **selectedAlertIds** | [**List&lt;QualifiedAlertIdDto&gt;?**](QualifiedAlertIdDto.md) |  | [optional]  |
| **filterSettingsTimeRangeType** | [**AlertsFilterTimeRangeTypeDto?**](AlertsFilterTimeRangeTypeDto?.md) |  | [optional]  |
| **filterSettingsTimeRangeRelativeMinutes** | **int?** |  | [optional]  |
| **filterSettingsTimeRangeFromDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeToDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeTimeWindowMode** | [**AlertsFilterTimeWindowModesDto?**](AlertsFilterTimeWindowModesDto?.md) |  | [optional]  |
| **filterSettingsIncludeStatusSeverityHigh** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityMedium** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityLow** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEvent** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusActive** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEnded** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeAlertTypeIds** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **filterSettingsSelectedTags** | [**List&lt;TagDto&gt;?**](TagDto.md) |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="alertsinboxaddgroupcomment"></a>
# **AlertsInboxAddGroupComment**
> void AlertsInboxAddGroupComment (string? author = null, string? comment = null, string? lastUpdate = null, List<GroupIdDto>? selectedGroupIds = null, List<QualifiedAlertIdDto>? selectedAlertIds = null, AlertsFilterTimeRangeTypeDto? filterSettingsTimeRangeType = null, int? filterSettingsTimeRangeRelativeMinutes = null, long? filterSettingsTimeRangeFromDateTime = null, long? filterSettingsTimeRangeToDateTime = null, AlertsFilterTimeWindowModesDto? filterSettingsTimeRangeTimeWindowMode = null, bool? filterSettingsIncludeStatusSeverityHigh = null, bool? filterSettingsIncludeStatusSeverityMedium = null, bool? filterSettingsIncludeStatusSeverityLow = null, bool? filterSettingsIncludeStatusReadYes = null, bool? filterSettingsIncludeStatusReadNo = null, bool? filterSettingsIncludeStatusClearedYes = null, bool? filterSettingsIncludeStatusClearedNo = null, bool? filterSettingsIncludeStatusStatusEvent = null, bool? filterSettingsIncludeStatusStatusActive = null, bool? filterSettingsIncludeStatusStatusEnded = null, bool? filterSettingsIncludeStatusCommentYes = null, bool? filterSettingsIncludeStatusCommentNo = null, List<string>? filterSettingsIncludeAlertTypeIds = null, List<TagDto>? filterSettingsSelectedTags = null, List<string>? channelInstanceRefs = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxAddGroupCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var author = "author_example";  // string? |  (optional) 
            var comment = "comment_example";  // string? |  (optional) 
            var lastUpdate = "lastUpdate_example";  // string? |  (optional) 
            var selectedGroupIds = new List<GroupIdDto>?(); // List<GroupIdDto>? |  (optional) 
            var selectedAlertIds = new List<QualifiedAlertIdDto>?(); // List<QualifiedAlertIdDto>? |  (optional) 
            var filterSettingsTimeRangeType = new AlertsFilterTimeRangeTypeDto?(); // AlertsFilterTimeRangeTypeDto? |  (optional) 
            var filterSettingsTimeRangeRelativeMinutes = 56;  // int? |  (optional) 
            var filterSettingsTimeRangeFromDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeToDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeTimeWindowMode = new AlertsFilterTimeWindowModesDto?(); // AlertsFilterTimeWindowModesDto? |  (optional) 
            var filterSettingsIncludeStatusSeverityHigh = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityMedium = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityLow = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEvent = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusActive = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEnded = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeAlertTypeIds = new List<string>?(); // List<string>? |  (optional) 
            var filterSettingsSelectedTags = new List<TagDto>?(); // List<TagDto>? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                apiInstance.AlertsInboxAddGroupComment(author, comment, lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxAddGroupComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxAddGroupCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxAddGroupCommentWithHttpInfo(author, comment, lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxAddGroupCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **author** | **string?** |  | [optional]  |
| **comment** | **string?** |  | [optional]  |
| **lastUpdate** | **string?** |  | [optional]  |
| **selectedGroupIds** | [**List&lt;GroupIdDto&gt;?**](GroupIdDto.md) |  | [optional]  |
| **selectedAlertIds** | [**List&lt;QualifiedAlertIdDto&gt;?**](QualifiedAlertIdDto.md) |  | [optional]  |
| **filterSettingsTimeRangeType** | [**AlertsFilterTimeRangeTypeDto?**](AlertsFilterTimeRangeTypeDto?.md) |  | [optional]  |
| **filterSettingsTimeRangeRelativeMinutes** | **int?** |  | [optional]  |
| **filterSettingsTimeRangeFromDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeToDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeTimeWindowMode** | [**AlertsFilterTimeWindowModesDto?**](AlertsFilterTimeWindowModesDto?.md) |  | [optional]  |
| **filterSettingsIncludeStatusSeverityHigh** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityMedium** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityLow** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEvent** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusActive** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEnded** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeAlertTypeIds** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **filterSettingsSelectedTags** | [**List&lt;TagDto&gt;?**](TagDto.md) |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="alertsinboxclear"></a>
# **AlertsInboxClear**
> void AlertsInboxClear (string? lastUpdate = null, List<GroupIdDto>? selectedGroupIds = null, List<QualifiedAlertIdDto>? selectedAlertIds = null, AlertsFilterTimeRangeTypeDto? filterSettingsTimeRangeType = null, int? filterSettingsTimeRangeRelativeMinutes = null, long? filterSettingsTimeRangeFromDateTime = null, long? filterSettingsTimeRangeToDateTime = null, AlertsFilterTimeWindowModesDto? filterSettingsTimeRangeTimeWindowMode = null, bool? filterSettingsIncludeStatusSeverityHigh = null, bool? filterSettingsIncludeStatusSeverityMedium = null, bool? filterSettingsIncludeStatusSeverityLow = null, bool? filterSettingsIncludeStatusReadYes = null, bool? filterSettingsIncludeStatusReadNo = null, bool? filterSettingsIncludeStatusClearedYes = null, bool? filterSettingsIncludeStatusClearedNo = null, bool? filterSettingsIncludeStatusStatusEvent = null, bool? filterSettingsIncludeStatusStatusActive = null, bool? filterSettingsIncludeStatusStatusEnded = null, bool? filterSettingsIncludeStatusCommentYes = null, bool? filterSettingsIncludeStatusCommentNo = null, List<string>? filterSettingsIncludeAlertTypeIds = null, List<TagDto>? filterSettingsSelectedTags = null, List<string>? channelInstanceRefs = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxClearExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var lastUpdate = "lastUpdate_example";  // string? |  (optional) 
            var selectedGroupIds = new List<GroupIdDto>?(); // List<GroupIdDto>? |  (optional) 
            var selectedAlertIds = new List<QualifiedAlertIdDto>?(); // List<QualifiedAlertIdDto>? |  (optional) 
            var filterSettingsTimeRangeType = new AlertsFilterTimeRangeTypeDto?(); // AlertsFilterTimeRangeTypeDto? |  (optional) 
            var filterSettingsTimeRangeRelativeMinutes = 56;  // int? |  (optional) 
            var filterSettingsTimeRangeFromDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeToDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeTimeWindowMode = new AlertsFilterTimeWindowModesDto?(); // AlertsFilterTimeWindowModesDto? |  (optional) 
            var filterSettingsIncludeStatusSeverityHigh = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityMedium = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityLow = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEvent = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusActive = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEnded = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeAlertTypeIds = new List<string>?(); // List<string>? |  (optional) 
            var filterSettingsSelectedTags = new List<TagDto>?(); // List<TagDto>? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                apiInstance.AlertsInboxClear(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxClear: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxClearWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxClearWithHttpInfo(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxClearWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lastUpdate** | **string?** |  | [optional]  |
| **selectedGroupIds** | [**List&lt;GroupIdDto&gt;?**](GroupIdDto.md) |  | [optional]  |
| **selectedAlertIds** | [**List&lt;QualifiedAlertIdDto&gt;?**](QualifiedAlertIdDto.md) |  | [optional]  |
| **filterSettingsTimeRangeType** | [**AlertsFilterTimeRangeTypeDto?**](AlertsFilterTimeRangeTypeDto?.md) |  | [optional]  |
| **filterSettingsTimeRangeRelativeMinutes** | **int?** |  | [optional]  |
| **filterSettingsTimeRangeFromDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeToDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeTimeWindowMode** | [**AlertsFilterTimeWindowModesDto?**](AlertsFilterTimeWindowModesDto?.md) |  | [optional]  |
| **filterSettingsIncludeStatusSeverityHigh** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityMedium** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityLow** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEvent** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusActive** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEnded** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeAlertTypeIds** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **filterSettingsSelectedTags** | [**List&lt;TagDto&gt;?**](TagDto.md) |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="alertsinboxclearalert"></a>
# **AlertsInboxClearAlert**
> void AlertsInboxClearAlert (string? lastUpdate = null, List<GroupIdDto>? selectedGroupIds = null, List<QualifiedAlertIdDto>? selectedAlertIds = null, AlertsFilterTimeRangeTypeDto? filterSettingsTimeRangeType = null, int? filterSettingsTimeRangeRelativeMinutes = null, long? filterSettingsTimeRangeFromDateTime = null, long? filterSettingsTimeRangeToDateTime = null, AlertsFilterTimeWindowModesDto? filterSettingsTimeRangeTimeWindowMode = null, bool? filterSettingsIncludeStatusSeverityHigh = null, bool? filterSettingsIncludeStatusSeverityMedium = null, bool? filterSettingsIncludeStatusSeverityLow = null, bool? filterSettingsIncludeStatusReadYes = null, bool? filterSettingsIncludeStatusReadNo = null, bool? filterSettingsIncludeStatusClearedYes = null, bool? filterSettingsIncludeStatusClearedNo = null, bool? filterSettingsIncludeStatusStatusEvent = null, bool? filterSettingsIncludeStatusStatusActive = null, bool? filterSettingsIncludeStatusStatusEnded = null, bool? filterSettingsIncludeStatusCommentYes = null, bool? filterSettingsIncludeStatusCommentNo = null, List<string>? filterSettingsIncludeAlertTypeIds = null, List<TagDto>? filterSettingsSelectedTags = null, List<string>? channelInstanceRefs = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxClearAlertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var lastUpdate = "lastUpdate_example";  // string? |  (optional) 
            var selectedGroupIds = new List<GroupIdDto>?(); // List<GroupIdDto>? |  (optional) 
            var selectedAlertIds = new List<QualifiedAlertIdDto>?(); // List<QualifiedAlertIdDto>? |  (optional) 
            var filterSettingsTimeRangeType = new AlertsFilterTimeRangeTypeDto?(); // AlertsFilterTimeRangeTypeDto? |  (optional) 
            var filterSettingsTimeRangeRelativeMinutes = 56;  // int? |  (optional) 
            var filterSettingsTimeRangeFromDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeToDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeTimeWindowMode = new AlertsFilterTimeWindowModesDto?(); // AlertsFilterTimeWindowModesDto? |  (optional) 
            var filterSettingsIncludeStatusSeverityHigh = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityMedium = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityLow = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEvent = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusActive = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEnded = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeAlertTypeIds = new List<string>?(); // List<string>? |  (optional) 
            var filterSettingsSelectedTags = new List<TagDto>?(); // List<TagDto>? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                apiInstance.AlertsInboxClearAlert(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxClearAlert: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxClearAlertWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxClearAlertWithHttpInfo(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxClearAlertWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lastUpdate** | **string?** |  | [optional]  |
| **selectedGroupIds** | [**List&lt;GroupIdDto&gt;?**](GroupIdDto.md) |  | [optional]  |
| **selectedAlertIds** | [**List&lt;QualifiedAlertIdDto&gt;?**](QualifiedAlertIdDto.md) |  | [optional]  |
| **filterSettingsTimeRangeType** | [**AlertsFilterTimeRangeTypeDto?**](AlertsFilterTimeRangeTypeDto?.md) |  | [optional]  |
| **filterSettingsTimeRangeRelativeMinutes** | **int?** |  | [optional]  |
| **filterSettingsTimeRangeFromDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeToDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeTimeWindowMode** | [**AlertsFilterTimeWindowModesDto?**](AlertsFilterTimeWindowModesDto?.md) |  | [optional]  |
| **filterSettingsIncludeStatusSeverityHigh** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityMedium** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityLow** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEvent** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusActive** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEnded** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeAlertTypeIds** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **filterSettingsSelectedTags** | [**List&lt;TagDto&gt;?**](TagDto.md) |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="alertsinboxdeletecustomfilter"></a>
# **AlertsInboxDeleteCustomFilter**
> bool AlertsInboxDeleteCustomFilter (string? name = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxDeleteCustomFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var name = "name_example";  // string? |  (optional) 

            try
            {
                bool result = apiInstance.AlertsInboxDeleteCustomFilter(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxDeleteCustomFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxDeleteCustomFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<bool> response = apiInstance.AlertsInboxDeleteCustomFilterWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxDeleteCustomFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string?** |  | [optional]  |

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="alertsinboxread"></a>
# **AlertsInboxRead**
> void AlertsInboxRead (string? lastUpdate = null, List<GroupIdDto>? selectedGroupIds = null, List<QualifiedAlertIdDto>? selectedAlertIds = null, AlertsFilterTimeRangeTypeDto? filterSettingsTimeRangeType = null, int? filterSettingsTimeRangeRelativeMinutes = null, long? filterSettingsTimeRangeFromDateTime = null, long? filterSettingsTimeRangeToDateTime = null, AlertsFilterTimeWindowModesDto? filterSettingsTimeRangeTimeWindowMode = null, bool? filterSettingsIncludeStatusSeverityHigh = null, bool? filterSettingsIncludeStatusSeverityMedium = null, bool? filterSettingsIncludeStatusSeverityLow = null, bool? filterSettingsIncludeStatusReadYes = null, bool? filterSettingsIncludeStatusReadNo = null, bool? filterSettingsIncludeStatusClearedYes = null, bool? filterSettingsIncludeStatusClearedNo = null, bool? filterSettingsIncludeStatusStatusEvent = null, bool? filterSettingsIncludeStatusStatusActive = null, bool? filterSettingsIncludeStatusStatusEnded = null, bool? filterSettingsIncludeStatusCommentYes = null, bool? filterSettingsIncludeStatusCommentNo = null, List<string>? filterSettingsIncludeAlertTypeIds = null, List<TagDto>? filterSettingsSelectedTags = null, List<string>? channelInstanceRefs = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var lastUpdate = "lastUpdate_example";  // string? |  (optional) 
            var selectedGroupIds = new List<GroupIdDto>?(); // List<GroupIdDto>? |  (optional) 
            var selectedAlertIds = new List<QualifiedAlertIdDto>?(); // List<QualifiedAlertIdDto>? |  (optional) 
            var filterSettingsTimeRangeType = new AlertsFilterTimeRangeTypeDto?(); // AlertsFilterTimeRangeTypeDto? |  (optional) 
            var filterSettingsTimeRangeRelativeMinutes = 56;  // int? |  (optional) 
            var filterSettingsTimeRangeFromDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeToDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeTimeWindowMode = new AlertsFilterTimeWindowModesDto?(); // AlertsFilterTimeWindowModesDto? |  (optional) 
            var filterSettingsIncludeStatusSeverityHigh = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityMedium = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityLow = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEvent = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusActive = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEnded = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeAlertTypeIds = new List<string>?(); // List<string>? |  (optional) 
            var filterSettingsSelectedTags = new List<TagDto>?(); // List<TagDto>? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                apiInstance.AlertsInboxRead(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxRead: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxReadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxReadWithHttpInfo(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxReadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lastUpdate** | **string?** |  | [optional]  |
| **selectedGroupIds** | [**List&lt;GroupIdDto&gt;?**](GroupIdDto.md) |  | [optional]  |
| **selectedAlertIds** | [**List&lt;QualifiedAlertIdDto&gt;?**](QualifiedAlertIdDto.md) |  | [optional]  |
| **filterSettingsTimeRangeType** | [**AlertsFilterTimeRangeTypeDto?**](AlertsFilterTimeRangeTypeDto?.md) |  | [optional]  |
| **filterSettingsTimeRangeRelativeMinutes** | **int?** |  | [optional]  |
| **filterSettingsTimeRangeFromDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeToDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeTimeWindowMode** | [**AlertsFilterTimeWindowModesDto?**](AlertsFilterTimeWindowModesDto?.md) |  | [optional]  |
| **filterSettingsIncludeStatusSeverityHigh** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityMedium** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityLow** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEvent** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusActive** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEnded** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeAlertTypeIds** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **filterSettingsSelectedTags** | [**List&lt;TagDto&gt;?**](TagDto.md) |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="alertsinboxreadalert"></a>
# **AlertsInboxReadAlert**
> void AlertsInboxReadAlert (string? lastUpdate = null, List<GroupIdDto>? selectedGroupIds = null, List<QualifiedAlertIdDto>? selectedAlertIds = null, AlertsFilterTimeRangeTypeDto? filterSettingsTimeRangeType = null, int? filterSettingsTimeRangeRelativeMinutes = null, long? filterSettingsTimeRangeFromDateTime = null, long? filterSettingsTimeRangeToDateTime = null, AlertsFilterTimeWindowModesDto? filterSettingsTimeRangeTimeWindowMode = null, bool? filterSettingsIncludeStatusSeverityHigh = null, bool? filterSettingsIncludeStatusSeverityMedium = null, bool? filterSettingsIncludeStatusSeverityLow = null, bool? filterSettingsIncludeStatusReadYes = null, bool? filterSettingsIncludeStatusReadNo = null, bool? filterSettingsIncludeStatusClearedYes = null, bool? filterSettingsIncludeStatusClearedNo = null, bool? filterSettingsIncludeStatusStatusEvent = null, bool? filterSettingsIncludeStatusStatusActive = null, bool? filterSettingsIncludeStatusStatusEnded = null, bool? filterSettingsIncludeStatusCommentYes = null, bool? filterSettingsIncludeStatusCommentNo = null, List<string>? filterSettingsIncludeAlertTypeIds = null, List<TagDto>? filterSettingsSelectedTags = null, List<string>? channelInstanceRefs = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxReadAlertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var lastUpdate = "lastUpdate_example";  // string? |  (optional) 
            var selectedGroupIds = new List<GroupIdDto>?(); // List<GroupIdDto>? |  (optional) 
            var selectedAlertIds = new List<QualifiedAlertIdDto>?(); // List<QualifiedAlertIdDto>? |  (optional) 
            var filterSettingsTimeRangeType = new AlertsFilterTimeRangeTypeDto?(); // AlertsFilterTimeRangeTypeDto? |  (optional) 
            var filterSettingsTimeRangeRelativeMinutes = 56;  // int? |  (optional) 
            var filterSettingsTimeRangeFromDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeToDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeTimeWindowMode = new AlertsFilterTimeWindowModesDto?(); // AlertsFilterTimeWindowModesDto? |  (optional) 
            var filterSettingsIncludeStatusSeverityHigh = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityMedium = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityLow = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEvent = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusActive = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEnded = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeAlertTypeIds = new List<string>?(); // List<string>? |  (optional) 
            var filterSettingsSelectedTags = new List<TagDto>?(); // List<TagDto>? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                apiInstance.AlertsInboxReadAlert(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxReadAlert: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxReadAlertWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxReadAlertWithHttpInfo(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxReadAlertWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lastUpdate** | **string?** |  | [optional]  |
| **selectedGroupIds** | [**List&lt;GroupIdDto&gt;?**](GroupIdDto.md) |  | [optional]  |
| **selectedAlertIds** | [**List&lt;QualifiedAlertIdDto&gt;?**](QualifiedAlertIdDto.md) |  | [optional]  |
| **filterSettingsTimeRangeType** | [**AlertsFilterTimeRangeTypeDto?**](AlertsFilterTimeRangeTypeDto?.md) |  | [optional]  |
| **filterSettingsTimeRangeRelativeMinutes** | **int?** |  | [optional]  |
| **filterSettingsTimeRangeFromDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeToDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeTimeWindowMode** | [**AlertsFilterTimeWindowModesDto?**](AlertsFilterTimeWindowModesDto?.md) |  | [optional]  |
| **filterSettingsIncludeStatusSeverityHigh** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityMedium** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityLow** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEvent** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusActive** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEnded** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeAlertTypeIds** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **filterSettingsSelectedTags** | [**List&lt;TagDto&gt;?**](TagDto.md) |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="alertsinboxsavecustomfilter"></a>
# **AlertsInboxSaveCustomFilter**
> void AlertsInboxSaveCustomFilter (string? name = null, AlertsFilterTimeRangeTypeDto? timeRangeType = null, int? timeRangeRelativeMinutes = null, long? timeRangeFromDateTime = null, long? timeRangeToDateTime = null, AlertsFilterTimeWindowModesDto? timeRangeTimeWindowMode = null, bool? includeStatusSeverityHigh = null, bool? includeStatusSeverityMedium = null, bool? includeStatusSeverityLow = null, bool? includeStatusReadYes = null, bool? includeStatusReadNo = null, bool? includeStatusClearedYes = null, bool? includeStatusClearedNo = null, bool? includeStatusStatusEvent = null, bool? includeStatusStatusActive = null, bool? includeStatusStatusEnded = null, bool? includeStatusCommentYes = null, bool? includeStatusCommentNo = null, List<string>? includeAlertTypeIds = null, List<TagDto>? selectedTags = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxSaveCustomFilterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var name = "name_example";  // string? |  (optional) 
            var timeRangeType = new AlertsFilterTimeRangeTypeDto?(); // AlertsFilterTimeRangeTypeDto? |  (optional) 
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
                apiInstance.AlertsInboxSaveCustomFilter(name, timeRangeType, timeRangeRelativeMinutes, timeRangeFromDateTime, timeRangeToDateTime, timeRangeTimeWindowMode, includeStatusSeverityHigh, includeStatusSeverityMedium, includeStatusSeverityLow, includeStatusReadYes, includeStatusReadNo, includeStatusClearedYes, includeStatusClearedNo, includeStatusStatusEvent, includeStatusStatusActive, includeStatusStatusEnded, includeStatusCommentYes, includeStatusCommentNo, includeAlertTypeIds, selectedTags);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxSaveCustomFilter: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxSaveCustomFilterWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxSaveCustomFilterWithHttpInfo(name, timeRangeType, timeRangeRelativeMinutes, timeRangeFromDateTime, timeRangeToDateTime, timeRangeTimeWindowMode, includeStatusSeverityHigh, includeStatusSeverityMedium, includeStatusSeverityLow, includeStatusReadYes, includeStatusReadNo, includeStatusClearedYes, includeStatusClearedNo, includeStatusStatusEvent, includeStatusStatusActive, includeStatusStatusEnded, includeStatusCommentYes, includeStatusCommentNo, includeAlertTypeIds, selectedTags);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxSaveCustomFilterWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string?** |  | [optional]  |
| **timeRangeType** | [**AlertsFilterTimeRangeTypeDto?**](AlertsFilterTimeRangeTypeDto?.md) |  | [optional]  |
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

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="alertsinboxunclear"></a>
# **AlertsInboxUnclear**
> void AlertsInboxUnclear (string? lastUpdate = null, List<GroupIdDto>? selectedGroupIds = null, List<QualifiedAlertIdDto>? selectedAlertIds = null, AlertsFilterTimeRangeTypeDto? filterSettingsTimeRangeType = null, int? filterSettingsTimeRangeRelativeMinutes = null, long? filterSettingsTimeRangeFromDateTime = null, long? filterSettingsTimeRangeToDateTime = null, AlertsFilterTimeWindowModesDto? filterSettingsTimeRangeTimeWindowMode = null, bool? filterSettingsIncludeStatusSeverityHigh = null, bool? filterSettingsIncludeStatusSeverityMedium = null, bool? filterSettingsIncludeStatusSeverityLow = null, bool? filterSettingsIncludeStatusReadYes = null, bool? filterSettingsIncludeStatusReadNo = null, bool? filterSettingsIncludeStatusClearedYes = null, bool? filterSettingsIncludeStatusClearedNo = null, bool? filterSettingsIncludeStatusStatusEvent = null, bool? filterSettingsIncludeStatusStatusActive = null, bool? filterSettingsIncludeStatusStatusEnded = null, bool? filterSettingsIncludeStatusCommentYes = null, bool? filterSettingsIncludeStatusCommentNo = null, List<string>? filterSettingsIncludeAlertTypeIds = null, List<TagDto>? filterSettingsSelectedTags = null, List<string>? channelInstanceRefs = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxUnclearExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var lastUpdate = "lastUpdate_example";  // string? |  (optional) 
            var selectedGroupIds = new List<GroupIdDto>?(); // List<GroupIdDto>? |  (optional) 
            var selectedAlertIds = new List<QualifiedAlertIdDto>?(); // List<QualifiedAlertIdDto>? |  (optional) 
            var filterSettingsTimeRangeType = new AlertsFilterTimeRangeTypeDto?(); // AlertsFilterTimeRangeTypeDto? |  (optional) 
            var filterSettingsTimeRangeRelativeMinutes = 56;  // int? |  (optional) 
            var filterSettingsTimeRangeFromDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeToDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeTimeWindowMode = new AlertsFilterTimeWindowModesDto?(); // AlertsFilterTimeWindowModesDto? |  (optional) 
            var filterSettingsIncludeStatusSeverityHigh = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityMedium = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityLow = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEvent = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusActive = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEnded = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeAlertTypeIds = new List<string>?(); // List<string>? |  (optional) 
            var filterSettingsSelectedTags = new List<TagDto>?(); // List<TagDto>? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                apiInstance.AlertsInboxUnclear(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxUnclear: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxUnclearWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxUnclearWithHttpInfo(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxUnclearWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lastUpdate** | **string?** |  | [optional]  |
| **selectedGroupIds** | [**List&lt;GroupIdDto&gt;?**](GroupIdDto.md) |  | [optional]  |
| **selectedAlertIds** | [**List&lt;QualifiedAlertIdDto&gt;?**](QualifiedAlertIdDto.md) |  | [optional]  |
| **filterSettingsTimeRangeType** | [**AlertsFilterTimeRangeTypeDto?**](AlertsFilterTimeRangeTypeDto?.md) |  | [optional]  |
| **filterSettingsTimeRangeRelativeMinutes** | **int?** |  | [optional]  |
| **filterSettingsTimeRangeFromDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeToDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeTimeWindowMode** | [**AlertsFilterTimeWindowModesDto?**](AlertsFilterTimeWindowModesDto?.md) |  | [optional]  |
| **filterSettingsIncludeStatusSeverityHigh** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityMedium** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityLow** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEvent** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusActive** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEnded** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeAlertTypeIds** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **filterSettingsSelectedTags** | [**List&lt;TagDto&gt;?**](TagDto.md) |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="alertsinboxunclearalert"></a>
# **AlertsInboxUnclearAlert**
> void AlertsInboxUnclearAlert (string? lastUpdate = null, List<GroupIdDto>? selectedGroupIds = null, List<QualifiedAlertIdDto>? selectedAlertIds = null, AlertsFilterTimeRangeTypeDto? filterSettingsTimeRangeType = null, int? filterSettingsTimeRangeRelativeMinutes = null, long? filterSettingsTimeRangeFromDateTime = null, long? filterSettingsTimeRangeToDateTime = null, AlertsFilterTimeWindowModesDto? filterSettingsTimeRangeTimeWindowMode = null, bool? filterSettingsIncludeStatusSeverityHigh = null, bool? filterSettingsIncludeStatusSeverityMedium = null, bool? filterSettingsIncludeStatusSeverityLow = null, bool? filterSettingsIncludeStatusReadYes = null, bool? filterSettingsIncludeStatusReadNo = null, bool? filterSettingsIncludeStatusClearedYes = null, bool? filterSettingsIncludeStatusClearedNo = null, bool? filterSettingsIncludeStatusStatusEvent = null, bool? filterSettingsIncludeStatusStatusActive = null, bool? filterSettingsIncludeStatusStatusEnded = null, bool? filterSettingsIncludeStatusCommentYes = null, bool? filterSettingsIncludeStatusCommentNo = null, List<string>? filterSettingsIncludeAlertTypeIds = null, List<TagDto>? filterSettingsSelectedTags = null, List<string>? channelInstanceRefs = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxUnclearAlertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var lastUpdate = "lastUpdate_example";  // string? |  (optional) 
            var selectedGroupIds = new List<GroupIdDto>?(); // List<GroupIdDto>? |  (optional) 
            var selectedAlertIds = new List<QualifiedAlertIdDto>?(); // List<QualifiedAlertIdDto>? |  (optional) 
            var filterSettingsTimeRangeType = new AlertsFilterTimeRangeTypeDto?(); // AlertsFilterTimeRangeTypeDto? |  (optional) 
            var filterSettingsTimeRangeRelativeMinutes = 56;  // int? |  (optional) 
            var filterSettingsTimeRangeFromDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeToDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeTimeWindowMode = new AlertsFilterTimeWindowModesDto?(); // AlertsFilterTimeWindowModesDto? |  (optional) 
            var filterSettingsIncludeStatusSeverityHigh = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityMedium = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityLow = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEvent = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusActive = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEnded = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeAlertTypeIds = new List<string>?(); // List<string>? |  (optional) 
            var filterSettingsSelectedTags = new List<TagDto>?(); // List<TagDto>? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                apiInstance.AlertsInboxUnclearAlert(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxUnclearAlert: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxUnclearAlertWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxUnclearAlertWithHttpInfo(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxUnclearAlertWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lastUpdate** | **string?** |  | [optional]  |
| **selectedGroupIds** | [**List&lt;GroupIdDto&gt;?**](GroupIdDto.md) |  | [optional]  |
| **selectedAlertIds** | [**List&lt;QualifiedAlertIdDto&gt;?**](QualifiedAlertIdDto.md) |  | [optional]  |
| **filterSettingsTimeRangeType** | [**AlertsFilterTimeRangeTypeDto?**](AlertsFilterTimeRangeTypeDto?.md) |  | [optional]  |
| **filterSettingsTimeRangeRelativeMinutes** | **int?** |  | [optional]  |
| **filterSettingsTimeRangeFromDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeToDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeTimeWindowMode** | [**AlertsFilterTimeWindowModesDto?**](AlertsFilterTimeWindowModesDto?.md) |  | [optional]  |
| **filterSettingsIncludeStatusSeverityHigh** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityMedium** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityLow** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEvent** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusActive** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEnded** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeAlertTypeIds** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **filterSettingsSelectedTags** | [**List&lt;TagDto&gt;?**](TagDto.md) |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="alertsinboxunread"></a>
# **AlertsInboxUnread**
> void AlertsInboxUnread (string? lastUpdate = null, List<GroupIdDto>? selectedGroupIds = null, List<QualifiedAlertIdDto>? selectedAlertIds = null, AlertsFilterTimeRangeTypeDto? filterSettingsTimeRangeType = null, int? filterSettingsTimeRangeRelativeMinutes = null, long? filterSettingsTimeRangeFromDateTime = null, long? filterSettingsTimeRangeToDateTime = null, AlertsFilterTimeWindowModesDto? filterSettingsTimeRangeTimeWindowMode = null, bool? filterSettingsIncludeStatusSeverityHigh = null, bool? filterSettingsIncludeStatusSeverityMedium = null, bool? filterSettingsIncludeStatusSeverityLow = null, bool? filterSettingsIncludeStatusReadYes = null, bool? filterSettingsIncludeStatusReadNo = null, bool? filterSettingsIncludeStatusClearedYes = null, bool? filterSettingsIncludeStatusClearedNo = null, bool? filterSettingsIncludeStatusStatusEvent = null, bool? filterSettingsIncludeStatusStatusActive = null, bool? filterSettingsIncludeStatusStatusEnded = null, bool? filterSettingsIncludeStatusCommentYes = null, bool? filterSettingsIncludeStatusCommentNo = null, List<string>? filterSettingsIncludeAlertTypeIds = null, List<TagDto>? filterSettingsSelectedTags = null, List<string>? channelInstanceRefs = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxUnreadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var lastUpdate = "lastUpdate_example";  // string? |  (optional) 
            var selectedGroupIds = new List<GroupIdDto>?(); // List<GroupIdDto>? |  (optional) 
            var selectedAlertIds = new List<QualifiedAlertIdDto>?(); // List<QualifiedAlertIdDto>? |  (optional) 
            var filterSettingsTimeRangeType = new AlertsFilterTimeRangeTypeDto?(); // AlertsFilterTimeRangeTypeDto? |  (optional) 
            var filterSettingsTimeRangeRelativeMinutes = 56;  // int? |  (optional) 
            var filterSettingsTimeRangeFromDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeToDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeTimeWindowMode = new AlertsFilterTimeWindowModesDto?(); // AlertsFilterTimeWindowModesDto? |  (optional) 
            var filterSettingsIncludeStatusSeverityHigh = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityMedium = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityLow = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEvent = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusActive = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEnded = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeAlertTypeIds = new List<string>?(); // List<string>? |  (optional) 
            var filterSettingsSelectedTags = new List<TagDto>?(); // List<TagDto>? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                apiInstance.AlertsInboxUnread(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxUnread: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxUnreadWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxUnreadWithHttpInfo(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxUnreadWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lastUpdate** | **string?** |  | [optional]  |
| **selectedGroupIds** | [**List&lt;GroupIdDto&gt;?**](GroupIdDto.md) |  | [optional]  |
| **selectedAlertIds** | [**List&lt;QualifiedAlertIdDto&gt;?**](QualifiedAlertIdDto.md) |  | [optional]  |
| **filterSettingsTimeRangeType** | [**AlertsFilterTimeRangeTypeDto?**](AlertsFilterTimeRangeTypeDto?.md) |  | [optional]  |
| **filterSettingsTimeRangeRelativeMinutes** | **int?** |  | [optional]  |
| **filterSettingsTimeRangeFromDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeToDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeTimeWindowMode** | [**AlertsFilterTimeWindowModesDto?**](AlertsFilterTimeWindowModesDto?.md) |  | [optional]  |
| **filterSettingsIncludeStatusSeverityHigh** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityMedium** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityLow** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEvent** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusActive** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEnded** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeAlertTypeIds** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **filterSettingsSelectedTags** | [**List&lt;TagDto&gt;?**](TagDto.md) |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="alertsinboxunreadalert"></a>
# **AlertsInboxUnreadAlert**
> void AlertsInboxUnreadAlert (string? lastUpdate = null, List<GroupIdDto>? selectedGroupIds = null, List<QualifiedAlertIdDto>? selectedAlertIds = null, AlertsFilterTimeRangeTypeDto? filterSettingsTimeRangeType = null, int? filterSettingsTimeRangeRelativeMinutes = null, long? filterSettingsTimeRangeFromDateTime = null, long? filterSettingsTimeRangeToDateTime = null, AlertsFilterTimeWindowModesDto? filterSettingsTimeRangeTimeWindowMode = null, bool? filterSettingsIncludeStatusSeverityHigh = null, bool? filterSettingsIncludeStatusSeverityMedium = null, bool? filterSettingsIncludeStatusSeverityLow = null, bool? filterSettingsIncludeStatusReadYes = null, bool? filterSettingsIncludeStatusReadNo = null, bool? filterSettingsIncludeStatusClearedYes = null, bool? filterSettingsIncludeStatusClearedNo = null, bool? filterSettingsIncludeStatusStatusEvent = null, bool? filterSettingsIncludeStatusStatusActive = null, bool? filterSettingsIncludeStatusStatusEnded = null, bool? filterSettingsIncludeStatusCommentYes = null, bool? filterSettingsIncludeStatusCommentNo = null, List<string>? filterSettingsIncludeAlertTypeIds = null, List<TagDto>? filterSettingsSelectedTags = null, List<string>? channelInstanceRefs = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class AlertsInboxUnreadAlertExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var lastUpdate = "lastUpdate_example";  // string? |  (optional) 
            var selectedGroupIds = new List<GroupIdDto>?(); // List<GroupIdDto>? |  (optional) 
            var selectedAlertIds = new List<QualifiedAlertIdDto>?(); // List<QualifiedAlertIdDto>? |  (optional) 
            var filterSettingsTimeRangeType = new AlertsFilterTimeRangeTypeDto?(); // AlertsFilterTimeRangeTypeDto? |  (optional) 
            var filterSettingsTimeRangeRelativeMinutes = 56;  // int? |  (optional) 
            var filterSettingsTimeRangeFromDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeToDateTime = 789L;  // long? |  (optional) 
            var filterSettingsTimeRangeTimeWindowMode = new AlertsFilterTimeWindowModesDto?(); // AlertsFilterTimeWindowModesDto? |  (optional) 
            var filterSettingsIncludeStatusSeverityHigh = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityMedium = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusSeverityLow = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusReadNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusClearedNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEvent = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusActive = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusStatusEnded = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentYes = true;  // bool? |  (optional) 
            var filterSettingsIncludeStatusCommentNo = true;  // bool? |  (optional) 
            var filterSettingsIncludeAlertTypeIds = new List<string>?(); // List<string>? |  (optional) 
            var filterSettingsSelectedTags = new List<TagDto>?(); // List<TagDto>? |  (optional) 
            var channelInstanceRefs = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                apiInstance.AlertsInboxUnreadAlert(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxUnreadAlert: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AlertsInboxUnreadAlertWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.AlertsInboxUnreadAlertWithHttpInfo(lastUpdate, selectedGroupIds, selectedAlertIds, filterSettingsTimeRangeType, filterSettingsTimeRangeRelativeMinutes, filterSettingsTimeRangeFromDateTime, filterSettingsTimeRangeToDateTime, filterSettingsTimeRangeTimeWindowMode, filterSettingsIncludeStatusSeverityHigh, filterSettingsIncludeStatusSeverityMedium, filterSettingsIncludeStatusSeverityLow, filterSettingsIncludeStatusReadYes, filterSettingsIncludeStatusReadNo, filterSettingsIncludeStatusClearedYes, filterSettingsIncludeStatusClearedNo, filterSettingsIncludeStatusStatusEvent, filterSettingsIncludeStatusStatusActive, filterSettingsIncludeStatusStatusEnded, filterSettingsIncludeStatusCommentYes, filterSettingsIncludeStatusCommentNo, filterSettingsIncludeAlertTypeIds, filterSettingsSelectedTags, channelInstanceRefs);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.AlertsInboxUnreadAlertWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lastUpdate** | **string?** |  | [optional]  |
| **selectedGroupIds** | [**List&lt;GroupIdDto&gt;?**](GroupIdDto.md) |  | [optional]  |
| **selectedAlertIds** | [**List&lt;QualifiedAlertIdDto&gt;?**](QualifiedAlertIdDto.md) |  | [optional]  |
| **filterSettingsTimeRangeType** | [**AlertsFilterTimeRangeTypeDto?**](AlertsFilterTimeRangeTypeDto?.md) |  | [optional]  |
| **filterSettingsTimeRangeRelativeMinutes** | **int?** |  | [optional]  |
| **filterSettingsTimeRangeFromDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeToDateTime** | **long?** |  | [optional]  |
| **filterSettingsTimeRangeTimeWindowMode** | [**AlertsFilterTimeWindowModesDto?**](AlertsFilterTimeWindowModesDto?.md) |  | [optional]  |
| **filterSettingsIncludeStatusSeverityHigh** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityMedium** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusSeverityLow** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusReadNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusClearedNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEvent** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusActive** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusStatusEnded** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentYes** | **bool?** |  | [optional]  |
| **filterSettingsIncludeStatusCommentNo** | **bool?** |  | [optional]  |
| **filterSettingsIncludeAlertTypeIds** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **filterSettingsSelectedTags** | [**List&lt;TagDto&gt;?**](TagDto.md) |  | [optional]  |
| **channelInstanceRefs** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apialertsalertsgroupinboxaddalertcommentjsonpost"></a>
# **ApiAlertsAlertsgroupinboxAddAlertCommentjsonPost**
> void ApiAlertsAlertsgroupinboxAddAlertCommentjsonPost (AlertInboxSelectionDto alertInboxSelectionDto, string? author = null, string? comment = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAlertsAlertsgroupinboxAddAlertCommentjsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var alertInboxSelectionDto = new AlertInboxSelectionDto(); // AlertInboxSelectionDto | 
            var author = "author_example";  // string? |  (optional) 
            var comment = "comment_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiAlertsAlertsgroupinboxAddAlertCommentjsonPost(alertInboxSelectionDto, author, comment);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxAddAlertCommentjsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAlertsAlertsgroupinboxAddAlertCommentjsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAlertsAlertsgroupinboxAddAlertCommentjsonPostWithHttpInfo(alertInboxSelectionDto, author, comment);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxAddAlertCommentjsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertInboxSelectionDto** | [**AlertInboxSelectionDto**](AlertInboxSelectionDto.md) |  |  |
| **author** | **string?** |  | [optional]  |
| **comment** | **string?** |  | [optional]  |

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
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apialertsalertsgroupinboxaddgroupcommentjsonpost"></a>
# **ApiAlertsAlertsgroupinboxAddGroupCommentjsonPost**
> void ApiAlertsAlertsgroupinboxAddGroupCommentjsonPost (AlertInboxSelectionDto alertInboxSelectionDto, string? author = null, string? comment = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAlertsAlertsgroupinboxAddGroupCommentjsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var alertInboxSelectionDto = new AlertInboxSelectionDto(); // AlertInboxSelectionDto | 
            var author = "author_example";  // string? |  (optional) 
            var comment = "comment_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiAlertsAlertsgroupinboxAddGroupCommentjsonPost(alertInboxSelectionDto, author, comment);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxAddGroupCommentjsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAlertsAlertsgroupinboxAddGroupCommentjsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAlertsAlertsgroupinboxAddGroupCommentjsonPostWithHttpInfo(alertInboxSelectionDto, author, comment);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxAddGroupCommentjsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertInboxSelectionDto** | [**AlertInboxSelectionDto**](AlertInboxSelectionDto.md) |  |  |
| **author** | **string?** |  | [optional]  |
| **comment** | **string?** |  | [optional]  |

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
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apialertsalertsgroupinboxclearalertjsonpost"></a>
# **ApiAlertsAlertsgroupinboxClearalertjsonPost**
> void ApiAlertsAlertsgroupinboxClearalertjsonPost (AlertInboxSelectionDto alertInboxSelectionDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAlertsAlertsgroupinboxClearalertjsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var alertInboxSelectionDto = new AlertInboxSelectionDto(); // AlertInboxSelectionDto | 

            try
            {
                apiInstance.ApiAlertsAlertsgroupinboxClearalertjsonPost(alertInboxSelectionDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxClearalertjsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAlertsAlertsgroupinboxClearalertjsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAlertsAlertsgroupinboxClearalertjsonPostWithHttpInfo(alertInboxSelectionDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxClearalertjsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertInboxSelectionDto** | [**AlertInboxSelectionDto**](AlertInboxSelectionDto.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apialertsalertsgroupinboxclearjsonpost"></a>
# **ApiAlertsAlertsgroupinboxClearjsonPost**
> void ApiAlertsAlertsgroupinboxClearjsonPost (AlertInboxSelectionDto alertInboxSelectionDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAlertsAlertsgroupinboxClearjsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var alertInboxSelectionDto = new AlertInboxSelectionDto(); // AlertInboxSelectionDto | 

            try
            {
                apiInstance.ApiAlertsAlertsgroupinboxClearjsonPost(alertInboxSelectionDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxClearjsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAlertsAlertsgroupinboxClearjsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAlertsAlertsgroupinboxClearjsonPostWithHttpInfo(alertInboxSelectionDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxClearjsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertInboxSelectionDto** | [**AlertInboxSelectionDto**](AlertInboxSelectionDto.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apialertsalertsgroupinboxdeletecustomfilterjsonpost"></a>
# **ApiAlertsAlertsgroupinboxDeletecustomfilterjsonPost**
> bool ApiAlertsAlertsgroupinboxDeletecustomfilterjsonPost (string? name = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAlertsAlertsgroupinboxDeletecustomfilterjsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var name = "name_example";  // string? |  (optional) 

            try
            {
                bool result = apiInstance.ApiAlertsAlertsgroupinboxDeletecustomfilterjsonPost(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxDeletecustomfilterjsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAlertsAlertsgroupinboxDeletecustomfilterjsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<bool> response = apiInstance.ApiAlertsAlertsgroupinboxDeletecustomfilterjsonPostWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxDeletecustomfilterjsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string?** |  | [optional]  |

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **422** | UnprocessableEntity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apialertsalertsgroupinboxreadalertjsonpost"></a>
# **ApiAlertsAlertsgroupinboxReadalertjsonPost**
> void ApiAlertsAlertsgroupinboxReadalertjsonPost (AlertInboxSelectionDto alertInboxSelectionDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAlertsAlertsgroupinboxReadalertjsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var alertInboxSelectionDto = new AlertInboxSelectionDto(); // AlertInboxSelectionDto | 

            try
            {
                apiInstance.ApiAlertsAlertsgroupinboxReadalertjsonPost(alertInboxSelectionDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxReadalertjsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAlertsAlertsgroupinboxReadalertjsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAlertsAlertsgroupinboxReadalertjsonPostWithHttpInfo(alertInboxSelectionDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxReadalertjsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertInboxSelectionDto** | [**AlertInboxSelectionDto**](AlertInboxSelectionDto.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apialertsalertsgroupinboxreadjsonpost"></a>
# **ApiAlertsAlertsgroupinboxReadjsonPost**
> void ApiAlertsAlertsgroupinboxReadjsonPost (AlertInboxSelectionDto alertInboxSelectionDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAlertsAlertsgroupinboxReadjsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var alertInboxSelectionDto = new AlertInboxSelectionDto(); // AlertInboxSelectionDto | 

            try
            {
                apiInstance.ApiAlertsAlertsgroupinboxReadjsonPost(alertInboxSelectionDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxReadjsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAlertsAlertsgroupinboxReadjsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAlertsAlertsgroupinboxReadjsonPostWithHttpInfo(alertInboxSelectionDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxReadjsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertInboxSelectionDto** | [**AlertInboxSelectionDto**](AlertInboxSelectionDto.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apialertsalertsgroupinboxsavecustomfilterjsonpost"></a>
# **ApiAlertsAlertsgroupinboxSavecustomfilterjsonPost**
> void ApiAlertsAlertsgroupinboxSavecustomfilterjsonPost (FilterSettingsDto filterSettingsDto, string? name = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAlertsAlertsgroupinboxSavecustomfilterjsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var filterSettingsDto = new FilterSettingsDto(); // FilterSettingsDto | 
            var name = "name_example";  // string? |  (optional) 

            try
            {
                apiInstance.ApiAlertsAlertsgroupinboxSavecustomfilterjsonPost(filterSettingsDto, name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxSavecustomfilterjsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAlertsAlertsgroupinboxSavecustomfilterjsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAlertsAlertsgroupinboxSavecustomfilterjsonPostWithHttpInfo(filterSettingsDto, name);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxSavecustomfilterjsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterSettingsDto** | [**FilterSettingsDto**](FilterSettingsDto.md) |  |  |
| **name** | **string?** |  | [optional]  |

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

<a id="apialertsalertsgroupinboxunclearalertjsonpost"></a>
# **ApiAlertsAlertsgroupinboxUnclearalertjsonPost**
> void ApiAlertsAlertsgroupinboxUnclearalertjsonPost (AlertInboxSelectionDto alertInboxSelectionDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAlertsAlertsgroupinboxUnclearalertjsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var alertInboxSelectionDto = new AlertInboxSelectionDto(); // AlertInboxSelectionDto | 

            try
            {
                apiInstance.ApiAlertsAlertsgroupinboxUnclearalertjsonPost(alertInboxSelectionDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxUnclearalertjsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAlertsAlertsgroupinboxUnclearalertjsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAlertsAlertsgroupinboxUnclearalertjsonPostWithHttpInfo(alertInboxSelectionDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxUnclearalertjsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertInboxSelectionDto** | [**AlertInboxSelectionDto**](AlertInboxSelectionDto.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apialertsalertsgroupinboxunclearjsonpost"></a>
# **ApiAlertsAlertsgroupinboxUnclearjsonPost**
> void ApiAlertsAlertsgroupinboxUnclearjsonPost (AlertInboxSelectionDto alertInboxSelectionDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAlertsAlertsgroupinboxUnclearjsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var alertInboxSelectionDto = new AlertInboxSelectionDto(); // AlertInboxSelectionDto | 

            try
            {
                apiInstance.ApiAlertsAlertsgroupinboxUnclearjsonPost(alertInboxSelectionDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxUnclearjsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAlertsAlertsgroupinboxUnclearjsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAlertsAlertsgroupinboxUnclearjsonPostWithHttpInfo(alertInboxSelectionDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxUnclearjsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertInboxSelectionDto** | [**AlertInboxSelectionDto**](AlertInboxSelectionDto.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apialertsalertsgroupinboxunreadalertjsonpost"></a>
# **ApiAlertsAlertsgroupinboxUnreadalertjsonPost**
> void ApiAlertsAlertsgroupinboxUnreadalertjsonPost (AlertInboxSelectionDto alertInboxSelectionDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAlertsAlertsgroupinboxUnreadalertjsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var alertInboxSelectionDto = new AlertInboxSelectionDto(); // AlertInboxSelectionDto | 

            try
            {
                apiInstance.ApiAlertsAlertsgroupinboxUnreadalertjsonPost(alertInboxSelectionDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxUnreadalertjsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAlertsAlertsgroupinboxUnreadalertjsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAlertsAlertsgroupinboxUnreadalertjsonPostWithHttpInfo(alertInboxSelectionDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxUnreadalertjsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertInboxSelectionDto** | [**AlertInboxSelectionDto**](AlertInboxSelectionDto.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apialertsalertsgroupinboxunreadjsonpost"></a>
# **ApiAlertsAlertsgroupinboxUnreadjsonPost**
> void ApiAlertsAlertsgroupinboxUnreadjsonPost (AlertInboxSelectionDto alertInboxSelectionDto)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cli.Api;
using cli.Client;
using cli.Model;

namespace Example
{
    public class ApiAlertsAlertsgroupinboxUnreadjsonPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlertInboxApiApi(config);
            var alertInboxSelectionDto = new AlertInboxSelectionDto(); // AlertInboxSelectionDto | 

            try
            {
                apiInstance.ApiAlertsAlertsgroupinboxUnreadjsonPost(alertInboxSelectionDto);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxUnreadjsonPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAlertsAlertsgroupinboxUnreadjsonPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ApiAlertsAlertsgroupinboxUnreadjsonPostWithHttpInfo(alertInboxSelectionDto);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AlertInboxApiApi.ApiAlertsAlertsgroupinboxUnreadjsonPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alertInboxSelectionDto** | [**AlertInboxSelectionDto**](AlertInboxSelectionDto.md) |  |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

