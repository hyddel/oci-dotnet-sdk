/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Collections.Generic;
using System.Threading;
using Oci.ServicemeshService.Requests;
using Oci.ServicemeshService.Responses;
using Oci.ServicemeshService.Models;

namespace Oci.ServicemeshService
{
    /// <summary>
    /// Collection of helper methods that can be used to provide an enumerator interface
    /// to any list operations of ServiceMesh where multiple pages of data may be fetched.
    /// Two styles of enumerators are supported:
    /// <list type="bullet">
    /// <item>
    /// <description>
    /// Enumerating over the Response objects returned by the list operation. These are referred to as ResponseEnumerators, and the methods are suffixed with ResponseEnumerator. For example: listUsersResponseEnumerator.
    /// </description>
    /// </item>
    /// <item>
    /// <description>
    /// Enumerating over the resources/records being listed. These are referred to as RecordEnumerators, and the methods are suffixed with RecordEnumerator. For example: listUsersRecordEnumerator.
    /// </description>
    /// </item>
    /// </list>
    /// These enumerators abstract away the need to write code to manually handle pagination via looping and using the page tokens.
    /// They will automatically fetch more data from the service when required.
    /// <br/>
    /// <br/>
    /// As an example, if we were using the ListUsers operation in IdentityService, then the iterator returned by calling a
    /// ResponseEnumerator method would iterate over the ListUsersResponse objects returned by each ListUsers call, whereas the enumerables
    /// returned by calling a RecordEnumerator method would iterate over the User records and we don't have to deal with ListUsersResponse objects at all.
    /// In either case, pagination will be automatically handled so we can iterate until there are no more responses or no more resources/records available.
    /// </summary>
    public class ServiceMeshPaginators
    {
        private readonly ServiceMeshClient client;

