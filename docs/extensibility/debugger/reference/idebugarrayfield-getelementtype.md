---
description: "Gets the type of element in the array."
title: IDebugArrayField::GetElementType | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugArrayField::GetElementType
helpviewer_keywords:
- IDebugArrayField::GetElementType method
ms.assetid: c46bf625-0a48-4cbb-8f1f-286356f2c065
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
# IDebugArrayField::GetElementType

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Gets the type of element in the array.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetElementType(
   out IDebugField ppType
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetElementType( 
   IDebugField** ppType
);
```
---

## Parameters
`ppType`\
[out] Returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object that describes the type of element.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The [IDebugArrayField](../../../extensibility/debugger/reference/idebugarrayfield.md) object assumes that all elements of the array are the same type.

## See also
- [IDebugArrayField](../../../extensibility/debugger/reference/idebugarrayfield.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
