---
title: "Create custom views of data in the debugger"
description: Learn the various ways  to inspect and modify program state in Visual Studio debugger. These include the Autos and Watch windows, DataTips, and Visualizers.  
ms.date: "08/08/2023"
ms.topic: article
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "debugging [Visual Studio], inspecting programs"
  - "debugger, viewing data"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Create custom views of data in the Visual Studio debugger (C#, Visual Basic, C++)

The Visual Studio debugger provides many tools for inspecting and modifying the state of your program. Most of these tools function only in break mode.

## Create custom views of data in variable windows and DataTips

 Many of the [debugger windows](../debugger/debugger-windows.md), such as the **Autos** and **Watch** windows, allow you to inspect variables. You can customize how C++ types, managed objects, and your own types are shown in the debugger variable windows and in [DataTips](../debugger/view-data-values-in-data-tips-in-the-code-editor.md). For more information, see the following articles:

- [Create custom views of C++ objects (Natvis)](../debugger/create-custom-views-of-native-objects.md)
- [Create custom views of .NET objects](../debugger/create-custom-views-of-managed-objects.md)

## Create custom visualizers

 Visualizers enable you to view the contents of an object or variable in a meaningful way. In the Visual Studio debugger, a visualizer refers to the different windows that you can open using the magnifying glass ![VisualizerIcon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon") icon. For example, the HTML visualizer shows how an HTML string would be interpreted and displayed in a browser. You can access visualizers from DataTips, the **Watch** window, the **Autos** window, and the **Locals** window. The **QuickWatch** dialog box also provides a visualizer. For more information:

- To create a visualizer for .NET objects, see [Custom visualizers](../debugger/create-custom-visualizers-of-data.md).
- To create a visualizer for C/C++ objects, see [UIVisualizer element](../debugger/create-custom-views-of-native-objects.md#BKMK_UIVisualizer) within the [Natvis](../debugger/create-custom-views-of-native-objects.md) documentation. Also, see the [C/C++ custom visualizer sample](https://github.com/Microsoft/ConcordExtensibilitySamples/tree/main/CppCustomVisualizer) or the [SQLite native Debugger Visualizer](https://github.com/Microsoft/VSSDK-Extensibility-Samples/tree/master/SqliteVisualizer) sample.

## Related content

- [First look at the debugger](../debugger/debugger-feature-tour.md)
- [Command window](../ide/reference/command-window.md)
- [Debugger security](../debugger/debugger-security.md)
