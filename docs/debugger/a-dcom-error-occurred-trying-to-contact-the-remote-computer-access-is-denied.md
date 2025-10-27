---
title: A DCOM error occurred trying to contact the remote computer. Access is denied.
titleSuffix: ""
description: A DCOM error occurred trying to contact the remote computer. Access is denied. View information about this Visual Studio remote debugging error reference.
ms.date: "10/24/2025"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.remote.dcom_access_denied"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords:
  - "remote debugging, DCOM error"
  - "remote DCOM access denied error"
  - "DCOM, access errors"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# A DCOM error occurred trying to contact the remote computer. Access is denied.

Remote debugging uses Distributed Component Object Model (DCOM) to communicate between the local and remote computers in the following situations.

:::moniker range="visualstudio"

- Debugger compatibility options labeled as **Native only** or **Managed only** are checked. These options are located in the **Tools** > **Options** pane under the **All Settings** > **Debugging** > **General** section and other sections, as applicable.

:::moniker-end
:::moniker range="vs-2022"

- Debugger compatibility options labeled as **Native only** or **Managed only** are checked under **Tools** > **Options** in the **Debugging** > **General** section.

:::moniker-end
:::moniker range="<=vs-2019"

- The debugger **Native Compatibility Mode** or **Managed Compatibility Mode** option is checked. These options are located under **Tools** > **Options** > **Debugging** > **General**.

:::moniker-end

- You're debugging managed C++ (C++/CLI) code.

- In earlier versions of Visual Studio, when the **Enable native Edit and Continue** option is checked in the **Tools** > **Options** > **Debugging** page.

- Some non-Microsoft debugging scenarios.

   This error occurs when the Visual Studio process can't authenticate itself (or the supplied credentials are deemed insufficient) to the remote debugger process over DCOM. One or more of the following workarounds might resolve the issue:

   - Turn off the **Native Compatibility Mode** and **Managed Compatibility Mode** options.

   - In earlier versions of Visual Studio, turn off the **Enable native Edit and Continue** option.

   - Reboot both computers.

   - If remote debugging requires entering credentials, check the option to save the credentials.

## See also

- [Remote Debugging Errors and Troubleshooting](../debugger/remote-debugging-errors-and-troubleshooting.md)
- [Remote Debugging](../debugger/remote-debugging.md)
