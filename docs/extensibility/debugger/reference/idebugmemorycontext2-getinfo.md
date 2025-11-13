---
description: "Retrieves a CONTEXT_INFO structure that describes the context."
title: IDebugMemoryContext2::GetInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugMemoryContext2::GetInfo
helpviewer_keywords:
- GetInfo method
- IDebugMemoryContext2::GetInfo method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugMemoryContext2::GetInfo

Retrieves a [CONTEXT_INFO](../../../extensibility/debugger/reference/context-info.md) structure that describes the context.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetInfo(
   enum_CONTEXT_INFO_FIELDS dwFields,
   CONTEXT_INFO[]           pinfo
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetInfo( 
   CONTEXT_INFO_FIELDS dwFields,
   CONTEXT_INFO*       pInfo
);
```
---

## Parameters
`dwFields`\
[in] A combination of flags from the [CONTEXT_INFO_FIELDS](../../../extensibility/debugger/reference/context-info-fields.md) enumeration that indicate which fields of the [CONTEXT_INFO](../../../extensibility/debugger/reference/context-info.md) structure are to be fill in.

`pInfo`\
[in, out] The `CONTEXT_INFO` structure that is filled in.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugMemoryContext2](../../../extensibility/debugger/reference/idebugmemorycontext2.md)
- [CONTEXT_INFO_FIELDS](../../../extensibility/debugger/reference/context-info-fields.md)
- [CONTEXT_INFO](../../../extensibility/debugger/reference/context-info.md)
