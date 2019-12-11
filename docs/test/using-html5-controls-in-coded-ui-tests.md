---
title: "Using HTML5 Controls in Coded UI Tests"
ms.date: 11/04/2016
ms.topic: conceptual
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
author: jillre
---
# Using HTML5 controls in coded UI tests

Coded UI tests include support for some of the HTML5 controls that are included in Internet Explorer 9 and Internet Explorer 10.

[!INCLUDE [coded-ui-test-deprecation](includes/coded-ui-test-deprecation.md)]

**Requirements**

- Visual Studio Enterprise

> [!WARNING]
> In versions prior to Internet Explorer 10, it was possible to run coded UI tests in a higher privilege level compared to that of the Internet Explorer process. When running coded UI tests on Internet Explorer 10, both the coded UI test and the Internet Explorer process must be at the same privilege level. This is because of more secure AppContainer features in Internet Explorer 10.

> [!WARNING]
> If you create a coded UI test in Internet Explorer 10, it might not run using Internet Explorer 9 or Internet Explorer 8. This is because Internet Explorer 10 includes HTML5 controls such as Audio, Video, ProgressBar and Slider. These HTML5 controls are not recognized by Internet Explorer 9, or Internet Explorer 8. Likewise, your coded UI test using Internet Explorer 9 might include some HTML5 controls that also will not be recognized by Internet Explorer 8.

## Audio Control

**Audio control:** Actions on the HTML5 Audio control are correctly recorded and played back.

![HTML5 Audio control](../test/media/codedui_html5_audio.png)

|Action|Recording|Generated Code|
|-|---------------|-|
|**Play audio**<br /><br /> Directly from control, or from control's right-click menu.|Play \<name> Audio from 00:00:00|HtmlAudio.Play(TimeSpan)|
|**Seek to a specific time in the audio**|Seek \<name> Audio to 00:01:48|HtmlAudio.Seek(TimeSpan)|
|**Pause audio**<br /><br /> Directly from control, or from control's right-click menu.|Pause \<name> Audio at 00:01:53|HtmlAudio.Pause(TimeSpan)|
|**Mute audio**<br /><br /> Directly from control, or from control's right-click menu.|Mute \<name> Audio|HtmlAudio.Mute()|
|**Unmute audio**<br /><br /> Directly from control, or from control's right-click menu.|Unmute \<name> Audio|HtmlAudio.Unmute()|
|**Change volume of audio**|Set volume of \<name> Audio to 79%|HtmlAudio.SetVolume(float)|

See [HTMLAudioElement](https://developer.mozilla.org/docs/Web/API/HTMLAudioElement) for a list of properties on which you can add an assertion.

**Search properties:** The search properties for `HtmlAudio` are `Id`, `Name` and `Title`.

**Filter properties:** The filter properties for `HtmlAudio` are `Src`, `Class`, `ControlDefinition` and `TagInstance`.

> [!NOTE]
> The amount of time for Seek and Pause can be significant. During playback, the coded UI test will wait until the specified time in `(TimeSpan)` before Pausing the audio. If by some special circumstance, the specified time has passed before hitting the Pause command, an exception will be thrown.

## Video Control
**Video control:** Actions on the HTML5 Video control are correctly recorded and played back.

![HTML5 Video control](../test/media/codedui_html5_video.png)

|Action|Recording|Generated Code|
|-|---------------|-|
|**Play video**<br /><br /> Directly from control, or from control's right-click menu.|Play \<name> Video  from 00:00:00|HtmlVideo.Play(TimeSpan)|
|**Seek to a specific time in the video**|Seek \<name> Video to 00:01:48|HtmlVideo.Seek(TimeSpan)|
|**Pause video**<br /><br /> Directly from control, or from control's right-click menu.|Pause \<name> Video at 00:01:53|HtmlVideo.Pause(TimeSpan)|
|**Mute video**<br /><br /> Directly from control, or from control's right-click menu.|Mute \<name> Video|HtmlVideo.Mute()|
|**Unmute video**<br /><br /> Directly from control, or from control's right-click menu.|Unmute \<name> Video|HtmlVideo.Unmute()|
|**Change volume of video**|Set volume of \<name> Video to 79%||

See [HTMLVideoElement](https://developer.mozilla.org/docs/Web/HTML/Element/video) for a list of properties on which you can add an assertion.

**Search properties:** The search properties for `HtmlVideo` are `Id`, `Name` and `Title`.

**Filter properties:** The filter properties for `HtmlVideo` are `Src`, `Poster`, `Class`, `ControlDefinition` and `TagInstance`.

> [!NOTE]
> If you rewind or fast forward the video using -30s or +30s labels, this will be aggregated to seek to the appropriate time.

## ProgressBar
**ProgressBar control:** The ProgressBar is a non-interactable control. You can add assertions on the `Value` and `Max` properties of this control. For more information, see [HTMLProgressElement](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/progress).

![HTML5 ProgressBar control](../test/media/codedui_html5_progressbar.png)

## See also

- [HTML elements](https://developer.mozilla.org/docs/Web/HTML/Element)
- [Use UI automation to test your code](../test/use-ui-automation-to-test-your-code.md)
- [Create coded UI tests](../test/use-ui-automation-to-test-your-code.md)
- [Supported configurations and platforms for coded UI tests and action recordings](../test/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)
