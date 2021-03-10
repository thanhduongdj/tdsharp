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
        /// The front side of the document contains an error. The error will be considered resolved when the file with the front side changes
        /// </summary>
        public partial class PassportElementErrorSource : Object
        {
            /// <summary>
            /// The front side of the document contains an error. The error will be considered resolved when the file with the front side changes
            /// </summary>
            public class PassportElementErrorSourceFrontSide : PassportElementErrorSource
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "passportElementErrorSourceFrontSide";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}