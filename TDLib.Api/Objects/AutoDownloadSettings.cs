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
        /// Contains auto-download settings
        /// </summary>
        public class AutoDownloadSettings : Object
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "autoDownloadSettings";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// True, if the auto-download is enabled
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_auto_download_enabled")]
            public bool IsAutoDownloadEnabled { get; set; }

            /// <summary>
            /// Maximum size of a photo file to be auto-downloaded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("max_photo_file_size")]
            public int MaxPhotoFileSize { get; set; }

            /// <summary>
            /// Maximum size of a video file to be auto-downloaded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("max_video_file_size")]
            public int MaxVideoFileSize { get; set; }

            /// <summary>
            /// Maximum size of other file types to be auto-downloaded
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("max_other_file_size")]
            public int MaxOtherFileSize { get; set; }

            /// <summary>
            /// True, if the beginning of videos needs to be preloaded for instant playback
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("preload_large_videos")]
            public bool PreloadLargeVideos { get; set; }

            /// <summary>
            /// True, if the next audio track needs to be preloaded while the user is listening to an audio file
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("preload_next_audio")]
            public bool PreloadNextAudio { get; set; }

            /// <summary>
            /// True, if "use less data for calls" option needs to be enabled
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("use_less_data_for_calls")]
            public bool UseLessDataForCalls { get; set; }
        }
    }
}