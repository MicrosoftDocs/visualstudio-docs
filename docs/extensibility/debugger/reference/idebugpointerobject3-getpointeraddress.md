---
title: "IDebugPointerObject3::GetPointerAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
helpviewer_keywords:
  - "GetPointerAddress"
  - "IDebugPointerObject3::GetPointerAddress"
ms.assetid: 4cc5af04-9e70-420d-8230-ef3108df6d51
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# IDebugPointerObject3::GetPointerAddress
Retrieves the address of the pointer.

## Syntax

```cpp
HRESULT GetPointerAddress (
   UINT64* puAddress
);
```

```csharp
int GetPointerAddress (
   out ulong puAddress
);
```

#### Parameters
 `puAddress`

 [out] Returns the address of the pointer.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See Also
- [IDebugPointerObject3](../../../extensibility/debugger/reference/idebugpointerobject3.md)