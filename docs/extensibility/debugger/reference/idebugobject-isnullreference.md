---
description: "Tests whether this object is a null reference."
title: IDebugObject::IsNullReference
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject::IsNullReference
helpviewer_keywords:
- IDebugObject::IsNullReference method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugObject::IsNullReference

Tests whether this object is a null reference.

## Syntax

### [C#](#tab/csharp)
```csharp
int IsNullReference(
   out int pfIsNull
);
```
### [C++](#tab/cpp)
```cpp
HRESULT IsNullReference( 
   BOOL* pfIsNull
);
```
---

## Parameters
`pfIsNull`\
[out] Returns non-zero (`TRUE`) if this object is a null reference; otherwise, returns zero (`FALSE`).

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 A null reference means an empty object or an object that has not been assigned to.

## See also
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
