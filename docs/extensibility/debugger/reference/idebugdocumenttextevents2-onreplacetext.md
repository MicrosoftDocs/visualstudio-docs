---
description: "Notifies the debug package that text has been replaced in the document."
title: IDebugDocumentTextEvents2::onReplaceText
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentTextEvents2::OnReplaceText
helpviewer_keywords:
- IDebugDocumentTextEvents2::onReplaceText
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentTextEvents2::onReplaceText

Notifies the debug package that text has been replaced in the document.

## Syntax

### [C#](#tab/csharp)
```csharp
int onReplaceText( 
   enum_TEXT_POSITION pos,
   uint               dwNumToReplace
);
```
### [C++](#tab/cpp)
```cpp
HRESULT onReplaceText( 
   TEXT_POSITION pos,
   DWORD         dwNumToReplace
);
```
---

## Parameters
`pos`\
[in] A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) indicates where the text was replaced.

`dwNumToReplace`\
[in] Specifies the number of characters of text that were replaced.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)
- [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)
