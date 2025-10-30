---
title: "Concurrency visualizer command-line utility"
description: Use the command-line utility CVCollectionCmd.exe to collect traces that you can view in Concurrency Visualizer. You don't need to have Visual Studio installed.
ms.date: "11/04/2016"
ms.topic: article
f1_keywords:
  - "vs.cv.performance.cvcollectioncmd"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Concurrency Visualizer command-line utility (CVCollectionCmd)

You can use the Concurrency Visualizer command-line utility (*CVCollectionCmd.exe*) to collect traces from the command line so that you can view them in the Concurrency Visualizer for Visual Studio. The tools can be used on computers that do not have Visual Studio installed.

> [!NOTE]
> The Concurrency Visualizer is an optional extension. (Previously it had been included in Visual Studio.) You can download the [Concurrency Visualizer collection tools for Visual Studio](https://www.microsoft.com/download/details.aspx?id=49103) from the Download Center.

## Download the Concurrency Visualizer command-line utility
 To download and install the command-line utility, go to [Concurrency Visualizer Collection Tools for Visual Studio](https://www.microsoft.com/download/details.aspx?id=49103) and follow the instructions. By default, *CVCollectionCmd.exe* is installed in %ProgramFiles%\Microsoft Concurrency Visualizer Collection Tools\ (%ProgramFiles(x86)%\Microsoft Concurrency Visualizer Collection Tools\ on x64 computers).

## Collect a trace with CVCollectionCmd
 You can collect a trace by starting the app with CVCollectionCmd, or by attaching to it. See the command reference below for your options. For example

```cmd
<Path>CVCollectionCmd /launch c:\myapp\myapp.exe /outdir c:\myapp\data
```

## Commands and parameters
 To get help about the commands and parameters in the command-line utility, type this at the command prompt:

 **CvCollectionCmd /?**

|Option|Description|Parameters|Return values|
|------------|-----------------|----------------|-------------------|
|Query|Returns whether collection can be started.|None|0 if collection is ready to start.<br /><br /> 1  if collection is already in progress.<br /><br /> 2 if collection isn't in progress, but one or more of the required [ETW](/dotnet/framework/wcf/samples/etw-tracing) sessions is already enabled.|
|Launch|Runs the specified process under the Concurrency Visualizer.|The path of the executable.|0 if the run succeeded.<br /><br /> 1 if the run failed because the target application couldn't be started.<br /><br /> 13 if the run failed because CVCollectionCmd has insufficient permissions to write to the specified output directory.|
|Attach|Begins collecting a system-wide trace; otherwise, attaches to a process if one is specified.|None.|0 if attachment succeeded.<br /><br /> 1 if attachment failed because the specified process is invalid or ambiguous.<br /><br /> 13 if the attachment failed because CVCollectionCmd has insufficient permissions to write to the specified output directory.|
|Detach|Stops collection.|None.|0 if detachment succeeded.<br /><br /> 1 if detachment failed because collection is not currently in progress.<br /><br /> 2 if detachment failed because collection could not be stopped.|
|Analyze|Analyzes the specified trace.|The full path of the CVTrace file.|0 if analysis succeeded.<br /><br /> 1 if analysis cannot start because the specified trace was system-wide, but no target process was specified.<br /><br /> 2 if analysis cannot start because the trace was not system-wide and a process was specified.<br /><br /> 3  if analysis failed because the specified process is invalid.<br /><br /> 4 if analysis failed because the specified CVTrace file is invalid.|
|LaunchArgs|Specifies the target executable arguments. This option applies to the Launch command only.|The command-line arguments to the application.|None.|
|Outdir|Specifies the directory in which to save trace files. Applies to the Launch and Attach commands.|A directory path or relative path.|None.|
|Process|Specifies the process to attach to when the Attach command is executed, or the process in a trace to analyze when the Analyze command is executed. Applies to the Attach and Analyze commands.|The PID or the name of the process.|None.|
|Config|Specifies the path of the configuration file, if you want collection settings other than the defaults.   Applies to the Launch, Attach, and Analyze commands.|The directory path or relative path of the XML configuration file.|None.|

## Customize configuration settings
 If you use CVCollectionCmd to collect traces and you want to customize the collection settings, then use a configuration file to specify them.

> [!NOTE]
> When you use Visual Studio to collect traces, don't directly modify the configuration file.  Instead, use the [Advanced Settings](../profiling/advanced-settings-dialog-box-concurrency-visualizer.md) dialog box to modify settings.

 To modify collection settings, create a configuration file on the machine where you will run the CVCollectionCmd utility. You can create the configuration file from scratch, or you can copy the configuration file on the computer that has Visual Studio installed and modify that. The file is named *UserConfig.xml* and is located in the *Local AppData* folder. When you run the utility, use the Config option in conjunction with the Launch, Attach, or Analyze command.  In the parameter that's associated with the Config option, specify the path of the configuration file.

### Configuration file tags
 The configuration file is XML-based. Here are the valid tags and values:

| Tag | Description | Values |
|-------------------------| - | - |
| Config | Demarcates the overall config file. | Must contain these elements:<br /><br /> -   MinorVersion<br />-   MajorVersion |
| MajorVersion | Specifies the major version of the config file. | Must be 1 for most Visual Studio projects. If not 1, the utility will not work. |
| MinorVersion | Specifies the minor version of the config file. | Must be 0 for most Visual Studio projects. If not 0, the utility will not work. |
| IncludeEnvSymbolPath | Sets a value that determines whether the environment symbol path (_NT_SYMBOL_PATH) is used. | -   True<br />-   False |
| DeleteEtlsAfterAnalysis | Sets a value that determines whether the ETL files are deleted when analysis completes. | -   True<br />-   False |
| SymbolPath | Specifies the path of the symbol server. For more information, see [Use the Microsoft Symbol Server to obtain debug symbol files](/windows/win32/dxtecharts/debugging-with-symbols). | A directory name or URL. |
| Markers | Contains the list of marker providers. | May contain zero or more MarkerProvider elements. |
| MarkerProvider | Specifies a single marker provider. | Must contain these elements:<br /><br /> -   Level<br />-   GUID<br />-   Name<br /><br /> Can contain these elements:<br /><br /> -   Categories<br />-   IsEnabled |
| Level | Sets the importance level of a MarkerProvider. | -   Low<br />-   Normal<br />-   High<br />-   Critical<br />-   Everything |
| Guid | The globally unique identifier of the ETW marker provider. | A GUID. |
| Name | Specifies the description of the marker provider. | A string. |
| Categories | Specifies the categories collected for the marker provider. | A comma-delimited string of numbers or ranges of numbers. |
| IsEnabled | Sets a value that determines whether the marker provider is enabled for collection. | -   True<br />-   False |
| FilterConfig | Specifies the list of configuration options of the ETW events that are filtered from collection. | May contain these elements:<br /><br /> -   CollectClrEvents<br />-   ClrCollectionOptions<br />-   CollectSampleEvents<br />-   CollectGpuEvents<br />-   CollectFileIO |
| CollectClrEvents | Set a value that determines whether CLR events are collected. | -   True<br />-   False |
| ClrCollectionOptions | Specifies whether to collect CLR events for native apps, and whether to collect NGEN rundown events. | May contain one, both, or none of these values:<br /><br /> -   CollectForNative<br />-   DisableNGenRundown |
| CollectSampleEvents | Sets a value that determines whether sample events are collected. | -   True<br />-   False |
| CollectGpuEvents | Sets a value that determines whether the events generated by DX are collected. | -   True<br />-   False |
| CollectFileIO | Sets a value that determines whether file I/O events are collected. | -   True<br />-   False |
| UserBufferSettings | Specifies the list of user buffer-settings parameters. | Must contain these elements:<br /><br /> -   BufferFlushTimer<br />-   BufferSize<br />-   MinimumBuffers<br />-   MaximumBuffers |
| KernelBufferSettings | Specifies the list of kernel buffer-settings parameters. | Must contain these elements:<br /><br /> -   BufferFlushTimer<br />-   BufferSize<br />-   MinimumBuffers<br />-   MaximumBuffers |
| BufferFlushTimer | Specifies the flush timer of the ETW buffers. | A positive integer. |
| BufferSize | Amount of memory that's allocated for each event-tracing session buffer, in kilobytes. | A number from 0 to 1024. |
| MinimumBuffers | The minimum number of buffers that are allocated for the buffer pool of the event-tracing session. | A positive integer greater than or equal to twice the number of logical cores. |
| MaximumBuffers | Maximum number of buffers that are allocated for the buffer pool of the event-tracing session. | A number greater than or equal to MinimumBuffers. |
| JustMyCode | Specifies the list of Just My Code directories. | A list of zero or more MyCodeDirectory elements. |
| MyCodeDirectory | Specifies a directory that contains your code. | An absolute path. |

### Example
 Instead of creating a configuration file from the beginning, you can copy the following example and then modify it to meet your requirements.

```xml
<?xml version="1.0"?>
<LocalConfig xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" MajorVersion="1" MinorVersion="0">

  <IncludeEnvSymbolPath>true</IncludeEnvSymbolPath>

  <DeleteEtlsAfterAnalysis>true</DeleteEtlsAfterAnalysis>

  <TraceLocation>C:\traces</TraceLocation>

  <SymbolPath>http://symweb</SymbolPath>

  <Markers>
    <MarkerProvider Name="Default" Guid="8d4925ab-505a-483b-a7e0-6f824a07a6f0" Level="Low" />
    <MarkerProvider Name="TPL" Guid="2e5dba47-a3d2-4d16-8ee0-6671ffdcd7b5" Level="Normal" />
    <MarkerProvider Name="TPL Dataflow" Guid="16f53577-e41d-43d4-b47e-c17025bf4025" Level="Normal" />
    <MarkerProvider Name="TPL Synchronization" Guid="ec631d38-466b-4290-9306-834971ba0217" Level="Normal" />
    <MarkerProvider Name="PLINQ" Guid="159eeeec-4a14-4418-a8fe-faabcd987887" Level="Normal" />
    <MarkerProvider Name="Concurrency Runtime" Guid="f7b697a3-4db5-4d3b-be71-c4d284e6592f" Level="Normal" />
    <MarkerProvider Name="Scenario Markers" Guid="fb9244c9-f23a-4966-8a9c-97a51f8c355b" Level="Low" />

    <!-- The IsEnabled and Categories elements are optional -->
    <MarkerProvider Name="myMarker1" Guid="d0dbb3a3-895c-4ce6-96d9-28f69d664dc3" Level="Critical" IsEnabled="false" Categories="0,1,3-5,8" />
    <MarkerProvider Name="myMarker2" Guid="03452127-a617-4302-9e30-c0d10442e4ee" Level="Low" IsEnabled="false" Categories="0,1,3-5,8-10,11-13" />
  </Markers>

  <FilterConfig>
    <CollectClrEvents>true</CollectClrEvents>
    <ClrCollectionOptions>CollectForNative DisableNGenRundown</ClrCollectionOptions>
    <CollectSampleEvents>true</CollectSampleEvents>
    <CollectGpuEvents>true</CollectGpuEvents>
    <CollectFileIO>true</CollectFileIO>
  </FilterConfig>

  <UserBufferSettings>
    <BufferFlushTimer>0</BufferFlushTimer>
    <BufferSize>256</BufferSize>
    <MinimumBuffers>512</MinimumBuffers>
    <MaximumBuffers>1024</MaximumBuffers>
  </UserBufferSettings>

  <KernelBufferSettings>
    <BufferFlushTimer>0</BufferFlushTimer>
    <BufferSize>256</BufferSize>
    <MinimumBuffers>512</MinimumBuffers>
    <MaximumBuffers>1024</MaximumBuffers>
  </KernelBufferSettings>

  <!-- List of MyCodeDirectory directories -->
  <JustMyCode>
    <MyCodeDirectory>C:\myBinaries1</MyCodeDirectory>
    <MyCodeDirectory>C:\myBinaries2</MyCodeDirectory>
  </JustMyCode>
</LocalConfig>

```
