---
description: "Creates a string object that has the specified length."
title: IDebugFunctionObject2::CreateStringObjectWithLength
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- CreateStringObjectWithLength
- IDebugFunctionObject2::CreateStringObjectWithLength
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugFunctionObject2::CreateStringObjectWithLength

Creates a string object that has the specified length.

## Syntax

### [C#](#tab/csharp)
```csharp
int CreateStringObjectWithLength (
   string           pcstrString,
   uint             uiLength,
   out IDebugObject ppObject
);
```
### [C++](#tab/cpp)
```cpp
HRESULT CreateStringObjectWithLength (
   LPCOLESTR      pcstrString,
   UINT           uiLength,
   IDebugObject** ppObject
);
```
---

## Parameters
`pcstrString`\
[in] The string value for the string object.

`uiLength`\
[in] The length of the string in bytes.

`ppObject`\
[out] Returns an [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md) object that represents the newly created string object.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugFunctionObject2](../../../extensibility/debugger/reference/idebugfunctionobject2.md)
