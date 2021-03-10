using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class TextParseMode : Object
        {
            public class TextParseModeHTML : TextParseMode
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "textParseModeHTML";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}