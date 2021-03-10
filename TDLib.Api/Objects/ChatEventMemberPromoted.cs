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
        /// A chat member has gained/lost administrator status, or the list of their administrator privileges has changed 
        /// </summary>
        public partial class ChatEventAction : Object
        {
            /// <summary>
            /// A chat member has gained/lost administrator status, or the list of their administrator privileges has changed 
            /// </summary>
            public class ChatEventMemberPromoted : ChatEventAction
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventMemberPromoted";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Chat member user identifier 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int UserId { get; set; }

                /// <summary>
                /// Previous status of the chat member 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_status")]
                public ChatMemberStatus OldStatus { get; set; }

                /// <summary>
                /// New status of the chat member
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_status")]
                public ChatMemberStatus NewStatus { get; set; }
            }
        }
    }
}