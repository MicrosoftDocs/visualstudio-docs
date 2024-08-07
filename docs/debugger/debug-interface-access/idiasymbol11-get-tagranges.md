---
description: "Retrieves the ranges of tags within a discriminated union symbol instance."
title: "IDiaSymbol11::get_tagRanges"
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol11::get_tagRanges method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol11::get_tagRanges

Retrieves the ranges of tags within a discriminated union symbol instance.

## Syntax

```C++
HRESULT get_tagRanges(
  DWORD count,
  DWORD *pcRangeValues,
  DiaTagValue *rangeValues
);
```

#### Parameters

 `count`

[in] Specifies the count of valid [`DiaTagValue`](../../debugger/debug-interface-access/diatagvalue.md) elements pointed to by the `rangeValues` parameter.

 `pcRangeValues`

[out] Returns the count of [`DiaTagValue`](../../debugger/debug-interface-access/diatagvalue.md) elements needed if `rangeValues` is `nullptr`; otherwise returns the count of elements used.

 `rangeValues`

[out] Returns an array of [`DiaTagValue`](../../debugger/debug-interface-access/diatagvalue.md). On input the count of valid elements is specified by the `count` parameter. Upon return `*pcRangeValues` is the count of valid elements that were filled in.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## Remarks

The first array element (`rangeValues[0]`) represents the lower bound of the range. The next array element represents the upper bound of the range. The array continues to alternate between lower and upper bounds of each subsequent range. Both upper and lower bounds are inclusive.

## See also

- [`IDiaSymbol11`](../../debugger/debug-interface-access/idiasymbol11.md)
- [`DiaTagValue`](../../debugger/debug-interface-access/diatagvalue.md)
