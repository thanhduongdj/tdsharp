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
        /// A text shows instead of a raw mention of the user (e.g., when the user has no username) 
        /// </summary>
        public partial class TextEntityType : Object
        {
            /// <summary>
            /// A text shows instead of a raw mention of the user (e.g., when the user has no username) 
            /// </summary>
            public class TextEntityTypeMentionName : TextEntityType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "textEntityTypeMentionName";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Identifier of the mentioned user
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int UserId { get; set; }
            }
        }
    }
}