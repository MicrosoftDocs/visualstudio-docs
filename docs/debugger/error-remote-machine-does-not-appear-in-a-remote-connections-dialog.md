---
title: "Error: Remote machine does not appear in a Remote Connections dialog | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Error: Remote machine does not appear in a Remote Connections dialog
If the remote machine does not appear in the Remote Connections dialog, check the following common causes.

 If you are using managed compatibility mode, please check the Visual Studio 2010 documentation: [Troubleshooting Remote Debugging - Visual Studio 2010](https://docs.microsoft.com/previous-versions/visualstudio/visual-studio-2010/2ys11ead(v=vs.100)).

### Common causes for this error

- The remote machine is running on a machine that is in a different subnet. To fix this, manually type the machine name or IP address in the Qualifier dialog

- The remote debugger is not running on the remote machine. To fix this, start the remote debugger.

- The firewall is blocking communication between Visual Studio and the remote machine. To fix this, configure your firewall to allow Visual Studio and the remote debugger (msvsmon) to communicate.

- Antivirus software is blocking communication between Visual Studio and the remote machine. To fix this, configure antivirus software to allow Visual Studio and the remote debugger (msvsmon) to communicate.

## See also
- [Remote Debugging](../debugger/remote-debugging.md)