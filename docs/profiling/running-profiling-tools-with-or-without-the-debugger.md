---
title: "Run profiling tools with or without the debugger | Microsoft Docs"
ms.date: "11/04/2018"
ms.topic: "conceptual"
ms.assetid: 3fcdccad-c1bd-4c67-bcec-bf33a8fb5d63
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Run profiling tools with or without the debugger

Visual Studio offers a choice of performance measurement and profiling tools. Some tools, like **CPU Usage** and **Memory Usage**, can run with or without the debugger, and on Release or Debug build configurations. **Performance Profiler** tools like **Application Timeline** can run on Debug or Release builds. Debugger-integrated tools like the **Diagnostic Tools** window and **Events** tab run only during debugging sessions.

>[!NOTE]
>You can use the non-debugger performance tools with Windows 7 and later. Windows 8 or later is required to run the debugger-integrated profiling tools.

The non-debugger **Performance Profiler** and the debugger-integrated **Diagnostic Tools** provide different information and experiences. Debugger-integrated tools show you breakpoints and variable values. Non-debugger tools give you results closer to the end-user experience.

To help decide which tools and results to use, consider the following points:

- External performance problems, like file I/O or network responsiveness issues, won't look much different in the debugger or non-debugger tools.
- For issues caused by CPU-intensive calls, there may be considerable performance differences between Release and Debug builds. Check to see whether the issue exists in Release builds.
- If the issue occurs only during Debug builds, you probably don't need to run the non-debugger tools. For Release build issues, decide whether the debugger tools will help for further investigation.
- Release builds provide optimizations like inlining function calls and constants, pruning unused code paths, and storing variables in ways that can't be used by the debugger. Performance numbers in the debugger-integrated tools are less accurate, because Debug builds lack these optimizations.
- The debugger itself changes performance times as it does necessary debugger operations like intercepting exception and module load events.
- Release build performance numbers in the **Performance Profiler** tools are the most precise and accurate. Debugger-integrated tool results are most useful to compare with other debugging-related measurements.

## <a name="BKMK_Quick_start__Collect_diagnostic_data"></a> Collect profiling data while debugging

When you start debugging in Visual Studio by selecting **Debug** > **Start Debugging** or pressing **F5**, the **Diagnostic Tools** window appears by default. To open it manually, select **Debug** > **Windows** > **Show Diagnostic Tools**. The **Diagnostic Tools** window shows information about events, process memory, and CPU usage.

![Diagnostic Tools Window](../profiling/media/diagnostictoolswindow.png "Diagnostic Tools Window")

- Use the **Settings** icon in the toolbar to select whether to view **Memory Usage**, **UI Analysis**, and **CPU Usage**.

- Select **Settings** in the **Settings** dropdown to open the **Diagnostic Tools Property Pages** with more options.

- If you're running Visual Studio Enterprise, you can enable or disable IntelliTrace under Visual Studio **Tools** > **Options** > **IntelliTrace**.

The diagnostic session ends when you stop debugging.

### The Events tab

During a debugging session, the **Events** tab of the **Diagnostic Tools** window lists the diagnostic events that occur. The category prefixes: **Breakpoint**, **File**, and others, let you quickly scan the list for a category, or skip the categories you don't care about.

Use the **Filter** dropdown to filter events in and out of view by selecting or deselecting specific categories of events.

![Diagnostic Event Filter](../profiling/media/diagnosticeventfilter.png "Diagnostic Event Filter")

Use the search box to find a specific string in the event list. Here are the results of a search for the string "name" that matched four events:

![Diagnostic Event Search](../profiling/media/diagnosticseventsearch.png "Diagnostic Event Search")

