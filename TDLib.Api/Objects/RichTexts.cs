using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class RichText : Object
        {
            public class RichTexts : RichText
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "richTexts";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("texts")]
                public RichText[] Texts { get; set; }
            }
        }
    }
}