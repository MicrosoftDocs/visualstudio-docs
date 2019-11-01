---
title: "Visual C/C++ Custom Visualizer Compatibility"
ms.date: "01/28/2019"
ms.prod: visual-studio-dev16
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "debugging assertions"
  - "assertions, debugging"
  - "assertions, assertion failures"
  - "Assertion Failed dialog box"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
monikerRange: ">= vs-2019"
---
# Visual C/C++ Custom Visualizer Compatibility

Starting in Visual Studio 2019, C++ includes an improved debugger that uses an external 64-bit process for hosting its memory-intensive components. As part of this update, certain extensions to the C/C++ expression evaluator must be updated to make them compatible with the new debugger.

If you are currently consuming a legacy C/C++ EE addin or C/C++ custom visualizer, you can turn off usage of this external process by going to **Tools** > **Options** > **Debugging**, and then deselecting **Load debug symbols in external process (native only)**. If you deselect this option, a significant increase in memory usage within the IDE (devenv.exe) process will occur. So, if you expect to debug large projects, it is recommended that you work with the owner of the extension to make it compatible with this debugging option.

If you are the owner of a legacy C/C++ EE addin or C/C++ custom visualizer, you can find more information about opting into loading your extension in a worker process on the [Concord extensibility samples wiki](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Worker-Process-Remoting). You can also find a [C/C++ custom visualizer sample](https://github.com/Microsoft/ConcordExtensibilitySamples/tree/master/CppCustomVisualizer).