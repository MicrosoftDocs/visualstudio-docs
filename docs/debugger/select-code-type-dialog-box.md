---
title: "Select Code Type Dialog Box | Microsoft Docs"
description: Learn about the Select Code Type dialog box in Visual Studio. To open this dialog box, open the Attach to Process dialog box, and then click the Select button.
ms.custom: SEO-VS-2020
ms.date: "06/12/2020"
ms.topic: "reference"
f1_keywords:
  - "vs.debug.selectengines"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
  - "SQL"
helpviewer_keywords:
  - "debugging [Visual Studio], engine selection"
  - "debugger, engine selection"
  - "debugging engine selection dialog box"
no-loc: ["Blazor WebAssembly"]
ms.assetid: 932269fe-94e3-43cb-8931-078f31afd177
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Select Code Type Dialog Box

To open this dialog box, open the **Attach to Process** dialog box, and then click the **Select** button.

**Automatically determine the type of code to debug**
The appropriate debugger will be selected based on the kind of code that is running.

**Debug these code types:**
From the list provided, choose the type(s) of code you want to debug. This can be helpful when [troubleshooting a failure to attach](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md#BKMK_Troubleshoot_attach_errors). This option restricts detection to only those types of code you want to debug.

::: moniker range=">=vs-2019"
- Blazor WebAssembly - Client-side Blazor WebAssembly
- GPU - Software Emulator - C++ code running on a GPU software emulator
- JavaScript (Chrome) - JavaScript running in Chrome
- JavaScript (Microsoft Edge - Chromium) - JavaScript running in Chromium-based Microsoft Edge for Windows 10
- JavaScript CDP (V3) Debugger - Chrome DevTools Protocol version 3, used for debugging in a CDP client
- Managed (CoreCLR) - .NET Core
- Managed (Native compilation) - C++/CLR code
- Managed (v3.5, v3.0, v2.0) - .NET Framework code for .NET Framework 2.0 and higher (up to 3.5)
- Managed (v.4.6, v4.5, v4.0) - .NET Framework code for .NET Framework 4.0 and higher
- Native - C/C++
- Node.js Debugging - Code hosted by the Node.js runtime
- Python - Python 
- Script - Specifies the general script debugger for JavaScript. Use more restrictive options if they apply to your scenario, such as JavaScript (Chrome).
- T-SQL - Transact-SQL
- Unity - Unity
- Managed Compatibility Mode - Specifies the legacy debugger for managed code, for use typically in mixed-mode debugging with C++/CLR code (enables Edit and Continue for mixed mode) or to support extensions that targeted the legacy debugger. In most mixed-mode debugging scenarios, select **Native** and the appropriate **Managed** code types instead of Managed Compatibility Mode.
::: moniker-end

For most scenarios, attaching multiple debuggers in the same debugging session is not supported. You may be able to do this using a second instance of Visual Studio.

## See also
- [Debugger Security](../debugger/debugger-security.md)
- [Attach to Running Processes](../debugger/attach-to-running-processes-with-the-visual-studio-debugger.md)
