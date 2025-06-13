---
description: "This interface provides access to types, aliases, and custom visualizer services."
title: IDebugBinder3
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder3
helpviewer_keywords:
- IDebugBinder3 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugBinder3

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).

 This interface provides access to types, aliases, and custom visualizer services.

## Syntax

```
IDebugBinder3 : IDebugBinder
```

## Notes for Implementers
 A debug engine implements this interface to support aliases, custom visualizer services, and access to object type information.

## Notes for Callers
 An [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md) interface obtains this interface by using [QueryInterface](/cpp/atl/queryinterface).

## Methods in Vtable order
 In addition to the methods provided by the [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md) interface, this interface implements the following:

|Method|Description|
|------------|-----------------|
|[GetMemoryObject](../../../extensibility/debugger/reference/idebugbinder3-getmemoryobject.md)|Retrieves a memory object representing the memory to which this object is bound.|
|[GetExceptionObjectAndType](../../../extensibility/debugger/reference/idebugbinder3-getexceptionobjectandtype.md)|Retrieves the exception associated with this object (if any),|
|[FindAlias](../../../extensibility/debugger/reference/idebugbinder3-findalias.md)|Retrieves an alias given its name,|
|[GetAllAliases](../../../extensibility/debugger/reference/idebugbinder3-getallaliases.md)|Retrieves an array of all aliases for this object,|
|[GetTypeArgumentCount](../../../extensibility/debugger/reference/idebugbinder3-gettypeargumentcount.md)|Gets the number of argument types associated with this object,|
|[GetTypeArguments](../../../extensibility/debugger/reference/idebugbinder3-gettypearguments.md)|Retrieves a list of argument types associated with this object,|
|[GetEEService](../../../extensibility/debugger/reference/idebugbinder3-geteeservice.md)|Gets an interface to a visualizer service,|
|[GetMemoryContext64](../../../extensibility/debugger/reference/idebugbinder3-getmemorycontext64.md)|Converts either an object location or a 64-bit memory address to a memory context.|

## Requirements
 Header: ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Expression Evaluation Interfaces](../../../extensibility/debugger/reference/expression-evaluation-interfaces.md)
- [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)
