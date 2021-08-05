---
description: "A DCOM error occurred when the remote machine tried to communicate with the local machine."
title: "Remote computer could not initiate DCOM communications | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.error.unmarshal_callback_failed"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Error: Remote computer could not initiate DCOM communications
A DCOM error occurred when the remote machine tried to communicate with the local machine. The local machine is the machine that is

 running Visual Studio. This error can occur for several reasons:

- The local machine has a firewall enabled.

- Windows authentication from the remote machine to the local machine is not working.

### To correct this error

1. If the local machine has Windows Firewall enabled, see [Remote Debugging](../debugger/remote-debugging.md) for instructions about how to configure the firewall for local debugging.

2. Test Windows authentication by trying to open a file share on the local machine from the remote server.

3. To restore Windows authentication, try rebooting both machines. Examine event logs on local and remote machines for Kerberos errors and contact domain administrators for known problems.

## See also
 [Remote Debugging](../debugger/remote-debugging.md)
