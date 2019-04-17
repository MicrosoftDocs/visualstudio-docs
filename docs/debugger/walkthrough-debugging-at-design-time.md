---
title: "Debug at design time | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/21/2018"
ms.topic: "conceptual"
dev_langs:
  - "VB"
helpviewer_keywords:
  - "debugging [Visual Studio], design-time"
  - "breakpoints, design-time debugging"
  - "Immediate window, design-time debugging"
  - "design-time debugging"
ms.assetid: 35bfdd2c-6f60-4be1-ba9d-55fce70ee4d8
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Debug at design time in Visual Studio (C#, C++, Visual Basic, F#)

To debug code at design time instead of while an app is running, you can use the **Immediate** window.

To debug XAML code behind an app from the XAML designer, such as data binding code, you can use **Debug** > **Attach to Process**.

## Use the Immediate window

You can use the Visual Studio **Immediate** window to execute a function or subroutine without running your app. If the function or subroutine contains a breakpoint, Visual Studio will break at the breakpoint. You can then use the debugger windows to examine your program state. This feature is called *debugging at design time*.

The following example is in Visual Basic. You can also use the **Immediate** window at design time in C#, F#, and C++ apps.

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

## Attach to an app from the XAML designer

In some declarative data binding scenarios, it can help to debug code behind in the XAML designer.

1. In the Visual Studio project, add a new XAML page, such as *temp.xaml*. Leave the new XAML page empty.

1. Build the solution.

1. Open *temp.xaml*, which loads the XAML designer, *XDesProc.exe*, or *UwpSurface.exe* in a UWP app.

1. Open a new instance of Visual Studio. In the new instance, select **Debug** > **Attach to Process**.

1. In the **Attach to Process** dialog box, select the designer process from the **Available Processes** list.

   For UWP projects targeting Windows build 16299 or above, the designer process is *UwpSurface.exe*. For WPF or UWP versions previous to 16299, the designer process is *XDesProc.exe*.

1. Make sure the **Attach to** field is set to the correct code type for your .NET version, such as **Managed Code (CoreCLR)**.

1. Select **Attach**.

1. While attached to the process, switch to the other Visual Studio instance, and set breakpoints where you want to debug the code behind your app.

   For example, you could set a breakpoint in the type converter code for the following XAML, which binds a TextBlock at design time.

    ```xaml
    <TextBlock Text="{Binding title, ConverterParameter=lower, Converter={StaticResource StringFormatConverter}, Mode=TwoWay}"  />
    ```

   When the page loads, the breakpoint is hit.

## See also
- [First look at the debugger](../debugger/debugger-feature-tour.md)
- [Debugger security](../debugger/debugger-security.md)