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
        /// Contains full information about a supergroup or channel
        /// </summary>
        public class SupergroupFullInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "supergroupFullInfo";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Contains full information about a supergroup or channel
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("description")]
            public string Description { get; set; }

            /// <summary>
            /// Number of members in the supergroup or channel; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_count")]
            public int MemberCount { get; set; }

            /// <summary>
            /// Number of privileged users in the supergroup or channel; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("administrator_count")]
            public int AdministratorCount { get; set; }

            /// <summary>
            /// Number of restricted users in the supergroup; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("restricted_count")]
            public int RestrictedCount { get; set; }

            /// <summary>
            /// Number of users banned from chat; 0 if unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("banned_count")]
            public int BannedCount { get; set; }

            /// <summary>
            /// Chat identifier of a discussion group for the channel, or a channel, for which the supergroup is the designated discussion group; 0 if none or unknown
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("linked_chat_id")]
            public long LinkedChatId { get; set; }

            /// <summary>
            /// Delay between consecutive sent messages for non-administrator supergroup members, in seconds
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("slow_mode_delay")]
            public int SlowModeDelay { get; set; }

            /// <summary>
            /// Time left before next message can be sent in the supergroup, in seconds. An updateSupergroupFullInfo update is not triggered when value of this field changes, but both new and old values are non-zero
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("slow_mode_delay_expires_in")]
            public double? SlowModeDelayExpiresIn { get; set; }

            /// <summary>
            /// True, if members of the chat can be retrieved
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_get_members")]
            public bool CanGetMembers { get; set; }

            /// <summary>
            /// True, if the chat username can be changed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_set_username")]
            public bool CanSetUsername { get; set; }

            /// <summary>
            /// True, if the supergroup sticker set can be changed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_set_sticker_set")]
            public bool CanSetStickerSet { get; set; }

            /// <summary>
            /// True, if the supergroup location can be changed
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_set_location")]
            public bool CanSetLocation { get; set; }

            /// <summary>
            /// True, if the channel statistics is available through getChatStatisticsUrl
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("can_view_statistics")]
            public bool CanViewStatistics { get; set; }

            /// <summary>
            /// True, if new chat members will have access to old messages. In public or discussion groups and both public and private channels, old messages are always available, so this option affects only private supergroups without a linked chat. The value of this field is only available for chat administrators
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_all_history_available")]
            public bool IsAllHistoryAvailable { get; set; }

            /// <summary>
            /// Identifier of the supergroup sticker set; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("sticker_set_id")]
            public Int64 StickerSetId { get; set; }

            /// <summary>
            /// Location to which the supergroup is connected; may be null
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("location")]
            public ChatLocation Location { get; set; }

            /// <summary>
            /// Invite link for this chat
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("invite_link")]
            public string InviteLink { get; set; }

            /// <summary>
            /// Identifier of the basic group from which supergroup was upgraded; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("upgraded_from_basic_group_id")]
            public int UpgradedFromBasicGroupId { get; set; }

            /// <summary>
            /// Identifier of the last message in the basic group from which supergroup was upgraded; 0 if none
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("upgraded_from_max_message_id")]
            public long UpgradedFromMaxMessageId { get; set; }
        }
    }
}