---
description: "Describes the properties of a symbol instance."
title: "IDiaSymbol"
ms.date: "04/22/2025"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "IDiaSymbol interface"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
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
> Symbols will return meaningful data for only some of these methods, depending on the type of symbol. If a method returns `S_OK`, then that method has returned meaningful data. For a list of symbol types, see [Lexical Hierarchy of Symbol Types](../debug-interface-access/lexical-hierarchy-of-symbol-types.md).

|Method|Description|
|------------|-----------------|
|[`IDiaSymbol::findChildren`](../../debugger/debug-interface-access/idiasymbol-findchildren.md)|Retrieves all children of the symbol.|
|[`IDiaSymbol::findChildrenEx`](../../debugger/debug-interface-access/idiasymbol-findchildrenex.md)|Retrieves the children of the symbol. This method is the extended version of [IDiaSymbol::findChildren](../../debugger/debug-interface-access/idiasymbol-findchildren.md).|
|[`IDiaSymbol::findChildrenExByAddr`](../../debugger/debug-interface-access/idiasymbol-findchildrenexbyaddr.md)|Retrieves the children of the symbol that are valid at a specified address.|
|[`IDiaSymbol::findChildrenExByRVA`](../../debugger/debug-interface-access/idiasymbol-findchildrenexbyrva.md)|Retrieves the children of the symbol that are valid at a specified relative virtual address (RVA).|
|[`IDiaSymbol::findChildrenExByVA`](../../debugger/debug-interface-access/idiasymbol-findchildrenexbyva.md)|Retrieves the children of the symbol that are valid at a specified virtual address.|
|[`IDiaSymbol::findInlineeLines`](../../debugger/debug-interface-access/idiasymbol-findinlineelines.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol.|
|[`IDiaSymbol::findInlineeLinesByAddr`](../../debugger/debug-interface-access/idiasymbol-findinlineelinesbyaddr.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified address range.|
|[`IDiaSymbol::findInlineeLinesByRVA`](../../debugger/debug-interface-access/idiasymbol-findinlineelinesbyrva.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified relative virtual address (RVA).|
|[`IDiaSymbol::findInlineeLinesByVA`](../../debugger/debug-interface-access/idiasymbol-findinlineelinesbyva.md)|Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in this symbol within the specified virtual address (VA).|
|[`IDiaSymbol::findInlineFramesByAddr`](../../debugger/debug-interface-access/idiasymbol-findinlineframesbyaddr.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a given address.|
|[`IDiaSymbol::findInlineFramesByRVA`](../../debugger/debug-interface-access/idiasymbol-findinlineframesbyrva.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified relative virtual address (RVA).|
|[`IDiaSymbol::findInlineFramesByVA`](../../debugger/debug-interface-access/idiasymbol-findinlineframesbyva.md)|Retrieves an enumeration that allows a client to iterate through all of the inline frames on a specified virtual address (VA).|
|[`IDiaSymbol::findInputAssemblyFile`](../../debugger/debug-interface-access/idiasymbol-findinputassemblyfile.md)|Retrieves the .NET Native input assembly file that is the parent of the symbol.|
|[`IDiaSymbol::findSymbolsByRVAForAcceleratorPointerTag`](../../debugger/debug-interface-access/idiasymbol-findsymbolsbyrvaforacceleratorpointertag.md)|Given a corresponding tag value, this method returns an enumeration of symbols that are contained in this stub function at a specified relative virtual address.|
|[`IDiaSymbol::findSymbolsForAcceleratorPointerTag`](../../debugger/debug-interface-access/idiasymbol-findsymbolsforacceleratorpointertag.md)|Returns the number of accelerator pointer tags in a C++ AMP stub function.|
|[`IDiaSymbol::get_acceleratorPointerTags`](../../debugger/debug-interface-access/idiasymbol-get-acceleratorpointertags.md)|Returns all accelerator pointer tag values that correspond to a C++ AMP accelerator stub function.|
|[`IDiaSymbol::get_access`](../../debugger/debug-interface-access/idiasymbol-get-access.md)|Retrieves the access modifier of a class member.|
|[`IDiaSymbol::get_addressOffset`](../../debugger/debug-interface-access/idiasymbol-get-addressoffset.md)|Retrieves the offset part of an address location.|
|[`IDiaSymbol::get_addressSection`](../../debugger/debug-interface-access/idiasymbol-get-addresssection.md)|Retrieves the section part of an address location.|
|[`IDiaSymbol::get_addressTaken`](../../debugger/debug-interface-access/idiasymbol-get-addresstaken.md)|Retrieves a flag indicating whether another symbol references this address.|
|[`IDiaSymbol::get_age`](../../debugger/debug-interface-access/idiasymbol-get-age.md)|Retrieves the age value of a program database.|
|[`IDiaSymbol::get_arrayIndexType`](../../debugger/debug-interface-access/idiasymbol-get-arrayindextype.md)|Retrieves the symbol identifier of the array index type.|
|[`IDiaSymbol::get_arrayIndexTypeId`](../../debugger/debug-interface-access/idiasymbol-get-arrayindextypeid.md)|Retrieves the array index type identifier of the symbol.|
|[`IDiaSymbol::get_backEndBuild`](../../debugger/debug-interface-access/idiasymbol-get-backendbuild.md)|Retrieves the back-end build number.|
|[`IDiaSymbol::get_backEndMajor`](../../debugger/debug-interface-access/idiasymbol-get-backendmajor.md)|Retrieves the back-end major version number.|
|[`IDiaSymbol::get_backEndMinor`](../../debugger/debug-interface-access/idiasymbol-get-backendminor.md)|Retrieves the back-end minor version number.|
|[`IDiaSymbol::get_backEndQFE`](../../debugger/debug-interface-access/idiasymbol-get-backendqfe.md)|Retrieves the back-end qfe number.|
|[`IDiaSymbol::get_baseDataOffset`](../../debugger/debug-interface-access/idiasymbol-get-basedataoffset.md)|Retrieves the base data offset.|
|[`IDiaSymbol::get_baseDataSlot`](../../debugger/debug-interface-access/idiasymbol-get-basedataslot.md)|Retrieves the base data slot.|
|[`IDiaSymbol::get_baseSymbol`](../../debugger/debug-interface-access/idiasymbol-get-basesymbol.md)|Retrieves the symbol from which the pointer is based.|
|[`IDiaSymbol::get_baseSymbolId`](../../debugger/debug-interface-access/idiasymbol-get-basesymbolid.md)|Retrieves the symbol ID from which the pointer is based.|
|[`IDiaSymbol::get_baseType`](../../debugger/debug-interface-access/idiasymbol-get-basetype.md)|Retrieves the type tag of a simple type.|
|[`IDiaSymbol::get_bindID`](../../debugger/debug-interface-access/idiasymbol-get-bindid.md)|Retrieves the binding register index.|
|[`IDiaSymbol::get_bindSlot`](../../debugger/debug-interface-access/idiasymbol-get-bindslot.md)|Retrieves the lower bound in binding space.|
|[`IDiaSymbol::get_bindSpace`](../../debugger/debug-interface-access/idiasymbol-get-bindspace.md)|Retrieves the binding space.|
|[`IDiaSymbol::get_bitPosition`](../../debugger/debug-interface-access/idiasymbol-get-bitposition.md)|Retrieves the bit position of a location.|
|[`IDiaSymbol::get_builtInKind`](../../debugger/debug-interface-access/idiasymbol-get-builtinkind.md)|Retrieves a built-in kind of the HLSL type.|
|[`IDiaSymbol::get_callingConvention`](../../debugger/debug-interface-access/idiasymbol-get-callingconvention.md)|Returns an indicator of a method's calling convention.|
|[`IDiaSymbol::get_characteristics`](../../debugger/debug-interface-access/idiasymbol-get-characteristics.md)|Retrieves the characteristics of this COFF section.|
|[`IDiaSymbol::get_classParent`](../../debugger/debug-interface-access/idiasymbol-get-classparent.md)|Retrieves a reference to the class parent of the symbol.|
|[`IDiaSymbol::get_classParentId`](../../debugger/debug-interface-access/idiasymbol-get-classparentid.md)|Retrieves the class parent identifier of the symbol.|
|[`IDiaSymbol::get_code`](../../debugger/debug-interface-access/idiasymbol-get-code.md)|Retrieves a flag indicating whether the symbol refers to a code address.|
|[`IDiaSymbol::get_coffGroup`](../../debugger/debug-interface-access/idiasymbol-get-coffgroup.md)|Retrieves the COFF group symbol this symbol comes from.|
|[`IDiaSymbol::get_compilerGenerated`](../../debugger/debug-interface-access/idiasymbol-get-compilergenerated.md)|Retrieves a flag indicating whether the symbol was compiler-generated.|
|[`IDiaSymbol::get_compilerName`](../../debugger/debug-interface-access/idiasymbol-get-compilername.md)|Retrieves the name of the compiler used to create the [Compiland](../../debugger/debug-interface-access/compiland.md).|
|[`IDiaSymbol::get_constantExport`](../../debugger/debug-interface-access/idiasymbol-get-constantexport.md)|Retrieves a flag indicating whether this export is CONSTANT.|
|[`IDiaSymbol::get_constructor`](../../debugger/debug-interface-access/idiasymbol-get-constructor.md)|Retrieves a flag indicating whether the user-defined data type has a constructor.|
|[`IDiaSymbol::get_constType`](../../debugger/debug-interface-access/idiasymbol-get-consttype.md)|Retrieves a flag indicating whether the user-defined data type is constant.|
|[`IDiaSymbol::get_container`](../../debugger/debug-interface-access/idiasymbol-get-container.md)|Retrieves the containing symbol of this symbol.|
|[`IDiaSymbol::get_count`](../../debugger/debug-interface-access/idiasymbol-get-count.md)|Retrieves the number of items in a list or array.|
|[`IDiaSymbol::get_countLiveRanges`](../../debugger/debug-interface-access/idiasymbol-get-countliveranges.md)|Retrieves the number of valid address ranges associated with the local symbol.|
|[`IDiaSymbol::get_customCallingConvention`](../../debugger/debug-interface-access/idiasymbol-get-customcallingconvention.md)|Retrieves a flag indicating whether the function uses a custom calling convention.|
|[`IDiaSymbol::get_dataBytes`](../../debugger/debug-interface-access/idiasymbol-get-databytes.md)|Retrieves the data bytes of an OEM symbol.|
|[`IDiaSymbol::get_dataExport`](../../debugger/debug-interface-access/idiasymbol-get-dataexport.md)|Retrieves a flag indicating whether this export is DATA.|
|[`IDiaSymbol::get_dataKind`](../../debugger/debug-interface-access/idiasymbol-get-datakind.md)|Retrieves the variable classification of a data symbol.|
|[`IDiaSymbol::get_editAndContinueEnabled`](../../debugger/debug-interface-access/idiasymbol-get-editandcontinueenabled.md)|Retrieves the flag describing the Edit and Continue features of the compiled program or unit.|
|[`IDiaSymbol::get_exceptionHandlerAddressOffset`](../../debugger/debug-interface-access/idiasymbol-get-exceptionhandleraddressoffset.md)|Retrieves the section offset of the exception handler.|
|[`IDiaSymbol::get_exceptionHandlerAddressSection`](../../debugger/debug-interface-access/idiasymbol-get-exceptionhandleraddresssection.md)|Retrieves the section number of the exception handler.|
|[`IDiaSymbol::get_exceptionHandlerRelativeVirtualAddress`](../../debugger/debug-interface-access/idiasymbol-get-exceptionhandlerrelativevirtualaddress.md)|Retrieves the relative virtual address of the exception handler.|
|[`IDiaSymbol::get_exceptionHandlerVirtualAddress`](../../debugger/debug-interface-access/idiasymbol-get-exceptionhandlervirtualaddress.md)|Retrieves the virtual address of the exception handler.|
|[`IDiaSymbol::get_exportHasExplicitlyAssignedOrdinal`](../../debugger/debug-interface-access/idiasymbol-get-exporthasexplicitlyassignedordinal.md)|Retrieves a flag indicating whether this export has an explicitly assigned ordinal.|
|[`IDiaSymbol::get_exportIsForwarder`](../../debugger/debug-interface-access/idiasymbol-get-exportisforwarder.md)|Retrieves a flag indicating whether this export is a forwarder.|
|[`IDiaSymbol::get_farReturn`](../../debugger/debug-interface-access/idiasymbol-get-farreturn.md)|Retrieves a flag indicating whether the function uses a far return.|
|[`IDiaSymbol::get_finalLiveStaticSize`](../../debugger/debug-interface-access/idiasymbol-get-finallivestaticsize.md)|Retrieves the final static size of live function, after inlining.|
|[`IDiaSymbol::get_framePointerPresent`](../../debugger/debug-interface-access/idiasymbol-get-framepointerpresent.md)|Retrieves a flag indicating whether this function has a frame pointer.|
|[`IDiaSymbol::get_frameSize`](../../debugger/debug-interface-access/idiasymbol-get-framesize.md)|Retrieves the frame size.|
|[`IDiaSymbol::get_frontEndBuild`](../../debugger/debug-interface-access/idiasymbol-get-frontendbuild.md)|Retrieves the front-end build number.|
|[`IDiaSymbol::get_frontEndMajor`](../../debugger/debug-interface-access/idiasymbol-get-frontendmajor.md)|Retrieves the front-end major version number.|
|[`IDiaSymbol::get_frontEndMinor`](../../debugger/debug-interface-access/idiasymbol-get-frontendminor.md)|Retrieves the front-end minor version number.|
|[`IDiaSymbol::get_frontEndQFE`](../../debugger/debug-interface-access/idiasymbol-get-frontendqfe.md)|Retrieves the front-end QFE version number.|
|[`IDiaSymbol::get_function`](../../debugger/debug-interface-access/idiasymbol-get-function.md)|Retrieves a flag indicating whether the public symbol refers to a function.|
|[`IDiaSymbol::get_guid`](../../debugger/debug-interface-access/idiasymbol-get-guid.md)|Retrieves the symbol's GUID.|
|[`IDiaSymbol::get_hasAlloca`](../../debugger/debug-interface-access/idiasymbol-get-hasalloca.md)|Retrieves a flag indicating whether the function contains a call to `alloca`.|
|[`IDiaSymbol::get_hasAssignmentOperator`](../../debugger/debug-interface-access/idiasymbol-get-hasassignmentoperator.md)|Retrieves a flag indicating whether the user-defined data type has any assignment operators defined.|
|[`IDiaSymbol::get_hasCastOperator`](../../debugger/debug-interface-access/idiasymbol-get-hascastoperator.md)|Retrieves a flag indicating whether the user-defined data type has any cast operators defined.|
|[`IDiaSymbol::get_hasControlFlowCheck`](../../debugger/debug-interface-access/idiasymbol-get-hascontrolflowcheck.md)|Retrieves a flag indicating whether this function contains control flow checks.|
|[`IDiaSymbol::get_hasDebugInfo`](../../debugger/debug-interface-access/idiasymbol-get-hasdebuginfo.md)|Retrieves a flag indicating whether the compiland contains any debugging information.|
|[`IDiaSymbol::get_hasEH`](../../debugger/debug-interface-access/idiasymbol-get-haseh.md)|Retrieves a flag indicating whether the function has a C++-style exception handler.|
|[`IDiaSymbol::get_hasEHa`](../../debugger/debug-interface-access/idiasymbol-get-haseha.md)|Retrieves a flag indicating whether the function has an asynchronous exception handler.|
|[`IDiaSymbol::get_hasInlAsm`](../../debugger/debug-interface-access/idiasymbol-get-hasinlasm.md)|Retrieves a flag indicating whether the function has inline assembly.|
|[`IDiaSymbol::get_hasLongJump`](../../debugger/debug-interface-access/idiasymbol-get-haslongjump.md)|Retrieves a flag indicating whether the function contains a longjmp command (part of C-style exception handling).|
|[`IDiaSymbol::get_hasManagedCode`](../../debugger/debug-interface-access/idiasymbol-get-hasmanagedcode.md)|Retrieves a flag indicating whether the module contains managed code.|
|[`IDiaSymbol::get_hasNestedTypes`](../../debugger/debug-interface-access/idiasymbol-get-hasnestedtypes.md)|Retrieves a flag indicating whether the user-defined data type has nested type definitions.|
|[`IDiaSymbol::get_hasSecurityChecks`](../../debugger/debug-interface-access/idiasymbol-get-hassecuritychecks.md)|Retrieves a flag indicating whether the function or compiland has security checks compiled in (via the [/GS (Buffer Security Check)](/cpp/build/reference/gs-buffer-security-check) compiler switch).|
|[`IDiaSymbol::get_hasSEH`](../../debugger/debug-interface-access/idiasymbol-get-hasseh.md)|Retrieves a flag indicating whether the function has Win32-style Structured Exception Handling.|
|[`IDiaSymbol::get_hasSetJump`](../../debugger/debug-interface-access/idiasymbol-get-hassetjump.md)|Retrieves a flag indicating whether the function contains a setjmp command.|
|[`IDiaSymbol::get_hasValidPGOCounts`](../../debugger/debug-interface-access/idiasymbol-get-hasvalidpgocounts.md)|Retrieves a flag indicating whether this symbols has valid PGO counts.|
|[`IDiaSymbol::get_hfaDouble`](../../debugger/debug-interface-access/idiasymbol-get-hfadouble.md)|Retrieves a flag that specifies whether a user-defined type (UDT) contains homogeneous floating-point aggregate (HFA) data of type double.|
|[`IDiaSymbol::get_hfaFloat`](../../debugger/debug-interface-access/idiasymbol-get-hfafloat.md)|Retrieves a flag that specifies whether a user-defined type (UDT) contains homogeneous floating-point aggregate (HFA) data of type float.|
|[`IDiaSymbol::get_indirectVirtualBaseClass`](../../debugger/debug-interface-access/idiasymbol-get-indirectvirtualbaseclass.md)|Retrieves a flag indicating whether the user-defined data type is an indirect virtual base class.|
|[`IDiaSymbol::get_InlSpec`](../../debugger/debug-interface-access/idiasymbol-get-inlspec.md)|Retrieves a flag indicating whether the function has been marked with the inline attribute.|
|[`IDiaSymbol::get_interruptReturn`](../../debugger/debug-interface-access/idiasymbol-get-interruptreturn.md)|Retrieves a flag indicating whether the function has a return from interrupt instruction.|
|[`IDiaSymbol::get_intrinsic`](../../debugger/debug-interface-access/idiasymbol-get-intrinsic.md)|Retrieves a flag that specifies whether a class is an intrinsic type.|
|[`IDiaSymbol::get_intro`](../../debugger/debug-interface-access/idiasymbol-get-intro.md)|Retrieves a flag indicating whether the function is the base class virtual function.|
|[`IDiaSymbol::get_isAcceleratorGroupSharedLocal`](../../debugger/debug-interface-access/idiasymbol-get-isacceleratorgroupsharedlocal.md)|Retrieves a flag that indicates whether the symbol corresponds to a group shared local variable in code compiled for a C++ AMP Accelerator.|
|[`IDiaSymbol::get_isAcceleratorPointerTagLiveRange`](../../debugger/debug-interface-access/idiasymbol-get-isacceleratorpointertagliverange.md)|Retrieves a flag that indicates whether the symbol corresponds to the *definition range symbol* for the tag component of a pointer variable in code compiled for a C++ AMP Accelerator. The definition range symbol is the location of a variable for a span of addresses.|
|[`IDiaSymbol::get_isAcceleratorStubFunction`](../../debugger/debug-interface-access/idiasymbol-get-isacceleratorstubfunction.md)|Indicates whether the symbol corresponds to a top-level function symbol for a shader compiled for an accelerator that corresponds to a `parallel_for_each` call.|
|[`IDiaSymbol::get_isAggregated`](../../debugger/debug-interface-access/idiasymbol-get-isaggregated.md)|Retrieves a flag indicating whether the data is part of an aggregate of many symbols.|
|[`IDiaSymbol::get_isConstructorVirtualBase`](../../debugger/debug-interface-access/idiasymbol-get-isconstructorvirtualbase.md)|Retrieves a flag indicating whether this is an instance constructor of a class with virtual base.|
|[`IDiaSymbol::get_isCTypes`](../../debugger/debug-interface-access/idiasymbol-get-isctypes.md)|Retrieves a flag indicating whether the symbol file contains C types.|
|[`IDiaSymbol::get_isCVTCIL`](../../debugger/debug-interface-access/idiasymbol-get-iscvtcil.md)|Retrieves a flag indicating whether the module was converted from Common Intermediate Language (CIL) to native code.|
|[`IDiaSymbol::get_isCxxReturnUdt`](../../debugger/debug-interface-access/idiasymbol-get-iscxxreturnudt.md)|Retrieves a flag indicating whether return C++ style UDT.|
|[`IDiaSymbol::get_isDataAligned`](../../debugger/debug-interface-access/idiasymbol-get-isdataaligned.md)|Retrieves a flag indicating whether the elements of a user-defined data type are aligned to a specific boundary.|
|[`IDiaSymbol::get_isHLSLData`](../../debugger/debug-interface-access/idiasymbol-get-ishlsldata.md)|Specifies whether this symbol represents High Level Shader Language (HLSL) data.|
|[`IDiaSymbol::get_isHotpatchable`](../../debugger/debug-interface-access/idiasymbol-get-ishotpatchable.md)|Retrieves a flag indicating whether the module was compiled with the [/hotpatch (Create Hotpatchable Image)](/cpp/build/reference/hotpatch-create-hotpatchable-image) compiler switch.|
|[`IDiaSymbol::get_isInterfaceUdt`](../../debugger/debug-interface-access/idiasymbol-get-isinterfaceudt.md)|Retrieves a flag indicating whether the type is a WinRT interface user-defined type (UDT).|
|[`IDiaSymbol::get_isLocationControlFlowDependent`](../../debugger/debug-interface-access/idiasymbol-get-islocationcontrolflowdependent.md)|Retrieves a flag indicating whether a local symbol's location liveness is dependent upon the control flow of the function.|
|[`IDiaSymbol::get_isLTCG`](../../debugger/debug-interface-access/idiasymbol-get-isltcg.md)|Retrieves a flag indicating whether the managed compiland was linked with the linker's LTCG.|
|[`IDiaSymbol::get_isMatrixRowMajor`](../../debugger/debug-interface-access/idiasymbol-get-ismatrixrowmajor.md)|Specifies whether the matrix is row major.|
|[`IDiaSymbol::get_isMSILNetmodule`](../../debugger/debug-interface-access/idiasymbol-get-ismsilnetmodule.md)|Retrieves a flag indicating whether the managed compiland is a .netmodule (containing only metadata).|
|[`IDiaSymbol::get_isMultipleInheritance`](../../debugger/debug-interface-access/idiasymbol-get-ismultipleinheritance.md)|Specifies whether the `this` pointer points to a data member with multiple inheritance.|
|[`IDiaSymbol::get_isNaked`](../../debugger/debug-interface-access/idiasymbol-get-isnaked.md)|Retrieves a flag indicating whether the function has the [naked](/cpp/cpp/naked-cpp) attribute.|
|[`IDiaSymbol::get_isOptimizedAway`](../../debugger/debug-interface-access/idiasymbol-get-isoptimizedaway.md)|Specifies whether the variable is optimized away.|
|[`IDiaSymbol::get_isOptimizedForSpeed`](../../debugger/debug-interface-access/idiasymbol-get-isoptimizedforspeed.md)|Retrieves a flag indicating whether the function is optimized for speed.|
|[`IDiaSymbol::get_isPGO`](../../debugger/debug-interface-access/idiasymbol-get-ispgo.md)|Retrieves a flag indicating whether PGO was enabled.|
|[`IDiaSymbol::get_isPointerBasedOnSymbolValue`](../../debugger/debug-interface-access/idiasymbol-get-ispointerbasedonsymbolvalue.md)|Specifies whether the `this` pointer is based on a symbol value.|
|[`IDiaSymbol::get_isPointerToDataMember`](../../debugger/debug-interface-access/idiasymbol-get-ispointertodatamember.md)|Specifies whether this symbol is a pointer to a data member.|
|[`IDiaSymbol::get_isPointerToMemberFunction`](../../debugger/debug-interface-access/idiasymbol-get-ispointertomemberfunction.md)|Specifies whether this symbol is a pointer to a member function.|
|[`IDiaSymbol::get_isRefUdt`](../../debugger/debug-interface-access/idiasymbol-get-isrefudt.md)|Retrieves a flag indicating whether this is a WinRT reference user-defined type (UDT).|
|[`IDiaSymbol::get_isReturnValue`](../../debugger/debug-interface-access/idiasymbol-get-isreturnvalue.md)|Specifies whether the variable carries a return value.|
|[`IDiaSymbol::get_isSafeBuffers`](../../debugger/debug-interface-access/idiasymbol-get-issafebuffers.md)|Retrieves a flag that specifies whether the preprocesser directive for a safe buffer is used.|
|[`IDiaSymbol::get_isSdl`](../../debugger/debug-interface-access/idiasymbol-get-issdl.md)|Specifies whether the module is compiled with the /SDL option.|
|[`IDiaSymbol::get_isSingleInheritance`](../../debugger/debug-interface-access/idiasymbol-get-issingleinheritance.md)|Specifies whether the `this` pointer points to a data member with single inheritance.|
|[`IDiaSymbol::get_isSplitted`](../../debugger/debug-interface-access/idiasymbol-get-issplitted.md)|Retrieves a flag indicating whether the data has been split into an aggregate of separate symbols.|
|[`IDiaSymbol::get_isStatic`](../../debugger/debug-interface-access/idiasymbol-get-isstatic.md)|Retrieves a flag indicating whether a function or thunk layer is static.|
|[`IDiaSymbol::get_isStripped`](../../debugger/debug-interface-access/idiasymbol-get-isstripped.md)|Retrieves a flag indicating whether private symbols have been stripped from the symbol file.|
|[`IDiaSymbol::get_isValueUdt`](../../debugger/debug-interface-access/idiasymbol-get-isvalueudt.md)|Retrieves a flag indicating whether this is a WinRT value user-defined type (UDT).|
|[`IDiaSymbol::get_isVirtualInheritance`](../../debugger/debug-interface-access/idiasymbol-get-isvirtualinheritance.md)|Specifies whether the `this` pointer points to a data member with virtual inheritance.|
|[`IDiaSymbol::get_isWinRTPointer`](../../debugger/debug-interface-access/idiasymbol-get-iswinrtpointer.md)|Retrieves a flag indicating whether this is a WinRT pointer type.|
|[`IDiaSymbol::get_language`](../../debugger/debug-interface-access/idiasymbol-get-language.md)|Retrieves the language of the source.|
|[`IDiaSymbol::get_length`](../../debugger/debug-interface-access/idiasymbol-get-length.md)|Retrieves the number of bytes of memory used by the object represented by this symbol.|
|[`IDiaSymbol::get_lexicalParent`](../../debugger/debug-interface-access/idiasymbol-get-lexicalparent.md)|Retrieves a reference to the lexical parent of the symbol.|
|[`IDiaSymbol::get_lexicalParentId`](../../debugger/debug-interface-access/idiasymbol-get-lexicalparentid.md)|Retrieves the lexical parent identifier of the symbol.|
|[`IDiaSymbol::get_libraryName`](../../debugger/debug-interface-access/idiasymbol-get-libraryname.md)|Retrieves the file name of the library or object file from which the object was loaded.|
|[`IDiaSymbol::get_liveRangeLength`](../../debugger/debug-interface-access/idiasymbol-get-liverangelength.md)|Returns the length of the address range in which the local symbol is valid.|
|[`IDiaSymbol::get_liveRangeStartAddressOffset`](../../debugger/debug-interface-access/idiasymbol-get-liverangestartaddressoffset.md)|Returns the offset part of the starting address range in which the local symbol is valid.|
|[`IDiaSymbol::get_liveRangeStartAddressSection`](../../debugger/debug-interface-access/idiasymbol-get-liverangestartaddresssection.md)|Returns the section part of the starting address range in which the local symbol is valid.|
|[`IDiaSymbol::get_liveRangeStartRelativeVirtualAddress`](../../debugger/debug-interface-access/idiasymbol-get-liverangestartrelativevirtualaddress.md)|Returns the start of the address range in which the local symbol is valid.|
|[`IDiaSymbol::get_localBasePointerRegisterId`](../../debugger/debug-interface-access/idiasymbol-get-localbasepointerregisterid.md)|Retrieves the register designator of the register holding base pointer to locals.|
|[`IDiaSymbol::get_locationType`](../../debugger/debug-interface-access/idiasymbol-get-locationtype.md)|Retrieves the location type of a data symbol.|
|[`IDiaSymbol::get_lowerBound`](../../debugger/debug-interface-access/idiasymbol-get-lowerbound.md)|Retrieves the lower bound of a FORTRAN array dimension.|
|[`IDiaSymbol::get_lowerBoundId`](../../debugger/debug-interface-access/idiasymbol-get-lowerboundid.md)|Retrieves the symbol identifier of the lower bound of a FORTRAN array dimension.|
|[`IDiaSymbol::get_machineType`](../../debugger/debug-interface-access/idiasymbol-get-machinetype.md)|Retrieves the type of the target CPU.|
|[`IDiaSymbol::get_managed`](../../debugger/debug-interface-access/idiasymbol-get-managed.md)|Retrieves a flag that indicating whether the symbol refers to managed code.|
|[`IDiaSymbol::get_memorySpaceKind`](../../debugger/debug-interface-access/idiasymbol-get-memoryspacekind.md)|Retrieves the memory space kind.|
|[`IDiaSymbol::get_modifierValues`](../../debugger/debug-interface-access/idiasymbol-get-modifiervalues.md)|Retrieves the set of modifiers for this symbol.|
|[`IDiaSymbol::get_msil`](../../debugger/debug-interface-access/idiasymbol-get-msil.md)|Retrieves a flag indicating whether the symbol refers to Microsoft Intermediate Language (MSIL) code.|
|[`IDiaSymbol::get_name`](../../debugger/debug-interface-access/idiasymbol-get-name.md)|Retrieves the name of the symbol.|
|[`IDiaSymbol::get_nested`](../../debugger/debug-interface-access/idiasymbol-get-nested.md)|Retrieves a flag indicating whether the user-defined data type is nested.|
|[`IDiaSymbol::get_noInline`](../../debugger/debug-interface-access/idiasymbol-get-noinline.md)|Retrieves a flag indicating whether the function is marked with the [`noinline`](/cpp/cpp/noinline) attribute.|
|[`IDiaSymbol::get_noNameExport`](../../debugger/debug-interface-access/idiasymbol-get-nonameexport.md)|Retrieves a flag indicating whether this export is `NONAME`.|
|[`IDiaSymbol::get_noReturn`](../../debugger/debug-interface-access/idiasymbol-get-noreturn.md)|Retrieves a flag indicating whether the function has been declared with the [noreturn](/cpp/cpp/noreturn) attribute.|
|[`IDiaSymbol::get_noStackOrdering`](../../debugger/debug-interface-access/idiasymbol-get-nostackordering.md)|Retrieves a flag indicating whether no stack ordering could be done as part of stack buffer checking.|
|[`IDiaSymbol::get_notReached`](../../debugger/debug-interface-access/idiasymbol-get-notreached.md)|Retrieves a flag indicating whether the function or label is never reached.|
|[`IDiaSymbol::get_numberOfAcceleratorPointerTags`](../../debugger/debug-interface-access/idiasymbol-get-numberofacceleratorpointertags.md)|Returns the number of accelerator pointer tags in a C++ AMP stub function.|
|[`IDiaSymbol::get_numberOfColumns`](../../debugger/debug-interface-access/idiasymbol-get-numberofcolumns.md)|Retrieves the number of columns in the matrix.|
|[`IDiaSymbol::get_numberOfModifiers`](../../debugger/debug-interface-access/idiasymbol-get-numberofmodifiers.md)|Retrieves the number of modifiers that are applied to the original type.|
|[`IDiaSymbol::get_numberOfRegisterIndices`](../../debugger/debug-interface-access/idiasymbol-get-numberofregisterindices.md)|Retrieves the number of register indices.|
|[`IDiaSymbol::get_numberOfRows`](../../debugger/debug-interface-access/idiasymbol-get-numberofrows.md)|Retrieves the number of rows in the matrix.|
|[`IDiaSymbol::get_numericProperties`](../../debugger/debug-interface-access/idiasymbol-get-numericproperties.md)|Retrieves the set of numeric properties for this symbol.|
|[`IDiaSymbol::get_objectFileName`](../../debugger/debug-interface-access/idiasymbol-get-objectfilename.md)|Retrieves the object file name.|
|[`IDiaSymbol::get_objectPointerType`](../../debugger/debug-interface-access/idiasymbol-get-objectpointertype.md)|Retrieves the type of the object pointer for a class method.|
|[`IDiaSymbol::get_oemId`](../../debugger/debug-interface-access/idiasymbol-get-oemid.md)|Retrieves the symbol's `oemId` value.|
|[`IDiaSymbol::get_oemSymbolId`](../../debugger/debug-interface-access/idiasymbol-get-oemsymbolid.md)|Retrieves the symbol's `oemSymbolId` value.|
|[`IDiaSymbol::get_offset`](../../debugger/debug-interface-access/idiasymbol-get-offset.md)|Retrieves the offset of the symbol location.|
|[`IDiaSymbol::get_offsetInUdt`](../../debugger/debug-interface-access/idiasymbol-get-offsetinudt.md)|Retrieves the field offset of this symbol withinthe outer user-defined type (UDT).|
|[`IDiaSymbol::get_optimizedCodeDebugInfo`](../../debugger/debug-interface-access/idiasymbol-get-optimizedcodedebuginfo.md)|Retrieves a flag indicating whether the function or label contains optimized code as well as debug information.|
|[`IDiaSymbol::get_ordinal`](../../debugger/debug-interface-access/idiasymbol-get-ordinal.md)|Retrieves the ordinal of this export.|
|[`IDiaSymbol::get_overloadedOperator`](../../debugger/debug-interface-access/idiasymbol-get-overloadedoperator.md)|Retrieves a flag indicating whether the user-defined data type has overloaded operators.|
|[`IDiaSymbol::get_packed`](../../debugger/debug-interface-access/idiasymbol-get-packed.md)|Retrieves a flag indicating whether the user-defined data type is packed.|
|[`IDiaSymbol::get_paramBasePointerRegisterId`](../../debugger/debug-interface-access/idiasymbol-get-parambasepointerregisterid.md)|Retrieves the register designator of the register holding the base pointer to parameters.|
|[`IDiaSymbol::get_PGODynamicInstructionCount`](../../debugger/debug-interface-access/idiasymbol-get-pgodynamicinstructioncount.md)|Retrieves the dynamic instruction count calculated by training.|
|[`IDiaSymbol::get_PGOEdgeCount`](../../debugger/debug-interface-access/idiasymbol-get-pgoedgecount.md)|Retrieves the edge count between a caller/callee and it's parent.|
|[`IDiaSymbol::get_PGOEntryCount`](../../debugger/debug-interface-access/idiasymbol-get-pgoentrycount.md)|Retrieves the total invocation count in PGO training.|
|[`IDiaSymbol::get_phaseName`](../../debugger/debug-interface-access/idiasymbol-get-phasename.md)|Retrieves the phase this function is a member of for PGO multiphased builds.|
|[`IDiaSymbol::get_platform`](../../debugger/debug-interface-access/idiasymbol-get-platform.md)|Retrieves the platform type for which the program or compiland was compiled.|
|[`IDiaSymbol::get_privateExport`](../../debugger/debug-interface-access/idiasymbol-get-privatexport.md)|Retrieves a flag indicating whether this export is `PRIVATE`.|
|[`IDiaSymbol::get_pure`](../../debugger/debug-interface-access/idiasymbol-get-pure.md)|Retrieves a flag that indicating whether the function is pure virtual.|
|[`IDiaSymbol::get_rank`](../../debugger/debug-interface-access/idiasymbol-get-rank.md)|Retrieves the rank of a FORTRAN multidimensional array.|
|[`IDiaSymbol::get_reference`](../../debugger/debug-interface-access/idiasymbol-get-reference.md)|Retrieves a flag indicating whether a pointer type is a reference.|
|[`IDiaSymbol::get_registerId`](../../debugger/debug-interface-access/idiasymbol-get-registerid.md)|Retrieves the register designator of the location.|
|[`IDiaSymbol::get_registerType`](../../debugger/debug-interface-access/idiasymbol-get-registertype.md)|Retrieves the register type.|
|[`IDiaSymbol::get_relativeVirtualAddress`](../../debugger/debug-interface-access/idiasymbol-get-relativevirtualaddress.md)|Retrieves the relative virtual address (RVA) of the location.|
|[`IDiaSymbol::get_restrictedType`](../../debugger/debug-interface-access/idiasymbol-get-restrictedtype.md)|Specifies whether the `this` pointer is flagged as restricted.|
|[`IDiaSymbol::get_RValueReference`](../../debugger/debug-interface-access/idiasymbol-get-rvaluereference.md)|Retrieves a flag that specifies whether a pointer type is an rvalue reference.|
|[`IDiaSymbol::get_samplerSlot`](../../debugger/debug-interface-access/idiasymbol-get-samplerslot.md)|Retrieves the sampler slot.|
|[`IDiaSymbol::get_scoped`](../../debugger/debug-interface-access/idiasymbol-get-scoped.md)|Retrieves a flag indicating whether the user-defined data type appears in a nonglobal lexical scope.|
|[`IDiaSymbol::get_sealed`](../../debugger/debug-interface-access/idiasymbol-get-sealed.md)|Retrieves a flag that specifies whether the class or method is sealed.|
|[`IDiaSymbol::get_signature`](../../debugger/debug-interface-access/idiasymbol-get-signature.md)|Retrieves the symbol's signature value.|
|[`IDiaSymbol::get_sizeInUdt`](../../debugger/debug-interface-access/idiasymbol-get-sizeinudt.md)|Retrieves the size of a member of a user-defined type.|
|[`IDiaSymbol::get_slot`](../../debugger/debug-interface-access/idiasymbol-get-slot.md)|Retrieves the slot number of the location.|
|[`IDiaSymbol::get_sourceFileName`](../../debugger/debug-interface-access/idiasymbol-get-sourcefilename.md)|Retrieves the file name of the source file.|
|[`IDiaSymbol::get_staticSize`](../../debugger/debug-interface-access/idiasymbol-get-staticsize.md)|Retrieves the static instruction count.|
|[`IDiaSymbol::get_strictGSCheck`](../../debugger/debug-interface-access/idiasymbol-get-strictgscheck.md)|Retrieves a flag indicating whether this function was compiled with [`strict_gs_check` pragma](/cpp/preprocessor/strict-gs-check) enabled.|
|[`IDiaSymbol::get_stride`](../../debugger/debug-interface-access/idiasymbol-get-stride.md)|Retrieves the stride of the matrix or strided array.|
|[`IDiaSymbol::get_subType`](../../debugger/debug-interface-access/idiasymbol-get-subtype.md)|Retrieves the sub type.|
|[`IDiaSymbol::get_subTypeId`](../../debugger/debug-interface-access/idiasymbol-get-subtypeid.md)|Retrieves the sub type ID.|
|[`IDiaSymbol::get_symbolsFileName`](../../debugger/debug-interface-access/idiasymbol-get-symbolsfilename.md)|Retrieves the name of the file from which the symbols were loaded.|
|[`IDiaSymbol::get_symIndexId`](../../debugger/debug-interface-access/idiasymbol-get-symindexid.md)|Retrieves the unique symbol identifier.|
|[`IDiaSymbol::get_symTag`](../../debugger/debug-interface-access/idiasymbol-get-symtag.md)|Retrieves the symbol type classifier.|
|[`IDiaSymbol::get_targetOffset`](../../debugger/debug-interface-access/idiasymbol-get-targetoffset.md)|Retrieves the offset section of a thunk target.|
|[`IDiaSymbol::get_targetRelativeVirtualAddress`](../../debugger/debug-interface-access/idiasymbol-get-targetrelativevirtualaddress.md)|Retrieves the relative virtual address (RVA) of a thunk target.|
|[`IDiaSymbol::get_targetSection`](../../debugger/debug-interface-access/idiasymbol-get-targetsection.md)|Retrieves the address section of a thunk target.|
|[`IDiaSymbol::get_targetVirtualAddress`](../../debugger/debug-interface-access/idiasymbol-get-targetvirtualaddress.md)|Retrieves the virtual address (VA) of a thunk target.|
|[`IDiaSymbol::get_textureSlot`](../../debugger/debug-interface-access/idiasymbol-get-textureslot.md)|Retrieves the texture slot.|
|[`IDiaSymbol::get_thisAdjust`](../../debugger/debug-interface-access/idiasymbol-get-thisadjust.md)|Retrieves the logical `this` adjustor for the method.|
|[`IDiaSymbol::get_thunkOrdinal`](../../debugger/debug-interface-access/idiasymbol-get-thunkordinal.md)|Retrieves the thunk type of a function.|
|[`IDiaSymbol::get_timeStamp`](../../debugger/debug-interface-access/idiasymbol-get-timestamp.md)|Retrieves the timestamp of the underlying executable file.|
|[`IDiaSymbol::get_token`](../../debugger/debug-interface-access/idiasymbol-get-token.md)|Retrieves the metadata token of a managed function or variable.|
|[`IDiaSymbol::get_type`](../../debugger/debug-interface-access/idiasymbol-get-type.md)|Retrieves a reference to the function signature.|
|[`IDiaSymbol::get_typeId`](../../debugger/debug-interface-access/idiasymbol-get-typeid.md)|Retrieves the type identifier of the symbol.|
|[`IDiaSymbol::get_typeIds`](../../debugger/debug-interface-access/idiasymbol-get-typeids.md)|Retrieves an array of compiler-specific type identifier values for this symbol.|
|[`IDiaSymbol::get_types`](../../debugger/debug-interface-access/idiasymbol-get-types.md)|Retrieves an array of compiler-specific type values for this symbol.|
|[`IDiaSymbol::get_uavSlot`](../../debugger/debug-interface-access/idiasymbol-get-uavslot.md)|Retrieves the uav slot.|
|[`IDiaSymbol::get_udtKind`](../../debugger/debug-interface-access/idiasymbol-get-udtkind.md)|Retrieves the variety of a user-defined type (UDT).|
|[`IDiaSymbol::get_unalignedType`](../../debugger/debug-interface-access/idiasymbol-get-unalignedtype.md)|Retrieves a flag indicating whether the user-defined data type is unaligned.|
|[`IDiaSymbol::get_undecoratedName`](../../debugger/debug-interface-access/idiasymbol-get-undecoratedname.md)|Retrieves the undecorated name for a C++ decorated, or linkage, name.|
|[`IDiaSymbol::get_undecoratedNameEx`](../../debugger/debug-interface-access/idiasymbol-get-undecoratednameex.md)|Extension of the `get_undecoratedName` method that retrieves the undecorated name based on the value of an extension field.|
|[`IDiaSymbol::get_unmodifiedType`](../../debugger/debug-interface-access/idiasymbol-get-unmodifiedtype.md)|Retrieves the original (unmodified) type of this symbol.|
|[`IDiaSymbol::get_unmodifiedTypeId`](../../debugger/debug-interface-access/idiasymbol-get-unmodifiedtypeid.md)|Retrieves the ID of the original (unmodified) type.|
|[`IDiaSymbol::get_unused`](../../debugger/debug-interface-access/idiasymbol-get-unused.md)|Deprecated function.|
|[`IDiaSymbol::get_upperBound`](../../debugger/debug-interface-access/idiasymbol-get-upperbound.md)|Retrieves the upper bound of a FORTRAN array dimension.|
|[`IDiaSymbol::get_upperBoundId`](../../debugger/debug-interface-access/idiasymbol-get-upperboundid.md)|Retrieves the symbol identifier of the upper bound of a FORTRAN array dimension.|
|[`IDiaSymbol::get_value`](../../debugger/debug-interface-access/idiasymbol-get-value.md)|Retrieves the value of a constant.|
|[`IDiaSymbol::get_virtual`](../../debugger/debug-interface-access/idiasymbol-get-virtual.md)|Retrieves a flag indicating whether the function is virtual.|
|[`IDiaSymbol::get_virtualAddress`](../../debugger/debug-interface-access/idiasymbol-get-virtualaddress.md)|Retrieves the virtual address (VA) of the location.|
|[`IDiaSymbol::get_virtualBaseClass`](../../debugger/debug-interface-access/idiasymbol-get-virtualbaseclass.md)|Retrieves a flag indicating whether the user-defined data type is a virtual base class.|
|[`IDiaSymbol::get_virtualBaseDispIndex`](../../debugger/debug-interface-access/idiasymbol-get-virtualbasedispindex.md)|Retrieves the index to the virtual base displacement table.|
|[`IDiaSymbol::get_virtualBaseOffset`](../../debugger/debug-interface-access/idiasymbol-get-virtualbaseoffset.md)|Retrieves the offset in the virtual function table of a virtual function.|
|[`IDiaSymbol::get_virtualBasePointerOffset`](../../debugger/debug-interface-access/idiasymbol-get-virtualbasepointeroffset.md)|Retrieves the offset of the virtual base pointer.|
|[`IDiaSymbol::get_virtualBaseTableType`](../../debugger/debug-interface-access/idiasymbol-get-virtualbasetabletype.md)|Retrieves the type of a virtual base table pointer.|
|[`IDiaSymbol::get_virtualTableShape`](../../debugger/debug-interface-access/idiasymbol-get-virtualtableshape.md)|Retrieves the symbol interface of the type of the virtual table for a user-defined type.|
|[`IDiaSymbol::get_virtualTableShapeId`](../../debugger/debug-interface-access/idiasymbol-get-virtualtableshapeid.md)|Retrieves the virtual table shape identifier of the symbol.|
|[`IDiaSymbol::get_volatileType`](../../debugger/debug-interface-access/idiasymbol-get-volatiletype.md)|Retrieves a flag indicating whether the user-defined data type is volatile.|
|[`IDiaSymbol::get_wasInlined`](../../debugger/debug-interface-access/idiasymbol-get-wasinlined.md)|Retrieves a flag indicating whether this function symbol was inlined into another function.|
|[`IDiaSymbol::getSrcLineOnTypeDefn`](../../debugger/debug-interface-access/idiasymbol-getsrclineontypedefn.md)|Retrieves the source file and line number that indicate where a specified user-defined type is defined.|

## Remarks

## Notes for Callers

Obtain this interface by calling one of the following methods:

- [IDiaEnumSymbols::Item](../../debugger/debug-interface-access/idiaenumsymbols-item.md)

- [IDiaEnumSymbols::Next](../../debugger/debug-interface-access/idiaenumsymbols-next.md)

- [IDiaEnumSymbolsByAddr::Next](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-next.md)

- [IDiaEnumSymbolsByAddr::Prev](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-prev.md)

- [IDiaEnumSymbolsByAddr::symbolByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-symbolbyaddr.md)

- [IDiaEnumSymbolsByAddr::symbolByRVA](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-symbolbyrva.md)

- [IDiaEnumSymbolsByAddr::symbolByVA](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr-symbolbyva.md)

- [IDiaSession::findSymbolByAddr](../../debugger/debug-interface-access/idiasession-findsymbolbyaddr.md)

- [IDiaSession::findSymbolByRVA](../../debugger/debug-interface-access/idiasession-findsymbolbyrva.md)

- [IDiaSession::findSymbolByRVAEx](../../debugger/debug-interface-access/idiasession-findsymbolbyrvaex.md)

- [IDiaSession::findSymbolByVA](../../debugger/debug-interface-access/idiasession-findsymbolbyva.md)

- [IDiaSession::findSymbolByVAEx](../../debugger/debug-interface-access/idiasession-findsymbolbyvaex.md)

- [IDiaSession::findSymbolByToken](../../debugger/debug-interface-access/idiasession-findsymbolbytoken.md)

- [IDiaSession::symbolById](../../debugger/debug-interface-access/idiasession-symbolbyid.md)

- [IDiaStackWalkHelper::symbolForVA](../../debugger/debug-interface-access/idiastackwalkhelper-symbolforva.md)

- [IDiaSymbol::get_types](../../debugger/debug-interface-access/idiasymbol-get-types.md)

## Example

This example shows how to display the local variables for a function at a given relative virtual address. It also shows how symbols of different types are related to each other.

> [!NOTE]
> `CDiaBSTR` is a class that wraps a `BSTR` and automatically handles freeing the string when the instantiation goes out of scope.

```C++
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

DLL: msdia140.dll

## See also

- [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)
- [IDiaEnumSymbolsByAddr](../../debugger/debug-interface-access/idiaenumsymbolsbyaddr.md)
- [IDiaEnumSymbols](../../debugger/debug-interface-access/idiaenumsymbols.md)
- [IDiaSession](../../debugger/debug-interface-access/idiasession.md)
- [Class Hierarchy of Symbol Types](../../debugger/debug-interface-access/class-hierarchy-of-symbol-types.md)
- [Symbols and Symbol Tags](../../debugger/debug-interface-access/symbols-and-symbol-tags.md)
- [Compiland](../../debugger/debug-interface-access/compiland.md)
