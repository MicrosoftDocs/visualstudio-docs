---
description: "Allows a program node to be notified of an attempt to attach to the associated program."
title: IDebugProgramNodeAttach2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramNodeAttach2
helpviewer_keywords:
- IDebugProgramNodeAttach2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugProgramNodeAttach2

Allows a program node to be notified of an attempt to attach to the associated program.

## Syntax

```
IDebugProgramNodeAttach2 : IUnknown
```

## Notes for Implementers
 This interface is implemented on the same class that implements the [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) interface in order to receive notification of an attach operation and to provide an opportunity to cancel the attach operation.

## Notes for Callers
 Obtain this interface by calling the `QueryInterface` method in an [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) object. The [OnAttach](../../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md) method must be called before the [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) method to give the program node a chance to stop the attach process.

## Methods in Vtable Order
 This interface implements the following method:

|Method|Description|
|------------|-----------------|
|[OnAttach](../../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md)|Attaches to the associated program or defers the attach process to the [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) method.|

## Remarks
 This interface is the preferred alternative to the deprecated [Attach_V7](../../../extensibility/debugger/reference/idebugprogramnode2-attach-v7.md) method. All debug engines are always loaded with the `CoCreateInstance` function, that is, they are instantiated outside the address space of the program being debugged.

 If a previous implementation of the `IDebugProgramNode2::Attach_V7` method was simply setting the `GUID` of the program being debugged, then only the [OnAttach](../../../extensibility/debugger/reference/idebugprogramnodeattach2-onattach.md) method needs to be implemented.

 If a previous implementation of the `IDebugProgramNode2::Attach_V7` method used the callback interface that was provided, then that functionality needs to be moved to an implementation of the [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) method and the `IDebugProgramNodeAttach2` interface does not have to be implemented.

## Requirements
 Header: Msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
- [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md)
- [Attach_V7](../../../extensibility/debugger/reference/idebugprogramnode2-attach-v7.md)
