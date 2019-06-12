---
title: "IDebugProgram2::GetMemoryBytes | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugProgram2::GetMemoryBytes"
helpviewer_keywords:
  - "IDebugProgram2::GetMemoryBytes"
ms.assetid: 1cdedb47-caf8-468e-aaf4-163f16afb403
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugProgram2::GetMemoryBytes
Retrieves the memory bytes occupied by the program.

## Syntax

```cpp
HRESULT GetMemoryBytes( 
   IDebugMemoryBytes2** ppMemoryBytes
);
```

```csharp
int GetMemoryBytes( 
   out IDebugMemoryBytes2 ppMemoryBytes
);
```

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