---
description: "Retrieves the name given to non-file source code; that is, code that was injected."
title: "IDiaInjectedSource::get_virtualFilename | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInjectedSource::get_virtualFilename method"
ms.assetid: b9977075-8fd1-4b11-bfff-d87e9f2586dc
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaInjectedSource::get_virtualFilename
Retrieves the name given to non-file source code; that is, code that was injected.

## Syntax

```C++
HRESULT get_virtualFilename ( 
   BSTR* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the name given to injected non-file source code.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaInjectedSource](../../debugger/debug-interface-access/idiainjectedsource.md)
