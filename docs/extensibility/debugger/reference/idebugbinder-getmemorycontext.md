---
title: "IDebugBinder::GetMemoryContext | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugBinder::GetMemoryContext"
helpviewer_keywords:
  - "IDebugBinder::GetMemoryContext method"
ms.assetid: 801c5b60-acff-4822-b23d-e9c7bbca8a0f
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugBinder::GetMemoryContext
This method converts either an object location or a memory address to a memory context.

## Syntax

```cpp
HRESULT GetMemoryContext( 
   IDebugField*           pField,
   DWORD                  dwConstant,
   IDebugMemoryContext2** ppMemCxt
);
```

```csharp
int GetMemoryContext(
   IDebugField              pField,
   uint                     dwConstant,
   out IDebugMemoryContext2 ppMemCxt
);
```

## Parameters
`pField`\
[in] An [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) describing the object to locate. If `NULL`, then use `dwConstant` instead.

`dwConstant`\
[in] A constant memory address, such as 0x5000.

`ppMemCxt`\
[out] Returns the [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) interface that represents the address of the object, or the address in memory.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)