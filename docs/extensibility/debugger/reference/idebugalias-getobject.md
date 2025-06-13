---
description: "Gets the object that this alias is for."
title: IDebugAlias::GetObject
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugAlias::GetObject
helpviewer_keywords:
- IDebugAlias::GetObject method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugAlias::GetObject

Gets the object that this alias is for.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetObject(
   Out IDebugObject2 ppObject
)
```
### [C++](#tab/cpp)
```cpp
HRESULT GetObject(
   IDebugObject2** ppObject
);
```
---

## Parameters
`ppObject`\
[out] The [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md) this alias represents.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## See also
- [IDebugAlias](../../../extensibility/debugger/reference/idebugalias.md)
- [IDebugObject2](../../../extensibility/debugger/reference/idebugobject2.md)
