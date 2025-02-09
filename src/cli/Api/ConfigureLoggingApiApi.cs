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
    public interface IConfigureLoggingApiApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>JSendSuccess</returns>
        JSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost(string baseMonitorName, LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of JSendSuccess</returns>
        ApiResponse<JSendSuccess> ApiBasemonitorsBaseMonitorNameConfigurationLoggingPostWithHttpInfo(string baseMonitorName, LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enabledSeconds"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>JSendSuccess</returns>
        JSendSuccess ApiConfigurationLoggingPerformancePost(int? enabledSeconds = default(int?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enabledSeconds"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of JSendSuccess</returns>
        ApiResponse<JSendSuccess> ApiConfigurationLoggingPerformancePostWithHttpInfo(int? enabledSeconds = default(int?), int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>JSendSuccess</returns>
        JSendSuccess ApiConfigurationLoggingPost(LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of JSendSuccess</returns>
        ApiResponse<JSendSuccess> ApiConfigurationLoggingPostWithHttpInfo(LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigureLoggingApiApiAsync : IApiAccessor
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
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of JSendSuccess</returns>
        System.Threading.Tasks.Task<JSendSuccess> ApiBasemonitorsBaseMonitorNameConfigurationLoggingPostAsync(string baseMonitorName, LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (JSendSuccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<JSendSuccess>> ApiBasemonitorsBaseMonitorNameConfigurationLoggingPostWithHttpInfoAsync(string baseMonitorName, LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enabledSeconds"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of JSendSuccess</returns>
        System.Threading.Tasks.Task<JSendSuccess> ApiConfigurationLoggingPerformancePostAsync(int? enabledSeconds = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enabledSeconds"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (JSendSuccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<JSendSuccess>> ApiConfigurationLoggingPerformancePostWithHttpInfoAsync(int? enabledSeconds = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of JSendSuccess</returns>
        System.Threading.Tasks.Task<JSendSuccess> ApiConfigurationLoggingPostAsync(LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (JSendSuccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<JSendSuccess>> ApiConfigurationLoggingPostWithHttpInfoAsync(LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IConfigureLoggingApiApi : IConfigureLoggingApiApiSync, IConfigureLoggingApiApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ConfigureLoggingApiApi : IConfigureLoggingApiApi
    {
        private cli.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureLoggingApiApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigureLoggingApiApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureLoggingApiApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ConfigureLoggingApiApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ConfigureLoggingApiApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ConfigureLoggingApiApi(cli.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ConfigureLoggingApiApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ConfigureLoggingApiApi(cli.Client.ISynchronousClient client, cli.Client.IAsynchronousClient asyncClient, cli.Client.IReadableConfiguration configuration)
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
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>JSendSuccess</returns>
        public JSendSuccess ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost(string baseMonitorName, LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0)
        {
            cli.Client.ApiResponse<JSendSuccess> localVarResponse = ApiBasemonitorsBaseMonitorNameConfigurationLoggingPostWithHttpInfo(baseMonitorName, logLevelSwitchParamsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of JSendSuccess</returns>
        public cli.Client.ApiResponse<JSendSuccess> ApiBasemonitorsBaseMonitorNameConfigurationLoggingPostWithHttpInfo(string baseMonitorName, LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0)
        {
            // verify the required parameter 'baseMonitorName' is set
            if (baseMonitorName == null)
            {
                throw new cli.Client.ApiException(400, "Missing required parameter 'baseMonitorName' when calling ConfigureLoggingApiApi->ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost");
            }

            cli.Client.RequestOptions localVarRequestOptions = new cli.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/*+json"
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
            localVarRequestOptions.Data = logLevelSwitchParamsDto;

            localVarRequestOptions.Operation = "ConfigureLoggingApiApi.ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<JSendSuccess>("/api/basemonitors/{baseMonitorName}/configuration/logging", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost", localVarResponse);
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
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of JSendSuccess</returns>
        public async System.Threading.Tasks.Task<JSendSuccess> ApiBasemonitorsBaseMonitorNameConfigurationLoggingPostAsync(string baseMonitorName, LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            cli.Client.ApiResponse<JSendSuccess> localVarResponse = await ApiBasemonitorsBaseMonitorNameConfigurationLoggingPostWithHttpInfoAsync(baseMonitorName, logLevelSwitchParamsDto, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (JSendSuccess)</returns>
        public async System.Threading.Tasks.Task<cli.Client.ApiResponse<JSendSuccess>> ApiBasemonitorsBaseMonitorNameConfigurationLoggingPostWithHttpInfoAsync(string baseMonitorName, LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'baseMonitorName' is set
            if (baseMonitorName == null)
            {
                throw new cli.Client.ApiException(400, "Missing required parameter 'baseMonitorName' when calling ConfigureLoggingApiApi->ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost");
            }


            cli.Client.RequestOptions localVarRequestOptions = new cli.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
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
            localVarRequestOptions.Data = logLevelSwitchParamsDto;

            localVarRequestOptions.Operation = "ConfigureLoggingApiApi.ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<JSendSuccess>("/api/basemonitors/{baseMonitorName}/configuration/logging", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiBasemonitorsBaseMonitorNameConfigurationLoggingPost", localVarResponse);
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
        /// <param name="enabledSeconds"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>JSendSuccess</returns>
        public JSendSuccess ApiConfigurationLoggingPerformancePost(int? enabledSeconds = default(int?), int operationIndex = 0)
        {
            cli.Client.ApiResponse<JSendSuccess> localVarResponse = ApiConfigurationLoggingPerformancePostWithHttpInfo(enabledSeconds);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enabledSeconds"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of JSendSuccess</returns>
        public cli.Client.ApiResponse<JSendSuccess> ApiConfigurationLoggingPerformancePostWithHttpInfo(int? enabledSeconds = default(int?), int operationIndex = 0)
        {
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

            if (enabledSeconds != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "enabledSeconds", enabledSeconds));
            }

            localVarRequestOptions.Operation = "ConfigureLoggingApiApi.ApiConfigurationLoggingPerformancePost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<JSendSuccess>("/api/configuration/logging/performance", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiConfigurationLoggingPerformancePost", localVarResponse);
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
        /// <param name="enabledSeconds"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of JSendSuccess</returns>
        public async System.Threading.Tasks.Task<JSendSuccess> ApiConfigurationLoggingPerformancePostAsync(int? enabledSeconds = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            cli.Client.ApiResponse<JSendSuccess> localVarResponse = await ApiConfigurationLoggingPerformancePostWithHttpInfoAsync(enabledSeconds, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enabledSeconds"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (JSendSuccess)</returns>
        public async System.Threading.Tasks.Task<cli.Client.ApiResponse<JSendSuccess>> ApiConfigurationLoggingPerformancePostWithHttpInfoAsync(int? enabledSeconds = default(int?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

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

            if (enabledSeconds != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "enabledSeconds", enabledSeconds));
            }

            localVarRequestOptions.Operation = "ConfigureLoggingApiApi.ApiConfigurationLoggingPerformancePost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<JSendSuccess>("/api/configuration/logging/performance", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiConfigurationLoggingPerformancePost", localVarResponse);
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
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>JSendSuccess</returns>
        public JSendSuccess ApiConfigurationLoggingPost(LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0)
        {
            cli.Client.ApiResponse<JSendSuccess> localVarResponse = ApiConfigurationLoggingPostWithHttpInfo(logLevelSwitchParamsDto);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of JSendSuccess</returns>
        public cli.Client.ApiResponse<JSendSuccess> ApiConfigurationLoggingPostWithHttpInfo(LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0)
        {
            cli.Client.RequestOptions localVarRequestOptions = new cli.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/*+json"
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

            localVarRequestOptions.Data = logLevelSwitchParamsDto;

            localVarRequestOptions.Operation = "ConfigureLoggingApiApi.ApiConfigurationLoggingPost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<JSendSuccess>("/api/configuration/logging", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiConfigurationLoggingPost", localVarResponse);
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
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of JSendSuccess</returns>
        public async System.Threading.Tasks.Task<JSendSuccess> ApiConfigurationLoggingPostAsync(LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            cli.Client.ApiResponse<JSendSuccess> localVarResponse = await ApiConfigurationLoggingPostWithHttpInfoAsync(logLevelSwitchParamsDto, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logLevelSwitchParamsDto"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (JSendSuccess)</returns>
        public async System.Threading.Tasks.Task<cli.Client.ApiResponse<JSendSuccess>> ApiConfigurationLoggingPostWithHttpInfoAsync(LogLevelSwitchParamsDto? logLevelSwitchParamsDto = default(LogLevelSwitchParamsDto?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            cli.Client.RequestOptions localVarRequestOptions = new cli.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
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

            localVarRequestOptions.Data = logLevelSwitchParamsDto;

            localVarRequestOptions.Operation = "ConfigureLoggingApiApi.ApiConfigurationLoggingPost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<JSendSuccess>("/api/configuration/logging", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiConfigurationLoggingPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
