---
title: "Debugging DLL projects | Microsoft Docs"
ms.custom: ""
ms.date: "05/23/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
caps.latest.revision: 38
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Debugging DLL projects from Visual Studio
The following Visual Studio templates create DLLs:  
  
-   (C++, C#, and Visual Basic) Class Library   

-   (C++): Win32 Console DLL project
  
     For more information, see [MFC Debugging Techniques](../debugger/mfc-debugging-techniques.md).

-   (C++, C#, and Visual Basic): Windows Forms Control Library
  
     Debugging a Windows Forms Control Library is similar to debugging a Class Library project. In most cases, you will call the Windows control from another project. When you debug the calling project, you can step into the code of your Windows control, set breakpoints, and perform other debugging operations. For more information, see [Windows Forms Controls](/dotnet/framework/winforms/controls/index).  

  
##  <a name="vxtskdebuggingdllprojectsbuildingadebugversion"></a> Building a debug version  
 No matter how you start debugging, make sure that you build the Debug version of the DLL first and make sure that the Debug version is in the location where the application expects to find it. This may seem obvious, but if you forget this step, the application might find a different version of the DLL and load it. The program will then continue to run, while you wonder why your breakpoint was never hit. When you are debugging, you can verify which DLLs your program has loaded by opening the debugger's **Modules** window. The **Modules** window lists each DLL or EXE loaded in the process you are debugging. For more information, see [How to: Use the Modules Window](../debugger/how-to-use-the-modules-window.md).  
 For the debugger to attach to code written in C++, the code must emit `DebuggableAttribute`. You can add this to your code automatically by linking with the [/ASSEMBLYDEBUG](/cpp/build/reference/assemblydebug-add-debuggableattribute) linker option.  
  
##  <a name="vxtskdebuggingdllprojectsmixedmodedebugging"></a> Mixed-Mode debugging  
 The calling application that calls your DLL can be written in managed code or native code. If your managed DLL is called by native code and you want to debug both, managed and native debuggers must both be enabled. You can select this in the **\<Project> Property Pages** dialog box or window. How you do this depends on whether you start debugging from the DLL project or the calling application project. For more information, see [How to: Debug in Mixed Mode](../debugger/how-to-debug-in-mixed-mode.md).  
  
##  <a name="vxtskdebuggingdllprojectschangingdefaultconfigurations"></a> Changing default configurations  
 When you create a console application project with the project template, [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] automatically creates required settings for the Debug and Release configurations. If necessary, you can change those settings. For more information, see [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md), [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md), [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md), and [How to: Set Debug and Release Configurations](../debugger/how-to-set-debug-and-release-configurations.md).  
  
##  <a name="vxtskdebuggingdllprojectswaystodebugthedll"></a> Ways to debug the DLL  
 Each of the projects in this section creates a DLL. You cannot run a DLL directly; it must be called by an application, usually an EXE. For more information, see [Creating and Managing Visual C++ Projects](/cpp/ide/creating-and-managing-visual-cpp-projects). The calling application might fit any one of the following criteria:  
  
-   An application built in another project in the same [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] solution that contains the class library.  
  
-   An existing application already deployed on a test or production computer.  
  
-   Located on the Web and accessed through a URL.  
  
-   A Web application that contains a Web page which embeds the DLL.  
  
###  <a name="vxtskdebuggingdllprojectsthecallingapplication"></a> Debugging the calling application  
To debug a DLL, start by debugging the calling application, typically either an EXE or a Web application. There are several ways to debug it.  
  
-   If you have a project for the calling application, you can open that project and start execution from the **Debug** menu. For more information, see [Getting started with the debugger](../debugger/getting-started-with-the-debugger.md).  
  
-   If the calling application is an existing program already deployed on a test or production computer and is already running you can attach to it. Use this method if the DLL is a control hosted by Internet Explorer, or a control on a Web page. For more information, see [How to: Attach to a Running Process](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md).  
  
-   You can debug it from the DLL project. For more information, see [How to: Debug from a DLL Project](../debugger/how-to-debug-from-a-dll-project.md).  
  
-   You can debug it from the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] [Immediate window](#vxtskdebuggingdllprojectstheimmediatewindow). In this case, the **Immediate** window plays the role of the application.  
  
Before you start debugging the calling application, you will usually want to set a breakpoint in the class library. For more information, see [Using Breakpoints](../debugger/using-breakpoints.md). When the breakpoint is hit, you can step through the code, observing the action at each line, until you isolate the problem. For more information, see [Navigate code in the debugger](../debugger/navigating-through-code-with-the-debugger.md).
  
###  <a name="vxtskdebuggingdllprojectstheimmediatewindow"></a> The Immediate Window  
 You can evaluate functions or methods in the DLL without having a calling application. You do design-time debugging and you use the **Immediate** window. To debug in this manner, do the follow these steps while the DLL project is open:  
  
1.  Open the Debugger **Immediate** window.  
  
2.  To test a method named `Test` in class `Class1`, instantiate an object of type `Class1` by typing the following C# code in the Immediate window. This managed code works for Visual Basic and C++, with appropriate syntax changes:  
  
    ```  
    Class1 obj = new Class1();  
    ```  
  
     In C#, all names must be fully qualified. In addition, any methods or variables must be in the current scope and context of the debugging session.  
  
3.  Assuming that `Test` takes one `int` parameter, evaluate `Test` using the **Immediate** window:  
  
    ```  
    ?obj.Test(10)  
    ```  
  
     The result will be printed in the **Immediate** window.  
  
4.  You can continue to debug `Test` by placing a breakpoint inside it and then evaluating the function again:  
  
    ```  
    ?obj.Test(10);  
    ```  
  
     The breakpoint will be hit and you will be able to step through `Test`. After execution has left `Test`, the Debugger will be back in Design mode.

## <a name="vxtskdebuggingdllprojectsexternal"></a> Debug an external DLL from a C++ project

If you are debugging a DLL external to your project, the debugging features available (such as stepping through code) will depend on the [debug configuration of the DLL](#vxtskdebuggingdllprojectsbuildingadebugversion) when it was built and whether the [.pdb file](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md) and other required files for the DLL are available.

Your project needs to be able to find the DLL and the .pdb file used for debugging. You can create a custom build task to copy these files to the **\<project folder>\Debug** output folder, or you can copy the files into the output folder manually.

You can easily set locations of header files and *.lib files in the Property Pages (right-click the C++ project and choose **View Properties**, and then choose **All Configurations**) without the need to copy them into your output folder:

- C/C++ folder (General category) - Specify the folder containing header files in the **Additional Include Directories** field.
- Linker folder (General category) - Specify the folder containing the .lib file in the **Additional Libraries Directories** field. 
- Linker folder (Input category) - Specify the full path and filename for the .lib file in the **Additional Dependencies** field.

When the configuration is correct, you can debug by starting execution from the **Debug** menu.

For more information on project settings, see [Property Pages (Visual C++)](/cpp/ide/property-pages-visual-cpp).
  
## See Also  
 [Debugging Managed Code](../debugger/debugging-managed-code.md)   
 [Visual C++ Project Types](../debugger/debugging-preparation-visual-cpp-project-types.md)   
 [C#, F#, and Visual Basic Project Types](../debugger/debugging-preparation-csharp-f-hash-and-visual-basic-project-types.md)   
 [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)   
 [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md)   
 [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)   
 [Debugger Security](../debugger/debugger-security.md)