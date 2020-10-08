---
title: "Security Warning: Debugger Must Execute Untrusted Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.sourceserver.securityalert"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: e5c004b3-b364-4098-ac98-770076ca9981
caps.latest.revision: 16
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Security Warning: Debugger Must Execute Untrusted Command
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This warning dialog box appears when you are using Source Server. It indicates that the command the debugger needs to execute to obtain source code is not in the list of trusted commands for Source Server contained in the srcsvr.ini file. If this is a valid command, you can add it to the srcsvr.ini file. Otherwise, you should not run it. For more information, see [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md).  
  
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
 [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)   
 [Debugger Security](../debugger/debugger-security.md)   
 [Source Server](https://msdn.microsoft.com/library/windows/desktop/ms680641\(v=vs.85\).aspx)
