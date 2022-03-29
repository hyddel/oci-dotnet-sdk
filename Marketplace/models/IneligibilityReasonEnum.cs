/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.MarketplaceService.Models
{
  /// <summary>
  /// Possible values of on why a tenant cannot launch a listing
  /// </summary>
  public enum IneligibilityReasonEnum {
      [EnumMember(Value = "INELIGIBLE_ACCOUNT_COUNTRY")]
      IneligibleAccountCountry,
      [EnumMember(Value = "INELIGIBLE_REGION")]
      IneligibleRegion,
      [EnumMember(Value = "INELIGIBLE_ACCOUNT_BLACKLISTED")]
      IneligibleAccountBlacklisted,
      [EnumMember(Value = "INELIGIBLE_ACCOUNT_FEATURE_DISABLED")]
      IneligibleAccountFeatureDisabled,
      [EnumMember(Value = "INELIGIBLE_ACCOUNT_CURRENCY")]
      IneligibleAccountCurrency,
      [EnumMember(Value = "INELIGIBLE_ACCOUNT_NOT_PAID")]
      IneligibleAccountNotPaid,
      [EnumMember(Value = "INELIGIBLE_ACCOUNT_INTERNAL")]
      IneligibleAccountInternal,
      [EnumMember(Value = "INELIGIBLE_ACCOUNT_GOV_SUBSCRIPTION")]
      IneligibleAccountGovSubscription,
      [EnumMember(Value = "INELIGIBLE_PAID_LISTING_THROTTLED")]
      IneligiblePaidListingThrottled,
      [EnumMember(Value = "NOT_AUTHORIZED")]
      NotAuthorized
  }
}
