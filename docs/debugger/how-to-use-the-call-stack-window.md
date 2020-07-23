---
title: View the call stack in the debugger | Microsoft Docs
ms.custom: seodec18
ms.date: 10/29/2018
ms.topic: how-to
f1_keywords: 
  - vs.debug.callstack
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
  - JScript
  - SQL
  - aspx
helpviewer_keywords: 
  - threading [Visual Studio], displaying calls to or from
  - functions [debugger], viewing code on call stack
  - disassembly code
  - breakpoints, Call Stack window
  - debugging [Visual Studio], switching to another stack frame
  - debugging [Visual Studio], Call Stack window
  - Call Stack window, viewing source code for functions on the call stack
  - stack, switching stack frames
  - Call Stack window, viewing disassembly code for functions on the call stack
ms.assetid: 5154a2a1-4729-4dbb-b675-db611a72a731
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload: 
  - multiple
---
# View the call stack and use the Call Stack window in the debugger

By using the **Call Stack** window, you can view the function or procedure calls that are currently on the stack. The **Call Stack** window shows the order in which methods and functions are getting called. The call stack is a good way to examine and understand the execution flow of an app.

When [debugging symbols](#bkmk_symbols) are not available for part of a call stack, the **Call Stack** window might not be able to display correct information for that part of the call stack, displaying instead:

`[Frames below may be incorrect and/or missing, no symbols loaded for name.dll]`

> [!NOTE]
> The **Call Stack** window is similar to the Debug perspective in some IDEs like Eclipse.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described here, depending on your active settings or edition. To change your settings, select **Import and Export Settings** on the **Tools** menu.  See [Reset settings](../ide/environment-settings.md#reset-settings).

## View the call stack while in the debugger

- While debugging, in the **Debug** menu, select **Windows > Call Stack**.

  ![Call Stack Window](../debugger/media/dbg_basics_callstack_window.png "CallStackWindow")

A yellow arrow identifies the stack frame where the execution pointer is currently located. By default, this stack frame's information appears in the source, **Locals**, **Autos**, **Watch**, and **Disassembly** windows. To change the debugger context to another frame on the stack, [switch to another stack frame](#bkmk_switch).

## Display non-user code in the Call Stack window

- Right-click the **Call Stack** window and select **Show External Code**.

Non-user code is any code that is not shown when [Just My Code](../debugger/just-my-code.md) is enabled. In managed code, non-user code frames are hidden by default. The following notation appears in place of the non-user code frames:

`[<External Code>]`

## <a name="bkmk_switch"></a> Switch to another stack frame (change the debugger context)

1. In the **Call Stack** window, right-click the stack frame whose code and data that you want to view.

    Or, you can double-click a frame in the **Call Stack** window to switch to that frame.

2. Select **Switch to Frame**.

     A green arrow with a curly tail appears next to the stack frame you selected. The execution pointer remains in the original frame, which is still marked with the yellow arrow. If you select **Step** or **Continue** from the **Debug** menu, execution will continue in the original frame, not the frame you selected.

## View the source code for a function on the call stack

- In the **Call Stack** window, right-click the function whose source code you want to see and select **Go To Source Code**.

## Run to a specific function from the Call Stack window

- In the **Call Stack** window, select the function, right-click, and then choose **Run to Cursor**.

## Set a breakpoint on the exit point of a function call

- See [Set a breakpoint at a call stack function](../debugger/using-breakpoints.md#BKMK_Set_a_breakpoint_from_debugger_windows).

## Display calls to or from another thread

- Right-click the **Call Stack** window and select **Include Calls To/From Other Threads**.

## Visually trace the call stack

In Visual Studio Enterprise (only), you can view code maps for the call stack while debugging.

- In the **Call Stack** window, open the shortcut menu. Choose **Show Call Stack on Code Map** (**Ctrl** + **Shift** + **`**).

    For more information, see [Map methods on the call stack while debugging](../debugger/map-methods-on-the-call-stack-while-debugging-in-visual-studio.md).

![Show Call Stack on Code Map](../debugger/media/dbg_basics_show_call_stack_on_code_map.gif "ShowCallStackOnCodeMap")

## View the disassembly code for a function on the call stack (C#, C++, Visual Basic, F#)

- In the **Call Stack** window, right-click the function whose disassembly code you want to see and select **Go To Disassembly**.

## Change the optional information displayed

- Right-click in the **Call Stack** window and set or clear **Show \<**_the information that you want_**>**.

## <a name="bkmk_symbols"></a> Load symbols for a module (C#, C++, Visual Basic, F#)

In the **Call Stack** window, you can load debugging symbols for code that does not currently have symbols loaded. These symbols can be .NET or system symbols downloaded from the Microsoft public symbol servers, or symbols in a symbol path on the computer that you are debugging.

See [Specify symbol (.pdb) and source files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).

### To load symbols

1. In the **Call Stack** window, right-click the stack frame for which symbols are not loaded. The frame will be dimmed.

2. Point to **Load Symbols** and then select **Microsoft Symbol Servers** (if available), or browse to the symbol path.

### To set the symbol path

1. In the **Call Stack** window, choose **Symbol Settings** from the shortcut menu.

     The **Options** dialog box opens and the **Symbols** page is displayed.

2. Select **Symbol Settings**.

3. In the **Options** dialog box, click the Folder icon.

     In the **Symbol file (.pdb) locations** box, a cursor appears.

4. Enter a directory pathname to the symbol location on the computer that you are debugging. For local and remote debugging, this is a path on your local computer.

5. Select **OK** to close the **Options** dialog box.

## See also

- [Mixed code and missing information in the Call Stack window](../debugger/mixed-code-and-missing-information-in-the-call-stack-window.md)
- [Viewing data in the debugger](../debugger/viewing-data-in-the-debugger.md)
- [Specify symbol (.pdb) and source files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)
- [Using breakpoints](../debugger/using-breakpoints.md)