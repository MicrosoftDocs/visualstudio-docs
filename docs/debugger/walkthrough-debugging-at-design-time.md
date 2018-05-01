---
title: "Debug at Design Time - Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "02/21/2018"
ms.technology: "vs-ide-debug"
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
manager: douge
ms.workload: 
  - "multiple"
---
# Debug at Design Time in Visual Studio

In some scenarios, you may want to debug code at design time instead of while the application is running. You can do this using the **Immediate** window. If you want to debug XAML code that interacts with other code, such as data binding code, you can use **Debug** > **Attach to Process** to do that.
  
### Debug at design time using the Immediate window  

You can use the Visual Studio **Immediate** window to execute a function or subroutine while your application is not running. If the function or subroutine contains a breakpoint, Visual Studio will break execution at the appropriate point. You can then use the debugger windows to examine your program state. This feature is called debugging at design time.  

The following example is in Visual Basic, but the **Immediate** window is also supported in C# and C++ applications.
  
1.  Paste the following code into a Visual Basic console application:  
  
    ```vb  
    Module Module1  
  
        Sub Main()  
            MySub()  
        End Sub  
  
        Function MyFunction() As Decimal  
            Static i As Integer  
            i = i + 1  
            Dim s As String  
  
            s = "Add Breakpoint here"  
            Return 4  
        End Function  
  
        Sub MySub()  
            MyFunction()  
        End Sub  
    End Module  
    ```  
  
2.  Set a breakpoint on the line that reads, `s="Add BreakPoint Here"`.  
  
3.  Open the **Immediate** window (**Debug** > **Windows** > **Immediate**) and type the following in the window: `?MyFunction<enter>`  
  
4.  Verify that the breakpoint was hit, and that the call stack is accurate.  
  
5.  On the **Debug** menu, click **Continue**, and verify that you are still in design mode.  
  
6.  Type the following in the **Immediate** window: `?MyFunction<enter>`  
  
7.  Type the following in the **Immediate** window: `?MySub<enter>`  
  
8.  Verify that you hit the breakpoint, and examine the value of static variable `i` in the **Locals** window. It should have the value of 3.  
  
9. Verify that the call stack is accurate.  
  
10. On the **Debug** menu, click **Continue**, and verify that you are still in design mode.  

## Debug at design time from the XAML designer

It can be helpful to debug code behind from the XAML designer in some declarative data binding scenarios.

1. In your project, add a new XAML page, such as *temp.xaml*. Leave the new XAML page empty. 

1. Compile your solution.

1. Open *temp.xaml*, which loads the designer (*UwpSurface.exe* in a UWP app, or *XDesProc.exe*) so you can attach to it in later steps. 

1. Open a new instance of Visual Studio. In the new instance, open the **Attach to Process** dialog box (**Debug** > **Attach to Process**), set the **Attach to** field to the correct code type, such as **Managed Code (CoreCLR)** or the correct code type based on your .NET version. Select the correct designer process from the list and choose **Attach**.

    For UWP projects targeting build 16299 or above, the designer process is *UwpSurface.exe*. For WPF or versions of UWP previous to 16299, the designer process is *XDesProc.exe*.

1. While attached to the process, switch to your project, open the code behind where you want to debug, and set a breakpoint.

1. Finally, open the page that contains the XAML code that includes data binding.

    For example, you could set a breakpoint in the type converter code for the following XAML, which binds a TextBlock at design time.

    ```xaml
    <TextBlock Text="{Binding title, ConverterParameter=lower, Converter={StaticResource StringFormatConverter}, Mode=TwoWay}"  />
    ```
   When the page loads, the breakpoint is hit.
  
## See Also  
 [Debugger Security](../debugger/debugger-security.md)   
 [Debugger Basics](../debugger/debugger-basics.md)
