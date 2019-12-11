---
title: "Attach the profiler to an ASP.NET app to collect memory data"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: d608f85a-41ae-4ca7-85e6-b96624dbc83c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "aspnet"
---
# How to: Attach the profiler to an ASP.NET web application to collect memory data by using the command line
This article describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to attach the profiler to a [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web application and collect data about the number and size of .NET Framework memory allocations. You can also collect data about the lifetime of .NET Framework memory objects.

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

 To collect performance data from a [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web application, you must use the [VSPerfCLREnv.cmd](../profiling/vsperfclrenv.md) tool to initialize the appropriate environment variables on the computer that hosts the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web application. You must then restart the computer to configure the Web server for profiling.

 You then use the [VSPerfCmd.exe](../profiling/vsperfcmd.md) tool to attach the profiler to the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process that hosts your Web site. When the profiler is attached to the application, you can pause and resume data collection.

 To end a profiling session, the profiler must no longer be attached to the application and the profiler must be explicitly shut down. In most cases, we recommend clearing the profiling environment variables at the end of a session.

## Attach the profiler

#### To attach the profiler to an ASP.NET web application

1. Open a Command Prompt window.

2. Initialize the profiling environment variables. Type:

    **VSPerfClrEnv** {**/globalsamplegc** &#124; **/globalsamplegclife**} [**/samplelineoff**]

   - The options **/globalsamplegc** and **/globalsamplegclife** specify the type of memory data to collect.

        Specify one and only one of the following options.

       |Option|Description|
       |------------|-----------------|
       |**/globalsamplegc**|Enables the collection of memory allocation data.|
       |**/globalsamplegclife**|Enables the collection of both memory allocation data and object lifetime data.|

   - The option **/samplelineoff** disables the assignment of collected data to specific source code lines. If this option is specified, data is assigned at the function level.

3. Restart the computer to set the new environment configuration.

4. Open a Command Prompt window. If necessary, set the profiler path enviroment variable.

5. Start the profiler. Type:

    **VSPerfCmd**  [/start](../profiling/start.md) **:sample**  [/output](../profiling/output.md) **:** `OutputFile` [`Options`]

   - The **/start:sample** option initializes the profiler.

   - The **/output:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.vsp) file.

     You can use any of the following options with the **/start:sample** option.

   > [!NOTE]
   > The **/user** and **/crosssession** options are usually required for ASP.NET applications.

   | Option | Description |
   | - | - |
   | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName` | Specifies the domain and user name of the account that owns the ASP.NET worker process. This option is required if the process is running as a user other than the logged-on user. The process owner is listed in the User Name column on the Processes tab of Windows Task Manager. |
   | [/crosssession](../profiling/crosssession.md) | Enables profiling of processes in other logon sessions. This option is required if the ASP.NET application is running in a different session. The session idenitifier is listed in the Session ID column on the Processes tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**. |
   | [/waitstart](../profiling/waitstart.md) [**:**`Interval`] | Specifies the number of seconds to wait for the profiler to initialize before it returns an error. If `Interval` is not specified, the profiler waits indefinitely. By default, **/start** returns immediately. |
   | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
   | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms. |
   | [/events](../profiling/events-vsperfcmd.md) **:** `Config` | Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.etl) file. |

6. Start the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web application in the typical way.

7. Attach the profiler to the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process. Type:

    **VSPerfCmd**  [/attach](../profiling/attach.md) **:**{`PID`&#124;`ProcName`} [[/targetclr](../profiling/targetclr.md)**:**`Version`]

   - The process ID `(PID)` specifies the process ID or the process name of the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process. You can view the process IDs of all running processes in Windows Task Manager.

   - **/targetclr:** `Version` specifies the version of the common language runtime (CLR) to profile when more than one version of the runtime is loaded in an application.

## Control data collection
 While the application is running, you can control data collection by starting and stopping the writing of data to the profiler data file by using **VSPerfCmd.exe** options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.

#### To start and stop data collection

- The following pairs of **VSPerfCmd** options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the `PID`.|
    |**/attach:**{`PID`&#124;`ProcName`} [/detach](../profiling/detach.md)[**:**{`PID`&#124;:`ProcName`}]|**/attach** starts to collect data for the process that is specified by the process ID or process name. **/detach** stops data collection for the specified process or for all processes if a specific process is not specified.|

## End the profiling session
 To end a profiling session, the profiler must be detached from the Web application. You can stop the collection of data from an application that is profiled with the sampling method by restarting the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process or by calling the **VSPerfCmd /detach** option. You then call the **VSPerfCmd** [/shutdown](../profiling/shutdown.md) option to turn off the profiler and close the profiling data file. The **VSPerfClrEnv /globaloff** command clears the profiling environment variables, but the system configuration is not reset until the computer is restarted.

#### To end a profiling session

1. Perform one of the following steps to detach the profiler from the target application:

   - Type **VSPerfCmd** [/detach](../profiling/detach.md)

      -or-

   - Close the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process. Type:

     **IISReset /stop**

2. Shut down the profiler. Type:

    **VSPerfCmd /shutdown**

3. (Optional) Clear the profiling environment variables. Type:

    **VSPerfCmd /globaloff**

4. Restart the computer. If necessary, restart Internet Information Services (IIS). Type:

    **IISReset /start**

## See also
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [.NET memory data views](../profiling/dotnet-memory-data-views.md)
