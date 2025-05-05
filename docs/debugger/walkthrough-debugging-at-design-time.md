---
title: "Debug at design time"
description: Use the Immediate window to debug code at design time, without running the app. You can execute a function and examine the state when a breakpoint is hit.
ms.date: "06/06/2023"
ms.topic: "conceptual"
dev_langs:
  - "VB"
helpviewer_keywords:
  - "debugging [Visual Studio], design-time"
  - "breakpoints, design-time debugging"
  - "Immediate window, design-time debugging"
  - "design-time debugging"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debug at design time in Visual Studio (C#, C++/CLI, Visual Basic, F#)

To debug code at design time instead of while an app is running, you can use the **Immediate** window.

To debug XAML code behind an app from the XAML designer, such as declarative data binding scenarios, you can use **Debug** > **Attach to Process**.

## Use the Immediate window

You can use the Visual Studio **Immediate** window to execute a function or subroutine without running your app. If the function or subroutine contains a breakpoint, Visual Studio will break at the breakpoint. You can then use the debugger windows to examine your program state. This feature is called *debugging at design time*. For detailed information, see [Use the Immediate window](../ide/reference/immediate-window.md)

The following example is in Visual Basic. You can also use the **Immediate** window at design time in C#, F#, and C++/CLI apps. For C++/CLI, compile without the /clr option to use the Immediate window.

1. Paste the following code into a blank Visual Basic console app:

   ```vb
   Module Module1

       Sub Main()
           MySub()
       End Sub

       Function MyFunction() As Decimal
           Static i As Integer
           i = i + 1
           Return i
       End Function

       Sub MySub()
           MyFunction()

       End Sub
   End Module
   ```

1. Set a breakpoint on the line **End Function**.

1. Open the **Immediate** window by selecting **Debug** > **Windows** > **Immediate**. Type `?MyFunction` in the window, and then press **Enter**.

   The breakpoint is hit, and the value of **MyFunction** in the **Locals** window is **1**. You can examine the call stack and other debugging windows while the app is in break mode.

1. Select **Continue** on the Visual Studio toolbar. The app ends, and **1** is returned in the **Immediate** window. Make sure you are still in design mode.

1. Type `?MyFunction` in the **Immediate** window again, and press **Enter**. The breakpoint is hit, and the value of **MyFunction** in the **Locals** window is **2**.

1. Without selecting **Continue**, type `?MySub()` in the **Immediate** window, and then press **Enter**. The breakpoint is hit, and the value of **MyFunction** in the **Locals** window is **3**. You can examine the app state while the app is in break mode.

1. Select **Continue**. The breakpoint is hit again, and the value of **MyFunction** in the **Locals** window is now **2**. The **Immediate** window returns **Expression has been evaluated and has no value**.

1. Select **Continue** again. The app ends, and **2** is returned in the **Immediate** window. Make sure that you are still in design mode.

1. To clear the contents of the **Immediate** window, right-click in the window and select **Clear All**.

## Debug a custom XAML control at design time by attaching to XAML designer

1. Open your solution or project in Visual Studio.

1. Build the solution/project.

1. Open the XAML page containing the custom control that you want to debug.

   For UWP projects targeting Windows build 16299 or above, this step will start the *UwpSurface.exe* process. For WPF projects targeting Windows build 16299 or above, this step will start the *WpfSurface.exe* process. For WPF or UWP versions prior to Windows build 16299, this step will start the *XDesProc.exe* process. 

1. Open a second instance of Visual Studio. Do not open a solution or project in the second instance.

1. In the second instance of Visual Studio, open the **Debug** menu and choose **Attach to Process…**.

1. Depending on your project type (see preceding steps), select the *UwpSurface.exe*, *WpfSurface.exe*, or the *XDesProc.exe* process from the list of available processes.

1. In the **Attach to** field of the **Attach to Process** dialog, choose the correct code type for the custom control you want to debug.

   If your custom control has been written in a .NET language, choose the appropriate .NET code type such as **Managed (CoreCLR)**. If your custom control has been written in C++, choose **Native**.

1. Attach the second instance of Visual Studio by clicking the **Attach** button.

1. In the second instance of Visual Studio, open the code files associated with the custom control you want to debug. Make sure to just open the files, not the entire solution or project.

1. Place the necessary breakpoints in the previously opened files.

1. In the first instance of Visual Studio, close the XAML page containing the custom control you want to debug (the same page you opened in earlier steps).

1. In the first instance of Visual Studio, open the XAML page you closed in the previous step. This will cause the debugger to stop at the first breakpoint you set in the second instance of Visual Studio.

1. Debug the code in the second instance of Visual Studio.

## Related content
- [First look at the debugger](../debugger/debugger-feature-tour.md)
- [Debugger security](../debugger/debugger-security.md)