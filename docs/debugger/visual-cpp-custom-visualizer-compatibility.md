---
title: "Visual C/C++ Custom Visualizer Compatibility"
description: A new feature in Visual Studio 2019 may not be compatible with legacy C/C++ expression evaluator add-ins and custom visualizers. See this article for details.
ms.date: "01/28/2019"

ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "debugging assertions"
  - "assertions, debugging"
  - "assertions, assertion failures"
  - "Assertion Failed dialog box"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
monikerRange: ">= vs-2019"
---
# Visual C/C++ Custom Visualizer Compatibility

Starting in Visual Studio 2019, C++ includes an improved debugger that uses an external 64-bit process for hosting its memory-intensive components. As part of this update, certain extensions to the C/C++ expression evaluator must be updated to make them compatible with the new debugger.

If you're currently consuming a legacy C/C++ EE add-in or C/C++ custom visualizer, you can turn off usage of this external process by going to **Tools** > **Options** > **Debugging**, and then deselecting **Load debug symbols in external process (native only)**. If you deselect this option, a significant increase in memory usage within the IDE (devenv.exe) process occurs. So, if you expect to debug large projects, we recommend that you work with the owner of the extension to make it compatible with this debugging option.

If you're the owner of a legacy C/C++ EE add-in or C/C++ custom visualizer, learn more about opting into loading your extension in a worker process on the [Concord extensibility samples wiki](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Worker-Process-Remoting). You can also find a [C/C++ custom visualizer sample](https://github.com/Microsoft/ConcordExtensibilitySamples/tree/main/CppCustomVisualizer).
