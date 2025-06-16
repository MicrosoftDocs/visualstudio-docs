---
description: "Gets the containing document."
title: IDebugDocumentPosition2::GetDocument
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentPosition2::GetDocument
helpviewer_keywords:
- IDebugDocumentPosition2::GetDocument
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentPosition2::GetDocument

Gets the containing document.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetDocument( 
   out IDebugDocument2 ppDoc
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetDocument( 
   IDebugDocument2** ppDoc
);
```
---

## Parameters
`ppDoc`\
[out] Returns an [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) object that represents the document containing this position.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md)
- [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)
