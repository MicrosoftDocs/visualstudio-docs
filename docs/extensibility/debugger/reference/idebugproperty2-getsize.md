---
description: "Gets the size, in bytes, of the property value."
title: IDebugProperty2::GetSize
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty2::GetSize
helpviewer_keywords:
- IDebugProperty2::GetSize
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProperty2::GetSize

Gets the size, in bytes, of the property value.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetSize ( 
   out uint pdwSize
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetSize ( 
   DWORD* pdwSize
);
```
---

## Parameters
`pdwSize`\
[out] Returns the size, in bytes, of the property value.

## Return Value
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETSIZE_NO_SIZE` if the property has no size.

## See also
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
