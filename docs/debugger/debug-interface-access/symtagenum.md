---
description: "Specifies the type of symbol."
title: "SymTagEnum"
ms.date: "11/4/2024"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "SymTagEnum enumeration"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
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
    SymTagHLSLType,
    SymTagCaller,
    SymTagCallee,
    SymTagExport,
    SymTagHeapAllocationSite,
    SymTagCoffGroup,
    SymTagInlinee,
    SymTagTaggedUnionCase,
};
```

## Elements

| Element    | Description                                                                                            |
-------------------------- | ---------------------------------------------------------------------------------------- |
| `SymTagNull`             | Indicates that the symbol has no type.                                                   |                            
| `SymTagExe`              | Indicates that the symbol is an .exe file.</br> there's only one `SymTagExe` symbol per symbol store.</br> It serves as the global scope and doesn't have a lexical parent.                  |
| `SymTagCompiland`        | Indicates the compiland symbol for each compiland component of the symbol store.</br> For native applications, `SymTagCompiland` symbols correspond to the object files linked into the image. For some kinds of Microsoft Intermediate Language (MSIL) images, there's one compiland per class. |
| `SymTagCompilandDetails` | Indicates that the symbol contains extended attributes of the compiland.</br> Retrieving these properties may require loading compiland symbols.                                |
| `SymTagCompilandEnv`     | Indicates that the symbol is an environment string defined for the compiland.             |
| `SymTagFunction`         | Indicates that the symbol is a function.                                                  |
| `SymTagBlock`            | Indicates that the symbol is a nested block.                                              |
| `SymTagData`             | Indicates that the symbol is data.                                                        |
| `SymTagAnnotation`       | Indicates that the symbol is for a code annotation.</br> Children of this symbol are constant data strings (`SymTagData`, `LocIsConstant`, and `DataIsConstant`).</br> Most clients ignore this symbol.                                                                    |
| `SymTagLabel`            | Indicates that the symbol is a label.                                                     |
| `SymTagPublicSymbol`     | Indicates that the symbol is a public symbol. For native applications, this symbol is the COFF external symbol encountered while linking the image.                                                                                                                 |
| `SymTagUDT`              | Indicates that the symbol is a user-defined type (structure, class, or union).            |
| `SymTagEnum`             | Indicates that the symbol is an enumeration.                                              |
| `SymTagFunctionType`     | Indicates that the symbol is a function signature type.                                   |
| `SymTagPointerType`      | Indicates that the symbol is a pointer type.                                              |
| `SymTagArrayType`        | Indicates that the symbol is an array type.                                               |
| `SymTagBaseType`         | Indicates that the symbol is a base type.                                                 |
| `SymTagTypedef`          | Indicates that the symbol is a `typedef` that is an alias for another type.               |
| `SymTagBaseClass`        | Indicates that the symbol is a base class of a user-defined type.                         |
| `SymTagFriend`           | Indicates that the symbol is a friend of a user-defined type.                             |
| `SymTagFunctionArgType`  | Indicates that the symbol is a function argument.                                         |
| `SymTagFuncDebugStart`   | Indicates that the symbol is the end location of the function's prologue code.            |
| `SymTagFuncDebugEnd`     | Indicates that the symbol is the beginning location of the function's epilogue code.      |
| `SymTagUsingNamespace`   | Indicates that the symbol is a namespace name active in the current scope.                |
| `SymTagVTableShape`      | Indicates that the symbol is a virtual table description.                                 |
| `SymTagVTable`           | Indicates that the symbol is a virtual table pointer.                                     |
| `SymTagCustom`           | Indicates that the symbol is a custom symbol.</br> Microsoft Debug Interface Access (DIA) SDK doesn't provide further interpretation of these symbols. |
| `SymTagThunk`            | Indicates that the symbol is a thunk used for sharing data between 16-bit and 32-bit code. |
| `SymTagCustomType`       | Indicates that the symbol is a custom compiler symbol.                                    |
| `SymTagManagedType`      | Indicates that the symbol is in metadata.                                                 |
| `SymTagDimension`        | Indicates that the symbol is a FORTRAN multi-dimensional array.                           |
| `SymTagCallSite`         | Indicates that the symbol represents the call site.                                       |
| `SymTagInlineSite`       | Indicates that the symbol represents the inline site.                                     |
| `SymTagBaseInterface`    | Indicates that the symbol is a base interface.                                            |
| `SymTagVectorType`       | Indicates that the symbol is a vector type.                                               |
| `SymTagMatrixType`       | Indicates that the symbol is a matrix type.                                               |
| `SymTagHLSLType`         | Indicates that the symbol is a High Level Shader Language type.                           |
| `SymTagCaller`           | Indicates that the symbol represents Profile-guided optimization (PGO) caller information. |
| `SymTagCallee`           | Indicates that the symbol represents PGO callee information.                              |
| `SymTagExport`           | Indicates that the symbol is an export from a DLL.                                        |
| `SymTagHeapAllocationSite`| Indicates that the symbol represents a heap allocation site (for example, a call to `operator new`)|
| `SymTagCoffGroup`        | Indicates that the symbol is a COFF group.                                                |
| `SymTagInlinee`          | Indicates that the symbol represents the inlinee of an inline site (see `SymTagInlineSite`).|
| `SymTagTaggedUnionCase`  | Indicates that the symbol is a tagged union (for example, Rust's enum type)                      |

## Remarks

All symbols within a debug file have an identifying tag that specifies the symbol's type.

The [`IDiaSymbol::get_symTag`](../../debugger/debug-interface-access/idiasymbol-get-symtag.md) method returns values from this enumeration.

The values in this enumeration are passed to the following methods to limit the scope of the search to a specific symbol type:

- [`IDiaSession::findSymbolByAddr`](../../debugger/debug-interface-access/idiasession-findsymbolbyaddr.md)

- [`IDiaSession::findSymbolByRVA`](../../debugger/debug-interface-access/idiasession-findsymbolbyrva.md)

- [`IDiaSession::findSymbolByRVAEx`](../../debugger/debug-interface-access/idiasession-findsymbolbyrvaex.md)

- [`IDiaSession::findSymbolByToken`](../../debugger/debug-interface-access/idiasession-findsymbolbytoken.md)

- [`IDiaSession::findSymbolByVA`](../../debugger/debug-interface-access/idiasession-findsymbolbyva.md)

- [`IDiaSession::findSymbolByVAEx`](../../debugger/debug-interface-access/idiasession-findsymbolbyvaex.md)

- [`IDiaSession::findChildren`](../../debugger/debug-interface-access/idiasession-findchildren.md)

- [`IDiaSymbol::findChildren`](../../debugger/debug-interface-access/idiasymbol-findchildren.md)

## Requirements

Header: cvconst.h

## See also

- [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)
- [Lexical Hierarchy of Symbol Types](../../debugger/debug-interface-access/lexical-hierarchy-of-symbol-types.md)
- [`IDiaSession::findSymbolByAddr`](../../debugger/debug-interface-access/idiasession-findsymbolbyaddr.md)
- [`IDiaSession::findSymbolByRVA`](../../debugger/debug-interface-access/idiasession-findsymbolbyrva.md)
- [`IDiaSession::findSymbolByRVAEx`](../../debugger/debug-interface-access/idiasession-findsymbolbyrvaex.md)
- [`IDiaSession::findSymbolByToken`](../../debugger/debug-interface-access/idiasession-findsymbolbytoken.md)
- [`IDiaSession::findSymbolByVA`](../../debugger/debug-interface-access/idiasession-findsymbolbyva.md)
- [`IDiaSession::findSymbolByVAEx`](../../debugger/debug-interface-access/idiasession-findsymbolbyvaex.md)
- [`IDiaSession::findChildren`](../../debugger/debug-interface-access/idiasession-findchildren.md)
- [`IDiaSymbol::findChildren`](../../debugger/debug-interface-access/idiasymbol-findchildren.md)
