---
description: "Returns an interface that represents the managed object."
title: IDebugManagedObject::GetManagedObject
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugManagedObject::GetManagedObject
helpviewer_keywords:
- IDebugManagedObject::GetManagedObject method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugManagedObject::GetManagedObject

Returns an interface that represents the managed object.

## Syntax

```cpp
HRESULT GetManagedObject( 
   IUnknown** ppManagedObject
);
```

```cpp
int GetManagedObject(
   out object ppManagedObject
);
```

## Parameters
`ppManagedObject`\
[out] Returns an interface that represents the managed object.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 The interface returned from this method can be queried for any interface implemented by the managed class, allowing its methods to be called.

## See also
- [IDebugManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject.md)
