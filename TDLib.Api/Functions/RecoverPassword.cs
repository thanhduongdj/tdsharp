using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class RecoverPassword : Function<PasswordState>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "recoverPassword";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("recovery_code")]
            public string RecoveryCode { get; set; }
        }
    }
}