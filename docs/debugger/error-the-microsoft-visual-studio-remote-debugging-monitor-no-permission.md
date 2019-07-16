---
title: "Error: The Microsoft Visual Studio Remote Debugging Monitor on the remote computer does not have permission to connect to this computer"
titleSuffix: ""
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
f1_keywords:
  - "vs.debug.error.access_denied_oncallback"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "remote debugging, Windows version error"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Error: The Microsoft Visual Studio Remote Debugging Monitor on the remote computer does not have permission to connect to this computer

This error occurs when the user who is trying to run the Visual Studio Remote Debugging Monitor (msvsmon) does not have an account on the local computer. This error may occur when remote debugging using the legacy debugging engine.

## To fix this problem

- Add a user account to the Visual Studio debugger host computer, with the same name and password as the user account running msvsmon on the remote computer,

   \- or -

- Run msvsmon as a user who has permission to call into the local computer. This means the user must be a domain user and an administrator on the msvsmon computer. You can specify the user account to run msvsmon in one of two ways:

  - Right-click the msvsmon icon and choose **Run As** on the shortcut menu

    \- or -

  - At the Command Prompt, run `runas.exe`.

## See also

- [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)
- [Remote Debugging](../debugger/remote-debugging.md)