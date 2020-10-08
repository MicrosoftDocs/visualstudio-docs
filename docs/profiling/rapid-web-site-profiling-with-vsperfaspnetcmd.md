---
title: "Rapid Web Site Profiling with VSPerfASPNETCmd | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "proflilng tools,VSPerfASPNETCmd"
  - "VSPerfASPNETCmd"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# Rapid web site profiling with VSPerfASPNETCmd

The **VSPerfASPNETCmd** command-line tool enables you to easily profile [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web applications. In comparison to the [VSPerfCmd](../profiling/vsperfcmd.md) command line tool, options are reduced, no environment variables have to be set, and rebooting the computer is not required. Using **VSPerfASPNETCmd** is the preferred method for profiling with the standalone profiler. For more information, see [How to: Install the stand-alone profiler](../profiling/how-to-install-the-stand-alone-profiler.md).

> [!NOTE]
> Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. UWP apps also require new collection techniques. See [Performance tools on Windows 8 and Windows Server 2012 applications](../profiling/performance-tools-on-windows-8-and-windows-server-2012-applications.md).

 In some scenarios, such as collecting concurrency data or pausing and resuming profiling, using **VSPerfCmd** is the preferred profiling method.

> [!NOTE]
> To get the path to the profiling tools, see [Specify the path to command line tools](../profiling/specifying-the-path-to-profiling-tools-command-line-tools.md). On 64-bit computers, both 64-bit and 32-bit versions of the tools are available. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the Command Prompt window or add it to the command itself.

## Profile an ASP.NET application

To profile an [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application, type one of the commands described in the following sections. The Web site is started and the profiler starts to collect data. Exercise your application and then close the browser. To stop profiling, press the **Enter** key in the command prompt window.

> [!NOTE]
> By default, the command prompt does not return after a **vsperfaspnetcmd** command. You can use the **/nowait** option to force the command prompt to return. See [Use the /NoWait option](#use-the-nowait-option).

## To collect application statistics by using the sampling method
 Sampling is the default profiling method of **VSPerfASPNETCmd** tool and does not have to be specified on the command line. The following command line collects application statistics from the specified web application:

 **vsperfaspnetcmd**  *websiteUrl*

 An example of a local server-hosted *websiteUrl* might be *http://localhost/MySite/default.aspx*. An example of an external site is *http://www.contoso.com*. For more information, see the example URLs in [To profile a web site without opening a project in Visual Studio](how-to-collect-performance-data-for-a-web-site.md#to-profile-a-web-site-without-opening-a-project-in-visual-studio).

## To collect detailed timing data by using the instrumentation method

Use the following command line to collect detailed timing data from a dynamically compiled [!INCLUDE[vstecasp](../code-quality/includes/vstecasp_md.md)] web application:

**vsperfaspnetcmd /trace**  *websiteUrl*

If you want to profile statically compiled .*dll* files in your web application, you must instrument the files by using the [VSInstr](../profiling/vsinstr.md) command-line tool. The vsperfaspnetcmd /trace command will include data from the instrumented files.

## To collect .NET memory data

The **/Memory** option collects data about the allocation of objects in .NET memory and can collect data about the lifetime of those objects. Allocation data collection is the default mode of the **/Memory** data option and does not have to be specified on the command line.

 **vsperfaspnetcmd /memory** *websiteUrl*

 Use the **Lifetime** parameter to collect object lifetime data in addition to the allocation data:

 **vsperfaspnetcmd /memory:lifetime** *websiteUrl*

 You can also use the **/Trace** option to include detailed timing information with the .NET memory data:

 **vsperfaspnetcmd /memory**[**:lifetime**] **/trace**`websiteUrl`

## To collect tier interaction data

> [!WARNING]
> Tier interaction profiling (TIP) data can be collected using any edition of Visual Studio. However, tier interaction profiling data can be viewed only in Visual Studio Enterprise.
>
> To collect TIP data on Windows 8 or Windows Server 2012, you must use the instrumentation (**/trace**) option.

To collect tier interaction data with sampling data:

**vsperfaspnetcmd /tip** `websiteUrl`

To collect tier interaction data with instrumentation data:

**vsperfaspnetcmd /trace /tip** *websiteUrl*

To collect tier interaction data with .NET memory data:

**vsperfaspnetcmd /memory**[**:lifetime**] **/tip**_websiteUrl_

## Use the /NoWait option

By default, the command prompt does not return after a **vsperfaspnetcmd** command. You can use the following syntax option to force the command prompt to return. You can then perform other operations in the command prompt window. To end profiling, use the **/shutdown** option in a separate **vsperfaspnetcmd** command.

To begin profiling:

**vsperfaspnetcmd** [*/Options*] **/nowait**_websiteUrl_

To end profiling:

**vsperfaspnetcmd /shutdown** *websiteUrl*

## Additional options

You can add any of the following options to the commands listed earlier in this section, except the **vsperfaspnetcmd /shutdown** command.

|Option|Description|
|------------|-----------------|
|**/Output:** `VspFile`|By default, the profiling data (.*vsp*) file is created in the current directory with the file name **PerformanceReport.vsp**. Use the /output option to specify a different location, file name, or both.|
|**/PackSymbols:Off**|By default, VsPerfASPNETCmd embeds symbols (function and parameter names, and so on.) in the .*vsp* file. Embedding the symbols can make the profiling data file very large. If you will have access to the .*pdb* files that contain the symbols when you analyze the data, use the /packsymbols:off option to disable the embedding of the symbols.|
