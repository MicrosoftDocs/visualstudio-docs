---
description: "Gets the document that contains this document context."
title: IDebugDocumentContext2::GetDocument
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentContext2::GetDocument
helpviewer_keywords:
- IDebugDocumentContext2::GetDocument
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentContext2::GetDocument

Gets the document that contains this document context.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetDocument( 
   out IDebugDocument2 ppDocument
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetDocument( 
   IDebugDocument2** ppDocument
);
```
---

## Parameters
`ppDocument`\
[out] Returns an [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) object that represents the document that contains this document context.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is for those debug engines that supply documents directly to the IDE. Otherwise, this method should return `E_NOTIMPL`.

## See also
- [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)
- [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)
