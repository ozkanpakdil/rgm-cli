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
using cli.Model;
using RedGate.SqlMonitor.Channels.Data;

namespace cli.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IDiskUsageDetailsApiApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="diskCir"> (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>DatabaseFileUsageViewModelJSendSuccess</returns>
    DatabaseFileUsageViewModelJSendSuccess ApiEstateDiskUsageDetailsGet(ChannelInstanceRef? diskCir = default,
        int operationIndex = 0);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="diskCir"> (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of DatabaseFileUsageViewModelJSendSuccess</returns>
    ApiResponse<DatabaseFileUsageViewModelJSendSuccess> ApiEstateDiskUsageDetailsGetWithHttpInfo(
        ChannelInstanceRef? diskCir = default, int operationIndex = 0);

    #endregion Synchronous Operations
}

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IDiskUsageDetailsApiApiAsync : IApiAccessor
{
    #region Asynchronous Operations

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="diskCir"> (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of DatabaseFileUsageViewModelJSendSuccess</returns>
    Task<DatabaseFileUsageViewModelJSendSuccess> ApiEstateDiskUsageDetailsGetAsync(
        ChannelInstanceRef? diskCir = default, int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="diskCir"> (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (DatabaseFileUsageViewModelJSendSuccess)</returns>
    Task<ApiResponse<DatabaseFileUsageViewModelJSendSuccess>> ApiEstateDiskUsageDetailsGetWithHttpInfoAsync(
        ChannelInstanceRef? diskCir = default, int operationIndex = 0, CancellationToken cancellationToken = default);

    #endregion Asynchronous Operations
}

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IDiskUsageDetailsApiApi : IDiskUsageDetailsApiApiSync, IDiskUsageDetailsApiApiAsync
{
}

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public class DiskUsageDetailsApiApi : IDiskUsageDetailsApiApi
{
    private ExceptionFactory _exceptionFactory = (name, response) => null;

    /// <summary>
    ///     Initializes a new instance of the <see cref="DiskUsageDetailsApiApi" /> class.
    /// </summary>
    /// <returns></returns>
    public DiskUsageDetailsApiApi() : this((string)null)
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="DiskUsageDetailsApiApi" /> class.
    /// </summary>
    /// <returns></returns>
    public DiskUsageDetailsApiApi(string basePath)
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
    ///     Initializes a new instance of the <see cref="DiskUsageDetailsApiApi" /> class
    ///     using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public DiskUsageDetailsApiApi(Configuration configuration)
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
    ///     Initializes a new instance of the <see cref="DiskUsageDetailsApiApi" /> class
    ///     using a Configuration object and client instance.
    /// </summary>
    /// <param name="client">The client interface for synchronous API access.</param>
    /// <param name="asyncClient">The client interface for asynchronous API access.</param>
    /// <param name="configuration">The configuration object.</param>
    public DiskUsageDetailsApiApi(ISynchronousClient client, IAsynchronousClient asyncClient,
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
    /// <param name="diskCir"> (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>DatabaseFileUsageViewModelJSendSuccess</returns>
    public DatabaseFileUsageViewModelJSendSuccess ApiEstateDiskUsageDetailsGet(ChannelInstanceRef? diskCir = default,
        int operationIndex = 0)
    {
        var localVarResponse = ApiEstateDiskUsageDetailsGetWithHttpInfo(diskCir);
        return localVarResponse.Data;
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="diskCir"> (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of DatabaseFileUsageViewModelJSendSuccess</returns>
    public ApiResponse<DatabaseFileUsageViewModelJSendSuccess> ApiEstateDiskUsageDetailsGetWithHttpInfo(
        ChannelInstanceRef? diskCir = default, int operationIndex = 0)
    {
        var localVarRequestOptions = new RequestOptions();

        var _contentTypes = new string[]
        {
        };

        // to determine the Accept header
        var _accepts = new[]
        {
            "text/plain",
            "application/json",
            "text/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
        var localVarMultipartFormData = localVarContentType == "multipart/form-data";
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        if (diskCir != null)
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "diskCir", diskCir));

        localVarRequestOptions.Operation = "DiskUsageDetailsApiApi.ApiEstateDiskUsageDetailsGet";
        localVarRequestOptions.OperationIndex = operationIndex;


        // make the HTTP request
        var localVarResponse = Client.Get<DatabaseFileUsageViewModelJSendSuccess>("/api/estate/disk-usage-details",
            localVarRequestOptions, Configuration);
        if (ExceptionFactory != null)
        {
            var _exception = ExceptionFactory("ApiEstateDiskUsageDetailsGet", localVarResponse);
            if (_exception != null) throw _exception;
        }

        return localVarResponse;
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="diskCir"> (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of DatabaseFileUsageViewModelJSendSuccess</returns>
    public async Task<DatabaseFileUsageViewModelJSendSuccess> ApiEstateDiskUsageDetailsGetAsync(
        ChannelInstanceRef? diskCir = default, int operationIndex = 0, CancellationToken cancellationToken = default)
    {
        var localVarResponse =
            await ApiEstateDiskUsageDetailsGetWithHttpInfoAsync(diskCir, operationIndex, cancellationToken)
                .ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="diskCir"> (optional)</param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (DatabaseFileUsageViewModelJSendSuccess)</returns>
    public async Task<ApiResponse<DatabaseFileUsageViewModelJSendSuccess>>
        ApiEstateDiskUsageDetailsGetWithHttpInfoAsync(ChannelInstanceRef? diskCir = default, int operationIndex = 0,
            CancellationToken cancellationToken = default)
    {
        var localVarRequestOptions = new RequestOptions();

        var _contentTypes = new string[]
        {
        };

        // to determine the Accept header
        var _accepts = new[]
        {
            "text/plain",
            "application/json",
            "text/json"
        };

        var localVarContentType = ClientUtils.SelectHeaderContentType(_contentTypes);
        if (localVarContentType != null)
            localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

        var localVarAccept = ClientUtils.SelectHeaderAccept(_accepts);
        if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

        if (diskCir != null)
            localVarRequestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "diskCir", diskCir));

        localVarRequestOptions.Operation = "DiskUsageDetailsApiApi.ApiEstateDiskUsageDetailsGet";
        localVarRequestOptions.OperationIndex = operationIndex;


        // make the HTTP request
        var localVarResponse = await AsynchronousClient
            .GetAsync<DatabaseFileUsageViewModelJSendSuccess>("/api/estate/disk-usage-details", localVarRequestOptions,
                Configuration, cancellationToken).ConfigureAwait(false);

        if (ExceptionFactory != null)
        {
            var _exception = ExceptionFactory("ApiEstateDiskUsageDetailsGet", localVarResponse);
            if (_exception != null) throw _exception;
        }

        return localVarResponse;
    }
}