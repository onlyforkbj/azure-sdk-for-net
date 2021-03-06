// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for HealthErrorCategory.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HealthErrorCategory
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Replication")]
        Replication,
        [EnumMember(Value = "TestFailover")]
        TestFailover,
        [EnumMember(Value = "Configuration")]
        Configuration,
        [EnumMember(Value = "FabricInfrastructure")]
        FabricInfrastructure,
        [EnumMember(Value = "VersionExpiry")]
        VersionExpiry
    }
    internal static class HealthErrorCategoryEnumExtension
    {
        internal static string ToSerializedValue(this HealthErrorCategory? value)
        {
            return value == null ? null : ((HealthErrorCategory)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this HealthErrorCategory value)
        {
            switch( value )
            {
                case HealthErrorCategory.None:
                    return "None";
                case HealthErrorCategory.Replication:
                    return "Replication";
                case HealthErrorCategory.TestFailover:
                    return "TestFailover";
                case HealthErrorCategory.Configuration:
                    return "Configuration";
                case HealthErrorCategory.FabricInfrastructure:
                    return "FabricInfrastructure";
                case HealthErrorCategory.VersionExpiry:
                    return "VersionExpiry";
            }
            return null;
        }

        internal static HealthErrorCategory? ParseHealthErrorCategory(this string value)
        {
            switch( value )
            {
                case "None":
                    return HealthErrorCategory.None;
                case "Replication":
                    return HealthErrorCategory.Replication;
                case "TestFailover":
                    return HealthErrorCategory.TestFailover;
                case "Configuration":
                    return HealthErrorCategory.Configuration;
                case "FabricInfrastructure":
                    return HealthErrorCategory.FabricInfrastructure;
                case "VersionExpiry":
                    return HealthErrorCategory.VersionExpiry;
            }
            return null;
        }
    }
}
