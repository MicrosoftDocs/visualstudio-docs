---
title: "Interfaces (Debug Interface Access SDK)"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "interfaces [DIA SDK]"
  - "DIA SDK, interfaces"
ms.assetid: 62aee7c3-d314-4272-a32b-b2818f32fab8
caps.latest.revision: 16
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Interfaces (Debug Interface Access SDK)
Methods are listed alphabetically under each interface in the table of contents and on the interface page in Vtable order.  
  
## In This Section  
 [IDiaAddressMap](../debugger/idiaaddressmap.md)  
 Provides control over how the DIA SDK computes virtual and relative virtual addresses for debug objects.  
  
 [IDiaDataSource](../debugger/idiadatasource.md)  
 Initiates access to a source of debugging symbols.  
  
 [IDiaEnumDebugStreamData](../debugger/idiaenumdebugstreamdata.md)  
 Provides access to the records in a debug data stream.  
  
 [IDiaEnumDebugStreams](../debugger/idiaenumdebugstreams.md)  
 Enumerates the various debug streams contained in the data source.  
  
 [IDiaEnumFrameData](../debugger/idiaenumframedata.md)  
 Enumerates the various frame data elements contained in the data source.  
  
 [IDiaEnumInjectedSources](../debugger/idiaenuminjectedsources.md)  
 Enumerate the various injected sources contained in the data source.  
  
 [IDiaEnumLineNumbers](../debugger/idiaenumlinenumbers.md)  
 Enumerates the various line numbers contained in the data source.  
  
 [IDiaEnumSectionContribs](../debugger/idiaenumsectioncontribs.md)  
 Enumerates the various section contributions contained in the data source.  
  
 [IDiaEnumSegments](../debugger/idiaenumsegments.md)  
 Enumerates the various segments contained in the data source.  
  
 [IDiaEnumSourceFiles](../debugger/idiaenumsourcefiles.md)  
 Enumerates the various source files contained in the data source.  
  
 [IDiaEnumStackFrames](../debugger/idiaenumstackframes.md)  
 Enumerates the various stack frames available.  
  
 [IDiaEnumSymbols](../debugger/idiaenumsymbols.md)  
 Enumerates the various symbols contained in the data source.  
  
 [IDiaEnumSymbolsByAddr](../debugger/idiaenumsymbolsbyaddr.md)  
 Enumerates by address the various symbols contained in the data source.  
  
 [IDiaEnumTables](../debugger/idiaenumtables.md)  
 Enumerates the various tables contained in the data source.  
  
 [IDiaFrameData](../debugger/idiaframedata.md)  
 Exposes the details of a stack frame.  
  
 [IDiaImageData](../debugger/idiaimagedata.md)  
 Exposes the details of the base location and memory offsets of the module or image.  
  
 [IDiaInjectedSource](../debugger/idiainjectedsource.md)  
 Accesses the program source code stored in the DIA data source.  
  
 [IDiaLineNumber](../debugger/idialinenumber.md)  
 Accesses information that describes the process of mapping from a block of bytes of image text to a source file line number.  
  
 [IDiaLoadCallback](../debugger/idialoadcallback.md)  
 Receives callbacks from the DIA symbol locating procedure, thus enabling a user interface to report on the progress of the location attempt.  
  
 [IDiaLoadCallback2](../debugger/idialoadcallback2.md)  
 Receives callbacks from the DIA symbol locating procedure, allowing restrictions to be imposed on the locating process.  
  
 [IDiaPropertyStorage](../debugger/idiapropertystorage.md)  
 Allows you to read the persistent properties of a DIA property set.  
  
 [IDiaReadExeAtRVACallback](../debugger/idiareadexeatrvacallback.md)  
 Enables a client application to supply bytes of an executable file as specified by file position.  
  
 [IDiaReadExeAtOffsetCallback](../debugger/idiareadexeatoffsetcallback.md)  
 Enables a client application to supply bytes of an executable file as specified by a relative virtual address.  
  
 [IDiaSectionContrib](../debugger/idiasectioncontrib.md)  
 Retrieves data describing a section contribution, that is, a contiguous block of memory contributed to the image by a compiland.  
  
 [IDiaSegment](../debugger/idiasegment.md)  
 Maps data from the section number to segments of address space.  
  
 [IDiaSession](../debugger/idiasession.md)  
 Provides a query context for debug symbols.  
  
 [IDiaSourceFile](../debugger/idiasourcefile.md)  
 Represents a source file.  
  
 [IDiaStackFrame](../debugger/idiastackframe.md)  
 Exposes the properties of a stack frame.  
  
 [IDiaStackWalker](../debugger/idiastackwalker.md)  
 Provides methods to do a stack walk using the PDB file.  
  
 [IDiaStackWalkFrame](../debugger/idiastackwalkframe.md)  
 Maintains stack context between invocations of the [IDiaFrameData::execute](../debugger/idiaframedata--execute.md) method.  
  
 [IDiaStackWalkHelper](../debugger/idiastackwalkhelper.md)  
 Facilitates walking the stack using the program debug database (PDB) file.  
  
 [IDiaSymbol](../debugger/idiasymbol.md)  
 Describes the properties of a symbol instance.  
  
 [IDiaTable](../debugger/idiatable.md)  
 Enumerates a DIA data source table.  
  
## Related Sections  
 [Enumerations and Structures](../debugger/enumerations-and-structures.md)  
 Describes the enumerations and structures used by the various interfaces of the DIA SDK.  
  
 [Constants (Debug Interface Access SDK)](../debugger/constants--debug-interface-access-sdk-.md)  
 Describes the constants available in the DIA SDK.  
  
## See Also  
 [Reference](../debugger/debug-interface-access-sdk-reference.md)