---
title: "Using HTML5 Controls in Coded UI Tests | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
ms.assetid: 2000b214-ae92-4334-b549-aa0eb4f45fe1
caps.latest.revision: 19
ms.author: jillfra
manager: jillfra
---
# Using HTML5 Controls in Coded UI Tests
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Coded UI tests include support for some of the HTML5 controls that are included in Internet Explorer 9 and Internet Explorer 10.

 **Requirements**

- Visual Studio Enterprise

> [!WARNING]
> In versions prior to Internet Explorer 10, it was possible to run coded UI tests in a higher privilege level compared to that of the Internet Explorer process. When running coded UI tests on Internet Explorer 10, both the coded UI test and the Internet Explorer process must be at the same privilege level. This is because of more secure AppContainer features in Internet Explorer 10.

> [!WARNING]
> If you create a coded UI test in Internet Explorer 10, it might not run using Internet Explorer 9 or Internet Explorer 8. This is because Internet Explorer 10 includes HTML5 controls such as Audio, Video, ProgressBar and Slider. These HTML5 controls are not recognized by Internet Explorer 9, or Internet Explorer 8. Likewise, your coded UI test using Internet Explorer 9 might include some HTML5 controls that also will not be recognized by Internet Explorer 8.

## Supported HTML5 Controls
 Coded UI tests include support for record, playback, and validation of the following HTML5 controls:

- [Audio Control](#audio-control)

- [Video Control](#video-control)

- [Slider](#slider)

- [ProgressBar](#progressbar)

### Audio Control
 **Audio control:** Actions on the HTML5 Audio control are correctly recorded and played back.

 ![HTML5 Audio control](../test/media/codedui-html5-audio.png)

|Action|Recording|Generated Code|
|------------|---------------|--------------------|
|**Play audio**<br /><br /> Directly from control, or from controls context menu.|Play \<name> Audio from 00:00:00|HtmlAudio.Play(TimeSpan)|
|**Seek to a specific time in the audio**|Seek \<name> Audio to 00:01:48|HtmlAudio.Seek(TimeSpan)|
|**Pause audio**<br /><br /> Directly from control, or from controls context menu.|Pause \<name> Audio at 00:01:53|HtmlAudio.Pause(TimeSpan)|
|**Mute audio**<br /><br /> Directly from control, or from controls context menu.|Mute \<name> Audio|HtmlAudio.Mute()|
|**Unmute audio**<br /><br /> Directly from control, or from controls context menu.|Unmute \<name> Audio|HtmlAudio.Unmute()|
|**Change volume of audio**|Set volume of \<name> Audio to 79%|HtmlAudio.SetVolume(float)|

 The following properties are available for HtmlAudio and you can add an assertion on all of them:

```
string AutoPlay
string Controls
string CurrentSrc
string CurrentTime
string CurrentTimeAsString
string Duration
string DurationAsString
string Ended
string Loop
string Muted
string Paused
string PlaybackRate
string ReadyState
string Seeking
string Src
string Volume
```

 **Search properties:** The search properties for `HtmlAudio` are `Id`, `Name` and `Title`.

 **Filter properties:** The filter properties for `HtmlAudio` are `Src`, `Class`, `ControlDefinition` and `TagInstance`.

> [!NOTE]
> The amount of time for Seek and Pause can be significant. During playback, the coded UI test will wait until the specified time in `(TimeSpan)` before Pausing the audio. If by some special circumstance, the specified time has passed before hitting the Pause command, an exception will be thrown.

### Video Control
 **Video control:** Actions on the HTML5 Video control are correctly recorded and played back.

 ![HTML5 Video control](../test/media/codedui-html5-video.png)

|Action|Recording|Generated Code|
|------------|---------------|--------------------|
|**Play video**<br /><br /> Directly from control, or from controls context menu.|Play \<name> Video  from 00:00:00|HtmlVideo.Play(TimeSpan)|
|**Seek to a specific time in the video**|Seek \<name> Video to 00:01:48|HtmlVideo.Seek(TimeSpan)|
|**Pause video**<br /><br /> Directly from control, or from controls context menu.|Pause \<name> Video at 00:01:53|HtmlVideo.Pause(TimeSpan)|
|**Mute video**<br /><br /> Directly from control, or from controls context menu.|Mute \<name> Video|HtmlVideo.Mute()|
|**Unmute video**<br /><br /> Directly from control, or from controls context menu.|Unmute \<name> Video|HtmlVideo.Unmute()|
|**Change volume of video**|Set volume of \<name> Video to 79%||

 All the properties of HtmlAudio are available for HtmlVideo. In addition, the following three properties are also available. Assertion can be added on all of them.

```
string Poster
string VideoHeight
string VideoWidth

```

 **Search properties:** The search properties for `HtmlVideo` are `Id`, `Name` and `Title`.

 **Filter properties:** The filter properties for `HtmlVideo` are `Src`, `Poster`, `Class`, `ControlDefinition` and `TagInstance`.

> [!NOTE]
> If you rewind or fast forward the video using -30s or +30s labels, this will be aggregated to seek to the appropriate time.

### Slider
 **Slider control:** Actions on the HTML5 Slider control are correctly recorded and played back.

 ![HTML5 Slider control](../test/media/codedui-html5-slider.png)

|Action|Recording|Generated Code|
|------------|---------------|--------------------|
|**Set a position in the slider**|Set position to \<x> in \<name> slider|HtmlSlider.ValueAsNumber=\<x>|

 The following properties are available for HtmlSlider and assertion can be added on all of them:

```
string Disabled
string Max
string Min
string Required
string Step
string ValueAsNumber
```

### ProgressBar
 **ProgressBar control:** The ProgressBar is a non-interactable control. You can add assertions on the `Value` and `Max` properties of this control.

 ![HTML5 ProgressBar control](../test/media/codedui-html5-progressbar.png)

## See also

- [HTML Elements](https://www.w3schools.com/HTML/html_elements.asp)
- [Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md)
- [Creating Coded UI Tests](../test/use-ui-automation-to-test-your-code.md#VerifyingCodeUsingCUITCreate)
- [Customizing your coded UI test](../test/use-ui-automation-to-test-your-code.md#VerifyingCodeCUITModify)
- [Supported Configurations and Platforms for Coded UI Tests and Action Recordings](../test/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)
