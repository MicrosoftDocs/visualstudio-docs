---
description: "Registers a program that can be debugged with the port it is running on."
title: IDebugPortNotify2::AddProgramNode
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortNotify2::AddProgramNode
helpviewer_keywords:
- IDebugPortNotify2::AddProgramNode
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortNotify2::AddProgramNode

Registers a program that can be debugged with the port it is running on.

## Syntax

### [C#](#tab/csharp)
```csharp
int AddProgramNode( 
   IDebugProgramNode2 pProgramNode
);
```
### [C++](#tab/cpp)
```cpp
HRESULT AddProgramNode( 
   IDebugProgramNode2* pProgramNode
);
```
---

## Parameters
`pProgramNode`\
[in] An [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) object that represents the program to be registered.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A program node can be unregistered from the port by calling the [RemoveProgramNode](../../../extensibility/debugger/reference/idebugportnotify2-removeprogramnode.md) method.

## See also
- [IDebugPortNotify2](../../../extensibility/debugger/reference/idebugportnotify2.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
- [RemoveProgramNode](../../../extensibility/debugger/reference/idebugportnotify2-removeprogramnode.md)
