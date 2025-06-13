---
title: Choosing a Debug Engine Implementation Strategy
description: Learn how the run-time architecture helps you to choose from several strategies for debug engine implementation.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debug engines, implementation strategies
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Choose a debug engine implementation strategy

Use the run-time architecture to determine your debug engine (DE) implementation strategy. You can create the debug engine in-process to the program you're debugging. Create the debug engine in-process to the Visual Studio session debug manager (SDM). Or, create the debug engine out-of-process to both of them. The following guidelines should help you choose among these three strategies.

## Guidelines
 While it's possible for the DE to be out-of-process to both the SDM and the program you're debugging, there's typically no reason to do so. Calls across process boundaries are relatively slow.

 Debug engines are already provided for the Win32 native run-time environment and for the common language run-time environment. If you have to replace the DE for either environment, you should create the DE in-process with the SDM.

 Otherwise, you either create the DE in-process to the SDM or in-process to the program you're debugging. You'll need to consider if the expression evaluator of the DE requires frequent access to the program symbol store. Or, if the symbol store can be loaded into memory for rapid access. Also, consider the following approaches:

- If there are not many calls between the expression evaluator and the symbol store, or if the symbol store can be read into the SDM memory space, create the DE in-process to the SDM. You must return the CLSID of the debug engine to the SDM when it attaches to your program. The SDM uses this CLSID to create an in-process instance of the DE.

- If the DE must call the program to access the symbol store, create the DE in-process with the program. In this case, the program creates the instance of the DE.

## Related content
- [Visual Studio debugger extensibility](../../extensibility/debugger/visual-studio-debugger-extensibility.md)
