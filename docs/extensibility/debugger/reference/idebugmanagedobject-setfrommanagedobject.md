---
description: "Sets the value of the instance of the value class object from the instance of the value class provided as a parameter."
title: IDebugManagedObject::SetFromManagedObject
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugManagedObject::SetFromManagedObject
helpviewer_keywords:
- IDebugManagedObject::SetFromManagedObject method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugManagedObject::SetFromManagedObject

Sets the value of the instance of the value class object from the instance of the value class provided as a parameter.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetFromManagedObject(
   object pManagedObject
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetFromManagedObject( 
   IUnknown* pManagedObject
);
```
---

## Parameters
`pManagedObject`\
[in] An interface that represents the managed object containing the new value.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 This method is used to change the managed object as represented by the [IDebugManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject.md) object.

## See also
- [IDebugManagedObject](../../../extensibility/debugger/reference/idebugmanagedobject.md)
