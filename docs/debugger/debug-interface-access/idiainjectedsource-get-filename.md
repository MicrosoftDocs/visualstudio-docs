---
title: "IDiaInjectedSource::get_filename | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInjectedSource::get_filename method"
ms.assetid: 20f4fc68-335a-4971-b3a6-76501f0e8b19
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaInjectedSource::get_filename
Retrieves the file name for the source.

## Syntax

```C++
HRESULT get_filename ( 
   BSTR* pRetVal
);
```

#### Parameters
 pRetVal

[out] Returns the file name for the source.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)