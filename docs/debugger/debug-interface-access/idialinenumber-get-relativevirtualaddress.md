---
description: "Retrieves the relative virtual address (RVA) of the block."
title: "IDiaLineNumber::get_relativeVirtualAddress | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_relativeVirtualAddress method"
ms.assetid: ba8142e3-5c77-43cc-bd33-c077dcc18cab
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaLineNumber::get_relativeVirtualAddress
Retrieves the relative virtual address (RVA) of the block.

## Syntax

```C++
HRESULT get_relativeVirtualAddress ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the image-relative virtual address of the block.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
