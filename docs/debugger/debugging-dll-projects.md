---
title: "Debug DLL projects | Microsoft Docs"
ms.custom: ""
ms.date: "11/06/2018"
ms.technology: "vs-ide-debug"
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
ms.assetid: 433cab30-d191-460b-96f7-90d2530ca243
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# Debug DLLs in Visual Studio

A DLL (dynamic link library) is a library that contains code and data that can be used by more than one app. You can use Visual Studio to create, build, configure, and debug DLLs. 

## Create a DLL

The following Visual Studio project templates can create DLLs:

- C# or Visual Basic Class Library (.NET Framework or Universal Windows)
- C# or Visual Basic WCF Service Library 
- C++ Dynamic-Link Library (DLL) or C++ DLL (Universal Windows)

For more information, see [MFC debugging techniques](../debugger/mfc-debugging-techniques.md).

You can also create DLLs with the C# or Visual Basic Windows Forms Control (WCF) Library project templates. 

Debugging a WCF Library is similar to debugging a Class Library. In most cases, you call the control from another project. When you debug the calling project, you can step into the code of your control, set breakpoints, and perform other debugging operations. For more information, see [Windows Forms Controls](/dotnet/framework/winforms/controls/index).  

## <a name="vxtskdebuggingdllprojectschangingdefaultconfigurations"></a> Configure DLLs

When you use a Visual Studio project template to create a console app, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] automatically creates required settings for Debug and Release build configurations. You can change these settings if necessary. For more information, see the following articles:

