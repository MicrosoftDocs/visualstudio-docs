---
description: "Loads the symbols for the current module."
title: IDebugModule3::LoadSymbols
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugModule3::LoadSymbols
helpviewer_keywords:
- IDebugModule3::LoadSymbols
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugModule3::LoadSymbols

Loads the symbols for the current module.

## Syntax

### [C#](#tab/csharp)
```csharp
int LoadSymbols();
```
### [C++](#tab/cpp)
```cpp
HRESULT LoadSymbols(
   void
);
```
---

## Return Value
 If the method succeeds, it returns `S_OK`. If it fails, it returns an error code.

## Remarks
 This method loads the symbols from the current search path (which can be altered by calling the [SetSymbolPath](../../../extensibility/debugger/reference/idebugengine3-setsymbolpath.md) method).

 This method is preferred over the [ReloadSymbols_Deprecated](../../../extensibility/debugger/reference/idebugmodule2-reloadsymbols-deprecated.md) method.

## See also
- [IDebugModule3](../../../extensibility/debugger/reference/idebugmodule3.md)
- [SetSymbolPath](../../../extensibility/debugger/reference/idebugengine3-setsymbolpath.md)
