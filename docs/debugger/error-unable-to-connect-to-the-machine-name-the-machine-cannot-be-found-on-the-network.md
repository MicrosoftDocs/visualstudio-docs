---
title: "Error: Unable to connect to the machine &lt;name&gt;. The machine cannot be found on the network. | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
f1_keywords:
  - "vs.debug.remote.dcom_disabled"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "DCOM, unable to connect error"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Error: Unable to connect to the machine &lt;name&gt;. The machine cannot be found on the network.
This behavior occurs if one of the following conditions is true:

- Your connection to the remote computer was broken.

- Your user account on the remote computer is disabled.

- Your password on the remote computer has expired.

### To resolve this behavior

- Make sure that the local computer and the remote computer are in the same network. To do this, use Microsoft Windows Explorer (or File Explorer) to try to access the remote computer.

     — and —

- Make sure that the user account that you are using to connect to the remote computer is enabled.

     — and —

- Make sure that the password that you are using to connect to the remote computer is valid and has not expired.

## See also
- [Remote Debugging](../debugger/remote-debugging.md)
- [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)