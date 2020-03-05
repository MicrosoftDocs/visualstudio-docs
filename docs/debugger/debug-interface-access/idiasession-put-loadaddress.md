---
title: "IDiaSession::put_loadAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::put_loadAddress method"
ms.assetid: b157b245-1ea0-4b80-8962-d8b278dbc742
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSession::put_loadAddress
Sets the load address for the executable file that corresponds to the symbols in this symbol store.

## Syntax

```C++
HRESULT put_loadAddress ( 
   ULONGLONG NewVal
);
```

#### Parameters
 `NewVal`

[in] Load address for the executable file.

## Remarks
 Symbol virtual address (VA) properties are computed using the value of this method. Virtual addresses are not calculated unless this property is set to non-zero.

> [!NOTE]
> You must call this method when you get the [IDiaSession](../../debugger/debug-interface-access/idiasession.md) object and before you start using the object if you need to use any virtual properties on symbols.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)