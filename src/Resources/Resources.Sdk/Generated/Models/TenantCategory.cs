// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Resources.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TenantCategory.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TenantCategory
    {
        [EnumMember(Value = "Home")]
        Home,
        [EnumMember(Value = "ProjectedBy")]
        ProjectedBy,
        [EnumMember(Value = "ManagedBy")]
        ManagedBy
    }
    internal static class TenantCategoryEnumExtension
    {
        internal static string ToSerializedValue(this TenantCategory? value)
        {
            return value == null ? null : ((TenantCategory)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TenantCategory value)
        {
            switch( value )
            {
                case TenantCategory.Home:
                    return "Home";
                case TenantCategory.ProjectedBy:
                    return "ProjectedBy";
                case TenantCategory.ManagedBy:
                    return "ManagedBy";
            }
            return null;
        }

        internal static TenantCategory? ParseTenantCategory(this string value)
        {
            switch( value )
            {
                case "Home":
                    return TenantCategory.Home;
                case "ProjectedBy":
                    return TenantCategory.ProjectedBy;
                case "ManagedBy":
                    return TenantCategory.ManagedBy;
            }
            return null;
        }
    }
}
