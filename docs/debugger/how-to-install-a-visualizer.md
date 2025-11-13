---
title: Install a Visualizer for use in debugging
description: Install a newly created visualizer to make it available to use for debugging your projects and solution in Visual Studio.
ms.date: 06/26/2025
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
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Install a Visualizer

> [!IMPORTANT]
> Starting with Visual Studio 2022 version 17.9, visualizers can now be written in .NET 6.0+ that run out-of-process using the new VisualStudio.Extensibility model. For extensions created using the new model, see the documentation at [Create Visual Studio debugger visualizers](../extensibility/visualstudio.extensibility/debugger-visualizer/debugger-visualizers.md) instead. If you need to support older versions of Visual Studio or want to ship your custom visualizers as part of a library DLL, then use the information in this article, which applies only to the older model of extension development (VSSDK).

After you have created a visualizer, you must install the visualizer so that it will be available in Visual Studio. Installing a visualizer is a simple process.

> [!NOTE]
> In UWP apps, only the standard text, HTML, XML, and JSON visualizers are supported. Custom (user-created) visualizers are not supported.

### To install a visualizer for Visual Studio 2019

1. Locate the DLL that contains the visualizer you built.

   Typically, it is best if both the debugger-side DLL and the debuggee-side DLL specify **Any CPU** as the target platform. The debugger-side DLL must be either **Any CPU** or **32-bit**. The target platform for the debuggee-side DLL should correspond to the debuggee process.

   >[!NOTE]
   > The debugger-side visualizer is loaded in the Visual Studio process, so it must be a .NET Framework DLL. The debuggee-side can be either .NET Framework or .NET Standard depending on what process is getting debugged in Visual Studio.

2. Copy the [debugger side](create-custom-visualizers-of-data.md#create-the-debugger-side-user-interface) DLL (and any DLLs it depends on) to either of the following locations:

    - *VisualStudioInstallPath* `\Common7\Packages\Debugger\Visualizers`

    - `My Documents\` *VisualStudioVersion* `\Visualizers`

3. Copy the [debuggee side](create-custom-visualizers-of-data.md#create-the-visualizer-object-source-for-the-debuggee-side) DLL to either of the following locations:

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

## Related content
- [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md)
- [How to: Write a Visualizer](create-custom-visualizers-of-data.md)
