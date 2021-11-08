---
description: "Given a corresponding tag value, this method returns an enumeration of symbols that are contained in this stub function."
title: "IDiaSymbol::findSymbolsForAcceleratorPointerTag | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: fb66852c-c5f7-4140-b9fe-20cb4e51a9fe
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaSymbol::findSymbolsForAcceleratorPointerTag

Given a corresponding tag value, this method returns an enumeration of symbols that are contained in this stub function.

## Syntax

```C++
HRESULT findSymbolsForAccleratorPointerTag (
   DWORD             tagValue,
   IDiaEnumSymbols** ppResult);
```

#### Parameters
 `tagValue`

[in] The pointer tag value for which the pointee symbol records are found.

 `ppResult`

[out] A pointer to an `IDiaEnumSymbols` interface pointer which is initialized with the result.

## Return Value
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.

## See also
- [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
