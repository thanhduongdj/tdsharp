using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class SecretChatState : Object
        {
            public class SecretChatStatePending : SecretChatState
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "secretChatStatePending";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}