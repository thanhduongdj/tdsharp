using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class InputPassportElement : Object
        {
            public class InputPassportElementPersonalDetails : InputPassportElement
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementPersonalDetails";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("personal_details")]
                public PersonalDetails PersonalDetails { get; set; }
            }
        }
    }
}