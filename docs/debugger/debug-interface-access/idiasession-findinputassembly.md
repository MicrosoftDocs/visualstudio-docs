---
description: Retrieves a .NET Native input assembly file by index.
title: "IDiaSession::findInputAssembly"
ms.date: "07/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findInputAssembly method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::findInputAssembly

Retrieves a .NET Native input assembly file by index.

## Syntax

```C++
HRESULT findInputAssembly (
    DWORD index,
    IDiaInputAssemblyFile** ppResult
);
```

#### Parameters

 `index`

[in] Specifies the index of the .NET Native input assembly file to return.

 `ppResult`

[out] Returns the specified [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md) object.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
- [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)
- [`IDiaInputAssemblyFile::get_index`](../../debugger/debug-interface-access/idiainputassemblyfile-get-index.md)
