---
title: Measuring the performance of Python code
description: How to use the Visual Studio profiler to check the performance of Python code when usnig CPython-based interpreters.
ms.date: 01/09/2018
ms.prod: visual-studio-dev15
ms.technology: vs-python
ms.topic: conceptual
author: kraigb
ms.author: kraigb
manager: douge
ms.workload: 
  - python
  - data-science
---

# Profiling Python code

You can profile a Python application when using CPython-based interpreters. (See [Features matrix - profiling](overview-of-python-tools-for-visual-studio.md#matrix-profiling) for the availability of this feature for different versions of Visual Studio.)

Profiling is started through the **Analyze > Launch Python Profiling** menu command, which opens a configuration dialog:

![Profiling configuration dialog](media/profiling-start.png)

When you select **OK**, the profiler runs and opens a performance report through which you can explore how time is spent in the application:

![Profiling performance report](media/profiling-results.png)

|   |   |
|---|---|
| ![movie camera icon for video](../install/media/video-icon.png "Watch a video") | [Watch a video (Microsoft Virtual Academy)](https://mva.microsoft.com/en-US/training-courses-embed/python-tools-for-visual-studio-2017-18121/Video-Profiling-Python-s6FoC6LWE_1005918567) for a demonstration of Python profiling (3m 00s).|

> [!Note]
> At present, Visual Studio supports only this level of full-application profiling, but we certainly want to hear your feedback on future capabilities. Use the [**Give product feedback** button](#feedback) at the bottom of this page.

## Profiling for IronPython

Because IronPython is not a CPython-based interpreter, the profiling feature above does not work.

Instead, use the Visual Studio .NET profiler by launching `ipy.exe` directly as the target application, using the appropriate arguments to launch your startup script. Include `-X:Debug` on the command line to ensure that all of your Python code can be debugged and profiled. This argument generates a performance report including time spent both in the IronPython runtime and you code. Your code is identified using mangled names.

Alternately, IronPython has some of its own built-in profiling but there's currently no good visualizer for it. See [An IronPython Profiler](http://blogs.msdn.com/b/curth/archive/2009/03/29/an-ironpython-profiler.aspx) (MSDN blogs) for what's available.