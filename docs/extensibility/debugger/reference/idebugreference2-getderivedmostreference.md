---
description: "Gets the derived-most reference of a reference."
title: IDebugReference2::GetDerivedMostReference | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugReference2::GetDerivedMostReference
helpviewer_keywords:
- IDebugReference2::GetDerivedMostReference
ms.assetid: 07253b74-7d39-48e0-8e85-ac8dfd919f6e
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
# IDebugReference2::GetDerivedMostReference
Gets the derived-most reference of a reference. Reserved for future use.

## Syntax

```cpp
HRESULT GetDerivedMostReference( 
   IDebugReference2** ppDerivedMost
);
```

```csharp
int GetDerivedMostReference( 
   out IDebugReference2 ppDerivedMost
);
```

## Parameters
`ppDerivedMost`\
[out] Returns an [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) object that represents the derived-most property.

## Return Value
 Always returns `E_NOTIMPL`.

## Remarks
 For example, if this property describes an object that implements `ClassRoot` but which is actually an instantiation of `ClassDerived` that is derived from `ClassRoot`, then this method returns an [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) object representing a reference to the `ClassDerived` object.

## See also
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
