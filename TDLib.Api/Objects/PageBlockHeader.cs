using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class PageBlock : Object
        {
            public class PageBlockHeader : PageBlock
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "pageBlockHeader";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("header")]
                public RichText Header { get; set; }
            }
        }
    }
}