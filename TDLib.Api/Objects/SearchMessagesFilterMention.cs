using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class SearchMessagesFilter : Object
        {
            public class SearchMessagesFilterMention : SearchMessagesFilter
            {
                [JsonProperty("@type")] public override string DataType { get; set; } = "searchMessagesFilterMention";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}