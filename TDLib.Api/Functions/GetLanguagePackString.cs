using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Returns a string stored in the local database from the specified localization target and language pack by its key. Returns a 404 error if the string is not found. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        public class GetLanguagePackString : Function<LanguagePackStringValue>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getLanguagePackString";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Path to the language pack database in which strings are stored 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("language_pack_database_path")]
            public string LanguagePackDatabasePath { get; set; }

            /// <summary>
            /// Localization target to which the language pack belongs 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("localization_target")]
            public string LocalizationTarget { get; set; }

            /// <summary>
            /// Language pack identifier 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("language_pack_id")]
            public string LanguagePackId { get; set; }

            /// <summary>
            /// Language pack key of the string to be returned
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("key")]
            public string Key { get; set; }
        }


        /// <summary>
        /// Returns a string stored in the local database from the specified localization target and language pack by its key. Returns a 404 error if the string is not found. This is an offline method. Can be called before authorization. Can be called synchronously
        /// </summary>
        public static Task<LanguagePackStringValue> GetLanguagePackStringAsync(this Client client,
            string languagePackDatabasePath = default(string),
            string localizationTarget = default(string),
            string languagePackId = default(string),
            string key = default(string))
        {
            return client.ExecuteAsync(new GetLanguagePackString
            {
                LanguagePackDatabasePath = languagePackDatabasePath,
                LocalizationTarget = localizationTarget,
                LanguagePackId = languagePackId,
                Key = key,
            });
        }
    }
}