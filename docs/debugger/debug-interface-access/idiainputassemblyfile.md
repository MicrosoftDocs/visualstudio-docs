---
description: Accesses information that describes an input or source assembly file for a .NET Native binary.
title: IDiaInputAssemblyFile
ms.date: "07/17/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaInputAssemblyFile interface"
author: "grantri"
ms.author: "grantri"
manager: twhitney
ms.subservice: debug-diagnostics
---

# IDiaInputAssemblyFile

Accesses information that describes an input or source assembly file for a .NET Native binary.

## Syntax

`IDiaInputAssemblyFile : IUnknown`

## Methods

The following table shows the methods of `IDiaInputAssemblyFile`.

|Method|Description|
|------------|-----------------|
|[`IDiaInputAssemblyFile::get_uniqueId`](../../debugger/debug-interface-access/idiainputassemblyfile-get-uniqueid.md)|Retrieves a unique identifier for the file.|
|[`IDiaInputAssemblyFile::get_index`](../../debugger/debug-interface-access/idiainputassemblyfile-get-index.md)|Retrieves the file index.|
|[`IDiaInputAssemblyFile::get_timestamp`](../../debugger/debug-interface-access/idiainputassemblyfile-get-timestamp.md)|Retrieves the time stamp.|
|[`IDiaInputAssemblyFile::get_pdbAvailableAtILMerge`](../../debugger/debug-interface-access/idiainputassemblyfile-get-pdbavailableatilmerge.md)|Retrieves a flag that indicates whether the PDB was available at the creation of the .NET Native binary.|
|[`IDiaInputAssemblyFile::get_fileName`](../../debugger/debug-interface-access/idiainputassemblyfile-get-filename.md)|Retrieves the orginal assembly file name.|
|[`IDiaInputAssemblyFile::get_version`](../../debugger/debug-interface-access/idiainputassemblyfile-get-version.md)|Retrieves the version of the orginal assembly.|

## Remarks

Obtain this interface by calling one of the [`IDiaSession::findInputAssemblyFile`](../../debugger/debug-interface-access/idiasession-findinputassemblyfile.md), [`IDiaSession::findInputAssembly`](../../debugger/debug-interface-access/idiasession-findinputassembly.md), [`IDiaSession::findInputAssemblyById`](../../debugger/debug-interface-access/idiasession-findinputassemblybyid.md), or [`IDiaSymbol::findInputAssemblyFile`](../../debugger/debug-interface-access/idiasymbol-findinputassemblyfile.md) methods. You can also enumerate the .NET Native input assembly files with the [`IDiaEnumInputAssemblyFiles`](../../debugger/debug-interface-access/idiaenuminputassemblyfiles.md) interface.

## Requirements

Header: Dia2.h

Library: diaguids.lib

DLL: msdia140.dll

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [`IDiaEnumInputAssemblyFiles`](../../debugger/debug-interface-access/idiaenuminputassemblyfiles.md)
- [Compile apps with .NET Native](/windows/uwp/dotnet-native/)
