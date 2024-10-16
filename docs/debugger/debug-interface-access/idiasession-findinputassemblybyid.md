---
description: Retrieves a .NET Native input assembly file by unique identifier.
title: "IDiaSession::findInputAssemblyById"
ms.date: "07/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findInputAssemblyById method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::findInputAssemblyById

Retrieves a .NET Native input assembly file by unique identifier.

## Syntax

```C++
HRESULT findInputAssemblyById (
    DWORD uniqueId,
    IDiaInputAssemblyFile** ppResult
);
```

#### Parameters

 `uniqueId`

[in] Specifies the unique identifier of the .NET Native input assembly file to return.

 `ppResult`

[out] Returns the specified [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md) object.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
- [`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)
- [`IDiaInputAssemblyFile::get_uniqueId`](../../debugger/debug-interface-access/idiainputassemblyfile-get-uniqueid.md)
