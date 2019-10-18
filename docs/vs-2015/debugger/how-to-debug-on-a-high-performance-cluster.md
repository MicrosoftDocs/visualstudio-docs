---
title: "How to: Debug On a High-Performance Cluster | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "cluster debugging"
  - "high-performance debugging"
ms.assetid: a2f0eb07-840e-4f95-a1b1-9509217e5b8f
caps.latest.revision: 27
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Debug On a High-Performance Cluster
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Debugging a multiprocessing program on a high-performance cluster is like debugging an ordinary program on a remote computer. However, there are some additional considerations. For general remote setup requirements, see [Remote Debugging](../debugger/remote-debugging.md).  
  
 When you debug on a high-performance cluster, you can use all the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] debugging windows and techniques that are available for remote debugging. Because you are debugging remotely, however, the external console window is not available.  
  
 The **Threads** window and **Processes** window are especially useful for debugging parallel applications. For tips on how to use these windows, see [How to: Use the Processes Window](https://msdn.microsoft.com/0207ce2f-8ceb-4fe7-b2b5-4dd35b035ed7) and [How to: Use the Threads Window](../debugger/how-to-use-the-threads-window.md).  
  
 The following procedures show some techniques that are especially useful for debugging on a high-performance cluster.  
  
 When you debug a parallel application, you might want to set a breakpoint on a particular thread, process, or computer. You can do this by creating a normal breakpoint, and then adding a breakpoint filter.  
  
### To open the Breakpoint Filter dialog box  
  
1. Right-click a breakpoint glyph in a source window, the **Disassembly** window, the **Call Stack** window, or the **Breakpoints** window.  
  
2. On the shortcut menu, click **Filter**. This option may appear at the top level or in the submenu under **Breakpoints**.  
  
### To set a breakpoint on a specific computer  
  
1. Get the computer name from the **Processes** window.  
  
2. Select a breakpoint, and open the **Breakpoint Filter** dialog box as described in the previous procedure.  
  
3. In the **Breakpoint Filter** dialog box, type:  
  
     MachineName =*yourmachinename*  
  
     To create a more complex filter, you can combine clauses using `&`, the AND operator, `||`, the OR operator, `!`, the NOT operator, and parentheses.  
  
4. Click **OK**.  
  
### To set a breakpoint on a specific process  
  
1. Get the process name or process ID number from the **Processes** window.  
  
2. Select a breakpoint, and open the **Breakpoint Filter** dialog box as in the first procedure.  
  
3. In the **Breakpoint Filter** dialog box, type:  
  
     `ProcessName =`  *yourprocessname*  
  
     —or—  
  
     `ProcessID =` *yourprocessIDnumber*  
  
     To create a more complex filter, you can combine clauses using `&`, the AND operator, `||`, the OR operator, `!`, the NOT operator, and parentheses.  
  
4. Click **OK**.  
  
### To set a breakpoint on a specific thread  
  
1. Get the thread name or thread ID number from the **Threads** window.  
  
2. Select a breakpoint, and open the **Breakpoint Filter** dialog box as described in the first procedure.  
  
3. In the **Breakpoint Filter** dialog box, type:  
  
     `ThreadName =` *yourthreadname*  
  
     —or—  
  
     `ThreadID =` *yourthreadIDnumber*  
  
     To create a more complex filter, you can combine clauses using `&`, the AND operator, `||`, the OR operator, `!`, the NOT operator, and parentheses.  
  
4. Click **OK**.  
  
## Example  
 The following example shows how to create a filter for a breakpoint on a computer named `marvin` and a thread named `fourier1`.  
  
```  
(MachineName = marvin) & (ThreadName = fourier1)  
```  
  
## See also  
 [Debug Multithreaded Applications](../debugger/debug-multithreaded-applications-in-visual-studio.md)   
 [Remote Debugging](../debugger/remote-debugging.md)   
 [How to: Use the Processes Window](https://msdn.microsoft.com/0207ce2f-8ceb-4fe7-b2b5-4dd35b035ed7)   
 [How to: Use the Threads Window](../debugger/how-to-use-the-threads-window.md)   
 [Threads and Processes](https://msdn.microsoft.com/73d87480-9af3-4d1b-baf5-397d5d876ae6)   
 [Using Breakpoints](../debugger/using-breakpoints.md)
