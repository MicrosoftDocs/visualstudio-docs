---
title: "PROVIDER_PROCESS_DATA | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "PROVIDER_PROCESS_DATA"
helpviewer_keywords:
  - "PROVIDER_PROCESS_DATA structure"
ms.assetid: ec2362ed-4a0c-4a09-9d66-8ff04e4f41ee
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# PROVIDER_PROCESS_DATA
This structure provides information about processes running on a machine.

## Syntax

```cpp
typedef struct tagPROVIDER_PROCESS_DATA {
   PROVIDER_FIELDS    Fields;
   PROGRAM_NODE_ARRAY ProgramNodes;
   BOOL               fIsDebuggerPresent;
} PROVIDER_PROCESS_DATA;
```

```csharp
public struct PROVIDER_PROCESS_DATA {
   public uint               Fields;
   public PROGRAM_NODE_ARRAY ProgramNodes;
   public int                fIsDebuggerPresent;
}
```

## Members
 `Fields`\
 A combination of flags from the [PROVIDER_FIELDS](../../../extensibility/debugger/reference/provider-fields.md) enumeration, indicating which fields are filled in.

 `ProgramNodes`\
 A [PROGRAM_NODE_ARRAY](../../../extensibility/debugger/reference/program-node-array.md) structure that contains an array of program nodes.

 `fIsDebuggerPresent`\
 Nonzero (`TRUE`) if the [!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)] debugger is running, zero (`FALSE`) if it is not.

## Remarks
 This structure is passed to the [GetProviderProcessData](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprocessdata.md) method where it is filled in.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [PROVIDER_FIELDS](../../../extensibility/debugger/reference/provider-fields.md)
- [PROGRAM_NODE_ARRAY](../../../extensibility/debugger/reference/program-node-array.md)
- [GetProviderProcessData](../../../extensibility/debugger/reference/idebugprogramprovider2-getproviderprocessdata.md)