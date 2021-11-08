---
description: "Provides an address map to support image layout translations."
title: "IDiaAddressMap::set_addressMap | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaAddressMap::set_addressMap method"
ms.assetid: 81e82073-089b-43d5-af39-49d7a4907c7a
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# IDiaAddressMap::set_addressMap
Provides an address map to support image layout translations.

## Syntax

```C++
HRESULT set_addressMap ( 
   DWORD                     cbData,
   struct DiaAddressMapEntry data[],
   BOOL                      imagetoSymbols
);
```

#### Parameters
 `cbData`

[in] The number of elements in the `data` parameter.

 `data[]`

[in] An array of [DiaAddressMapEntry Structure](../../debugger/debug-interface-access/diaaddressmapentry.md) structures that define the translation map.

 `imagetoSymbols`

[in] `TRUE` if the `data` parameter defines a map from the new image layout to the original layout (as described by the debug symbols). `FALSE` if `data` is a map to the new image layout taken from the original layout.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 Usually, the DIA retrieves address translation maps from the program database (.pdb) file. If these values are missing, the [IDiaAddressMap::set_imageHeaders](../../debugger/debug-interface-access/idiaaddressmap-set-imageheaders.md) method is called twice, once with the `imagetoSymbols` parameter set to `TRUE` and once with the `imagetoSymbols` parameter set to `FALSE`. Address map translations cannot be enabled using the [IDiaAddressMap::put_addressMapEnabled](../../debugger/debug-interface-access/idiaaddressmap-put-addressmapenabled.md) method unless both translation maps are provided.

## See also
- [DiaAddressMapEntry Structure](../../debugger/debug-interface-access/diaaddressmapentry.md)
- [IDiaAddressMap](../../debugger/debug-interface-access/idiaaddressmap.md)
- [IDiaAddressMap::put_addressMapEnabled](../../debugger/debug-interface-access/idiaaddressmap-put-addressmapenabled.md)
- [IDiaAddressMap::set_imageHeaders](../../debugger/debug-interface-access/idiaaddressmap-set-imageheaders.md)
