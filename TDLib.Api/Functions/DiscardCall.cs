using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Discards a call 
        /// </summary>
        public class DiscardCall : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "discardCall";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Call identifier 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("call_id")]
            public int CallId { get; set; }

            /// <summary>
            /// True, if the user was disconnected 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_disconnected")]
            public bool IsDisconnected { get; set; }

            /// <summary>
            /// The call duration, in seconds 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("duration")]
            public int Duration { get; set; }

            /// <summary>
            /// Identifier of the connection used during the call
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("connection_id")]
            public Int64 ConnectionId { get; set; }
        }


        /// <summary>
        /// Discards a call 
        /// </summary>
        public static Task<Ok> DiscardCallAsync(this Client client,
            int callId = default(int),
            bool isDisconnected = default(bool),
            int duration = default(int),
            Int64 connectionId = default(Int64))
        {
            return client.ExecuteAsync(new DiscardCall
            {
                CallId = callId,
                IsDisconnected = isDisconnected,
                Duration = duration,
                ConnectionId = connectionId,
            });
        }
    }
}