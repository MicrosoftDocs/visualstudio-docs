---
description: "Gets the alias associated with this object, if any."
title: IDebugObject2::GetAlias | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject2::GetAlias
helpviewer_keywords:
- IDebugObject2::GetAlias method
ms.assetid: aa6824d5-c932-42ba-8713-950e7d1fb42f
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
# IDebugObject2::GetAlias

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Gets the alias associated with this object, if any.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetAlias(
   out IDebugAlias ppAlias
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetAlias(
   IDebugAlias** ppAlias
);
```
---

## Parameters
`ppAlias`\
[out] Returns an [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md) object representing the alias for this object; otherwise, returns a null value.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 An alias for an object is created with a call to the [CreateAlias](../../../extensibility/debugger/reference/idebugobject2-createalias.md) method.

## See also
- [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)
- [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)
