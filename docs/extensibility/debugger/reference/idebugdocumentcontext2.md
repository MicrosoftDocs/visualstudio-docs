---
description: "This interface represents a position in a source file document."
title: IDebugDocumentContext2
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentContext2
helpviewer_keywords:
- IDebugDocumentContext2
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugDocumentContext2

This interface represents a position in a source file document.

## Syntax

```
IDebugDocumentContext2 : IUnknown
```

## Notes for Implementers
 The debug engine (DE) implements this interface as part of its support for source code level debugging. In addition to a position in source code, this interface supplies methods for comparing contexts and navigating through a source code document.

## Notes for Callers
 Methods on several interfaces, most typically the [GetDocumentContext](../../../extensibility/debugger/reference/idebugstackframe2-getdocumentcontext.md) and [GetDocumentContext](../../../extensibility/debugger/reference/idebugcodecontext2-getdocumentcontext.md) interfaces, return this interface.

## Methods in Vtable Order
 The following table shows the methods of `IDebugDocumentContext2`.

|Method|Description|
|------------|-----------------|
|[GetDocument](../../../extensibility/debugger/reference/idebugdocumentcontext2-getdocument.md)|Gets the document that contains this document context.|
|[GetName](../../../extensibility/debugger/reference/idebugdocumentcontext2-getname.md)|Gets the displayable name of the document that contains this document context.|
|[EnumCodeContexts](../../../extensibility/debugger/reference/idebugdocumentcontext2-enumcodecontexts.md)|Retrieves a list of all code contexts associated with this document context.|
|[GetLanguageInfo](../../../extensibility/debugger/reference/idebugdocumentcontext2-getlanguageinfo.md)|Gets the language associated with this document context.|
|[GetStatementRange](../../../extensibility/debugger/reference/idebugdocumentcontext2-getstatementrange.md)|Gets the file statement range of this document context.|
|[GetSourceRange](../../../extensibility/debugger/reference/idebugdocumentcontext2-getsourcerange.md)|Gets the file source range of this document context.|
|[Compare](../../../extensibility/debugger/reference/idebugdocumentcontext2-compare.md)|Compares this document context to a given array of document contexts.|
|[Seek](../../../extensibility/debugger/reference/idebugdocumentcontext2-seek.md)|Moves the document context by a given number of statements or lines.|

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [GetDocumentContext](../../../extensibility/debugger/reference/idebugcanstopevent2-getdocumentcontext.md)
- [GetDocumentContext](../../../extensibility/debugger/reference/idebugactivatedocumentevent2-getdocumentcontext.md)
- [GetDocumentContext](../../../extensibility/debugger/reference/idebugstackframe2-getdocumentcontext.md)
- [GetDocumentContext](../../../extensibility/debugger/reference/idebugcodecontext2-getdocumentcontext.md)
