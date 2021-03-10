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
        /// Deletes a file from the TDLib file cache 
        /// </summary>
        public class DeleteFile : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "deleteFile";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the file to delete
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("file_id")]
            public int FileId { get; set; }
        }
    }
}