---
description: "Determines if this object is read-only."
title: IDebugObject::IsReadOnly | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject::IsReadOnly
helpviewer_keywords:
- IDebugObject::IsReadOnly method
ms.assetid: c460f772-d08a-4b36-81f3-dff6a51a93fd
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
# IDebugObject::IsReadOnly
Determines if this object is read-only.

## Syntax

```cpp
HRESULT IsReadOnly( 
   BOOL* pfIsReadOnly
);
```

```csharp
int IsReadOnly(
   out int pfIsReadOnly
);
```

## Parameters
`pfIsReadOnly`\
[out] Returns non-zero (`TRUE`) if this object is read-only; otherwise, returns zero (`FALSE`).

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 A read-only object cannot have its value changed after it is created.

## See also
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
