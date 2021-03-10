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
        /// Changes notification settings for chats of a given type 
        /// </summary>
        public class SetScopeNotificationSettings : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setScopeNotificationSettings";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Types of chats for which to change the notification settings 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("scope")]
            public NotificationSettingsScope Scope { get; set; }

            /// <summary>
            /// The new notification settings for the given scope
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("notification_settings")]
            public ScopeNotificationSettings NotificationSettings { get; set; }
        }
    }
}