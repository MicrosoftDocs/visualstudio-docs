---
title: "IDebugField::GetAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugField::GetAddress"
helpviewer_keywords:
  - "IDebugField::GetAddress method"
ms.assetid: 6981bf03-66ef-4bf9-87ea-f6c9624486cb
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugField::GetAddress
This method gets the debug address of a field.

## Syntax

```cpp
HRESULT GetAddress( 
   IDebugAddress** ppAddress
);
```

```csharp
int GetAddress(
   out IDebugAddress ppAddress
);
```

## Parameters
`ppAddress`\
[out] Returns the address as an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) object.

## Return Value
 If successful, returns `S_OK`; otherwise, return an error code.

## See also
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)