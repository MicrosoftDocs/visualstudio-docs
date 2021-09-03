---
title: Profiler command line - Instrument dynamic ASP.NET app, get memory data
description: Learn how to use the Visual Studio Profiling Tools command-line tools to collect detailed memory activity data for a dynamically compiled ASP.NET application.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: 2cdd9903-39db-47e8-93dd-5e6a21bc3435
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: 'vs-2017'
ms.workload: 
  - aspnet
---
# How to: Instrument a dynamically compiled ASP.NET web application and collect memory data by using the profiler command line
This topic describes how to use [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] Profiling Tools command-line tools to collect detailed .NET memory allocation and object lifetime data for a dynamically compiled [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application by using the instrumentation profiling method.

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

 To collect performance data from a [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application, you modify the *web.config* file of the target application to enable the [VSInstr.exe](../profiling/vsinstr.md) tool to instrument the dynamically compiled application files. You then use the [VSPerfCLREnv.cmd](../profiling/vsperfclrenv.md) tool to configure the server that hosts the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] Web application and enable .NET memory profiling by setting the appropriate environment variables, and then restart the computer.

 To collect data, start the profiler and then run the target application. While the profiler is attached to the application, you can pause and resume data collection.When you have collected the appropriate data, close the application, close the Internet Information Services (IIS) worker process, and then shut down the profiler.

 When you have completed your profiling work, restore the *web.config* file and the web server to their original states.

## Configure the ASP.NET web application and the web server

#### To configure the ASP.NET web application and the web server

1. Modify the *web.config* file of the target application. See [How to: Modify web.config files to instrument and profile dynamically compiled ASP.NET web applications](../profiling/how-to-modify-web-config-files-to-instrument-dynamically-compiled-aspnet-apps.md).

2. Open a command prompt window on the computer that hosts the web application.

3. Initialize the profiling environment variables. Type:

     **VSPerfClrEnv /globaltracegc**

     -or-

     **VSPerfClrEnv /globaltracegclife**

    - **/globaltracegc** enables the collection of memory allocation data.

    - **/globaltracegclife** enables the collection of memory allocation data and object lifetime data.

4. Restart the computer.

## Run the profiling session

#### To profile the ASP.NET web application

1. Start the profiler. Type:

    **VSPerfCmd** [/start](../profiling/start.md) **:trace** [/output](../profiling/output.md) **:** `OutputFile` [`Options`]

   - The **/start:trace** option initializes the profiler.

   - The **/output:**`OutputFile` option is required with **/start**. `OutputFile` specifies the name and location of the profiling data (.*vsp*) file.

     You can use any of the following options with the **/start:trace** option.

   > [!NOTE]
   > The **/user** and **/crosssession** options are usually required for ASP.NET applications.

   | Option | Description |
   | - | - |
   | [/user](../profiling/user-vsperfcmd.md) **:**[`Domain`**\\**]`UserName` | Specifies the optional domain and user name of the account that owns the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process. This option is required if the process is running as a user other than the logged on user. The name is listed in the **User Name** column on the **Processes** tab of Windows Task Manager. |
   | [/crosssession](../profiling/crosssession.md) | Enables profiling of processes in other sessions. This option is required if the application is running in a different session. The session ID is listed in the **Session ID** column on the **Processes** tab of Windows Task Manager. **/CS** can be specified as an abbreviation for **/crosssession**. |
   | [/globaloff](../profiling/globalon-and-globaloff.md) | Starts the profiler with data collection paused. Use [/globalon](../profiling/globalon-and-globaloff.md) to resume profiling. |
   | [/counter](../profiling/counter.md) **:** `Config` | Collects information from the processor performance counter specified in `Config`. Counter information is added to the data collected at each profiling event. |
   | [/wincounter](../profiling/wincounter.md) **:** `WinCounterPath` | Specifies a Windows performance counter to be collected during profiling. |
   | [/automark](../profiling/automark.md) **:** `Interval` | Use with **/wincounter** only. Specifies the number of milliseconds between Windows performance counter collection events. Default is 500 ms. |
   | [/events](../profiling/events-vsperfcmd.md) **:** `Config` | Specifies an Event Tracing for Windows (ETW) event to be collected during profiling. ETW events are collected in a separate (.*etl*) file. |

2. Start the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application in the typical way.

## Control data collection
 While the target application is running, you can control data collection by starting and stopping the writing of data to the profiler data file by using *VSPerfCmd.exe* options. Controlling data collection enables you to collect data for a specific part of program execution, such as starting or shutting down the application.

#### To start and stop data collection

- The following pairs of options start and stop data collection. Specify each option on a separate command line. You can turn data collection on and off multiple times.

    |Option|Description|
    |------------|-----------------|
    |[/globalon /globaloff](../profiling/globalon-and-globaloff.md)|Starts (**/globalon**) or stops (**/globaloff**) data collection for all processes.|
    |[/processon](../profiling/processon-and-processoff.md) **:** `PID` [/processoff](../profiling/processon-and-processoff.md) **:** `PID`|Starts (**/processon**) or stops (**/processoff**) data collection for the process specified by the process ID (`PID`).|
    |[/threadon](../profiling/threadon-and-threadoff.md) **:** `TID` [/threadoff](../profiling/threadon-and-threadoff.md) **:** `TID`|Starts (**/threadon**) or stops (**/threadoff**) data collection for the thread specified by the thread ID (`TID`).|

- You can also use the **VSPerfCmd.exe**[/mark](../profiling/mark.md) option to insert a profiling mark into the data file. The **/mark** command adds an identifier, a timestamp, and an optional user-defined text string. Marks can be used to filter the data in profiler reports and data views.

## End the profiling session
 To end a profiling session, close the target [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application, stop Internet Information Services (IIS) to stop the profiled process, and then shut down the profiler. Then restart IIS.

#### To end a profiling session

1. Close the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application.

2. Close the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] worker process by resetting Internet Information Services (IIS). Type:

    **IISReset /stop**

3. Shut down the profiler. Type:

    **VSPerfCmd** [/shutdown](../profiling/shutdown.md)

4. Restart IIS. Type:

    **IISReset /start**

## Restore the application and computer configuration
 When you have completed all profiling, replace the *web.config* file, clear the profiling environment variables, and restart the computer to restore the server and the [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] application to their original states.

#### To restore the application and computer configuration

1. Replace the *web.config* file with a copy of the original file.

2. (Optional). Clear the profiling environment variables. Type:

     **VSPerfCmd /globaloff**

3. Restart the computer.

## See also
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
- [.NET memory data views](../profiling/dotnet-memory-data-views.md)
