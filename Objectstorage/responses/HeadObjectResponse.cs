/*
 * Copyright (c) 2020, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.Runtime.Serialization;
using Oci.ObjectstorageService.Models;

namespace Oci.ObjectstorageService.Responses
{
    public class HeadObjectResponse : Oci.Common.IOciResponse
    {

        /// <value>
        /// Echoes back the value passed in the opc-client-request-id header, for use by clients when debugging.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-client-request-id")]
        public string OpcClientRequestId { get; set; }


        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular
        /// request, provide this request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }


        /// <value>
        /// The entity tag (ETag) for the object.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "ETag")]
        public string ETag { get; set; }


        /// <value>
        /// The user-defined metadata for the object.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-meta-")]
        public System.Collections.Generic.Dictionary<string, string> OpcMeta { get; set; }


        /// <value>
        /// The object size in bytes.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-length")]
        public System.Nullable<long> ContentLength { get; set; }


        /// <value>
        /// Content-MD5 header, as described in [RFC 2616](https://tools.ietf.org/html/rfc2616#section-14.15).
        /// Unavailable for objects uploaded using multipart upload.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-md5")]
        public string ContentMd5 { get; set; }


        /// <value>
        /// Only applicable to objects uploaded using multipart upload.
        /// Base-64 representation of the multipart object hash.
        /// The multipart object hash is calculated by taking the MD5 hashes of the parts,
        /// concatenating the binary representation of those hashes in order of their part numbers,
        /// and then calculating the MD5 hash of the concatenated values.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-multipart-md5")]
        public string OpcMultipartMd5 { get; set; }


        /// <value>
        /// Content-Type header, as described in [RFC 2616](https://tools.ietf.org/html/rfc2616#section-14.17).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-type")]
        public string ContentType { get; set; }


        /// <value>
        /// Content-Language header, as described in [RFC 2616](https://tools.ietf.org/html/rfc2616#section-14.12).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-language")]
        public string ContentLanguage { get; set; }


        /// <value>
        /// Content-Encoding header, as described in [RFC 2616](https://tools.ietf.org/html/rfc2616#section-14.11).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-encoding")]
        public string ContentEncoding { get; set; }


        /// <value>
        /// Cache-Control header, as described in [RFC 2616](https://tools.ietf.org/html/rfc2616#section-14.9).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "cache-control")]
        public string CacheControl { get; set; }


        /// <value>
        /// Content-Disposition header, as described in [RFC 2616](https://tools.ietf.org/html/rfc2616#section-19.5.1).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "content-disposition")]
        public string ContentDisposition { get; set; }


        /// <value>
        /// The object modification time, as described in [RFC 2616](https://tools.ietf.org/html/rfc2616#section-14.29).
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "last-modified")]
        public System.Nullable<System.DateTime> LastModified { get; set; }

        ///
        /// <value>
        /// The current state of the object.
        /// </value>
        ///
        public enum ArchivalStateEnum {
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "ARCHIVED")]
            Archived,
            [EnumMember(Value = "RESTORING")]
            Restoring,
            [EnumMember(Value = "RESTORED")]
            Restored
        };

        /// <value>
        /// The current state of the object.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "archival-state")]
        public System.Nullable<ArchivalStateEnum> ArchivalState { get; set; }


        /// <value>
        /// Time that the object is returned to the archived state. This field is only present for restored objects.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "time-of-archival")]
        public System.Nullable<System.DateTime> TimeOfArchival { get; set; }


        /// <value>
        /// VersionId of the object requested
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "version-id")]
        public string VersionId { get; set; }



        /// <value>
        /// Flag to indicate whether or not the object was modified.  If this is true,
        /// the getter for the object itself will return null.  Callers should check this
        /// if they specified one of the request params that might result in a conditional
        /// response (like 'if-match'/'if-none-match').
        /// </value>
        public bool IsNotModified { get; set; }
    }
}