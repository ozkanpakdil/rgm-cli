# cli.Model.AlertSuppressionWindowDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [readonly] 
**ScheduleFrequency** | **ScheduleFrequencyDto** |  | [optional] 
**Id** | [**IntegerIdentifier**](IntegerIdentifier.md) |  | [optional] 
**Name** | **string** |  | [optional] 
**Start** | **string** |  | [optional] 
**Duration** | **int?** |  | [optional] 
**Status** | **AlertSuppressionWindowStatusDto** |  | [optional] 
**AlertSuppressionLevel** | **AlertSuppressionLevelDto** |  | [optional] 
**AlertTypeGroupToSuppress** | **AlertTypeGroupToSuppressDto** |  | [optional] 
**Monday** | **bool** |  | [optional] 
**Tuesday** | **bool** |  | [optional] 
**Wednesday** | **bool** |  | [optional] 
**Thursday** | **bool** |  | [optional] 
**Friday** | **bool** |  | [optional] 
**Saturday** | **bool** |  | [optional] 
**Sunday** | **bool** |  | [optional] 
**ScheduleSetPosition** | **ScheduleSetPositionDto** |  | [optional] 
**StartDate** | **DateTime?** |  | [optional] 
**MonthlyScheduleDayOfWeek** | **DayOfWeek** |  | [optional] 
**Targets** | [**List&lt;MonitoredObjectWithIdDto&gt;**](MonitoredObjectWithIdDto.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

