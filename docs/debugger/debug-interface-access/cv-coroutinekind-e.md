---
title: CV_CoroutineKind_e
description: Get information about the CV_CoroutineKind_e enumeration type, which specifies the coroutine kind.
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "CV_CoroutineKind_e enumeration"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# CV_CoroutineKind_e

Specifies the couroutine kind.

## Syntax

```c++
typedef enum CV_CoroutineKind_e
{
    CV_COROUTINEKIND_NONE,
    CV_COROUTINEKIND_PRIMARY,
    CV_COROUTINEKIND_INIT,
    CV_COROUTINEKIND_RESUME,
    CV_COROUTINEKIND_DESTROY
} CV_CoroutineKind_e;
```

## Elements

| Element      | Description                  |
| ------------ | ---------------------------- |
| `CV_COROUTINEKIND_NONE`| Not a coroutine. |
| `CV_COROUTINEKIND_PRIMARY`| The original coroutine function. |
| `CV_COROUTINEKIND_INIT`| Initialization function, sets up the coroutine frame. |
| `CV_COROUTINEKIND_RESUME`| Resume function, contains the coroutine body code. |
| `CV_COROUTINEKIND_DESTROY`| Destroy function, tears down the coroutine frame. |

## Remarks

Use the [IDiaSymbol8::get_coroutineKind](../../debugger/debug-interface-access/idiasymbol8-get-coroutinekind.md) method to retrieve the coroutine kind for a coroutine function.

## Requirements

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [IDiaSymbol8::get_coroutineKind](../../debugger/debug-interface-access/idiasymbol8-get-coroutinekind.md)
