---
title: Debug dynamic-link library (DLL) files and projects
description: Debug dynamic-link library (DLL) files in Visual Studio, and use Visual Studio to create, build, configure, and debug DLLs.
ms.date: "04/15/2025"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging DLLs"
  - "templates, debugging DLLs"
  - "DLLs, debugging"
  - "debugging [Visual Studio], DLLs"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Debug DLLs in Visual Studio (C#, C++, Visual Basic, F#)

A DLL (dynamic-link library) is a library that contains code and data that can be used by more than one app. You can use Visual Studio to create, build, configure, and debug DLLs.

## Create a DLL

The following Visual Studio project templates can create DLLs:

- Class Library (.NET, .NET Framework, and other app platforms)
- Windows Forms Control Library (.NET and .NET Framework)
- Dynamic-Link Library (DLL) (C++)

Debugging a Windows Forms Control Library is similar to debugging a Class Library. For more information, see [Windows Forms Controls](/dotnet/framework/winforms/controls/index).

You usually call a DLL from another project. When you debug the calling project, depending on the DLL configuration, you can step into and debug the DLL code.

## <a name="vxtskdebuggingdllprojectschangingdefaultconfigurations"></a> DLL debug configuration

When you use a Visual Studio project template to create an app, Visual Studio automatically creates required settings for Debug and Release build configurations. You can change these settings if necessary. For more information, see the following articles:

- [How to: Set Debug and Release configurations](../debugger/how-to-set-debug-and-release-configurations.md)
- [Project settings for a C++ debug configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)
- [Project settings for .NET C# debug configurations](../debugger/project-settings-for-csharp-debug-configurations-dotnetcore.md)
- [Project settings for C# debug configurations](../debugger/project-settings-for-csharp-debug-configurations.md)
- [Project settings for a Visual Basic debug configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)

### Set C++ DebuggableAttribute

For the debugger to attach to a C++ DLL, the C++ code must emit `DebuggableAttribute`.

**To set `DebuggableAttribute`:**

1. Select the C++ DLL project in **Solution Explorer** and select the **Properties** icon, or right-click the project and select **Properties**.

1. In the **Properties** pane, under **Linker** > **Debugging**, select **Yes (/ASSEMBLYDEBUG)** for **Debuggable Assembly**.

For more information, see [/ASSEMBLYDEBUG](/cpp/build/reference/assemblydebug-add-debuggableattribute).

### <a name="vxtskdebuggingdllprojectsexternal"></a> Set C/C++ DLL file locations

To debug an external DLL, a calling project must be able to find the DLL, its [.pdb file](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md), and any other files the DLL requires. You can create a custom build task to copy these files to your *\<project folder>\Debug* output folder, or you can copy the files there manually.

For C/C++ projects, you can set header and LIB file locations in the project property pages, instead of copying them to the output folder.

**To set C/C++ header and LIB file locations:**

1. Select the C/C++ DLL project in **Solution Explorer** and select the **Properties** icon, or right-click the project and select **Properties**.

1. At the top of the **Properties** pane, under **Configuration**, select **All Configurations**.

1. Under **C/C++** > **General** > **Additional Include Directories**, specify the folder that has header files.

1. Under **Linker** > **General** > **Additional Libraries Directories**, specify the folder that has LIB files.

1. Under **Linker** > **Input** > **Additional Dependencies**, specify the full path and filename for the LIB files.

1. Select **OK**.

For more information on C++ project settings, see [Windows C++ property page reference](/cpp/build/reference/property-pages-visual-cpp).

## <a name="vxtskdebuggingdllprojectsbuildingadebugversion"></a> Build a Debug version

Make sure to build a Debug version of the DLL before you start debugging. To debug a DLL, a calling app must be able to find its [.pdb file](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md) and any other files the DLL requires. For more information, see [How to: Set Debug and Release configurations](../debugger/how-to-set-debug-and-release-configurations.md).

You can create a custom build task to copy the DLL files to your *\<calling project folder>\Debug* output folder, or you can copy the files there manually.

Make sure to call the DLL in its correct location. This may seem obvious, but if a calling app finds and loads a different copy of the DLL, the debugger will never hit the breakpoints you set.

## <a name="vxtskdebuggingdllprojectswaystodebugthedll"></a> Debug a DLL

You can't run a DLL directly. It must be called by an app, usually an *.exe* file. 

To debug a DLL, you can [start debugging from the calling app](#vxtskdebuggingdllprojectsthecallingapplication), or [debug from the DLL project](how-to-debug-from-a-dll-project.md) by specifying its calling app. You can also use the debugger [Immediate window](#vxtskdebuggingdllprojectstheimmediatewindow) to evaluate DLL functions or methods at design time, without using a calling app.

### <a name="vxtskdebuggingdllprojectsthecallingapplication"></a> Start debugging from the calling app

The app that calls a DLL can be:

- An app from a Visual Studio project in the same or a different solution from the DLL.
- An existing app that is already deployed and running on a test or production computer.
- Located on the web and accessed through a URL.
- A web app with a web page that embeds the DLL.

Before you start debugging the calling app, set a breakpoint in the DLL. See [Get started with breakpoints](../debugger/get-started-with-breakpoints.md). When the DLL breakpoint is hit, you can step through the code, observing the action at each line. For more information, see [Navigate code in the debugger](../debugger/navigating-through-code-with-the-debugger.md).

To debug a DLL from a calling app, you can:

- Open the project for the calling app, and start debugging by selecting **Debug** > **Start Debugging** or pressing **F5**.

  or

- Attach to an app that is already deployed and running on a test or production computer. Use this method for DLLs on websites or in web apps. For more information, see [How to: Attach to a running process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md).

During debugging, you can use the **Modules** window to verify the DLLs and *.exe* files the app loads. To open the **Modules** window, while debugging, select **Debug** > **Windows** > **Modules**. For more information, see [How to: Use the Modules window](../debugger/how-to-use-the-modules-window.md).

### <a name="vxtskdebuggingdllprojectstheimmediatewindow"></a> Use the Immediate window

You can use the **Immediate** window to evaluate DLL functions or methods at design time. The **Immediate** window plays the role of a calling app.

>[!NOTE]
>You can use the **Immediate** window at design time with most project types. It's not supported for SQL, web projects, or script.

For example, to test a method named `Test` in class `Class1`:

1. With the DLL project open, open the **Immediate** window by selecting **Debug** > **Windows** > **Immediate** or pressing **Ctrl**+**Alt**+**I**.

1. Instantiate an object of type `Class1` by typing the following C# code in the **Immediate** window and pressing **Enter**. This managed code works for C# and Visual Basic, with appropriate syntax changes:

   ```csharp
   Class1 obj = new Class1();
   ```

   In C#, all names must be fully qualified. Any methods or variables must be in the current scope and context when the language service tries to evaluate the expression.

1. Assuming that `Test` takes one `int` parameter, evaluate `Test` using the **Immediate** window:

   ```csharp
   ?obj.Test(10);
   ```

   The result prints in the **Immediate** window.

1. You can continue to debug `Test` by placing a breakpoint inside it, and then evaluating the function again.

   The breakpoint will be hit, and you can step through `Test`. After execution has left `Test`, the debugger will be back in design mode.

## <a name="vxtskdebuggingdllprojectsmixedmodedebugging"></a> Mixed-mode debugging

You can write a calling app for a DLL in managed or native code. If your native app calls a managed DLL and you want to debug both, you can enable both the managed and native debuggers in the project properties. The exact process depends on whether you want to start debugging from the DLL project or the calling app project. For more information, see [How to: Debug in mixed mode](../debugger/how-to-debug-in-mixed-mode.md).

You can also debug a native DLL from a managed calling project. For more information, see [How to debug managed and native code](how-to-debug-managed-and-native-code.md).

## Related content
- [Debug managed code](../debugger/debugging-managed-code.md)
- [Prepare to debug C++ projects](../debugger/debugging-preparation-visual-cpp-project-types.md)
- [C#, F#, and Visual Basic project types](../debugger/managed-debugging-recommended-property-settings.md)
- [Project settings for a C++ Debug configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)
- [Project settings for .NET C# debug configurations](../debugger/project-settings-for-csharp-debug-configurations-dotnetcore.md)
- [Project settings for  C# Debug configurations](../debugger/project-settings-for-csharp-debug-configurations.md)
- [Project settings for a Visual Basic Debug configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)
- [Debugger security](../debugger/debugger-security.md)
