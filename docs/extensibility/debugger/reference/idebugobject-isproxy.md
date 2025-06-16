---
description: "Determines if the object is a transparent proxy."
title: IDebugObject::IsProxy
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugObject::IsProxy
- IsProxy
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugObject::IsProxy

Determines if the object is a transparent proxy.

## Syntax

### [C#](#tab/csharp)
```csharp
int IsProxy (
   out bool pfIsProxy
);
```
### [C++](#tab/cpp)
```cpp
HRESULT IsProxy (
   BOOL* pfIsProxy
);
```
---

## Parameters
`pfIsProxy`\
[out] `TRUE` if the object is a transparent proxy; otherwise, `FALSE`.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is implemented by the default C++ debug engine.

## See also
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
