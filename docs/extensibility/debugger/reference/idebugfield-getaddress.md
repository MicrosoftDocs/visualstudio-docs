---
description: "This method gets the debug address of a field."
title: IDebugField::GetAddress | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugField::GetAddress
helpviewer_keywords:
- IDebugField::GetAddress method
ms.assetid: 6981bf03-66ef-4bf9-87ea-f6c9624486cb
author: maiak
ms.author: maiak
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugField::GetAddress

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
This method gets the debug address of a field.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetAddress(
   out IDebugAddress ppAddress
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetAddress( 
   IDebugAddress** ppAddress
);
```
---

## Parameters
`ppAddress`\
[out] Returns the address as an [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) object.

## Return Value
 If successful, returns `S_OK`; otherwise, return an error code.

## See also
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)
