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
        /// Returns only call messages
        /// </summary>
        public partial class SearchMessagesFilter : Object
        {
            /// <summary>
            /// Returns only call messages
            /// </summary>
            public class SearchMessagesFilterCall : SearchMessagesFilter
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "searchMessagesFilterCall";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}