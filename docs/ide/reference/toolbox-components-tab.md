---
title: Toolbox, Components Tab
description: Learn about the components you'll find in the Components tab of the Toolbox window.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VS.CHOOSEITEMS.FrameworkComponents
- VS.CHOOSEITEMS.COMComponents
- VS.CHOOSEITEMS.UniversalWindowsComponents
helpviewer_keywords:
- Toolbox, Components tab
ms.custom: "ide-ref"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Toolbox, Components tab

Displays components you can add to Visual Basic and C# designers for Windows Forms. In addition to the .NET components that are included with Visual Studio, such as the <xref:System.Messaging.MessageQueue> and <xref:System.Diagnostics.EventLog> components, you can add your own or third-party components to this tab.

To display this tab, open a Windows Forms designer. Select **View** > **Toolbox**. In **Toolbox**, select the **Components** tab.

## Components

**BackgroundWorker**

Creates a <xref:System.ComponentModel.BackgroundWorker> component instance that can run an operation on a separate, dedicated thread. For more information, see [BackgroundWorker component](/dotnet/framework/winforms/controls/backgroundworker-component).

**DirectoryEntry**

Creates a <xref:System.DirectoryServices.DirectoryEntry> component instance that encapsulates a node or object in the Active Directory hierarchy and can be used to interact with Active Directory service providers.

**DirectorySearcher**

Creates a <xref:System.DirectoryServices.DirectorySearcher> component instance that you can use to perform queries against the Active Directory.

**ErrorProvider**

Creates a <xref:System.Windows.Forms.ErrorProvider> component instance, which indicates to the end user that a control on a form has an error associated with it. For more information, see [ErrorProvider component](/dotnet/framework/winforms/controls/errorprovider-component-windows-forms).

**EventLog**

Creates an <xref:System.Diagnostics.EventLog> component instance you can use to interact with system and custom event logs, including writing events to a log and reading log data.

**FileSystemWatcher**

Creates a <xref:System.IO.FileSystemWatcher> component instance that you can use to monitor for changes to any directory or file to which you have access.

**HelpProvider**

Creates a <xref:System.Windows.Forms.HelpProvider> component instance that provides pop-up or online help for controls. For more information, see [HelpProvider component](/dotnet/framework/winforms/controls/helpprovider-component-windows-forms).

**ImageList**

Creates a <xref:System.Windows.Forms.ImageList> component instance that provides methods to manage a collection of <xref:System.Drawing.Image> objects. For more information, see [ImageList component](/dotnet/framework/winforms/controls/imagelist-component-windows-forms).

**MessageQueue**

Creates a <xref:System.Messaging.MessageQueue> component instance that you can use to interact with message queues, including reading messages from and writing messages to queues, processing transactions, and performing queue administration tasks.

**PerformanceCounter**

Creates a <xref:System.Diagnostics.PerformanceCounter> component instance that you can use to interact with Windows performance counters, including creating new categories and instances, reading values from counters, and performing calculations on counter data.

**Process**

Creates a <xref:System.Diagnostics.Process> component instance you can use to stop, start, and manipulate the data associated with processes on your system.

**SerialPort**

Creates a <xref:System.IO.Ports.SerialPort> component instance that provides synchronous and event-driven I/O, access to pin and break states, and access to serial driver properties.

**ServiceController**

Creates a <xref:System.ServiceProcess.ServiceController> component instance you can use to manipulate existing services, including starting and stopping services and sending commands to them.

**Timer**

Creates a <xref:System.Windows.Forms.Timer> component instance you can use to add time-based functionality to your Windows-based applications. For more information, see [Timer component](/dotnet/framework/winforms/controls/timer-component-windows-forms).

> [!NOTE]
> There is also a system-based <xref:System.Timers.Timer> that you can add to the **Toolbox** This <xref:System.Timers.Timer> is optimized for server applications, and the Windows Forms <xref:System.Windows.Forms.Timer> is best suited for use on Windows Forms.

## See also

- [Controls to use on Windows Forms](/dotnet/framework/winforms/controls/controls-to-use-on-windows-forms)
- [Choose Toolbox items, WPF components](choose-toolbox-items-wpf-components.md)
- [Toolbox](../../ide/reference/toolbox.md)
