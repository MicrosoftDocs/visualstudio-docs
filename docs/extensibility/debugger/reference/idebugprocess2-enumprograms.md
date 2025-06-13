---
description: "Retrieves a list of all the programs contained by this process."
title: IDebugProcess2::EnumPrograms
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProcess2::EnumPrograms
helpviewer_keywords:
- IDebugProcess2::EnumPrograms
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProcess2::EnumPrograms

Retrieves a list of all the programs contained by this process.

## Syntax

### [C#](#tab/csharp)
```csharp
int EnumPrograms( 
   out IEnumDebugPrograms2 ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT EnumPrograms( 
   IEnumDebugPrograms2** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugPrograms2](../../../extensibility/debugger/reference/ienumdebugprograms2.md) object that contains a list of all the programs in the process.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugProcess2](../../../extensibility/debugger/reference/idebugprocess2.md)
- [IEnumDebugPrograms2](../../../extensibility/debugger/reference/ienumdebugprograms2.md)
