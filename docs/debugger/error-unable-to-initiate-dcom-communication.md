---
title: "Error: Unable to initiate DCOM communication | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "troubleshooting"
f1_keywords:
  - "vs.debug.error.unmarshal_server_failed"
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
# Error: Unable to initiate DCOM communication
A DCOM error occurred when the local machine tried to communicate with the remote machine. This is caused by a firewall on the remote server or broken Windows authentication on the remote machine.

### To correct this error

- If the remote machine has Windows Firewall enabled, see [Remote Debugging](../debugger/remote-debugging.md) for instructions about how to configure the firewall for local debugging.

- To restore Windows authentication, try rebooting both machines. Examine event logs on local and remote machines for Kerberos errors and contact domain administrators for known problems.

## See also
- [Remote Debugging](../debugger/remote-debugging.md)