---
description: "Unregisters a program that can be debugged from the port it is running on."
title: IDebugPortNotify2::RemoveProgramNode
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortNotify2::RemoveProgramNode
helpviewer_keywords:
- IDebugPortNotify2::RemoveProgramNode
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugPortNotify2::RemoveProgramNode

Unregisters a program that can be debugged from the port it is running on.

## Syntax

### [C#](#tab/csharp)
```csharp
int RemoveProgramNode( 
   IDebugProgramNode2 pProgramNode
);
```
### [C++](#tab/cpp)
```cpp
HRESULT RemoveProgramNode( 
   IDebugProgramNode2* pProgramNode
);
```
---

## Parameters
`pProgramNode`\
[in] An [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) object that represents the program to be unregistered.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method removes a program node that was added with a call to the [AddProgramNode](../../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md) method.

## See also
- [IDebugPortNotify2](../../../extensibility/debugger/reference/idebugportnotify2.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
- [AddProgramNode](../../../extensibility/debugger/reference/idebugportnotify2-addprogramnode.md)
