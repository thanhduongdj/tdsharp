using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class LabeledPricePart : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "labeledPricePart";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("amount")]
            public long Amount { get; set; }
        }
    }
}