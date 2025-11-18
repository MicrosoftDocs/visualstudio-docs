---
description: "This warning dialog box appears when you attach to a process that contains partially trusted code or is owned by an untrusted user immediately before the attach occurs."
title: "Security Warning: Attaching to a process owned by an untrusted user can be dangerous. If the following information looks suspicious or you are unsure, do not attach to this process"
ms.date: "1/26/2024"
ms.topic: article
f1_keywords:
  - "vs.debug.attachsecuritywarning"
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
# Security Warning: Attaching to a process owned by an untrusted user can be dangerous. If the following information looks suspicious or you are unsure, do not attach to this process

This warning dialog box appears when you attach to a process that contains partially trusted code or is owned by an untrusted user immediately before the attach occurs. An untrusted process that contains malicious code has the potential to damage the computer doing the debugging. If you have reason to distrust the process, then you should click **Cancel** to prevent debugging.

In IIS scenarios, you may see this warning if you use a custom application pool, which is untrusted.

To suppress this warning when debugging a legitimate scenario:

1. Close Visual Studio.

1. Set the value of the `DisableAttachSecurityWarning` registry key to 1.

   In older versions of Visual Studio, find or create the key under `HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\<version>\Debugger`, and set it to 1.

   Starting in Visual Studio 2017, you need to first load the private registry hive with `HKEY_USERS` selected. For more information, see [How to examine Visual Studio 2017 registry](https://github.com/microsoft/VSProjectSystem/blob/master/doc/overview/examine_registry.md). Make sure you unload the private registry hive before starting Visual Studio.

   In Visual Studio 2022, create the key under `HKEY_USERS\IsolatedHiveName\Software\Microsoft\VisualStudio\17.0_configID\Debugger`.

   In Visual Studio 2019, create the key under `HKEY_USERS\IsolatedHiveName\Software\Microsoft\VisualStudio\16.0_configID\Debugger`.

   In Visual Studio 2017, create the key under `HKEY_USERS\IsolatedHiveName\Software\Microsoft\VisualStudio\15.0_configID\Debugger`.

   :::moniker range=">= vs-2022"
   :::image type="content" source="../debugger/media/vs-2022/disable-attach-security-warning.png" alt-text="Screenshot of the security warning for attaching to a process owned by an untrusted user.":::
   :::moniker-end

1. Unload the private registry hive by selecting `HKEY_USERS` and then selecting **File** > **Unload Hive**.

1. Restart Visual Studio.

1. After you finish debugging the scenario, reset the value to 0, and restart Visual Studio.

"Trusted users" include yourself, plus a set of standard users who are typically defined on computers that have the .NET Framework installed, such as `aspnet`, `localsystem`, `networkservice`, and `localservice`.

## Related content

- [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)
- [Debugger Security](../debugger/debugger-security.md)
