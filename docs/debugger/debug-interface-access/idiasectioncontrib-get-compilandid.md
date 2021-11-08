---
description: "Retrieves the compiland identifier for the section."
title: "IDiaSectionContrib::get_compilandId | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSectionContrib::get_compilandId method"
ms.assetid: 71ef2e63-d095-42b6-88d8-626e3129f0d9
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSectionContrib::get_compilandId
Retrieves the compiland identifier for the section.

## Syntax

```C++
HRESULT get_compilandId ( 
   DWORD* pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns the compiland identifier for the section.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaSectionContrib](../../debugger/debug-interface-access/idiasectioncontrib.md)
