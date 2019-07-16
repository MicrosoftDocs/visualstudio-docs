---
title: "IDebugObject::GetMemoryContext | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugObject::GetMemoryContext"
helpviewer_keywords:
  - "IDebugObject::GetMemoryContext method"
ms.assetid: 6760a0d3-a898-4e81-b68f-c45c584b225b
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugObject::GetMemoryContext
Gets the memory context that represents the address of the value of the object.

## Syntax

```cpp
HRESULT GetMemoryContext( 
   IDebugMemoryContext2** pContext
);
```

```csharp
int GetMemoryContext(
   ref IDebugMemoryContext2 pContext
);
```

## Parameters
`pContext`\
[out] Returns an [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) object representing the address of the value of the object.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The returned memory context specifies the address of the value as represented by this [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object.

## See also
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)