For more information, see [Searching and filtering the Events tab of the Diagnostic Tools window](https://devblogs.microsoft.com/devops/searching-and-filtering-the-events-tab-of-the-diagnostic-tools-window/).

## Collect profiling data without debugging

To collect performance data without debugging, you can run the **Performance Profiler** tools.

1. With a project open in Visual Studio, set the solution configuration to **Release** and select **Local Windows Debugger** (or **Local Machine**) as the deployment target.

1. Select **Debug** > **Performance Profiler**, or press **Alt**+**F2**.

1. On the diagnostic tools launch page, select one or more tools to run. Only the tools that are applicable to the project type, operating system, and programming language are displayed. Select **Show all tools** to also see tools that are disabled for this diagnostic session.

   ![Select the diagnostic tools](../profiling/media/diaghubsummarypage.png "DIAG_SelectTool")

1. To start the diagnostic session, select **Start**.

   While the session is running, some tools display graphs of real-time data on the diagnostic tools page as well as controls to pause and resume data collection.

    ![Collect data on the Performance and Diagnostic Hub](../profiling/media/diaghubcollectdata.png "Hub collect data")

1. To end the diagnostic session, select **Stop Collection**.

   The analyzed data displays on the **Report** page.

You can save the reports, and open them from the **Recently Opened Sessions** list on the diagnostic tools launch page.

![Open a saved diagnosis session file](../profiling/media/diaghubopenexistingdiagsession.png "PDHUB_OpenExistingDiagSession")

## Collecting profiling data with the command line

To measure performance data from the command line you can use VSDiagnostics.exe which is included with either Visual Studio or the Remote Tools. This is useful for capturing performance traces on systems where Visual Studio is not installed or for scripting the collection of performance traces. When you use VSDiagnostics.exe, you begin a diagnostic session that captures and stores profiling data until the tool is stopped, at which point that data is exported into a .diagsession file. Then you can open this file in Visual Studio to analyze results.

### Launching an application

1. Open a command prompt and change to the directory with VSDiagnostics.exe

```
**Visual Studio Install Folder**\Team Tools\DiagnosticsHub\Collector\
```

2. Start VSDiagnostics.exe with the following command:

```
VSDiagnostics.exe start **id** /launch:**appToLaunch** /loadConfig:**configFile**
```

The arguments that must be included are:

- **id** - Identifies the collection session. The ID must be a number between 1-255
- **appToLaunch** - The executable to launch and profile
- **configFile** - Configuration file for the collection agent you wish to launch. For more information, see Configuration files for agents.

3. To stop collection and view your results follow the steps under Stopping Collection.

### Attaching to an existing application

1. Open an application, such as Notepad, and then open Task Manager to get its process ID (PID). In Task Manager, find the PID in the Details tab.
2. Open a command prompt and change to the directory with the collection agent executable, typically here.

```
**Visual Studio installation folder**\2019\Preview\Team Tools\DiagnosticsHub\Collector\
```

3. Start VSDiagnostics.exe by typing the following command.

```
VSDiagnostics.exe start **id** /attach:**pid** /loadConfig:**configFile**
```

The arguments that must be included are:

- **id** - Identifies the collection session. The ID must be a number between 1-255.
- **pid** - PID of the process you wish to profile, in this case the PID you found in step 1.
- **configFile** - configuration file for the collection agent you wish to launch. For more information, see [Configuration files for agents](../profiling/profile-apps-from-command-line.md).

4. To stop collection and view your results follow the steps under Stopping Collection.

### Stopping collection

1. Stop the collection session and send output to a file by typing the following command.

```
VSDiagnostics.exe stop <id> /output:<path to file>
```

2. Go to the file output from the previous command, and open it in Visual Studio to examine the information collected.

## Agent configuration files

Collection Agents are interchangeable components that collect different types of data depending on what you are trying to measure.
For convenience, you can store that information in an agent configuration file. The configuration file is a .json file that contains at minimum the name of the .dll and its COM CLSID. Here are the example configuration files that you can find in the following folder:

```
<Visual Studio installation folder>\Team Tools\DiagnosticsHub\Collector\AgentConfigs\
```

- CpuUsage configurations (Base/High/Low), which corresponds to data collected for the [CPU Usage](../profiling/cpu-usage.md) profiling tool.
- DotNetObjectAlloc configurations (Base/Low), which corresponds to data collected for the [NET Object Allocation tool](../profiling/dotnet-alloc-tool.md).

Base/Low/High configurations refer to the sampling rate. For example, Low is 100 samples/second and High is 4000 samples/second.
For the VSDiagnostics.exe tool to work with a collection agent, it requires both a DLL and a COM CLSID for the appropriate agent, and the agent might have additional configuration options as well. If you use an agent without a configuration file, use the format in the following command:

```
VSDiagnostics.exe start <id> /attach:<pid> /loadAgent:<agentCLSID>;<agentName>[;<config>]
```

## See also

The following are blog posts and MSDN articles from the Diagnostics development team:
- [MSDN Magazine: Analyze Performance While Debugging in Visual Studio 2015](https://msdn.microsoft.com/magazine/dn973013.aspx)

- [MSDN Magazine: Use IntelliTrace to Diagnose Issues Faster](https://msdn.microsoft.com/magazine/dn973014.aspx)

- [Blog post: Diagnosing Event Handler Leaks with the Memory Usage Tool in Visual Studio 2015](https://devblogs.microsoft.com/devops/diagnosing-event-handler-leaks-with-the-memory-usage-tool-in-visual-studio-2015/)

- [Video: Historical Debugging with IntelliTrace in Microsoft Visual Studio Ultimate 2015](https://channel9.msdn.com/Events/Ignite/2015/BRK3716)

- [Video: Debugging Performance Issues Using Visual Studio 2015](https://channel9.msdn.com/Events/Build/2015/3-731)

- [PerfTips: Performance Information at-a-glance while Debugging with Visual Studio](https://devblogs.microsoft.com/devops/perftips-performance-information-at-a-glance-while-debugging-with-visual-studio/)

- [Diagnostic Tools debugger window in Visual Studio 2015](https://devblogs.microsoft.com/devops/diagnostic-tools-debugger-window-in-visual-studio-2015/)

- [IntelliTrace in Visual Studio Enterprise 2015](https://devblogs.microsoft.com/devops/intellitrace-in-visual-studio-ultimate-2015/)
