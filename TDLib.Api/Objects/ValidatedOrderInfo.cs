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
        /// Contains a temporary identifier of validated order information, which is stored for one hour. Also contains the available shipping options 
        /// </summary>
        public class ValidatedOrderInfo : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "validatedOrderInfo";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Temporary identifier of the order information 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("order_info_id")]
            public string OrderInfoId { get; set; }

            /// <summary>
            /// Available shipping options
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("shipping_options")]
            public ShippingOption[] ShippingOptions { get; set; }
        }
    }
}