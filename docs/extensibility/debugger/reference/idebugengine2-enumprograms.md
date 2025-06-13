---
description: "Retrieves a list of all programs being debugged by a debug engine (DE)."
title: IDebugEngine2::EnumPrograms
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugEngine2::EnumPrograms
helpviewer_keywords:
- IDebugEngine2::EnumPrograms
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugEngine2::EnumPrograms

Retrieves a list of all programs being debugged by a debug engine (DE).

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumPrograms( 
   out IEnumDebugPrograms2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumPrograms( 
   IEnumDebugPrograms2** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugPrograms2](../../../extensibility/debugger/reference/ienumdebugprograms2.md) object that contains a list of all programs being debugged by a DE.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugEngine2](../../../extensibility/debugger/reference/idebugengine2.md)
- [IEnumDebugPrograms2](../../../extensibility/debugger/reference/ienumdebugprograms2.md)
