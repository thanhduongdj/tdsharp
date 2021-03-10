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
        /// Represents a video 
        /// </summary>
        public partial class InlineQueryResult : Object
        {
            /// <summary>
            /// Represents a video 
            /// </summary>
            public class InlineQueryResultVideo : InlineQueryResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inlineQueryResultVideo";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Unique identifier of the query result 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }

                /// <summary>
                /// Video 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("video")]
                public Video Video { get; set; }

                /// <summary>
                /// Title of the video 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                /// <summary>
                /// Represents a video 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("description")]
                public string Description { get; set; }
            }
        }
    }
}