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
            public class MessageUnsupported : MessageContent
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "messageUnsupported";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}