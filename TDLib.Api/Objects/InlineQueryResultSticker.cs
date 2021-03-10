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
        /// Represents a sticker 
        /// </summary>
        public partial class InlineQueryResult : Object
        {
            /// <summary>
            /// Represents a sticker 
            /// </summary>
            public class InlineQueryResultSticker : InlineQueryResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inlineQueryResultSticker";

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
                /// Sticker
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker")]
                public Sticker Sticker { get; set; }
            }
        }
    }
}