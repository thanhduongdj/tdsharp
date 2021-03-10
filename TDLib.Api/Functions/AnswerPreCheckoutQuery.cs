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
        /// Sets the result of a pre-checkout query; for bots only 
        /// </summary>
        public class AnswerPreCheckoutQuery : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "answerPreCheckoutQuery";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the pre-checkout query 
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("pre_checkout_query_id")]
            public Int64 PreCheckoutQueryId { get; set; }

            /// <summary>
            /// An error message, empty on success
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("error_message")]
            public string ErrorMessage { get; set; }
        }
    }
}