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
        /// Contains information about a related article 
        /// </summary>
        public class PageBlockRelatedArticle : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "pageBlockRelatedArticle";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Related article URL 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// Article title; may be empty 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// Contains information about a related article 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("description")]
            public string Description { get; set; }

            /// <summary>
            /// Article photo; may be null 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("photo")]
            public Photo Photo { get; set; }

            /// <summary>
            /// Article author; may be empty 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("author")]
            public string Author { get; set; }

            /// <summary>
            /// Point in time (Unix timestamp) when the article was published; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("publish_date")]
            public int PublishDate { get; set; }
        }
    }
}