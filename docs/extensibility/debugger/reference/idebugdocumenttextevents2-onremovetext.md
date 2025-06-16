---
description: "Notifies the debug package that text has been removed from the document."
title: IDebugDocumentTextEvents2::onRemoveText
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentTextEvents2::OnRemoveText
helpviewer_keywords:
- IDebugDocumentTextEvents2::onRemoveText
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentTextEvents2::onRemoveText

Notifies the debug package that text has been removed from the document.

## Syntax

### [C#](#tab/csharp)
```csharp
int onRemoveText( 
   enum_TEXT_POSITION pos,
   uint               dwNumToRemove
);
```
### [C++](#tab/cpp)
```cpp
HRESULT onRemoveText( 
   TEXT_POSITION pos,
   DWORD         dwNumToRemove
);
```
---

## Parameters
`pos`\
[in] A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure that indicates where the text was removed.

`dwNumToRemove`\
[in] Specifies the number of characters of text that were removed.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)
- [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)
