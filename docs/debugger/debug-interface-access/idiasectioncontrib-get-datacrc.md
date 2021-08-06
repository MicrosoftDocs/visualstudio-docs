---
description: "Retrieves the cyclic redundancy check (CRC) of the data in the section."
title: "IDiaSectionContrib::get_dataCrc | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_dataCrc method"
ms.assetid: 33b7488f-dc9c-47b3-b08c-737e0eb1bf7d
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSectionContrib::get_dataCrc
Retrieves the cyclic redundancy check (CRC) of the data in the section.

## Syntax

```C++
HRESULT get_dataCrc ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the CRC of the data in the section.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
