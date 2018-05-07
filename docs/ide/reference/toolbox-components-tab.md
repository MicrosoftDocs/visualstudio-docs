---
title: Toolbox, Components Tab
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: reference
helpviewer_keywords:
  - "Toolbox, Components tab"
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Toolbox, Components Tab

Displays components you can add to Visual Basic and C# designers. In addition to the .NET Framework components that are included with Visual Studio, such as the <xref:System.Messaging.MessageQueue> and <xref:System.Diagnostics.EventLog> components, you can add your own or third-party components to this tab.

 To display this tab, from the **View** menu, select **Toolbox**. In the **Toolbox**, select the **Components** tab.

 **BackgroundWorker**

 Creates a `System.ComponentModel.BackgroundWorker` component instance that can run an operation on a separate, dedicated thread.

 **DirectoryEntry**

 Creates a <xref:System.DirectoryServices.DirectoryEntry> component instance that encapsulates a node or object in the Active Directory hierarchy and can be used to interact with Active Directory service providers.

 **DirectorySearcher**

 Creates a <xref:System.DirectoryServices.DirectorySearcher> component instance that you can use to perform queries against the Active Directory.

 **ErrorProvider**

 Creates a `System.Windows.Forms.ErrorProvider` component instance, which indicates to the end user that a control on a form has an error associated with it.

 **EventLog**

 Creates an <xref:System.Diagnostics.EventLog> component instance you can use to interact with system and custom event logs, including writing events to a log and reading log data.

 **FileSystemWatcher**

 Creates a <xref:System.IO.FileSystemWatcher> component instance that you can use to monitor for changes to any directory or file to which you have access.

 **HelpProvider**

 Creates a `System.Windows.Forms.HelpProvider` component instance that provides pop-up or online Help for controls.

 **ImageList**

 Creates a `System.Windows.Forms.ImageList` component instance that provides methods to manage a collection of `System.Drawing.Image` objects.

 **MessageQueue**

 Creates a <xref:System.Messaging.MessageQueue> component instance that you can use to interact with message queues, including reading messages from and writing messages to queues, processing transactions, and performing queue administration tasks.

 **PerformanceCounter**

 Creates a <xref:System.Diagnostics.PerformanceCounter> component instance that you can use to interact with Windows performance counters, including creating new categories and instances, reading values from counters, and performing calculations on counter data.

 **Process**

 Creates a <xref:System.Diagnostics.Process> component instance you can use to stop, start, and manipulate the data associated with processes on your system.

 **SerialPort**

 Creates a `System.IO.Ports.SerialPort` component instance that provides synchronous and event-driven I/O, access to pin and break states, and access to serial driver properties.

 **ServiceController**

 Creates a <xref:System.ServiceProcess.ServiceController> component instance you can use to manipulate existing services, including starting and stopping services and sending commands to them.

 **Timer**

 Creates a <xref:System.Windows.Forms.Timer> component instance you can use to add time-based functionality to your Windows-based applications. For more information, see [Timer Component](/dotnet/framework/winforms/controls/timer-component-windows-forms).

> [!NOTE]
> There is also a system-based <xref:System.Timers.Timer> that you can add to the **Toolbox** This <xref:System.Timers.Timer> is optimized for server applications, and the Windows Forms <xref:System.Windows.Forms.Timer> is best suited for use on Windows Forms.


## See also

- [Programming with Components](http://msdn.microsoft.com/Library/d4d4fcb4-e0b8-46b3-b679-7ee0026eb9e3)
- [Component Programming Walkthroughs](http://msdn.microsoft.com/Library/373cacf7-479e-4b05-991c-5cb18824e913)
- [Toolbox](../../ide/reference/toolbox.md)