---
description: "Retrieves a reference to the source file."
title: "IDiaLineNumber::get_sourceFile | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_sourceFile method"
ms.assetid: 86fc4411-375e-4b99-8f96-4da2c3f68190
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaLineNumber::get_sourceFile
Retrieves a reference to the source file.

## Syntax

```C++
HRESULT get_sourceFile ( 
   IDiaSourceFile** pRetVal
);
```

#### Parameters
 `pRetVal`

[out] Returns an [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md) object that represents the source file.

## Return Value
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.

## See also
- [IDiaLineNumber](../../debugger/debug-interface-access/idialinenumber.md)
- [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)
