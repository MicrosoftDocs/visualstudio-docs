---
title: "NameSearchOptions | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "NameSearchOptions enumeration"
ms.assetid: 67dfbede-2678-47df-b664-5c49841d0b9b
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# NameSearchOptions
Specifies the search options for symbol and file names.

## Syntax

```C++
enum NameSearchOptions {
    nsNone,
    nsfCaseSensitive     = 0x1,
    nsfCaseInsensitive   = 0x2,
    nsfFNameExt          = 0x4,
    nsfRegularExpression = 0x8,
    nsfUndecoratedName   = 0x10,

// For backward compatibility:
    nsCaseSensitive           = nsfCaseSensitive,
    nsCaseInsensitive         = nsfCaseInsensitive,
    nsFNameExt                = nsfCaseInsensitive | nsfFNameExt,
    nsRegularExpression       = nsfRegularExpression | nsfCaseSensitive,
    nsCaseInRegularExpression = nsfRegularExpression | nsfCaseInsensitive
};
```

## Elements
`nsNone`
No options are specified.

`nsfCaseSensitive`
Applies a case-sensitive name match.

`nsfCaseInsensitive`
Applies a case-insensitive name match.

`nsfFNameExt`
Treats names as paths and applies a filename.ext name match.

`nsfRegularExpression`
Applies a case-sensitive name match using asterisks (*) and question marks (?) as wildcards. (Other common regular expression characters are not supported.)

`nsfUndecoratedName`
Applies only to symbols that have both undecorated and decorated names.

## Remarks
The values from this enumeration are passed to the following methods:

- [IDiaSession::findChildren](../../debugger/debug-interface-access/idiasession-findchildren.md)

- [IDiaSession::findFile](../../debugger/debug-interface-access/idiasession-findfile.md)

- [IDiaSymbol::findChildren](../../debugger/debug-interface-access/idiasymbol-findchildren.md)

## Requirements
Header: dia2.h

## See also
- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaSession::findChildren](../../debugger/debug-interface-access/idiasession-findchildren.md)
- [IDiaSession::findFile](../../debugger/debug-interface-access/idiasession-findfile.md)
- [IDiaSymbol::findChildren](../../debugger/debug-interface-access/idiasymbol-findchildren.md)
