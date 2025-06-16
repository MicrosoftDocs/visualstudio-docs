---
description: "Loads (as necessary) symbols for all modules being debugged by this debugging engine."
title: IDebugEngine3::LoadSymbols
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine3::LoadSymbols
helpviewer_keywords:
- IDebugEngine3::LoadSymbols
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine3::LoadSymbols

Loads (as necessary) symbols for all modules being debugged by this debugging engine.

## Syntax

### [C#](#tab/csharp)
```csharp
int LoadSymbols();
```
### [C++](#tab/cpp)
```cpp
HRESULT LoadSymbols();
```
---

## Parameters
 None.

## Return Value
 If successful, returns S_OK; otherwise returns error code.

## Remarks
 This loads debugging symbols for all modules referenced by this debugging engine. The symbols are loaded only if they have not already been loaded. Symbols are searched on the paths set by a call to [SetSymbolPath](../../../extensibility/debugger/reference/idebugengine3-setsymbolpath.md).

## See also
- [SetSymbolPath](../../../extensibility/debugger/reference/idebugengine3-setsymbolpath.md)
- [IDebugEngine3](../../../extensibility/debugger/reference/idebugengine3.md)
