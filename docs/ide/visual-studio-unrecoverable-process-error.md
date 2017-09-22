---
title: "Visual Studio unrecoverable process error | Microsoft Docs"
ms.custom: ""
ms.date: "02/23/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "editor"
ms.assetid: 2263956f-3ae0-4bdc-9d3a-4991dfaf4ddb
caps.latest.revision: 29
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
ms.technology: 
  - "vs-ide-general"
---
# Visual Studio unrecoverable process error

Visual Studio 2017 uses several out-of-proc processes to run required background tasks, such as live unit testing, code analyzers, and more. These processes are run out-of-proc to give Visual Studio performance advantages, such as enabling Visual Studio to respond faster when running resource-intensive, long-running jobs. Also, because Visual Studio is a 32-bit process, running processes out-of-proc gives memory intensive work a larger memory space in which to operate.

If any of these required processes end for some reason, a pop-up information bar appears with the following message:

"Unfortunately, a process used by Visual Studio has encountered an unrecoverable error. We recommend saving your work, and then closing and restarting Visual Studio."

If you see this message, you should immediately save your work and then close and restart Visual Studio. If you don't do this, Visual Studio can crash at any moment.

## List of processes

Following is a list of out-of-proc processes used by Visual Studio that must be running for Visual Studio to work properly.

- Microsoft.Alm.Shared.Remoting.RemoteContainer.dll
- Microsoft.CodeAnalysis.LiveUnitTesting.EntryPoint
- PerfWatson2.exe
- ServiceHub.Host.Node.x86.exe
- ServiceHub.IdentityHost.exe
- ServiceHub.VSDetouredHost.exe
- ServiceHub.SettingsHost.exe
- ServiceHub.Host.CLR.x86.exe
- ServiceHub.RoslynCodeAnalysisService32.exe
- WindowsAzureGuestAgent.exe
- WindowsAzureTelemetryService.exe
- WaAppAgent.exe
