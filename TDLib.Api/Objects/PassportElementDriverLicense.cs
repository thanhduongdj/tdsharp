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
            public class PassportElementDriverLicense : PassportElement
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "passportElementDriverLicense";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("driver_license")]
                public IdentityDocument DriverLicense { get; set; }
            }
        }
    }
}