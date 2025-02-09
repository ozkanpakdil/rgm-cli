# cli.Model.ManageEntityViewModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsClusterNodeInstance** | **bool** |  | [optional] 
**ClusterNodeName** | **string** |  | [optional] 
**Id** | **string** |  | 
**FullyQualifiedName** | **string** |  | 
**Name** | **string** |  | 
**Credentials** | [**AllCredentialsModel**](AllCredentialsModel.md) |  | 
**CredentialsDescription** | **string** |  | 
**Alias** | **string** |  | [optional] 
**Status** | **MonitoredEntityStatusDto** |  | 
**UserCanRetryConnection** | **bool** |  | [optional] 
**UserCanSuspendAndResume** | **bool** |  | [optional] 
**Machines** | [**List&lt;ManageEntityViewModel&gt;**](ManageEntityViewModel.md) |  | [optional] 
**SqlServers** | [**List&lt;ManageEntityViewModel&gt;**](ManageEntityViewModel.md) |  | [optional] 
**Type** | [**EntityType**](EntityType.md) |  | 
**HostType** | [**EntityType**](EntityType.md) |  | [optional] 
**IsCluster** | **bool** |  | [optional] 
**IsRemovable** | **bool** |  | [optional] 
**Tags** | [**List&lt;TagDto&gt;**](TagDto.md) |  | [optional] 
**EntityReference** | [**ChannelInstanceRef**](ChannelInstanceRef.md) |  | 
**ChildStatuses** | [**List&lt;ManagedEntityChildStatusViewModel&gt;**](ManagedEntityChildStatusViewModel.md) |  | [optional] 
**GroupId** | **string** |  | 
**BaseMonitorName** | **string** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

