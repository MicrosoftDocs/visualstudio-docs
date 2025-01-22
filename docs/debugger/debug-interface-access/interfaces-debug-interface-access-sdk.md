---
description: "Methods are listed alphabetically under each interface in the table of contents and on the interface page in Vtable order."
title: "Interfaces (Debug Interface Access SDK)"
ms.date: "11/19/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "interfaces [DIA SDK]"
  - "DIA SDK, interfaces"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Interfaces (Debug Interface Access SDK)

Methods of the Debug Interface Access (DIA) SDK are listed alphabetically under each interface in the table of contents and on the interface page in Vtable order.

## In This Section

[`IDiaAddressMap`](../../debugger/debug-interface-access/idiaaddressmap.md)

Provides control over how the DIA SDK computes virtual and relative virtual addresses for debug objects.

[`IDiaDataSource`](../../debugger/debug-interface-access/idiadatasource.md)

Initiates access to a source of debugging symbols.

[`IDiaDataSourceEx`](../../debugger/debug-interface-access/idiadatasourceex.md)

Initiates access to a source of debugging symbols. Supersedes [`IDiaDataSource`](../../debugger/debug-interface-access/idiadatasource.md)

[`IDiaDataSourceEx2`](../../debugger/debug-interface-access/idiadatasourceex2.md)

Initiates access to a source of debugging symbols. Supersedes [`IDiaDataSource`](../../debugger/debug-interface-access/idiadatasource.md) and [`IDiaDataSourceEx`](../../debugger/debug-interface-access/idiadatasourceex.md)

[`IDiaEnumDebugStreamData`](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md)

Provides access to the records in a debug data stream.

[`IDiaEnumDebugStreams`](../../debugger/debug-interface-access/idiaenumdebugstreams.md)

Enumerates the various debug streams contained in the data source.

[`IDiaEnumFrameData`](../../debugger/debug-interface-access/idiaenumframedata.md)

Enumerates the various frame data elements contained in the data source.

[`IDiaEnumInjectedSources`](../../debugger/debug-interface-access/idiaenuminjectedsources.md)

Enumerate the various injected sources contained in the data source.

[`IDiaEnumInputAssemblyFiles`](../../debugger/debug-interface-access/idiaenuminputassemblyfiles.md)

Enumerate the input assembly files listed in the data source.

[`IDiaEnumLineNumbers`](../../debugger/debug-interface-access/idiaenumlinenumbers.md)

Enumerates the various line numbers contained in the data source.

[`IDiaEnumSectionContribs`](../../debugger/debug-interface-access/idiaenumsectioncontribs.md)

Enumerates the various section contributions contained in the data source.

[`IDiaEnumSegments`](../../debugger/debug-interface-access/idiaenumsegments.md)

Enumerates the various segments contained in the data source.

[`IDiaEnumSourceFiles`](../../debugger/debug-interface-access/idiaenumsourcefiles.md)

Enumerates the various source files contained in the data source.

[`IDiaEnumSourceLink`](../../debugger/debug-interface-access/idiaenumsourcelink.md)

Enumerates the various source link blobs contained in the data source.

[`IDiaEnumSourceLink2`](../../debugger/debug-interface-access/idiaenumsourcelink2.md)

Enumerates the various source link blobs contained in the data source. Supersedes [`IDiaEnumSourceLink2`](../../debugger/debug-interface-access/idiaenumsourcelink2.md) to add support for 64-bit sizes.

[`IDiaEnumStackFrames`](../../debugger/debug-interface-access/idiaenumstackframes.md)

Enumerates the various stack frames available.

[`IDiaEnumSymbols`](../../debugger/debug-interface-access/idiaenumsymbols.md)

Enumerates the various symbols contained in the data source.

[`IDiaEnumSymbolsByAddr`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md)

Enumerates by address the various symbols contained in the data source.

[`IDiaEnumSymbolsByAddr2`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr2.md)

Enumerates by address the various symbols contained in the data source. Supersedes [`IDiaEnumSymbolsByAddr`](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md)

[`IDiaEnumTables`](../../debugger/debug-interface-access/idiaenumtables.md)

Enumerates the various tables contained in the data source.

[`IDiaFrameData`](../../debugger/debug-interface-access/idiaframedata.md)

Exposes the details of a stack frame.

[`IDiaImageData`](../../debugger/debug-interface-access/idiaimagedata.md)

Exposes the details of the base location and memory offsets of the module or image.

[`IDiaInjectedSource`](../../debugger/debug-interface-access/idiainjectedsource.md)

Accesses the program source code stored in the DIA data source.

[`IDiaInputAssemblyFile`](../../debugger/debug-interface-access/idiainputassemblyfile.md)

Accesses information that describes an input or source assembly file for a .NET Native binary.

[`IDiaLineNumber`](../../debugger/debug-interface-access/idialinenumber.md)

Accesses information that describes the process of mapping from a block of bytes of image text to a source file line number.

[`IDiaLoadCallback`](../../debugger/debug-interface-access/idialoadcallback.md)

Receives callbacks from the DIA symbol locating procedure, thus enabling a user interface to report on the progress of the location attempt.

[`IDiaLoadCallback2`](../../debugger/debug-interface-access/idialoadcallback2.md)

