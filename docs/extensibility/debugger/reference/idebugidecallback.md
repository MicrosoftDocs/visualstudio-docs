---
description: "Enables an expression evaluator (EE) to display a message in the debugger's output window."
title: IDebugIDECallback | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugIDECallback interface
ms.assetid: 8d31adc0-1c44-4658-8d4f-f4b73e35f4a6
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# IDebugIDECallback
> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 Enables an expression evaluator (EE) to display a message in the debugger's output window.

## Syntax

```
IDebugIDECallback : IUnknown
```

## Notes for Implementers
 This callback is implemented by the managed debug engine.

## Notes for Callers
 It can be consumed by an expression evaluator to send output to the debugger's output window.

## Methods
 This interface implements the following method:

|Method|Description|
|------------|-----------------|
|[DisplayMessage](../../../extensibility/debugger/reference/idebugidecallback-displaymessage.md)|Sends the specified message string to the debugger's output window.|

## Requirements
 Header: Ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
