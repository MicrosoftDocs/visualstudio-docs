---
description: "Represents a numeric alias for a variable, and enables an expression evaluator (EE) to obtain the application domain for the alias."
title: IDebugAlias2
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugAlias2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugAlias2

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 Represents a numeric alias for a variable, and enables an expression evaluator (EE) to obtain the application domain for the alias.

## Syntax

```
IDebugAlias2 : IDebugAlias
```

## Notes for Implementers
 This interface is implemented by the managed debug engine (DE).

## Methods
 In addition to the methods on the [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md) interface, this interface implements the following method:

|Method|Description|
|------------|-----------------|
|[GetAppDomainId](../../../extensibility/debugger/reference/idebugalias2-getappdomainid.md)|Retrieves the identifier for the application domain.|

## Remarks
 An alias is a decimal number in string form followed by the # character, for example, 1001#.

## Requirements
 Header: Ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
