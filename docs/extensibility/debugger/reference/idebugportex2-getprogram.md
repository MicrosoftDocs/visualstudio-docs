---
description: "Gets the program associated with a program node."
title: IDebugPortEx2::GetProgram
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortEx2::GetProgram
helpviewer_keywords:
- IDebugPortEx2::GetProgram
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortEx2::GetProgram

Gets the program associated with a program node.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetProgram( 
   IDebugProgramNode2 pProgramNode,
   out IDebugProgram2 ppProgram
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetProgram( 
   IDebugProgramNode2* pProgramNode,
   IDebugProgram2**    ppProgram
);
```
---

## Parameters
`pProgramNode`
[in] An [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) object representing the program node.

`ppProgram`
[out] Returns an [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md) object that represents the program associated with the program node.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPortEx2](../../../extensibility/debugger/reference/idebugportex2.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
