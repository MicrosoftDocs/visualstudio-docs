---
title: "Constants (Debug Interface Access SDK) | Microsoft Docs"
description: See a list of string constants that can be used to identify various sections of a program debug database (PDB) file through the debug interface access (DIA) SDK.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "constants, DIA SDK"
  - "DIA SDK, constants"
ms.assetid: aca4ec77-bc08-4cdd-a6ce-8d4a28ea5ea3
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Constants (Debug Interface Access SDK)
These string constants can be used to identify various sections of a program debug database (PDB) file through the DIA SDK.

## Constants
The following are declared as C/C++ macros.

|Macro|Value|
|-----------|-----------|
|`DiaTable_Symbols`|L"Symbols"|
|`DiaTable_Sections`|L"Sections"|
|`DiaTable_SrcFiles`|L"SourceFiles"|
|`DiaTable_LineNums`|L"LineNumbers"|
|`DiaTable_SegMap`|L"SegmentMap"|
|`DiaTable_Dbg`|L"Dbg"|
|`DiaTable_InjSrc`|L"InjectedSource"|
|`DiaTable_FrameData`|L"FrameData"|

## Example
Here is an example using one of these symbols:

```C++
HRESULT GetSymbolTable(IDiaEnumTables *pEnumTables, IDiaTable **pTable)
{
    HRESULT hr;
    VARIANT var;
    var.vt      = VT_BSTR;
    var.bstrVal = SysAllocString( DiaTable_Symbols );
    hr = pEnumTables->Item( var, pTable );
    return(hr);
}
```

## Requirements
Header: dia2.h

## See also
- [Reference](../../debugger/debug-interface-access/debug-interface-access-sdk-reference.md)
- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaEnumTables::Item](../../debugger/debug-interface-access/idiaenumtables-item.md)
