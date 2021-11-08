---
title: "Measure performance from the command line"
description: "Measure CPU performance and managed memory usage in your application from the command line."
ms.date: 9/13/2021
ms.topic: conceptual
helpviewer_keywords: 
  - "Profiling Tools, command-line"
  - "Diagnostics Tools, command-line"
  - "CPU Usage, command-line"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: '>= vs-2019'
ms.workload: 
  - "multiple"
---

# Measure application performance from the command line

You can collect performance information about an application by using command-line tools.

In the example described in this article, you collect performance information for Microsoft Notepad, but the same method can be used to profile any process.

## Prerequisites

* Visual Studio 2019 or later versions

* Familiarity with command-line tools

* To collect performance information on a remote machine without Visual Studio installed, install the [Remote Tools for Visual Studio](https://visualstudio.microsoft.com/downloads#remote-tools-for-visual-studio-2019) on the remote machine. The version of the tools must match your version of Visual Studio.

## Collect performance data

Profiling using the Visual Studio Diagnostics CLI tools works by attaching the profiling tool, along with one of the collector agents, to a process. When you attach the profiling tool, you begin a diagnostic session that captures and stores profiling data until the tool is stopped, at which point that data is exported into a *.diagsession* file. Then you can open this file in Visual Studio to analyze results.

1. Start Notepad, and then open Task Manager to get its process ID (PID). In Task Manager, find the PID in the **Details** tab.

1. Open a command prompt and change to the directory with the collection agent executable, typically here (for Visual Studio Enterprise).

   ::: moniker range=">= vs-2022"
   ```<Visual Studio installation folder>\2022\Enterprise\Team Tools\DiagnosticsHub\Collector\```
   ::: moniker-end
   ::: moniker range="vs-2019"
   ```<Visual Studio installation folder>\2019\Enterprise\Team Tools\DiagnosticsHub\Collector\```
   ::: moniker-end

1. Start *VSDiagnostics.exe* by typing the following command.

   ```cmd
   VSDiagnostics.exe start <id> /attach:<pid> /loadConfig:<configFile>
   ```

   The arguments that must be included are:

   * \<*id*> Identifies the collection session. The ID must be a number between 1-255.
   * \<*pid*>, PID of the process you wish to profile, in this case the PID you found in step 1.
   * \<*configFile*>, configuration file for the collection agent you wish to launch. For more information, see [Configuration files for agents](#config_file).

   For example, you could use the following command for the CPUUsageBase agent by replacing the *pid* as described previously.

   ```cmd
   VSDiagnostics.exe start 1 /attach:<pid> /loadConfig:AgentConfigs\CPUUsageLow.json
   ```

1. Resize Notepad, or type something in it in order to make sure that some interesting profiling information is collected.

1. Stop the collection session and send output to a file by typing the following command.

   ```cmd
   VSDiagnostics.exe stop <id> /output:<path to file>
   ```

1. Locate the *.diagsession* file output from the previous command, and open it in Visual Studio (**File** > **Open**) to examine the information collected.

   To analyze the results, see the documentation for the corresponding performance tool. For example, this might be the [CPU Usage](../profiling/cpu-usage.md), [.NET Object Allocation tool](../profiling/dotnet-alloc-tool.md), or the [Database](../profiling/analyze-database.md) tool.

## <a name="config_file"></a> Agent configuration files

Collection Agents are interchangeable components that collect different types of data depending on what you are trying to measure.

For convenience, we recommend that you store that information in an agent configuration file. The configuration file is a *.json* file that contains at minimum the name of the *.dll* and its COM CLSID. Here are the example configuration files that you can find in the following folder:

```<Visual Studio installation folder>Team Tools\DiagnosticsHub\Collector\AgentConfigs\```

Please see the following links to download and view agent configuration files:

- https://aka.ms/vs/diaghub/agentconfig/cpubase
- https://aka.ms/vs/diaghub/agentconfig/cpuhigh
- https://aka.ms/vs/diaghub/agentconfig/cpulow
- https://aka.ms/vs/diaghub/agentconfig/database
- https://aka.ms/vs/diaghub/agentconfig/dotnetasyncbase
- https://aka.ms/vs/diaghub/agentconfig/dotnetallocbase
- https://aka.ms/vs/diaghub/agentconfig/dotnetalloclow
- https://aka.ms/vs/diaghub/agentconfig/dotnetcountersbase

CpuUsage configurations (Base/High/Low) correspond to data collected for the [CPU Usage](../profiling/cpu-usage.md) profiling tool.
DotNetObjectAlloc configurations (Base/Low) correspond to data collected for the [.NET Object Allocation tool](../profiling/dotnet-alloc-tool.md).

Base/Low/High configurations refer to the sampling rate. For example, Low is 100 samples/second and High is 4000 samples/second.

For the *VSDiagnostics.exe* tool to work with a collection agent, it requires both a DLL and a COM CLSID for the appropriate agent. The agent might have additional configuration options as well, which would be any options that are specified in the config file, formatted as properly escaped JSON.

## Permissions

To profile an application that requires elevated permissions, you must do so from an elevated command prompt.
