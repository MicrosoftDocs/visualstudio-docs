---
description: Retrieves source files by compiland and name.
title: "IDiaSession::findFile"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findFile method"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaSession::findFile

Retrieves source files by compiland and name.

## Syntax

```C++
HRESULT findFile ( 
   IDiaSymbol*           pCompiland,
   LPCOLESTR             name,
   DWORD                 option,
   IDiaEnumSourceFiles** ppResult
);
```

#### Parameters
 `pCompiland`

[in] An [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object representing the compiland to be used as a context for the search. Set this parameter to `NULL` to find source files in all compilands.

 `name`

[in] Specifies the name of the source file to be retrieved. Set this parameter to `NULL` for all source files to be retrieved.

 `option`

[in] Specifies the comparison options applied to name searching. Values from the [NameSearchOptions Enumeration](../../debugger/debug-interface-access/namesearchoptions.md) enumeration can be used alone or in combination.

 `ppResult`

[out] Returns an [IDiaEnumSourceFiles](../../debugger/debug-interface-access/idiaenumsourcefiles.md) object that contains a list of the source files retrieved.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Example

```C++
IDiaEnumSourceFiles* pEnum;
pSession->findFile( NULL, L"sourcefile.cpp", nsFNameExt, &pEnum );
```

## See also
- [IDiaEnumSourceFiles](../../debugger/debug-interface-access/idiaenumsourcefiles.md)
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [NameSearchOptions Enumeration](../../debugger/debug-interface-access/namesearchoptions.md)
