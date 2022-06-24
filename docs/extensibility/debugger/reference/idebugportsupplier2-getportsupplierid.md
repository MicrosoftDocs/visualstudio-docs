---
description: "Gets the port supplier identifier."
title: IDebugPortSupplier2::GetPortSupplierId | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugPortSupplier2::GetPortSupplierId
helpviewer_keywords:
- IDebugPortSupplier2::GetPortSupplierId
ms.assetid: 741d0829-0943-49bf-b56e-61e836043006
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugPortSupplier2::GetPortSupplierId

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Gets the port supplier identifier.

## Syntax

### [C#](#tab/csharp)
```csharp
HRESULT GetPortSupplierId( 
   out Guid pguidPortSupplier
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetPortSupplierId( 
   GUID* pguidPortSupplier
);
```
---

## Parameters
`pguidPortSupplier`\
[out] Returns the GUID of the port supplier.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugPortSupplier2](../../../extensibility/debugger/reference/idebugportsupplier2.md)
