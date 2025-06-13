---
description: "Removes a specified program node from availability to debug engines (DEs) and the session debug manager (SDM)."
title: IDebugProgramPublisher2::UnpublishProgramNode
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramPublisher2::UnpublishProgramNode
helpviewer_keywords:
- IDebugProgramPublisher2::UnpublishProgramNode
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgramPublisher2::UnpublishProgramNode

Removes a specified program node from availability to debug engines (DEs) and the session debug manager (SDM).

## Syntax

### [C#](#tab/csharp)
```csharp
int UnpublishProgramNode(
   IDebugProgramNode2 pProgramNode
);
```
### [C++](#tab/cpp)
```cpp
HRESULT UnpublishProgramNode(
   IDebugProgramNode2* pProgramNode
);
```
---

## Parameters
`pProgramNode`\
[in] An [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) object representing the program node being removed.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Once removed, the program node is no longer available to be queried for program information.

 To make a program node available, call the [PublishProgramNode](../../../extensibility/debugger/reference/idebugprogrampublisher2-publishprogramnode.md) method.

## See also
- [IDebugProgramPublisher2](../../../extensibility/debugger/reference/idebugprogrampublisher2.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
- [PublishProgramNode](../../../extensibility/debugger/reference/idebugprogrampublisher2-publishprogramnode.md)
