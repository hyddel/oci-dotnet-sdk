/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Oci.Common;
using Oci.Common.Auth;
using Oci.Common.Retry;
using Oci.AnalyticsService.Requests;
using Oci.AnalyticsService.Responses;

namespace Oci.AnalyticsService
{
    /// <summary>Service client instance for Analytics.</summary>
    public class AnalyticsClient : RegionalClientBase
    {
        private readonly RetryConfiguration retryConfiguration;
        private const string basePathWithoutHost = "/20190331";

        public AnalyticsPaginators Paginators { get; }

        public AnalyticsWaiters Waiters { get; }

        /// <summary>
        /// Creates a new service instance using the given authentication provider and/or client configuration and/or endpoint.
        /// A client configuration can also be provided optionally to adjust REST client behaviors.
        /// </summary>
        /// <param name="authenticationDetailsProvider">The authentication details provider. Required.</param>
        /// <param name="clientConfiguration">The client configuration that contains settings to adjust REST client behaviors. Optional.</param>
        /// <param name="endpoint">The endpoint of the service. If not provided and the client is a regional client, the endpoint will be constructed based on region information. Optional.</param>
        public AnalyticsClient(IBasicAuthenticationDetailsProvider authenticationDetailsProvider, ClientConfiguration clientConfiguration = null, string endpoint = null)
            : base(authenticationDetailsProvider, clientConfiguration)
        {
            service = new Service
            {
                ServiceName = "ANALYTICS",
                ServiceEndpointPrefix = "",
                ServiceEndpointTemplate = "https://analytics.{region}.ocp.{secondLevelDomain}"
            };

            ClientConfiguration clientConfigurationToUse = clientConfiguration ?? new ClientConfiguration();

            if (authenticationDetailsProvider is IRegionProvider)
            {
                // Use region from Authentication details provider.
                SetRegion(((IRegionProvider)authenticationDetailsProvider).Region);
            }

            if (endpoint != null)
            {
                logger.Info($"Using endpoint specified \"{endpoint}\".");
                SetEndpoint(endpoint);
            }

            this.retryConfiguration = clientConfigurationToUse.RetryConfiguration;
            Paginators = new AnalyticsPaginators(this);
            Waiters = new AnalyticsWaiters(this);
        }

