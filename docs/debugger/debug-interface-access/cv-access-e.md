---
title: CV_access_e
description: Get information about the CV_access_e enumeration type, which specifies the scope of visibility (access level) of members in the debug interface access SDK.
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "CV_access_e enumeration"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# CV_access_e

Specifies the scope of visibility (access level) of member functions and variables.

## Syntax

```c++
typedef enum CV_access_e {
    CV_private   = 1,
    CV_protected = 2,
    CV_public    = 3
} CV_access_e;
```

## Elements

| Element      | Description                  |
| ------------ | ---------------------------- |
| CV_private   | Member has private access.   |
| CV_protected | Member has protected access. |
| CV_public    | Member has public access.    |

## Remarks

The `friend` access specifier is not included here because it is typically used by non-member functions that have access to both private and protected elements of the class. Use the [IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md) method to find symbols with `SymTagFriend` access.

## Requirements

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaSymbol::get_access](../../debugger/debug-interface-access/idiasymbol-get-access.md)
- [IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md)
