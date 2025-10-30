---
title: "Source Server Security Alert"
description: Read about the Source Server security alert warning in the Visual Studio debugger. Be aware of potential security threats when using Source Server.
ms.date: "11/04/2016"
ms.topic: article
f1_keywords:
  - "vs.debug.sourceserver.enablewarning"
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
# Source Server Security Alert

When using Source Server, only use symbol files that are from a known and trusted location.

 This warning appears when you enable Source Server support. Source Server commands are embedded in debug symbol files (**\*.pdb** files). Make sure you know where your PDB files come from.

> [!IMPORTANT]
> The following potential security threats must be taken into account when using Source Server: Arbitrary commands can be embedded in the application's PDB file, so make sure you put only the ones you want to execute in the srcsrv.ini file. Any attempt to execute a command not in the srcsvr.ini file will cause a confirmation dialog box to appear. For more information, see [Security Warning: Debugger Must Execute Untrusted Command](../debugger/security-warning-debugger-must-execute-untrusted-command.md). No validation is done on command parameters, so be careful with trusted commands. For example, if you trusted cmd.exe, a malicious user might specify parameters that would make the command dangerous.

## Related content
- [Specify Symbol (.pdb) and Source Files](../debugger/specify-symbol-dot-pdb-and-source-files-in-the-visual-studio-debugger.md)
- [Debugger Security](../debugger/debugger-security.md)
- [Source Server](/windows/desktop/Debug/source-server-and-source-indexing)
