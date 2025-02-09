# cli.Model.AddPostgresInstanceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** |  | 
**Alias** | **string** |  | [optional] 
**Port** | **int** |  | 
**GroupId** | **Guid?** |  | [optional] 
**MachineConfiguration** | [**LinuxMachineConfiguration**](LinuxMachineConfiguration.md) |  | [optional] 
**InstanceCredentials** | [**PostgresInstanceCredentialsDto**](PostgresInstanceCredentialsDto.md) |  | 
**AmazonApiCredentials** | [**AmazonApiCredentialsDto**](AmazonApiCredentialsDto.md) |  | [optional] 
**AzureApiCredentials** | [**AzureApiCredentialsDto**](AzureApiCredentialsDto.md) |  | [optional] 
**Database** | **string** |  | [optional] 
**FailIfExists** | **bool** |  | [optional] 
**EnvironmentType** | **EnvironmentTypeDto** |  | 
**AddToExistingLinuxMachine** | **bool** |  | [optional] 
**AgentName** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

