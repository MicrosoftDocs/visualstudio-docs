---
description: "If the remote machine doesn't appear in the Remote Connections dialog, check the following common causes."
title: "Remote machine doesn't appear in a Remote Connections dialog"
ms.date: "09/04/2025"
ms.topic: "error-reference"
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
# Error: Remote machine doesn't appear in a Remote Connections dialog

If the remote machine doesn't appear in the Remote Connections dialog, check the following common causes.


### Common causes for this error

- The remote machine is running on a machine that is in a different subnet. To fix this, manually type the machine name or IP address in the Qualifier dialog

- The remote debugger isn't running on the remote machine. To fix this, start the remote debugger.

- The firewall is blocking communication between Visual Studio and the remote machine. To fix this, configure your firewall to allow Visual Studio and the remote debugger (msvsmon) to communicate. For more information, see [Configure Windows Firewall for remote debugging](../debugger/error-remote-machine-does-not-appear-in-a-remote-connections-dialog.md).

- Antivirus software is blocking communication between Visual Studio and the remote machine. To fix this, configure antivirus software to allow Visual Studio and the remote debugger (msvsmon) to communicate.

## See also
- [Remote Debugging](../debugger/remote-debugging.md)
