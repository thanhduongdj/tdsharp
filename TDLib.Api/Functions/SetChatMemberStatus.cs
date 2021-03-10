using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Changes the status of a chat member, needs appropriate privileges. This function is currently not suitable for adding new members to the chat and transferring chat ownership; instead, use addChatMember or transferChatOwnership. The chat member status will not be changed until it has been synchronized with the server
        /// </summary>
        public class SetChatMemberStatus : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setChatMemberStatus";

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
            /// User identifier 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            /// <summary>
            /// The new status of the member in the chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("status")]
            public ChatMemberStatus Status { get; set; }
        }


        /// <summary>
        /// Changes the status of a chat member, needs appropriate privileges. This function is currently not suitable for adding new members to the chat and transferring chat ownership; instead, use addChatMember or transferChatOwnership. The chat member status will not be changed until it has been synchronized with the server
        /// </summary>
        public static Task<Ok> SetChatMemberStatusAsync(this Client client,
            long chatId = default(long),
            int userId = default(int),
            ChatMemberStatus status = default(ChatMemberStatus))
        {
            return client.ExecuteAsync(new SetChatMemberStatus
            {
                ChatId = chatId,
                UserId = userId,
                Status = status,
            });
        }
    }
}