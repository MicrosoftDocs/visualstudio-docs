---
description: "Notifies the debug package that text has been inserted into the document."
title: IDebugDocumentTextEvents2::onInsertText | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentTextEvents2::OnInsertText
helpviewer_keywords:
- IDebugDocumentTextEvents2::onInsertText
ms.assetid: 6040181f-7288-4a42-953c-d23f74200431
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentTextEvents2::onInsertText
Notifies the debug package that text has been inserted into the document.

## Syntax

```cpp
HRESULT onInsert( 
   TEXT_POSITION pos,
   DWORD         dwNumToInsert
);
```

```csharp
int onInsert( 
   enum_TEXT_POSITION pos,
   uint               dwNumToInsert
);
```

## Parameters
`pos`\
[in] A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure that indicates where the text was inserted.

`dwNumToInsert`\
[in] Specifies the number of characters of text that were inserted.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)
- [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)
