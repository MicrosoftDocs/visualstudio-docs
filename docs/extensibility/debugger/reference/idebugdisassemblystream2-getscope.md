---
description: "Gets the scope of the disassembly stream."
title: IDebugDisassemblyStream2::GetScope
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDisassemblyStream2::GetScope
helpviewer_keywords:
- IDebugDisassemblyStream2::GetScope
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDisassemblyStream2::GetScope

Gets the scope of the disassembly stream.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetScope( 
   out enum_ DISASSEMBLY_STREAM_SCOPE pdwScope
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetScope( 
   DISASSEMBLY_STREAM_SCOPE* pdwScope
);
```
---

## Parameters
`pdwScope`\
[out] Returns a value from the [DISASSEMBLY_STREAM_SCOPE](../../../extensibility/debugger/reference/disassembly-stream-scope.md) enumeration that describes the scope of this disassembly stream.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The scope of a disassembly could be a function or the whole module, for example.

## See also
- [IDebugDisassemblyStream2](../../../extensibility/debugger/reference/idebugdisassemblystream2.md)
- [DISASSEMBLY_STREAM_SCOPE](../../../extensibility/debugger/reference/disassembly-stream-scope.md)
