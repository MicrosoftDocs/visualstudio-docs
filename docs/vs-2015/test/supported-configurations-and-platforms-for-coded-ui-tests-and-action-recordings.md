---
title: "Supported Configurations and Platforms for Coded UI Tests and Action Recordings | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
helpviewer_keywords:
  - "coded UI tests"
ms.assetid: 544742b5-4ec1-4d51-b941-72b2f6ff17bc
caps.latest.revision: 108
ms.author: jillfra
manager: jillfra
---
# Supported Configurations and Platforms for Coded UI Tests and Action Recordings
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The supported configurations and platforms for coded UI tests for Visual Studio Enterprise are listed in the following table. These configurations also apply to action recordings created by using [!INCLUDE[MTRlong](../includes/mtrlong-md.md)].

> [!NOTE]
> The coded UI test process must have the same privileges as the app under test.

 **Requirements**

- Visual Studio Enterprise

## Supported Configurations

|Configuration|Supported|
|-------------------|---------------|
|Operating Systems|[!INCLUDE[win7](../includes/win7-md.md)]<br /><br /> [!INCLUDE[winsvr08_r2](../includes/winsvr08-r2-md.md)]<br /><br /> [!INCLUDE[win8](../includes/win8-md.md)]<br /><br /> Windows 10|
|32-bit / 64-bit Support|32-bit Windows that is running 32-bit [!INCLUDE[TCMext](../includes/tcmext-md.md)] can test 32-bit applications.<br /><br /> 64-bit Windows that is running 32-bit [!INCLUDE[TCMext](../includes/tcmext-md.md)] can test 32-bit WOW Applications that have UI Synchronization.n.<br /><br /> 64-bit Windows that is running 32-bit [!INCLUDE[TCMext](../includes/tcmext-md.md)] can test 64-bit Windows Forms and WPF Applications that do not have UI Synchronization.|
|Architecture|x86 and x64 **Note:**  Internet Explorer is not supported in 64-bit mode except when running under [!INCLUDE[win8](../includes/win8-md.md)] or later versions.|
|.NET|.NET 2.0, 3.0, 3.5, 4 and 4.5. **Note:**  [!INCLUDE[TCMext](../includes/tcmext-md.md)] and Visual Studio will both require .NET 4 to operate. However, applications developed by using the listed .NET versions are supported.|

> [!NOTE]
> *UI Synchronization* is a feature where the playback is verified in the message queue of each control. If a control did not respond to the event that was sent to it, then the event is sent again.

## Platform Support

