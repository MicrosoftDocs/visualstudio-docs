---
description: Retrieves the .NET Native input assembly file that is the parent of the specified symbol.
title: "IDiaSession::findInputAssemblyFile"
ms.date: "07/05/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findInputAssemblyFile method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::findInputAssemblyFile

Retrieves the .NET Native input assembly file that is the parent of the specified symbol.

## Syntax

```C++
HRESULT findInputAssemblyFile ( 
    IDiaSymbol* pSymbol,
    IDiaInputAssemblyFile** ppResult
);
```

#### Parameters

 `pSymbol`

[in] An [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md) that is a child of the desired input assembly.

 `ppResult`

[out] Returns an [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md) object that was the original .NET assembly of the specified symbol.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)
- [`IDiaSymbol::findInputAssemblyFile`](../../debugger/debug-interface-access/idiasymbol-findinputassemblyfile.md)
- [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)
