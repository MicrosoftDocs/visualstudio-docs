---
description: "This warning dialog box appears when you attach to a process that contains partially trusted code or is owned by an untrusted user immediately before the attach occurs."
title: "Security Warning: Attaching to a process owned by an untrusted user can be dangerous. If the following information looks suspicious or you are unsure, do not attach to this process | Microsoft Docs"
ms.date: "1/15/2021"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.attachsecuritywarning"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
ms.assetid: 52246c1e-a371-40a0-b756-a435cc51876f
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Security Warning: Attaching to a process owned by an untrusted user can be dangerous. If the following information looks suspicious or you are unsure, do not attach to this process

This warning dialog box appears when you attach to a process that contains partially trusted code or is owned by an untrusted user immediately before the attach occurs. An untrusted process that contains malicious code has the potential to damage the computer doing the debugging. If you have reason to distrust the process, then you should click **Cancel** to prevent debugging.

In IIS scenarios, you may see this warning if you use a custom application pool, which is untrusted.

To suppress this warning when debugging a legitimate scenario:

1. Close Visual Studio.

1. Set the value of the `DisableAttachSecurityWarning` registry key to 1.

   Find or create the key under `HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\<version>\Debugger`, and set it to 1.

   Starting in Visual Studio 2017, if you want to view the complete registry settings, you need to load the private registry hive. For more information, see [How to examine Visual Studio 2017 registry](https://github.com/microsoft/VSProjectSystem/blob/master/doc/overview/examine_registry.md). Make sure you unload the private registry hive before starting Visual Studio.

1. Restart Visual Studio.

1. After you finish debugging the scenario, reset the value to 0, and restart Visual Studio.

"Trusted users" include yourself, plus a set of standard users who are typically defined on computers that have the .NET Framework installed, such as `aspnet`, `localsystem`, `networkservice`, and `localservice`.

## UIElement List

 Name
 Name of the assembly requested to debug

 User
 Current user

 Attach
 Press to continue to debug by attaching

 Don't Attach
 Do not attach to the process

## See also
- [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)
- [Debugger Security](../debugger/debugger-security.md)
