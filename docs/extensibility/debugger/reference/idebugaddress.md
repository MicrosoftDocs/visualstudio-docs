---
description: "This interface represents the address of an item."
title: IDebugAddress | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugAddress
helpviewer_keywords:
- IDebugAddress interface
ms.assetid: bc709ff7-4966-4f36-9af2-690efe2cea1d
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
---
# IDebugAddress
This interface represents the address of an item. It is returned by the symbol handler.

## Syntax

```
IDebugAddress : IUnknown
```

## Notes for Implementers
 A symbol provider implements this interface to represent an address of an object.

## Notes for Callers
 Many methods on many interfaces return this interface.

## Methods in Vtable Order
 This interface implements the following method:

|Method|Description|
|------------|-----------------|
|[GetAddress](../../../extensibility/debugger/reference/idebugaddress-getaddress.md)|Retrieves a [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) structure describing an object and its location.|

## Remarks
 The symbol provider returns this interface to represent an object and its location within a particular scope (for example, function, method, or class). This interface is returned from and passed to various methods of the symbol provider and expression evaluator. Normally, the symbol provider is the only entity that needs to interpret the contents of this interface.

## Requirements
 Header: sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)
- [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md)
