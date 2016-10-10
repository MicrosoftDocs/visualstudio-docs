---
title: "IDiaSymbol"
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
ms.assetid: 01ad328a-736c-4933-a9f8-c2ded19ddd8c
caps.latest.revision: 30
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
# IDiaSymbol
Describes the properties of a symbol instance.  
  
## Syntax  
  
```  
IDiaSymbol : IUnknown  
```  
  
## Methods in Alphabetical Order  
 The following table shows the methods of `IDiaSymbol`.  
  
> [!NOTE]
>  Symbols will return meaningful data for only some of these methods, depending on the type of symbol. If a method returns `S_OK`, then that method has returned meaningful data.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaSymbol::findChildren](../VS_debugger/IDiaSymbol--findChildren.md)|Retrieves all children of the symbol.|  
|[IDiaSymbol::findChildrenEx](../VS_debugger/IDiaSymbol--findChildrenEx.md)|Retrieves the children of the symbol. This method is the extended version of [IDiaSymbol::findChildren](../VS_debugger/IDiaSymbol--findChildren.md).|  
|[IDiaSymbol::findChildrenExByAddr](../VS_debugger/IDiaSymbol--findChildrenExByAddr.md)|Retrieves the children of the symbol that are valid at a specified address.|  
|[IDiaSymbol::findChildrenExByRVA](../VS_debugger/IDiaSymbol--findChildrenExByRVA.md)|Retrieves the children of the symbol that are valid at a specified relative virtual address (RVA).|  
|[IDiaSymbol::findChildrenExByVA](../VS_debugger/IDiaSymbol--findChildrenExByVA.md)|Retrieves the children of the symbol that are valid at a specified virtual address.|  
|[IDiaSymbol::findInlineFramesByAddr](../VS_debugger/IDiaSymbol--findInlineFramesByAddr.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a given address.|  
|[IDiaSymbol::findInlineFramesByRVA](../VS_debugger/IDiaSymbol--findInlineFramesByRVA.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified relative virtual address (RVA).|  
|[IDiaSymbol::findInlineFramesByVA](../VS_debugger/IDiaSymbol--findInlineFramesByVA.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified virtual address (VA).|  
|[IDiaSymbol::findInlineeLines](../VS_debugger/IDiaSymbol--findInlineeLines.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol.|  
|[IDiaSymbol::findInlineeLinesByAddr](../VS_debugger/IDiaSymbol--findInlineeLinesByAddr.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified address range.|  
|[IDiaSymbol::findInlineeLinesByRVA](../VS_debugger/IDiaSymbol--findInlineeLinesByRVA.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified relative virtual address (RVA).|  
|[IDiaSymbol::findInlineeLinesByVA](../VS_debugger/IDiaSymbol--findInlineeLinesByVA.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified virtual address (VA).|  
|[IDiaSymbol::findSymbolsByRVAForAcceleratorPointerTag](../VS_debugger/IDiaSymbol--findSymbolsByRVAForAcceleratorPointerTag.md)|Given a corresponding tag value, this method returns an enumeration of symbols that are contained in this stub function at a specified relative virtual address.|  
|[IDiaSymbol::findSymbolsForAcceleratorPointerTag](../VS_debugger/IDiaSymbol--findSymbolsForAcceleratorPointerTag.md)|Returns the number of accelerator pointer tags in a C++ AMP stub function.|  
|[IDiaSymbol::get_acceleratorPointerTags](../VS_debugger/IDiaSymbol--get_acceleratorPointerTags.md)|Returns all accelerator pointer tag values that correspond to a C++ AMP accelerator stub function.|  
|[IDiaSymbol::get_access](../VS_debugger/IDiaSymbol--get_access.md)|Retrieves the access modifier of a class member.|  
|[IDiaSymbol::get_addressOffset](../VS_debugger/IDiaSymbol--get_addressOffset.md)|Retrieves the offset part of an address location.|  
|[IDiaSymbol::get_addressSection](../VS_debugger/IDiaSymbol--get_addressSection.md)|Retrieves the section part of an address location.|  
|[IDiaSymbol::get_addressTaken](../VS_debugger/IDiaSymbol--get_addressTaken.md)|Retrieves a flag indicating whether another symbol references this address.|  
|[IDiaSymbol::get_age](../VS_debugger/IDiaSymbol--get_age.md)|Retrieves the age value of a program database.|  
|[IDiaSymbol::get_arrayIndexType](../VS_debugger/IDiaSymbol--get_arrayIndexType.md)|Retrieves the symbol identifier of the array index type.|  
|[IDiaSymbol::get_arrayIndexTypeId](../VS_debugger/IDiaSymbol--get_arrayIndexTypeId.md)|Retrieves the array index type identifier of the symbol.|  
|[IDiaSymbol::get_backEndMajor](../VS_debugger/IDiaSymbol--get_backEndMajor.md)|Retrieves the back-end major version number.|  
|[IDiaSymbol::get_backEndMinor](../VS_debugger/IDiaSymbol--get_backEndMinor.md)|Retrieves the back-end minor version number.|  
|[IDiaSymbol::get_backEndBuild](../VS_debugger/IDiaSymbol--get_backEndBuild.md)|Retrieves the back-end build number.|  
|[IDiaSymbol::get_baseDataOffset](../VS_debugger/IDiaSymbol--get_baseDataOffset.md)|Retrieves the base data offset.|  
|[IDiaSymbol::get_baseDataSlot](../VS_debugger/IDiaSymbol--get_baseDataSlot.md)|Retrieves the base data slot.|  
|[IDiaSymbol::get_baseSymbol](../VS_debugger/IDiaSymbol--get_baseSymbol.md)|Retrieves the symbol from which the pointer is based.|  
|[IDiaSymbol::get_baseSymbolId](../VS_debugger/IDiaSymbol--get_baseSymbolId.md)|Retrieves the symbol ID from which the pointer is based.|  
|[IDiaSymbol::get_baseType](../VS_debugger/IDiaSymbol--get_baseType.md)|Retrieves the type tag of a simple type.|  
|[IDiaSymbol::get_bitPosition](../VS_debugger/IDiaSymbol--get_bitPosition.md)|Retrieves the bit position of a location.|  
|[IDiaSymbol::get_builtInKind](../VS_debugger/IDiaSymbol--get_builtInKind.md)|Retrieves a built-in kind of the HLSL type.|  
|[IDiaSymbol::get_callingConvention](../VS_debugger/IDiaSymbol--get_callingConvention.md)|Returns an indicator of a method's calling convention.|  
|[IDiaSymbol::get_classParent](../VS_debugger/IDiaSymbol--get_classParent.md)|Retrieves a reference to the class parent of the symbol.|  
|[IDiaSymbol::get_classParentId](../VS_debugger/IDiaSymbol--get_classParentId.md)|Retrieves the class parent identifier of the symbol.|  
|[IDiaSymbol::get_code](../VS_debugger/IDiaSymbol--get_code.md)|Retrieves a flag indicating whether the symbol refers to a code address.|  
|[IDiaSymbol::get_compilerGenerated](../VS_debugger/IDiaSymbol--get_compilerGenerated.md)|Retrieves a flag indicating whether the symbol was compiler-generated.|  
|[IDiaSymbol::get_compilerName](../VS_debugger/IDiaSymbol--get_compilerName.md)|Retrieves the name of the compiler used to create the [Compiland](../VS_debugger/Compiland.md).|  
|[IDiaSymbol::get_constructor](../VS_debugger/IDiaSymbol--get_constructor.md)|Retrieves a flag indicating whether the user-defined data type has a constructor.|  
|[IDiaSymbol::get_container](../VS_debugger/IDiaSymbol--get_container.md)|Retrieves the containing symbol of this symbol.|  
|[IDiaSymbol::get_constType](../VS_debugger/IDiaSymbol--get_constType.md)|Retrieves a flag indicating whether the user-defined data type is constant.|  
|[IDiaSymbol::get_count](../VS_debugger/IDiaSymbol--get_count.md)|Retrieves the number of items in a list or array.|  
|[IDiaSymbol::get_countLiveRanges](../VS_debugger/IDiaSymbol--get_countLiveRanges.md)|Retrieves the number of valid address ranges associated with the local symbol.|  
|[IDiaSymbol::get_customCallingConvention](../VS_debugger/IDiaSymbol--get_customCallingConvention.md)|Retrieves a flag indicating whether the function uses a custom calling convention.|  
|[IDiaSymbol::get_dataBytes](../VS_debugger/IDiaSymbol--get_dataBytes.md)|Retrieves the data bytes of an OEM symbol.|  
|[IDiaSymbol::get_dataKind](../VS_debugger/IDiaSymbol--get_dataKind.md)|Retrieves the variable classification of a data symbol.|  
|[IDiaSymbol::get_editAndContinueEnabled](../VS_debugger/IDiaSymbol--get_editAndContinueEnabled.md)|Retrieves the flag describing the Edit and Continue features of the compiled program or unit.|  
|[IDiaSymbol::get_farReturn](../VS_debugger/IDiaSymbol--get_farReturn.md)|Retrieves a flag indicating whether the function uses a far return.|  
|[IDiaSymbol::get_frontEndMajor](../VS_debugger/IDiaSymbol--get_frontEndMajor.md)|Retrieves the front-end major version number.|  
|[IDiaSymbol::get_frontEndMinor](../VS_debugger/IDiaSymbol--get_frontEndMinor.md)|Retrieves the front-end minor version number.|  
|[IDiaSymbol::get_frontEndBuild](../VS_debugger/IDiaSymbol--get_frontEndBuild.md)|Retrieves the front-end build number.|  
|[IDiaSymbol::get_function](../VS_debugger/IDiaSymbol--get_function.md)|Retrieves a flag indicating whether the public symbol refers to a function.|  
|[IDiaSymbol::get_guid](../VS_debugger/IDiaSymbol--get_guid.md)|Retrieves the symbol's GUID.|  
|[IDiaSymbol::get_hasAlloca](../VS_debugger/IDiaSymbol--get_hasAlloca.md)|Retrieves a flag indicating whether the function contains a call to `alloca`.|  
|[IDiaSymbol::get_hasAssignmentOperator](../VS_debugger/IDiaSymbol--get_hasAssignmentOperator.md)|Retrieves a flag indicating whether the user-defined data type has any assignment operators defined.|  
|[IDiaSymbol::get_hasCastOperator](../VS_debugger/IDiaSymbol--get_hasCastOperator.md)|Retrieves a flag indicating whether the user-defined data type has any cast operators defined.|  
|[IDiaSymbol::get_hasDebugInfo](../VS_debugger/IDiaSymbol--get_hasDebugInfo.md)|Retrieves a flag indicating whether the compiland contains any debugging information.|  
|[IDiaSymbol::get_hasEH](../VS_debugger/IDiaSymbol--get_hasEH.md)|Retrieves a flag indicating whether the function has a C++-style exception handler.|  
|[IDiaSymbol::get_hasEHa](../VS_debugger/IDiaSymbol--get_hasEHa.md)|Retrieves a flag indicating whether the function has an asynchronous exception handler.|  
|[IDiaSymbol::get_hasInlAsm](../VS_debugger/IDiaSymbol--get_hasInlAsm.md)|Retrieves a flag indicating whether the function has inline assembly.|  
|[IDiaSymbol::get_hasLongJump](../VS_debugger/IDiaSymbol--get_hasLongJump.md)|Retrieves a flag indicating whether the function contains a longjmp command (part of C-style exception handling).|  
|[IDiaSymbol::get_hasManagedCode](../VS_debugger/IDiaSymbol--get_hasManagedCode.md)|Retrieves a flag indicating whether the module contains managed code.|  
|[IDiaSymbol::get_hasNestedTypes](../VS_debugger/IDiaSymbol--get_hasNestedTypes.md)|Retrieves a flag indicating whether the user-defined data type has nested type definitions.|  
|[IDiaSymbol::get_hasSecurityChecks](../VS_debugger/IDiaSymbol--get_hasSecurityChecks.md)|Retrieves a flag indicating whether the function or compiland has security checks compiled in (via the [/GS (Buffer Security Check)](../Topic/-GS%20\(Buffer%20Security%20Check\).md) compiler switch).|  
|[IDiaSymbol::get_hasSEH](../VS_debugger/IDiaSymbol--get_hasSEH.md)|Retrieves a flag indicating whether the function has Win32-style Structured Exception Handling.|  
|[IDiaSymbol::get_hasSetJump](../VS_debugger/IDiaSymbol--get_hasSetJump.md)|Retrieves a flag indicating whether the function contains a setjmp command.|  
|[IDiaSymbol::get_indirectVirtualBaseClass](../VS_debugger/IDiaSymbol--get_indirectVirtualBaseClass.md)|Retrieves a flag indicating whether the user-defined data type is an indirect virtual base class.|  
|[IDiaSymbol::get_InlSpec](../VS_debugger/IDiaSymbol--get_InlSpec.md)|Retrieves a flag indicating whether the function has been marked with the inline attribute.|  
|[IDiaSymbol::get_interruptReturn](../VS_debugger/IDiaSymbol--get_interruptReturn.md)|Retrieves a flag indicating whether the function has a return from interrupt instruction.|  
|[IDiaSymbol::get_intro](../VS_debugger/IDiaSymbol--get_intro.md)|Retrieves a flag indicating whether the function is the base class virtual function.|  
|[IDiaSymbol::get_isAcceleratorGroupSharedLocal](../VS_debugger/IDiaSymbol--get_isAcceleratorGroupSharedLocal.md)|Retrieves a flag that indicates whether the symbol corresponds to a group shared local variable in code compiled for a C++ AMP Accelerator.|  
|[IDiaSymbol::get_isAcceleratorPointerTagLiveRange](../VS_debugger/IDiaSymbol--get_isAcceleratorPointerTagLiveRange.md)|Retrieves a flag that indicates whether the symbol corresponds to the *definition range symbol* for the tag component of a pointer variable in code compiled for a C++ AMP Accelerator. The definition range symbol is the location of a variable for a span of addresses.|  
|[IDiaSymbol::get_isAcceleratorStubFunction](../VS_debugger/IDiaSymbol--get_isAcceleratorStubFunction.md)|Indicates whether the symbol corresponds to a top-level function symbol for a shader compiled for an accelerator that corresponds to a `parallel_for_each` call.|  
|[IDiaSymbol::get_isAggregated](../VS_debugger/IDiaSymbol--get_isAggregated.md)|Retrieves a flag indicating whether the data is part of an aggregate of many symbols.|  
|[IDiaSymbol::get_isCTypes](../VS_debugger/IDiaSymbol--get_isCTypes.md)|Retrieves a flag indicating whether the symbol file contains C types.|  
|[IDiaSymbol::get_isCVTCIL](../VS_debugger/IDiaSymbol--get_isCVTCIL.md)|Retrieves a flag indicating whether the module was converted from Common Intermediate Language (CIL) to native code.|  
|[IDiaSymbol::get_isDataAligned](../VS_debugger/IDiaSymbol--get_isDataAligned.md)|Retrieves a flag indicating whether the elements of a user-defined data type are aligned to a specific boundary.|  
|[IDiaSymbol::get_isHLSLData](../VS_debugger/IDiaSymbol--get_isHLSLData.md)|Specifies whether this symbol represents High Level Shader Language (HLSL) data.|  
|[IDiaSymbol::get_isHotpatchable](../VS_debugger/IDiaSymbol--get_isHotpatchable.md)|Retrieves a flag indicating whether the module was compiled with the [/hotpatch (Create Hotpatchable Image)](../Topic/-hotpatch%20\(Create%20Hotpatchable%20Image\).md) compiler switch.|  
|[IDiaSymbol::get_isLTCG](../VS_debugger/IDiaSymbol--get_isLTCG.md)|Retrieves a flag indicating whether the managed compiland was linked with the linker's LTCG.|  
|[IDiaSymbol::get_isMatrixRowMajor](../VS_debugger/IDiaSymbol--get_isMatrixRowMajor.md)|Specifies whether the matrix is row major.|  
|[IDiaSymbol::get_isMSILNetmodule](../VS_debugger/IDiaSymbol--get_isMSILNetmodule.md)|Retrieves a flag indicating whether the managed compiland is a .netmodule (containing only metadata).|  
|[IDiaSymbol::get_isMultipleInheritance](../VS_debugger/IDiaSymbol--get_isMultipleInheritance.md)|Specifies whether the `this` pointer points to a data member with multiple inheritance.|  
|[IDiaSymbol::get_isNaked](../VS_debugger/IDiaSymbol--get_isNaked.md)|Retrieves a flag indicating whether the function has the [naked](../Topic/naked%20\(C++\).md) attribute.|  
|[IDiaSymbol::get_isOptimizedAway](../VS_debugger/IDiaSymbol--get_isOptimizedAway.md)|Specifies whether the variable is optimized away.|  
|[IDiaSymbol::get_isPointerBasedOnSymbolValue](../VS_debugger/IDiaSymbol--get_isPointerBasedOnSymbolValue.md)|Specifies whether the `this` pointer is based on a symbol value.|  
|[IDiaSymbol::get_isPointerToDataMember](../VS_debugger/IDiaSymbol--get_isPointerToDataMember.md)|Specifies whether this symbol is a pointer to a data member.|  
|[IDiaSymbol::get_isPointerToMemberFunction](../VS_debugger/IDiaSymbol--get_isPointerToMemberFunction.md)|Specifies whether this symbol is a pointer to a member function.|  
|[IDiaSymbol::get_isReturnValue](../VS_debugger/IDiaSymbol--get_isReturnValue.md)|Specifies whether the variable carries a return value.|  
|[IDiaSymbol::get_isSdl](../VS_debugger/IDiaSymbol--get_isSdl.md)|Specifies whether the module is compiled with the /SDL option.|  
|[IDiaSymbol::get_isSingleInheritance](../VS_debugger/IDiaSymbol--get_isSingleInheritance.md)|Specifies whether the `this` pointer points to a data member with single inheritance.|  
|[IDiaSymbol::get_isSplitted](../VS_debugger/IDiaSymbol--get_isSplitted.md)|Retrieves a flag indicating whether the data has been split into an aggregate of separate symbols.|  
|[IDiaSymbol::get_isStatic](../VS_debugger/IDiaSymbol--get_isStatic.md)|Retrieves a flag indicating whether a function or thunk layer is static.|  
|[IDiaSymbol::get_isStripped](../VS_debugger/IDiaSymbol--get_isStripped.md)|Retrieves a flag indicating whether private symbols have been stripped from the symbol file.|  
|[IDiaSymbol::get_isVirtualInheritance](../VS_debugger/IDiaSymbol--get_isVirtualInheritance.md)|Specifies whether the `this` pointer points to a data member with virtual inheritance.|  
|[IDiaSymbol::get_language](../VS_debugger/IDiaSymbol--get_language.md)|Retrieves the language of the source.|  
|[IDiaSymbol::get_length](../VS_debugger/IDiaSymbol--get_length.md)|Retrieves the number of bytes of memory used by the object represented by this symbol.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|Retrieves a reference to the lexical parent of the symbol.|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|Retrieves the lexical parent identifier of the symbol.|  
|[IDiaSymbol::get_libraryName](../VS_debugger/IDiaSymbol--get_libraryName.md)|Retrieves the file name of the library or object file from which the object was loaded.|  
|[IDiaSymbol::get_liveRangeLength](../VS_debugger/IDiaSymbol--get_liveRangeLength.md)|Returns the length of the address range in which the local symbol is valid.|  
|[IDiaSymbol::get_liveRangeStartAddressSection](../VS_debugger/IDiaSymbol--get_liveRangeStartAddressSection.md)|Returns the section part of the starting address range in which the local symbol is valid.|  
|[IDiaSymbol::get_liveRangeStartAddressOffset](../VS_debugger/IDiaSymbol--get_liveRangeStartAddressOffset.md)|Returns the offset part of the starting address range in which the local symbol is valid.|  
|[IDiaSymbol::get_liveRangeStartRelativeVirtualAddress](../VS_debugger/IDiaSymbol--get_liveRangeStartRelativeVirtualAddress.md)|Returns the start of the address range in which the local symbol is valid.|  
|[IDiaSymbol::get_locationType](../VS_debugger/IDiaSymbol--get_locationType.md)|Retrieves the location type of a data symbol.|  
|[IDiaSymbol::get_lowerBound](../VS_debugger/IDiaSymbol--get_lowerBound.md)|Retrieves the lower bound of a FORTRAN array dimension.|  
|[IDiaSymbol::get_lowerBoundId](../VS_debugger/IDiaSymbol--get_lowerBoundId.md)|Retrieves the symbol identifier of the lower bound of a FORTRAN array dimension.|  
|[IDiaSymbol::get_machineType](../VS_debugger/IDiaSymbol--get_machineType.md)|Retrieves the type of the target CPU.|  
|[IDiaSymbol::get_managed](../VS_debugger/IDiaSymbol--get_managed.md)|Retrieves a flag that indicating whether the symbol refers to managed code.|  
|[IDiaSymbol::get_memorySpaceKind](../VS_debugger/IDiaSymbol--get_memorySpaceKind.md)|Retrieves the memory space kind.|  
|[IDiaSymbol::get_msil](../VS_debugger/IDiaSymbol--get_msil.md)|Retrieves a flag indicating whether the symbol refers to Microsoft Intermediate Language (MSIL) code.|  
|[IDiaSymbol::get_name](../VS_debugger/IDiaSymbol--get_name.md)|Retrieves the name of the symbol.|  
|[IDiaSymbol::get_nested](../VS_debugger/IDiaSymbol--get_nested.md)|Retrieves a flag indicating whether the user-defined data type is nested.|  
|[IDiaSymbol::get_noInline](../VS_debugger/IDiaSymbol--get_noInline.md)|Retrieves a flag indicating whether the function is marked with the [noinline](../Topic/noinline.md) attribute.|  
|[IDiaSymbol::get_noReturn](../VS_debugger/IDiaSymbol--get_noReturn.md)|Retrieves a flag indicating whether the function has been declared with the [noreturn](../Topic/noreturn.md) attribute.|  
|[IDiaSymbol::get_noStackOrdering](../VS_debugger/IDiaSymbol--get_noStackOrdering.md)|Retrieves a flag indicating whether no stack ordering could be done as part of stack buffer checking.|  
|[IDiaSymbol::get_notReached](../VS_debugger/IDiaSymbol--get_notReached.md)|Retrieves a flag indicating whether the function or label is never reached.|  
|[IDiaSymbol::get_numberOfAcceleratorPointerTags](../VS_debugger/IDiaSymbol--get_numberOfAcceleratorPointerTags.md)|Returns the number of accelerator pointer tags in a C++ AMP stub function.|  
|[IDiaSymbol::get_numberOfModifiers](../VS_debugger/IDiaSymbol--get_numberOfModifiers.md)|Retrieves the number of modifiers that are applied to the original type.|  
|[IDiaSymbol::get_numberOfRegisterIndices](../VS_debugger/IDiaSymbol--get_numberOfRegisterIndices.md)|Retrieves the number of register indices.|  
|[IDiaSymbol::get_numberOfRows](../VS_debugger/IDiaSymbol--get_numberOfRows.md)|Retrieves the number of rows in the matrix.|  
|[IDiaSymbol::get_numberOfColumns](../VS_debugger/IDiaSymbol--get_numberOfColumns.md)|Retrieves the number of columns in the matrix.|  
|[IDiaSymbol::get_objectFileName](../VS_debugger/IDiaSymbol--get_objectFileName.md)|Retrieves the object file name.|  
|[IDiaSymbol::get_objectPointerType](../VS_debugger/IDiaSymbol--get_objectPointerType.md)|Retrieves the type of the object pointer for a class method.|  
|[IDiaSymbol::get_oemId](../VS_debugger/IDiaSymbol--get_oemId.md)|Retrieves the symbol's `oemId` value.|  
|[IDiaSymbol::get_oemSymbolId](../VS_debugger/IDiaSymbol--get_oemSymbolId.md)|Retrieves the symbol's `oemSymbolId` value.|  
|[IDiaSymbol::get_offset](../VS_debugger/IDiaSymbol--get_offset.md)|Retrieves the offset of the symbol location.|  
|[IDiaSymbol::get_optimizedCodeDebugInfo](../VS_debugger/IDiaSymbol--get_optimizedCodeDebugInfo.md)|Retrieves a flag indicating whether the function or label contains optimized code as well as debug information.|  
|[IDiaSymbol::get_overloadedOperator](../VS_debugger/IDiaSymbol--get_overloadedOperator.md)|Retrieves a flag indicating whether the user-defined data type has overloaded operators.|  
|[IDiaSymbol::get_packed](../VS_debugger/IDiaSymbol--get_packed.md)|Retrieves a flag indicating whether the user-defined data type is packed.|  
|[IDiaSymbol::get_platform](../VS_debugger/IDiaSymbol--get_platform.md)|Retrieves the platform type for which the program or compiland was compiled.|  
|[IDiaSymbol::get_pure](../VS_debugger/IDiaSymbol--get_pure.md)|Retrieves a flag that indicating whether the function is pure virtual.|  
|[IDiaSymbol::get_rank](../VS_debugger/IDiaSymbol--get_rank.md)|Retrieves the rank of a FORTRAN multidimensional array.|  
|[IDiaSymbol::get_reference](../VS_debugger/IDiaSymbol--get_reference.md)|Retrieves a flag indicating whether a pointer type is a reference.|  
|[IDiaSymbol::get_registerId](../VS_debugger/IDiaSymbol--get_registerId.md)|Retrieves the register designator of the location.|  
|[IDiaSymbol::get_registerType](../VS_debugger/IDiaSymbol--get_registerType.md)|Retrieves the register type.|  
|[IDiaSymbol::get_relativeVirtualAddress](../VS_debugger/IDiaSymbol--get_relativeVirtualAddress.md)|Retrieves the relative virtual address (RVA) of the location.|  
|[IDiaSymbol::get_restrictedType](../VS_debugger/IDiaSymbol--get_restrictedType.md)|Specifies whether the `this` pointer is flagged as restricted.|  
|[IDiaSymbol::get_samplerSlot](../VS_debugger/IDiaSymbol--get_samplerSlot.md)|Retrieves the sampler slot.|  
|[IDiaSymbol::get_scoped](../VS_debugger/IDiaSymbol--get_scoped.md)|Retrieves a flag indicating whether the user-defined data type appears in a nonglobal lexical scope.|  
|[IDiaSymbol::get_signature](../VS_debugger/IDiaSymbol--get_signature.md)|Retrieves the symbol's signature value.|  
|[IDiaSymbol::get_sizeInUdt](../VS_debugger/IDiaSymbol--get_sizeInUdt.md)|Retrieves the size of a member of a user-defined type.|  
|[IDiaSymbol::get_slot](../VS_debugger/IDiaSymbol--get_slot.md)|Retrieves the slot number of the location.|  
|[IDiaSymbol::get_sourceFileName](../VS_debugger/IDiaSymbol--get_sourceFileName.md)|Retrieves the file name of the source file.|  
|[IDiaSymbol::getSrcLineOnTypeDefn](../VS_debugger/IDiaSymbol--getSrcLineOnTypeDefn.md)|Retrieves the source file and line number that indicate where a specified user-defined type is defined.|  
|[IDiaSymbol::get_stride](../VS_debugger/IDiaSymbol--get_stride.md)|Retrieves the stride of the matrix or strided array.|  
|[IDiaSymbol::get_subType](../VS_debugger/IDiaSymbol--get_subType.md)|Retrieves the sub type.|  
|[IDiaSymbol::get_subTypeId](../VS_debugger/IDiaSymbol--get_subTypeId.md)|Retrieves the sub type ID.|  
|[IDiaSymbol::get_symbolsFileName](../VS_debugger/IDiaSymbol--get_symbolsFileName.md)|Retrieves the name of the file from which the symbols were loaded.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|Retrieves the unique symbol identifier.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|Retrieves the symbol type classifier.|  
|[IDiaSymbol::get_targetOffset](../VS_debugger/IDiaSymbol--get_targetOffset.md)|Retrieves the offset section of a thunk target.|  
|[IDiaSymbol::get_targetRelativeVirtualAddress](../VS_debugger/IDiaSymbol--get_targetRelativeVirtualAddress.md)|Retrieves the relative virtual address (RVA) of a thunk target.|  
|[IDiaSymbol::get_targetSection](../VS_debugger/IDiaSymbol--get_targetSection.md)|Retrieves the address section of a thunk target.|  
|[IDiaSymbol::get_targetVirtualAddress](../VS_debugger/IDiaSymbol--get_targetVirtualAddress.md)|Retrieves the virtual address (VA) of a thunk target.|  
|[IDiaSymbol::get_textureSlot](../VS_debugger/IDiaSymbol--get_textureSlot.md)|Retrieves the texture slot.|  
|[IDiaSymbol::get_thisAdjust](../VS_debugger/IDiaSymbol--get_thisAdjust.md)|Retrieves the logical `this` adjustor for the method.|  
|[IDiaSymbol::get_thunkOrdinal](../VS_debugger/IDiaSymbol--get_thunkOrdinal.md)|Retrieves the thunk type of a function.|  
|[IDiaSymbol::get_timeStamp](../VS_debugger/IDiaSymbol--get_timeStamp.md)|Retrieves the timestamp of the underlying executable file.|  
|[IDiaSymbol::get_token](../VS_debugger/IDiaSymbol--get_token.md)|Retrieves the metadata token of a managed function or variable.|  
|[IDiaSymbol::get_type](../VS_debugger/IDiaSymbol--get_type.md)|Retrieves a reference to the function signature.|  
|[IDiaSymbol::get_typeId](../VS_debugger/IDiaSymbol--get_typeId.md)|Retrieves the type identifier of the symbol.|  
|[IDiaSymbol::get_types](../VS_debugger/IDiaSymbol--get_types.md)|Retrieves an array of compiler-specific type values for this symbol.|  
|[IDiaSymbol::get_typeIds](../VS_debugger/IDiaSymbol--get_typeIds.md)|Retrieves an array of compiler-specific type identifier values for this symbol.|  
|[IDiaSymbol::get_uavSlot](../VS_debugger/IDiaSymbol--get_uavSlot.md)|Retrieves the uav slot.|  
|[IDiaSymbol::get_udtKind](../VS_debugger/IDiaSymbol--get_udtKind.md)|Retrieves the variety of a user-defined type (UDT).|  
|[IDiaSymbol::get_unalignedType](../VS_debugger/IDiaSymbol--get_unalignedType.md)|Retrieves a flag indicating whether the user-defined data type is unaligned.|  
|[IDiaSymbol::get_undecoratedName](../VS_debugger/IDiaSymbol--get_undecoratedName.md)|Retrieves the undecorated name for a C++ decorated, or linkage, name.|  
|[IDiaSymbol::get_undecoratedNameEx](../VS_debugger/IDiaSymbol--get_undecoratedNameEx.md)|Extension of the `get_undecoratedName` method that retrieves the undecorated name based on the value of an extension field.|  
|[IDiaSymbol::get_unmodifiedTypeId](../VS_debugger/IDiaSymbol--get_unmodifiedTypeId.md)|Retrieves the ID of the original (unmodified) type.|  
|[IDiaSymbol::get_upperBound](../VS_debugger/IDiaSymbol--get_upperBound.md)|Retrieves the upper bound of a FORTRAN array dimension.|  
|[IDiaSymbol::get_upperBoundId](../VS_debugger/IDiaSymbol--get_upperBoundId.md)|Retrieves the symbol identifier of the upper bound of a FORTRAN array dimension.|  
|[IDiaSymbol::get_value](../VS_debugger/IDiaSymbol--get_value.md)|Retrieves the value of a constant.|  
|[IDiaSymbol::get_virtual](../VS_debugger/IDiaSymbol--get_virtual.md)|Retrieves a flag indicating whether the function is virtual.|  
|[IDiaSymbol::get_virtualAddress](../VS_debugger/IDiaSymbol--get_virtualAddress.md)|Retrieves the virtual address (VA) of the location.|  
|[IDiaSymbol::get_virtualBaseClass](../VS_debugger/IDiaSymbol--get_virtualBaseClass.md)|Retrieves a flag indicating whether the user-defined data type is a virtual base class.|  
|[IDiaSymbol::get_virtualBaseDispIndex](../VS_debugger/IDiaSymbol--get_virtualBaseDispIndex.md)|Retrieves the index to the virtual base displacement table.|  
|[IDiaSymbol::get_virtualBaseOffset](../VS_debugger/IDiaSymbol--get_virtualBaseOffset.md)|Retrieves the offset in the virtual function table of a virtual function.|  
|[IDiaSymbol::get_virtualBasePointerOffset](../VS_debugger/IDiaSymbol--get_virtualBasePointerOffset.md)|Retrieves the offset of the virtual base pointer.|  
|[IDiaSymbol::get_virtualBaseTableType](../VS_debugger/IDiaSymbol--get_virtualBaseTableType.md)|Retrieves the type of a virtual base table pointer.|  
|[IDiaSymbol::get_virtualTableShape](../VS_debugger/IDiaSymbol--get_virtualTableShape.md)|Retrieves the symbol interface of the type of the virtual table for a user-defined type.|  
|[IDiaSymbol::get_virtualTableShapeId](../VS_debugger/IDiaSymbol--get_virtualTableShapeId.md)|Retrieves the virtual table shape identifier of the symbol.|  
|[IDiaSymbol::get_volatileType](../VS_debugger/IDiaSymbol--get_volatileType.md)|Retrieves a flag indicating whether the user-defined data type is volatile.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling one of the following methods:  
  
-   [IDiaEnumSymbols::Item](../VS_debugger/IDiaEnumSymbols--Item.md)  
  
-   [IDiaEnumSymbols::Next](../VS_debugger/IDiaEnumSymbols--Next.md)  
  
-   [IDiaEnumSymbolsByAddr::Next](../VS_debugger/IDiaEnumSymbolsByAddr--Next.md)  
  
-   [IDiaEnumSymbolsByAddr::Prev](../VS_debugger/IDiaEnumSymbolsByAddr--Prev.md)  
  
-   [IDiaEnumSymbolsByAddr::symbolByAddr](../VS_debugger/IDiaEnumSymbolsByAddr--symbolByAddr.md)  
  
-   [IDiaEnumSymbolsByAddr::symbolByRVA](../VS_debugger/IDiaEnumSymbolsByAddr--symbolByRVA.md)  
  
-   [IDiaEnumSymbolsByAddr::symbolByVA](../VS_debugger/IDiaEnumSymbolsByAddr--symbolByVA.md)  
  
-   [IDiaSession::findSymbolByAddr](../VS_debugger/IDiaSession--findSymbolByAddr.md)  
  
-   [IDiaSession::findSymbolByRVA](../VS_debugger/IDiaSession--findSymbolByRVA.md)  
  
-   [IDiaSession::findSymbolByRVAEx](../VS_debugger/IDiaSession--findSymbolByRVAEx.md)  
  
-   [IDiaSession::findSymbolByVA](../VS_debugger/IDiaSession--findSymbolByVA.md)  
  
-   [IDiaSession::findSymbolByVAEx](../VS_debugger/IDiaSession--findSymbolByVAEx.md)  
  
-   [IDiaSession::findSymbolByToken](../VS_debugger/IDiaSession--findSymbolByToken.md)  
  
-   [IDiaSession::symbolById](../VS_debugger/IDiaSession--symbolById.md)  
  
-   [IDiaStackWalkHelper::symbolForVA](../VS_debugger/IDiaStackWalkHelper--symbolForVA.md)  
  
-   [IDiaSymbol::get_types](../VS_debugger/IDiaSymbol--get_types.md)  
  
## Example  
 This example shows how to display the local variables for a function at a given relative virtual address. It also shows how symbols of different types are related to each other.  
  
> [!NOTE]
>  `CDiaBSTR` is a class that wraps a `BSTR` and automatically handles freeing the string when the instantiation goes out of scope.  
  
```cpp#  
void DumpLocalVars( DWORD rva, IDiaSession *pSession )  
{  
    CComPtr< IDiaSymbol > pBlock;  
    if ( FAILED( psession->findSymbolByRVA( rva, SymTagBlock, &pBlock ) ) )  
    {  
        Fatal( "Failed to find symbols by RVA" );  
    }  
    CComPtr< IDiaSymbol > pscope;  
    for ( ; pBlock != NULL; )  
    {  
        CComPtr< IDiaEnumSymbols > pEnum;  
        // local data search  
        if ( FAILED( pBlock->findChildren( SymTagNull, NULL, nsNone, &pEnum ) ) )  
        {  
            Fatal( "Local scope findChildren failed" );  
        }  
        CComPtr< IDiaSymbol > pSymbol;  
        DWORD tag;  
        DWORD celt;  
        while ( pEnum != NULL &&  
                SUCCEEDED( pEnum->Next( 1, &pSymbol, &celt ) ) &&  
                celt == 1)  
        {  
            pSymbol->get_symTag( &tag );  
            if ( tag == SymTagData )  
            {  
                CDiaBSTR name;  
                DWORD    kind;  
                pSymbol->get_name( &name );  
                pSymbol->get_dataKind( &kind );  
                if ( name != NULL )  
                    wprintf_s( L"\t%s (%s)\n", name, szDataKinds[ kind ] );  
            }  
            else if ( tag == SymTagAnnotation )  
            {  
                CComPtr< IDiaEnumSymbols > pValues;  
                // local data search  
                wprintf_s( L"\tAnnotation:\n" );  
                if ( FAILED( pSymbol->findChildren( SymTagNull, NULL, nsNone, &pValues ) ) )  
                    Fatal( "Annotation findChildren failed" );  
                pSymbol = NULL;  
                while ( pValues != NULL &&  
                        SUCCEEDED( pValues->Next( 1, &pSymbol, &celt ) ) &&  
                        celt == 1 )  
                {  
                    CComVariant value;  
                    if ( pSymbol->get_value( &value ) != S_OK )  
                        Fatal( "No value for annotation data." );  
                    wprintf_s( L"\t\t%ws\n", value.bstrVal );  
                    pSymbol = NULL;  
                }  
            }  
            pSymbol = NULL;  
        }  
        pBlock->get_symTag( &tag );   
        if ( tag == SymTagFunction )    // stop when at function scope  
            break;  
        // move to lexical parent  
        CComPtr< IDiaSymbol > pParent;  
        if ( SUCCEEDED( pBlock->get_lexicalParent( &pParent ) )  
            && pParent != NULL ) {  
            pBlock = pParent;  
        }  
        else  
        {  
            Fatal( "Finding lexical parent failed." );  
        }  
    };  
}  
```  
  
## Requirements  
 `Header:` Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaEnumSymbolsByAddr](../VS_debugger/IDiaEnumSymbolsByAddr.md)   
 [IDiaEnumSymbols](../VS_debugger/IDiaEnumSymbols.md)   
 [IDiaSession](../VS_debugger/IDiaSession.md)   
 [Class Hierarchy of Symbol Types](../VS_debugger/Class-Hierarchy-of-Symbol-Types.md)   
 [Symbols and Symbol Tags](../VS_debugger/Symbols-and-Symbol-Tags.md)   
 [Compiland](../VS_debugger/Compiland.md)