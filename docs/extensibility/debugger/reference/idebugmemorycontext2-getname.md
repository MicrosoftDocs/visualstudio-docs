---
description: "Retrieves the user-displayable name for this context."
title: IDebugMemoryContext2::GetName
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMemoryContext2::GetName
helpviewer_keywords:
- IDebugMemoryContext2::GetName method
- GetName method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugMemoryContext2::GetName

Retrieves the user-displayable name for this context.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetName(
   out string pbstrName
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetName( 
   BSTR* pbstrName
);
```
---

## Parameters
`pbstrName`\
[out] Returns the name of the memory context.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The name of a memory context is not normally used.

## See also
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
