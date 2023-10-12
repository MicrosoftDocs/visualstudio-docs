---
description: "Retrieves the name of the table."
title: "IDiaTable::get_name"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaTable::get_name method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
---
# IDiaTable::get_name

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Retrieves the name of the table.

## Syntax

```C++
HRESULT get_name ( 
   BSTR* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the name of the table.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaTable](../../debugger/debug-interface-access/idiatable.md)
