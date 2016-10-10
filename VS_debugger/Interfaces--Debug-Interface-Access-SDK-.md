---
title: "Interfaces (Debug Interface Access SDK)"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 62aee7c3-d314-4272-a32b-b2818f32fab8
caps.latest.revision: 16
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Interfaces (Debug Interface Access SDK)
Methods are listed alphabetically under each interface in the table of contents and on the interface page in Vtable order.  
  
## In This Section  
 [IDiaAddressMap](../VS_debugger/IDiaAddressMap.md)  
 Provides control over how the DIA SDK computes virtual and relative virtual addresses for debug objects.  
  
 [IDiaDataSource](../VS_debugger/IDiaDataSource.md)  
 Initiates access to a source of debugging symbols.  
  
 [IDiaEnumDebugStreamData](../VS_debugger/IDiaEnumDebugStreamData.md)  
 Provides access to the records in a debug data stream.  
  
 [IDiaEnumDebugStreams](../VS_debugger/IDiaEnumDebugStreams.md)  
 Enumerates the various debug streams contained in the data source.  
  
 [IDiaEnumFrameData](../VS_debugger/IDiaEnumFrameData.md)  
 Enumerates the various frame data elements contained in the data source.  
  
 [IDiaEnumInjectedSources](../VS_debugger/IDiaEnumInjectedSources.md)  
 Enumerate the various injected sources contained in the data source.  
  
 [IDiaEnumLineNumbers](../VS_debugger/IDiaEnumLineNumbers.md)  
 Enumerates the various line numbers contained in the data source.  
  
 [IDiaEnumSectionContribs](../VS_debugger/IDiaEnumSectionContribs.md)  
 Enumerates the various section contributions contained in the data source.  
  
 [IDiaEnumSegments](../VS_debugger/IDiaEnumSegments.md)  
 Enumerates the various segments contained in the data source.  
  
 [IDiaEnumSourceFiles](../VS_debugger/IDiaEnumSourceFiles.md)  
 Enumerates the various source files contained in the data source.  
  
 [IDiaEnumStackFrames](../VS_debugger/IDiaEnumStackFrames.md)  
 Enumerates the various stack frames available.  
  
 [IDiaEnumSymbols](../VS_debugger/IDiaEnumSymbols.md)  
 Enumerates the various symbols contained in the data source.  
  
 [IDiaEnumSymbolsByAddr](../VS_debugger/IDiaEnumSymbolsByAddr.md)  
 Enumerates by address the various symbols contained in the data source.  
  
 [IDiaEnumTables](../VS_debugger/IDiaEnumTables.md)  
 Enumerates the various tables contained in the data source.  
  
 [IDiaFrameData](../VS_debugger/IDiaFrameData.md)  
 Exposes the details of a stack frame.  
  
 [IDiaImageData](../VS_debugger/IDiaImageData.md)  
 Exposes the details of the base location and memory offsets of the module or image.  
  
 [IDiaInjectedSource](../VS_debugger/IDiaInjectedSource.md)  
 Accesses the program source code stored in the DIA data source.  
  
 [IDiaLineNumber](../VS_debugger/IDiaLineNumber.md)  
 Accesses information that describes the process of mapping from a block of bytes of image text to a source file line number.  
  
 [IDiaLoadCallback](../VS_debugger/IDiaLoadCallback.md)  
 Receives callbacks from the DIA symbol locating procedure, thus enabling a user interface to report on the progress of the location attempt.  
  
 [IDiaLoadCallback2](../VS_debugger/IDiaLoadCallback2.md)  
 Receives callbacks from the DIA symbol locating procedure, allowing restrictions to be imposed on the locating process.  
  
 [IDiaPropertyStorage](../VS_debugger/IDiaPropertyStorage.md)  
 Allows you to read the persistent properties of a DIA property set.  
  
 [IDiaReadExeAtRVACallback](../VS_debugger/IDiaReadExeAtRVACallback.md)  
 Enables a client application to supply bytes of an executable file as specified by file position.  
  
 [IDiaReadExeAtOffsetCallback](../VS_debugger/IDiaReadExeAtOffsetCallback.md)  
 Enables a client application to supply bytes of an executable file as specified by a relative virtual address.  
  
 [IDiaSectionContrib](../VS_debugger/IDiaSectionContrib.md)  
 Retrieves data describing a section contribution, that is, a contiguous block of memory contributed to the image by a compiland.  
  
 [IDiaSegment](../VS_debugger/IDiaSegment.md)  
 Maps data from the section number to segments of address space.  
  
 [IDiaSession](../VS_debugger/IDiaSession.md)  
 Provides a query context for debug symbols.  
  
 [IDiaSourceFile](../VS_debugger/IDiaSourceFile.md)  
 Represents a source file.  
  
 [IDiaStackFrame](../VS_debugger/IDiaStackFrame.md)  
 Exposes the properties of a stack frame.  
  
 [IDiaStackWalker](../VS_debugger/IDiaStackWalker.md)  
 Provides methods to do a stack walk using the PDB file.  
  
 [IDiaStackWalkFrame](../VS_debugger/IDiaStackWalkFrame.md)  
 Maintains stack context between invocations of the [IDiaFrameData::execute](../VS_debugger/IDiaFrameData--execute.md) method.  
  
 [IDiaStackWalkHelper](../VS_debugger/IDiaStackWalkHelper.md)  
 Facilitates walking the stack using the program debug database (PDB) file.  
  
 [IDiaSymbol](../VS_debugger/IDiaSymbol.md)  
 Describes the properties of a symbol instance.  
  
 [IDiaTable](../VS_debugger/IDiaTable.md)  
 Enumerates a DIA data source table.  
  
## Related Sections  
 [Enumerations and Structures](../VS_debugger/Enumerations-and-Structures.md)  
 Describes the enumerations and structures used by the various interfaces of the DIA SDK.  
  
 [Constants (Debug Interface Access SDK)](../VS_debugger/Constants--Debug-Interface-Access-SDK-.md)  
 Describes the constants available in the DIA SDK.  
  
## See Also  
 [Reference](../VS_debugger/Debug-Interface-Access-SDK-Reference.md)