---
title: "IDiaSession::get_globalScope | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::get_globalScope method"
ms.assetid: 75d128a8-3dce-40ed-b392-de3fdda041b7
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSession::get_globalScope
Retrieves a reference to the global scope.

## Syntax

```C++
HRESULT get_globalScope ( 
   IDiaSymbol** pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object that represents the global scope.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [Exe](../../debugger/debug-interface-access/exe.md)
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)