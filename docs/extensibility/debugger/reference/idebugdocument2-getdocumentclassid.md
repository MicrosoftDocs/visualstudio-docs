---
description: "Gets the class identifier of the document."
title: IDebugDocument2::GetDocumentClassID
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocument2::GetDocumentClassID
helpviewer_keywords:
- IDebugDocument2::GetDocumentClassID
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocument2::GetDocumentClassID

Gets the class identifier of the document.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetDocumentClassID( 
   out Guid pclsid
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetDocumentClassID( 
   CLSID* pclsid
);
```
---

## Parameters
`pclsid`
[out] Returns a GUID that is the class ID of the document.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The class GUID can be used to instantiate individual classes each of which represents a document.

## See also
- [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)