        /// <summary>
        /// Change the compartment of an Analytics instance. The operation is long-running
        /// and creates a new WorkRequest.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<ChangeAnalyticsInstanceCompartmentResponse> ChangeAnalyticsInstanceCompartment(ChangeAnalyticsInstanceCompartmentRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called changeAnalyticsInstanceCompartment");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/analyticsInstances/{analyticsInstanceId}/actions/changeCompartment".Trim('/')));
            HttpMethod method = new HttpMethod("Post");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<ChangeAnalyticsInstanceCompartmentResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ChangeAnalyticsInstanceCompartment failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Change an Analytics instance network endpoint. The operation is long-running
        /// and creates a new WorkRequest.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<ChangeAnalyticsInstanceNetworkEndpointResponse> ChangeAnalyticsInstanceNetworkEndpoint(ChangeAnalyticsInstanceNetworkEndpointRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called changeAnalyticsInstanceNetworkEndpoint");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/analyticsInstances/{analyticsInstanceId}/actions/changeNetworkEndpoint".Trim('/')));
            HttpMethod method = new HttpMethod("Post");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<ChangeAnalyticsInstanceNetworkEndpointResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ChangeAnalyticsInstanceNetworkEndpoint failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Create a new AnalyticsInstance in the specified compartment. The operation is long-running
        /// and creates a new WorkRequest.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<CreateAnalyticsInstanceResponse> CreateAnalyticsInstance(CreateAnalyticsInstanceRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called createAnalyticsInstance");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/analyticsInstances".Trim('/')));
            HttpMethod method = new HttpMethod("Post");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<CreateAnalyticsInstanceResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"CreateAnalyticsInstance failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Terminates the specified Analytics instance. The operation is long-running
        /// and creates a new WorkRequest.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<DeleteAnalyticsInstanceResponse> DeleteAnalyticsInstance(DeleteAnalyticsInstanceRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called deleteAnalyticsInstance");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/analyticsInstances/{analyticsInstanceId}".Trim('/')));
            HttpMethod method = new HttpMethod("Delete");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<DeleteAnalyticsInstanceResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"DeleteAnalyticsInstance failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Cancel a work request that has not started yet.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<DeleteWorkRequestResponse> DeleteWorkRequest(DeleteWorkRequestRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called deleteWorkRequest");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/workRequests/{workRequestId}".Trim('/')));
            HttpMethod method = new HttpMethod("Delete");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<DeleteWorkRequestResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"DeleteWorkRequest failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Info for a specific Analytics instance.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<GetAnalyticsInstanceResponse> GetAnalyticsInstance(GetAnalyticsInstanceRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called getAnalyticsInstance");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/analyticsInstances/{analyticsInstanceId}".Trim('/')));
            HttpMethod method = new HttpMethod("Get");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<GetAnalyticsInstanceResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"GetAnalyticsInstance failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Get the details of a work request.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<GetWorkRequestResponse> GetWorkRequest(GetWorkRequestRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called getWorkRequest");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/workRequests/{workRequestId}".Trim('/')));
            HttpMethod method = new HttpMethod("Get");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<GetWorkRequestResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"GetWorkRequest failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// List Analytics instances.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<ListAnalyticsInstancesResponse> ListAnalyticsInstances(ListAnalyticsInstancesRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listAnalyticsInstances");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/analyticsInstances".Trim('/')));
            HttpMethod method = new HttpMethod("Get");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<ListAnalyticsInstancesResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListAnalyticsInstances failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Get the errors of a work request.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<ListWorkRequestErrorsResponse> ListWorkRequestErrors(ListWorkRequestErrorsRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listWorkRequestErrors");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/workRequests/{workRequestId}/errors".Trim('/')));
            HttpMethod method = new HttpMethod("Get");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<ListWorkRequestErrorsResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListWorkRequestErrors failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Get the logs of a work request.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<ListWorkRequestLogsResponse> ListWorkRequestLogs(ListWorkRequestLogsRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listWorkRequestLogs");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/workRequests/{workRequestId}/logs".Trim('/')));
            HttpMethod method = new HttpMethod("Get");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<ListWorkRequestLogsResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListWorkRequestLogs failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// List all work requests in a compartment.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<ListWorkRequestsResponse> ListWorkRequests(ListWorkRequestsRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called listWorkRequests");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/workRequests".Trim('/')));
            HttpMethod method = new HttpMethod("Get");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<ListWorkRequestsResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ListWorkRequests failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Scale an Analytics instance up or down. The operation is long-running
        /// and creates a new WorkRequest.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<ScaleAnalyticsInstanceResponse> ScaleAnalyticsInstance(ScaleAnalyticsInstanceRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called scaleAnalyticsInstance");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/analyticsInstances/{analyticsInstanceId}/actions/scale".Trim('/')));
            HttpMethod method = new HttpMethod("Post");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<ScaleAnalyticsInstanceResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"ScaleAnalyticsInstance failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Starts the specified Analytics instance. The operation is long-running
        /// and creates a new WorkRequest.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<StartAnalyticsInstanceResponse> StartAnalyticsInstance(StartAnalyticsInstanceRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called startAnalyticsInstance");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/analyticsInstances/{analyticsInstanceId}/actions/start".Trim('/')));
            HttpMethod method = new HttpMethod("Post");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<StartAnalyticsInstanceResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"StartAnalyticsInstance failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Stop the specified Analytics instance. The operation is long-running
        /// and creates a new WorkRequest.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<StopAnalyticsInstanceResponse> StopAnalyticsInstance(StopAnalyticsInstanceRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called stopAnalyticsInstance");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/analyticsInstances/{analyticsInstanceId}/actions/stop".Trim('/')));
            HttpMethod method = new HttpMethod("Post");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<StopAnalyticsInstanceResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"StopAnalyticsInstance failed with error: {e.Message}");
                throw;
            }
        }

        /// <summary>
        /// Updates certain fields of an Analytics instance. Fields that are not provided in the
        /// request will not be updated.
        ///
        /// </summary>
        /// <param name="request">The request object containing the details to send. Required.</param>
        /// <param name="retryConfiguration">The retry configuration that will be used by to send this request. Optional.</param>
        /// <param name="cancellationToken">The cancellation token to cancel this operation. Optional.</param>
        /// <returns>A response object containing details about the completed operation</returns>
        public async Task<UpdateAnalyticsInstanceResponse> UpdateAnalyticsInstance(UpdateAnalyticsInstanceRequest request, RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            logger.Trace("Called updateAnalyticsInstance");
            Uri uri = new Uri(this.restClient.GetEndpoint(), System.IO.Path.Combine(basePathWithoutHost, "/analyticsInstances/{analyticsInstanceId}".Trim('/')));
            HttpMethod method = new HttpMethod("Put");
            HttpRequestMessage requestMessage = Converter.ToHttpRequestMessage(uri, method, request);
            requestMessage.Headers.Add("Accept", "application/json");
            GenericRetrier retryingClient = Retrier.GetPreferredRetrier(retryConfiguration, this.retryConfiguration);
            HttpResponseMessage responseMessage;

            try
            {
                if (retryingClient != null)
                {
                    responseMessage = await retryingClient.MakeRetryingCall(this.restClient.HttpSend, requestMessage, cancellationToken);
                }
                else
                {
                    responseMessage = await this.restClient.HttpSend(requestMessage);
                }

                return Converter.FromHttpResponseMessage<UpdateAnalyticsInstanceResponse>(responseMessage);
            }
            catch (Exception e)
            {
                logger.Error($"UpdateAnalyticsInstance failed with error: {e.Message}");
                throw;
            }
        }

    }
}
