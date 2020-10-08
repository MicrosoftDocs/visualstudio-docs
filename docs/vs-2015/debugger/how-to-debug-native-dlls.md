---
title: "How to: Debug Native DLLs | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.dll"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging DLLs"
  - "DLLs, debugging"
  - "executable files, specifying for debug sessions"
ms.assetid: 76b34d15-a66d-4963-842e-c8b955c81696
caps.latest.revision: 20
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Debug Native DLLs
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose Import and Export Settings on the Tools menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
 When you debug a DLL, you can start debugging from:  
  
- The project used to create the executable that calls the DLL.  
  
  \- or -  
  
- The project used to create the DLL itself.  
  
  If you have the project used to create the executable, start debugging from that project. You can then open a source file for the DLL and set breakpoints in that file, even though it is not a part of the project used to create the executable. For more information, see [Breakpoints](https://msdn.microsoft.com/fe4eedc1-71aa-4928-962f-0912c334d583).  
  
  If you start debugging from the project that creates the DLL, you must specify the executable you want to use in debugging the DLL.  
  
### To specify an executable for the debug session  
  
1. In **Solution Explorer**, select the project that creates the DLL.  
  
2. From the **View** menu, choose**Property Pages**.  
  
3. In the **Property Pages** dialog box, open the **Configuration Properties** folder and select the **Debugging** category.  
  
4. In the **Command** box, specify the path name for the container. For example, C:\Program Files\MyApplication\MYAPP.EXE.  
  
5. In the **Command Arguments** box, specify any necessary arguments for the executable.  
  
   If you do not specify the executable in the _Project_**Property Pages** dialog box, the [Executable for Debugging Session Dialog Box](../debugger/executable-for-debugging-session-dialog-box.md) appears when you start debugging.  
  
## See Also  
 [Debugger Security](../debugger/debugger-security.md)   
 [Debugging in Visual Studio](../debugger/debugging-in-visual-studio.md)
