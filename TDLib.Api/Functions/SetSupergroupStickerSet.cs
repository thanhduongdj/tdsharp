using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class SetSupergroupStickerSet : Function<Ok>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "setSupergroupStickerSet";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("supergroup_id")]
            public int SupergroupId { get; set; }

            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("sticker_set_id")]
            public Int64 StickerSetId { get; set; }
        }
    }
}