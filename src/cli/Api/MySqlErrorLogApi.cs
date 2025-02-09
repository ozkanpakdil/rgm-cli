/*
 * Redgate Monitor API - internal - for dev use only
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 14.0.45
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using cli.Client;
using cli.Model;

namespace cli.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMySqlErrorLogApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="dbmsCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ServerOverviewMySqlErrorLogDtoJSendSuccess</returns>
        ServerOverviewMySqlErrorLogDtoJSendSuccess ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGet(string baseMonitorName, MySqlInstanceChannelInstanceRef? dbmsCir = default(MySqlInstanceChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int? pageNumber = default(int?), int? pageSize = default(int?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="dbmsCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ServerOverviewMySqlErrorLogDtoJSendSuccess</returns>
        ApiResponse<ServerOverviewMySqlErrorLogDtoJSendSuccess> ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGetWithHttpInfo(string baseMonitorName, MySqlInstanceChannelInstanceRef? dbmsCir = default(MySqlInstanceChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int? pageNumber = default(int?), int? pageSize = default(int?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMySqlErrorLogApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="dbmsCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ServerOverviewMySqlErrorLogDtoJSendSuccess</returns>
        System.Threading.Tasks.Task<ServerOverviewMySqlErrorLogDtoJSendSuccess> ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGetAsync(string baseMonitorName, MySqlInstanceChannelInstanceRef? dbmsCir = default(MySqlInstanceChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int? pageNumber = default(int?), int? pageSize = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="dbmsCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ServerOverviewMySqlErrorLogDtoJSendSuccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<ServerOverviewMySqlErrorLogDtoJSendSuccess>> ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGetWithHttpInfoAsync(string baseMonitorName, MySqlInstanceChannelInstanceRef? dbmsCir = default(MySqlInstanceChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int? pageNumber = default(int?), int? pageSize = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMySqlErrorLogApi : IMySqlErrorLogApiSync, IMySqlErrorLogApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MySqlErrorLogApi : IMySqlErrorLogApi
    {
        private cli.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlErrorLogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MySqlErrorLogApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlErrorLogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MySqlErrorLogApi(string basePath)
        {
            this.Configuration = cli.Client.Configuration.MergeConfigurations(
                cli.Client.GlobalConfiguration.Instance,
                new cli.Client.Configuration { BasePath = basePath }
            );
            this.Client = new cli.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new cli.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = cli.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlErrorLogApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MySqlErrorLogApi(cli.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = cli.Client.Configuration.MergeConfigurations(
                cli.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new cli.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new cli.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = cli.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MySqlErrorLogApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MySqlErrorLogApi(cli.Client.ISynchronousClient client, cli.Client.IAsynchronousClient asyncClient, cli.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = cli.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public cli.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public cli.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public cli.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public cli.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="dbmsCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ServerOverviewMySqlErrorLogDtoJSendSuccess</returns>
        public ServerOverviewMySqlErrorLogDtoJSendSuccess ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGet(string baseMonitorName, MySqlInstanceChannelInstanceRef? dbmsCir = default(MySqlInstanceChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int? pageNumber = default(int?), int? pageSize = default(int?), int operationIndex = 0)
        {
            cli.Client.ApiResponse<ServerOverviewMySqlErrorLogDtoJSendSuccess> localVarResponse = ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGetWithHttpInfo(baseMonitorName, dbmsCir, startTime, endTime, pageNumber, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="dbmsCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ServerOverviewMySqlErrorLogDtoJSendSuccess</returns>
        public cli.Client.ApiResponse<ServerOverviewMySqlErrorLogDtoJSendSuccess> ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGetWithHttpInfo(string baseMonitorName, MySqlInstanceChannelInstanceRef? dbmsCir = default(MySqlInstanceChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int? pageNumber = default(int?), int? pageSize = default(int?), int operationIndex = 0)
        {
            // verify the required parameter 'baseMonitorName' is set
            if (baseMonitorName == null)
            {
                throw new cli.Client.ApiException(400, "Missing required parameter 'baseMonitorName' when calling MySqlErrorLogApi->ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGet");
            }

            cli.Client.RequestOptions localVarRequestOptions = new cli.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = cli.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            var localVarMultipartFormData = localVarContentType == "multipart/form-data";
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = cli.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("baseMonitorName", cli.Client.ClientUtils.ParameterToString(baseMonitorName)); // path parameter
            if (dbmsCir != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "dbmsCir", dbmsCir));
            }
            if (startTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "startTime", startTime));
            }
            if (endTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "endTime", endTime));
            }
            if (pageNumber != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "pageNumber", pageNumber));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "pageSize", pageSize));
            }

            localVarRequestOptions.Operation = "MySqlErrorLogApi.ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<ServerOverviewMySqlErrorLogDtoJSendSuccess>("/api/basemonitors/{baseMonitorName}/MySqlErrorLog/GetErrorLogs", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="dbmsCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ServerOverviewMySqlErrorLogDtoJSendSuccess</returns>
        public async System.Threading.Tasks.Task<ServerOverviewMySqlErrorLogDtoJSendSuccess> ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGetAsync(string baseMonitorName, MySqlInstanceChannelInstanceRef? dbmsCir = default(MySqlInstanceChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int? pageNumber = default(int?), int? pageSize = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            cli.Client.ApiResponse<ServerOverviewMySqlErrorLogDtoJSendSuccess> localVarResponse = await ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGetWithHttpInfoAsync(baseMonitorName, dbmsCir, startTime, endTime, pageNumber, pageSize, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="dbmsCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="pageNumber"> (optional, default to 1)</param>
        /// <param name="pageSize"> (optional, default to 10)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ServerOverviewMySqlErrorLogDtoJSendSuccess)</returns>
        public async System.Threading.Tasks.Task<cli.Client.ApiResponse<ServerOverviewMySqlErrorLogDtoJSendSuccess>> ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGetWithHttpInfoAsync(string baseMonitorName, MySqlInstanceChannelInstanceRef? dbmsCir = default(MySqlInstanceChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int? pageNumber = default(int?), int? pageSize = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'baseMonitorName' is set
            if (baseMonitorName == null)
            {
                throw new cli.Client.ApiException(400, "Missing required parameter 'baseMonitorName' when calling MySqlErrorLogApi->ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGet");
            }


            cli.Client.RequestOptions localVarRequestOptions = new cli.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = cli.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = cli.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("baseMonitorName", cli.Client.ClientUtils.ParameterToString(baseMonitorName)); // path parameter
            if (dbmsCir != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "dbmsCir", dbmsCir));
            }
            if (startTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "startTime", startTime));
            }
            if (endTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "endTime", endTime));
            }
            if (pageNumber != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "pageNumber", pageNumber));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "pageSize", pageSize));
            }

            localVarRequestOptions.Operation = "MySqlErrorLogApi.ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ServerOverviewMySqlErrorLogDtoJSendSuccess>("/api/basemonitors/{baseMonitorName}/MySqlErrorLog/GetErrorLogs", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiBasemonitorsBaseMonitorNameMySqlErrorLogGetErrorLogsGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
