---
description: "Retrieves the memory bytes occupied by the program."
title: IDebugProgram2::GetMemoryBytes
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::GetMemoryBytes
helpviewer_keywords:
- IDebugProgram2::GetMemoryBytes
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::GetMemoryBytes

Retrieves the memory bytes occupied by the program.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetMemoryBytes( 
   out IDebugMemoryBytes2 ppMemoryBytes
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetMemoryBytes( 
   IDebugMemoryBytes2** ppMemoryBytes
);
```
---

## Parameters
`ppMemoryBytes`\
[out] Returns an [IDebugMemoryBytes2](../../../extensibility/debugger/reference/idebugmemorybytes2.md) object that represents the memory bytes of the program.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The memory bytes as represented by the [IDebugMemoryBytes2](../../../extensibility/debugger/reference/idebugmemorybytes2.md) object is for the program's image in memory and not any memory that was allocated when the program was executed.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
- [IDebugMemoryBytes2](../../../extensibility/debugger/reference/idebugmemorybytes2.md)
