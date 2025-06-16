---
description: "Moves the document context by a given number of statements or lines."
title: IDebugDocumentContext2::Seek
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugDocumentContext2::Seek
helpviewer_keywords:
- IDebugDocumentContext2::Seek
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugDocumentContext2::Seek

Moves the document context by a given number of statements or lines.

## Syntax

```cpp
HRESULT Seek( 
   int                      nCount,
   IDebugDocumentContext2** ppDocContext
);
```

```cpp
int Seek( 
   int                        nCount,
   out IDebugDocumentContext2 ppDocContext
);
```

## Parameters
`nCount`\
[in] The number of statements or lines to move ahead, depending on the document context.

`ppDocContext`\
[out] Returns a new [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) object with the new position.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)
