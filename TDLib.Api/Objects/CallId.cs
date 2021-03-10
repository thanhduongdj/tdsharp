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
        /// Contains the call identifier 
        /// </summary>
        public class CallId : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "callId";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Call identifier
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }
        }
    }
}