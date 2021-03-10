using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GetImportedContactCount : Function<Count>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "getImportedContactCount";

            [JsonProperty("@extra")] public override string Extra { get; set; }
        }
    }
}