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
        /// Searches for messages in secret chats. Returns the results in reverse chronological order. For optimal performance the number of returned messages is chosen by the library
        /// </summary>
        public class SearchSecretMessages : Function<FoundMessages>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "searchSecretMessages";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the chat in which to search. Specify 0 to search in all secret chats 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            /// <summary>
            /// Query to search for. If empty, searchChatMessages should be used instead
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("query")]
            public string Query { get; set; }

            /// <summary>
            /// The identifier from the result of a previous request, use 0 to get results from the last message
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("from_search_id")]
            public Int64 FromSearchId { get; set; }

            /// <summary>
            /// Maximum number of messages to be returned; up to 100. Fewer messages may be returned than specified by the limit, even if the end of the message history has not been reached
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("limit")]
            public int Limit { get; set; }

            /// <summary>
            /// A filter for the content of messages in the search results
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("filter")]
            public SearchMessagesFilter Filter { get; set; }
        }
    }
}