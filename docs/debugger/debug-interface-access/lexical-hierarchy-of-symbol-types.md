---
title: "Lexical Hierarchy of Symbol Types"
description: "The following table shows the symbol types in the lexical hierarchy."
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - "symbols [DIA SDK], type hierarchies"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Lexical Hierarchy of Symbol Types

The following table shows the symbol types in the lexical hierarchy.

## Symbol Types

|Symbol type|Description|
|-----------------|-----------------|
|[Annotation](../../debugger/debug-interface-access/annotation.md)|Specifies an annotated location in program code.|
|[Block](../../debugger/debug-interface-access/block.md)|Specifies nested scopes in functions.|
|`Compiland`|Specifies a `compiland` linked to the .exe file.|
|[CompilandDetails](../../debugger/debug-interface-access/compilanddetails.md)|Specifies compiland data that may require loading additional compiland details and thus incur run-time overhead to retrieve.|
|[CompilandEnv](../../debugger/debug-interface-access/compilandenv.md)|Specifies any additional environment variables significant to the compilation of the compiland.|
|[Custom (Debug Interface Access SDK)](../../debugger/debug-interface-access/custom-debug-interface-access-sdk.md)|Specifies a user-defined symbol.|
|[Data (Debug Interface Access SDK)](../../debugger/debug-interface-access/data-debug-interface-access-sdk.md)|Specifies such variables as parameters, local variables, global variables, and class members.|
|[Exe](../../debugger/debug-interface-access/exe.md)|Specifies the global scope of the data; corresponds to an entire .exe or .dll file.|
|[FuncDebugEnd](../../debugger/debug-interface-access/funcdebugend.md)|Specifies a function that has a defined point at which debugging is to end.|
|[FuncDebugStart](../../debugger/debug-interface-access/funcdebugstart.md)|Specifies a function that has a defined point at which debugging is to begin.|
|[Function (Debug Interface Access SDK)](../../debugger/debug-interface-access/function-debug-interface-access-sdk.md)|Specifies a function.|
|[Label (Debug Interface Access SDK)](../../debugger/debug-interface-access/label-debug-interface-access-sdk.md)|Specifies a location in program code.|
|[PublicSymbol](../../debugger/debug-interface-access/publicsymbol.md)|Specifies an external symbol that appears when building the executable program.|
|[Thunk](../../debugger/debug-interface-access/thunk.md)|Specifies a `thunk`.|
|[UsingNameSpace](../../debugger/debug-interface-access/usingnamespace.md)|Specifies a `namespace` identifier.|

> [!NOTE]
> Additional symbol properties may be available depending on the symbol type. These properties are listed in the individual symbol topics.

## See also
- [Class Hierarchy of Symbol Types](../../debugger/debug-interface-access/class-hierarchy-of-symbol-types.md)
- [IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md)
- [Symbols and Symbol Tags](../../debugger/debug-interface-access/symbols-and-symbol-tags.md)
- [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md)
