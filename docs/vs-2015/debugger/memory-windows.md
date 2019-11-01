---
title: "Memory Windows | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.memory"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Memory window"
  - "strings [Visual Studio], viewing"
  - "debugger [Visual Studio], Memory window"
  - "memory [Visual Studio], debugging"
  - "debugging [Visual Studio], Memory window"
  - "buffers, viewing"
ms.assetid: 7f7a0439-10e4-4966-bb2d-51f04cda4fe2
caps.latest.revision: 37
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Memory Windows
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The **Memory** window provides a view into the memory space that is used by your application. The **Watch** window, **QuickWatch** dialog box, **Autos** window, and **Locals** window show you the content of variables, which are stored at specific locations in memory. But the **Memory** window shows you the large-scale picture. This view can be convenient for examining large pieces of data (buffers or large strings, for example) that do not display well in the other windows. However, the **Memory** window is not limited to displaying data. It displays everything in the memory space, whether the content is data, code, or random bits of garbage in unassigned memory.  
  
 The **Memory** window is available only if address-level debugging is enabled in the **Options** dialog box,**Debugging** node. The **Memory** window is not available for Script or SQL, which are languages that do not recognize the concept of memory.  
  
## Opening a Memory Window  
  
#### To open a Memory window  
  
1. Start debugging, if you are not already in debug mode.  
  
2. In the **Debug** menu, point to **Windows**. Then, point to **Memory** and then click **Memory 1**, **Memory 2**, **Memory 3**, or **Memory 4**. (Lower-level editions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] have only a single **Memory** window. If you are using one of those editions, just click **Memory**.)  
  
## Paging in the Memory Window  
 The **Memory** window has a vertical scrollbar that operates in a nonstandard manner. The address space of a modern computer is very large, and you could easily get lost by grabbing the scrollbar thumb and dragging it to a random location. For that reason, the thumb is "spring-loaded" and always remains in the center of the scrollbar. In native code applications, you can page up or down, but cannot scroll about freely.  
  
 Higher memory addresses appear at the bottom of the window. To view a higher address, scroll down, not up.  
  
#### To page up or down in memory  
  
1. To page down (move to a higher memory address), click under the thumb in the vertical scrollbar.  
  
2. To page up (move to a lower memory address), click above the thumb the vertical scrollbar.  
  
## Selecting a Memory Location  
 If you want to move instantly to a selected location in memory, you can do so by using a drag-and-drop operation or by editing the value in the **Address** box. The **Address** box accepts not only numeric values but also expressions that evaluate to addresses. By default, the **Memory** window treats an **Address** expression as a live expression, which is reevaluated as your program executes. Live expressions can be very useful. For example, you can use them to view the memory that is touched by a pointer.  
  
#### To select a memory location by dragging and dropping  
  
1. In any window, select a memory address or pointer variable that contains a memory address.  
  
2. Drag the address or pointer to the **Memory** window.  
  
#### To select a memory location by editing  
  
1. In the **Memory** window, select the **Address** box.  
  
2. Type or paste the address you want to see, and then press **ENTER**.  
  
## Changing the Way the Memory Window Displays Information  
 You can customize the way the **Memory** window shows memory contents. By default, memory contents appear as one-byte integers in hexadecimal format, and the number of columns is determined automatically by the current width of the window.  
  
#### To change the format of the memory contents  
  
1. Right-click the **Memory** window.  
  
2. Choose the format that you want.  
  
#### To change the number of columns in the Memory window  
  
1. In the toolbar at the top of the **Memory** window, locate the **Columns** list.  
  
2. In the **Columns** list, select the number of columns that you want to display or select **Auto** for automatic adjustment to fit the width of the window.  
  
   If you do not want the contents of the **Memory** window to change as your program executes, you can turn off live expression evaluation.  
  
#### To toggle live evaluation  
  
1. Right-click the **Memory** window.  
  
2. On the shortcut menu, click **Reevaluate Automatically**.  
  
    If live evaluation is on, the option will be selected, and clicking it turns off live evaluation. If live evaluation is off, the option is not selected, and clicking it turns on live evaluation.  
  
   You can hide or display the toolbar at the top of the **Memory** window. You will not have access to Address box or other tools as long as the toolbar is hidden.  
  
#### To toggle the toolbar  
  
1. Right-click a **Memory** window.  
  
2. On the shortcut menu, click **Show Toolbar**.  
  
     The toolbar appears or disappears, depending on its previous state.  
  
## Following a Pointer Through Memory  
 In native code applications, you can use register names as live expressions. For example, you can use the stack pointer to follow the stack.  
  
#### To follow a pointer through memory  
  
1. In the **Memory** window **Address** box, type a pointer expression. The pointer variable must be in the current scope. Depending on the language, you might have to dereference it.  
  
2. Press **ENTER**.  
  
     Now, when you use an execution command such as **Step**, the memory address that is displayed will automatically change as the pointer changes.  
  
## See Also  
 [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)
