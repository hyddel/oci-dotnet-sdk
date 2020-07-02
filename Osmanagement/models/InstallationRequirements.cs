/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.OsmanagementService.Models
{
  /// <summary>
  /// A reason why an update may not be installable.
  /// </summary>
  public enum InstallationRequirements {
      [EnumMember(Value = "EULA_ACCEPTANCE_REQUIRED")]
      EulaAcceptanceRequired,
      [EnumMember(Value = "SOFTWARE_MEDIA_REQUIRED")]
      SoftwareMediaRequired,
      [EnumMember(Value = "USER_INTERACTION_REQUIRED")]
      UserInteractionRequired
  }
}
