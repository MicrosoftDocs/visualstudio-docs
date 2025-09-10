---
title: "Protected mode for dump debugging"
description: Using protected mode to debug dumps in isolation.
ms.date: "09/04/2025"
ms.topic: "conceptual"
author: "auott"
ms.author: "auott"
manager: barryta
ms.subservice: debug-diagnostics
monikerRange: '>= visualstudio'
---
# Protected mode for dump debugging

When debugging dump files from untrusted sources, Visual Studio by default enables protected mode to provide a secure debugging environment.

## What is protected mode?

Protected mode isolates the debugger process from the rest of the system via AppContainer isolation. This isolation helps prevent malicious code or data within the dump file from affecting your system or accessing sensitive information.

## Limitations

* The “Tasks” view will be empty in the Parallel Tasks window
* The Debugger Tasks Window (Debug->Windows->Tasks) will be empty
* Protected mode is not enabled for Diagnostic Analysis and Debug Managed Memory

## Disabling protected mode

Protected mode can be disabled for a dump temporarily by unselecting the 'Protected' toggle on the dump summary page, or permanently for the dump by marking it as trusted using the the 'Trust' button.

## Related content
- [Using Dump Files](../debugger/using-dump-files.md)