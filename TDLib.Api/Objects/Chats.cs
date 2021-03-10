using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class Chats : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "chats";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_ids")]
            public long[] ChatIds { get; set; }
        }
    }
}