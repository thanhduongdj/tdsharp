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
        /// A mask should be placed relatively to the chin
        /// </summary>
        public partial class MaskPoint : Object
        {
            /// <summary>
            /// A mask should be placed relatively to the chin
            /// </summary>
            public class MaskPointChin : MaskPoint
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "maskPointChin";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}