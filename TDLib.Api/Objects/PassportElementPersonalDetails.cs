using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public partial class TdApi
    {
        /// <summary>
        /// A Telegram Passport element containing the user's personal details 
        /// </summary>
        public partial class PassportElement : Object
        {
            /// <summary>
            /// A Telegram Passport element containing the user's personal details 
            /// </summary>
            public class PassportElementPersonalDetails : PassportElement
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "passportElementPersonalDetails";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Personal details of the user
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("personal_details")]
                public PersonalDetails PersonalDetails { get; set; }
            }
        }
    }
}