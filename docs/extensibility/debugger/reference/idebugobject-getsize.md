---
description: "Gets the size of the object in bytes."
title: IDebugObject::GetSize
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject::GetSize
helpviewer_keywords:
- IDebugObject::GetSize method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugObject::GetSize

Gets the size of the object in bytes.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetSize(
   out uint pnSize
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetSize( 
   UINT* pnSize
);
```
---

## Parameters
`pnSize`\
[out] Returns the size in bytes.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 Use the [GetValue](../../../extensibility/debugger/reference/idebugobject-getvalue.md) method to retrieve the value as a sequence of bytes.

## See also
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
- [GetValue](../../../extensibility/debugger/reference/idebugobject-getvalue.md)
