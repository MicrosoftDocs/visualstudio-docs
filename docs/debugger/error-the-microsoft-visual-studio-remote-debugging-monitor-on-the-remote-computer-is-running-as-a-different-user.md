---
title: "Error: The Microsoft Visual Studio Remote Debugging Monitor on the remote computer is running as a different user"
titleSuffix: ""
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "-anyuser option"
  - "anyuser option"
  - "Remote Debugging Monitor"
  - "remote debugging, Remote Debugging Monitor"
  - "msvsmon.exe"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Error: The Microsoft Visual Studio Remote Debugging Monitor on the remote computer is running as a different user
When trying to do remote debugging, you may get the following error message:

 The Microsoft Visual Studio Remote Debugging Monitor on the remote computer is running as a different user.

## Cause
 This message occurs when you are debugging in No Authentication mode and the user who started msvsmon is not the user who is running Visual Studio.

## Solution
 The safest and best solution is to run the Remote Debugging Monitor (msvsmon.exe) under the same user account as Visual Studio. If you cannot do that, you can run Remote Debugging Monitor under the other account with the **Allow any user to debug** option selected in the Remote Debugging Monitor **Options** dialog box.

> [!CAUTION]
> Granting other users permission to connect allows the possibility of accidentally connecting to the wrong remote debugging session. Debugging in **No Authentication** mode is never secure and should be used with caution.

## See also
- [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)
- [Remote Debugging](../debugger/remote-debugging.md)