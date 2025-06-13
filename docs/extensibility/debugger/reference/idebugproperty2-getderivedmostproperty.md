---
description: "Gets the derived-most property of a property."
title: IDebugProperty2::GetDerivedMostProperty
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty2::GetDerivedMostProperty
helpviewer_keywords:
- IDebugProperty2::GetDerivedMostProperty
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProperty2::GetDerivedMostProperty

Gets the derived-most property of a property.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetDerivedMostProperty ( 
   out IDebugProperty2 ppDerivedMost
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetDerivedMostProperty ( 
   IDebugProperty2** ppDerivedMost
);
```
---

## Parameters
`ppDerivedMost`\
[out] Returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object that represents the derived-most property.

## Return Value
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETDERIVEDMOST_NO_DERIVED_MOST` if there is no derived-most property to retrieve.

## Remarks
 For example, if this property describes an object that implements `ClassRoot` but which is actually an instantiation of `ClassDerived` that is derived from `ClassRoot`, then this method returns an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) object describing the `ClassDerived` object.

## See also
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
