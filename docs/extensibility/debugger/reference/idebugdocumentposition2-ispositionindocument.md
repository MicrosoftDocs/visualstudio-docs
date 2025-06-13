---
description: "Determines if the document position is contained in the given document."
title: IDebugDocumentPosition2::IsPositionInDocument
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentPosition2::IsPositionInDocument
helpviewer_keywords:
- IDebugDocumentPosition2::IsPositionInDocument
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentPosition2::IsPositionInDocument

Determines if the document position is contained in the given document.

## Syntax

### [C#](#tab/csharp)
```csharp
int IsPositionInDocument( 
   IDebugDocument2 pDoc
);
```
### [C++](#tab/cpp)
```cpp
HRESULT IsPositionInDocument( 
   IDebugDocument2* pDoc
);
```
---

## Parameters
`pDoc`\
[in] The [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) object that represents the containing document candidate.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is used primarily in setting breakpoints in [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) interfaces. As documents are loaded, the breakpoint position is called to determine if the document contains this position.

## See also
- [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md)
- [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)
