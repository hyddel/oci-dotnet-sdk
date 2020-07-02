/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.DnsService.Models;
using Oci.DnsService.Requests;
using Oci.DnsService.Responses;

namespace Oci.DnsService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of Dns.
    /// </summary>
    public class DnsWaiters
    {
        private readonly DnsClient client;

        public  DnsWaiters(DnsClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSteeringPolicyRequest, GetSteeringPolicyResponse> ForSteeringPolicy(GetSteeringPolicyRequest request, params SteeringPolicy.LifecycleStateEnum[] targetStates)
        {
            return this.ForSteeringPolicy(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSteeringPolicyRequest, GetSteeringPolicyResponse> ForSteeringPolicy(GetSteeringPolicyRequest request, WaiterConfiguration config, params SteeringPolicy.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetSteeringPolicyRequest, GetSteeringPolicyResponse>(
                request,
                request => client.GetSteeringPolicy(request),
                response => targetStates.Contains(response.SteeringPolicy.LifecycleState.Value),
                targetStates.Contains(SteeringPolicy.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetSteeringPolicyRequest, GetSteeringPolicyResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSteeringPolicyAttachmentRequest, GetSteeringPolicyAttachmentResponse> ForSteeringPolicyAttachment(GetSteeringPolicyAttachmentRequest request, params SteeringPolicyAttachment.LifecycleStateEnum[] targetStates)
        {
            return this.ForSteeringPolicyAttachment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetSteeringPolicyAttachmentRequest, GetSteeringPolicyAttachmentResponse> ForSteeringPolicyAttachment(GetSteeringPolicyAttachmentRequest request, WaiterConfiguration config, params SteeringPolicyAttachment.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetSteeringPolicyAttachmentRequest, GetSteeringPolicyAttachmentResponse>(
                request,
                request => client.GetSteeringPolicyAttachment(request),
                response => targetStates.Contains(response.SteeringPolicyAttachment.LifecycleState.Value)
            );
            return new Waiter<GetSteeringPolicyAttachmentRequest, GetSteeringPolicyAttachmentResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTsigKeyRequest, GetTsigKeyResponse> ForTsigKey(GetTsigKeyRequest request, params TsigKey.LifecycleStateEnum[] targetStates)
        {
            return this.ForTsigKey(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTsigKeyRequest, GetTsigKeyResponse> ForTsigKey(GetTsigKeyRequest request, WaiterConfiguration config, params TsigKey.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetTsigKeyRequest, GetTsigKeyResponse>(
                request,
                request => client.GetTsigKey(request),
                response => targetStates.Contains(response.TsigKey.LifecycleState.Value)
            );
            return new Waiter<GetTsigKeyRequest, GetTsigKeyResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetZoneRequest, GetZoneResponse> ForZone(GetZoneRequest request, params Zone.LifecycleStateEnum[] targetStates)
        {
            return this.ForZone(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetZoneRequest, GetZoneResponse> ForZone(GetZoneRequest request, WaiterConfiguration config, params Zone.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetZoneRequest, GetZoneResponse>(
                request,
                request => client.GetZone(request),
                response => targetStates.Contains(response.Zone.LifecycleState.Value),
                targetStates.Contains(Zone.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetZoneRequest, GetZoneResponse>(config, agent);
        }
    }
}
