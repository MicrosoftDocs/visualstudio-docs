---
description: "Retrieves a cyclic redundancy check (CRC) calculated from the bytes of the source code."
title: "IDiaInjectedSource::get_crc"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInjectedSource::get_crc method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
---
# IDiaInjectedSource::get_crc

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
