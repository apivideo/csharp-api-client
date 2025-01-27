# ApiVideo.Model.VideoCreationPayload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The title of your new video. | 
**Subtitle** | **string** | A subtitle of your video. | [optional] 
**Description** | **string** | A brief description of your video. | [optional] 
**Source** | **string** | You can either add a video already on the web, by entering the URL of the video, or you can also enter the &#x60;videoId&#x60; of one of the videos you already have on your api.video acccount, and this will generate a copy of your video. Creating a copy of a video can be especially useful if you want to keep your original video and trim or apply a watermark onto the copy you would create. | [optional] 
**Public** | **bool** | Default: True. If set to &#x60;false&#x60; the video will become private. More information on private videos can be found [here](https://docs.api.video/delivery/video-privacy-access-management) | [optional] [default to true]
**Panoramic** | **bool** | Indicates if your video is a 360/immersive video. | [optional] [default to false]
**Mp4Support** | **bool** | Enables mp4 version in addition to streamed version. | [optional] [default to true]
**PlayerId** | **string** | The unique identification number for your video player. | [optional] 
**Tags** | **List&lt;string&gt;** | A list of tags you want to use to describe your video. | [optional] 
**Metadata** | [**List&lt;Metadata&gt;**](Metadata.md) | A list of key value pairs that you use to provide metadata for your video. | [optional] 
**Clip** | [**VideoClip**](VideoClip.md) |  | [optional] 
**Watermark** | [**VideoWatermark**](VideoWatermark.md) |  | [optional] 
**Language** | **string** | Use this parameter to set the language of the video. When this parameter is set, the API creates a transcript of the video using the language you specify. You must use the [IETF language tag](https://en.wikipedia.org/wiki/IETF_language_tag) format.  &#x60;language&#x60; is a permanent attribute of the video. You can update it to another language using the [&#x60;PATCH /videos/{videoId}&#x60;](https://docs.api.video/reference/api/Videos#update-a-video-object) operation. This triggers the API to generate a new transcript using a different language. | [optional] 
**Transcript** | **bool** | Use this parameter to enable transcription.   - When &#x60;true&#x60;, the API generates a transcript for the video. - The default value is &#x60;false&#x60;. - If you define a video language using the &#x60;language&#x60; parameter, the API uses that language to transcribe the video. If you do not define a language, the API detects it based on the video.  - When the API generates a transcript, it will be available as a caption for the video. | [optional] 
**TranscriptSummary** | **bool** | Use this parameter to enable summarization. We recommend using this parameter together with &#x60;transcript: true&#x60;.  - When &#x60;true&#x60;, the API generates a summary for the video, based on the transcription. - The default value is &#x60;false&#x60;. - If you define a video language using the &#x60;language&#x60; parameter, the API uses that language to summarize the video. If you do not define a language, the API detects it based on the video. | [optional] 
**TranscriptSummaryAttributes** | **List&lt;string&gt;** | Use this parameter to define the elements of a summary that you want to generate. If you do not define this parameter, the API generates a full summary with all attributes. The possible values are &#x60;abstract&#x60; and &#x60;takeaways&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

