---
title: "Rapid Web Site Profiling with VSPerfASPNETCmd"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9a9d62a6-549a-45ac-a948-76eb98586ac5
caps.latest.revision: 16
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Rapid Web Site Profiling with VSPerfASPNETCmd
The **VSPerfASPNETCmd** command line tool enables you to easily profile ASP.NET Web applications. In comparison to the [VSPerfCmd](../VS_IDE/VSPerfCmd.md) command line tool, options are reduced, no environment variables have to be set, and rebooting the computer is not required. Using **VSPerfASPNETCmd** is the preferred method for profiling with the standalone profiler. For more information, see [How to: Install the Stand-Alone Profiler](../VS_IDE/How-to--Install-the-Stand-Alone-Profiler.md).  
  
> [!NOTE]
>  Enhanced security features in Windows 8 and Windows Server 2012 required significant changes in the way the Visual Studio profiler collects data on these platforms. Windows Store apps also require new collection techniques. See [Performance Tools on Windows 8 and Windows Server 2012 applications](../VS_IDE/Performance-Tools-on-Windows-8-and-Windows-Server-2012-applications.md).  
  
 In some scenarios, such as collecting concurrency data or pausing and resuming profiling, using **VSPerfCmd** is the preferred profiling method.  
  
> [!NOTE]
>  Command-line tools of the Profiling Tools are located in the \Team Tools\Performance Tools subdirectory of the Visual Studio installation directory. On 64 bit computers,, use the VSPerfASPNETCmd tool located in the 32 bit \Team Tools\Performance Tools directory. To use the profiler command-line tools, you must add the tools path to the PATH environment variable of the command prompt window or add it to the command itself. For more information, see [Specifying the Path to Command Line Tools](../VS_IDE/Specifying-the-Path-to-Profiling-Tools-Command-Line-Tools.md).  
  
## Profiling an ASP.NET Application  
 To profile an ASP.NET Web application, type one of the commands described in the following sections. The Web site is started and the profiler starts to collect data. Exercise your application and then close the browser. To stop profiling, press the Enter key in the command prompt window.  
  
> [!NOTE]
>  By default, the command prompt does not return after a **vsperfaspnetcmd** command. You can use the **/nowait** option to force the command prompt to return. See [Using the /NoWait option](#UsingNoWait).  
  
## To collect application statistics by using the sampling method  
 Sampling is the default profiling method of **VSPerfASPNETCmd** tool and does not have to be specified on the command line. The following command line collects application statistics from the specified Web application:  
  
 **vsperfaspnetcmd**  *websiteUrl*  
  
## To collect detailed timing data by using the instrumentation method  
 Use the following command line to collect detailed timing data from a dynamically compiled ASP.NET Web application:  
  
 **vsperfaspnetcmd /trace**  *websiteUrl*  
  
 If you want to profile statically compiled .dll files in your Web application, you must instrument the files by using the [VSInstr](../VS_IDE/VSInstr.md) command-line tool. The vsperfaspnetcmd /trace command will include data from the instrumented files.  
  
## To collect .NET memory data  
 The **/Memory** option collects data about the allocation of objects in .NET memory and can collect data about the lifetime of those objects. Allocation data collection is the default mode of the **/Memory** data option and does not have to be specified on the command line.  
  
 **vsperfaspnetcmd /memory** *websiteUrl*  
  
 Use the **Lifetime** parameter to collect object lifetime data in addition to the allocation data:  
  
 **vsperfaspnetcmd /memory:lifetime** *websiteUrl*  
  
 You can also use the **/Trace** option to include detailed timing information with the .NET memory data:  
  
 **vsperfaspnetcmd /memory**[**:lifetime**] **/trace**`websiteUrl`  
  
## To collect tier interaction data  
  
> [!WARNING]
>  Tier interaction profiling (TIP) data can be collected using Visual Studio Ultimate, Visual Studio Premium, or Visual Studio Professional. However, tier interaction profiling data can be viewed only in Visual Studio Ultimate and Visual Studio Premium.  
>   
>  To collect TIP data on Windows 8 or Windows Server 2012, you must use the the instrumentation (**/trace**) option.  
  
 To collect tier interaction data with sampling data:  
  
 **vsperfaspnetcmd /tip** `websiteUrl`  
  
 To collect tier interaction data with instrumentation data:  
  
 **vsperfaspnetcmd /trace /tip** *websiteUrl*  
  
 To collect tier interaction data with .NET memory data:  
  
 **vsperfaspnetcmd /memory**[**:lifetime**] **/tip***websiteUrl*  
  
##  <a name="UsingNoWait"></a> Using the /NoWait option  
 By default, the command prompt does not return after a **vsperfaspnetcmd** command. You can use the following syntax option to force the command prompt to return. You can then perform other operations in the command prompt window. To end profiling, use the **/shutdown** option in a separate **vsperfaspnetcmd** command.  
  
 To begin profiling:  
  
 **vsperfaspnetcmd** [*/Options*] **/nowait***websiteUrl*  
  
 To end profiling:  
  
 **vsperfaspnetcmd /shutdown** *websiteUrl*  
  
## Additional Options  
 You can add any of the following options to the commands listed earlier in this section, except the **vsperfaspnetcmd /shutdown** command.  
  
|Option|Description|  
|------------|-----------------|  
|**/Output:** `VspFile`|By default, the profiling data (.vsp) file is created in the current directory with the file name **PerformanceReport.vsp**. Use the /output option to specify a different location, file name, or both.|  
|**/PackSymbols:Off**|By default, VsPerfASPNETCmd embeds symbols (function and parameter names, etc) in the .vsp file. Embedding the symbols can make the profiling data file very large. If you will have access to the .pdb files that contain the symbols when you analyze the data, use the /packsymbols:off option to disable the embedding of the symbols.|