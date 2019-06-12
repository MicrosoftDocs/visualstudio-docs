---
title: "IDebugMemoryBytes2::WriteAt | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugMemoryBytes2::WriteAt"
helpviewer_keywords:
  - "IDebugMemoryBytes2::WriteAt method"
  - "WriteAt method"
ms.assetid: 61cc3704-47fa-4d9b-aa62-bb4585ac8fb1
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugMemoryBytes2::WriteAt
Writes the specified number of bytes of memory, starting at the specified address.

## Syntax

```cpp
HRESULT WriteAt( 
   IDebugMemoryContext2* pStartContext,
   DWORD                 dwCount,
   BYTE*                 rgbMemory
);
```

```csharp
int WriteAt(
   IDebugMemoryContext2 pStartContext,
   uint                 dwCount,
   byte[]               rgbMemory
);
```

## Parameters
`pStartContext`\
[in] The [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md) object that specifies where to start writing bytes.

`dwCount`\
[in] The number of bytes to write.

`rgbMemory`\
[in] The bytes to write. This array is assumed to be at least `dwCount` bytes in size.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` if not all bytes could be written or returns an error code (typically `E_FAIL`).

## Remarks
 If the starting address is not within the memory window represented by this [IDebugMemoryBytes2](../../../extensibility/debugger/reference/idebugmemorybytes2.md) object, no writing occurs and an error code of `E_FAIL` is returned — even if the amount to write overlaps into the memory space.

## See also
- [IDebugMemoryBytes2](../../../extensibility/debugger/reference/idebugmemorybytes2.md)
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)