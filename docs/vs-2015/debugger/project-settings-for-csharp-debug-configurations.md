---
title: "Project Settings for  C# Debug Configurations | Microsoft Docs"
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
  - "debug configurations, C#"
  - "debugging [J#], debugger settings"
  - "project settings [Visual Studio], debug configurations"
  - "debug builds, project settings"
  - "projects [Visual Studio], debug configurations"
  - "project configurations, debug"
  - "debugging [C#], debugger settings"
  - "debug configurations, J#"
ms.assetid: e30ca810-66e9-4d6e-9cf6-9f285cd0b100
caps.latest.revision: 25
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Project Settings for  C# Debug Configurations
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can change the project settings for a C# debug configuration in the **Property Pages** window, as discussed in [Debug and Release Configurations](../debugger/how-to-set-debug-and-release-configurations.md). The following tables show where to find debugger-related settings in the **Property Pages** window.  
  
> [!WARNING]
> This topic does not apply to Windows Store apps. See [Start a debug session (VB, C#, C++ and XAML)](../debugger/start-a-debugging-session-for-a-store-app-in-visual-studio-vb-csharp-cpp-and-xaml.md)  
  
## <a name="BKMK_Debug_tab"></a> Debug tab  
  
|**Setting**|**Description**|  
|-----------------|---------------------|  
|**Configuration**|Sets mode for compiling the application. Choose among **Active (Debug)**, **Debug**, **Release**, **All Configurations**.|  
|**Start Action**|This group of controls specifies the action that will occur when you choose Start from the Debug menu.<br /><br /> -   **Start project** is the default and launches the startup project for debugging. For more information, see [Choosing the Startup Project](https://msdn.microsoft.com/222e3f32-a6fe-4941-bf37-6b2a921129fd).<br />-   **Start external program** enables you to start and attach to a program that is not part of a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project. For more information, see [Attaching to a Running Program](https://msdn.microsoft.com/636d0a52-4bfd-48d2-89ad-d7b9ca4dc4f4).<br />-   **Start browser in URL** enables you to debug a Web application.|  
|**Command line arguments**|Specifies command-line arguments for the program to be debugged. The command name is the program name specified in Start external program. If Start Action is set to Start URL, command-line arguments cannot be specified.|  
|**Working directory**|Specifies the working directory of the program being debugged. In [!INCLUDE[csprcs](../includes/csprcs-md.md)], the working directory is the directory the application is launched from \bin\debug by default.|  
|**Use remote machine**|The name of a remote machine where the application will run for debugging purposes or an [Msvsmon server name](https://msdn.microsoft.com/library/55b60ce7-834b-4e83-a10e-fe4248260a4c). The location of the EXE on the remote machine is specified by the Output Path property in the Configuration Properties folder, Build category. The location must be a shareable directory on the remote machine.|  
|**Enable unmanaged code debugging**|Enables you to debug calls to native (unmanaged) Win32 code from your managed application.|  
|**Enable SQL Server debugging**|Allows debugging of SQL Server database objects.|  
  
## <a name="BKMK_Build_tab"></a> Build tab  
  
|Setting|Description|  
|-------------|-----------------|  
|**Conditional compilation symbols:**|The DEBUG and TRACE constants are defined here.<br /><br /> These constants enable conditional compilation of the [Debug class](https://msdn.microsoft.com/library/system.diagnostics.debug.aspx) and [Trace class](https://msdn.microsoft.com/library/system.diagnostics.trace.aspx). With these constants defined, Debug and Trace class methods generate output to the [Output window](../ide/reference/output-window.md). Without these constants, Debug and Trace class methods are not compiled and no output is generated.<br /><br /> -   Debug is normally defined in the Debug version of a program and undefined in the Release version.<br />-   Trace is normally defined in both Debug and Release versions.|  
|**Optimize code**|Unless you find a bug that appears only in optimized code, you should leave this setting turned off in the Debug version. Optimized code is harder to debug because instructions do not correspond directly to statements in your source windows.|  
|**Output path:**|Typically set to bin\Debug for debugging.|  
  
## See Also  
 [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)
