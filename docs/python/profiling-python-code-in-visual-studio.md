---
title: Run profiler to measure Python code performance
description: Run the Visual Studio profiler to debug Python programs and check the performance of Python code when using CPython-based interpreters.
ms.date: 04/18/2024
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to develop Python projects in Visual Studio so I can use debugging and profiling features to check the performance of my Python code.
---

# Profile Python code in Visual Studio

Visual Studio provides profiling features for Python applications when you debug your code. The Visual Studio **Debugger** lets you step through your code to check variables, analyze program state, resolve potential issues, and so on. Visual Studio profiling features provide information about execution times for your program. You can use this information to help identify performance issues in your code.

Profiling is available for Python 3.9 and earlier when you use a CPython-based interpreter.

## Prerequisites 

- Visual Studio on Windows installed with support for Python workloads. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

- A CPython-based interpreter. [CPython](https://www.python.org/) is the "native" and most commonly used interpreter and is available in 32-bit and 64-bit versions (32-bit recommended). For more information, see [Install Python interpreters](installing-python-interpreters.md).

- A [Python project](quickstart-02-python-in-visual-studio-project-from-template.md) with code or a [folder with Python code](quickstart-05-python-visual-studio-open-folder.md).

Visual Studio for Mac isn't supported. For more information, see [What's happening to Visual Studio for Mac?](/visualstudio/mac/what-happened-to-vs-for-mac) Visual Studio Code on Windows, Mac, and Linux [works well with Python through available extensions](https://code.visualstudio.com/docs/languages/python).

## Use profiler with CPython-based interpreter

When you profile a Python application, Visual Studio collects data for the lifetime of the process, measured in milliseconds (ms).  

Follow these steps to start working with the profiling features in Visual Studio:

1. In Visual Studio, open your Python code file. 

1. Confirm the current environment for your Python code is a CPython-based interpreter. You can check the selected interpreter in the [Python Environments window](managing-python-environments-in-visual-studio.md#the-python-environments-window).

1. On the main toolbar, select **Debug** > **Launch Python Profiling**. Visual Studio opens the **Profiling Settings** dialog:

   :::image type="content" source="media/profiling-python-code-in-visual-studio/profiling-config.png" alt-text="Screenshot of the Profiling Settings configuration dialog in Visual Studio." lightbox="media/profiling-python-code-in-visual-studio/profiling-config.png":::

1. In the **Profiling Settings** dialog, choose the code file or project code that you want to profile:

   - To profile all project code:
   
      1. Select **Open project**.
      
      1. Select the project from the dropdown list. The list shows all projects in the current Visual Studio solution.

   - To profile a specific file:
   
      1. Select **Standalone script**.
      
      1. Select the **Python Interpreter** from the dropdown list or browse to the location. To specify an unlisted interpreter, choose **Other** in the dropdown list and then specify the **Interpreter Path**.

      1. Identify the **Script** file or browse to the location.
      
      1. Specify the **Working Directory** or browse to the location.
      
      1. Specify any **Command Line Arguments** for the script.

1. Select **Start**.

The profiler runs and opens a performance report in Visual Studio. You can review the report to explore how time is spent in your application:

::: moniker range=">=vs-2022"

:::image type="content" source="media/vs-2022/profiling-results.png" alt-text="Screenshot of the Profiling performance report in Visual Studio 2022." border="false" lightbox="media/vs-2022/profiling-results.png":::

::: moniker-end
::: moniker range="<=vs-2019"

:::image type="content" source="media/profiling-results.png" alt-text="Screenshot of the Profiling performance report in Visual Studio." border="false" lightbox="media/profiling-results.png":::

::: moniker-end

## Use profiler with IronPython

IronPython is a .NET implementation of Python that's available in 32-bit and 64-bit versions. IronPython isn't a CPython-based interpreter. Visual Studio supports standard Python debugging for IronPython, but not the profiling features.

For IronPython projects, you can use the Visual Studio .NET profiler. Run the `ipy.exe` command directly as the target application with the appropriate arguments to launch your startup script. On the command line, include the `-X:Debug` argument to ensure all your Python code can be debugged and profiled. This argument generates a performance report that includes time spent in the IronPython runtime and your code. Your code is identified by using _mangled names_.

IronPython offers some built-in profiling, but there's currently no workable visualizer. For more information, see [An IronPython Profiler](/archive/blogs/curth/an-ironpython-profiler) (blog) and [Debugging and Profiling](https://ironpython-test.readthedocs.io/en/latest/library/debug.html) in the IronPython documentation.

## Related content

- [Install Python interpreters](installing-python-interpreters.md)
- [Tutorial: Run code in the Debugger in Visual Studio](./tutorial-working-with-python-in-visual-studio-step-04-debugging.md)
