---
title: "SymTagEnum | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "SymTagEnum enumeration"
ms.assetid: 528a50cf-e13d-46ec-a98c-323d5d047de9
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# SymTagEnum
Specifies the type of symbol.

## Syntax

```C++
enum SymTagEnum {
    SymTagNull,
    SymTagExe,
    SymTagCompiland,
    SymTagCompilandDetails,
    SymTagCompilandEnv,
    SymTagFunction,
    SymTagBlock,
    SymTagData,
    SymTagAnnotation,
    SymTagLabel,
    SymTagPublicSymbol,
    SymTagUDT,
    SymTagEnum,
    SymTagFunctionType,
    SymTagPointerType,
    SymTagArrayType,
    SymTagBaseType,
    SymTagTypedef,
    SymTagBaseClass,
    SymTagFriend,
    SymTagFunctionArgType,
    SymTagFuncDebugStart,
    SymTagFuncDebugEnd,
    SymTagUsingNamespace,
    SymTagVTableShape,
    SymTagVTable,
    SymTagCustom,
    SymTagThunk,
    SymTagCustomType,
    SymTagManagedType,
    SymTagDimension,
    SymTagCallSite,
    SymTagInlineSite,
    SymTagBaseInterface,
    SymTagVectorType,
    SymTagMatrixType,
    SymTagHLSLType
};
```

## Elements
`SymTagNull`
Indicates that the symbol has no type.

`SymTagExe`
Indicates that the symbol is an .exe file. There is only one `SymTagExe` symbol per symbol store. It serves as the global scope and does not have a lexical parent.

`SymTagCompiland`
Indicates the compiland symbol for each compiland component of the symbol store. For native applications, `SymTagCompiland` symbols correspond to the object files linked into the image. For some kinds of Microsoft Intermediate Language (MSIL) images, there is one compiland per class.

`SymTagCompilandDetails`
Indicates that the symbol contains extended attributes of the compiland. Retrieving these properties may require loading compiland symbols.

`SymTagCompilandEnv`
Indicates that the symbol is an environment string defined for the compiland.

`SymTagFunction`
Indicates that the symbol is a function.

`SymTagBlock`
Indicates that the symbol is a nested block.

`SymTagData`
Indicates that the symbol is data.

`SymTagAnnotation`
Indicates that the symbol is for a code annotation. Children of this symbol are constant data strings (`SymTagData`, `LocIsConstant`, `DataIsConstant`). Most clients ignore this symbol.

`SymTagLabel`
Indicates that the symbol is a label.

`SymTagPublicSymbol`
Indicates that the symbol is a public symbol. For native applications, this symbol is the COFF external symbol encountered while linking the image.

`SymTagUDT`
Indicates that the symbol is a user-defined type (structure, class, or union).

`SymTagEnum`
Indicates that the symbol is an enumeration.

`SymTagFunctionType`
Indicates that the symbol is a function signature type.

`SymTagPointerType`
Indicates that the symbol is a pointer type.

`SymTagArrayType`
Indicates that the symbol is an array type.

`SymTagBaseType`
Indicates that the symbol is a base type.

`SymTagTypedef`
Indicates that the symbol is a `typedef`, that is, an alias for another type.

`SymTagBaseClass`
Indicates that the symbol is a base class of a user-defined type.

`SymTagFriend`
Indicates that the symbol is a friend of a user-defined type.

`SymTagFunctionArgType`
Indicates that the symbol is a function argument.

`SymTagFuncDebugStart`
Indicates that the symbol is the end location of the function's prologue code.

`SymTagFuncDebugEnd`
Indicates that the symbol is the beginning location of the function's epilogue code.

`SymTagUsingNamespace`
Indicates that the symbol is a namespace name, active in the current scope.

`SymTagVTableShape`
Indicates that the symbol is a virtual table description.

`SymTagVTable`
Indicates that the symbol is a virtual table pointer.

`SymTagCustom`
Indicates that the symbol is a custom symbol and is not interpreted by DIA.

`SymTagThunk`
Indicates that the symbol is a thunk used for sharing data between 16 and 32 bit code.

`SymTagCustomType`
Indicates that the symbol is a custom compiler symbol.

`SymTagManagedType`
Indicates that the symbol is in metadata.

`SymTagDimension`
Indicates that the symbol is a FORTRAN multi-dimensional array.

`SymTagCallSite`
Indicates that the symbol represents the call site.

`SymTagInlineSite`
Indicates that the symbol represents the inline site.

`SymTagBaseInterface`
Indicates that the symbol is a base interface.

`SymTagVectorType`
Indicates that the symbol is a vector type.

`SymTagMatrixType`
Indicates that the symbol is a matrix type.

`SymTagHLSLType`
Indicates that the symbol is a High Level Shader Language type.

## Remarks
All symbols within a debug file have an identifying tag that specifies the symbol's type.

The values in this enumeration are returned by a call to the [IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md) method.

The values in this enumeration are passed to the following methods to limit the scope of the search to a specific symbol type:

- [IDiaSession::findSymbolByAddr](../../debugger/debug-interface-access/idiasession-findsymbolbyaddr.md)

- [IDiaSession::findSymbolByRVA](../../debugger/debug-interface-access/idiasession-findsymbolbyrva.md)

- [IDiaSession::findSymbolByRVAEx](../../debugger/debug-interface-access/idiasession-findsymbolbyrvaex.md)

- [IDiaSession::findSymbolByToken](../../debugger/debug-interface-access/idiasession-findsymbolbytoken.md)

- [IDiaSession::findSymbolByVA](../../debugger/debug-interface-access/idiasession-findsymbolbyva.md)

- [IDiaSession::findSymbolByVAEx](../../debugger/debug-interface-access/idiasession-findsymbolbyvaex.md)

- [IDiaSession::findChildren](../../debugger/debug-interface-access/idiasession-findchildren.md)

- [IDiaSymbol::findChildren](../../debugger/debug-interface-access/idiasymbol-findchildren.md)

## Requirements
Header: cvconst.h

## See also
- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [Lexical Hierarchy of Symbol Types](../../debugger/debug-interface-access/lexical-hierarchy-of-symbol-types.md)
- [IDiaSession::findSymbolByAddr](../../debugger/debug-interface-access/idiasession-findsymbolbyaddr.md)
- [IDiaSession::findSymbolByRVA](../../debugger/debug-interface-access/idiasession-findsymbolbyrva.md)
- [IDiaSession::findSymbolByRVAEx](../../debugger/debug-interface-access/idiasession-findsymbolbyrvaex.md)
- [IDiaSession::findSymbolByToken](../../debugger/debug-interface-access/idiasession-findsymbolbytoken.md)
- [IDiaSession::findSymbolByVA](../../debugger/debug-interface-access/idiasession-findsymbolbyva.md)
- [IDiaSession::findSymbolByVAEx](../../debugger/debug-interface-access/idiasession-findsymbolbyvaex.md)
- [IDiaSession::findChildren](../../debugger/debug-interface-access/idiasession-findchildren.md)
- [IDiaSymbol::findChildren](../../debugger/debug-interface-access/idiasymbol-findchildren.md)
