---
description: "Attaches to the associated program or defers the attach process to the Attach method."
title: IDebugProgramNodeAttach2::OnAttach | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgramNodeAttach2::OnAttach
helpviewer_keywords:
- IDebugProgramNodeAttach2::OnAttach
ms.assetid: 5fe52761-a508-4ab5-abdb-334fb6590334
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugProgramNodeAttach2::OnAttach
Attaches to the associated program or defers the attach process to the [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) method.

## Syntax

```cpp
HRESULT OnAttach(
   [in] REFGUID guidProgramId
);
```

```csharp
int OnAttach(
   ref Guid guidProgramId
};
```

## Parameters
`guidProgramId`\
[in] `GUID` to assign to the associated program.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if the [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) method should not be called. Otherwise, returns an error code.

## Remarks
 This method is called during the attach process, before the [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md) method is called. The `OnAttach` method can perform the attach process itself (in which case, this method returns `S_FALSE`) or defer the attach process to the `IDebugEngine2::Attach` method (the `OnAttach` method returns `S_OK`). In either event, the `OnAttach` method can set the `GUID` of the program being debugged to the given `GUID`.

## See also
- [IDebugProgramNodeAttach2](../../../extensibility/debugger/reference/idebugprogramnodeattach2.md)
- [Attach](../../../extensibility/debugger/reference/idebugengine2-attach.md)
