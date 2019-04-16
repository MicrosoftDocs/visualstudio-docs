---
title: "Measure CPU usage from the command line"
description: "Measure CPU performance in your application from the command line."
ms.custom: ""
ms.date: "02/19/2019"
ms.topic: "conceptual"
helpviewer_keywords: 
  - "Profiling Tools, command-line"
  - "Diagnostics Tools, command-line"
  - "CPU Usage, command-line"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: '>= vs-2019'
ms.workload: 
  - "multiple"
---

# Measure application performance from the command line

You can collect performance information about an application by using command-line tools.

In the example described in this article, you collect performance information for Microsoft Notepad, but the same method can be used to profile any process.

## Prerequisites

* Visual Studio 2019 Preview 3 or later versions

* Familiarity with command-line tools

## Collect performance data

Profiling using the Visual Studio Diagnostics CLI tools works by attaching the profiling tool, along with one of the collector agents, to a process. When you attach the profiling tool, you begin a diagnostic session that captures and stores profiling data until the tool is stopped, at which point that data is exported into a *.diagsession* file. Then you can open this file in Visual Studio to analyze results.

1. Start Notepad, and then open Task Manager to get its process ID (PID). In Task Manager, find the PID in the **Details** tab.

1. Open a command prompt and change to the directory with the collection agent executable, typically here.

   ```<Visual Studio installation folder>\2019\Preview\Team Tools\DiagnosticsHub\Collector\```

1. Start *VSDiagnostics.exe* by typing the following command.

   ```cmd
   VSDiagnostics.exe start <id> /attach:<pid> /loadConfig:<configFile>
   ```

   The arguments that must be included are:

   * \<*id*> Identifies the collection session. The ID must be a number between 1-255.
   * \<*pid*>, PID of the process you wish to profile, in this case the PID you found in step 1
   * \<*configFile*>, configuration file for the collection agent you wish to launch. For more information, see [Configuration files for agents](#config_file).

1. Resize Notepad, or type something in it in order to make sure that some interesting profiling information is collected.

1. Stop the collection session and send output to a file by typing the following command.

   ```cmd
   VSDiagnostics.exe stop <id> /output:<path to file>
   ```

1. Go to the file output from the previous command, and open it in Visual Studio to examine the information collected.

## <a name="config_file"></a> Agent configuration files

Collection Agents are interchangeable components that collect different types of data depending on what you are trying to measure.

For convenience, you can store that information in an agent configuration file. The configuration file is a *.json* file that contains at minimum the name of the *.dll* and its COM CLSID. Here are the example configuration files that you can find in the following folder:

```<Visual Studio installation folder>\2019\Preview\Team Tools\DiagnosticsHub\Collector\AgentConfigs\```

* CpuUsage configurations (Base/High/Low), which corresponds to data collected for the [CPU Usage](../profiling/cpu-usage.md) profiling tool.
* DotNetObjectAlloc configurations (Base/Low), which corresponds to data collected for the [.NET Object Allocation tool](https://devblogs.microsoft.com/visualstudio/visual-studio-2017-version-15-8-preview-3/#tooling).

Base/Low/High configurations refer to the sampling rate. For example, Low is 100 samples/second and High is 4000 samples/second.

For the *VSDiagnostics.exe* tool to work with a collection agent, it requires both a DLL and a COM CLSID for the appropriate agent, and the agent might have additional configuration options as well. If you use an agent without a configuration file, use the format in the following command.

```cmd
VSDiagnostics.exe start <id> /attach:<pid> /loadAgent:<agentCLSID>;<agentName>[;<config>]
```

## Permissions

To profile an application that requires elevated permissions, you must do so from an elevated command prompt.
