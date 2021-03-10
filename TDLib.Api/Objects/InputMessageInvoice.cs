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
        /// A message with an invoice; can be used only by bots and only in private chats 
        /// </summary>
        public partial class InputMessageContent : Object
        {
            /// <summary>
            /// A message with an invoice; can be used only by bots and only in private chats 
            /// </summary>
            public class InputMessageInvoice : InputMessageContent
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputMessageInvoice";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Invoice 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("invoice")]
                public Invoice Invoice { get; set; }

                /// <summary>
                /// Product title; 1-32 characters 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                /// <summary>
                /// A message with an invoice; can be used only by bots and only in private chats 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("description")]
                public string Description { get; set; }

                /// <summary>
                /// Product photo URL; optional 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo_url")]
                public string PhotoUrl { get; set; }

                /// <summary>
                /// Product photo size 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo_size")]
                public int PhotoSize { get; set; }

                /// <summary>
                /// Product photo width 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo_width")]
                public int PhotoWidth { get; set; }

                /// <summary>
                /// Product photo height
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo_height")]
                public int PhotoHeight { get; set; }

                /// <summary>
                /// The invoice payload 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("payload")]
                public byte[] Payload { get; set; }

                /// <summary>
                /// Payment provider token 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("provider_token")]
                public string ProviderToken { get; set; }

                /// <summary>
                /// JSON-encoded data about the invoice, which will be shared with the payment provider 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("provider_data")]
                public string ProviderData { get; set; }

                /// <summary>
                /// Unique invoice bot start_parameter for the generation of this invoice
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("start_parameter")]
                public string StartParameter { get; set; }
            }
        }
    }
}