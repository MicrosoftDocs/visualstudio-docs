---
title: "Getting Started with Graphics Diagnostics | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
ms.assetid: 59131181-1caa-4b7f-be4b-e84709634edf
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Getting Started with Visual Studio Graphics Diagnostics
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In this section you'll prepare to use Graphics Diagnostics for the first time, then you'll capture frames from a Direct3D app and examine them in the Graphics Analyzer.

## Requirements
 To use Graphics Diagnostics in Visual Studio 2015, you must have one of these editions:

- Visual Studio 2015 Enterprise

- Visual Studio 2015 Professional

- Visual Studio 2015 Community

  [!INCLUDE[downloadvs](../includes/downloadvs-md.md)]

### Windows 10 prerequisites
 The optional Windows feature *Graphics Tools* provides the capture and playback infrastructure that's required by Graphics Diagnostics on Windows 10.

 For information on installing Graphics Tools, see [Install Graphics Tools for Windows 10](#InstallGraphicsTools).

### Windows 8.1 prerequisites
 The Windows Software Development Kit (SDK) for Windows 8.1 provides the capture and playback infrastructure that's required by Graphics Diagnostics on Windows 8.1, and supports development for Windows 8.1 and Windows 8.

 [Download the Windows Software Development Kit (SDK) for Windows 8.1](https://msdn.microsoft.com/windows/desktop/bg162891.aspx)

 To use a remote playback machine that's running Windows 10 from a development machine running Windows 8.1, you must install the Windows 10 SDK on the development machine, and the optional Graphics Tools feature on the playback machine.

## <a name="InstallGraphicsTools"></a> Install Graphics Tools for Windows 10
 In Windows 10, the Graphics Diagnostics infrastructure is provided by an optional feature of Windows called *Graphics Tools*. This feature is required to capture and play back graphics information on Windows 10 regardless of whether the app being captured targets a previous version of windows or which version of Direct3D it uses. You can choose to install the Graphics Tools feature ahead of time; otherwise it will be installed on-demand the first time you start a Graphics Diagnostics session from Visual Studio.

#### To install Graphics Tools for Windows 10

1. On the **Start** menu, choose **Settings**. The **Settings** dialog appears.

2. In the **Settings** dialog, choose **System**, then select **Installed apps** from the list of system settings.

3. On the right-hand side of the **Settings** dialog, choose **Manage optional features** under **Installed apps and features**. The **Manage optional features** dialog appears.

4. In the **Manage optional features** dialog, choose **Add a feature**. A list of optional features you can install appears.

5. Select **Graphics Tools** from the list of features, then choose **Install**.

   The Graphics Tools feature is also installed automatically when you install the Windows 10 SDK.

> [!TIP]
> The optional Graphics Tools feature of Windows 10 provides lightweight capture and playback functionality—such as the command-line capture program **dxcap.exe**—that can be used in support, testing, and diagnostic scenarios on machines where developer tools aren't installed. For more information, see the [Command-Line Capture Tool](../debugger/command-line-capture-tool.md) topic.

## Using Graphics Diagnostics for the first time
 Now that you have everything you need, you're ready to start using Graphics Diagnostics. Just follow these steps.

### 1 - Create a Direct3D app
 If you've already got your own Direct3D app to explore Graphics Diagnostics with, great! Otherwise you can use one of the Direct3D samples available on Code Gallery.

- To try out Graphics Diagnostics with Direct3D 12 on Windows 10 using Visual Studio 2015, try the [Direct3D 12 UAP sample](https://code.msdn.microsoft.com/Direct3D-12-UAP-Sample-ecb1779f) for Windows 10.

- To try out Graphics Diagnostics with Direct3D 11 on Windows 10 or Windows 8.1, you can use the **DirectX App (Windows Universal)** or  **DirectX App (Windows 8.1)** project templates. Or, for something more interesting, try the [DirectX marble maze game sample](https://code.msdn.microsoft.com/windowsapps/DirectX-Marble-Maze-Game-e4806345) for Windows 8.1.

  Make sure you can build the app before moving on.

### 2 - Start a Graphics Diagnostics session
 Now you're ready to start your first graphics diagnostics session. In Visual Studio, on the main menu, choose **Debug, Graphics, Start Diagnostics**, or just press **Alt+F5**. This starts your app under Graphics Diagnostics and displays the diagnostics session windows in Visual Studio.

> [!IMPORTANT]
> If you're running your app on Windows 10 and haven't installed the optional Graphics Tools feature yet, you'll be prompted to do so now. You must install it before you can use Graphics Diagnostics on Windows 10.

### 3 - Capture Frames
 You're ready to capture frames as soon as your app starts.

##### To capture single frames

- In Visual Studio, choose the **Capture Frame** button from the Graphics toolbar or diagnostics session window. Or, if your app has focus, just press **Print Screen**.

##### To capture a sequence of frames

- In Visual Studio, in the diagnostic session window, set **Frames to capture** to the number of frames you want to capture in sequence, then capture the sequence by using any of the methods you described above to capture single frames.

   To capture single frames again, set **Frames to capture** to `1`.

  When you're done capturing frames just exit the app or choose the **Stop** button from the Graphics toolbar or diagnostic session window.

### 4 – Examine captured frames in the Graphics Analyzer
 Now you're ready to examine the frames you just captured. To start analyzing a frame, choose the frame number of the frame you want to examine from the diagnostic session window. This opens the frame in the **Graphics Analyzer**, where you can use the Graphics Diagnostics tools to examine how your app uses Direct3D to track down rendering problems, or use the **Frame Analysis** tool to understand its performance.

 If you selected the wrong frame from the diagnostic session window or you want to examine a different frame you can select a new one from the Graphics Analyzer. On the **Render Target** tab of the graphics log window, under the render target image, expand the **Frame List** and then choose a different frame to examine.

 To learn more about how to use the Graphics Analyzer tools together, see the [Examples](../debugger/graphics-diagnostics-examples.md).

## See Also
 [Direct3D 12 Graphics](https://msdn.microsoft.com/52094ae3-3b44-4689-9ee7-1ba1b3a779cb)
