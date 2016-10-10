---
title: "Security Warning: Debugger Must Execute Untrusted Command"
ms.custom: na
ms.date: 10/03/2016
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
ms.assetid: e5c004b3-b364-4098-ac98-770076ca9981
caps.latest.revision: 13
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
# Security Warning: Debugger Must Execute Untrusted Command
This warning dialog box appears when you are using Source Server. It indicates that the command the debugger needs to execute to obtain source code is not in the list of trusted commands for Source Server contained in the srcsvr.ini file. If this is a valid command, you can add it to the srcsvr.ini file. Otherwise, you should not run it. For more information, see [Specify Symbol (.pdb) and Source Files](../VS_debugger/Specify-Symbol--.pdb--and-Source-Files-in-the-Visual-Studio-Debugger.md).  
  
## Message Text  
 **The debugger must execute the following untrusted command to obtain source code from the source server.**  
  
 **If the debug symbol file (\*.pdb) is not from a known and trusted source, this command could be invalid or dangerous to run.**  
  
 **Do you want to run this command?**  
  
## UIElement List  
 Text Box  
 Command from the .pdb file to run.  
  
 Run  
 Allow the command to run.  
  
 Don't Run  
 Stop execution of command and downloading of the file from Source Server.  
  
## See Also  
 [Specify Symbol (.pdb) and Source Files](../VS_debugger/Specify-Symbol--.pdb--and-Source-Files-in-the-Visual-Studio-Debugger.md)   
 [Debugger Security](../VS_debugger/Debugger-Security.md)   
 [Source Server](http://msdn.microsoft.com/library/windows/desktop/ms680641\(v=vs.85\).aspx)