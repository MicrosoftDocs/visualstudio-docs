---
description: "Describes the line and column location in the given text."
title: TEXT_POSITION
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- TEXT_POSITION
helpviewer_keywords:
- TEXT_POSITION structure
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# TEXT_POSITION

Describes the line and column location in the given text.

## Syntax

### [C#](#tab/csharp)
```csharp
public struct TEXT_POSITION { 
   public uint dwLine;
   public uint dwColumn;
};
```
### [C++](#tab/cpp)
```cpp
typedef struct _tagTEXT_POSITION { 
   DWORD dwLine;
   DWORD dwColumn;
} TEXT_POSITION;
```
---

## Members

`dwLine`\
Index of line in source file.

`dwColumn`\
Character offset into line.

## Remarks

This structure is used in the [CONTEXT_INFO](../../../extensibility/debugger/reference/context-info.md) and [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md) structures.

This structure is filled in by a call to the following methods:

- [GetStatementRange](../../../extensibility/debugger/reference/idebugdocumentcontext2-getstatementrange.md)

- [GetSourceRange](../../../extensibility/debugger/reference/idebugdocumentcontext2-getsourcerange.md)

- [GetRange](../../../extensibility/debugger/reference/idebugdocumentposition2-getrange.md)

- [GetOffset](../../../extensibility/debugger/reference/idebugfunctionposition2-getoffset.md)

This structure is passed as a parameter to the following methods:

- [GetText](../../../extensibility/debugger/reference/idebugdocumenttext2-gettext.md)

- [onInsertText](../../../extensibility/debugger/reference/idebugdocumenttextevents2-oninserttext.md)

- [onRemoveText](../../../extensibility/debugger/reference/idebugdocumenttextevents2-onremovetext.md)

- [onReplaceText](../../../extensibility/debugger/reference/idebugdocumenttextevents2-onreplacetext.md)

- [onUpdateTextAttributes](../../../extensibility/debugger/reference/idebugdocumenttextevents2-onupdatetextattributes.md)

## Requirements

 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also

- [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)
- [GetStatementRange](../../../extensibility/debugger/reference/idebugdocumentcontext2-getstatementrange.md)
- [GetSourceRange](../../../extensibility/debugger/reference/idebugdocumentcontext2-getsourcerange.md)
- [GetRange](../../../extensibility/debugger/reference/idebugdocumentposition2-getrange.md)
- [GetOffset](../../../extensibility/debugger/reference/idebugfunctionposition2-getoffset.md)
- [GetText](../../../extensibility/debugger/reference/idebugdocumenttext2-gettext.md)
- [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)
- [CONTEXT_INFO](../../../extensibility/debugger/reference/context-info.md)
- [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md)
