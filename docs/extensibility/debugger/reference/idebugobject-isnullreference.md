---
title: "IDebugObject::IsNullReference | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugObject::IsNullReference"
helpviewer_keywords:
  - "IDebugObject::IsNullReference method"
ms.assetid: 6dbfcdb0-954f-4486-8fac-7ea8d003e3a9
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugObject::IsNullReference
Tests whether this object is a null reference.

## Syntax

```cpp
HRESULT IsNullReference( 
   BOOL* pfIsNull
);
```

```csharp
int IsNullReference(
   out int pfIsNull
);
```

## Parameters
`pfIsNull`\
[out] Returns non-zero (`TRUE`) if this object is a null reference; otherwise, returns zero (`FALSE`).

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 A null reference means an empty object or an object that has not been assigned to.

## See also
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)