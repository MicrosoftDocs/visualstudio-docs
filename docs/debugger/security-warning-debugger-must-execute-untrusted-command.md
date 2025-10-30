---
description: "This warning dialog box appears when you are using Source Server."
title: "Security Warning: Debugger Must Execute Untrusted Command"
ms.date: "11/04/2016"
ms.topic: article
f1_keywords:
  - "vs.debug.sourceserver.securityalert"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
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

## Related content
- [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)
- [Debugger Security](../debugger/debugger-security.md)
- [Source Server](/windows/desktop/Debug/source-server-and-source-indexing)
