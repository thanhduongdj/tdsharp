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
        /// Contains information about the total amount of data that was used for calls 
        /// </summary>
        public partial class NetworkStatisticsEntry : Object
        {
            /// <summary>
            /// Contains information about the total amount of data that was used for calls 
            /// </summary>
            public class NetworkStatisticsEntryCall : NetworkStatisticsEntry
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "networkStatisticsEntryCall";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Type of the network the data was sent through. Call setNetworkType to maintain the actual network type
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("network_type")]
                public NetworkType NetworkType { get; set; }

                /// <summary>
                /// Total number of bytes sent 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("sent_bytes")]
                public long SentBytes { get; set; }

                /// <summary>
                /// Total number of bytes received 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("received_bytes")]
                public long ReceivedBytes { get; set; }

                /// <summary>
                /// Total call duration, in seconds
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("duration")]
                public double? Duration { get; set; }
            }
        }
    }
}