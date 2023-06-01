---
description: "Gets an enumerator of all elements of the array."
title: IDebugArrayObject::GetElements | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugArrayObject::GetElements
helpviewer_keywords:
- IDebugArrayObject::GetElements method
ms.assetid: f6a6262f-5183-46ce-8a45-33ef46088b98
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
# IDebugArrayObject::GetElements

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Gets an enumerator of all elements of the array.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetElements(
   out IEnumDebugObjects ppEnum
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetElements( 
   IEnumDebugObjects** ppEnum
);
```
---

## Parameters
`ppEnum`\
[out] Returns an [IEnumDebugObjects](../../../extensibility/debugger/reference/ienumdebugobjects.md) object that allows enumerating over all elements.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 As an alternative, use the [GetCount](../../../extensibility/debugger/reference/idebugarrayobject-getcount.md) and [GetElement](../../../extensibility/debugger/reference/idebugarrayobject-getelement.md) methods to iterate through the elements.

## See also
- [IDebugArrayObject](../../../extensibility/debugger/reference/idebugarrayobject.md)
