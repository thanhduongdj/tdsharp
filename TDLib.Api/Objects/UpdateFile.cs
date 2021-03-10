using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class Update : Object
        {
            public class UpdateFile : Update
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "updateFile";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("file")]
                public File File { get; set; }
            }
        }
    }
}