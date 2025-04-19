---
title: CV_AssociationKind_e
description: Specifies the kind of association between two symbols.
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "CV_AssociationKind_e enumeration"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# `CV_AssociationKind_e`

Specifies the kind of association between two symbols.

## Syntax

```c++
typedef enum CV_AssociationKind_e
{
    CV_ASSOCIATIONKIND_NONE,
    CV_ASSOCIATIONKIND_COROUTINE
} CV_AssociationKind_e;
```

## Elements

| Element      | Description                  |
| ------------ | ---------------------------- |
| `CV_ASSOCIATIONKIND_NONE`| No associated symbol. |
| `CV_ASSOCIATIONKIND_COROUTINE`| Associated symbol is the primary coroutine function. |

## Remarks

Use the [`IDiaSymbol8::get_associatedSymbolKind`](../../debugger/debug-interface-access/idiasymbol8-get-associatedSymbolkind.md) method to retrieve the kind of associated between two symbols.

## Requirements

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [`IDiaSymbol8::get_associatedSymbolKind`](../../debugger/debug-interface-access/idiasymbol8-get-associatedSymbolkind.md)
