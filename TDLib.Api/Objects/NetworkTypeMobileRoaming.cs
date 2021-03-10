using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class NetworkType : Object
        {
            public class NetworkTypeMobileRoaming : NetworkType
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "networkTypeMobileRoaming";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}