        public ServiceMeshPaginators(ServiceMeshClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListAccessPolicies operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListAccessPoliciesResponse> ListAccessPoliciesResponseEnumerator(ListAccessPoliciesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListAccessPoliciesRequest, ListAccessPoliciesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListAccessPolicies(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the AccessPolicySummary objects
        /// contained in responses from the ListAccessPolicies operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<AccessPolicySummary> ListAccessPoliciesRecordEnumerator(ListAccessPoliciesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListAccessPoliciesRequest, ListAccessPoliciesResponse, AccessPolicySummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListAccessPolicies(request, retryConfiguration, cancellationToken),
                response => response.AccessPolicyCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListIngressGatewayRouteTables operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListIngressGatewayRouteTablesResponse> ListIngressGatewayRouteTablesResponseEnumerator(ListIngressGatewayRouteTablesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListIngressGatewayRouteTablesRequest, ListIngressGatewayRouteTablesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListIngressGatewayRouteTables(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the IngressGatewayRouteTableSummary objects
        /// contained in responses from the ListIngressGatewayRouteTables operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<IngressGatewayRouteTableSummary> ListIngressGatewayRouteTablesRecordEnumerator(ListIngressGatewayRouteTablesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListIngressGatewayRouteTablesRequest, ListIngressGatewayRouteTablesResponse, IngressGatewayRouteTableSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListIngressGatewayRouteTables(request, retryConfiguration, cancellationToken),
                response => response.IngressGatewayRouteTableCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListIngressGateways operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListIngressGatewaysResponse> ListIngressGatewaysResponseEnumerator(ListIngressGatewaysRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListIngressGatewaysRequest, ListIngressGatewaysResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListIngressGateways(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the IngressGatewaySummary objects
        /// contained in responses from the ListIngressGateways operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<IngressGatewaySummary> ListIngressGatewaysRecordEnumerator(ListIngressGatewaysRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListIngressGatewaysRequest, ListIngressGatewaysResponse, IngressGatewaySummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListIngressGateways(request, retryConfiguration, cancellationToken),
                response => response.IngressGatewayCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListMeshes operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListMeshesResponse> ListMeshesResponseEnumerator(ListMeshesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListMeshesRequest, ListMeshesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListMeshes(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the MeshSummary objects
        /// contained in responses from the ListMeshes operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<MeshSummary> ListMeshesRecordEnumerator(ListMeshesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListMeshesRequest, ListMeshesResponse, MeshSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListMeshes(request, retryConfiguration, cancellationToken),
                response => response.MeshCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListVirtualDeployments operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListVirtualDeploymentsResponse> ListVirtualDeploymentsResponseEnumerator(ListVirtualDeploymentsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListVirtualDeploymentsRequest, ListVirtualDeploymentsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVirtualDeployments(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the VirtualDeploymentSummary objects
        /// contained in responses from the ListVirtualDeployments operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<VirtualDeploymentSummary> ListVirtualDeploymentsRecordEnumerator(ListVirtualDeploymentsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListVirtualDeploymentsRequest, ListVirtualDeploymentsResponse, VirtualDeploymentSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVirtualDeployments(request, retryConfiguration, cancellationToken),
                response => response.VirtualDeploymentCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListVirtualServiceRouteTables operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListVirtualServiceRouteTablesResponse> ListVirtualServiceRouteTablesResponseEnumerator(ListVirtualServiceRouteTablesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListVirtualServiceRouteTablesRequest, ListVirtualServiceRouteTablesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVirtualServiceRouteTables(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the VirtualServiceRouteTableSummary objects
        /// contained in responses from the ListVirtualServiceRouteTables operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<VirtualServiceRouteTableSummary> ListVirtualServiceRouteTablesRecordEnumerator(ListVirtualServiceRouteTablesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListVirtualServiceRouteTablesRequest, ListVirtualServiceRouteTablesResponse, VirtualServiceRouteTableSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVirtualServiceRouteTables(request, retryConfiguration, cancellationToken),
                response => response.VirtualServiceRouteTableCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListVirtualServices operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListVirtualServicesResponse> ListVirtualServicesResponseEnumerator(ListVirtualServicesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListVirtualServicesRequest, ListVirtualServicesResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVirtualServices(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the VirtualServiceSummary objects
        /// contained in responses from the ListVirtualServices operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<VirtualServiceSummary> ListVirtualServicesRecordEnumerator(ListVirtualServicesRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListVirtualServicesRequest, ListVirtualServicesResponse, VirtualServiceSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListVirtualServices(request, retryConfiguration, cancellationToken),
                response => response.VirtualServiceCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListWorkRequestErrors operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListWorkRequestErrorsResponse> ListWorkRequestErrorsResponseEnumerator(ListWorkRequestErrorsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListWorkRequestErrorsRequest, ListWorkRequestErrorsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListWorkRequestErrors(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the WorkRequestError objects
        /// contained in responses from the ListWorkRequestErrors operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<WorkRequestError> ListWorkRequestErrorsRecordEnumerator(ListWorkRequestErrorsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListWorkRequestErrorsRequest, ListWorkRequestErrorsResponse, WorkRequestError>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListWorkRequestErrors(request, retryConfiguration, cancellationToken),
                response => response.WorkRequestErrorCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListWorkRequestLogs operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListWorkRequestLogsResponse> ListWorkRequestLogsResponseEnumerator(ListWorkRequestLogsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListWorkRequestLogsRequest, ListWorkRequestLogsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListWorkRequestLogs(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the WorkRequestLogEntry objects
        /// contained in responses from the ListWorkRequestLogs operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<WorkRequestLogEntry> ListWorkRequestLogsRecordEnumerator(ListWorkRequestLogsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListWorkRequestLogsRequest, ListWorkRequestLogsResponse, WorkRequestLogEntry>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListWorkRequestLogs(request, retryConfiguration, cancellationToken),
                response => response.WorkRequestLogEntryCollection.Items
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the responses received from the ListWorkRequests operation. This enumerable
        /// will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<ListWorkRequestsResponse> ListWorkRequestsResponseEnumerator(ListWorkRequestsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseEnumerable<ListWorkRequestsRequest, ListWorkRequestsResponse>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListWorkRequests(request, retryConfiguration, cancellationToken)
            );
        }

        /// <summary>
        /// Creates a new enumerable which will iterate over the WorkRequestSummary objects
        /// contained in responses from the ListWorkRequests operation. This enumerable will fetch more data from the server as needed.
        /// </summary>
        /// <param name="request">The request object containing the details to send</param>
        /// <param name="retryConfiguration">The configuration for retrying, may be null</param>
        /// <param name="cancellationToken">The cancellation token object</param>
        /// <returns>The enumerator, which supports a simple iteration over a collection of a specified type</returns>
        public IEnumerable<WorkRequestSummary> ListWorkRequestsRecordEnumerator(ListWorkRequestsRequest request, Common.Retry.RetryConfiguration retryConfiguration = null, CancellationToken cancellationToken = default)
        {
            return new Common.Utils.ResponseRecordEnumerable<ListWorkRequestsRequest, ListWorkRequestsResponse, WorkRequestSummary>(
                response => response.OpcNextPage,
                input =>
                {
                    if (!string.IsNullOrEmpty(input))
                    {
                        request.Page = input;
                    }
                    return request;
                },
                request => client.ListWorkRequests(request, retryConfiguration, cancellationToken),
                response => response.WorkRequestCollection.Items
            );
        }

    }
}