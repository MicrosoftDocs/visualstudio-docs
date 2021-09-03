---
description: "Gets the document to activate."
title: IDebugActivateDocumentEvent2::GetDocument | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugActivateDocumentEvent2::GetDocument
helpviewer_keywords:
- GetDocument method
- IDebugActivateDocumentEvent2::GetDocument method
ms.assetid: b3c32f1b-f3de-409d-920d-ba7b3fa84fcd
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
# IDebugActivateDocumentEvent2::GetDocument
Gets the document to activate.

## Syntax

```cpp
HRESULT GetDocument ( 
   IDebugDocument2** ppDoc
);
```

```csharp
int GetDocument ( 
   out IDebugDocument2 ppDoc
);
```

## Parameters
`ppDoc`\
[out] Returns an [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) object that represents the document to be activated.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugActivateDocumentEvent2](../../../extensibility/debugger/reference/idebugactivatedocumentevent2.md)
- [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)
