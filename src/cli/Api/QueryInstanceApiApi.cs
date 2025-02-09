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
    public interface IQueryInstanceApiApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TimeSpanJSendSuccess</returns>
        TimeSpanJSendSuccess ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGet(string baseMonitorName, int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TimeSpanJSendSuccess</returns>
        ApiResponse<TimeSpanJSendSuccess> ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGetWithHttpInfo(string baseMonitorName, int operationIndex = 0);
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="instanceCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>QueryInstanceDtoIEnumerableJSendSuccess</returns>
        QueryInstanceDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameQueryinstancesGet(string baseMonitorName, ChannelInstanceRef? instanceCir = default(ChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int operationIndex = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="instanceCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of QueryInstanceDtoIEnumerableJSendSuccess</returns>
        ApiResponse<QueryInstanceDtoIEnumerableJSendSuccess> ApiBasemonitorsBaseMonitorNameQueryinstancesGetWithHttpInfo(string baseMonitorName, ChannelInstanceRef? instanceCir = default(ChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQueryInstanceApiApiAsync : IApiAccessor
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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TimeSpanJSendSuccess</returns>
        System.Threading.Tasks.Task<TimeSpanJSendSuccess> ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGetAsync(string baseMonitorName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TimeSpanJSendSuccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<TimeSpanJSendSuccess>> ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGetWithHttpInfoAsync(string baseMonitorName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="instanceCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of QueryInstanceDtoIEnumerableJSendSuccess</returns>
        System.Threading.Tasks.Task<QueryInstanceDtoIEnumerableJSendSuccess> ApiBasemonitorsBaseMonitorNameQueryinstancesGetAsync(string baseMonitorName, ChannelInstanceRef? instanceCir = default(ChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="instanceCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (QueryInstanceDtoIEnumerableJSendSuccess)</returns>
        System.Threading.Tasks.Task<ApiResponse<QueryInstanceDtoIEnumerableJSendSuccess>> ApiBasemonitorsBaseMonitorNameQueryinstancesGetWithHttpInfoAsync(string baseMonitorName, ChannelInstanceRef? instanceCir = default(ChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQueryInstanceApiApi : IQueryInstanceApiApiSync, IQueryInstanceApiApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class QueryInstanceApiApi : IQueryInstanceApiApi
    {
        private cli.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryInstanceApiApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QueryInstanceApiApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryInstanceApiApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QueryInstanceApiApi(string basePath)
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
        /// Initializes a new instance of the <see cref="QueryInstanceApiApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public QueryInstanceApiApi(cli.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="QueryInstanceApiApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public QueryInstanceApiApi(cli.Client.ISynchronousClient client, cli.Client.IAsynchronousClient asyncClient, cli.Client.IReadableConfiguration configuration)
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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>TimeSpanJSendSuccess</returns>
        public TimeSpanJSendSuccess ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGet(string baseMonitorName, int operationIndex = 0)
        {
            cli.Client.ApiResponse<TimeSpanJSendSuccess> localVarResponse = ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGetWithHttpInfo(baseMonitorName);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of TimeSpanJSendSuccess</returns>
        public cli.Client.ApiResponse<TimeSpanJSendSuccess> ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGetWithHttpInfo(string baseMonitorName, int operationIndex = 0)
        {
            // verify the required parameter 'baseMonitorName' is set
            if (baseMonitorName == null)
            {
                throw new cli.Client.ApiException(400, "Missing required parameter 'baseMonitorName' when calling QueryInstanceApiApi->ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGet");
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

            localVarRequestOptions.Operation = "QueryInstanceApiApi.ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<TimeSpanJSendSuccess>("/api/basemonitors/{baseMonitorName}/queryinstances/durationfilter", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGet", localVarResponse);
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
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TimeSpanJSendSuccess</returns>
        public async System.Threading.Tasks.Task<TimeSpanJSendSuccess> ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGetAsync(string baseMonitorName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            cli.Client.ApiResponse<TimeSpanJSendSuccess> localVarResponse = await ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGetWithHttpInfoAsync(baseMonitorName, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TimeSpanJSendSuccess)</returns>
        public async System.Threading.Tasks.Task<cli.Client.ApiResponse<TimeSpanJSendSuccess>> ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGetWithHttpInfoAsync(string baseMonitorName, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'baseMonitorName' is set
            if (baseMonitorName == null)
            {
                throw new cli.Client.ApiException(400, "Missing required parameter 'baseMonitorName' when calling QueryInstanceApiApi->ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGet");
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

            localVarRequestOptions.Operation = "QueryInstanceApiApi.ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<TimeSpanJSendSuccess>("/api/basemonitors/{baseMonitorName}/queryinstances/durationfilter", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiBasemonitorsBaseMonitorNameQueryinstancesDurationfilterGet", localVarResponse);
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
        /// <param name="instanceCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>QueryInstanceDtoIEnumerableJSendSuccess</returns>
        public QueryInstanceDtoIEnumerableJSendSuccess ApiBasemonitorsBaseMonitorNameQueryinstancesGet(string baseMonitorName, ChannelInstanceRef? instanceCir = default(ChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int operationIndex = 0)
        {
            cli.Client.ApiResponse<QueryInstanceDtoIEnumerableJSendSuccess> localVarResponse = ApiBasemonitorsBaseMonitorNameQueryinstancesGetWithHttpInfo(baseMonitorName, instanceCir, startTime, endTime);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="instanceCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of QueryInstanceDtoIEnumerableJSendSuccess</returns>
        public cli.Client.ApiResponse<QueryInstanceDtoIEnumerableJSendSuccess> ApiBasemonitorsBaseMonitorNameQueryinstancesGetWithHttpInfo(string baseMonitorName, ChannelInstanceRef? instanceCir = default(ChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int operationIndex = 0)
        {
            // verify the required parameter 'baseMonitorName' is set
            if (baseMonitorName == null)
            {
                throw new cli.Client.ApiException(400, "Missing required parameter 'baseMonitorName' when calling QueryInstanceApiApi->ApiBasemonitorsBaseMonitorNameQueryinstancesGet");
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
            if (instanceCir != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "instanceCir", instanceCir));
            }
            if (startTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "startTime", startTime));
            }
            if (endTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "endTime", endTime));
            }

            localVarRequestOptions.Operation = "QueryInstanceApiApi.ApiBasemonitorsBaseMonitorNameQueryinstancesGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<QueryInstanceDtoIEnumerableJSendSuccess>("/api/basemonitors/{baseMonitorName}/queryinstances", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiBasemonitorsBaseMonitorNameQueryinstancesGet", localVarResponse);
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
        /// <param name="instanceCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of QueryInstanceDtoIEnumerableJSendSuccess</returns>
        public async System.Threading.Tasks.Task<QueryInstanceDtoIEnumerableJSendSuccess> ApiBasemonitorsBaseMonitorNameQueryinstancesGetAsync(string baseMonitorName, ChannelInstanceRef? instanceCir = default(ChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            cli.Client.ApiResponse<QueryInstanceDtoIEnumerableJSendSuccess> localVarResponse = await ApiBasemonitorsBaseMonitorNameQueryinstancesGetWithHttpInfoAsync(baseMonitorName, instanceCir, startTime, endTime, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="cli.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="baseMonitorName"></param>
        /// <param name="instanceCir"> (optional)</param>
        /// <param name="startTime"> (optional)</param>
        /// <param name="endTime"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (QueryInstanceDtoIEnumerableJSendSuccess)</returns>
        public async System.Threading.Tasks.Task<cli.Client.ApiResponse<QueryInstanceDtoIEnumerableJSendSuccess>> ApiBasemonitorsBaseMonitorNameQueryinstancesGetWithHttpInfoAsync(string baseMonitorName, ChannelInstanceRef? instanceCir = default(ChannelInstanceRef?), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'baseMonitorName' is set
            if (baseMonitorName == null)
            {
                throw new cli.Client.ApiException(400, "Missing required parameter 'baseMonitorName' when calling QueryInstanceApiApi->ApiBasemonitorsBaseMonitorNameQueryinstancesGet");
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
            if (instanceCir != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "instanceCir", instanceCir));
            }
            if (startTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "startTime", startTime));
            }
            if (endTime != null)
            {
                localVarRequestOptions.QueryParameters.Add(cli.Client.ClientUtils.ParameterToMultiMap("", "endTime", endTime));
            }

            localVarRequestOptions.Operation = "QueryInstanceApiApi.ApiBasemonitorsBaseMonitorNameQueryinstancesGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<QueryInstanceDtoIEnumerableJSendSuccess>("/api/basemonitors/{baseMonitorName}/queryinstances", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiBasemonitorsBaseMonitorNameQueryinstancesGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
