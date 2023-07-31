---
description: "This method gets the type of field."
title: IDebugField::GetType | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugField::GetType
helpviewer_keywords:
- IDebugField::GetType method
ms.assetid: b3cdec9f-ef7b-44d0-a775-d17ef7eae968
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
# IDebugField::GetType

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
This method gets the type of field.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetType(
   out IDebugField ppType
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetType( 
   IDebugField** ppType
);
```
---

## Parameters
`ppType`\
[out] Returns the field type as another [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
