---
title: "Debugging DLL Projects | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging DLLs"
  - "templates, debugging DLLs"
  - "DLLs, debugging"
  - "debugging [Visual Studio], DLLs"
ms.assetid: 433cab30-d191-460b-96f7-90d2530ca243
caps.latest.revision: 41
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Debugging DLL Projects
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The following templates create DLLs:  
  
- (C++, C#, and Visual Basic) Class Library  
  
- (C++, C#, and Visual Basic): Windows Forms Control Library  
  
   Debugging a Windows Control Library is similar to debugging a Class Library project. In most cases, you will call the Windows control from another project. When you debug the calling project, you can step into the code of your Windows control, set breakpoints, and perform other debugging operations. For more information, see [Windows Forms Controls](https://msdn.microsoft.com/library/f050de8f-4ebd-4042-94b8-edf9a1dbd52a).  
  
- (C# and Visual Basic): Web Control Library  
  
   For more information, see [Web Control Library (Managed Code)](../debugger/web-control-library-managed-code.md).  
  
- (C++): MFC ActiveX Control and MFC Smart Device ActiveX Control  
  
   ActiveX controls are controls that can be downloaded over the Internet onto a client computer, and displayed and activated on Web pages.  
  
   Debugging ActiveX controls is similar to debugging other kinds of controls because they cannot be run as stand-alone, but must be embedded in an HTML Web page. For more information, see [How to: Debug an ActiveX Control](../debugger/how-to-debug-an-activex-control.md).  
  
- (C++): MFC Smart Device DLL  
  
   For more information, see [MFC Debugging Techniques](../debugger/mfc-debugging-techniques.md).  
  
  This section also contains information about the following topics:  
  
- [How to: Debug from a DLL Project](../debugger/how-to-debug-from-a-dll-project.md)  
  
- [How to: Debug in Mixed Mode](../debugger/how-to-debug-in-mixed-mode.md)  
  
  This topic contains the following sections, which provide considerations about how to prepare to debug class libraries:  
  
- [Building a Debug Version](#vxtskdebuggingdllprojectsbuildingadebugversion)  
  
- [Mixed-Mode Debugging](#vxtskdebuggingdllprojectsmixedmodedebugging)  
  
- [Changing Default Configurations](#vxtskdebuggingdllprojectschangingdefaultconfigurations)  
  
- [Ways to Debug the DLL](#vxtskdebuggingdllprojectswaystodebugthedll)  
  
- [The Calling Application](#vxtskdebuggingdllprojectsthecallingapplication)  
  
- [Controls on a Web Page](#vxtskdebuggingdllprojectscontrolsonawebpage)  
  
- [The Immediate Window](#vxtskdebuggingdllprojectstheimmediatewindow)  
  
## <a name="vxtskdebuggingdllprojectsbuildingadebugversion"></a> Building a Debug Version  
 No matter how you start debugging, make sure that you build the Debug version of the DLL first and make sure that the Debug version is in the location where the application expects to find it. This may seem obvious, but if you forget this step, the application might find a different version of the DLL and load it. The program will then continue to run, while you wonder why your breakpoint was never hit. When you are debugging, you can verify which DLLs your program has loaded by opening the debugger's **Modules** window. The **Modules** window lists each DLL or EXE loaded in the process you are debugging. For more information, see [How to: Use the Modules Window](../debugger/how-to-use-the-modules-window.md).  
  
 For the debugger to attach to code written in C++, the code must emit `DebuggableAttribute`. You can add this to your code automatically by linking with the [/ASSEMBLYDEBUG](https://msdn.microsoft.com/library/94443af3-470c-41d7-83a0-7434563d7982) linker option.  
  
## <a name="vxtskdebuggingdllprojectsmixedmodedebugging"></a> Mixed-Mode Debugging  
 The calling application that calls your DLL can be written in managed code or native code. If your managed DLL is called by native code and you want to debug both, managed and native debuggers must both be enabled. You can select this in the **\<Project>Property Pages** dialog box or window. How you do this depends on whether you start debugging from the DLL project or the calling application project. For more information, see [How to: Debug in Mixed Mode](../debugger/how-to-debug-in-mixed-mode.md).  
  
## <a name="vxtskdebuggingdllprojectschangingdefaultconfigurations"></a> Changing Default Configurations  
 When you create a console application project with the project template, [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] automatically creates required settings for the Debug and Release configurations. If necessary, you can change those settings. For more information, see [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md), [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md), [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md), and [How to: Set Debug and Release Configurations](../debugger/how-to-set-debug-and-release-configurations.md).  
  
## <a name="vxtskdebuggingdllprojectswaystodebugthedll"></a> Ways to Debug the DLL  
 Each of the projects in this section creates a DLL. You cannot run a DLL directly; it must be called by an application, usually an EXE. For more information, see [Creating and Managing Visual C++ Projects](https://msdn.microsoft.com/library/11003cd8-9046-4630-a189-a32bf3b88047). The calling application might fit any one of the following criteria:  
  
- An application built in another project in the same [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] solution that contains the class library.  
  
- An existing application already deployed on a test or production computer.  
  
- Located on the Web and accessed through a URL.  
  
- A Web application that contains a Web page which embeds the DLL.  
  
### <a name="vxtskdebuggingdllprojectsthecallingapplication"></a> Debugging the Calling Application  
 To debug a DLL, start by debugging the calling application, typically either an EXE or a Web application. There are several ways to debug it.  
  
- If you have a project for the calling application, you can open that project and start execution from the **Debug** menu. For more information, see [How to: Start Execution](https://msdn.microsoft.com/b0fe0ce5-900e-421f-a4c6-aa44ddae453c).  
  
- If the calling application is an existing program already deployed on a test or production computer and is already running you can attach to it. Use this method if the DLL is a control hosted by Internet Explorer, or a control on a Web page. For more information, see [How to: Attach to a Running Process](https://msdn.microsoft.com/636d0a52-4bfd-48d2-89ad-d7b9ca4dc4f4).  
  
- You can debug it from the DLL project. For more information, see [How to: Debug from a DLL Project](../debugger/how-to-debug-from-a-dll-project.md).  
  
- You can debug it from the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] **Immediate** window. In this case, the **Immediate** window plays the role of the application.  
  
  Before you start debugging the calling application, you will usually want to set a breakpoint in the class library. For more information, see [Breakpoints and Tracepoints](https://msdn.microsoft.com/fe4eedc1-71aa-4928-962f-0912c334d583). When the breakpoint is hit, you can step through the code, observing the action at each line, until you isolate the problem. For more information, see [Code Stepping Overview](https://msdn.microsoft.com/8791dac9-64d1-4bb9-b59e-8d59af1833f9).  
  
### <a name="vxtskdebuggingdllprojectscontrolsonawebpage"></a> Controls on a Web Page  
 To debug a Web page control, create an [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] page that embeds it if such a page does not already exist. You then place breakpoints in the Web page code as well as the control code. You then invoke the Web page from [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
 Before you start debugging the calling application, you will usually want to set a breakpoint in the DLL. When the breakpoint is hit, you can step through the code, observing the action at each line, until you isolate the problem. For more information, see [Breakpoints and Tracepoints](https://msdn.microsoft.com/fe4eedc1-71aa-4928-962f-0912c334d583).  
  
### <a name="vxtskdebuggingdllprojectstheimmediatewindow"></a> The Immediate Window  
 You can evaluate functions or methods in the DLL without having a calling application. You do design-time debugging and you use the **Immediate** window. To debug in this manner, do the follow these steps while the DLL project is open:  
  
1. Open the Debugger **Immediate** window.  
  
2. To test a method named `Test` in class `Class1`, instantiate an object of type `Class1` by typing the following C# code in the Immediate window. This managed code works for Visual Basic and C++, with appropriate syntax changes:  
  
    ```  
    Class1 obj = new Class1();  
    ```  
  
     In C#, all names must be fully qualified. In addition, any methods or variables must be in the current scope and context of the debugging session.  
  
3. Assuming that `Test` takes one `int` parameter, evaluate `Test` using the **Immediate** window:  
  
    ```  
    ?obj.Test(10)  
    ```  
  
     The result will be printed in the **Immediate** window.  
  
4. You can continue to debug `Test` by placing a breakpoint inside it and then evaluating the function again:  
  
    ```  
    ?obj.Test(10);  
    ```  
  
     The breakpoint will be hit and you will be able to step through `Test`. After execution has left `Test`, the Debugger will be back in Design mode.  
  
## See Also  
 [Debugging Managed Code](../debugger/debugging-managed-code.md)   
 [Visual C++ Project Types](../debugger/debugging-preparation-visual-cpp-project-types.md)   
 [C#, F#, and Visual Basic Project Types](../debugger/debugging-preparation-csharp-f-hash-and-visual-basic-project-types.md)   
 [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)   
 [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md)   
 [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)   
 [Debugger Security](../debugger/debugger-security.md)
