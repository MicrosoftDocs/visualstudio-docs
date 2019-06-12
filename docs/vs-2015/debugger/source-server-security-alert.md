---
title: "Source Server Security Alert | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.debug.sourceserver.enablewarning"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: 8451c281-6914-469c-b80c-6271cc3f3d17
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Source Server Security Alert
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When using Source Server, only use symbol files that are from a known and trusted location.  
  
 This warning appears when you enable Source Server support. Source Server commands are embedded in debug symbol files (PDB files). Make sure you know where your PDB files come from.  
  
> [!IMPORTANT]
> The following potential security threats must be taken into account when using Source Server: Arbitrary commands can be embedded in the application's PDB file, so make sure you put only the ones you want to execute in the srcsrv.ini file. Any attempt to execute a command not in the srcsvr.ini file will cause a confirmation dialog box to appear. For more information, see [Security Warning: Debugger Must Execute Untrusted Command](../debugger/security-warning-debugger-must-execute-untrusted-command.md).No validation is done on command parameters, so be careful with trusted commands. For example, if you trusted cmd.exe, a malicious user might specify parameters that would make the command dangerous.  
  
## See Also  
 [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)   
 [Debugger Security](../debugger/debugger-security.md)   
 [Source Server](https://msdn.microsoft.com/library/windows/desktop/ms680641.aspx)
