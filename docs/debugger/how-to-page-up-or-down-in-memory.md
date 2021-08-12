---
title: Page Up or Down in Memory | Microsoft Docs
description: See how to page up or down in memory to view memory contents in a Memory window or the Disassembly window when debugging in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
  - JScript
helpviewer_keywords: 
  - debugger, paging up or down in memory
  - memory, paging up or down
  - Disassembly window, viewing memory space
  - Memory window, paging up or down in memory
ms.assetid: 50b30a68-66f6-43f8-a48b-59ce12c95471
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# How to: Page Up or Down in Memory

When you view memory contents in a **Memory** window or the **Disassembly** window, you can use the vertical scrollbar to move up or down in the memory space.

### To page up or down in memory

1. To page down (move to a higher memory address), click the vertical scrollbar below the scroll box.

2. To page up (move to a lower memory address), click the vertical scrollbar above the thumb.

   You will also notice that the vertical scrollbar operates in a nonstandard manner. The address space of a modern computer is very large, and it would be easy to get lost by grabbing the scrollbar thumb and dragging it to a random location. For this reason, the thumb is "springloaded" and always remains in the center of the scrollbar. In native code applications, you can page up or down, but cannot scroll about freely.

   In managed applications, disassembly is limited to one function and you can scroll normally.

   You will notice that the higher addresses appear at the bottom of the window. To view a higher address, you must move down, not up.

#### To move up or down one instruction

- Click the arrow at the top or bottom of the vertical scrollbar.

## See also
- [Memory Windows](../debugger/memory-windows.md)
- [How to: Use the Disassembly Window](../debugger/how-to-use-the-disassembly-window.md)
- [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)