---
title: "Security Warning: Debugger Must Execute Untrusted Command | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.sourceserver.securityalert"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
ms.assetid: e5c004b3-b364-4098-ac98-770076ca9981
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Security Warning: Debugger Must Execute Untrusted Command
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

## See also
- [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)
- [Debugger Security](../debugger/debugger-security.md)
- [Source Server](/windows/desktop/Debug/source-server-and-source-indexing)