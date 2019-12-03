---
title: "VSPerfASPNetCmd | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "profiling tools,VSPerfASPNETCmd"
  - "VSPerfASPNETCmd"
ms.assetid: f9e9f895-57bb-41e8-8bd1-cdaa738ec220
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# VSPerfASPNetCmd
The **VSPerfASPNetCmd.exe** command-line tool allows you to profile ASP.Net web sites without requiring that you set environment variables or restart your computer. Use **VSPerfASPNetCmd.exe** instead of [VSPerfCmd](../profiling/vsperfcmd.md) when you are profiling ASP.NET websites and you do not need the additional functionality provided by **VSPerfCmd**. For more information about **VSPerfASPNetCmd**, see [Rapid web site profiling with VSPerfASPNETCmd](../profiling/rapid-web-site-profiling-with-vsperfaspnetcmd.md). **VSPerfASPNetCmd** is the preferred command line tool to use when you are using the standalone profiler to profile an ASP.NET web site.

## Syntax
 **vsperfaspnetcmd** [/*Options*] *Website*

## Options

|Option|Description|
|------------|-----------------|
|**/Sample** or   **/s**|Profiles website by using the sampling method. **/Sample** is the default method. /Sample cannot be used with **/Trace**.|
|**/Trace** or   **/t**|Profiles website by using the instrumentation method. /Trace cannot be used with **/Sample**.|
|**/Memory**[**:**`Type`]or   **/m**[**:**{**a**&#124;**l**}]|Profiles memory allocation and optionally profiles object lifetimes (garbage collection). **/Memory** can be used with the sampling or the instrumentation method.<br /><br /> *Type* can be one of the following:<br /><br /> -   **allocation** (or **a**) collects memory allocation data only.<br />-   **lifetime** (or **l**) collects memory allocation and object lifetime data.<br /><br /> The default `Type` is **allocation**.|
|**/Tip** or   **/i**|Adds detailed ASP.NET request and ADO.NET call information to the profiling data. **/Tip** can be used with the sampling or the instrumentation method, and it can be used with the **/Memory** option.|
|**/Output:** `File` or   **/o:**`File`|Specifies the path and file name of the profiling data (.*vsp*) file.|
|**/NoWait** or   **/n**|Returns the command prompt immediately so that additional commands can be used in the command prompt window. You must type **VSPerfASPNETCmd /Shutdown** on a separate command line to turn profiling off.|
|**/PackSymbols**[:{**on**&#124;**off**}or   **/p**[:{**on**&#124;**off**}|Embeds symbols (function and parameter names, etc.) in profiling data (.*vsp*) file.|
|**/Shutdown:** `Website`or   **/d:**`Website`|Turns profiling off. Use as the only option on a command line after using the **/NoWait** option to start profiling, or if the profiler ends unexpectedly. Specify the same url that you used in the original **VSPerfASPNETCmd** command.|
|`Website`|The url of the website to be profiled.|

## See also
- [Rapid web site profiling with VSPerfASPNETCmd](../profiling/rapid-web-site-profiling-with-vsperfaspnetcmd.md)
- [Profile ASP.NET web applications](../profiling/command-line-profiling-of-aspnet-web-applications.md)
