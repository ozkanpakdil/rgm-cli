# cli.Model.BackupsRowDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Servers** | [**List&lt;EstateServerDto&gt;**](EstateServerDto.md) |  | 
**Group** | **string** |  | 
**Cluster** | **string** |  | 
**Database** | **string** |  | 
**RecoveryModel** | **string** |  | 
**Full** | [**EstateBackupDto**](EstateBackupDto.md) |  | 
**Log** | [**EstateBackupDto**](EstateBackupDto.md) |  | 
**Differential** | [**EstateBackupDto**](EstateBackupDto.md) |  | 
**MaxRpoMinutes** | **double?** |  | 
**RpoBucket** | **string** |  | 
**AllRpo** | **List&lt;double&gt;** |  | 
**SqlInstanceEntityType** | [**EntityType**](EntityType.md) |  | 
**IsCopyOnly** | **bool** |  | 
**IsSystemDatabase** | **bool** |  | [optional] [readonly] 
**SortableDatabaseName** | **string** |  | [optional] [readonly] 
**HasLogBackupWarning** | **bool** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

