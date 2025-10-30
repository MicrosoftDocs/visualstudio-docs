---
title: "IntelliTrace Features"
description: Learn about IntelliTrace features in Visual Studio. Use IntelliTrace to record events and method calls in your application.
ms.date: "09/19/2018"
ms.topic: article
helpviewer_keywords:
  - "IntelliTrace, debugging with events"
  - "IntelliTrace, recording execution history"
  - "debugging [Visual Studio ALM], recording execution history"
  - "IntelliTrace, turn off"
  - "IntelliTrace, navigating event and call history"
  - "IntelliTrace, saving your session"
  - "IntelliTrace, enabling"
  - "IntelliTrace, start debugging"
  - "IntelliTrace, debugging with events and call information"
  - "IntelliTrace, disabling"
  - "IntelliTrace, turn on"
  - "debugging [Visual Studio ALM], IntelliTrace"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IntelliTrace Features (C#, Visual Basic, C++)

You can use IntelliTrace to record events and method calls your application, which allows you to examine its state (call stack and local variable values) at different points in the execution. Just start debugging as usual - IntelliTrace is turned on by default, and you can see the information IntelliTrace is recording in the new **Diagnostic Tools** window under the **Events** tab. Select an event and click **Activate Historical Debugging** to see the call stack and locals recorded for this event.

For a step-by-step description, see [Walkthrough: Using IntelliTrace](../debugger/walkthrough-using-intellitrace.md).

IntelliTrace is available in Visual Studio Enterprise edition, but not in the Visual Studio Professional or Community editions.

To confirm that IntelliTrace is turned on, open the **Tools > Options > IntelliTrace** options page. **Enable IntelliTrace** should be checked by default.

> [!NOTE]
> The scope of all settings on the **IntelliTrace** options page is Visual Studio as a whole, not individual projects or solutions. A change in these settings applies to all instances of Visual Studio, all debugging sessions and all projects or solutions.

## <a name="ChooseEvents"></a> Choose the events that IntelliTrace records (C#, Visual Basic)

You can turn on or off recording for specific IntelliTrace events.

If you're debugging, stop debugging. Go to **Tools > Options > IntelliTrace > IntelliTrace Events**. Choose the events you want IntelliTrace to record.

## <a name="Snapshots"></a> Collect snapshots (C#, Visual Basic, C++)

This isn't enabled by default, but IntelliTrace can capture snapshots of your application at every breakpoint and debugger step event, and you can view these snapshots in a historical debugging session. A snapshot gives you a view of your full application state. To enable the capture of snapshots, go to **Tools > Options > IntelliTrace > General**, and select **IntelliTrace snapshots (managed and native)**. For more information, see [Inspect previous app states using IntelliTrace](../debugger/view-historical-application-state.md).

Snapshots are available in Visual Studio Enterprise 2017 version 15.5 and higher, and it requires Windows 10 Anniversary Update or above.  For .NET Core and ASP.NET Core apps, Visual Studio Enterprise 2017 version 15.7 is required. For native apps targeting Windows, Visual Studio Enterprise 2017 version 15.9 Preview 2 is required.

## <a name="GoingFurther"></a> Collect IntelliTrace events and call information (C#, Visual Basic)

This isn't enabled by default, but IntelliTrace can record method calls along with events. To enable collection of method calls go to **Tools > Options > IntelliTrace > General**, and select **IntelliTrace events and call information (managed only)**.

Call information is not currently available for .NET Core and ASP.NET Core apps.

This lets you see the call stack history and step backward and forward through calls in your code. IntelliTrace records data such as method names, method entry and exit points, and certain parameter values and return values.

> [!TIP]
> This option is not enabled by default because it adds considerable overhead. Not only does IntelliTrace have to intercept every method call your application makes, but it also has to deal with a much larger set of data when it comes to showing it on the screen or persisting it to disk.
>
> You can reduce the performance overhead by restricting the list of events that IntelliTrace records and by keeping the number of modules you are collecting to a minimum. For more information, see [Control how much call information IntelliTrace records](../debugger/intellitrace-features.md#ControlCallData).

### Use the navigation gutter

You can use the navigation gutter that appears to the left of the code window. If you don't see the navigation gutter, go to **Tools > Options > IntelliTrace > Advanced**, and select **Display the navigation gutter while in debug mode**.

The navigation gutter allows you to move forwards and backwards through method calls and events in historical debugging mode. For more information about historical debugging, see [Historical Debugging](../debugger/historical-debugging.md). It has a number of commands:

|Command|Description|
|-|-|
|**Set Debugger Context Here**|Set the debugging context to the call timeframe where it appears.<br /><br /> This icon appears only on the current call stack.|
|**Return to Call Site**|Move the pointer and debugging context back to where the current function was called.<br /><br /> If you are in Live Debugging mode, this command turns Historical Debugging on. If you navigate back to the original execution break, Historical Debugging is turned off and Live Debugging is turned on.|
|**Go to Previous Call or IntelliTrace Event**|Move the pointer and debugging context back to the previous call or event.<br /><br /> If you are in Live Debugging mode, this command turns on Historical Debugging.|
|**Step In**|Step into the currently selected function.<br /><br /> This command is available only when you are in Historical Debugging mode.|
|**Go to Next Call or IntelliTrace Event**|Move the pointer and debugging context to the next call or event for which IntelliTrace data exists.<br /><br /> This command is available only when you are in Historical Debugging mode.|
|**Go to Live Mode**|Return to Live Debugging mode.|

### Search for a line or method in IntelliTrace

You can search methods only when method call information has been enabled. You can search IntelliTrace history for a specific line or method. While debugger execution is halted, right-click inside the body of the function to see the context menu, and click either **Search For This LIne In IntelliTrace** or **Search For This Method In IntelliTrace**.

### <a name="ControlCallData"></a> Control how much call information IntelliTrace records

By default IntelliTrace records information for all the modules used by your solution. You can set IntelliTrace to record call information only for the modules that interest you. In **Tools > Options > IntelliTrace > Modules**, You can specify the modules to include or the modules to exclude from IntelliTrace. IntelliTrace will collect only the events that originated from the modules you have specified, and the method calls that happened within the modules you are interested in.

To add multiple modules, use the wildcard character * at the start or the end of the string. For module names, use file names, not assembly names. File paths are not accepted.

Try to keep the number of modules to a minimum. You get better performance because there is less data to be collected. You also get less noise in the UI because there is less data to go through.

## <a name="SaveSession"></a> Save IntelliTrace data to file (C#, Visual Basic, C++)

You can save the data that IntelliTrace has collected going to **Debug > IntelliTrace > Save IntelliTrace Session** while you are debugging and the application is in a break state. The menu item is disabled and you will not be able to save the data IntelliTrace has collected if the application is still running or if you have stopped debugging.

You can configure IntelliTrace to automatically save to a file by going to **Tools > Options > IntelliTrace > Advanced** and selecting **Store IntelliTrace recordings in this directory**. You can also configure a set size for the generated file, which causes IntelliTrace to write over older data when it runs out of space. Visual Studio creates two files for each IntelliTrace session when they are saved automatically and the Visual Studio hosting process (vshost.exe) is turned on.

> [!TIP]
> To save disk space, turn off saving files automatically when you don't need them anymore. Any existing files will not be deleted. You can always save to file on demand from the context menu.

When you save IntelliTrace data to file, you get one .itrace file for each process that IntelliTrace collected from. You can then open the .itrace file in Visual Studio by going to **File > Open > File** and selecting the .itrace file from the Open File dialog. For more information, see [Using saved IntelliTrace data](../debugger/using-saved-intellitrace-data.md).

## Blogs

[IntelliTrace in Visual Studio Enterprise 2015](https://devblogs.microsoft.com/devops/intellitrace-in-visual-studio-ultimate-2015/)

[IntelliTrace in Visual Studio Enterprise 2015 now supports attach!](https://devblogs.microsoft.com/devops/intellitrace-in-visual-studio-enterprise-2015-now-supports-attach/)

[Collect data from a windows service using the IntelliTrace Standalone Collector](https://devblogs.microsoft.com/devops/collect-data-from-a-windows-service-using-the-intellitrace-standalone-collector/)

[Editing the IntelliTrace collection plan](https://devblogs.microsoft.com/devops/editing-the-intellitrace-collection-plan)

[Custom TraceSource and debugging using IntelliTrace](https://devblogs.microsoft.com/devops/custom-tracesource-and-debugging-using-intellitrace/)

## Forums

[Visual Studio Debugger](https://social.msdn.microsoft.com/Forums/en-US/home)
