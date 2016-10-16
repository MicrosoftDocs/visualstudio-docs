---
title: "How to: Include Recordings of the Screen and Voice During Tests Using Test Settings"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "test settings, recording desktop video"
ms.assetid: 2cefe8c2-430a-4cb4-bbe0-f3edb2e5bc03
caps.latest.revision: 76
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Include Recordings of the Screen and Voice During Tests Using Test Settings
From the configuration editor in [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)] or Visual Studio, you can configure the diagnostic data adapter that records the screen and voice of the user who’s running the test. This diagnostic data adapter saves a screen and voice recording of the desktop session during the test. The recording is saved with the test result or it can be attached to a bug. Other team members can use the recording to isolate application defects that are difficult to reproduce.  
  
> [!CAUTION]
>  Visual Studio creates the screen recordings in Windows Media Video (WMV) format. For compatibility with recordings created using Visual Studio 2010, you must install the Expression Encoder 4.0 diagnostic data adapter software. For more information about which software to install, see the Visual Studio 2010 topic [How to: Install the Required Software to Create a Screen and voice recording Using Test Runner](http://go.microsoft.com/fwlink/?LinkID=251910).  
  
> [!CAUTION]
>  The screen and voice recordings do not support multiple monitor configurations.  
  
 The screen and voice recorder can be used with either manual or automated tests. For example, if you run a coded UI test remotely you might want to record the desktop to see the coded UI test as it runs. For more information about how to capture a screen and voice recording remotely, see [How to: Set Up Your Test Agent to Run Tests that Interact with the Desktop](../test/how-to--set-up-your-test-agent-to-run-tests-that-interact-with-the-desktop.md).  
  
#### To configure screen and voice recording for your test settings  
  
1.  Open the test settings that you want to configure for recording the screen and voice. For more information, see [Creating test settings for manual tests](../test/collect-more-diagnostic-data-in-manual-tests.md#CreatePlan) or [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md).  
  
2.  In the test settings, select the **Role** to use to record the screen and voice.  
  
    > [!NOTE]
    >  For manual tests and automated tests this would be the machine that runs the tests.  
  
3.  Select **Screen and Voice Recorder** and then choose **Configure**.  
  
     The Configure Diagnostic Data Adapter – Screen and Voice Recorder dialog box is displayed.  
  
     ![Video configuration](../test/media/testsettingvideoconfiggdr.png "TestSettingVideoConfigGDR")  
  
4.  (Optional) Select **Enable voice recording** to capture audio content in your recording.  
  
5.  (Optional) Select the check box next to **Save recording if test case passes** to specify saving screen and voice recordings for both failed and passed tests.  
  
    > [!WARNING]
    >  If you select **save recording if test case passes**, the recording is stored with the test results, which uses storage space on the server. You can use the Test Attachment Cleaner tool to clean up these attachments.  
  
6.  Under **Screen Recording Quality**, configure the following drop-down list options:  
  
    1.  **Frame rate:** Specify how many frames per second you want to use in the screen and voice recording. The default value is 4 frames per second. Values between 2 and 20 can be specified.  
  
    2.  **Bit rate:** Specify how many kilobytes per second to use in the screen and voice recording. The default value is 512. Values between 512 and 10,000 can be specified.  
  
    3.  **Quality(1-100):** You can specify the quality of the screen and voice recording by selecting a range between 1 and 100. The default is 50 (mid-range).  
  
7.  If you are using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], choose **Save**. If you are using Visual Studio, choose **OK**. The diagnostic trace collector settings are now configured and saved for your test settings.  
  
    > [!TIP]
    >  To reset the configuration for this diagnostic data adapter, choose **Reset to default configuration** for Visual Studio and **Reset to default** for [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)].  
  
## See Also  
 [Collect more diagnostic data](../test/collect-more-diagnostic-data-in-manual-tests.md)   
 [Create Test Settings for Automated System Tests Using Microsoft Test Manager](../test_notintoc/create-test-settings-for-automated-system-tests-using-microsoft-test-manager.md)   
 [Specifying Test Settings for Visual Studio Tests](../test/specifying-test-settings-for-visual-studio-tests.md)   
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)   
 [Run your tests](../test/running-manual-tests-using-the-web-portal.md)   
 [Record and play back manual tests](../test/record-and-play-back-manual-tests.md)