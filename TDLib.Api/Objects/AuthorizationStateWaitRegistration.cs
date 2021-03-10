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
        /// The user is unregistered and need to accept terms of service and enter their first name and last name to finish registration 
        /// </summary>
        public partial class AuthorizationState : Object
        {
            /// <summary>
            /// The user is unregistered and need to accept terms of service and enter their first name and last name to finish registration 
            /// </summary>
            public class AuthorizationStateWaitRegistration : AuthorizationState
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "authorizationStateWaitRegistration";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Telegram terms of service
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("terms_of_service")]
                public TermsOfService TermsOfService { get; set; }
            }
        }
    }
}