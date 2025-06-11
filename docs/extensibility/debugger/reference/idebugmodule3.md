---
description: "This interface represents a module that supports alternate locations of symbols and JustMyCode states."
title: IDebugModule3
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugModule3
helpviewer_keywords:
- IDebugModule3 interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugModule3

This interface represents a module that supports alternate locations of symbols and JustMyCode states.

## Syntax

```
IDebugModule3 : IDebugModule2
```

## Notes for Implementers
 The debug engine (DE) implements this interface to support alternate locations of symbols and to work with JustMyCode states (see the [Visual Studio Debugger Glossary](../../../extensibility/debugger/reference/visual-studio-debugger-glossary.md) for a definition of "JustMyCode").

## Notes for Callers
 A call to [GetSymbolSearchInfo](../../../extensibility/debugger/reference/idebugsymbolsearchevent2-getsymbolsearchinfo.md) returns this interface. The DE sends the [IDebugSymbolSearchEvent2](../../../extensibility/debugger/reference/idebugsymbolsearchevent2.md) interface to the session debug manager (SDM) using the [Event](../../../extensibility/debugger/reference/idebugeventcallback2-event.md) method. Also, a call to [QueryInterface](/cpp/atl/queryinterface) on an [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md) interface returns this interface.

## Methods in Vtable Order
 In addition to the methods on the [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md) interface, this interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[GetSymbolInfo](../../../extensibility/debugger/reference/idebugmodule3-getsymbolinfo.md)|Returns a list of paths searched for symbols and the results of searching each path.|
|[LoadSymbols](../../../extensibility/debugger/reference/idebugmodule3-loadsymbols.md)|Loads and initializes symbols for the current module.|
|[IsUserCode](../../../extensibility/debugger/reference/idebugmodule3-isusercode.md)|Returns flag specifying whether the module represents user code.|
|[SetJustMyCodeState](../../../extensibility/debugger/reference/idebugmodule3-setjustmycodestate.md)|Specifies whether the module should be considered user code or not.|

## Remarks
 Visual Studio is the typical consumer of this interface.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [IDebugModule2](../../../extensibility/debugger/reference/idebugmodule2.md)
- [IDebugSymbolSearchEvent2](../../../extensibility/debugger/reference/idebugsymbolsearchevent2.md)
- [GetSymbolSearchInfo](../../../extensibility/debugger/reference/idebugsymbolsearchevent2-getsymbolsearchinfo.md)
