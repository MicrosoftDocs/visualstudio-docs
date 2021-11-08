---
title: View Disassembly Code in the debugger | Microsoft Docs
description: Use the Disassembly window in Visual Studio to show assembly code corresponding to the instructions created by the compiler.

ms.date: 10/30/2018
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
ms.assetid: eaf84dd0-c82d-481b-af51-690b74e7794c
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# View disassembly code in the Visual Studio debugger (C#, C++, Visual Basic, F#)

The **Disassembly** window shows assembly code corresponding to the instructions created by the compiler. If you're debugging managed code, these assembly instructions correspond to the native code created by the Just-in-Time (JIT) compiler, not the Microsoft intermediate language (MSIL) created by the Visual Studio compiler.

> [!NOTE]
> To take full advantage of the **Disassembly** window, understand or learn the basics of [assembly-language programming](https://wikipedia.org/wiki/Assembly_language).

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

To open the **Disassembly** window during debugging, select **Windows** > **Disassembly** or press **Alt**+**8**.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../ide/environment-settings.md#reset-settings).

To turn optional information on or off, right-click in the **Disassembly** window, and set or clear the desired options in the shortcut menu.

A yellow arrow in the left margin marks the current execution point. For native code, the execution point corresponds to the CPU's program counter. This location shows the next instruction that will be executed in your program.

## See also

* [Paging up or down in memory](../debugger/how-to-page-up-or-down-in-memory.md)
* [Viewing data in the debugger](../debugger/viewing-data-in-the-debugger.md)
* [How to: Use the Registers window](../debugger/how-to-use-the-registers-window.md)