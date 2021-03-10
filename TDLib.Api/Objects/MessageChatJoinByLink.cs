using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class MessageContent : Object
        {
            public class MessageChatJoinByLink : MessageContent
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "messageChatJoinByLink";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}