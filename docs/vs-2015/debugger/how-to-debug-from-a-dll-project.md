---
title: "How to: Debug from a DLL Project | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "DLL projects, debugging"
  - "debugging DLLs"
  - "DLLs, debugging projects"
  - "debugging [Visual Studio], DLLs"
ms.assetid: 40a94339-d3f7-4ab9-b8a1-b8cf82942f44
caps.latest.revision: 33
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Debug from a DLL Project
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To start debugging a DLL project, you must specify the calling application in the project properties. The C++ property pages differ in layout and content from the C# and Visual Basic property pages.  
  
 If a managed DLL is called by native code and you want to debug both, you can specify this in the project properties. For more information, see [How to: Debug in Mixed Mode](../debugger/how-to-debug-in-mixed-mode.md).  
  
> [!NOTE]
> You cannot specify an external calling application in Express editions of Visual Studio. Instead, you need to add an executable project to the solution, set it as the startup project, and call methods in your DLL from the executable project.  
  
### To specify the calling application in a C++ project  
  
1. Right-click the project node in the **Solution Explorer** and select **Properties**. Go to the **Debug** tab.  
  
2. Make sure that the **Configuration** field at the top of the window is set to **Debug**.  
  
3. Go to **Configuration Properties / Debugging**.  
  
4. In the **Debugger to launch** list, choose **Local Windows Debugger** or **Remote Windows Debugger**.  
  
5. In the **Command** or **Remote Command** box, add the fully-qualified path name of the application.  
  
6. Add any necessary program arguments to the **Command Arguments** box.  
  
### To specify the calling application in a C# or Visual Basic project  
  
1. Right-click the project node in the **Solution Explorer** and select **Properties**. Go to the **Debug** tab.  
  
     Select **Start external program**, and add the fully-qualified path name of the program to run.  
  
     If you need to add the external program’s command line arguments, add them in the **Command line arguments** field.  
  
2. You can also call an application as a URL. (You might want to do this if you are debugging a managed DLL used by a local ASP.NET application.)  
  
     Under **Start Action**, select the **Start browser in URL:** radio button and fill in the URL.  
  
### To start debugging from the DLL project  
  
1. Set breakpoints as needed.  
  
2. Start debugging (press F5, click the green arrow, or click **Debug / Start Debugging**).  
  
## See Also  
 [Debugging DLL Projects](../debugger/debugging-dll-projects.md)   
 [Project Settings for  C# Debug Configurations](../debugger/project-settings-for-csharp-debug-configurations.md)   
 [Project Settings for a Visual Basic Debug Configuration](../debugger/project-settings-for-a-visual-basic-debug-configuration.md)   
 [Project Settings for a C++ Debug Configuration](../debugger/project-settings-for-a-cpp-debug-configuration.md)
