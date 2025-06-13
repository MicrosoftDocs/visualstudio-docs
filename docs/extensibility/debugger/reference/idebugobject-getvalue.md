---
description: "Gets the value of the object as a consecutive series of bytes."
title: IDebugObject::GetValue
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugObject::GetValue
helpviewer_keywords:
- IDebugObject::GetValue method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugObject::GetValue

Gets the value of the object as a consecutive series of bytes.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetValue(
   ref byte[] pValue,
   uint nSize
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetValue( 
   BYTE* pValue,
   UINT  nSize
);
```
---

## Parameters
`pValue`\
[in, out] An array that is filled in with a consecutive series of bytes representing the value of the object.

`nSize`\
[in] The maximum number of bytes to fetch.

## Return Value
 If successful, returns S_OK; otherwise, returns an error code.

## Remarks
 Get the total number of value bytes that can be fetched by calling the [GetSize](../../../extensibility/debugger/reference/idebugobject-getsize.md) method.

## See also
- [IDebugObject](../../../extensibility/debugger/reference/idebugobject.md)
