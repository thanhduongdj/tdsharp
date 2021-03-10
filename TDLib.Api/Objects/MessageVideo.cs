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
        /// A video message 
        /// </summary>
        public partial class MessageContent : Object
        {
            /// <summary>
            /// A video message 
            /// </summary>
            public class MessageVideo : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageVideo";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Message content 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("video")]
                public Video Video { get; set; }

                /// <summary>
                /// Video caption 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public FormattedText Caption { get; set; }

                /// <summary>
                /// True, if the video thumbnail must be blurred and the video must be shown only while tapped
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_secret")]
                public bool IsSecret { get; set; }
            }
        }
    }
}