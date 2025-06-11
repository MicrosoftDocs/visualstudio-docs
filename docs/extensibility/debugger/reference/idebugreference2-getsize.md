---
description: "Gets the size, in bytes, of the value of the reference."
title: IDebugReference2::GetSize
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugReference2::GetSize
helpviewer_keywords:
- IDebugReference2::GetSize
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugReference2::GetSize

Gets the size, in bytes, of the value of the reference. Reserved for future use.

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
[out] Returns the size, in bytes, of the value of the reference.

## Return Value
 Always returns `E_NOTIMPL`.

## See also
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
