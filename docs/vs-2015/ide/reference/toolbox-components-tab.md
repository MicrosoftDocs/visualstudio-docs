---
title: "Toolbox, Components Tab | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "Toolbox, Components tab"
ms.assetid: 332fafab-a763-4244-b388-15d1b5b5cc04
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# Toolbox, Components Tab
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Displays components you can add to [!INCLUDE[vbprvb](../../includes/vbprvb-md.md)] and [!INCLUDE[csprcs](../../includes/csprcs-md.md)] designers. In addition to the [!INCLUDE[dnprdnshort](../../includes/dnprdnshort-md.md)] components that are included with [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)], such as the <xref:System.Messaging.MessageQueue> and <xref:System.Diagnostics.EventLog> components, you can add your own or third-party components to this tab. For more information, see [How to: Manipulate Toolbox Tabs](https://msdn.microsoft.com/21285050-cadd-455a-b1f5-a2289a89c4db).

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
 Creates an <xref:System.Diagnostics.EventLog> component instance you can use to interact with system and custom event logs, including writing events to a log and reading log data. For more information, see [Introduction to the EventLog Component](https://msdn.microsoft.com/a2ba4f28-4b1a-435e-99ef-51b28e21f805).

 **FileSystemWatcher**
 Creates a <xref:System.IO.FileSystemWatcher> component instance that you can use to monitor for changes to any directory or file to which you have access. For more information, see [How to: Configure FileSystemWatcher Component Instances](https://msdn.microsoft.com/2e628234-4951-4135-8a86-28b924070d50).

 **HelpProvider**
 Creates a `System.Windows.Forms.HelpProvider` component instance that provides pop-up or online Help for controls.

 **ImageList**
 Creates a `System.Windows.Forms.ImageList` component instance that provides methods to manage a collection of `System.Drawing.Image` objects.

 **MessageQueue**
 Creates a <xref:System.Messaging.MessageQueue> component instance that you can use to interact with message queues, including reading messages from and writing messages to queues, processing transactions, and performing queue administration tasks. For more information, see [Using Messaging Components](https://msdn.microsoft.com/922dbac7-26f0-4e39-b666-ccfc184793d7).

 **PerformanceCounter**
 Creates a <xref:System.Diagnostics.PerformanceCounter> component instance that you can use to interact with Windows performance counters, including creating new categories and instances, reading values from counters, and performing calculations on counter data. For more information, see [Monitoring Performance Thresholds](https://msdn.microsoft.com/b8b44a55-31d0-4b45-9517-8c1b1e4fdc91).

 **Process**
 Creates a <xref:System.Diagnostics.Process> component instance you can use to stop, start, and manipulate the data associated with processes on your system. For more information, see [Monitoring and Managing Windows Processes](https://msdn.microsoft.com/a86bd4c1-b92c-49a0-8f32-61d67837b45e).

 **SerialPort**
 Creates a `System.IO.Ports.SerialPort` component instance that provides synchronous and event-driven I/O, access to pin and break states, and access to serial driver properties.

 **ServiceController**
 Creates a <xref:System.ServiceProcess.ServiceController> component instance you can use to manipulate existing services, including starting and stopping services and sending commands to them. For more information, see [Monitoring Windows Services](https://msdn.microsoft.com/4542ee3f-e052-4cb9-8726-58e9420de222).

 **Timer**
 Creates a <xref:System.Windows.Forms.Timer> component instance you can use to add time-based functionality to your Windows-based applications. For more information, see [Timer Component](https://msdn.microsoft.com/library/6700e534-6382-43d5-98ed-14205435fff7).

> [!NOTE]
> There is also a system-based <xref:System.Timers.Timer> that you can add to the **Toolbox** This <xref:System.Timers.Timer> is optimized for server applications, and the Windows Forms <xref:System.Windows.Forms.Timer> is best suited for use on Windows Forms.

## See Also
 [Programming with Components](https://msdn.microsoft.com/library/d4d4fcb4-e0b8-46b3-b679-7ee0026eb9e3)
 [Component Programming Walkthroughs](https://msdn.microsoft.com/library/373cacf7-479e-4b05-991c-5cb18824e913)
 [Toolbox](../../ide/reference/toolbox.md)
 [Choose Toolbox Items Dialog Box (Visual Studio)](https://msdn.microsoft.com/bd07835f-18a8-433e-bccc-7141f65263bb)
