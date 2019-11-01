---
title: "How to: Debug Optimized Code | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "breakpoints, in optimized code"
  - "debugging [C++], optimized code"
  - "optimization, debug builds"
  - "debug builds, optimizing"
  - "optimized code, debugging"
ms.assetid: fc8eeeb8-6629-4c9b-99f7-2016aee81dff
caps.latest.revision: 28
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Debug Optimized Code
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose Import and Export Settings on the Tools menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
> [!NOTE]
> The [/Zo (Enhance Optimized Debugging)](https://msdn.microsoft.com/library/eea8d89a-7fe0-4fe1-86b2-7689bbebbd7f)compiler option (introduced in Visual Studio Update 3) generates richer debugging information for optimized code (projects that are not built with the **/Od** compiler option. See [/O Options (Optimize Code)](https://msdn.microsoft.com/library/77997af9-5555-4b3d-aa57-6615b27d4d5d)). This includes improved support for debugging local variables and inlined functions.  
>   
> [Edit and Continue](../debugger/edit-and-continue-visual-csharp.md) is disabled when the **/Zo** ocompiler option is used.  
  
 When the compiler optimizes code, it repositions and reorganizes instructions. This results in more efficient compiled code. Because of this rearrangement, the debugger cannot always identify the source code that corresponds to a set of instructions.  
  
 Optimization can affect:  
  
- Local variables, which can be removed by the optimizer or moved to locations the debugger does not understand.  
  
- Positions inside a function, which are changed when the optimizer merges blocks of code.  
  
- Function names for frames on the call stack, which might be wrong if the optimizer merges two functions.  
  
  The frames that you see on the call stack are almost always correct, however, assuming you have symbols for all frames. The frames on the call stack will be wrong if you have stack corruption, if you have functions written in assembly language, or if there are operating system frames without matching symbols on the call stack.  
  
  Global and static variables are always shown correctly. So is structure layout. If you have a pointer to a structure and the value of the pointer is correct, every member variable of the structure will show the correct value.  
  
  Because of these limitations, you should debug using an unoptimized version of your program if at all possible. By default, optimization is turned off in the Debug configuration of a Visual C++ program and turned on in the Release configuration.  
  
  However, a bug might appear only in an optimized version of a program. In that case, you must debug the optimized code.  
  
### To turn on optimization in a Debug build configuration  
  
1. When you create a new project, select the `Win32 Debug` target. Use the `Win32``Debug` target until your program is fully debugged and you are ready to build a `Win32 Release` target. The compiler does not optimize the `Win32 Debug` target.  
  
2. Select the project in Solution Explorer.  
  
3. On the **View** menu, click **Property Pages**.  
  
4. In the **Property Pages** dialog box, make sure `Debug` is selected in the **Configuration** drop-down list.  
  
5. In the folder view on the left, select the **C/C++** folder.  
  
6. Under the **C++** folder, select `Optimization`.  
  
7. In the properties list on the right, find `Optimization`. The setting next to it probably says `Disabled (`[/Od](https://msdn.microsoft.com/library/b1ac31b7-e086-4eeb-be5e-488f7513f5f5)`)`. Choose one of the other options (`Minimum Size``(`[/O1](https://msdn.microsoft.com/library/2d1423f5-53d9-44da-8908-b33a351656c2)`)`, `Maximum Speed``(`[/O2](https://msdn.microsoft.com/library/2d1423f5-53d9-44da-8908-b33a351656c2)`)`, `Full Optimization``(`[/Ox](https://msdn.microsoft.com/library/3ad7c30b-c615-428c-b1d0-2e024f81c760)`)`, or `Custom`).  
  
8. If you chose the `Custom` option for `Optimization`, you can now set options for any of the other properties shown in the properties list.  
  
9. Select the Configuration Properties, C/C++, Command Line node of the project properties page, and add `(`[/Zo](https://msdn.microsoft.com/library/eea8d89a-7fe0-4fe1-86b2-7689bbebbd7f)`)` to the **Additional Options** text box.  
  
    > [!WARNING]
    > `/Zo` requires Visual Studio 2013 Update 3 or a later version.  
    >   
    >  Adding `/Zo` will disable [Edit and Continue](../debugger/edit-and-continue-visual-csharp.md).  
  
   When you debug optimized code, use the **Disassembly** window to see what instructions are actually created and executed. When you set breakpoints, you need to know that the breakpoint might move together with an instruction. For example, consider the following code:  
  
```  
for (x=0; x<10; x++)  
```  
  
 Suppose you set a breakpoint at this line. You might expect the breakpoint to be hit 10 times, but if the code is optimized, the breakpoint is hit only one time. That is because the first instruction sets the value of `x` to 0. The compiler recognizes that this only has to be done once and moves it out of the loop. The breakpoint moves with it. The instructions that compare and increment `x` remain inside the loop. When you view the **Disassembly** window, the [step unit](https://msdn.microsoft.com/8791dac9-64d1-4bb9-b59e-8d59af1833f9) is automatically set to Instruction for greater control, which is useful when you step through optimized code.  
  
## See Also  
 [Debugger Security](../debugger/debugger-security.md)   
 [Debugging Native Code](../debugger/debugging-native-code.md)
