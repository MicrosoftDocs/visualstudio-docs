---
description: Retrieves a source file by source file identifier.
title: "IDiaSession::findFileById"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findFileById method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::findFileById

Retrieves a source file by source file identifier.

## Syntax

```C++
HRESULT findFileById ( 
   DWORD            uniqueId,
   IDiaSourceFile** ppResult
);
```

#### Parameters
 `uniqueId`

[in] Specifies the source file identifier.

 `ppResult`

[out] Returns an [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md) object that represents the source file retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 The source file identifier is a unique value used internally to the DIA SDK to make all source files unique. This method is typically used internally to the DIA SDK.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSession::findFile](../../debugger/debug-interface-access/idiasession-findfile.md)
- [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)
