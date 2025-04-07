---
title: Debug optimized code after compilation
description: If possible, don't build a Win32 Release target until your program is debugged, because optimization can complicate debugging. See the details in this article.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vs.debug
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - breakpoints, in optimized code
  - debugging [C++], optimized code
  - optimization, debug builds
  - debug builds, optimizing
  - optimized code, debugging
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debug Optimized Code

This article explains which compiler switches to set to enable you to debug optimized code better.

A better experience is available starting in Visual Studio 2022 version 17.14 that allows you to debug optimized code as if it were compiled unoptimized, while retaining the speed of optimized code. For more information, see [C++ Dynamic Debugging (Preview)](cpp-dynamic-debugging.md).

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset all settings](../ide/personalizing-the-visual-studio-ide.md#reset-all-settings).

> [!NOTE]
> The [/Zo (Enhance Optimized Debugging)](/cpp/build/reference/zo-enhance-optimized-debugging) compiler option (introduced in Visual Studio Update 3) generates richer debugging information for optimized code (projects that aren't built with the **/Od** compiler option. See [/O Options (Optimize Code)](/cpp/build/reference/o-options-optimize-code)). This includes improved support for debugging local variables and inlined functions.
>
> [Edit and Continue](../debugger/edit-and-continue-visual-csharp.md) is disabled when the **/Zo** compiler option is used.

 When the compiler optimizes code, it repositions and reorganizes instructions. This results in more efficient compiled code. Because of this rearrangement, the debugger can't always identify the source code that corresponds to a set of instructions.

 Optimization can affect:

- The optimizer can remove local variables or move them to locations that the debugger doesn't understand.
- Positions inside a function, which are changed when the optimizer merges blocks of code.
- Function names for frames on the call stack, which might be wrong if the optimizer merges two functions.

  The frames that you see on the call stack are almost always correct, however, assuming you have symbols for all frames. The frames on the call stack will be wrong if you have stack corruption, if you have functions written in assembly language, or if there are operating system frames without matching symbols on the call stack.

  Global and static variables are always shown correctly. So is structure layout. If you have a pointer to a structure and the value of the pointer is correct, every member variable of the structure will show the correct value.

  Because of these limitations, you should debug using an unoptimized version of your program if at all possible. By default, optimization is turned off in the Debug configuration of a C++ program and turned on in the Release configuration.

  However, a bug might appear only in an optimized version of a program. In that case, you must debug the optimized code.

## To turn on optimization in a Debug build configuration

1. When you create a new project, select the `Win32 Debug` target. Use the `Win32 Debug` target until your program is fully debugged and you're ready to build a `Win32 Release` target. The compiler doesn't optimize the `Win32 Debug` target.

2. Select the project in Solution Explorer.

3. On the **View** menu, click **Property Pages**.

4. In the **Property Pages** dialog box, make sure `Debug` is selected in the **Configuration** drop-down list.

5. In the folder view on the left, select the **C/C++** folder.

6. Under the **C++** folder, select `Optimization`.

7. In the properties list on the right, find `Optimization`. The setting next to it probably says `Disabled (`[/Od](/cpp/build/reference/od-disable-debug)`)`. Choose one of the other options (`Minimum Size``(`[/O1](/cpp/build/reference/o1-o2-minimize-size-maximize-speed)`)`, `Maximum Speed``(`[/O2](/cpp/build/reference/o1-o2-minimize-size-maximize-speed)`)`, `Full Optimization``(`[/Ox](/cpp/build/reference/ox-full-optimization)`)`, or `Custom`).

8. If you chose the `Custom` option for `Optimization`, you can now set options for any of the other properties shown in the properties list.

9. Select the Configuration Properties, C/C++, Command Line node of the project properties page, and add `(`[/Zo](/cpp/build/reference/zo-enhance-optimized-debugging)`)` to the **Additional Options** text box.

    > [!WARNING]
    >
    > Adding `/Zo` disables [Edit and Continue](../debugger/edit-and-continue-visual-csharp.md).

   When you debug optimized code, use the **Disassembly** window to see what instructions are created and executed. When you set breakpoints, you need to know that the breakpoint might move together with an instruction. For example, consider the following code:

```cpp
for (x=0; x<10; x++)
```

 Suppose you set a breakpoint at this line. You might expect the breakpoint to be hit 10 times, but if the code is optimized, the breakpoint is hit only one time. That is because the first instruction sets the value of `x` to 0. The compiler recognizes that this only has to be done once and moves it out of the loop. The breakpoint moves with it. The instructions that compare and increment `x` remain inside the loop. When you view the **Disassembly** window, the [step unit](/previous-versions/visualstudio/visual-studio-2010/ek13f001(v=vs.100)) is automatically set to Instruction for greater control, which is useful when you step through optimized code.

## Related content

- [Debugger Security](../debugger/debugger-security.md)
- [Debugging Native Code](../debugger/debugging-native-code.md)