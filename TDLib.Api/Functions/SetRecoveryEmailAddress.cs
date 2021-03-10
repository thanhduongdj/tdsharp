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
        /// Changes the 2-step verification recovery email address of the user. If a new recovery email address is specified, then the change will not be applied until the new recovery email address is confirmed.
        /// </summary>
        public class SetRecoveryEmailAddress : Function<PasswordState>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setRecoveryEmailAddress";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Password of the current user 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("password")]
            public string Password { get; set; }

            /// <summary>
            /// New recovery email address
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("new_recovery_email_address")]
            public string NewRecoveryEmailAddress { get; set; }
        }
    }
}