---
title: "Visualizer Security Considerations"
description: A visualizer for Visual Studio debugger must run with full trust. As you write yours, be aware of possible security threats and take appropriate precautions.
ms.date: "12/21/2022"
ms.topic: article
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "visualizers, security"
  - "security [Visual Studio], visualizers"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Visualizer Security Considerations

Writing a Visualizer involves possible security threats. No known exploit currently exists for these potential threats, but developers should be aware of them and take appropriate security precautions, as described here, to guard against future exploits.

Debugger visualizers require greater privileges than are allowed by a partial trust application. Visualizers will not load when you are stopped in code with partial trust. To debug using a visualizer, you must run the code with full trust.

> [!NOTE]
> Code Access Security (CAS) has been deprecated across all versions of .NET Framework and .NET. Recent versions of .NET do not honor CAS annotations and produce errors if CAS-related APIs are used. Developers should seek alternative means of accomplishing security tasks.

## Possible Malicious Debuggee Component

 Visualizers consist of at least two classes: one on the debugger side and one on the debuggee side. Visualizers are often deployed in separate assemblies put in special directories, but they can also be loaded out of the debuggee. When this occurs, the debugger takes code out of the debuggee and runs it inside the debugger with full trust.

 Running debuggee-side code with full trust becomes problematic when the debuggee is not fully trusted. If a visualizer tries to load a partial trust assembly from the debuggee into the debugger, Visual Studio will terminate the visualizer.

 However, a minor vulnerability still exists. The debuggee-side can associate with a debugger side that was loaded from another source (not the debuggee). The debuggee side can then tell that trusted debugger side to perform actions on its behalf. If the trusted debugger-side class exposes a "delete this file" mechanism, for example, the partial-trust debuggee could invoke that mechanism when the user invokes its visualizer.

 To mitigate this vulnerability, be mindful of the interfaces exposed by your visualizer.

## Related content

- [Visualizer Architecture](../debugger/visualizer-architecture.md)
- [Create custom visualizers for .NET objects](../debugger/create-custom-visualizers-of-data.md)
- [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)
