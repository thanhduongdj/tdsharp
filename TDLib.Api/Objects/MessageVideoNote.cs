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
        /// A video note message 
        /// </summary>
        public partial class MessageContent : Object
        {
            /// <summary>
            /// A video note message 
            /// </summary>
            public class MessageVideoNote : MessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "messageVideoNote";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// The video note description 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("video_note")]
                public VideoNote VideoNote { get; set; }

                /// <summary>
                /// True, if at least one of the recipients has viewed the video note 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_viewed")]
                public bool IsViewed { get; set; }

                /// <summary>
                /// True, if the video note thumbnail must be blurred and the video note must be shown only while tapped
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_secret")]
                public bool IsSecret { get; set; }
            }
        }
    }
}