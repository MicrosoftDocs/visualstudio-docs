---
description: "Notifies receiver of the event that the document attributes have been updated."
title: IDebugDocumentTextEvents2::onUpdateDocumentAttributes
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentTextEvents2::OnUpdateDocumentAttributes
helpviewer_keywords:
- IDebugDocumentTextEvents2::onUpdateDocumentAttributes
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentTextEvents2::onUpdateDocumentAttributes

Notifies receiver of the event that the document attributes have been updated.

## Syntax

### [C#](#tab/csharp)
```csharp
int onUpdateDocumentAttributes( 
   enum_TEXT_DOC_ATTR_2 textdocattr
);
```
### [C++](#tab/cpp)
```cpp
HRESULT onUpdateDocumentAttributes( 
   TEXT_DOC_ATTR_2 textdocattr
);
```
---

## Parameters
`textdocattr`\
[in] A combination of flags from the [TEXT_DOC_ATTR_2](../../../extensibility/debugger/reference/text-doc-attr-2.md) enumeration that specifies the updated attributes of the document.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)
- [TEXT_DOC_ATTR_2](../../../extensibility/debugger/reference/text-doc-attr-2.md)
