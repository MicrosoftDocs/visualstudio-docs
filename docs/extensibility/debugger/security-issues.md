---
title: Security Issues
description: Learn about the permissions needed to debug a program using Visual Studio, including remote debugging and situations that involve other services.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- security [Debugging SDK]
- debugging [Debugging SDK], security
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Security issues

To debug a program using Visual Studio, the only permissions needed are the same ones a developer requires to run the program. This includes remote debugging for most situations. Some situations, involving other services, such as the Internet Information Service, may require a higher level of permissions.

 While Visual Studio is running, the process debug manager (PDM) tracks debug processes on the local machine. Remotely, a program called *msvsmon.exe* is started by the developer to handle remote debugging and make the PDM available. (*msvsmon.exe* is not a service and must be started manually to enable remote debugging on that machine.) When Visual Studio (or *msvsmon.exe*) is not running, no processes are tracked for debugging.

 A developer can debug programs that they started with no special permissions. The developer can even debug processes started by someone else if that other person is a member of the same security group. And, to enable remote debugging, it's necessary only to copy the required files to the remote machine and start *msvsmon.exe*. For more information, see [Remote debugging](../../debugger/remote-debugging.md).

## Related content
- [Debugging tasks](../../extensibility/debugger/debugging-tasks.md)
- [Process debug manager](../../extensibility/debugger/process-debug-manager.md)
- [Remote debugging](../../debugger/remote-debugging.md)
