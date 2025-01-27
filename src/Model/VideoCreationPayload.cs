using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ApiVideo.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class VideoCreationPayload: DeepObject   {
    /// <summary>
    /// The title of your new video.
    /// </summary>
    /// <value>The title of your new video.</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string title { get; set; }
    /// <summary>
    /// A subtitle for your video.
    /// </summary>
    /// <value>A subtitle for your video.</value>
    [DataMember(Name="subtitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subtitle")]
    public string subtitle { get; set; }
    /// <summary>
    /// A brief description of your video.
    /// </summary>
    /// <value>A brief description of your video.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string description { get; set; }
    /// <summary>
    /// You can either add a video already on the web, by entering the URL of the video, or you can also enter the `videoId` of one of the videos you already have on your api.video acccount, and this will generate a copy of your video. Creating a copy of a video can be especially useful if you want to keep your original video and trim or apply a watermark onto the copy you would create.
    /// </summary>
    /// <value>You can either add a video already on the web, by entering the URL of the video, or you can also enter the `videoId` of one of the videos you already have on your api.video acccount, and this will generate a copy of your video. Creating a copy of a video can be especially useful if you want to keep your original video and trim or apply a watermark onto the copy you would create.</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string source { get; set; }
    /// <summary>
    /// Default: True. If set to `false` the video will become private. More information on private videos can be found [here](https://docs.api.video/delivery/video-privacy-access-management)
    /// </summary>
    /// <value>Default: True. If set to `false` the video will become private. More information on private videos can be found [here](https://docs.api.video/delivery/video-privacy-access-management)</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public Nullable<bool> _public { get; set; }
    /// <summary>
    /// Indicates if your video is a 360/immersive video.
    /// </summary>
    /// <value>Indicates if your video is a 360/immersive video.</value>
    [DataMember(Name="panoramic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "panoramic")]
    public Nullable<bool> panoramic { get; set; }
    /// <summary>
    /// Enables mp4 version in addition to streamed version.
    /// </summary>
    /// <value>Enables mp4 version in addition to streamed version.</value>
    [DataMember(Name="mp4Support", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mp4Support")]
    public Nullable<bool> mp4support { get; set; }
    /// <summary>
    /// The unique identification number for your video player.
    /// </summary>
    /// <value>The unique identification number for your video player.</value>
    [DataMember(Name="playerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "playerId")]
    public string playerid { get; set; }
    /// <summary>
    /// A list of tags you want to use to describe your video.
    /// </summary>
    /// <value>A list of tags you want to use to describe your video.</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> tags { get; set; }
    /// <summary>
    /// A list of key value pairs that you use to provide metadata for your video.
    /// </summary>
    /// <value>A list of key value pairs that you use to provide metadata for your video.</value>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public List<Metadata> metadata { get; set; }
    /// <summary>
    /// Gets or Sets Clip
    /// </summary>
    [DataMember(Name="clip", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clip")]
    public VideoClip clip { get; set; }
    /// <summary>
    /// Gets or Sets Watermark
    /// </summary>
    [DataMember(Name="watermark", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "watermark")]
    public VideoWatermark watermark { get; set; }
    /// <summary>
    /// Use this parameter to set the language of the video. When this parameter is set, the API creates a transcript of the video using the language you specify. You must use the [IETF language tag](https://en.wikipedia.org/wiki/IETF_language_tag) format.  `language` is a permanent attribute of the video. You can update it to another language using the [`PATCH /videos/{videoId}`](https://docs.api.video/reference/api/Videos#update-a-video-object) operation. This triggers the API to generate a new transcript using a different language.
    /// </summary>
    /// <value>Use this parameter to set the language of the video. When this parameter is set, the API creates a transcript of the video using the language you specify. You must use the [IETF language tag](https://en.wikipedia.org/wiki/IETF_language_tag) format.  `language` is a permanent attribute of the video. You can update it to another language using the [`PATCH /videos/{videoId}`](https://docs.api.video/reference/api/Videos#update-a-video-object) operation. This triggers the API to generate a new transcript using a different language.</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string language { get; set; }
    /// <summary>
    /// Use this parameter to enable transcription.   - When `true`, the API generates a transcript for the video. - The default value is `false`. - If you define a video language using the `language` parameter, the API uses that language to transcribe the video. If you do not define a language, the API detects it based on the video.  - When the API generates a transcript, it will be available as a caption for the video.
    /// </summary>
    /// <value>Use this parameter to enable transcription.   - When `true`, the API generates a transcript for the video. - The default value is `false`. - If you define a video language using the `language` parameter, the API uses that language to transcribe the video. If you do not define a language, the API detects it based on the video.  - When the API generates a transcript, it will be available as a caption for the video.</value>
    [DataMember(Name="transcript", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transcript")]
    public Nullable<bool> transcript { get; set; }
    /// <summary>
    /// Use this parameter to enable summarization. We recommend using this parameter together with `transcript: true`.  - When `true`, the API generates a summary for the video, based on the transcription. - The default value is `false`. - If you define a video language using the `language` parameter, the API uses that language to summarize the video. If you do not define a language, the API detects it based on the video.
    /// </summary>
    /// <value>Use this parameter to enable summarization. We recommend using this parameter together with `transcript: true`.  - When `true`, the API generates a summary for the video, based on the transcription. - The default value is `false`. - If you define a video language using the `language` parameter, the API uses that language to summarize the video. If you do not define a language, the API detects it based on the video.</value>
    [DataMember(Name="transcriptSummary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transcriptSummary")]
    public Nullable<bool> transcriptsummary { get; set; }
    /// <summary>
    /// Use this parameter to define the elements of a summary that you want to generate. If you do not define this parameter, the API generates a full summary with all attributes. The possible values are `abstract` and `takeaways`.
    /// </summary>
    /// <value>Use this parameter to define the elements of a summary that you want to generate. If you do not define this parameter, the API generates a full summary with all attributes. The possible values are `abstract` and `takeaways`.</value>
    [DataMember(Name="transcriptSummaryAttributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transcriptSummaryAttributes")]
    public List<string> transcriptsummaryattributes { get; set; }


    /// <summary>
    /// Constructor. Set default values.
    /// </summary>
    public VideoCreationPayload() {
        _public = true;
        panoramic = false;
        mp4support = true;
        
    }

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoCreationPayload {\n");
      sb.Append("  Title: ").Append(title).Append("\n");
      sb.Append("  Subtitle: ").Append(subtitle).Append("\n");
      sb.Append("  Description: ").Append(description).Append("\n");
      sb.Append("  Source: ").Append(source).Append("\n");
      sb.Append("  Public: ").Append(_public).Append("\n");
      sb.Append("  Panoramic: ").Append(panoramic).Append("\n");
      sb.Append("  Mp4Support: ").Append(mp4support).Append("\n");
      sb.Append("  PlayerId: ").Append(playerid).Append("\n");
      sb.Append("  Tags: ").Append(tags).Append("\n");
      sb.Append("  Metadata: ").Append(metadata).Append("\n");
      sb.Append("  Clip: ").Append(clip).Append("\n");
      sb.Append("  Watermark: ").Append(watermark).Append("\n");
      sb.Append("  Language: ").Append(language).Append("\n");
      sb.Append("  Transcript: ").Append(transcript).Append("\n");
      sb.Append("  TranscriptSummary: ").Append(transcriptsummary).Append("\n");
      sb.Append("  TranscriptSummaryAttributes: ").Append(transcriptsummaryattributes).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
    }

}
}
