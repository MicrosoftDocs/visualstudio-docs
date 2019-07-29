---
title: "IDebugDocumentTextEvents2::onUpdateTextAttributes | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugDocumentTextEvents2::OnUpdateTextAttributes"
helpviewer_keywords:
  - "IDebugDocumentTextEvents2::onUpdateTextAttributes"
ms.assetid: eb68d69a-1ad9-4ce4-84e1-40979ef16634
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugDocumentTextEvents2::onUpdateTextAttributes
Notifies the debug package that text attributes have been updated in the document.

## Syntax

```cpp
HRESULT onUpdateTextAttributes( 
   TEXT_POSITION pos,
   DWORD         dwNumToUpdate
);
```

```csharp
int onUpdateTextAttributes( 
   enum_TEXT_POSITION pos,
   uint               dwNumToUpdate
);
```

## Parameters
`pos`\
[in] A [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) structure that indicates where the text attributes were updated.

`dwNumToUpdate`\
[in] Specifies the number of characters of text that were updated.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)
- [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)