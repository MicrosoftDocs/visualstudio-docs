---
title: "Function (Debug Interface Access SDK)"
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
ms.assetid: 458dc91c-b78b-4427-84f4-615d89e26760
caps.latest.revision: 22
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
# Function (Debug Interface Access SDK)
Each function is identified by a `SymTagFunction` symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|`Data type`|Description|  
|--------------|-----------------|-----------------|  
|[IDiaSymbol::get_access](../VS_debugger/IDiaSymbol--get_access.md)|`DWORD`|One of the values of the [CV_access_e Enumeration](../VS_debugger/CV_access_e.md), if the function is a member function.|  
|[IDiaSymbol::get_addressOffset](../VS_debugger/IDiaSymbol--get_addressOffset.md)|`DWORD`|Offset part of location; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md).|  
|[IDiaSymbol::get_addressSection](../VS_debugger/IDiaSymbol--get_addressSection.md)|`DWORD`|Section part of location; for details, see the [LocationType Enumeration](../VS_debugger/LocationType.md).|  
|[IDiaSymbol::get_classParent](../VS_debugger/IDiaSymbol--get_classParent.md)|`IDiaSymbol*`|Symbol for the class, if the function is a member function.|  
|[IDiaSymbol::get_classParentId](../VS_debugger/IDiaSymbol--get_classParentId.md)|`DWORD`|ID of the class parent symbol.|  
|[IDiaSymbol::get_constType](../VS_debugger/IDiaSymbol--get_constType.md)|`BOOL`|`TRUE` if the function is marked as a constant.|  
|[IDiaSymbol::get_customCallingConvention](../VS_debugger/IDiaSymbol--get_customCallingConvention.md)|`BOOL`|`TRUE` if the function uses a custom calling convention (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_farReturn](../VS_debugger/IDiaSymbol--get_farReturn.md)|`BOOL`|`TRUE` if the function performs a far return (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_hasAlloca](../VS_debugger/IDiaSymbol--get_hasAlloca.md)|`BOOL`|`TRUE` if the function uses allocated memory function (only uinnder DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_hasEH](../VS_debugger/IDiaSymbol--get_hasEH.md)|`BOOL`|`TRUE` if the function contains C++-style exception handling (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_hasEHa](../VS_debugger/IDiaSymbol--get_hasEHa.md)|`BOOL`|`TRUE` if the function contains asynchronous exception handling (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_hasInlAsm](../VS_debugger/IDiaSymbol--get_hasInlAsm.md)|`BOOL`|`TRUE` if the function contains inline assembly (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_hasLongJump](../VS_debugger/IDiaSymbol--get_hasLongJump.md)|`BOOL`|`TRUE` if the function contains a [longjmp](../Topic/longjmp.md) call (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_hasSecurityChecks](../VS_debugger/IDiaSymbol--get_hasSecurityChecks.md)|`BOOL`|`TRUE` if the function contains security checks (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_hasSEH](../VS_debugger/IDiaSymbol--get_hasSEH.md)|`BOOL`|`TRUE` if the function contains Win32-style structured exception handling (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_hasSetJump](../VS_debugger/IDiaSymbol--get_hasSetJump.md)|`BOOL`|`TRUE` if the function contains a [setjmp](../Topic/setjmp.md) call (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_interruptReturn](../VS_debugger/IDiaSymbol--get_interruptReturn.md)|`BOOL`|`TRUE` if the function has a return from interrupt (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_intro](../VS_debugger/IDiaSymbol--get_intro.md)|`BOOL`|`TRUE` if a function is intro virtual.|  
|[IDiaSymbol::get_InlSpec](../VS_debugger/IDiaSymbol--get_InlSpec.md)|`BOOL`|`TRUE` if the function has been marked with one of the [inline, __inline, \__forceinline](../VS_not_in_toc/inline--__inline--__forceinline.md) attributes.|  
|[IDiaSymbol::get_isNaked](../VS_debugger/IDiaSymbol--get_isNaked.md)|`BOOL`|`TRUE` if the function is marked with the [naked](../Topic/naked%20\(C++\).md) attribute (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_isStatic](../VS_debugger/IDiaSymbol--get_isStatic.md)|`BOOL`|`TRUE` if the function is static (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_length](../VS_debugger/IDiaSymbol--get_length.md)|`ULONGLONG`|Number of bytes of function code, starting from location.|  
|[IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md)|`IDiaSymbol*`|Symbol of the enclosing compiland.|  
|[IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md)|`DWORD`|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_locationType](../VS_debugger/IDiaSymbol--get_locationType.md)|`DWORD`|Functions can have static or metadata locations; for details, see [Symbol Locations](../VS_debugger/Symbol-Locations.md).|  
|[IDiaSymbol::get_name](../VS_debugger/IDiaSymbol--get_name.md)|`BSTR`|Name of the function.|  
|[IDiaSymbol::get_noInline](../VS_debugger/IDiaSymbol--get_noInline.md)|`BOOL`|`TRUE` if the function is not an inline function (only n DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_notReached](../VS_debugger/IDiaSymbol--get_notReached.md)|`BOOL`|`TRUE` if the function is not reachable (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_noReturn](../VS_debugger/IDiaSymbol--get_noReturn.md)|`BOOL`|`TRUE` if the function does not return a value (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_noStackOrdering](../VS_debugger/IDiaSymbol--get_noStackOrdering.md)|`BOOL`|`TRUE` if the function was compiled with buffer security checks but no stack ordering could be done.|  
|[IDiaSymbol::get_optimizedCodeDebugInfo](../VS_debugger/IDiaSymbol--get_optimizedCodeDebugInfo.md)|`BOOL`|`TRUE` if the code has debug information for optimized code (only in DIA SDK V8.0 or later).|  
|[IDiaSymbol::get_pure](../VS_debugger/IDiaSymbol--get_pure.md)|`BOOL`|`TRUE` if function is pure virtual.|  
|[IDiaSymbol::get_relativeVirtualAddress](../VS_debugger/IDiaSymbol--get_relativeVirtualAddress.md)|`DWORD`|Relative position of this function within its module.|  
|[IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md)|`DWORD`|Index ID of symbol.|  
|[IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)|`DWORD`|Returns `SymTagFunction` (one of the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) values).|  
|[IDiaSymbol::get_token](../VS_debugger/IDiaSymbol--get_token.md)|`DWORD`|Metadata token for the function.|  
|[IDiaSymbol::get_type](../VS_debugger/IDiaSymbol--get_type.md)|`IDiaSymbol*`|Symbol for the function signature.|  
|[IDiaSymbol::get_typeId](../VS_debugger/IDiaSymbol--get_typeId.md)|`DWORD`|ID of the type symbol.|  
|[IDiaSymbol::get_unalignedType](../VS_debugger/IDiaSymbol--get_unalignedType.md)|`BOOL`|`TRUE` if the function is unaligned.|  
|[IDiaSymbol::get_undecoratedName](../VS_debugger/IDiaSymbol--get_undecoratedName.md)|`BSTR`|The undecorated form of the function name (only in DIA SDK v8.0 or later)|  
|[IDiaSymbol::get_undecoratedNameEx](../VS_debugger/IDiaSymbol--get_undecoratedNameEx.md)|`BSTR`|Part or all of the undecorated form of the function name (only in DIA SDK v8.0 or later).|  
|[IDiaSymbol::get_virtual](../VS_debugger/IDiaSymbol--get_virtual.md)|`BOOL`|`TRUE` if a virtual function.|  
|[IDiaSymbol::get_virtualAddress](../VS_debugger/IDiaSymbol--get_virtualAddress.md)|`ULONGLONG`|Position of this function within the executable image.|  
|[IDiaSymbol::get_virtualBaseOffset](../VS_debugger/IDiaSymbol--get_virtualBaseOffset.md)|`DWORD`|If a virtual function, then the offset in the virtual function table.|  
|[IDiaSymbol::get_volatileType](../VS_debugger/IDiaSymbol--get_volatileType.md)|`BOOL`|`TRUE` if the function is marked as volatile.|  
  
## See Also  
 [CV_access_e Enumeration](../VS_debugger/CV_access_e.md)   
 [Lexical Hierarchy of Symbol Types](../VS_debugger/Lexical-Hierarchy-of-Symbol-Types.md)   
 [LocationType Enumeration](../VS_debugger/LocationType.md)   
 [Symbol Locations](../VS_debugger/Symbol-Locations.md)