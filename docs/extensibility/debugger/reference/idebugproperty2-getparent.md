---
description: "Gets the parent property of a property."
title: IDebugProperty2::GetParent | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty2::GetParent
helpviewer_keywords:
- IDebugProperty2::GetParent
ms.assetid: 58780469-fe25-4d84-9187-67940ca0767f
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
# IDebugProperty2::GetParent

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Gets the parent property of a property.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetParent ( 
   out IDebugProperty2 ppParent
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetParent ( 
   IDebugProperty2** ppParent
);
```
---

## Parameters
`ppParent`\
[out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the parent of the property.

## Return Value
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETPARENT_NO_PARENT` if there is no parent.

## See also
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
