---
title: View Disassembly Code in the debugger
description: Use the Disassembly window in Visual Studio to show assembly code corresponding to the instructions created by the compiler.
ms.date: 04/18/2025
ms.topic: how-to
f1_keywords: 
  - vs.debug.disassembly
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
  - JScript
helpviewer_keywords: 
  - assembly language, debugging inline assembly code
  - breakpoints, Disassembly window
  - Disassembly window
  - machine code
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# View disassembly code in the Visual Studio debugger (C#, C++, Visual Basic, F#)

The **Disassembly** window shows assembly code corresponding to the instructions created by the compiler. If you're debugging managed code, these assembly instructions correspond to the native code created by the Just-in-Time (JIT) compiler, not the Microsoft intermediate language (MSIL) created by the Visual Studio compiler.

> [!NOTE]
> To take full advantage of the **Disassembly** window, understand or learn the basics of [assembly-language programming](https://wikipedia.org/wiki/Assembly_language). Reference material for Intel instruction sets are found in the 2nd volume of the [architecture manuals](https://www.intel.com/content/www/us/en/developer/articles/technical/intel-sdm.html#three-volume). This material generally applies to AMD instruction sets as well.

This feature is only available if address-level debugging is enabled. It isn't available for script or SQL debugging.

In addition to assembly instructions, the **Disassembly** window can show the following optional information:

- Memory address where each instruction is located. For native applications, it is the actual memory address. For Visual Basic or C#, it's an offset from the beginning of the function.

- Source code from which the assembly code derives.

- Code bytes, that is, the byte representations of the actual machine or MSIL instructions.

- Symbol names for the memory addresses.

- Line numbers corresponding to the source code.

Assembly-language instructions consist of *mnemonics*, which are abbreviations for instruction names, and *symbols* for variables, registers, and constants. Each machine-language instruction is represented by one assembly-language mnemonic optionally followed by one or more symbols.

Assembly code relies heavily on processor registers or, for managed code, common language runtime registers. You can use the **Disassembly** window along with the **Registers** window, which allows you to examine register contents.

To view machine-code instructions in their raw numeric form, rather than as assembly language, use the **Memory** window or select **Code Bytes** from the shortcut menu in the **Disassembly** window.

## Use the Disassembly window

To enable the **Disassembly** window, under **Tools** > **Options** > **Debugging**, select **Enable address-level debugging**.

To open the **Disassembly** window during debugging, select **Debug** > **Windows** > **Disassembly** or press **Ctrl** + **Alt** + **D**.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in this article depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset all settings](../ide/personalizing-the-visual-studio-ide.md#reset-all-settings).

To turn optional information on or off, right-click in the **Disassembly** window, and set or clear the desired options in the shortcut menu.

A yellow arrow in the left margin marks the current execution point. For native code, the execution point corresponds to the CPU's program counter. This location shows the next instruction that will be executed in your program.

## Page up or down in memory

When you view memory contents in a **Memory** window or the **Disassembly** window, you can use the vertical scrollbar to move up or down in the memory space.

1. To page down (move to a higher memory address), click the vertical scrollbar below the scroll box.

2. To page up (move to a lower memory address), click the vertical scrollbar above the thumb.

   You will also notice that the vertical scrollbar operates in a nonstandard manner. The address space of a modern computer is very large, and it would be easy to get lost by grabbing the scrollbar thumb and dragging it to a random location. For this reason, the thumb is "springloaded" and always remains in the center of the scrollbar. In native code applications, you can page up or down, but cannot scroll about freely.

   In managed applications, disassembly is limited to one function and you can scroll normally.

   You will notice that the higher addresses appear at the bottom of the window. To view a higher address, you must move down, not up.

### Move up or down one instruction

- Click the arrow at the top or bottom of the vertical scrollbar.

## Related content

* [Viewing data in the debugger](../debugger/viewing-data-in-the-debugger.md)
* [How to: Use the Registers window](../debugger/how-to-use-the-registers-window.md)