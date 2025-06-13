---
description: "Gets the field to which the custom attribute is attached."
title: IDebugCustomAttribute::GetParentField
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomAttribute::GetParentField
helpviewer_keywords:
- IDebugCustomAttribute::GetParentField
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugCustomAttribute::GetParentField

Gets the field to which the custom attribute is attached.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetParentField(
   out IDebugField ppField
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetParentField( 
   IDebugField** ppField
);
```
---

## Parameters
`ppField`\
[out] Returns the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object that represents the field to which the custom attribute is attached.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 Call the [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md) method on the returned [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object to determine what kind of field the parent is.

## See also
- [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
