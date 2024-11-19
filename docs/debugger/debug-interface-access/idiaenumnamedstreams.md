---
description: Enumerates the named streams contained in the data source.
title: IDiaEnumNamedStreams
ms.date: "11/18/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaEnumNamedStreams interface"
author: "grantri"
ms.author: "grantri"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# IDiaEnumNamedStreams

Enumerates the named streams contained in the data source.

## Syntax

`IDiaEnumNamedStreams : IUnknown`

## Methods in Vtable Order

The following table shows the methods of `IDiaEnumNamedStreams`.

|Method|Description|
|------------|-----------------|
|[`IDiaEnumNamedStreams::get__NewEnum`](../../debugger/debug-interface-access/idiaenumnamedstreams-get-newenum.md)|Retrieves the [`IEnumVARIANT` Interface](/previous-versions/windows/desktop/api/oaidl/nn-oaidl-ienumvariant) version of this enumerator.|
|[`IDiaEnumNamedStreams::get_Count`](../../debugger/debug-interface-access/idiaenumnamedstreams-get-count.md)|Retrieves the number of named streams.|
|[`IDiaEnumNamedStreams::Next`](../../debugger/debug-interface-access/idiaenumnamedstreams-next.md)|Retrieves the next named stream in the enumeration sequence.|
|[`IDiaEnumNamedStreams::Skip`](../../debugger/debug-interface-access/idiaenumnamedstreams-skip.md)|Advances a specified number of names in the enumeration sequence.|
|[`IDiaEnumNamedStreams::Reset`](../../debugger/debug-interface-access/idiaenumnamedstreams-reset.md)|Resets this enumeration sequence to the beginning.|
|[`IDiaEnumNamedStreams::Clone`](../../debugger/debug-interface-access/idiaenumnamedstreams-clone.md)|Creates a new enumerator that contains the same enumeration state as the current enumerator.|

## Remarks

 These named streams are an implementation detail of the PDB file format. They often contain information that can more appropriately be enumerated with a better enumeration, such as  [`IDiaEnumTables`](../../debugger/debug-interface-access/idiaenumtables.md), [`IDiaEnumInjectedSources`](../../debugger/debug-interface-access/idiaenuminjectedsources.md), [`IDiaEnumSourceLink`](../../debugger/debug-interface-access/idiaenumsourcelink.md), [`IDiaEnumSourceLink2`](../../debugger/debug-interface-access/idiaenumsourcelink2.md), or even [`IDiaEnumDebugStreams`](../../debugger/debug-interface-access/idiaenumdebugstreams.md). Where possible the other enumerators should be used.

## Notes for Callers

Obtain this interface by calling the [`IDiaDataSourceEx2::findNamedStreams`](../../debugger/debug-interface-access/idiadatasourceex2-findnamedstreams.md) method.

## Example

See [`IDiaDataSourceEx2::findNamedStreams`](../../debugger/debug-interface-access/idiadatasourceex2-findnamedstreams.md) for an example of how to obtain an `IDiaEnumNamedStreams` interface and enumerate all of the named streams.

## Requirements

Header: Dia2.h

Library: diaguids.lib

DLL: msdia140.dll

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [`IDiaDataSourceEx2::findNamedStreams`](../../debugger/debug-interface-access/idiadatasourceex2-findnamedstreams.md)
- [`IDiaEnumDebugStreams`](../../debugger/debug-interface-access/idiaenumdebugstreams.md)
- [`IDiaEnumInjectedSources`](../../debugger/debug-interface-access/idiaenuminjectedsources.md)
- [`IDiaEnumSourceLink`](../../debugger/debug-interface-access/idiaenumsourcelink.md)
- [`IDiaEnumSourceLink2`](../../debugger/debug-interface-access/idiaenumsourcelink2.md)
- [`IDiaEnumTables`](../../debugger/debug-interface-access/idiaenumtables.md)
