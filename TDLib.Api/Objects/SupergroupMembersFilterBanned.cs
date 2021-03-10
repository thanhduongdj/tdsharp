using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Returns users banned from the supergroup or channel; can be used only by administrators 
        /// </summary>
        public partial class SupergroupMembersFilter : Object
        {
            /// <summary>
            /// Returns users banned from the supergroup or channel; can be used only by administrators 
            /// </summary>
            public class SupergroupMembersFilterBanned : SupergroupMembersFilter
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "supergroupMembersFilterBanned";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Query to search for
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("query")]
                public string Query { get; set; }
            }
        }
    }
}