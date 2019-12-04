---
title: "IntelliTrace | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.historicaldebug.overview"
helpviewer_keywords: 
  - "debugger, recording execution history"
  - "debugging, recording execution history"
  - "IntelliTrace [Visual Studio ALM]"
  - "IntelliTrace, debugging applications"
  - "debugger, (See also IntelliTrace [Visual Studio ALM])"
  - "debugging, (See also IntelliTrace [Visual Studio ALM])"
  - "IntelliTrace, collecting data from Test Manager"
  - "IntelliTrace"
  - "Test Manager, debugging with IntelliTrace"
  - "IntelliTrace, debugging after a crash"
ms.assetid: 486bfec2-39bd-4d78-892a-42352128ee52
caps.latest.revision: 142
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IntelliTrace
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The latest version of this topic can be found at [IntelliTrace](https://docs.microsoft.com/visualstudio/debugger/intellitrace) .  
  
You can spend less time debugging your application when you use IntelliTrace to record and trace your code's execution history. You can find bugs easily because IntelliTrace lets you:  
  
- Record specific events  
  
   Examine related code, data that appears in the **Locals** window during debugger events, and function call information  
  
- Debug errors that are hard to reproduce or that happen in deployment  
  
  You can use IntelliTrace in Visual Studio Enterprise edition (but not the Professional or Community editions).  
  
## What do you want to do?  
  
|||  
|-|-|  
|**Debug my application with IntelliTrace:**<br /><br /> -   Show me past events.<br />-   Show me call information with past events.<br />-   Save my IntelliTrace session.<br />-   Control the data that IntelliTrace collects.|-   [Walkthrough: Using IntelliTrace](../debugger/walkthrough-using-intellitrace.md)<br />     [IntelliTrace Features](../debugger/intellitrace-features.md)<br />-   [Configure IntelliTrace](https://msdn.microsoft.com/7657ecab-e07e-4b1b-872d-f05d966be37e)<br />-   [Historical Debugging](../debugger/historical-debugging.md)|  
|**Collect IntelliTrace data during a test session in Test Manager**|-   [Collect more diagnostic data in manual tests](https://msdn.microsoft.com/library/bb5a2cc0-84f5-4dfe-9560-ca3d313aefd2)|  
|**Collect IntelliTrace data from deployed applications**|-   [Using the IntelliTrace stand-alone collector](../debugger/using-the-intellitrace-stand-alone-collector.md)|  
|**Start debugging from an IntelliTrace log file (.iTrace file).**|-   [Using saved IntelliTrace data](../debugger/using-saved-intellitrace-data.md)|  
  
## <a name="IntelliTraceSupport"></a> What apps can I debug with IntelliTrace?  
  
|||  
|-|-|  
|**Supported**|-   Visual Basic and Visual C# applications that use .NET Framework 2.0 or higher versions.<br />     You can debug most applications, including ASP.NET, Microsoft Azure, Windows Forms, WCF, WPF, Windows Workflow, SharePoint 2010, SharePoint 2013, and 64-bit apps.<br />     To debug SharePoint applications with IntelliTrace, see [Walkthrough: Debugging a SharePoint Application by Using IntelliTrace](https://msdn.microsoft.com/library/4bd80d2f-f680-4bf4-81c3-f14e8185f6a4).<br />     To debug Microsoft Azure apps with IntelliTrace, see [Debugging a Published Cloud Service with IntelliTrace and Visual Studio](../azure/vs-azure-tools-intellitrace-debug-published-cloud-services.md).|  
|**Limited support**|-   F# apps on an experimental basis<br />-   Windows Store apps supported for events only|  
|**Not supported**|-   C++, other languages, and script<br />-   Windows Services, Silverlight, Xbox, or [!INCLUDE[winmobile](../includes/winmobile-md.md)] apps|  
  
> [!NOTE]
> If you want to debug a process that is already running, you can’t use IntelliTrace. You must start IntelliTrace when the process starts.  
  
## <a name="IntelliTraceVSTraditional"></a> Why debug with IntelliTrace?  
 Traditional or *live* debugging shows only your application's current state, with limited data about past events. You either have to infer these events based on the application's current state, or you have to recreate these events by rerunning your application.  
  
 IntelliTrace expands this traditional debugging experience by recording specific events and data at these points in time. This lets you see what happened in your application without restarting it, especially if you step past where the bug is. IntelliTrace is turned on by default during traditional debugging and collects data automatically and invisibly. This lets you switch easily between traditional debugging and IntelliTrace debugging to see the recorded information. See [IntelliTrace Features](../debugger/intellitrace-features.md) and [What data does IntelliTrace collect?](#WhatData)  
  
 IntelliTrace can also help you debug errors that are hard to reproduce or that happen in deployment. You can collect IntelliTrace data and save it to an IntelliTrace log file (.iTrace file). An .iTrace file contains details about exceptions, performance events, Web requests, test data, threads, modules, and other system information. You can open this file in Visual Studio Enterprise, select an item, and start debugging with IntelliTrace. This lets you go to any event in the file and see specific details about your application at that point in time.  
  
 You can save IntelliTrace data from these sources:  
  
- An IntelliTrace session in Visual Studio 2015 Enterprise or previous versions of Visual Studio Ultimate.  
  
- A test session in Microsoft Test Manager  
  
- ASP.NET web apps hosted on IIS, or SharePoint 2010 and SharePoint 2013 applications running in deployment when you use Microsoft Monitoring Agent, either alone or with System Center 2012. See [Using the IntelliTrace stand-alone collector](../debugger/using-the-intellitrace-stand-alone-collector.md) and [Monitoring with Microsoft Monitoring Agent](https://technet.microsoft.com/library/dn465153.aspx).  
  
  Here are some examples of how IntelliTrace can help you with debugging:  
  
- Your application has corrupted a data file, but you don't know where this event happened.  
  
   Without IntelliTrace, you have to look through the code to find all possible file accesses, put breakpoints on those accesses, and rerun your application to find where the problem happened. With IntelliTrace, you can see all the collected file-access events and specific details about your application when each event happened.  
  
- An exception happens.  
  
   Without IntelliTrace, you get a message about an exception but you don’t have much information about the events that led to the exception. You can examine the call stack to see the chain of calls that led to the exception, but you can’t see the sequence of events that happened during those calls. With IntelliTrace, you can examine the events that happened before the exception.  
  
- Your application crashes on a test computer but runs successfully on a development computer.  
  
   You can collect IntelliTrace data from Microsoft Test Manager, save the data to an .iTrace file, and attach this file to a Team Foundation Server work item for later investigation. See [Collect more diagnostic data in manual tests](https://msdn.microsoft.com/library/bb5a2cc0-84f5-4dfe-9560-ca3d313aefd2) and [Using saved IntelliTrace data](../debugger/using-saved-intellitrace-data.md).  
  
- A bug or crash happens in a deployed application.  
  
   For Microsoft Azure-based apps, you can configure IntelliTrace data collection before you publish the application. While your application runs, IntelliTrace saves data to an .iTrace file. See [Debugging a Published Cloud Service with IntelliTrace and Visual Studio](../azure/vs-azure-tools-intellitrace-debug-published-cloud-services.md).  
  
   For ASP.NET web apps hosted on IIS 7.0, 7.5, and 8.0, and SharePoint 2010 or SharePoint 2013 applications, use Microsoft Monitoring Agent, either alone or with System Center 2012, to save IntelliTrace data to an .iTrace file.  
  
   This is useful when you want to diagnose problems with apps in deployment. See [Using the IntelliTrace stand-alone collector](../debugger/using-the-intellitrace-stand-alone-collector.md).  
  
## <a name="WhatData"></a> What data does IntelliTrace collect?  
 **Collecting event information**  
  
 By default, IntelliTrace records only IntelliTrace events: debugger events, exceptions, .NET Framework events, and other system events that can help you with debugging. You can choose the kinds of IntelliTrace events that you want to collect, except for debugger events and exceptions, which are always collected. See [Configure IntelliTrace](https://msdn.microsoft.com/7657ecab-e07e-4b1b-872d-f05d966be37e).  
  
- **Debugger events**  
  
   IntelliTrace always records events that happen in the Visual Studio debugger. For example, starting your application is a debugger event. Other debugger events are stopping events, which cause your application to break execution. For example, your program hits a breakpoint, hits a tracepoint, or executes a **Step** command.  
  
   To help with performance, IntelliTrace doesn't record every possible value for a debugger event. Instead, it records these values:  
  
  - Values in the **Locals** window. Keep the **Locals** window open to see these values.  
  
  - Values in the **Autos** window only if the **Autos** window is open  
  
  - Values in DataTips that appear when you move the mouse pointer on top of a variable in the source window to see its value. IntelliTrace doesn't collect values in pinned DataTips.  
  
- **Exceptions**  
  
   IntelliTrace records the exception type and message for these kinds of exceptions:  
  
  - Handled exceptions where the exception is thrown and caught  
  
  - Unhandled exceptions  
  
- **.NET Framework events**  
  
   By default, IntelliTrace records the most common .NET Framework events. For example:  
  
  - For a File Access event, IntelliTrace collects the file name.  
  
  - For a Check Checkbox event, IntelliTrace collects the checkbox state and text.  
  
- **SharePoint 2010 and SharePoint 2013 application events**  
  
   You can record user profile events and a subset of Unified Logging System (ULS) events for SharePoint 2010 and 2013 applications running outside Visual Studio. You can save these events to an .iTrace file. Requires Visual Studio Enterprise 2015, a previous version of Visual Studio Ultimate, or [Microsoft Monitoring Agent](https://go.microsoft.com/fwlink/?LinkId=320384) running in **Trace** mode.  
  
   When you open the .iTrace file, enter a SharePoint correlation ID to find its matching web request, view the recorded events, and start debugging from a specific event. If the file contains unhandled exceptions, you can choose a correlation ID to start debugging an exception.  
  
   See:  
  
  - [Using the IntelliTrace stand-alone collector](../debugger/using-the-intellitrace-stand-alone-collector.md)  
  
  - [Using saved IntelliTrace data](../debugger/using-saved-intellitrace-data.md)  
  
  - [Walkthrough: Debugging a SharePoint Application by Using IntelliTrace](https://msdn.microsoft.com/library/4bd80d2f-f680-4bf4-81c3-f14e8185f6a4)  
  
  **Collecting function call information**  
  
  You can configure IntelliTrace to collect call information for functions. This information lets you see a history of the call stack and lets you step backward and forward through calls in the code. For each function call, IntelliTrace records this data:  
  
- Function name  
  
- Values of primitive data types passed as parameters at function entry points and returned at function exit points  
  
- Values of automatic properties when they are read or changed  
  
- Pointers to first-level child objects, but not their values other than if they were null or not  
  
> [!NOTE]
> IntelliTrace collects only the first 256 objects in arrays and the first 256 characters for strings.  
  
 See [Configure IntelliTrace](https://msdn.microsoft.com/7657ecab-e07e-4b1b-872d-f05d966be37e).  
  
 **Collecting module information**  
  
 To control how much call information that IntelliTrace collects, specify only those modules that you care about. This can help improve your application's performance during collection. See [Configure IntelliTrace](https://msdn.microsoft.com/7657ecab-e07e-4b1b-872d-f05d966be37e).  
  
## <a name="AffectPerformance"></a> Will IntelliTrace slow down my application?  
 By default, IntelliTrace collects data for selected IntelliTrace events only. This might or might not slow down your application, depending on the structure and organization of your code. For example, if IntelliTrace records an event often, this might slow down your application. It might also make you consider refactoring your application.  
  
 Collecting call information might slow down your application significantly. It might also increase the size of any IntelliTrace log files (.iTrace files) that you’re saving to disk. To minimize these effects, collect call information only for the modules you care about.  To change the maximum size of your .iTrace files, go to **Tools**, **Options**, **IntelliTrace**, **Advanced**. See [Configure IntelliTrace](https://msdn.microsoft.com/7657ecab-e07e-4b1b-872d-f05d966be37e).  
  
## In this section  
 [IntelliTrace Features](../debugger/intellitrace-features.md)  
  
 [Configure IntelliTrace](https://msdn.microsoft.com/7657ecab-e07e-4b1b-872d-f05d966be37e)  
  
 [Including Diagnostic Trace Data with Bugs that are Difficult to Reproduce](https://msdn.microsoft.com/library/944ae9af-5a55-4c58-b520-0108c03b3564)  
  
 [Diagnose problems after deployment](../debugger/diagnose-problems-after-deployment.md)  
  
 [Using saved IntelliTrace data](../debugger/using-saved-intellitrace-data.md)  
  
### Blogs  
 [Visual Studio ALM + Team Foundation Server](https://go.microsoft.com/fwlink/?LinkID=201340)  
  
### Forums  
 [Visual Studio Diagnostics](https://go.microsoft.com/fwlink/?LinkId=262263)
