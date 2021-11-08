---
title: A process has encountered an unrecoverable error
description: Learn about the processes that might encounter unrecoverable errors during the normal operations of Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 10/14/2021
ms.topic: troubleshooting
helpviewer_keywords:
- unrecoverable error
- error, process
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Visual Studio unrecoverable process error

::: moniker range="<=vs-2019"
Visual Studio uses several out-of-proc processes to run required background tasks, such as live unit testing, code analyzers, and more. These processes are run out-of-proc to give Visual Studio performance advantages, such as enabling Visual Studio to respond faster when running long, resource-intensive jobs. Also, because Visual Studio is a 32-bit process, running processes out-of-proc gives memory intensive work a larger memory space in which to operate.
:::moniker-end
:::moniker range=">=vs-2022"
Visual Studio uses several out-of-proc processes to run required background tasks, such as live unit testing, code analyzers, and more. These processes are run out-of-proc to give Visual Studio performance advantages, such as enabling Visual Studio to respond faster when running long, resource-intensive jobs.
:::moniker-end

If the *ServiceHub.RoslynCodeAnalysisService.exe* or *ServiceHub.RoslynCodeAnalysisService32.exe* process ends for some reason, a pop-up information bar appears with the following message:

**"Unfortunately, a process used by Visual Studio has encountered an unrecoverable error. We recommend saving your work, and then closing and restarting Visual Studio."**

If you see this message, you should save your work and then close and restart Visual Studio.

## List of processes

Following is a list of out-of-proc processes used by Visual Studio. This list is inclusive of processes that launch in specific workflows or scenarios, and so in most cases they aren't all running at the same time.

- Microsoft.Alm.Shared.Remoting.RemoteContainer.dll
- Microsoft.CodeAnalysis.LiveUnitTesting.EntryPoint
- MSBuild.exe
- PerfWatson2.exe
- ScriptedSandbox64.exe
- ServiceHub.Host.CLR.x86.exe
- ServiceHub.Host.Node.x86.exe
- ServiceHub.IdentityHost.exe
- ServiceHub.RoslynCodeAnalysisService.exe
- ServiceHub.RoslynCodeAnalysisService32.exe
- ServiceHub.SettingsHost.exe
- ServiceHub.VSDetouredHost.exe
- VBCSCompiler.exe
- VsHub.exe
- vstest.discoveryengine.x86.exe
- WaAppAgent.exe
- WindowsAzureGuestAgent.exe
- WindowsAzureTelemetryService.exe

If any of these processes terminates unexpectedly, some functionality within Visual Studio stops working. For some processes, the loss of functionality may be insignificant. For others, the stability of Visual Studio is affected and an error message is displayed.

> [!NOTE]
> If you experience a problem that's not referenced on this page, please report it to us via the [Report a Problem](../../ide/how-to-report-a-problem-with-visual-studio.md) tool that appears both in the Visual Studio Installer and in the Visual Studio IDE.
