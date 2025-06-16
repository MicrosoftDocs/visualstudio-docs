---
description: "Sets the reference value of this object."
title: IDebugObject::SetReferenceValue
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject::SetReferenceValue
helpviewer_keywords:
- IDebugObject::SetReferenceValue method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugObject::SetReferenceValue

Sets the reference value of this object.

## Syntax

### [C#](#tab/csharp)
```csharp
int SetReferenceValue(
   [In] IDebugObject pObject
);
```
### [C++](#tab/cpp)
```cpp
HRESULT SetReferenceValue( 
   IDebugObject* pObject
);
```
---

## Parameters
`pObject`\
[in] An [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object representing the new reference value.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 This method makes this [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object a reference to the value of the object given in the `pObject` parameter, throwing away any previous reference. Note that this `IDebugObject` object must already be a reference type.

## See also
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
- [GetValue](../../../extensibility/debugger/reference/idebugobject-getvalue.md)
