---
title: Install a Visualizer | Microsoft Docs
description: Understand how to install a visualizer so that it will be available for debugging use in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 07/02/2021
ms.topic: how-to
dev_langs:
  - CSharp
  - VB
  - FSharp
  - C++
  - JScript
helpviewer_keywords:
  - debugger, visualizers
  - visualizers, installing
ms.assetid: 3310ef43-515c-4d97-b0f9-51047247d3da
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - multiple
---
# How to: Install a Visualizer
After you have created a visualizer, you must install the visualizer so that it will be available in [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)]. Installing a visualizer is a simple process.

> [!NOTE]
> In UWP apps, only the standard text, HTML, XML, and JSON visualizers are supported. Custom (user-created) visualizers are not supported.

::: moniker range=">=vs-2019"
### To install a visualizer for Visual Studio 2019

1. Locate the DLL that contains the visualizer you built.

   Typically, it is best if both the debugger-side DLL and the debuggee-side DLL specify **Any CPU** as the target platform. The debugger-side DLL must be either **Any CPU** or **32-bit**. The target platform for the debuggee-side DLL should correspond to the debuggee process.

   >[!NOTE]
   > The debugger-side visualizer is loaded in the Visual Studio process, so it must be a .NET Framework DLL. The debuggee-side can be either .NET Framework or .NET Standard depending on what process is getting debugged in Visual Studio.

2. Copy the [debugger side](create-custom-visualizers-of-data.md#to-create-the-debugger-side) DLL (and any DLLs it depends on) to either of the following locations:

    - *VisualStudioInstallPath* `\Common7\Packages\Debugger\Visualizers`

    - `My Documents\` *VisualStudioVersion* `\Visualizers`

3. Copy the [debuggee side](create-custom-visualizers-of-data.md#to-create-the-visualizer-object-source-for-the-debuggee-side) DLL to either of the following locations:

    - *VisualStudioInstallPath* `\Common7\Packages\Debugger\Visualizers\` *Framework*

    - `My Documents\` *VisualStudioVersion* `\Visualizers\` *Framework*

    where *Framework* is either:
    - `net2.0` for debuggees running the `.NET Framework` runtime.
    - `netstandard2.0` for debuggees using a runtime that supports `netstandard 2.0` (`.NET Framework v4.6.1+` or `.NET Core 2.0+`).
    - `netcoreapp` for debuggees running the `.NET Core` runtime. (supports `.NET Core 2.0+`)

   A debuggee-side DLL is necessary if you want to create a standalone visualizer. This DLL contains code for the data object, which can implement methods of <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource>.

   If you are multi-targeting the debuggee-side code, the debuggee-side DLL must be placed into the folder for minimum-supported TFM.

4. Restart the debugging session.

> [!NOTE]
> The procedure is different in Visual Studio 2017 and older. See the [previous version](how-to-install-a-visualizer.md?view=vs-2017&preserve-view=true) of this article.
::: moniker-end

::: moniker range="vs-2017"
### To install a visualizer for Visual Studio 2017 and older

> [!IMPORTANT]
> Only .NET Framework visualizers are supported in Visual Studio 2017 and older.

1. Locate the DLL that contains the visualizer you have built.

2. Copy the DLL to either of the following locations:

    - *VisualStudioInstallPath* `\Common7\Packages\Debugger\Visualizers`

    - `My Documents\` *VisualStudioVersion* `\Visualizers`

3. Restart the debugging session.

> [!NOTE]
> If you want to use a managed visualizer for remote debugging, copy the DLL to the same path on the remote computer.
::: moniker-end

## See also
- [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md)
- [How to: Write a Visualizer](create-custom-visualizers-of-data.md)
