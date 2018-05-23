---
title: Collection and storage of error diagnostic data
ms.date: 05/24/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
author: gewarren
ms.author: michma
manager: douge
ms.workload:
  - "multiple"
---
# Diagnostic information collected by Visual Studio

Visual Studio collects error diagnostic information to fix problems and improve the quality of the product through the [Visual Studio Experience Improvement Program](visual-studio-experience-improvement-program.md). This article provides some information about the types of data we collect and how it's stored. It also provides tips on how extension authors can avoid inadvertent disclosure of personal or sensitive information.

## Types of collected data

Visual Studio collects diagnostic data for crashes, hangs, UI unresponsiveness, and high CPU or memory usage. We also collect information about errors encountered during product installation or usage. The collected data varies based on the error encountered. Some examples of the data we collect are the following:

- For high CPU usage and unresponsiveness, stack traces of relevant Visual Studio threads are collected.

- For cases where stack traces of some threads aren't enough to determine the root cause of the issue, for example, crashes, hangs or high memory usage, we collect a memory *dump*. The dump represents the state of the process when the error occurred.

- For unexpected error conditions, for example, an exception while trying to write to a file on disk, we collect information about the exception. The information includes the name of the exception, the stack trace of the thread where the exception occurred, the message associated with the exception, and other information relevant to the specific exception.

   The following example of collected data shows an exception name, stack trace, and exception message:

   "Reserved.DataModel.Fault.Exception.TypeString": "System.IO.IOException",
   "Reserved.DataModel.Fault.Exception.StackTrace": "System.IO.\__Error.WinIOError(Int32,String)\r\n
   System.IO.FileStream.Init(String,FileMode,FileAccess,Int32,Boolean,FileShare,Int32,FileOptions,SECURITY_ATTRIBUTES,String,Boolean,Boolean,Boolean)\r\n
   System.IO.FileStream..ctor(String,FileMode,FileAccess,FileShare,Int32,FileOptions,String,Boolean,Boolean,Boolean)\r\nSystem.IO.StreamWriter.CreateFile(String,Boolean,Boolean)\r\n
   System.IO.StreamWriter..ctor(String,Boolean,Encoding,Int32,Boolean)\r\n
   System.IO.StreamWriter..ctor(String,Boolean)\r\n
   System.IO.File.CreateText(String)\r\n
   Microsoft.VisualStudio.Setup.Services.FileSystem.CreateText(String,Boolean)\r\n
   Microsoft.VisualStudio.Setup.Cache.ChannelManifestRepository.WriteChannelManifest(IChannelManifest,String,String)\r\n
   Microsoft.VisualStudio.Setup.Cache.ChannelManifestRepository.AddChannel(ChannelManifestPair,Boolean)\r\n
   Microsoft.VisualStudio.Setup.Cache.CacheManager.AddChannel(ChannelManifestPair,Boolean)\r\n
   Microsoft.VisualStudio.Setup.ChannelManager.\<UpdateAsync>d__37.MoveNext()\r\n”,
   "Reserved.DataModel.Fault.Exception.Message": " The process cannot access the file 'C:\\Users\\[UserName]\\AppData\\Local\\Microsoft\\VisualStudio\\Packages\\\_Channels\\4CB340F5\\channelManifest.json' because it is being used by another process."

## How we use diagnostic data

The workflow to determine the root cause of an error varies depending on the type of error and its severity.

### Error classification

Based on the collected data, errors are classified and counted to prioritize their investigation. For example, we may discover that “System.IO.\__Error.WinIOError” at “System.IO.FileStream.Init” has occurred 500 times in version \<x> of the product, and has the highest rate of occurrence in that version.

### Logging of work items

Work items for individual, prioritized errors are created and assigned to engineers for investigation. These work items typically contain the classification, priority, and diagnostic information relevant to the type of error. This information is derived from the collected diagnostic data for the error. For example, a work item for a crash might contain the stack trace where the crash is occurring.

### Error investigation

Engineers use the information available in the work item to determine the root cause of an error. In some cases, they need more information than what's present in the work item, in which case they refer to the original diagnostic data that was collected. For example, to understand a product crash an engineer might need to investigate the memory dump collected for that crash.

## Access and retention of diagnostic data

The error diagnostic data collected from customer machines is treated with utmost care, and we restrict access to it. For example, the data might only be accessible to engineers in the organizational group relevant to the product being investigated. The data is not shared with anyone outside of Microsoft.

Investigating and fixing errors can take from days to months, depending on their complexity. Regardless of that, the most sensitive data is retained for a short length of time. For example, memory dumps are typically retained for thirty days or less. Less sensitive data that only contains information related to the error condition is retained for a longer, but bounded, period of time.

We may store pieces of information derived from diagnostic data in work items or emails. Such data can live for unbounded periods of time. This data typically doesn't include sensitive information, and may include classification information, stack traces, and so on.

## Tips for extension authors

Extension authors should limit exposure of personal information by taking care not to use personal or other sensitive information in the names of their modules, types, and methods. If a crash or similar error condition occurs with that code on the stack, that information gets collected as part of error diagnostics.

## Opt out of data collection

Given the purpose of the data we collect and the constraints on its access and retention, we recommend that you use the default privacy settings for Visual Studio and Windows. However, you can [opt out](../ide/visual-studio-experience-improvement-program.md#opt-in-or-out) of the Visual Studio Experience Improvement Program. To opt out of diagnostic data collection for all programs, see [Diagnostics, feedback, and privacy in Windows 10](https://privacy.microsoft.com/windows-10-feedback-diagnostics-and-privacy). Options may vary depending on the version of Windows you're using.

## See also

- [Visual Studio Experience Improvement Program](visual-studio-experience-improvement-program.md)
- [Diagnostics, feedback, and privacy in Windows 10](https://privacy.microsoft.com/windows-10-feedback-diagnostics-and-privacy)