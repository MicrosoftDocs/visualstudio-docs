---
title: "CONTEXT_COMPARE | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "CONTEXT_COMPARE"
helpviewer_keywords:
  - "CONTEXT_COMPARE enumeration"
ms.assetid: 701ed61c-a320-4c20-a335-0b840024abc0
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# CONTEXT_COMPARE
Specifies the criteria for comparing two memory contexts.

## Syntax

```cpp
enum enum_CONTEXT_COMPARE {
    CONTEXT_EQUAL                 = 0x0001,
    CONTEXT_LESS_THAN             = 0x0002,
    CONTEXT_GREATER_THAN          = 0x0003,
    CONTEXT_LESS_THAN_OR_EQUAL    = 0x0004,
    CONTEXT_GREATER_THAN_OR_EQUAL = 0x0005,
    CONTEXT_SAME_SCOPE            = 0x0006,
    CONTEXT_SAME_FUNCTION         = 0x0007,
    CONTEXT_SAME_MODULE           = 0x0008,
    CONTEXT_SAME_PROCESS          = 0x0009
};
typedef DWORD CONTEXT_COMPARE;
```

```csharp
public enum enum_CONTEXT_COMPARE {
    CONTEXT_EQUAL                 = 0x0001,
    CONTEXT_LESS_THAN             = 0x0002,
    CONTEXT_GREATER_THAN          = 0x0003,
    CONTEXT_LESS_THAN_OR_EQUAL    = 0x0004,
    CONTEXT_GREATER_THAN_OR_EQUAL = 0x0005,
    CONTEXT_SAME_SCOPE            = 0x0006,
    CONTEXT_SAME_FUNCTION         = 0x0007,
    CONTEXT_SAME_MODULE           = 0x0008,
    CONTEXT_SAME_PROCESS          = 0x0009
};
```

## Fields
`CONTEXT_EQUAL`\
Find the first memory context in the list that is equal to the target memory context.

`CONTEXT_LESS_THAN`\
Find the first memory context in the list that is less than the target memory context.

`CONTEXT_GREATER_THAN`\
Find the first memory context in the list that is greater than the target memory context.

`CONTEXT_LESS_THAN_OR_EQUAL`\
Find the first memory context in the list that is less than or equal to the target memory context.

`CONTEXT_GREATER_THAN_OR_EQUAL`\
Find the first memory context in the list that is greater than or equal to the target memory context.

`CONTEXT_SAME_SCOPE`\
Find the first memory context in the list that is in the same scope as the target memory context.

`CONTEXT_SAME_FUNCTION`\
Find the first memory context in the list that is in the same function as the target memory scope.

`CONTEXT_SAME_MODULE`\
Find the first memory context in the list that is in the same module as the target memory context.

`CONTEXT_SAME_PROCESS`\
Find the first memory context in the list that is in the same process as the target memory context.

## Remarks
Passed as an argument to the [Compare](../../../extensibility/debugger/reference/idebugmemorycontext2-compare.md) method.

These values are used to find the first memory context in a list that satisfies the specified comparison criteria. A memory context is given a list of memory contexts to compare itself against through the `IDebugMemoryContext2::Compare` method. The first memory context in the list for which the comparison operator is `true` is then returned.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [Compare](../../../extensibility/debugger/reference/idebugmemorycontext2-compare.md)
