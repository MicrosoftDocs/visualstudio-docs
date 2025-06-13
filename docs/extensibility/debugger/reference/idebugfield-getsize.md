---
description: "This method gets the size of a field, in bytes."
title: IDebugField::GetSize
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugField::GetSize
helpviewer_keywords:
- IDebugField::GetSize method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugField::GetSize

This method gets the size of a field, in bytes.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetSize(
   out uint pdwSize
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetSize( 
   DWORD* pdwSize
);
```
---

## Parameters
`pdwSize`\
[out] Returns the size.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 All fields have a type and all types have a size. For example, a field with a type of byte has a size of 1 byte.

## See also
- [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)
