using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class UserPrivacySettingRule : Object
        {
            public class UserPrivacySettingRuleAllowContacts : UserPrivacySettingRule
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userPrivacySettingRuleAllowContacts";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}