- [Project settings for a C++ debug configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)
- [Project settings for C# debug configurations](../debugger/project-settings-for-csharp-debug-configurations.md)
- [Project settings for a Visual Basic debug configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)
- [How to: Set Debug and Release configurations](../debugger/how-to-set-debug-and-release-configurations.md)  
  
### Set DebuggableAttribute

For the debugger to attach to a C++ DLL, the C++ code must emit `DebuggableAttribute`. 

**To set `DebuggableAttribute`:**

1. Select the C++ project in **Solution Explorer** and select the **Properties** icon, or right-click the project and select **Properties**. 
   
1. In the **Properties** pane, under **Linker** > **Debugging**, select **Yes (/ASSEMBLYDEBUG)** under **Debuggable Assembly**. 

For more information, see [/ASSEMBLYDEBUG](/cpp/build/reference/assemblydebug-add-debuggableattribute).  

### <a name="vxtskdebuggingdllprojectsexternal"></a> Configure a project to debug an external DLL 

The debugging features available for DLLs outside your project, such as stepping through code, depend on the [debug configuration of the DLL](#vxtskdebuggingdllprojectsbuildingadebugversion) when it was built, and whether the [.pdb file](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md) and other required DLL files are available.

To debug an external DLL, a project must be able to find the DLL and the *.pdb* file used for debugging. You can create a custom build task to copy these files to your *\<project folder>\Debug* output folder, or you can copy the files there manually.

For C/C++ projects, you can set locations of header files and *.lib* files in the project property pages: 

1. Select the project in **Solution Explorer** and select the **Properties** icon, or right-click the project and select **Properties**. 
   
1. At the top of the **Properties** pane, under **Configuration**, select **All Configurations**.
   
1. Under **C/C++** > **General** > **Additional Include Directories**, specify the folder containing header files.
   
1. Under **Linker** > **General** > **Additional Libraries Directories**, specify the folder containing the *.lib* file. 
   
1. Under **Linker** > **Input** > **Additional Dependencies**, specify the full path and filename for the *.lib* file.

1. Select **OK**.

For more information on C++ project settings, see [Property pages (Visual C++)](/cpp/ide/property-pages-visual-cpp).
  
##  <a name="vxtskdebuggingdllprojectsbuildingadebugversion"></a> Build a Debug version  

Make sure to build the Debug version of the DLL first, and save it in the location the calling app points to. This may seem obvious, but if the app finds and loads a different version of the DLL, the breakpoints in your version will never be hit. 

##  <a name="vxtskdebuggingdllprojectswaystodebugthedll"></a> Debug a DLL  

You can debug a DLL [from its calling project](#vxtskdebuggingdllprojectsthecallingapplication), from the DLL project itself, or by using the debugger [Immediate window](#vxtskdebuggingdllprojectstheimmediatewindow).

To debug directly from a DLL project, see [How to: Debug from a DLL project](../debugger/how-to-debug-from-a-dll-project.md).  
  
To start debugging, select **Debug** > **Start Debugging**, select the green arrow in the toolbar, or press **F5**. For more information, see [Get started with the debugger](getting-started-with-the-debugger.md).

During debugging, the **Modules** window lists the DLLs and *.exe* files your app has loaded for the process you are debugging. To open the **Modules** window, while debugging, select **Debug** > **Windows** > **Modules**. For more information, see [How to: Use the Modules window](../debugger/how-to-use-the-modules-window.md). 

### <a name="vxtskdebuggingdllprojectsthecallingapplication"></a> Start debugging from the calling app

You can't run a DLL directly. It must be called by an app, usually an *.exe* file. The calling app can be:  
  
- An app in a different solution, or in another project in the same [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] solution as the class library.  
- An app already deployed on a test or production computer.  
- An app located on the web that is accessed through a URL.  
- A web app with a web page that embeds the DLL.  
  
For more information, see [Create and manage Visual C++ projects](/cpp/ide/creating-and-managing-visual-cpp-projects). 

To debug a DLL from a calling app, you can:  
  
- Open the project for the calling app, and start execution from the **Debug** menu.  

or  

- Attach to an existing app that is already deployed and running on a test or production computer. Use this method for DLL controls in Internet Explorer or on web pages. For more information, see [How to: Attach to a running process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md).  
  
Before you start debugging the calling app, set a breakpoint in the DLL. For more information, see [Using breakpoints](../debugger/using-breakpoints.md). When the breakpoint is hit, you can step through the code, observing the action at each line. For more information, see [Navigate code in the debugger](../debugger/navigating-through-code-with-the-debugger.md).
  
###  <a name="vxtskdebuggingdllprojectstheimmediatewindow"></a> Use the Immediate window  

 You can use the **Immediate** window at design time to evaluate functions or methods in the DLL. The **Immediate** window plays the role of a calling app. 

For example, to test a method named `Test` in class `Class1`:

1. With the DLL project open, open the **Immediate** window by selecting **Debug** > **Windows** > **Immediate** or pressing **Ctrl**+**Alt**+**I**.  
  
1. Instantiate an object of type `Class1` by typing the following C# code in the **Immediate** window. This managed code works for C# and Visual Basic, with appropriate syntax changes:  
  
    ```csharp
    Class1 obj = new Class1();  
    ```  
  
    In C#, all names must be fully qualified, and any methods or variables must be in the current scope and context of the debugging session.  
  
1.  Assuming that `Test` takes one `int` parameter, evaluate `Test` using the **Immediate** window:  
  
    ```csharp
    ?obj.Test(10)  
    ```  
  
     The result is printed in the **Immediate** window.  
  
1.  You can continue to debug `Test` by placing a breakpoint inside it and then evaluating the function again:  
  
    ```csharp
    ?obj.Test(10);  
    ```  
  
     The breakpoint will be hit and you will be able to step through `Test`. After execution has left `Test`, the debugger will be back in Design mode.

##  <a name="vxtskdebuggingdllprojectsmixedmodedebugging"></a> Mixed-mode debugging  

You can write a calling app for a DLL in managed or native code. If your native app calls a managed DLL and you want to debug both, you can enable both the managed and native debuggers in the project properties. The exact process depends on whether you want to start debugging from the DLL project or the calling app project. For more information, see [How to: Debug in mixed mode](../debugger/how-to-debug-in-mixed-mode.md). 

You can also debug a native DLL from a managed calling project. For more information, see [How to debug managed and native code]{how-to-debug-managed-and-native-code.md). 

## See also  
 [Debug managed code](../debugger/debugging-managed-code.md)   
 [Visual C++ project types](../debugger/debugging-preparation-visual-cpp-project-types.md)   
 [C#, F#, and Visual Basic project types](../debugger/debugging-preparation-csharp-f-hash-and-visual-basic-project-types.md)   
 [Project settings for a C++ Debug configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)   
 [Project settings for  C# Debug configurations](../debugger/project-settings-for-csharp-debug-configurations.md)   
 [Project settings for a Visual Basic Debug configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)   
 [Debugger security](../debugger/debugger-security.md)
