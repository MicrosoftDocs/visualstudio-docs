---
title: "How to: Choose the applications that are recorded in a manual test"
ms.custom: na
ms.date: "10/01/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "manual tests, recording user interface actions"
  - "test settings, recording user interface actions"
ms.assetid: bb146984-8728-4187-af48-3cdc3462a219
caps.latest.revision: 73
ms.author: "ahomer"
manager: "kamrani"
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
# How to: Choose the applications that are recorded in a manual test
You can configure the action log diagnostic data adapter for your action log and your action recording. An action log creates a text file where each action is recorded as text. For example, the following text is added if you choose the **Add to Cart** button: Choose Button "Add to Cart". An action recording records each action. This action recording can be used to play back each user action when you want to fast forward to a particular location in the test again.  
  
 If you select the action log diagnostic data adapter in your test settings, an action log is created based on the settings that you configure for the adapter. You can also specify the configuration that will be used for an action recording. These settings that you configured are used if the tester chooses to create an action recording when they run a test.  
  
 The settings include the following:  
  
-   Which applications will be recorded  
  
-   Any time delays between actions when you play back your action recording  
  
-   How to capture the delay between actions  
  
 For more information about how to play back actions, see [Record and play back manual tests](../test/record-and-play-back-manual-tests.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
> [!CAUTION]
>  When a user runs a test using [!INCLUDE[mtrlong](../codequality/includes/mtrlong_md.md)], the user can decide whether to create an action recording, override an existing action recording, or not when they start each test. If the action log diagnostic data adapter has not been selected in the test settings for the role that runs the tests, the default values are used when the action recording is created.  
  
> [!NOTE]
>  In [!INCLUDE[vs_dev11_long](../codequality/includes/vs_dev11_long_md.md)], the ARM architecture is supported for action logs.  
  
 The following procedure describes how to configure your diagnostic data adapter from the configuration editor for action log and action recording. To create your tests settings, see [Collect more diagnostic data](../test/collect-more-diagnostic-data-in-manual-tests.md).  
  
> [!NOTE]
>  The action log and action recording can be collected only on a local computer when you run manual tests and cannot be collected for automated tests.  
  
## Configure recording of user interface actions for playback and as text  
 Before you follow the steps in this procedure, you must open your test settings for your test plan using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. From the **Plan** view, select **Properties**. Select the test settings and then select the **Data and Diagnostics** page.  
  
#### To configure recording of user interface actions for playback and as text  
  
1.  Select **Action log** and then choose **Configure**.  
  
     The **Configure Diagnostic Data Adapter – Action log** dialog box is displayed.  
  
2.  (Applies to action log and action recording) Under **Select applications under test**, select one of the following options:  
  
    1.  **All applications running on the computer except the following**. This option will include all the applications that are running during the test in the recording except the applications that are displayed in the list. You can remove applications from the list, or add process names to exclude other applications.  
  
         -or-  
  
    2.  **Applications in the following list**, and then choose the browse button (**…**) at the end of the list to locate the applications that you want to include during the test recording. If you already know the process name, you can add it.  
  
3.  (Applies to action recording only) Under **Recording settings**, select **Capture user delay between actions if more than:** to enable customized delay time settings for an action recording. Then use the spin box next to **Capture user delay between actions if more than** to configure when you want to capture the delay for the action recording.  
  
4.  (Applies to action recording only) Under **Playback settings**, configure the following settings:  
  
    1.  Use the spin box next to **Constant delay between actions** to configure how many seconds that you want the action recording to insert as a delay between user actions.  
  
    2.  Use the spin box next to **Multiplier for user delay between actions** to specify a time delay multiplier. For example, a setting of 2 will double how many seconds that you have specified in **Delay between actions**.  
  
    3.  Use the spin box next to **Search time for control** to configure how many seconds that you want for the action recording to search for controls.  
  
         Under certain circumstances, an application under test might take several seconds before a control becomes available. The Search time for control setting provides some flexibility by instructing the recording to wait for a specified time interval.  
  
5.  Choose **Save**. The action log and action recording settings are now configured and saved for this test setting.  
  
    > [!NOTE]
    >  To reset the configuration for this diagnostic data adapter, choose **Reset to default**.  
  
## See Also  
 [Collect more diagnostic data](../test/collect-more-diagnostic-data-in-manual-tests.md)   
 [Setting Up Machines and Collecting Diagnostic Information Using Test Settings](../test/setting-up-machines-and-collecting-diagnostic-information-using-test-settings.md)   
 [Run your tests](../test/running-manual-tests-using-the-web-portal.md)   
 [Record and play back manual tests](../test/record-and-play-back-manual-tests.md)