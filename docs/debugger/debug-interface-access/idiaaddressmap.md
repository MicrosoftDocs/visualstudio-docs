---
description: Provides control over how the DIA SDK computes virtual and relative virtual addresses for debug objects.
title: IDiaAddressMap
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaAddressMap interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaAddressMap

Provides control over how the Debug Interface Access (DIA) SDK computes virtual and relative virtual addresses for debug objects.

## Syntax

`IDiaAddressMap : IUnknown`

## Methods in Vtable Order

The following table shows the methods of `IDiaAddressMap`.

|Method|Description|
|------------|-----------------|
|[IDiaAddressMap::get_addressMapEnabled](../../debugger/debug-interface-access/idiaaddressmap-get-addressmapenabled.md)|Indicates whether an address map has been established for a particular session.|
|[IDiaAddressMap::put_addressMapEnabled](../../debugger/debug-interface-access/idiaaddressmap-put-addressmapenabled.md)|Specifies whether the address map should be used to translate symbol addresses.|
|[IDiaAddressMap::get_relativeVirtualAddressEnabled](../../debugger/debug-interface-access/idiaaddressmap-get-relativevirtualaddressenabled.md)|Indicates whether the calculation and use of relative virtual addresses is enabled.|
|[IDiaAddressMap::put_relativeVirtualAddressEnabled](../../debugger/debug-interface-access/idiaaddressmap-put-relativevirtualaddressenabled.md)|Allows the client to enable or disable the calculation of relative virtual addresses.|
|[IDiaAddressMap::get_imageAlign](../../debugger/debug-interface-access/idiaaddressmap-get-imagealign.md)|Retrieves the current image alignment.|
|[IDiaAddressMap::put_imageAlign](../../debugger/debug-interface-access/idiaaddressmap-put-imagealign.md)|Sets the image alignment.|
|[IDiaAddressMap::set_imageHeaders](../../debugger/debug-interface-access/idiaaddressmap-set-imageheaders.md)|Sets image headers to enable the translation of relative virtual addresses.|
|[IDiaAddressMap::set_addressMap](../../debugger/debug-interface-access/idiaaddressmap-set-addressmap.md)|Provides an address map to support image layout translations.|

## Remarks

The control provided by this interface is encapsulated in two sets of data you supply: image headers and address maps. Most clients use the [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md) method to find the proper debug information for an image and the method can typically discover all of the necessary headers and maps data itself. However some clients implement specialized processing and searching for data. Such clients use the methods of the `IDiaAddressMap` interface to provide the DIA SDK with the search results.

## Notes for Callers

This interface is available from the DIA session object. The client calls the `QueryInterface` method on DIA session object interface, usually [IDiaSession](../../debugger/debug-interface-access/idiasession.md), to retrieve the `IDiaAddressMap` interface.

## Requirements

Header: Dia2.h

Library: diaguids.lib

DLL: msdia80.dll

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaDataSource::loadDataForExe](../../debugger/debug-interface-access/idiadatasource-loaddataforexe.md)
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
