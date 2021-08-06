---
description: "This method returns the exact type of a variable."
title: IDebugBinder::ResolveDynamicType | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder::ResolveDynamicType
helpviewer_keywords:
- IDebugBinder::ResolveDynamicType method
ms.assetid: 2c36ef92-5b44-4cfd-988e-54a2e5a6710c
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
# IDebugBinder::ResolveDynamicType
This method returns the exact type of a variable.

## Syntax

```cpp
HRESULT ResolveDynamicType (
   IDebugDynamicField *pDynamic,
   IDebugField       **ppResolved
);
```

```csharp
int ResolveDynamicType(
   IDebugDynamicField pDynamic,
   out IDebugField    ppResolved
);
```

## Parameters
`pDynamic`\
[in] An [IDebugDynamicField](../../../extensibility/debugger/reference/idebugdynamicfield.md) representing a type of a variable.

`ppResolved`\
[out] Returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) giving specific information about the variable's type.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [IDebugDynamicField](../../../extensibility/debugger/reference/idebugdynamicfield.md)
