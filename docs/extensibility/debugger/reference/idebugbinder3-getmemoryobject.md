---
description: "This method retrieves a memory object that represents the memory that this object is bound to."
title: IDebugBinder3::GetMemoryObject
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugBinder3::GetMemoryObject
helpviewer_keywords:
- IDebugBinder3::GetMemoryObject method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugBinder3::GetMemoryObject

This method retrieves a memory object that represents the memory that this object is bound to.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMemoryObject(
   IDebugField      pField,
   long             uConstant,
   out IDebugObject ppObject
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMemoryObject(
   IDebugField*   pField,
   UINT64         uConstant,
   IDebugObject** ppObject
);
```
---

## Parameters
`pField`\
[in] Specifies which field to get the memory object for.

`uConstant`\
[in] Represents a memory address or value for a constant value.

`ppObject`\
[out] An [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) representing the memory that this object is bound to.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugBinder3](../../../extensibility/debugger/reference/idebugbinder3.md)
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
