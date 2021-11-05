---
title: Getting started with graphics diagnostics | Microsoft Docs
description: Prepare to use Graphics Diagnostics for the first time, then capture frames from a Direct3D app and examine them in the Graphics Analyzer.

ms.date: 06/08/2020
ms.topic: how-to
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# Getting Started with Visual Studio Graphics Diagnostics
In this section you'll prepare to use Graphics Diagnostics for the first time, then you'll capture frames from a Direct3D app and examine them in the Graphics Analyzer.

## Requirements
 To use Graphics Diagnostics in Visual Studio, you must use Visual Studio Enterprise, Visual Studio Professional, or Visual Studio Community.  Other editions, including Visual Studio Code, do not contain this feature.

 [!INCLUDE[downloadvs](../includes/downloadvs_md.md)]

### Windows 10 prerequisites
 The optional Windows feature *Graphics Tools* provides the capture and playback infrastructure that's required by Graphics Diagnostics on Windows 10.

 For information on installing Graphics Tools, see [Install Graphics Tools for Windows 10](#InstallGraphicsTools).

## <a name="InstallGraphicsTools"></a> Install Graphics Tools for Windows 10
 In Windows 10, the Graphics Diagnostics infrastructure is provided by an optional feature of Windows called *Graphics Tools*. This feature is required to capture and play back graphics information on Windows 10 regardless of whether the app being captured targets a previous version of windows or which version of Direct3D it uses. You can choose to install the Graphics Tools feature ahead of time; otherwise it will be installed on-demand the first time you start a Graphics Diagnostics session from Visual Studio.

#### To install Graphics Tools for Windows 10

1. In Search, type **Apps and features** and then open the **Apps & features** settings.

2. On the right-hand side of the **Apps & features** settings, choose **Optional features** (under **Apps & features**).

   The **Optional features** settings appear.

3. In the **Optional features** settings, choose **Add a feature**. A list of optional features you can install appears.

4. Select **Graphics Tools** from the list of features, then choose **Install**.

   The Graphics Tools feature is also installed automatically when you install the Windows 10 SDK.

> [!TIP]
> The optional Graphics Tools feature of Windows 10 provides lightweight capture and playback functionality—such as the command-line capture program **dxcap.exe**—that can be used in support, testing, and diagnostic scenarios on machines where developer tools aren't installed. For more information, see the [Command-Line Capture Tool](command-line-capture-tool.md) topic.

## Using Graphics Diagnostics for the first time
 Now that you have everything you need, you're ready to start using Graphics Diagnostics. Just follow these steps.

### 1 - Create a Direct3D app

If you already have your own Direct3D app to explore Graphics Diagnostics with, great! Otherwise, use one of the following:

::: moniker range=">=vs-2019"
Download a sample from [Direct3D Game Sample](/samples/microsoft/windows-universal-samples/simple3dgamedx/).
::: moniker-end
::: moniker range="vs-2017"
- The **DirectX 11 App (Universal Windows)** or **DirectX 12 App (Universal Windows)** project templates for Windows 10.
- [Direct3D 12 UAP sample](https://code.msdn.microsoft.com/Direct3D-12-UAP-Sample-ecb1779f) for Windows 10.
::: moniker-end

Make sure you can build and run the app before moving on. Choose **Build** > **Build Solution** to make sure it builds without errors. Then choose **Debug** > **Start without Debugging** (**Ctrl + F5**) to make sure it runs correctly. Depending on what machine you are testing with the tool, you may need to adjust the platform and debugging target for the sample. For example, to test against the x64 platform on your Visual Studio host machine, choose **x64** as the Solution Platform and **Local Machine** as your debugging target. 

### 2 - Start a Graphics Diagnostics session
 Now you're ready to start your first graphics diagnostics session. In Visual Studio, on the main menu, choose **Debug, Graphics, Start Graphics Debugging**, or just press **Alt+F5**. This starts your app under Graphics Diagnostics and displays the diagnostics session windows in Visual Studio.

> [!IMPORTANT]
> If you're running your app on Windows 10 and haven't installed the optional Graphics Tools feature yet, you'll be prompted to do so now. You must install it before you can use Graphics Diagnostics on Windows 10.

### 3 - Capture Frames
 You're ready to capture frames as soon as your app starts.

#### To capture single frames

- In Visual Studio, choose the **Capture Frame** button from the Graphics toolbar or diagnostics session window. Or, if your app has focus, just press the **Print Screen** key on your keyboard.

#### To capture a sequence of frames

- In Visual Studio, in the diagnostic session window, set **Frames to capture** to the number of frames you want to capture in sequence, then capture the sequence by using any of the methods you described above to capture single frames.

   To capture single frames again, set **Frames to capture** to *1*.

  When you're done capturing frames just exit the app or choose the **Stop** button from the Graphics toolbar or diagnostic session window.

### 4 - Examine captured frames in the Graphics Analyzer
 Now you're ready to examine the frames you just captured. To start analyzing a frame, choose the frame number of the frame you want to examine from the diagnostic session window. This opens the frame in the **Graphics Analyzer**, where you can use the Graphics Diagnostics tools to examine how your app uses Direct3D to track down rendering problems, or use the **Frame Analysis** tool to understand its performance.

 If you selected the wrong frame from the diagnostic session window or you want to examine a different frame you can select a new one from the Graphics Analyzer. On the **Render Target** tab of the graphics log window, under the render target image, expand the **Frame List** and then choose a different frame to examine.

 To learn more about how to use the Graphics Analyzer tools together, see the [Examples](graphics-diagnostics-examples.md).

## See also
- [Direct3D 12 Graphics](/windows/desktop/direct3d12/direct3d-12-graphics)