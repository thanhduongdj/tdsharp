using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class PassportElementErrorSource : Object
        {
            public class PassportElementErrorSourceReverseSide : PassportElementErrorSource
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "passportElementErrorSourceReverseSide";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}