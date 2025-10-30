---
title: "About the Registers window"
description: Learn about the Registers window in Visual Studio, which is available only if address-level debugging is enabled in the Options dialog box, Debugging node.
ms.date: "11/04/2016"
ms.topic: concept-article
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "Registers window, about Registers window"
  - "debugging [Visual Studio], Registers window"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# About the Registers Window in Visual Studio (C#, C++, Visual Basic, F#)

The **Registers** window is available only if address-level debugging is enabled in the **Options** dialog box, **Debugging** node.

 Registers are special locations within a processor (CPU) that are used to store small pieces of data that the processor is actively working on. Compiling or interpreting source code generates instructions that move data from memory into the registers and back again, as needed. Accessing data in registers is very fast compared to accessing data in memory, so code that allows the processor to keep data in a register and access it repeatedly tends to execute faster than code that requires the processor to constantly load and unload registers. To make it easier for the compiler to keep data in registers, and perform other optimizations, you should avoid using global variables and rely on local variables as much as possible. Code written in this fashion is said to have good locality of reference. In some languages, such as C/C++, the programmer can declare a register variable, which tells the compiler to try its best to keep the variable in a register at all times. For more information, see [Register Keyword](/previous-versions/482s4fy9(v=vs.140)).

 Registers can be divided into two types: general purpose and special purpose. General-purpose registers hold data for general operations such as adding two numbers together or referencing an element in an array. Special-purpose registers have specific purposes and specialized meaning. A good example is the stack-pointer register, which the processor uses to keep track of the program's call stack. As a programmer, you will probably not manipulate the stack pointer directly. However, it is essential to the proper functioning of your program because without the stack pointer, the processor would not know where to return to at the end of a function call.

 Most general-purpose registers hold only a single data element. For example, a single integer, floating-point number, or element of an array. Some newer processors have larger registers, called vector registers, that can hold a small array of data. Because they hold so much data, vector registers permit operations involving arrays to be performed very rapidly. Vector registers were first used on expensive, high-performance supercomputers but are now becoming available on microprocessors where they are used to great advantage in intensive graphic operations.

 A processor usually has two sets of general-purpose registers, one optimized for floating-point operations and the other for integer operations. Not surprisingly, these are called floating-point and integer registers.

 Managed code is compiled at run time to native code that accesses the physical registers of the microprocessor. The **Registers** window displays these physical registers for common language runtime or native code. The **Registers** window does not display register information for script or SQL application, because script and SQL are languages that do not support the concept of registers.

 For more information on displaying the **Registers** window, see [Using the Registers Window](../debugger/how-to-use-the-registers-window.md).

 When you look at the **Registers** window, you will see entries such as `EAX = 003110D8`.

 The symbol to the left of the `=` sign is the register name, `EAX`, in this case. The number to the right of the `=` sign represents the register contents.

 The **Registers** window enables you to do more than just view the contents of a register. When you are in break mode in native code, you can click on the contents of a register and edit the value. This is not something you should do at random. Unless you understand the register you are editing, and the data it contains, the result of careless editing is likely to be a program crash or some other undesired consequence. Unfortunately, a detailed explanation of the register sets of the various Intel and Intel-compatible processors goes far beyond the scope of this brief introduction.

## Register groups

To reduce clutter, the **Registers** window organizes registers into groups. If you right-click on the **Registers** window, you will see a shortcut menu containing a list of groups, which you can display or hide as you see fit.

## Register flags

For Intel x86 processors, you may see the following flags in the **Registers** window. During a debugging session, you can also edit these flags.

|Flag|Set value|
|-|-|
|Overflow|OV = 1|
|Direction|UP = 1|
|Interrupt|EI = 1|
|Sign|PL = 1|
|Zero|ZR = 1|
|Auxiliary carry|AC = 1|
|Parity|PE = 1|
|Carry|CY = 1|

## Related content
- [How to: Use the Registers Window](../debugger/how-to-use-the-registers-window.md)
- [First look at the debugger](../debugger/debugger-feature-tour.md)
