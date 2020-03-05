---
title: "How to: Use the Call Stack Window | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.callstack"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "SQL"
  - "aspx"
helpviewer_keywords: 
  - "threading [Visual Studio], displaying calls to or from"
  - "functions [debugger], viewing code on call stack"
  - "disassembly code"
  - "breakpoints, Call Stack window"
  - "debugging [Visual Studio], switching to another stack frame"
  - "debugging [Visual Studio], Call Stack window"
  - "Call Stack window, viewing source code for functions on the call stack"
  - "stack, switching stack frames"
  - "Call Stack window, viewing disassembly code for functions on the call stack"
ms.assetid: 5154a2a1-4729-4dbb-b675-db611a72a731
caps.latest.revision: 45
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Use the Call Stack Window
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By using the **Call Stack** window, you can view the function or procedure calls that are currently on the stack.  
  
 The **Call Stack** window displays the name of each function and the programming language that it is written in. The function or procedure name may be accompanied by optional information, such as module name, line number, and parameter names, types, and values. The display of this optional information can be turned on or off.  
  
 A yellow arrow identifies the stack frame where the execution pointer is currently located. By default, this is the frame whose information appears in the source, **Disassembly**, **Locals**, **Watch**, and **Autos** windows. If you want to change the context to another frame on the stack, you can do that in the **Call Stack** window.  
  
 When debugging symbols are not available for part of a call stack, the **Call Stack** window might not be able to display correct information for that part of the call stack. The following notation appears:  
  
 [Frames below may be incorrect and/or missing, no symbols loaded for name.dll]  
  
 In managed code, by default. the **Call Stack** window hides information for non-user code. The following notation appears instead of the hidden information:  
  
 **[\<External Code>]**  
  
 Non-user code is any code that is not "My Code You can choose to display the call stack information for non-user code by using the shortcut menu.  
  
 By using the shortcut menu, you can choose whether to see calls between threads.  
  
> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help, depending on your active settings or edition. To change your settings, select **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To display the Call Stack window in break mode or in run mode  
  
- On the **Debug** menu, select **Windows** and then click **Call Stack**.  
  
### To change the optional information displayed  
  
- Right-click the **Call Stack** window and set or clear **Show \<**_the information that you want_**>**.  
  
### To display non-user code frames in the Call Stack window  
  
- Right-click the **Call Stack** window and select **Show External Code**.  
  
### To switch to another stack frame  
  
1. In the **Call Stack** window, right-click the frame whose code and data that you want to view.  
  
2. Select **Switch to Frame**.  
  
     A green arrow with a curly tail appears next to the frame you selected. The execution pointer remains in the original frame, which is still marked with the yellow arrow. If you select **Step** or **Continue** from the **Debug** menu, execution will continue in the original frame, not the frame you selected.  
  
### To display calls to or from another thread  
  
- Right-click the **Call Stack** window and select **Include Calls To/From Other Threads**.  
  
### To view the source code for a function on the call stack  
  
- In the **Call Stack** window, right-click the function whose source code you want to see and select **Go To Source Code**.  
  
### To visually trace the call stack  
  
1. In the **Call Stack** window, open the shortcut menu. Choose **Show Call Stack on Code Map**. (Keyboard: **CTRL** + **SHIFT** + **`**)  
  
     See [Map methods on the call stack while debugging](../debugger/map-methods-on-the-call-stack-while-debugging-in-visual-studio.md).  
  
### To view the disassembly code for a function on the call stack  
  
- In the **Call Stack** window, right-click the function whose disassembly code you want to see and select **Go To Disassembly**.  
  
### To run to a specific function from the Call Stack window  
  
- In the **Call Stack** window, select the function, right-click and  choose **Run to Cursor**.  
  
### To set a breakpoint on the exit point of a function call  
  
- See [Set a breakpoint at a call stack function](../debugger/using-breakpoints.md#BKMK_Set_a_breakpoint_in_the_call_stack_window).  
  
### To load symbols for a module  
  
- In the **Call Stack** window, right-click the frame that shows the module whose symbols you want to reload and select **Load Symbols**.  
  
## Loading Symbols  
 In the **Call Stack** window, you can load debugging symbols for code that does not currently have symbols loaded. These symbols can be .NET Framework or system symbols downloaded from the Microsoft public symbol servers or symbols in a symbol path on the computer that you are debugging.  
  
 See [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)  
  
#### To load symbols  
  
1. In the **Call Stack** window, right-click the frame for which symbols are not loaded. The frame will be dimmed.  
  
2. Point to **Load Symbols From** and then click **Microsoft Symbol Servers** or **Symbol Path**.  
  
#### To set the symbol path  
  
1. In the **Call Stack** window, choose **Symbol Settings** from the shortcut menu.  
  
     The **Options** dialog box opens and the **Symbols** page is displayed.  
  
2. Click **Symbol Settings**.  
  
3. In the **Options** dialog box, click the Folder icon.  
  
     In the **Symbol file (.pdb) locations** box, a cursor appears.  
  
4. Type a directory pathname to the symbol location on the computer that you are debugging. For local debugging, this is your local computer. For remote debugging, it is the remote computer.  
  
5. Click **OK** to close the **Options** dialog box.  
  
## See Also  
 [Mixed Code and Missing Information in the Call Stack Window](../debugger/mixed-code-and-missing-information-in-the-call-stack-window.md)   
 [How to: Change the Numeric Format of Debugger Windows](https://msdn.microsoft.com/library/cd593847-a625-411d-a430-b798346ef18f)   
 [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)   
 [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)   
 [Using Breakpoints](../debugger/using-breakpoints.md)
