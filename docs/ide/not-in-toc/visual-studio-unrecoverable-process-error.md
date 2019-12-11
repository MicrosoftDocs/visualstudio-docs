---
title: A process has encountered an unrecoverable error
ms.date: 06/22/2018
ms.topic: troubleshooting
helpviewer_keywords:
  - "unrecoverable error"
  - "error, process"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Visual Studio unrecoverable process error

Visual Studio uses several out-of-proc processes to run required background tasks, such as live unit testing, code analyzers, and more. These processes are run out-of-proc to give Visual Studio performance advantages, such as enabling Visual Studio to respond faster when running long, resource-intensive jobs. Also, because Visual Studio is a 32-bit process, running processes out-of-proc gives memory intensive work a larger memory space in which to operate.

If the *ServiceHub.RoslynCodeAnalysisService.exe* or *ServiceHub.RoslynCodeAnalysisService32.exe* process ends for some reason, a pop-up information bar appears with the following message:

**"Unfortunately, a process used by Visual Studio has encountered an unrecoverable error. We recommend saving your work, and then closing and restarting Visual Studio."**

If you see this message, you should save your work and then close and restart Visual Studio.

## List of processes

Following is a list of out-of-proc processes used by Visual Studio. This list is inclusive of processes that launch in specific workflows or scenarios, and so in most cases they aren't all running at the same time.

- Microsoft.Alm.Shared.Remoting.RemoteContainer.dll
- Microsoft.CodeAnalysis.LiveUnitTesting.EntryPoint
- PerfWatson2.exe
- ServiceHub.Host.Node.x86.exe
- ServiceHub.IdentityHost.exe
- ServiceHub.VSDetouredHost.exe
- ServiceHub.SettingsHost.exe
- ServiceHub.Host.CLR.x86.exe
- ServiceHub.RoslynCodeAnalysisService32.exe
- ServiceHub.RoslynCodeAnalysisService.exe
- WindowsAzureGuestAgent.exe
- WindowsAzureTelemetryService.exe
- WaAppAgent.exe

If any of these processes terminates unexpectedly, some functionality within Visual Studio stops working. For some processes, the loss of functionality may be insignificant. For others, the stability of Visual Studio is affected and an error message is displayed.