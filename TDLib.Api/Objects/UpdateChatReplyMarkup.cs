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
        /// The default chat reply markup was changed. Can occur because new messages with reply markup were received or because an old reply markup was hidden by the user
        /// </summary>
        public partial class Update : Object
        {
            /// <summary>
            /// The default chat reply markup was changed. Can occur because new messages with reply markup were received or because an old reply markup was hidden by the user
            /// </summary>
            public class UpdateChatReplyMarkup : Update
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "updateChatReplyMarkup";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Chat identifier 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long ChatId { get; set; }

                /// <summary>
                /// Identifier of the message from which reply markup needs to be used; 0 if there is no default custom reply markup in the chat
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("reply_markup_message_id")]
                public long ReplyMarkupMessageId { get; set; }
            }
        }
    }
}