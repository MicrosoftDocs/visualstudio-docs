---
description: Retrieves an enumeration that allows a client to iterate through the .NET Native input assembly files.
title: "IDiaSession::findInputAssemblyFiles"
ms.date: "07/04/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSession::findInputAssemblyFiles method"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaSession::findInputAssemblyFiles

Retrieves an enumeration that allows a client to iterate through the .NET Native input assembly files.

## Syntax

```C++
HRESULT findInputAssemblyFiles (
   IDiaEnumInputAssemblyFiles** ppResult
);
```

#### Parameters

 `ppResult`

[out] Returns an [`IDiaEnumInputAssemblyFiles`](../../debugger/debug-interface-access/idiaenuminputassemblyfiles.md) object that contains a list of .NET Native input assembly files.

## Return Value

 If successful, returns `S_OK`; otherwise, returns an error code.

## See also

- [`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)
- [`IDiaEnumInputAssemblyFiles`](../../debugger/debug-interface-access/idiaenuminputassemblyfiles.md)
