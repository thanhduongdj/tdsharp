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
            public class InputPassportElementRentalAgreement : InputPassportElement
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputPassportElementRentalAgreement";

                [JsonProperty("@extra")] public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("rental_agreement")]
                public InputPersonalDocument RentalAgreement { get; set; }
            }
        }
    }
}