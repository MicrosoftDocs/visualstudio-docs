---
title: "IDiaLineNumber::get_compilandId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_compilandId method"
ms.assetid: 2cd6f551-8091-47c7-803f-3f79a766a211
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaLineNumber::get_compilandId
Retrieves a unique identifier for the compiland that contributed this line.

## Syntax

```C++
HRESULT get_compilandId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns `DWORD` that contains the unique identifier for the compiland that contributed this line.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)