|Platform|Level of Support|
|--------------|----------------------|
|Windows Phone Apps|Only WinRT-XAML based Phone apps are supported.|
|Windows Store Apps|Only XAML-based Store apps are supported.|
|Universal Windows Apps|Only XAML-based Universal Windows Apps on Phone and Desktop are supported.|
|Edge|In Visual Studio 2015 Update 2 and later by using the [Coded UI Cross Browser Testing extension](https://visualstudiogallery.msdn.microsoft.com/11cfc881-f8c9-4f96-b303-a2780156628d)|
|Internet Explorer 8<br /><br /> Internet Explorer 9<br /><br /> Internet Explorer 10 **Important:**  Internet Explorer 10 is only supported on the desktop. <br /><br /> Internet Explorer 11 **Important:**  Internet Explorer 11 is only supported on the desktop.|Fully supported.<br /><br /> -   **Support for HTML5 in Internet Explorer 9 and Internet Explorer 10:** Coded UI tests support record, playback, and validation of the HTML5 controls: Audio, Video, ProgressBar and Slider. For more information, see [Using HTML5 Controls in Coded UI Tests](../test/using-html5-controls-in-coded-ui-tests.md). **Warning:**      If you create a coded UI tests in Internet Explorer 10, it might not run using Internet Explorer 9 or Internet Explorer 8. This is because Internet Explorer 10 includes HTML5 controls such as Audio, Video, ProgressBar, and Slider. These HTML5 controls are not recognized by Internet Explorer 9, or Internet Explorer 8. Likewise, your coded UI test using Internet Explorer 9 might include some HTML5 controls that also will not be recognized by Internet Explorer 8.<br />-   **Support for Internet Explorer 10 Spell Checking:** Internet Explorer 10 includes spell checking capabilities for all text boxes. This allows you to choose from a list of suggested corrections. Coded UI Test will ignore user actions like selecting an alternative spelling suggestion. Only the final text typed into the text box will be recorded.<br />     The following actions are recorded for coded UI test that use the spell checking control: Add to Dictionary, Copy, Select All, Add To Dictionary, and Ignore.<br />-   **Support for 64-bit Internet Explorer running under Windows 8:** Previously, 64-bit versions of Internet Explorer were not supported for recording and playback. With [!INCLUDE[win8](../includes/win8-md.md)] and [!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)], coded UI tests have been enabled for 64-bit versions of Internet Explorer. **Warning:**      64-bit support for Internet Explorer applies only when you are running [!INCLUDE[win8](../includes/win8-md.md)] or later.<br />-   **Support for Pinned Sites in Internet Explorer 9:** In Internet Explorer 9, pinned sites were introduced. With Pinned Sites, you can get to your favorite sites directly from the Windows taskbar—without having to open Internet Explorer first. Coded UI tests can now generate intent-aware actions on pinned sites. For more information about pinned sites, see [Pinned Sites](https://go.microsoft.com/fwlink/?LinkId=220037).<br />-   **Support for Internet Explorer 9 Semantic Tags:** Internet Explorer 9 introduced the following semantic tags: section, nav, article, aside, hgroup, header, footer, figure, figcaption and mark. Coded UI tests ignore all of these semantic tags while recording. You can add assertions on these tags using the Coded UI Test Builder. You can use the navigation dial in the Coded UI Test Builder to navigate to any of these elements and view their properties.<br />-   **Seamless Handling of White Space Characters between Versions of Internet Explorer:** There are differences in the handling of white space characters between Internet Explorer 8, Internet Explorer 9, and Internet Explorer 10. Coded UI Test handles these differences seamlessly. Therefore, a coded UI test created in Internet Explorer 8 for example, will play back successfully in Internet Explorer 9 and Internet Explorer 10.<br />-   **The Notification Area of Internet Explorer Are Now Recorded With the “Continue on Error” Attribute Set:** All actions on the Notification Area of Internet Explorer are now recorded with the “Continue on Error” attribute set. If the notification bar does not appear during playback, the actions on it will be ignored and coded UI test will continue with the next action.|
|Windows Forms and WPF third party controls|Fully supported.<br /><br /> To enable third party controls in Windows Forms and WPF applications, you must add references and code. For more information, see [Enable Coded UI Testing of Your Controls](../test/enable-coded-ui-testing-of-your-controls.md).|
|Internet Explorer 6<br /><br /> Internet Explorer 7|Not supported.|
|Chrome<br /><br /> Firefox|Recording of action steps is not supported. Coded UI Tests can be played back on Chrome and Firefox browsers with Visual Studio 2012 Update 4 or later. Go [here](https://msdn.microsoft.com/library/jj835758.aspx) for more details.|
|Opera<br /><br /> Safari|Not supported.|
|Silverlight|Not supported.<br /><br /> For Visual Studo 2013 however, you can download the [Microsoft Visual Studio 2013 Coded UI Test Plugin for Silverlight](https://go.microsoft.com/fwlink/?LinkId=691026) from the Visual Studio Gallery.|
|Flash/Java|Not supported.|
|Windows Forms 2.0 and later|Fully supported. **Note:**  NetFx controls are fully supported, but not all third-party controls are supported.|
|WPF 3.5 and later|Fully supported.<br /><br /> **Note** NetFx controls are fully supported, but not all third-party controls are supported.|
|Windows Win32|May work with some known issues, but not officially supported.|
|MFC|Partially supported. See the following [Microsoft Web site](https://go.microsoft.com/fwlink/?LinkId=206511) for details of what features are supported.|
|SharePoint|Fully supported.|
|Office Client Applications|Not supported.|
|Dynamics CRM web client|Fully supported.|
|Dynamics (Ax) 2012 client|Action recording and playback are partially supported. See the following [Microsoft Web site](https://go.microsoft.com/fwlink/?LinkId=232677) for details.|
|SAP|Not supported.|
|Citrix/Terminal Services|We don’t recommend recording actions on a terminal server. The recorder doesn’t support running multiple instances at the same time.|
|PowerBuilder|Partially supported.<br /><br /> The support is to the extent accessibility is enabled for PowerBuilder controls.|

 For information about how to create extensions to support other platforms, see [Enable Coded UI Testing of Your Controls](../test/enable-coded-ui-testing-of-your-controls.md) and [Extending Coded UI Tests and Action Recordings to Support Microsoft Excel](../test/extending-coded-ui-tests-and-action-recordings-to-support-microsoft-excel.md).

## See Also
 [Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md)
 [Generating a Coded UI Test from an Existing Action Recording](https://msdn.microsoft.com/library/56736963-9027-493b-b5c4-2d4e86d1d497)
