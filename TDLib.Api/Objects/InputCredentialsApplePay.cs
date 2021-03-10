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
        /// Applies if a user enters new credentials using Apple Pay 
        /// </summary>
        public partial class InputCredentials : Object
        {
            /// <summary>
            /// Applies if a user enters new credentials using Apple Pay 
            /// </summary>
            public class InputCredentialsApplePay : InputCredentials
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputCredentialsApplePay";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// JSON-encoded data with the credential identifier
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("data")]
                public string Data { get; set; }
            }
        }
    }
}