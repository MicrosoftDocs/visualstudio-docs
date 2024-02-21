---
title: Debug Python code, set breakpoints, inspect code
description: Use rich interactive debugging for Python code in Visual Studio, including setting breakpoints, stepping, inspecting values, looking at exceptions, and more.
ms.date: 02/20/2024
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: jmartens
ms.subservice: python

#customer intent: As a developer, I want to use debugging features in Visual Studio so that I can set breakpoints, step into code, inspect values, and more in my Python code.
---

# Debug your Python code in Visual Studio

Visual Studio provides a comprehensive debugging experience for Python. In this article, you explore how to attach the debugger to running processes and evaluate expressions in the **Watch** and **Immediate** windows. In the debugger, you can inspect local variables, use breakpoints, step in/out/over statements, **Set Next Statement**, and more.

For scenario-specific debugging information, see the following articles:

- [Linux remote debugging](debugging-python-code-on-remote-linux-machines.md)
- [Mixed-mode Python/C++ debugging](debugging-mixed-mode-c-cpp-python-in-visual-studio.md)
- [Symbols for mixed-mode debugging](debugging-symbols-for-mixed-mode-c-cpp-python.md)

## Prerequisites

- Visual Studio installed with support for Python workloads. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

- Python code to use with the debugger.

## Debug code with or without a project

