using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class DownloadFile : Function<File>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "downloadFile";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("file_id")]
            public int FileId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("priority")]
            public int Priority { get; set; }
        }
    }
}