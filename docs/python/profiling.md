---
title: "Measuring the performance of Python Code in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 7/13/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 2723d4d0-89c8-4279-bfc2-27c0834a997e
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
---

# Profiling Python Code

Visual Studio supports profiling a Python application when using CPython-based interpreters.

Profiling is started through the **Analyze > Launch Python Profiling** menu command, which opens a configuration dialog:

![Profiling configuration dialog](media/profiling-start.png)

When you select **OK**, the profiler runs and opens a performance report through which you can explore how time is spent in the application:

![Profiling performance report](media/profiling-results.png)

For an overview, see the following

For a walkthrough demonstration, see the [Profiling with Python Tools for Visual Studio](http://www.youtube.com/watch?v=K-KqkFkp55k) video (8m52s).

> [!VIDEO https://www.youtube.com/embed/K-KqkFkp55k]

## Profiling for IronPython

Because IronPython is not a CPython-based interpreter, the profiling feature above does not work.

Instead, use the Visual Studio .NET profiler by launching `ipy.exe` directly as the target application, using the appropriate arguments to launch your startup script. Include `-X:Debug` on the command line to force all of your Python code to be debuggable and profilable. This argument generates a performance report including time spent both in the IronPython runtime and you code. Your code is identified using mangled names.

Alternately, IronPython has some of its own built-in profiling but there's currently no good visualizer for it. See [An IronPython Profiler](http://blogs.msdn.com/b/curth/archive/2009/03/29/an-ironpython-profiler.aspx) (MSDN blogs) for what's available.