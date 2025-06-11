---
description: "Creates a copy of the managed object in the address space of the debug engine."
title: IDebugObject::GetManagedDebugObject
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject::GetManagedDebugObject
helpviewer_keywords:
- IDebugObject::GetManagedDebugObject method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugObject::GetManagedDebugObject

Creates a copy of the managed object in the address space of the debug engine.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetManagedDebugObject(
   out IDebugManagedObject ppObject
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetManagedDebugObject( 
   IDebugManagedObject** ppObject
);
```
---

## Parameters
`ppObject`\
[out] Returns an [IDebugManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject.md) object representing the newly created managed object.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code. Returns E_FAIL if this [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) does not represent a managed value class instance.

## Remarks
 This [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object must represent a managed value class instance, such as a `System.Decimal` instance. By having a local copy, the overhead of calling [Evaluate](../../../extensibility/debugger/reference/idebugfunctionobject-evaluate.md) is eliminated.

## See also
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
- [IDebugManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject.md)
