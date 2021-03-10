using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class TdlibParameters : Object
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "tdlibParameters";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_test_dc")]
            public bool UseTestDc { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("database_directory")]
            public string DatabaseDirectory { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("files_directory")]
            public string FilesDirectory { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_file_database")]
            public bool UseFileDatabase { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_chat_info_database")]
            public bool UseChatInfoDatabase { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_message_database")]
            public bool UseMessageDatabase { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_secret_chats")]
            public bool UseSecretChats { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("api_id")]
            public int ApiId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("api_hash")]
            public string ApiHash { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("system_language_code")]
            public string SystemLanguageCode { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("device_model")]
            public string DeviceModel { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("system_version")]
            public string SystemVersion { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("application_version")]
            public string ApplicationVersion { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("enable_storage_optimizer")]
            public bool EnableStorageOptimizer { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("ignore_file_names")]
            public bool IgnoreFileNames { get; set; }
        }
    }
}