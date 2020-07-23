---
title: "IDiaSession::findSymbolsForAcceleratorPointerTag | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
ms.assetid: 95fd5e7a-c637-437e-b369-c864eef733c2
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# IDiaSession::findSymbolsForAcceleratorPointerTag
Returns an enumeration of symbols for the variable that the specified tag value corresponds to in the parent Accelerator stub function.

## Syntax

```C++
HRESULT findSymbolsForAcceleratorPointerTag ( 
   IDiaSymbol*           parent,
   DWORD                 tagValue,
   IDiaEnumSymbols**     ppResult
);
```

#### Parameters
 `parent`

[in] An IDiaSymbol that corresponds to the Accelerator stub function to be searched.

 `tagValue`

[in] The pointer tag value.

 `ppResult`

[out] A pointer to an `IDiaEnumSymbols` interface pointer that is initialized with the result.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## See also
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)