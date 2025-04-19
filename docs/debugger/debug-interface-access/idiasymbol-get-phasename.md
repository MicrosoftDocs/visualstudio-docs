---
description: "Retrieves the phase this function is a member of for PGO multiphased builds."
title: "IDiaSymbol::get_phaseName"
ms.date: "07/09/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol::get_phaseName method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---
# IDiaSymbol::get_phaseName

Retrieves the phase this function is a member of for PGO multiphased builds.

## Syntax

```C++
HRESULT get_phaseName ( 
   BSTR* pRetVal
);
```

#### Parameters

 `pRetVal`

[out] Returns the phase name.

## Return Value

 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [Profile-guided optimizations](/cpp/build/profile-guided-optimizations)
