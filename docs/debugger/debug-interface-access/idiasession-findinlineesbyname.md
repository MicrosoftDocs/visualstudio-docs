---
description: "Retrieves an enumeration that allows a client to iterate through the line number information of all inlined functions that match a specified name."
title: "IDiaSession::findInlineesByName | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: 9860336d-f703-4ecb-bfc4-3f5beb175a76
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSession::findInlineesByName
Retrieves an enumeration that allows a client to iterate through the line number information of all inlined functions that match a specified name.

## Syntax

```C++
HRESULT findInlineesByName ( 
   LPCOLESTR             name,
   DWORD                 option,
   IDiaEnumLineNumbers** ppResult
);
```

#### Parameters
 `name`

[in] Specifies the name to use for comparison.

 `option`

[in] Specifies the comparison options applied to name searching. Values from the [NameSearchOptions Enumeration](../../debugger/debug-interface-access/namesearchoptions.md) enumeration can be used alone or in combination.

 `ppResult`

[out] Returns an [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md) object that contains a list of the line numbers that were retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)
- [IDiaEnumLineNumbers](../../debugger/debug-interface-access/idiaenumlinenumbers.md)
