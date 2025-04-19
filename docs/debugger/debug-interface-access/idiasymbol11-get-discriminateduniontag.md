---
description: "Retrieves information about the tag of a discriminated union symbol instance."
title: "IDiaSymbol11::get_discriminatedUnionTag"
ms.date: "07/15/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol11::get_discriminatedUnionTag method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol11::get_discriminatedUnionTag

Retrieves information about the tag of a discriminated union symbol instance.

## Syntax

```C++
HRESULT get_discriminatedUnionTag(
    IDiaSymbol **ppTagType,
    DWORD *pTagOffset,
    DiaTagValue *pTagMask
);
```

#### Parameters

 `ppTagType`

[out] Returns the [`IDiaSymbol`](../../debugger//debug-interface-access/idiasymbol.md) that represents the type of the tag member.

 `pTagOffset`

[out] Returns the byte offset within the parent structure of where the start of the tag member is located.

 `pTagMask`

[out] Returns a mask value if the tag does not fill all the bytes of the tag member; otherwise returns an empty [`DiaTagValue`](../../debugger/debug-interface-access/diatagvalue.md) with the `valueSizeBytes` set to 0.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also

- [`IDiaSymbol11`](../../debugger/debug-interface-access/idiasymbol11.md)
- [`DiaTagValue`](../../debugger/debug-interface-access/diatagvalue.md)
