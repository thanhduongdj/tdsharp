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
        /// Text that must be formatted as if inside a code HTML tag
        /// </summary>
        public partial class TextEntityType : Object
        {
            /// <summary>
            /// Text that must be formatted as if inside a code HTML tag
            /// </summary>
            public class TextEntityTypeCode : TextEntityType
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "textEntityTypeCode";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}