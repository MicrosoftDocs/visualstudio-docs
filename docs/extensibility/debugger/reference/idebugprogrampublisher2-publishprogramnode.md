---
title: "IDebugProgramPublisher2::PublishProgramNode | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProgramPublisher2::PublishProgramNode"
helpviewer_keywords:
  - "IDebugProgramPublisher2::PublishProgramNode"
ms.assetid: d4b72e04-f726-46cf-8e56-5203ff205b12
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProgramPublisher2::PublishProgramNode
Makes a program node available for use by debug engines (DEs) and the session debug manager (SDM).

## Syntax

```cpp
HRESULT PublishProgramNode(
   IDebugProgramNode2 *pProgramNode
);
```

```csharp
int PublishProgramNode(
   IDebugProgramNode2 pProgramNode
);
```

## Parameters
`pProgramNode`\
[in] An [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) object that represents the program node to make available.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method allows programs to be queried for information before selecting and launching them for debugging.

 To remove a program node from availability, call the [UnpublishProgramNode](../../../extensibility/debugger/reference/idebugprogrampublisher2-unpublishprogramnode.md) method.

## See also
- [IDebugProgramPublisher2](../../../extensibility/debugger/reference/idebugprogrampublisher2.md)
- [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
- [UnpublishProgramNode](../../../extensibility/debugger/reference/idebugprogrampublisher2-unpublishprogramnode.md)