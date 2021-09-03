---
description: "Retrieves a cyclic redundancy check (CRC) calculated from the bytes of the source code."
title: "IDiaInjectedSource::get_crc | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInjectedSource::get_crc method"
ms.assetid: 2ecdda93-950e-40d6-b79b-4ae3c55b6cfc
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaInjectedSource::get_crc
Retrieves a cyclic redundancy check (CRC) calculated from the bytes of the source code.

## Syntax

```C++
HRESULT get_crc ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the CRC calculated from the bytes of the source code.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)
