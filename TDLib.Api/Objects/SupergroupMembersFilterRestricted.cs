using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public partial class TdApi
    {
        /// <summary>
        /// Returns restricted supergroup members; can be used only by administrators 
        /// </summary>
        public partial class SupergroupMembersFilter : Object
        {
            /// <summary>
            /// Returns restricted supergroup members; can be used only by administrators 
            /// </summary>
            public class SupergroupMembersFilterRestricted : SupergroupMembersFilter
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "supergroupMembersFilterRestricted";

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