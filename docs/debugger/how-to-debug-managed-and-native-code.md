---
title: "Tutorial: Debug managed and native code | Microsoft Docs"
description: Learn how to debug a native DLL from a C# app
ms.custom: ""
ms.date: "04/27/2018"
ms.technology: "vs-ide-debug"
ms.topic: "tutorial"
dev_langs: 
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "mixed mode debugging"
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "dotnet"
  - "cplusplus"
---
# How to: Debug managed and native code in Visual Studio

Visual Studio allows you to enable more than one debugger type when debugging, which is called mixed mode debugging. In this article, we set options to debug both managed and native code in a single debugging session.

In this tutorial, you will:

> [!div class="checklist"]
> * Create a simple native DLL
> * Create a simple C# app to call the DLL
> * Start the debugger
> * Hit a breakpoint in the C# app
> * Step into native code

## Prerequisites


## Create a simple native DLL

1. In Visual Studio, choose **File** > **New** > **Project**.

1. In the **New Project** dialog box, choose **Visual C++**, **General** from the installed templates section, and then in the middel pane select **Empty Project**.

1. In the **Name** field, type **Mixed-Mode-Debugging** and click **OK**.

    Visual Studio creates the empty project, which appears in Solution Explorer in the right pane.

1. In Solution Explorer, right-click the **Source Files** node in the C++ project and choose **Add** > **New Item**, and then select **C++ file (.cpp)**, give the file the name **Mixed-Mode.cpp**, and choose **Add**.

    Visual Studio adds the new C++ file.

1. Copy the following code into *Mixed-Mode.cpp*:

    ```cpp
    #include "Mixed_Mode.h"
    ```
1. In Solution Explorer, right-click the **Header Files** node in the C++ project and choose **Add** > **New Item**, and then select **Header file (.h)**, give the file the name **Mixed-Mode.h**, and choose **Add**.

    Visual Studio adds the new header file.

1. Copy the following code into *Mixed-Mode.h*:

    ```cpp
    #ifndef MIXED_MODE_MULTIPLY_HPP
    #define MIXED_MODE_MULTIPLY_HPP
    
    extern "C"
    {
    	__declspec(dllexport) int __stdcall mixed_mode_multiply(int a, int b) {
    		return a * b;
    	}
    }
    #endif
    ```

1. From the Debug toolbar, select a **Release** configuration and **Any CPU** as the platform.

    [screenshot]

    [important: give .NET Core instructions or remove it!! Need to use x64 to compile it!!!]

1. In Solution Explorer, right-click the project node (**Mixed-Mode-Debugging**) and choose **Properties**.

1. In the **Properties** page, choose **Configuration Properties** > **Linker** > **Advanced**, and then in the **No Entry Point** drop-down list, select **YES (/NOENTRY)**.

    [screenshot]

1. In the **Properties** page, choose **Configuration Properties** > **General**, and then select **Dynamic Link Library (.dll)** from the **Configuration Type** field.

1. Right-click the project and choose **Debug** > **Build**.

    If you see any build errors, make sure you selected a Release build in the previous steps.

## Create a simple .NET Framework app to call the DLL

1. In Visual Studio, choose **File** > **New** > **Project**.

1. In the **New Project** dialog box, choose **Visual C#**, **Windows Classic Desktop** from the installed templates section, and then in the middel pane select **Console App (.NET Framework)**.

1. In the **Name** field, type **Mixed_Mode_DotNet** and click **OK**.

    Visual Studio creates the console project, which appears in Solution Explorer in the right pane.

1. In Program.cs, replace the default code with the following code:

    ```c#
    using System;
    using System.Runtime.InteropServices;
    
    namespace Mixed_Mode_DotNet
    {
        public class Program
        {
            // Replace the file path shown here with the
            // file path on your computer.
            [DllImport(@"C:\Users\username\source\repos\Mixed-Mode-Debugging\Release\Mixed-Mode-Debugging.dll", EntryPoint =
            "mixed_mode_multiply", CallingConvention = CallingConvention.StdCall)]
            public static extern int Multiply(int x, int y);
            public static void Main(string[] args)
            { 
                int result = Multiply(7, 7);
                Console.WriteLine("The answer is {0}", result);
                Console.ReadKey();
            }
        }
    }
    ```

## Configure mixed mode debugging

1. In Solution Explorer, right click the **Mixed_Mode_DotNet** project and choose **Set as Startup Project**.

1. right click the **Mixed_Mode_DotNet** project and choose **Properties**, and then choose **Debug** in the left pane, select **Enable native code debugging**, and then close the properties page to save the changes.

## Set a breakpoint and start the debugger

1. In the Debug toolbar, switch to a **Debug** build.

    This will allow you to step into code with the debugger and hit breakpoints.

1. In the C# project, open Program.cs and set a breakpoint in the following line of code by clicking in the left margin:

    ```c#
    int result = Multiply(7, 7);
    ```

    A red circle appears in the left margin to indicate that you have set the breakpoint.

1. Press **F5** (**Debug** > **Start Debugging**) to start the debugger.

    The debugger pauses on the breakpoint that you set. A yellow arrow indicates where the debugger is currently paused.

## Step into native code

1. While paused in the managed app, press **F11** (**Debug** > **Step Into**).

    The header file with the native code opens and you see the yellow arrow where the debugger is paused. Note that we are able to debug the release version of the DLL because the [symbol files]() are available in the same folder as the DLL itself.

1. Hover over the variables to see their value.

1. Look at the **Autos** and **Locals** windows to see variable and their values.

    While paused in the debugger, you can use other debugger features such as the **Watch** window and the **Call Stack** window.

1. Press **F11** again to advance the debugger one line.

1. Press **Shift + F11** (**Debug** > **Step Out**) to continue app execution and pause again in the managed app.

1. Press **F5** to continue the app.

    Congratulations! You have completed the tutorial on mixed mode debugging.

## Next steps