If you want to control your Python environment and arguments, first create a project for your code. You can create a project with the [From existing Python code](managing-python-projects-in-visual-studio.md#create-a-project-from-existing-files) project template.

However, you don't need a project or solution file in Visual Studio to debug your Python code.

To debug code in a standalone Python file:

1. Open your standalone Python file in Visual Studio.

1. Right-click in the code editor and select **Start with Debugging**.

Visual Studio launches the script with the global default environment and no arguments. You then have full debugging support for your code. 

For more information, see [Python environments](managing-python-environments-in-visual-studio.md).

## Explore basic debugging

The basic debugging workflow involves settings breakpoints, stepping through code, inspecting values, and handling exceptions.

Start the debugging session for a project by selecting **Debug** > **Start Debugging** or the **Start** button on the toolbar, or the **F5** keyboard shortcut. These actions launch your project's _startup file_ with the project's active environment and any command-line arguments or search paths specified for **Project Properties**. To configure the properties, see [Set project debugging options](#configure-project-debugging-options).

### Set the startup file

The startup file for a project is shown in bold in **Solution Explorer**. You can choose which file to use as the startup file.

- To specify a project file as the startup file, right-click the file and select **Set as Startup Item**.

In Visual Studio 2017 version 15.6 and later, you see an alert if you don't have a specified startup file set. Earlier versions of Visual Studio might open an **Output** window with the Python interpreter running, or the **Output** window briefly opens and closes.

### Specify the active environment

If you're using a project file, the debugger always starts with the active Python environment for the project. You can change the current active environment. For more information, see [Select a Python environment for a project](selecting-a-python-environment-for-a-project.md).

If you're debugging a standalone Python code file, Visual Studio launches the script with the global default environment and no arguments. 

### Set breakpoints

Breakpoints stop execution of code at a marked point so you can inspect the program state.

Some breakpoints in Python can be surprising for developers who have worked with other programming languages. In Python, the entire file is executable code, so Python runs the file when it's loaded to process any top-level class or function definitions. If a breakpoint is set, you might find the debugger breaking part-way through a class declaration. This behavior is correct, even though it's sometimes surprising.

- To set a breakpoint, select in the left margin of the code editor or right-click a line of code and select **Breakpoint** > **Insert Breakpoint**.

   A red dot appears on each line that has a set breakpoint.

   :::image type="content" source="media/debugging-breakpoints.png" alt-text="Screenshot that shows how breakpoints are displayed in the left margin of the code file in Visual Studio." lightbox="media/debugging-breakpoints.png":::

- To remove a breakpoint, select the red dot or right-click the line of code and select **Breakpoint** > **Delete Breakpoint**. You can also disable a breakpoint by selecting the red dot and selecting **Breakpoint** > **Disable Breakpoint**.

#### Set conditions

You can customize the conditions under which a breakpoint is triggered, such as breaking only when a variable is set to a certain value or value range.

- To set conditions, right-click the breakpoint's red dot, select **Condition**, then create expressions by using Python code. For full details on this feature in Visual Studio, see [Breakpoint conditions](../debugger/using-breakpoints.md#breakpoint-conditions).

When you set conditions, you can also select **Action** and create a message to log to the output window, optionally continuing execution automatically. Logging a message creates a _tracepoint_ without adding logging code to your application directly:

:::image type="content" source="media/debugging-tracepoint.png" alt-text="Screenshot that shows how to create a tracepoint with a breakpoint in Visual Studio." lightbox="media/debugging-tracepoint.png"::: 

### Step through code

When Visual Studio stops code execution at a breakpoint, there are several commands you can use to step through your code or run blocks of code before breaking again. The commands are available in a few places in Visual Studio, including the **Debugger** toolbar, the **Debug** menu, the right-click context menu in the code editor, and through keyboard shortcuts. 

The following table summarizes these commands and provides the keyboard shortcut:

| Command | Shortcut | Description |
| --- | --- | --- |
| **Continue**            | **F5**                     | Run code until you reach the next breakpoint. |
| **Step Into**           | **F11**                    | Run the next statement and stop. If the next statement is a call to a function, the debugger stops at the first line of the called function. |
| **Step Over**           | **F10**                    | Run the next statement, including making a call to a function (running all its code) and applying any return value. This command allows you to easily skip functions that you don't need to debug. |
| **Step Out**            | **Shift**+**F11**          | Run the code until the end of the current function, then step to the calling statement. This command is useful when you don't need to debug the remainder of the current function. |
| **Run to Cursor**       | **Ctrl**+**F10**           | Run the code up to the location of the caret in the editor. This command allows you to easily skip over a segment of code that you don't need to debug. |
| **Set Next Statement**  | **Ctrl**+**Shift**+**F10** | Change the current run point in the code to the location of the caret. This command allows you to omit a segment of code from being run at all, such as when you know the code is faulty or produces an unwanted side-effect. |
| **Show Next Statement** | **Alt**+**Num**+**\\**     | Return to the next statement to run in the code. This command helps you locate the place in your code where the debugger is stopped. |

### Inspect and modify values

When you stop code execution in the debugger, you can inspect and modify the values of variables. You can also use the **Watch** window to monitor individual variables and custom expressions. For more information, see [Inspect variables](../debugger/debugger-feature-tour.md#inspect-variables-with-the-autos-and-locals-windows).

- To view a value by using **DataTips**, hover the mouse over any variable in the editor. You can select the value to change it:

   :::image type="content" source="media/debugging-quick-tips.png" alt-text="Screenshot that shows DataTips for a variable in the Visual Studio debugger." lightbox="media/debugging-quick-tips.png"::: 

- To use the **Autos** window, select **Debug** > **Windows** > **Autos**. This window contains variables and expressions that are close to the current statement. You can double-click in the value column or select and enter **F2** to edit the value:

   :::image type="content" source="media/debugging-autos-window.png" alt-text="Screenshot that shows the Autos window in the Visual Studio debugger." lightbox="media/debugging-autos-window.png"::: 

   For more information on using the **Autos** window, see [Inspect variables in the Autos and Locals windows](../debugger/autos-and-locals-windows.md).

- To use the **Locals** window, select **Debug** > **Windows** > **Locals**. This window displays all variables that are in the current scope, which can again be edited:
 
   :::image type="content" source="media/debugging-locals-window.png" alt-text="Screenshot that shows the Locals window in the Visual Studio debugger." lightbox="media/debugging-locals-window.png"::: 

   For more information on using the **Locals** window, see [Inspect variables in the Autos and Locals windows](../debugger/autos-and-locals-windows.md).

- To use the **Watch** windows, select **Debug** > **Windows** > **Watch** > **Watch 1-4**. This option allows you to enter arbitrary Python expressions and view the results. Expressions are reevaluated for each step:

   :::image type="content" source="media/debugging-watch-window.png" alt-text="Screenshot that shows the Watch window in the Visual Studio debugger." lightbox="media/debugging-watch-window.png"::: 

   For more information on using the **Watch** window, see [Set a watch on variables with the Watch and QuickWatch windows](../debugger/watch-and-quickwatch-windows.md).

- To inspect a string value, select the magnifying glass icon on the right side of the value. The `str`, `unicode`, `bytes`, and `bytearray` types are all available for inspection.

   Selecting the magnifying glass displays the unquoted string value in a popup dialog, with wrapping and scrolling, which is useful for long strings.
   
   You can also select the dropdown arrow on the magnifying glass to choose plain text, HTML, XML, and JSON visualizations:

   :::image type="content" source="media/debugging-string-visualizers.png" alt-text="Screenshot that shows how to access string visualizers from the magnifying glass in the Visual Studio debugger." lightbox="media/debugging-string-visualizers.png" border="false":::

   HTML, XML, and JSON visualizations appear in separate popup windows with syntax highlighting and tree views.

### View exceptions

If an error occurs in your program during debugging, but you don't have an exception handler for it, the debugger breaks at the point of the exception:

:::image type="content" source="media/debugging-exception-popup.png" alt-text="Screenshot that shows an Exception popup for an unhandled error in the Visual Studio debugger." lightbox="media/debugging-exception-popup.png":::

When an error occurs, you can inspect the current program state, including the call stack. However, if you step through the code, the debugging process continues to throw the exception until it's handled or your program exits.

- To see an expanded view of exceptions, select **Debug** > **Windows** > **Exception Settings**. 

   :::image type="content" source="media/debugging-exception-settings.png" alt-text="Screenshot that shows the Exceptions window in the Visual Studio debugger." lightbox="media/debugging-exception-settings.png":::

   In the **Python Exceptions** window opens, the checkbox next an exception controls whether the debugger _always_ breaks when that exception is raised.
   
- To break more often for a particular exception, select the checkbox next to the exception in the **Python Exceptions** window.

- By default, most exceptions break when an exception handler can't be found in the source code. To change this behavior, right-click any exception and modify the **Continue When Unhandled in User Code** option. To break less often for the exception, deselect the **Continue When Unhandled in User Code** option.

- To configure an exception that doesn't appear in the **Python Exceptions** window, select **Add**. Enter a name for the exception to watch. The name must match the full name of the exception.

## Configure project debugging options

By default, the debugger starts your program with the standard Python launcher, no command-line arguments, and no other special paths or conditions. You can configure the startup options for a project by setting the debug properties.

- To access the debug properties for a project, right-click your project in **Solution Explorer**, select **Properties**, and then select the **Debug** tab.

   :::image type="content" source="media/debugging-project-properties.png" alt-text="Screenshot that shows the project debug properties in the Visual Studio debugger." lightbox="media/debugging-project-properties.png":::

The following sections describe the specific properties.

### Set launch properties (launcher)

The following table describes properties you can use to configure launch behavior for the debugger.

| Property | Description |
| --- | --- |
| **Standard Python launcher**   | Use debugging code written in portable Python compatible with CPython, IronPython, and variants like Stackless Python. This option provides the best experience for debugging pure Python code. When you attach to a running _python.exe_ process, the launcher specified in this property is used. This launcher also provides [mixed-mode debugging](debugging-mixed-mode-c-cpp-python-in-visual-studio.md) for CPython, which allows you to step seamlessly between C/C++ code and Python code. |
| **Web launcher**               | Start your default browser on launch and enable debugging of templates. For more information, see the [Web template debugging](python-web-application-project-templates.md#debugging) section. |
| **Django Web launcher**        | Identical behavior to the **Web launcher** property, and used only for the purposes of backwards compatibility. |
| **IronPython (.NET) launcher** | Use the .NET debugger, which works only with IronPython but allows for stepping between any .NET language project, including C# and Visual Basic. This launcher is used if you attach to a running .NET process that hosts IronPython. |

### Set run properties (search, startup, environment)

The following table describes properties you can set to configure running behavior for the debugger.

| Property | Description |
| --- | --- |
| **Search Paths**          | These values match the items shown in the project's **Search Paths** node in **Solution Explorer**. While you can specify search paths in the **Properties** dialog, it can be easier to use **Solution Explorer**. The latter option lets your browse folders and automatically converts paths to relative form. |
| **Script Arguments**      | These arguments are added to the command used to launch your script, and appear after your script's filename. The first item listed in the value is available to your script as `sys.argv[1]`, the second as `sys.argv[2]`, and so on. |
| **Interpreter Arguments** | These arguments are added to the launcher command line before the name of your script. Common arguments are `-W ...` to control warnings, `-O` to slightly optimize your program, and `-u` to use unbuffered IO. IronPython users are likely to use this field to pass `-X` options, such as `-X:Frames` or `-X:MTA`. |
| **Interpreter Path**      | This value overrides the path associated with the current environment. The value might be useful for launching your script with a nonstandard interpreter. |
| **Environment Variables** | Use this property to add entries of the form `<NAME>=\<VALUE>`. Visual Studio applies this property value last, on top of any existing global environment variables, and after `PYTHONPATH` is set according to the **Search Paths** setting. As a result, this setting can be used to manually override any of those other variables. |

## Work with Immediate and Interactive windows

There are two interactive windows you can use during a debugging session: the standard Visual Studio **Immediate** window and the **Python Debug Interactive** window.

### Open the Immediate window

You can use the standard Visual Studio **Immediate** window for quick evaluation of Python expressions and inspection or assignment of variables within your running program. For more information, see [Immediate window](../ide/reference/immediate-window.md).

- To open the **Immediate** window, select **Debug** > **Windows** > **Immediate**.

### Open the Debug Interactive window

The **Python Debug Interactive** window offers a rich environment with the full [Interactive REPL](python-interactive-repl-in-visual-studio.md) experience available while debugging, including writing and running code. This window automatically connects to any process started in the debugger by using the Standard Python launcher (including processes attached through **Debug** > **Attach to Process**). However, this window isn't available when using mixed-mode C/C++ debugging.

- To use the **Debug Interactive** window, select **Debug** > **Windows** > **Python Debug Interactive**. 

   :::image type="content" source="media/debugging-interactive.png" alt-text="Screenshot that shows how to work with the Python Debug Interactive window in Visual Studio." lightbox="media/debugging-interactive.png":::

The **Debug Interactive** window supports special meta-commands in addition to the [standard REPL commands](python-interactive-repl-in-visual-studio.md#meta-commands), as described in the following table:

| Command | Description |
| --- | --- |
| `$continue`, `$cont`, `$c`    | Start running the program from the current statement. |
| `$down`, `$d`                 | Move the current frame one level down in the stack trace. |
| `$frame`                      | Display the current frame ID. |
| `$frame`                      | Switch the current frame to the specified frame ID. <br> - Requires a _\<frame ID>_ argument. |
| `$load`                       | Load commands from file and executes until complete. |
| `$proc`                       | Display the current process ID.  |
| `$proc`                       | Switch the current process to the specified process ID. <br> - Requires a _\<process ID>_ argument. |
| `$procs`                      | List the processes currently being debugged. |
| `$stepin`, `$step`, `$s`      | Step into the next function call, if possible. |
| `$stepout`, `$return`, `$r`   | Step out of the current function. |
| `$stepover`, `$until`, `$unt` | Step over the next function call. |
| `$thread`                     | Display the current thread ID. | 
| `$thread`                     | Switch the current thread to the specified thread ID. <br> - Requires a _\<thread ID>_ argument. |
| `$threads`                    | List the threads currently being debugged. |
| `$up`, `$u`                   | Move up the current frame one level in the stack trace. |
| `$where`, `$w`, `$bt`         | List the frames for the current thread. |

The standard debugger windows such as **Processes**, **Threads**, and **Call Stack** aren't synchronized with the **Debug Interactive** window. If you change the active process, thread, or frame in the **Debug Interactive** window, the other debugger windows aren't affected. Similarly, changing the active process, thread, or frame in the other debugger windows doesn't affect the **Debug Interactive** window.

## Use the legacy debugger

Depending on your environment configuration, you might need to use the legacy debugger:

- Visual Studio 2017 version 15.7 and earlier with Python 2.6, 3.1 to 3.4, or IronPython
- Visual Studio 2019 version 16.5 and later with Python 2.6, 3.1 to 3.4, or IronPython
- ptvsd 3.x and early 4.x versions

The legacy debugger is the default in Visual Studio 2017 version 15.7 and earlier.

<!-- Unable to locate this option under Tools. Is it because I'm using current versions of VS and Python? -->
- To use the legacy debugger, select **Tools** > **Options**, expand the **Python** > **Debugging** options, and select the **Use legacy debugger** option.

### Support older Visual Studio or Python versions

Visual Studio 2017 version 15.8 and later use a debugger based on ptvsd version 4.1+. Visual Studio 2019 version 16.5 and later use a debugger based on debugpy. These two versions of the debugger are compatible with Python 2.7 and Python 3.5+. If you're running one of these versions of Visual Studio, but you're using Python 2.6, 3.1 to 3.4, or IronPython, Visual Studio shows the error, **Debugger does not support this Python environment**:

:::image type="content" source="media/debugging-experimental-incompatible-error.png" alt-text="Screenshot of the debugger error message 'Debugger does not support this Python environment'." lightbox="media/debugging-experimental-incompatible-error.png"::: 

When Visual Studio reports this environment error, you must use the legacy debugger.

### Support older ptvsd versions

If you're using an older version of ptvsd in the current environment (such as an earlier 4.0.x version, or a 3.x version required for remote debugging), Visual Studio might show an error or warning.

If your environment uses ptvsd 3.x, Visual Studio shows the error, **Debugger package could not be loaded**:

:::image type="content" source="media/debugging-experimental-version-error.png" alt-text="Screenshot of the debugger error message 'Debugger package could not be loaded'." lightbox="media/debugging-experimental-version-error.png":::

The warning, **Debugger package is outdated**, appears when you're using an earlier 4.x version of ptvsd:

:::image type="content" source="media/debugging-experimental-version-warning.png" alt-text="Screenshot of the debugger warning message 'Debugger package is outdated'." lightbox="media/debugging-experimental-version-warning.png":::

When Visual Studio reports these environment errors, you must use the legacy debugger.

> [!IMPORTANT]
> Although you might choose to ignore the warning for some versions of ptvsd, Visual Studio might not work correctly.

#### Manage your ptvsd installation

Follow these steps to manage your ptvsd installation:

1. In the **Python Environments** window, go to the **Packages** tab.

1. Enter _ptvsd_ in the search box and examine the installed version of ptvsd:

   :::image type="content" source="media/debugging-experimental-check-ptvsd.png" alt-text="Screenshot that shows how to check the ptvsd version in the Python Environments window." lightbox="media/debugging-experimental-check-ptvsd.png" border="false":::

1. If the version is lower than 4.1.1a9 (the version bundled with Visual Studio), select the **X** to the right of the package to uninstall the older version. Visual Studio then uses its bundled version. (You can also uninstall from PowerShell by using the `pip uninstall ptvsd` command.)

1. Alternately, you can update the ptvsd package to its newest version by following the instructions in the [Troubleshoot debug scenarios](#troubleshoot-debug-scenarios) section.

## Troubleshoot debug scenarios

The following scenarios describe other troubleshooting options for your debugging configuration.

### Upgrade ptvsd for Visual Studio 2019

If you have issues with the debugger in Visual Studio 2019 version 16.4 and earlier, first upgrade your version of the debugger as follows:

1. In the **Python Environments** window, go to the **Packages** tab.

1. Enter _ptvsd --upgrade_ in the search box, then select **Run command: pip install ptvsd --upgrade**. (You can also use the same command from PowerShell.)

   :::image type="content" source="media/debugging-experimental-upgrade-ptvsd.png" alt-text="Screenshot that shows how to select the ptvsd upgrade command in the Python Environments window." lightbox="media/debugging-experimental-upgrade-ptvsd.png" border="false":::

   If issues persist, file an issue on the [PTVS GitHub repository](https://github.com/Microsoft/ptvs/issues).

   > [!NOTE]
   > For Visual Studio 2019 version 16.5 and later, debugpy is part of the Visual Studio Python workload and is updated along with Visual Studio.

### Enable debugger logging

In the course of investigating a debugger issue, Microsoft might ask you to enable and collect debugger logs to help in diagnosis.

The following steps enable debugging in the current Visual Studio session:

1. Open a command window in Visual Studio by selecting **View** > **Other Windows** > **Command Window**.

1. Enter the following command:

   ```powershell
   DebugAdapterHost.Logging /On /OutputWindow
   ```

1. Start debugging and go through the steps necessary to reproduce your issue. During this time, debug logs appear in the **Output** window under **Debug Adapter Host Log**. You can then copy the logs from that window and paste into a GitHub issue, email, and so on.

   :::image type="content" source="media/debugger-logging-output.png" alt-text="Screenshot that shows Debugger logging output in the Output window in Visual Studio." lightbox="media/debugger-logging-output.png" border="false":::

1. If Visual Studio stops responding or you aren't otherwise able to access the **Output** window, restart Visual Studio, open a command window, and enter the following command:

   ```powershell
   DebugAdapterHost.Logging /On
   ```

1. Start debugging and reproduce your issue again. The debugger logs are located in `%temp%\DebugAdapterHostLog.txt`.

## Related content

- [Debugging in Visual Studio](../debugger/debugger-feature-tour.md)
- [Mixed-mode Python/C++ debugging](debugging-mixed-mode-c-cpp-python-in-visual-studio.md)
- [Symbols for mixed-mode debugging](debugging-symbols-for-mixed-mode-c-cpp-python.md)
