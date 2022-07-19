/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.FusionappsService.Models;
using Oci.FusionappsService.Requests;
using Oci.FusionappsService.Responses;

namespace Oci.FusionappsService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of FusionEnvironmentFamily.
    /// </summary>
    public class FusionEnvironmentFamilyWaiters
    {
        private readonly FusionEnvironmentFamilyClient client;

        public  FusionEnvironmentFamilyWaiters(FusionEnvironmentFamilyClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetFusionEnvironmentFamilyRequest, GetFusionEnvironmentFamilyResponse> ForFusionEnvironmentFamily(GetFusionEnvironmentFamilyRequest request, params FusionEnvironmentFamily.LifecycleStateEnum[] targetStates)
        {
            return this.ForFusionEnvironmentFamily(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetFusionEnvironmentFamilyRequest, GetFusionEnvironmentFamilyResponse> ForFusionEnvironmentFamily(GetFusionEnvironmentFamilyRequest request, WaiterConfiguration config, params FusionEnvironmentFamily.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetFusionEnvironmentFamilyRequest, GetFusionEnvironmentFamilyResponse>(
                request,
                request => client.GetFusionEnvironmentFamily(request),
                response => targetStates.Contains(response.FusionEnvironmentFamily.LifecycleState.Value),
                targetStates.Contains(FusionEnvironmentFamily.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetFusionEnvironmentFamilyRequest, GetFusionEnvironmentFamilyResponse>(config, agent);
        }
    }
}