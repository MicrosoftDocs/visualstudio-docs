---
description: "Indicates that the entire document has been destroyed."
title: IDebugDocumentTextEvents2::onDestroy
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentTextEvents2::OnDestroy
helpviewer_keywords:
- IDebugDocumentTextEvents2::onDestroy
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentTextEvents2::onDestroy

Indicates that the entire document has been destroyed.

## Syntax

### [C#](#tab/csharp)
```csharp
int onDestroy();
```
### [C++](#tab/cpp)
```cpp
HRESULT onDestroy( 
   void 
);
```
---

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)
