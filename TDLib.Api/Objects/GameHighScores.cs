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
        /// Contains a list of game high scores 
        /// </summary>
        public class GameHighScores : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "gameHighScores";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// A list of game high scores
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("scores")]
            public GameHighScore[] Scores { get; set; }
        }
    }
}