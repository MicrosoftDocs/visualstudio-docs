---
title: View memory for variables in the debugger | Microsoft Docs
description: Learn how to use Memory windows as you debug, to see the memory space your app is using. Other windows show variables and where they reside in memory.
ms.custom: SEO-VS-2020
ms.date: 10/04/2018
ms.topic: how-to
f1_keywords: 
  - vs.debug.memory
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
  - JScript
helpviewer_keywords: 
  - Memory window
  - strings [Visual Studio], viewing
  - debugger [Visual Studio], Memory window
  - memory [Visual Studio], debugging
  - debugging [Visual Studio], Memory window
  - buffers, viewing
ms.assetid: 7f7a0439-10e4-4966-bb2d-51f04cda4fe2
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# Use the Memory windows in the Visual Studio debugger (C#, C++, Visual Basic, F#)

During debugging, the **Memory** window shows the memory space your app is using.

Debugger windows like **Watch**, **Autos**, **Locals**, and the **QuickWatch** dialog show you variables, which are stored at specific locations in memory. The **Memory** window shows you the overall picture. The memory view is convenient for examining large pieces of data (buffers or large strings, for example) that don't display well in the other windows.

The **Memory** window isn't limited to displaying data. It displays everything in the memory space, including data, code, and random bits of garbage in unassigned memory.

The **Memory** window isn't available for script or SQL debugging. Those languages don't recognize the concept of memory.

## Open a Memory window

Like other debugger windows, the **Memory** windows are available only during a debugging session.

>[!IMPORTANT]
>To enable the **Memory** windows, **Enable address-level debugging** must be selected in **Tools** > **Options** (or **Debug** > **Options**) > **Debugging** > **General**.

**To open a Memory window**

1. Make sure **Enable address-level debugging** is selected in **Tools** > **Options** (or **Debug** > **Options**) > **Debugging** > **General**.

1. Start debugging by selecting the green arrow, pressing **F5**, or selecting **Debug** > **Start Debugging**.

2. Under **Debug** > **Windows** > **Memory**, select **Memory 1**, **Memory 2**, **Memory 3**, or **Memory 4**. (Some editions of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] offer only one **Memory** window.)

## Move around in the Memory window

The address space of a computer is large, and you can easily lose your place by scrolling in the **Memory** window.

Higher memory addresses appear at the bottom of the window. To view a higher address, scroll down. To view a lower address, scroll up.

You can instantly go to a specified address in the **Memory** window by using drag-and-drop, or by entering the address in the **Address** field. The **Address** field accepts alphanumeric addresses, and expressions that evaluate to addresses, such as `e.User.NonroamableId`.

To force immediate re-evaluation of an expression in the **Address** field, select the rounded-arrow **Reevaluate Automatically** icon.

By default, the **Memory** window treats **Address** expressions as live expressions, which are re-evaluated as the app runs. Live expressions can be useful, for example, to view the memory that is touched by a pointer variable.

**To use drag and drop to move to a memory location:**

1. In any debugger window, select a memory address, or a pointer variable that contains a memory address.

2. Drag and drop the address or pointer in the **Memory** window. That address then appears in the **Address** field, and the **Memory** window adjusts to display that address at the top.

**To move to a memory location by entering it in the Address field:**

- Type or paste the address or expression in the **Address** field and press **Enter**, or choose it from the dropdown in the **Address** field. The **Memory** window adjusts to display that address at the top.

## Customize the Memory window

By default, memory contents appear as 1-byte integers in hexadecimal format, and the window width determines the number of columns shown. You can customize the way the **Memory** window shows memory contents.

**To change the format of the memory contents:**

- Right-click in the **Memory** window, and choose the formats that you want from the context menu.

**To change the number of columns in the Memory window:**

- Select the drop down arrow next to the **Columns** field, and select the number of columns to display, or select **Auto** for automatic adjustment based on window width.

If you do not want the contents of the **Memory** window to change as your app runs, you can turn off live expression evaluation.

**To toggle live evaluation:**

- Right-click in the **Memory** window, and select **Reevaluate Automatically** in the context menu.

  >[!NOTE]
  >Live expression evaluation is a toggle, and is on by default, so selecting **Reevaluate Automatically** turns it off. Selecting **Reevaluate Automatically** again turns it back on.

You can hide or display the toolbar at the top of the **Memory** window. You will not have access to the **Address** field or other tools when the toolbar is hidden.

**To toggle the toolbar display:**

- Right-click in the **Memory** window, and select **Show Toolbar** in the context menu. The toolbar appears or disappears, depending on its previous state.

## Follow a pointer through memory

In native code apps, you can use register names as live expressions. For example, you can use the stack pointer to follow the stack.

**To follow a pointer through memory:**

1. In the **Memory** window **Address** field, enter a pointer expression that is in the current scope. Depending on the language, you might have to dereference it.

2. Press **Enter**.

   When you use a debug command such as **Step**, the memory address displayed in the **Address** field and at the top of the **Memory** window automatically changes as the pointer changes.

## See also
- [View data in the debugger](../debugger/viewing-data-in-the-debugger.md)