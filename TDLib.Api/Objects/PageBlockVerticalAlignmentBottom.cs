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
        /// The content should be bottom-aligned
        /// </summary>
        public partial class PageBlockVerticalAlignment : Object
        {
            /// <summary>
            /// The content should be bottom-aligned
            /// </summary>
            public class PageBlockVerticalAlignmentBottom : PageBlockVerticalAlignment
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "pageBlockVerticalAlignmentBottom";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}