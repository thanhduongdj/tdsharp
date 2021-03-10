using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Checks the authentication token of a bot; to log in as a bot. Works only when the current authorization state is authorizationStateWaitPhoneNumber. Can be used instead of setAuthenticationPhoneNumber and checkAuthenticationCode to log in 
        /// </summary>
        public class CheckAuthenticationBotToken : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "checkAuthenticationBotToken";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The bot token
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("token")]
            public string Token { get; set; }
        }


        /// <summary>
        /// Checks the authentication token of a bot; to log in as a bot. Works only when the current authorization state is authorizationStateWaitPhoneNumber. Can be used instead of setAuthenticationPhoneNumber and checkAuthenticationCode to log in 
        /// </summary>
        public static Task<Ok> CheckAuthenticationBotTokenAsync(this Client client,
            string token = default(string))
        {
            return client.ExecuteAsync(new CheckAuthenticationBotToken
            {
                Token = token,
            });
        }
    }
}