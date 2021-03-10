using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class PassportElement : Object
        {
            public class PassportElementPassport : PassportElement
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "passportElementPassport";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("passport")]
                public IdentityDocument Passport { get; set; }
            }
        }
    }
}