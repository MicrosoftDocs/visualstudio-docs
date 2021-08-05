---
description: "Gets the class identifier of the document."
title: IDebugDocument2::GetDocumentClassID | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocument2::GetDocumentClassID
helpviewer_keywords:
- IDebugDocument2::GetDocumentClassID
ms.assetid: 111c2b85-ebfa-487f-b896-2ec4a3eac4d1
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
# IDebugDocument2::GetDocumentClassID
Gets the class identifier of the document.

## Syntax

```cpp
HRESULT GetDocumentClassID( 
   CLSID* pclsid
);
```

```csharp
int GetDocumentClassID( 
   out Guid pclsid
);
```

## Parameters
`pclsid`
[out] Returns a GUID that is the class ID of the document.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The class GUID can be used to instantiate individual classes each of which represents a document.

## See also
- [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)
