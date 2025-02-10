/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using cli.Client;

namespace cli.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAvailabilityGroupsApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="availabilityGroupName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns></returns>
    void ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet(string clusterName,
        string availabilityGroupName, string baseMonitorName, int operationIndex = 0);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="availabilityGroupName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of Object(void)</returns>
    ApiResponse<object>
        ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGetWithHttpInfo(
            string clusterName, string availabilityGroupName, string baseMonitorName, int operationIndex = 0);

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns></returns>
    void ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet(string clusterName,
        string baseMonitorName, int operationIndex = 0);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of Object(void)</returns>
    ApiResponse<object> ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGetWithHttpInfo(
        string clusterName, string baseMonitorName, int operationIndex = 0);

    #endregion Synchronous Operations
}

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAvailabilityGroupsApiAsync : IApiAccessor
{
    #region Asynchronous Operations

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="availabilityGroupName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    Task ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGetAsync(
        string clusterName, string availabilityGroupName, string baseMonitorName, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="availabilityGroupName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    Task<ApiResponse<object>>
        ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGetWithHttpInfoAsync(
            string clusterName, string availabilityGroupName, string baseMonitorName, int operationIndex = 0,
            CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    Task ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGetAsync(string clusterName,
        string baseMonitorName, int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    Task<ApiResponse<object>> ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGetWithHttpInfoAsync(
        string clusterName, string baseMonitorName, int operationIndex = 0,
        CancellationToken cancellationToken = default);

    #endregion Asynchronous Operations
}

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAvailabilityGroupsApi : IAvailabilityGroupsApiSync, IAvailabilityGroupsApiAsync
{
}

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public class AvailabilityGroupsApi : IAvailabilityGroupsApi
{
    private ExceptionFactory _exceptionFactory = (name, response) => null;

    /// <summary>
    ///     Initializes a new instance of the <see cref="AvailabilityGroupsApi" /> class.
    /// </summary>
    /// <returns></returns>
    public AvailabilityGroupsApi() : this((string)null)
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AvailabilityGroupsApi" /> class.
    /// </summary>
    /// <returns></returns>
    public AvailabilityGroupsApi(string basePath)
    {
        Configuration = cli.Client.Configuration.MergeConfigurations(
            GlobalConfiguration.Instance,
            new Configuration { BasePath = basePath }
        );
        Client = new ApiClient(Configuration.BasePath);
        AsynchronousClient = new ApiClient(Configuration.BasePath);
        ExceptionFactory = cli.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AvailabilityGroupsApi" /> class
    ///     using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public AvailabilityGroupsApi(Configuration configuration)
    {
        if (configuration == null) throw new ArgumentNullException("configuration");

        Configuration = cli.Client.Configuration.MergeConfigurations(
            GlobalConfiguration.Instance,
            configuration
        );
        Client = new ApiClient(Configuration.BasePath);
        AsynchronousClient = new ApiClient(Configuration.BasePath);
        ExceptionFactory = cli.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AvailabilityGroupsApi" /> class
    ///     using a Configuration object and client instance.
    /// </summary>
    /// <param name="client">The client interface for synchronous API access.</param>
    /// <param name="asyncClient">The client interface for asynchronous API access.</param>
    /// <param name="configuration">The configuration object.</param>
    public AvailabilityGroupsApi(ISynchronousClient client, IAsynchronousClient asyncClient,
        IReadableConfiguration configuration)
    {
        if (client == null) throw new ArgumentNullException("client");
        if (asyncClient == null) throw new ArgumentNullException("asyncClient");
        if (configuration == null) throw new ArgumentNullException("configuration");

        Client = client;
        AsynchronousClient = asyncClient;
        Configuration = configuration;
        ExceptionFactory = cli.Client.Configuration.DefaultExceptionFactory;
    }

    /// <summary>
    ///     The client for accessing this underlying API asynchronously.
    /// </summary>
    public IAsynchronousClient AsynchronousClient { get; set; }

    /// <summary>
    ///     The client for accessing this underlying API synchronously.
    /// </summary>
    public ISynchronousClient Client { get; set; }

    /// <summary>
    ///     Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public string GetBasePath()
    {
        return Configuration.BasePath;
    }

    /// <summary>
    ///     Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    public IReadableConfiguration Configuration { get; set; }

    /// <summary>
    ///     Provides a factory method hook for the creation of exceptions.
    /// </summary>
    public ExceptionFactory ExceptionFactory
    {
        get
        {
            if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
            return _exceptionFactory;
        }
        set => _exceptionFactory = value;
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="availabilityGroupName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns></returns>
    public void ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet(
        string clusterName, string availabilityGroupName, string baseMonitorName, int operationIndex = 0)
    {
        ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGetWithHttpInfo(
            clusterName, availabilityGroupName, baseMonitorName);
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="availabilityGroupName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of Object(void)</returns>
    public ApiResponse<object>
        ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGetWithHttpInfo(
            string clusterName, string availabilityGroupName, string baseMonitorName, int operationIndex = 0)
    {
        // verify the required parameter 'clusterName' is set
        if (clusterName == null)
            throw new ApiException(400,
                "Missing required parameter 'clusterName' when calling AvailabilityGroupsApi->ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet");

        // verify the required parameter 'availabilityGroupName' is set
        if (availabilityGroupName == null)
            throw new ApiException(400,
                "Missing required parameter 'availabilityGroupName' when calling AvailabilityGroupsApi->ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet");

        // verify the required parameter 'baseMonitorName' is set
        if (baseMonitorName == null)
            throw new ApiException(400,
                "Missing required parameter 'baseMonitorName' when calling AvailabilityGroupsApi->ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet");

        var localVarRequestOptions = new RequestOptions();

        var _contentTypes = new string[]
        {
        };

        // to determine the Accept header
        var _accepts = new[]
        {
            "application/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
        var localVarMultipartFormData = localVarContentType == "multipart/form-data";
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        localVarRequestOptions.PathParameters.Add("clusterName",
            ClientUtils.ParameterToString(clusterName)); // path parameter
        localVarRequestOptions.PathParameters.Add("availabilityGroupName",
            ClientUtils.ParameterToString(availabilityGroupName)); // path parameter
        localVarRequestOptions.PathParameters.Add("baseMonitorName",
            ClientUtils.ParameterToString(baseMonitorName)); // path parameter

        localVarRequestOptions.Operation =
            "AvailabilityGroupsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet";
        localVarRequestOptions.OperationIndex = operationIndex;


        // make the HTTP request
        var localVarResponse =
            Client.Get<object>(
                "/api/basemonitors/{baseMonitorName}/clusters/{clusterName}/availabilitygroups/{availabilityGroupName}",
                localVarRequestOptions, Configuration);
        if (ExceptionFactory != null)
        {
            var _exception =
                ExceptionFactory(
                    "ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet",
                    localVarResponse);
            if (_exception != null) throw _exception;
        }

        return localVarResponse;
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="availabilityGroupName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async Task ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGetAsync(
        string clusterName, string availabilityGroupName, string baseMonitorName, int operationIndex = 0,
        CancellationToken cancellationToken = default)
    {
        await
            ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGetWithHttpInfoAsync(
                    clusterName, availabilityGroupName, baseMonitorName, operationIndex, cancellationToken)
                .ConfigureAwait(false);
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="availabilityGroupName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    public async Task<ApiResponse<object>>
        ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGetWithHttpInfoAsync(
            string clusterName, string availabilityGroupName, string baseMonitorName, int operationIndex = 0,
            CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'clusterName' is set
        if (clusterName == null)
            throw new ApiException(400,
                "Missing required parameter 'clusterName' when calling AvailabilityGroupsApi->ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet");

        // verify the required parameter 'availabilityGroupName' is set
        if (availabilityGroupName == null)
            throw new ApiException(400,
                "Missing required parameter 'availabilityGroupName' when calling AvailabilityGroupsApi->ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet");

        // verify the required parameter 'baseMonitorName' is set
        if (baseMonitorName == null)
            throw new ApiException(400,
                "Missing required parameter 'baseMonitorName' when calling AvailabilityGroupsApi->ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet");


        var localVarRequestOptions = new RequestOptions();

        var _contentTypes = new string[]
        {
        };

        // to determine the Accept header
        var _accepts = new[]
        {
            "application/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        localVarRequestOptions.PathParameters.Add("clusterName",
            ClientUtils.ParameterToString(clusterName)); // path parameter
        localVarRequestOptions.PathParameters.Add("availabilityGroupName",
            ClientUtils.ParameterToString(availabilityGroupName)); // path parameter
        localVarRequestOptions.PathParameters.Add("baseMonitorName",
            ClientUtils.ParameterToString(baseMonitorName)); // path parameter

        localVarRequestOptions.Operation =
            "AvailabilityGroupsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet";
        localVarRequestOptions.OperationIndex = operationIndex;


        // make the HTTP request
        var localVarResponse = await AsynchronousClient
            .GetAsync<object>(
                "/api/basemonitors/{baseMonitorName}/clusters/{clusterName}/availabilitygroups/{availabilityGroupName}",
                localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

        if (ExceptionFactory != null)
        {
            var _exception =
                ExceptionFactory(
                    "ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsAvailabilityGroupNameGet",
                    localVarResponse);
            if (_exception != null) throw _exception;
        }

        return localVarResponse;
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns></returns>
    public void ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet(string clusterName,
        string baseMonitorName, int operationIndex = 0)
    {
        ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGetWithHttpInfo(clusterName,
            baseMonitorName);
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of Object(void)</returns>
    public ApiResponse<object> ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGetWithHttpInfo(
        string clusterName, string baseMonitorName, int operationIndex = 0)
    {
        // verify the required parameter 'clusterName' is set
        if (clusterName == null)
            throw new ApiException(400,
                "Missing required parameter 'clusterName' when calling AvailabilityGroupsApi->ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet");

        // verify the required parameter 'baseMonitorName' is set
        if (baseMonitorName == null)
            throw new ApiException(400,
                "Missing required parameter 'baseMonitorName' when calling AvailabilityGroupsApi->ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet");

        var localVarRequestOptions = new RequestOptions();

        var _contentTypes = new string[]
        {
        };

        // to determine the Accept header
        var _accepts = new[]
        {
            "application/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
        var localVarMultipartFormData = localVarContentType == "multipart/form-data";
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        localVarRequestOptions.PathParameters.Add("clusterName",
            ClientUtils.ParameterToString(clusterName)); // path parameter
        localVarRequestOptions.PathParameters.Add("baseMonitorName",
            ClientUtils.ParameterToString(baseMonitorName)); // path parameter

        localVarRequestOptions.Operation =
            "AvailabilityGroupsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet";
        localVarRequestOptions.OperationIndex = operationIndex;


        // make the HTTP request
        var localVarResponse =
            Client.Get<object>("/api/basemonitors/{baseMonitorName}/clusters/{clusterName}/availabilitygroups",
                localVarRequestOptions, Configuration);
        if (ExceptionFactory != null)
        {
            var _exception = ExceptionFactory("ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet",
                localVarResponse);
            if (_exception != null) throw _exception;
        }

        return localVarResponse;
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of void</returns>
    public async Task ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGetAsync(string clusterName,
        string baseMonitorName, int operationIndex = 0, CancellationToken cancellationToken = default)
    {
        await ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGetWithHttpInfoAsync(clusterName,
            baseMonitorName, operationIndex, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="clusterName"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse</returns>
    public async Task<ApiResponse<object>>
        ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGetWithHttpInfoAsync(string clusterName,
            string baseMonitorName, int operationIndex = 0, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'clusterName' is set
        if (clusterName == null)
            throw new ApiException(400,
                "Missing required parameter 'clusterName' when calling AvailabilityGroupsApi->ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet");

        // verify the required parameter 'baseMonitorName' is set
        if (baseMonitorName == null)
            throw new ApiException(400,
                "Missing required parameter 'baseMonitorName' when calling AvailabilityGroupsApi->ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet");


        var localVarRequestOptions = new RequestOptions();

        var _contentTypes = new string[]
        {
        };

        // to determine the Accept header
        var _accepts = new[]
        {
            "application/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        localVarRequestOptions.PathParameters.Add("clusterName",
            ClientUtils.ParameterToString(clusterName)); // path parameter
        localVarRequestOptions.PathParameters.Add("baseMonitorName",
            ClientUtils.ParameterToString(baseMonitorName)); // path parameter

        localVarRequestOptions.Operation =
            "AvailabilityGroupsApi.ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet";
        localVarRequestOptions.OperationIndex = operationIndex;


        // make the HTTP request
        var localVarResponse = await AsynchronousClient
            .GetAsync<object>("/api/basemonitors/{baseMonitorName}/clusters/{clusterName}/availabilitygroups",
                localVarRequestOptions, Configuration, cancellationToken).ConfigureAwait(false);

        if (ExceptionFactory != null)
        {
            var _exception = ExceptionFactory("ApiBasemonitorsBaseMonitorNameClustersClusterNameAvailabilitygroupsGet",
                localVarResponse);
            if (_exception != null) throw _exception;
        }

        return localVarResponse;
    }
}