---
description: Retrieves an enumeration of source link information.
title: "IDiaSessionEx::getSourceLinkInfo"
ms.date: "07/05/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSessionEx::getSourceLinkInfo method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSessionEx::getSourceLinkInfo

Retrieves an enumeration of [Source Link](https://github.com/dotnet/designs/blob/main/accepted/2020/diagnostics/source-link.md) information.

## Syntax

```C++
HRESULT getSourceLinkInfo(
        IDiaSymbol* parent,
        IDiaEnumSourceLink** ppEnum
);
```

#### Parameters

 `parent`

 [in] If not `nullptr`, specifies the `SymTagCompiland` symbol to query for source link information. Otherwise this method enumerates all source link information.

 `ppEnum`

[out] Returns an [`IDiaEnumSourceLine`](../../debugger/debug-interface-access/idiaenumsourcelink.md) object that contains the list of source link information .

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaSessionEx`](../../debugger/debug-interface-access/idiasessionex.md)
- [Source Link](https://github.com/dotnet/designs/blob/main/accepted/2020/diagnostics/source-link.md)
- [Using Source Link](https://github.com/dotnet/sourcelink#using-source-link-in-c-projects)
- [/SOURCELINK (Include Source Link file in PDB)](/cpp/build/reference/sourcelink)
