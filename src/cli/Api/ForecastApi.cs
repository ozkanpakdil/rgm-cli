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
using RedGate.SqlMonitor.Channels;

namespace cli.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IForecastApiSync : IApiAccessor
{
    #region Synchronous Operations

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cir"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>DoubleArrayIEnumerableJSendSuccess</returns>
    DoubleArrayIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet(GroupOrCir cir,
        string baseMonitorName, int operationIndex = 0);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cir"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of DoubleArrayIEnumerableJSendSuccess</returns>
    ApiResponse<DoubleArrayIEnumerableJSendSuccess>
        ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGetWithHttpInfo(GroupOrCir cir,
            string baseMonitorName,
            int operationIndex = 0);

    #endregion Synchronous Operations
}

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IForecastApiAsync : IApiAccessor
{
    #region Asynchronous Operations

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cir"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of DoubleArrayIEnumerableJSendSuccess</returns>
    Task<DoubleArrayIEnumerableJSendSuccess> ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGetAsync(
        GroupOrCir cir, string baseMonitorName, int operationIndex = 0, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cir"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (DoubleArrayIEnumerableJSendSuccess)</returns>
    Task<ApiResponse<DoubleArrayIEnumerableJSendSuccess>>
        ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGetWithHttpInfoAsync(GroupOrCir cir,
            string baseMonitorName, int operationIndex = 0, CancellationToken cancellationToken = default);

    #endregion Asynchronous Operations
}

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IForecastApi : IForecastApiSync, IForecastApiAsync
{
}

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public class ForecastApi : IForecastApi
{
    private ExceptionFactory _exceptionFactory = (name, response) => null;

    /// <summary>
    ///     Initializes a new instance of the <see cref="ForecastApi" /> class.
    /// </summary>
    /// <returns></returns>
    public ForecastApi() : this((string)null)
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ForecastApi" /> class.
    /// </summary>
    /// <returns></returns>
    public ForecastApi(string basePath)
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
    ///     Initializes a new instance of the <see cref="ForecastApi" /> class
    ///     using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public ForecastApi(Configuration configuration)
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
    ///     Initializes a new instance of the <see cref="ForecastApi" /> class
    ///     using a Configuration object and client instance.
    /// </summary>
    /// <param name="client">The client interface for synchronous API access.</param>
    /// <param name="asyncClient">The client interface for asynchronous API access.</param>
    /// <param name="configuration">The configuration object.</param>
    public ForecastApi(ISynchronousClient client, IAsynchronousClient asyncClient, IReadableConfiguration configuration)
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
    /// <param name="cir"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>DoubleArrayIEnumerableJSendSuccess</returns>
    public DoubleArrayIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet(
        GroupOrCir cir, string baseMonitorName, int operationIndex = 0)
    {
        var localVarResponse =
            ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGetWithHttpInfo(cir, baseMonitorName);
        return localVarResponse.Data;
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cir"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <returns>ApiResponse of DoubleArrayIEnumerableJSendSuccess</returns>
    public ApiResponse<DoubleArrayIEnumerableJSendSuccess>
        ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGetWithHttpInfo(GroupOrCir cir,
            string baseMonitorName,
            int operationIndex = 0)
    {
        // verify the required parameter 'cir' is set
        if (cir == null)
            throw new ApiException(400,
                "Missing required parameter 'cir' when calling ForecastApi->ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet");

        // verify the required parameter 'baseMonitorName' is set
        if (baseMonitorName == null)
            throw new ApiException(400,
                "Missing required parameter 'baseMonitorName' when calling ForecastApi->ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet");

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

        localVarRequestOptions.PathParameters.Add("cir", ClientUtils.ParameterToString(cir)); // path parameter
        localVarRequestOptions.PathParameters.Add("baseMonitorName",
            ClientUtils.ParameterToString(baseMonitorName)); // path parameter

        localVarRequestOptions.Operation =
            "ForecastApi.ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet";
        localVarRequestOptions.OperationIndex = operationIndex;


        // make the HTTP request
        var localVarResponse = Client.Get<DoubleArrayIEnumerableJSendSuccess>(
            "/api/basemonitors/{baseMonitorName}/sqlinstances/{cir}/cpu-alert-forecast", localVarRequestOptions,
            Configuration);
        if (ExceptionFactory != null)
        {
            var _exception = ExceptionFactory("ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet",
                localVarResponse);
            if (_exception != null) throw _exception;
        }

        return localVarResponse;
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cir"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of DoubleArrayIEnumerableJSendSuccess</returns>
    public async Task<DoubleArrayIEnumerableJSendSuccess>
        ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGetAsync(GroupOrCir cir, string baseMonitorName,
            int operationIndex = 0, CancellationToken cancellationToken = default)
    {
        var localVarResponse =
            await ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGetWithHttpInfoAsync(cir,
                baseMonitorName, operationIndex, cancellationToken).ConfigureAwait(false);
        return localVarResponse.Data;
    }

    /// <summary>
    /// </summary>
    /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
    /// <param name="cir"></param>
    /// <param name="baseMonitorName"></param>
    /// <param name="operationIndex">Index associated with the operation.</param>
    /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
    /// <returns>Task of ApiResponse (DoubleArrayIEnumerableJSendSuccess)</returns>
    public async Task<ApiResponse<DoubleArrayIEnumerableJSendSuccess>>
        ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGetWithHttpInfoAsync(GroupOrCir cir,
            string baseMonitorName, int operationIndex = 0, CancellationToken cancellationToken = default)
    {
        // verify the required parameter 'cir' is set
        if (cir == null)
            throw new ApiException(400,
                "Missing required parameter 'cir' when calling ForecastApi->ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet");

        // verify the required parameter 'baseMonitorName' is set
        if (baseMonitorName == null)
            throw new ApiException(400,
                "Missing required parameter 'baseMonitorName' when calling ForecastApi->ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet");


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

        localVarRequestOptions.PathParameters.Add("cir", ClientUtils.ParameterToString(cir)); // path parameter
        localVarRequestOptions.PathParameters.Add("baseMonitorName",
            ClientUtils.ParameterToString(baseMonitorName)); // path parameter

        localVarRequestOptions.Operation =
            "ForecastApi.ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet";
        localVarRequestOptions.OperationIndex = operationIndex;


        // make the HTTP request
        var localVarResponse = await AsynchronousClient
            .GetAsync<DoubleArrayIEnumerableJSendSuccess>(
                "/api/basemonitors/{baseMonitorName}/sqlinstances/{cir}/cpu-alert-forecast", localVarRequestOptions,
                Configuration, cancellationToken).ConfigureAwait(false);

        if (ExceptionFactory != null)
        {
            var _exception = ExceptionFactory("ApiBasemonitorsBaseMonitorNameSqlinstancesCirCpuAlertForecastGet",
                localVarResponse);
            if (_exception != null) throw _exception;
        }

        return localVarResponse;
    }
}