---
description: "Sets the reference type."
title: IDebugReference2::SetReferenceType | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugReference2::SetReferenceType
helpviewer_keywords:
- IDebugReference2::SetReferenceType
ms.assetid: 5854a172-ea82-481c-97d9-c7fc16923d44
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
# IDebugReference2::SetReferenceType

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Sets the reference type. Reserved for future use.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetReferenceType ( 
   enum_REFERENCE_TYPE dwRefType
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetReferenceType ( 
   REFERENCE_TYPE dwRefType
);
```
---

## Parameters
`dwRefType`\
[in] A value from the [REFERENCE_TYPE](../../../extensibility/debugger/reference/reference-type.md) enumeration that specifies the reference type.

## Return Value
 Always returns `E_NOTIMPL`.

## See also
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
- [REFERENCE_TYPE](../../../extensibility/debugger/reference/reference-type.md)
