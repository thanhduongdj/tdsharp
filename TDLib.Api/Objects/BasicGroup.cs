using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class BasicGroup : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "basicGroup";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("member_count")]
            public int MemberCount { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("status")]
            public ChatMemberStatus Status { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("everyone_is_administrator")]
            public bool EveryoneIsAdministrator { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_active")]
            public bool IsActive { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("upgraded_to_supergroup_id")]
            public int UpgradedToSupergroupId { get; set; }
        }
    }
}