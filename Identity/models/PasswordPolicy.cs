/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.IdentityService.Models
{
    /// <summary>
    /// Password policy, currently set for the given compartment.
    /// 
    /// </summary>
    public class PasswordPolicy 
    {
        
        /// <value>
        /// Minimum password length required.
        /// </value>
        [JsonProperty(PropertyName = "minimumPasswordLength")]
        public System.Nullable<int> MinimumPasswordLength { get; set; }

        /// <value>
        /// At least one uppercase character required.
        /// </value>
        [JsonProperty(PropertyName = "isUppercaseCharactersRequired")]
        public System.Nullable<bool> IsUppercaseCharactersRequired { get; set; }

        /// <value>
        /// At least one lower case character required.
        /// </value>
        [JsonProperty(PropertyName = "isLowercaseCharactersRequired")]
        public System.Nullable<bool> IsLowercaseCharactersRequired { get; set; }

        /// <value>
        /// At least one numeric character required.
        /// </value>
        [JsonProperty(PropertyName = "isNumericCharactersRequired")]
        public System.Nullable<bool> IsNumericCharactersRequired { get; set; }

        /// <value>
        /// At least one special character required.
        /// </value>
        [JsonProperty(PropertyName = "isSpecialCharactersRequired")]
        public System.Nullable<bool> IsSpecialCharactersRequired { get; set; }

        /// <value>
        /// User name is allowed to be part of the password.
        /// </value>
        [JsonProperty(PropertyName = "isUsernameContainmentAllowed")]
        public System.Nullable<bool> IsUsernameContainmentAllowed { get; set; }
    }
}
