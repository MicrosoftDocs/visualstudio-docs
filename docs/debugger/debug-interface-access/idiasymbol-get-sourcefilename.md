---
description: "Retrieves the file name of the compiland source file."
title: "IDiaSymbol::get_sourceFileName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_sourceFileName method"
ms.assetid: 0f5dce88-829e-4df3-8acd-8d71076ad167
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::get_sourceFileName
Retrieves the file name of the compiland source file.

## Syntax

```C++
HRESULT get_sourceFileName ( 
   BSTR* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the file name of the compiland source file.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
