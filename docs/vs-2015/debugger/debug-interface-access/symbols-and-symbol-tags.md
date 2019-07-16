---
title: "Symbols and Symbol Tags | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "symbols [DIA SDK]"
ms.assetid: 2ee3a262-cda6-48bf-b799-a37edde6c8b8
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Symbols and Symbol Tags
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Debug information about a compiled program is stored in the program database (.pdb) file as symbols that are accessible using the Debug Interface Access (DIA) SDK APIs. All symbols have a [IDiaSymbol::get_symTag](../../debugger/debug-interface-access/idiasymbol-get-symtag.md) and a [IDiaSymbol::get_symIndexId](../../debugger/debug-interface-access/idiasymbol-get-symindexid.md) property. The `symTag` property indicates the kind of symbol as defined by the [SymTagEnum Enumeration](../../debugger/debug-interface-access/symtagenum.md) enumeration. The `symIndexId` property is a `DWORD` value that contains the unique identifier for every instance of a symbol.  
  
 Symbols also have properties that can specify additional information about the symbol as well as references to other symbols, most often a [IDiaSymbol::get_lexicalParent](../../debugger/debug-interface-access/idiasymbol-get-lexicalparent.md) or [IDiaSymbol::get_classParent](../../debugger/debug-interface-access/idiasymbol-get-classparent.md). When you query a property that contains a reference, the reference is returned as an [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md) object. Such properties are always paired with another property by the same name but suffixed with "Id", for example, [IDiaSymbol::get_lexicalParentId](../../debugger/debug-interface-access/idiasymbol-get-lexicalparentid.md) and [IDiaSymbol::get_classParentId](../../debugger/debug-interface-access/idiasymbol-get-classparentid.md). The tables in [Symbol Locations](../../debugger/debug-interface-access/symbol-locations.md), [Lexical Hierarchy of Symbol Types](../../debugger/debug-interface-access/lexical-hierarchy-of-symbol-types.md), and [Class Hierarchy of Symbol Types](../../debugger/debug-interface-access/class-hierarchy-of-symbol-types.md) outline the properties for each of the different kinds of symbols. These properties may have relevant information about or references to other symbols. Because the `*Id` properties are simply numeric ordinal identifiers of their related properties, they are omitted from further discussions. They are referred to only where needed for parameter clarification.  
  
 When trying to access the property, if no error occurs and the symbol property has been assigned a value, the property's "get" method returns `S_OK`. A return value of `S_FALSE` indicates that the property is not valid for the current symbol.  
  
## In This Section  
 [Symbol Locations](../../debugger/debug-interface-access/symbol-locations.md)  
 Describes the different kinds of locations a symbol can have.  
  
 [Lexical Hierarchy of Symbol Types](../../debugger/debug-interface-access/lexical-hierarchy-of-symbol-types.md)  
 Describes the symbol types that form lexical hierarchies such as files, modules, and functions.  
  
 [Class Hierarchy of Symbol Types](../../debugger/debug-interface-access/class-hierarchy-of-symbol-types.md)  
 Describes the symbol types that correspond to different language elements such as classes, arrays, and function return types.  
  
## See Also  
 [Debug Interface Access SDK](../../debugger/debug-interface-access/debug-interface-access-sdk.md)