Receives callbacks from the DIA symbol locating procedure, allowing restrictions to be imposed on the locating process.

[`IDiaPropertyStorage`](../../debugger/debug-interface-access/idiapropertystorage.md)

Allows you to read the persistent properties of a DIA property set.

[`IDiaReadExeAtRVACallback`](../../debugger/debug-interface-access/idiareadexeatrvacallback.md)

Enables a client application to supply bytes of an executable file as specified by file position.

[`IDiaReadExeAtOffsetCallback`](../../debugger/debug-interface-access/idiareadexeatoffsetcallback.md)

Enables a client application to supply bytes of an executable file as specified by a relative virtual address.

[`IDiaSectionContrib`](../../debugger/debug-interface-access/idiasectioncontrib.md)

Retrieves data describing a section contribution, that is, a contiguous block of memory contributed to the image by a compiland.

[`IDiaSegment`](../../debugger/debug-interface-access/idiasegment.md)

Maps data from the section number to segments of address space.

[`IDiaSession`](../../debugger/debug-interface-access/idiasession.md)

Provides a query context for debug symbols.

[`IDiaSessionEx`](../../debugger/debug-interface-access/idiasessionex.md)

Provides an extended query context for debug symbols.

[`IDiaSourceFile`](../../debugger/debug-interface-access/idiasourcefile.md)

Represents a source file.

[`IDiaStackFrame`](../../debugger/debug-interface-access/idiastackframe.md)

Exposes the properties of a stack frame.

[`IDiaStackWalker`](../../debugger/debug-interface-access/idiastackwalker.md)

Provides methods to do a stack walk using the PDB file.

[`IDiaStackWalkFrame`](../../debugger/debug-interface-access/idiastackwalkframe.md)

Maintains stack context between invocations of the [`IDiaFrameData::execute`](../../debugger/debug-interface-access/idiaframedata-execute.md) method.

[`IDiaStackWalkHelper`](../../debugger/debug-interface-access/idiastackwalkhelper.md)

Facilitates walking the stack using the program debug database (PDB) file.

[`IDiaStackWalkHelper2`](../../debugger/debug-interface-access/idiastackwalkhelper2.md)

Facilitates walking the stack using the program debug database (PDB) file. Supersedes [`IDiaStackWalkHelper`](../../debugger/debug-interface-access/idiastackwalkhelper.md)

[`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)

Describes the properties of a symbol instance.

[`IDiaSymbol2`](../../debugger/debug-interface-access/idiasymbol2.md)

Describes more properties of a symbol instance. Supersedes [`IDiaSymbol`](../../debugger/debug-interface-access/idiasymbol.md)

[`IDiaSymbol3`](../../debugger/debug-interface-access/idiasymbol3.md)

Describes more properties of a symbol instance. Supersedes [`IDiaSymbol2`](../../debugger/debug-interface-access/idiasymbol2.md)

[`IDiaSymbol4`](../../debugger/debug-interface-access/idiasymbol4.md)

Describes more properties of a symbol instance. Supersedes [`IDiaSymbol3`](../../debugger/debug-interface-access/idiasymbol3.md)

[`IDiaSymbol5`](../../debugger/debug-interface-access/idiasymbol5.md)

Describes more properties of a symbol instance. Supersedes [`IDiaSymbol4`](../../debugger/debug-interface-access/idiasymbol4.md)

[`IDiaSymbol6`](../../debugger/debug-interface-access/idiasymbol6.md)

Describes more properties of a symbol instance. Supersedes [`IDiaSymbol5`](../../debugger/debug-interface-access/idiasymbol5.md)

[`IDiaSymbol7`](../../debugger/debug-interface-access/idiasymbol7.md)

Describes more properties of a symbol instance. Supersedes [`IDiaSymbol6`](../../debugger/debug-interface-access/idiasymbol6.md)

[`IDiaSymbol8`](../../debugger/debug-interface-access/idiasymbol8.md)

Describes more properties of a symbol instance primarily related to coroutines. Supersedes [`IDiaSymbol7`](../../debugger/debug-interface-access/idiasymbol7.md)

[`IDiaSymbol9`](../../debugger/debug-interface-access/idiasymbol9.md)

Describes more properties of a symbol instance. Supersedes [`IDiaSymbol8`](../../debugger/debug-interface-access/idiasymbol8.md)

[`IDiaSymbol10`](../../debugger/debug-interface-access/idiasymbol10.md)

Describes more properties of a symbol instance. Supersedes [`IDiaSymbol9`](../../debugger/debug-interface-access/idiasymbol9.md)

[`IDiaSymbol11`](../../debugger/debug-interface-access/idiasymbol11.md)

Describes more properties of a symbol instance. Supersedes [`IDiaSymbol10`](../../debugger/debug-interface-access/idiasymbol10.md)

[`IDiaTable`](../../debugger/debug-interface-access/idiatable.md)

Enumerates a DIA data source table.

## Related Sections

[Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)

Describes the enumerations and structures used by the various interfaces of the DIA SDK.

[Constants (Debug Interface Access SDK)](../../debugger/debug-interface-access/constants-debug-interface-access-sdk.md)

Describes the constants available in the DIA SDK.

## See also

- [Reference](../../debugger/debug-interface-access/debug-interface-access-sdk-reference.md)
