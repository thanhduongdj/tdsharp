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
        /// An authentication code is delivered by an immediately cancelled call to the specified phone number. The number from which the call was made is the code 
        /// </summary>
        public partial class AuthenticationCodeType : Object
        {
            /// <summary>
            /// An authentication code is delivered by an immediately cancelled call to the specified phone number. The number from which the call was made is the code 
            /// </summary>
            public class AuthenticationCodeTypeFlashCall : AuthenticationCodeType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authenticationCodeTypeFlashCall";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Pattern of the phone number from which the call will be made
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("pattern")]
                public string Pattern { get; set; }
            }
        }
    }
}