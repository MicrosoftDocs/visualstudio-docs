---
title: "Debugging Deployed Web Applications"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - FSharp
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b938a91b-be96-416f-83bc-4177e7f3929a
caps.latest.revision: 31
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Debugging Deployed Web Applications
If you need to debug a Web application that is running on a production server, this should be done with caution. If you attach to the ASP.NET worker process for debugging and hit a breakpoint, for example, all managed code in the worker process halts. Halting all managed code in the worker process can cause a work stoppage for all users on the server. Before you debug on a production server, consider the potential impact on production work.  
  
 To use Visual Studio to debug a deployed application, you must attach to the ASP.NET worker process and make sure that the debugger has access to symbols for the application. You must also locate and open the source files for the application. For more information, see [Specify Symbol (.pdb) and Source Files](../VS_debugger/Specify-Symbol--.pdb--and-Source-Files-in-the-Visual-Studio-Debugger.md), [How to: Find the Name of the ASP.NET Process](../VS_debugger/How-to--Find-the-Name-of-the-ASP.NET-Process.md), and [System Requirements](../VS_debugger/ASP.NET-Debugging--System-Requirements.md).  
  
> [!NOTE]
>  Many ASP.NET Web applications reference DLLs that contain business logic or other useful code. Such a reference automatically copies the DLL from your local computer to the \bin folder of the Web application's virtual directory. When you are debugging, remember that your Web application is referencing that copy of the DLL and not the copy on your local computer.  
  
 The process for attaching to the ASP.NET worker process is the same as attaching to any other remote process. When you are attached, if you do not have the correct project open, a dialog box appears when the application breaks. This dialog box asks for the location of the source files for the application. The file name that you specify in the dialog box must match the file name specified in the debug symbols on the Web server. For more information, see [Attach to Running Processes](../VS_debugger/Attach-to-Running-Processes-with-the-Visual-Studio-Debugger.md).  
  
## See Also  
 [Debugging ASP.NET and AJAX Applications](../VS_debugger/Debugging-ASP.NET-and-AJAX-Applications.md)   
 [Debugging Web Applications and Script](../VS_debugger/Debugging-Web-Applications-and-Script.md)   
 [How to: Enable Debugging for ASP.NET Applications](../VS_debugger/How-to--Enable-Debugging-for-ASP.NET-Applications.md)   
 [How to: Find the Name of the ASP.NET Process](../VS_debugger/How-to--Find-the-Name-of-the-ASP.NET-Process.md)   
 [Specify Symbol (.pdb) and Source Files](../VS_debugger/Specify-Symbol--.pdb--and-Source-Files-in-the-Visual-Studio-Debugger.md)