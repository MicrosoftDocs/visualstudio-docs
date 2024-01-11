---
description: "Retrieves the name of a debug data stream."
title: "IDiaEnumDebugStreamData::get_name"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumDebugStreamData::get_Name method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.subservice: debug-diagnostics
---
# IDiaEnumDebugStreamData::get_name

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
Retrieves the name of a debug data stream.

## Syntax

```C++
HRESULT get_Name ( 
   BSTR * pRetVal
)
```

#### Parameters
 pRetVal

[out] Returns the name of a debug data stream.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaEnumDebugStreamData](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md)
