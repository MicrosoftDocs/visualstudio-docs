---
description: "Retrieves the source file and line number that indicate where a specified user-defined type is defined."
title: "IDiaSymbol::getSrcLineOnTypeDefn | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: ad554d18-9988-4b64-ad71-e7594c266e94
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::getSrcLineOnTypeDefn
Retrieves the source file and line number that indicate where a specified user-defined type is defined.

## Syntax

```C++
HRESULT getSrcLineOnTypeDefn(
   IDiaLineNumber **ppResult);
```

#### Parameters
 `ppResult`

[out] A `IDiaLineNumber` object that contains the source file and line number where the user-defined.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
