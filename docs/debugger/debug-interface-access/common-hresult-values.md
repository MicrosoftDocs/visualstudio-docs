---
title: Common HRESULT Values (Debug Interface Access SDK)
description: See a list of common HRESULT values returned by various APIs in the Debug Interface Access (DIA) SDK.
ms.date: "7/2/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "constants, HRESULT, DIA SDK"
  - "DIA SDK, HRESULT, constants"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Common HRESULT values (Debug Interface Access SDK)

The following `HRESULT` values are most commonly returned by APIs within the Debug Interface Access (DIA) SDK.

Here are the values listed in numeric order by value

|Value|Name|Description|
|-----------|-----------|-----------|
|0x806d0002|`E_PDB_USAGE`|invalid parameter or call order|
|0x806d0004|`E_PDB_FILE_SYSTEM`|Can't read or write file, out of disk space, and so on.|
|0x806d0005|`E_PDB_NOT_FOUND`|PDB file not found|
|0x806d0006|`E_PDB_INVALID_SIG`|PDB signature does not match|
|0x806d0007|`E_PDB_INVALID_AGE`|PDB age mismatch|
|0x806d0008|`E_PDB_PRECOMP_REQUIRED`|Precompiled type information not found|
|0x806d0009|`E_PDB_OUT_OF_TI`|Out of debugger types|
|0x806d000c|`E_PDB_FORMAT`|Attempt to load or use a PDB with an incompatible or unsupported format|
|0x806d000d|`E_PDB_LIMIT`|Internal limit of PDB exceeded|
|0x806d000e|`E_PDB_CORRUPT`|PDB records or structure are corrupt|
|0x806d0011|`E_PDB_ILLEGAL_TYPE_EDIT`|Trying to edit types in read-only mode|
|0x806d0012|`E_PDB_INVALID_EXECUTABLE`|File is not recognized as a valid executable|
|0x806d0013|`E_PDB_DBG_NOT_FOUND`|.DBG file not found|
|0x806d0014|`E_PDB_NO_DEBUG_INFO`|No recognized debug information found|
|0x806d0015|`E_PDB_INVALID_EXE_TIMESTAMP`|Invalid timestamp of executable|
|0x806d0016|`E_PDB_RESERVED`|Undocumented error|
|0x806d0017|`E_PDB_DEBUG_INFO_NOT_IN_PDB`|Debug information is not in the PDB|
|0x806d0018|`E_PDB_SYMSRV_BAD_CACHE_PATH`|Bad cache location specified with symsrv|
|0x806d0019|`E_PDB_SYMSRV_CACHE_FULL`|symsrv cache is full|
|0x806d0064|`E_DIA_INPROLOG`|Cannot execute stack frame when in prolog|
|0x806d0065|`E_DIA_SYNTAX`|Error parsing frame program|
|0x806d0066|`E_DIA_FRAME_ACCESS`|Error accessing registers or memory|
|0x806d0067|`E_DIA_VALUE`|Error in computed value (such as divide by zero)|
|0x806d00C8|`E_DIA_COFF_ACCESS`|Error accessing OBJ, LIB or compiler generated PDB when querying a PDB produced by the linker with `/DEBUG:fastlink`|
|0x806d00C9|`E_DIA_COMP_PDB_ACCESS`|Error accessing compiler generated PDB|

## Requirements

Header: dia2.h

## See also

- [Reference](../../debugger/debug-interface-access/debug-interface-access-sdk-reference.md)
- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
