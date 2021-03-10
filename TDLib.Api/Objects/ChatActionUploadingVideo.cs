using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ChatAction : Object
        {
            public class ChatActionUploadingVideo : ChatAction
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "chatActionUploadingVideo";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("progress")]
                public int Progress { get; set; }
            }
        }
    }
}