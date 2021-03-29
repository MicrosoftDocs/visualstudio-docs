---
description: "Writes a dump to a file."
title: IDebugProgram2::WriteDump | Microsoft Docs
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProgram2::WriteDump
helpviewer_keywords:
- IDebugProgram2::WriteDump
ms.assetid: 375afb8c-882d-44db-bfa7-e2c9eb555122
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
dev_langs:
- CPP
- CSharp
---
# IDebugProgram2::WriteDump
Writes a dump to a file.

## Syntax

```cpp
HRESULT WriteDump( 
   DUMPTYPE  DumpType,
   LPCOLESTR pszDumpUrl
);
```

```csharp
int WriteDump( 
   enum_DUMPTYPE  DumpType,
   string         pszDumpUrl
);
```

## Parameters
`DumpType`\
[in] A value from the [DUMPTYPE](../../../extensibility/debugger/reference/dumptype.md) enumeration that specifies the type of dump, for example, short or long.

`pszDumpUrl`\
[in] The URL to write the dump to. Typically, this is in the form of `file://c:\path\filename.ext`, but may be any valid URL.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 A program dump would typically include the current stack frame, the stack itself, a list of the threads running in the program, and possibly any memory that the program owns.

## See also
- [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)
