---
title: "Walkthrough: Capturing Graphics Information | Microsoft Docs"
description: See how to use Visual Studio Graphics Diagnostics to manually capture graphics information from a Direct3D app. 
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 48f12f6e-57b4-48ec-a145-89fa71a42424
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Walkthrough: Capturing Graphics Information
This walkthrough demonstrates how to use the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] Graphics Diagnostics to manually capture graphics information from a Direct3D app.

 This walkthrough illustrates these tasks:

- Hooking Graphics Diagnostics to your app

- Capturing graphics information

## Capturing graphics information
 To use the Graphics Diagnostics tools, you first have to capture the graphics information that it relies on. To enable capture, use the **Start Diagnostics** command to hook Graphics Diagnostics to your app when it starts.

#### To enable the capture of graphics information after a project or solution is loaded

1. In [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)], load a project or solution file for the app that you want to capture graphics information from.

2. On the Graphics Diagnostics toolbar, choose **Start Diagnostics**.

#### To enable the capture of graphics information without loading a project or solution

1. On the menu bar, choose **File**, **Open**, **Project/Solution**. The **Open Project** dialog box appears.

2. Instead of a project or solution file, specify the executable file for the app that you want to capture graphics information from, and then choose **Open**.

3. On the menu bar, choose **Debug**, **Graphics**, **Start Diagnostics**.

   After you start the app and it is rendering frames, you can capture graphics information.

#### To capture graphics information

- On the Graphics Diagnostics toolbar, choose the **Capture** button. ![Graphics capture button icon](media/debuggingdirectxgraphics.png "DebuggingDirectXGraphics")

   -or-

   With the app in focus, press **Print Screen**.

  Each time you capture information about a frame, Graphics Diagnostics records the Direct3D events and associated state and adds that data to a graphics log. A new graphics log is created for each Graphics Diagnostics session. For information about graphics logs, see [Overview](overview-of-visual-studio-graphics-diagnostics.md).

## Next Steps
 This walkthrough demonstrated how to capture graphics information manually. As a next step, consider this option:

- Learn how to analyze captured graphics information using the Graphics Diagnostics tools. See [Overview](overview-of-visual-studio-graphics-diagnostics.md).

## See also
- [Capturing Graphics Information](capturing-graphics-information.md)