---
title: Use Visual Studio profiler to measure performance of Python code
description: Use the Visual Studio profiler to check the performance of Python code when using CPython-based interpreters.
ms.date: 06/02/2022
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: jmartens
ms.technology: vs-python
ms.custom: devdivchpfy22
ms.workload:
  - python
  - data-science
---
# Profile Python code

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

You can profile a Python application when using CPython-based interpreters. (See [Features matrix - profiling](overview-of-python-tools-for-visual-studio.md#matrix-profiling) for the availability of this feature for different versions of Visual Studio.)

## Profiling for CPython-based interpreters

Profiling is started through the **Debug** > **Launch Python Profiling** menu command, which opens a configuration dialog:

:::image type="content" source="media/profiling-start.png" alt-text="Screenshot of Profiling configuration dialog.":::

When you select **OK**, the profiler runs and opens a performance report through which you can explore how time is spent in the application:
::: moniker range="<=vs-2019"
:::image type="content" source="media/profiling-results.png" alt-text="Screenshot of Profiling performance report.":::
::: moniker-end
::: moniker range=">=vs-2022"
:::image type="content" source="media/profiling-results-vs-22.png" alt-text="Screenshot of Profiling performance report.":::
::: moniker-end

  > [!Note]
  > When you profile a Python application, Visual Studio collects data for the lifetime of the process. We do want to hear your feedback on future capabilities. Use the **Product feedback** button at the bottom of this page.

## Profiling for IronPython

Because IronPython isn't a CPython-based interpreter, the profiling feature doesn't work.

Instead, use the Visual Studio .NET profiler by launching *ipy.exe* directly as the target application, using the appropriate arguments to launch your startup script. Include `-X:Debug` on the command line to ensure that all of your Python code can be debugged and profiled. This argument generates a performance report including time spent in the IronPython runtime and your code. Your code is identified using mangled names.

Alternately, IronPython has some of its own built-in profiling, but there's currently no good visualizer for it. See [An IronPython Profiler](/archive/blogs/curth/an-ironpython-profiler) (MSDN blogs) for what's available.
