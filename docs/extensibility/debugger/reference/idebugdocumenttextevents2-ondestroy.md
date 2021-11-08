---
description: "Indicates that the entire document has been destroyed."
title: IDebugDocumentTextEvents2::onDestroy | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentTextEvents2::OnDestroy
helpviewer_keywords:
- IDebugDocumentTextEvents2::onDestroy
ms.assetid: 60e4689c-c899-4c14-9d18-96393b741e1f
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
# IDebugDocumentTextEvents2::onDestroy
Indicates that the entire document has been destroyed.

## Syntax

```cpp
HRESULT onDestroy( 
   void 
);
```

```csharp
int onDestroy();
```

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugDocumentTextEvents2](../../../extensibility/debugger/reference/idebugdocumenttextevents2.md)
