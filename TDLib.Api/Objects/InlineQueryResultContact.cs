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
        /// Represents a user contact 
        /// </summary>
        public partial class InlineQueryResult : Object
        {
            /// <summary>
            /// Represents a user contact 
            /// </summary>
            public class InlineQueryResultContact : InlineQueryResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inlineQueryResultContact";

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
                /// A user contact 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("contact")]
                public Contact Contact { get; set; }

                /// <summary>
                /// Result thumbnail; may be null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail")]
                public PhotoSize Thumbnail { get; set; }
            }
        }
    }
}