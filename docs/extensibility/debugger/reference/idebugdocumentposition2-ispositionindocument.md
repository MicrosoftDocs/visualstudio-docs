---
description: "Determines if the document position is contained in the given document."
title: IDebugDocumentPosition2::IsPositionInDocument | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentPosition2::IsPositionInDocument
helpviewer_keywords:
- IDebugDocumentPosition2::IsPositionInDocument
ms.assetid: d5cf57cb-b93b-4e1d-bec9-185f4fe8668d
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentPosition2::IsPositionInDocument
Determines if the document position is contained in the given document.

## Syntax

```cpp
HRESULT IsPositionInDocument( 
   IDebugDocument2* pDoc
);
```

```csharp
int IsPositionInDocument( 
   IDebugDocument2 pDoc
);
```

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
