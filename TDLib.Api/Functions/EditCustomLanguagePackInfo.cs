using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class EditCustomLanguagePackInfo : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "editCustomLanguagePackInfo";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("info")]
            public LanguagePackInfo Info { get; set; }
        }
    }
}