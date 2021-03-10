using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// A button that sends the user's location when pressed; available only in private chats
        /// </summary>
        public partial class KeyboardButtonType : Object
        {
            /// <summary>
            /// A button that sends the user's location when pressed; available only in private chats
            /// </summary>
            public class KeyboardButtonTypeRequestLocation : KeyboardButtonType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "keyboardButtonTypeRequestLocation";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}