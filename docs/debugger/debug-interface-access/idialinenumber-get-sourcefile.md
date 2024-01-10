---
description: "Retrieves a reference to the source file."
title: "IDiaLineNumber::get_sourceFile"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaLineNumber::get_sourceFile method"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.subservice: vs-ide-debug
---
# IDiaLineNumber::get_sourceFile

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
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
