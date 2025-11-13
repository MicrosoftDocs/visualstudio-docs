---
description: "This interface represents a module—that is, an executable unit of a program—such as a DLL."
title: IDebugModule2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugModule2
helpviewer_keywords:
- IDebugModule2 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugModule2

This interface represents a module—that is, an executable unit of a program—such as a DLL.

## Syntax

```
IDebugModule2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface to represent a module and to provide access to information about that module.

## Notes for Callers
 A call to [GetModule](../../../extensibility/debugger/reference/idebugmoduleloadevent2-getmodule.md) returns this interface. The DE sends the [IDebugModuleLoadEvent2](../../../extensibility/debugger/reference/idebugmoduleloadevent2.md) interface to the session debug manager (SDM) using the [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md) method.

 This interface can also be returned in a [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) structure (which is returned by a call to [EnumFrameInfo](../../../extensibility/debugger/reference/idebugthread2-enumframeinfo.md)).

- [Next](../../../extensibility/debugger/reference/ienumdebugmodules2-next.md) also returns this interface ([EnumModules](../../../extensibility/debugger/reference/idebugprogram2-enummodules.md) returns the [IEnumDebugModules2](../../../extensibility/debugger/reference/ienumdebugmodules2.md) interface).

## Methods in Vtable Order
 The following table shows the methods of `IDebugModule2`.

|Method|Description|
|------------|-----------------|
|[GetInfo](../../../extensibility/debugger/reference/idebugmodule2-getinfo.md)|Gets the [MODULE_INFO](../../../extensibility/debugger/reference/module-info.md) that describes this module.|
|[ReloadSymbols_Deprecated](../../../extensibility/debugger/reference/idebugmodule2-reloadsymbols-deprecated.md)|OBSOLETE. DO NOT USE. Reloads the symbols for this module.|

## Remarks
 Module information can be displayed in the **Modules** window of the IDE.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [MODULE_INFO](../../../extensibility/debugger/reference/module-info.md)
- [GetModule](../../../extensibility/debugger/reference/idebugmoduleloadevent2-getmodule.md)
- [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md)
- [IEnumDebugModules2](../../../extensibility/debugger/reference/ienumdebugmodules2.md)
