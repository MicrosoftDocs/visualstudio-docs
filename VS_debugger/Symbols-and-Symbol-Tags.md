---
title: "Symbols and Symbol Tags"
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
ms.assetid: 2ee3a262-cda6-48bf-b799-a37edde6c8b8
caps.latest.revision: 8
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
# Symbols and Symbol Tags
Debug information about a compiled program is stored in the program database (.pdb) file as symbols that are accessible using the Debug Interface Access (DIA) SDK APIs. All symbols have a [IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md) and a [IDiaSymbol::get_symIndexId](../VS_debugger/IDiaSymbol--get_symIndexId.md) property. The `symTag` property indicates the kind of symbol as defined by the [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md) enumeration. The `symIndexId` property is a `DWORD` value that contains the unique identifier for every instance of a symbol.  
  
 Symbols also have properties that can specify additional information about the symbol as well as references to other symbols, most often a [IDiaSymbol::get_lexicalParent](../VS_debugger/IDiaSymbol--get_lexicalParent.md) or [IDiaSymbol::get_classParent](../VS_debugger/IDiaSymbol--get_classParent.md). When you query a property that contains a reference, the reference is returned as an [IDiaSymbol](../VS_debugger/IDiaSymbol.md) object. Such properties are always paired with another property by the same name but suffixed with "Id", for example, [IDiaSymbol::get_lexicalParentId](../VS_debugger/IDiaSymbol--get_lexicalParentId.md) and [IDiaSymbol::get_classParentId](../VS_debugger/IDiaSymbol--get_classParentId.md). The tables in [Symbol Locations](../VS_debugger/Symbol-Locations.md), [Lexical Hierarchy of Symbol Types](../VS_debugger/Lexical-Hierarchy-of-Symbol-Types.md), and [Class Hierarchy of Symbol Types](../VS_debugger/Class-Hierarchy-of-Symbol-Types.md) outline the properties for each of the different kinds of symbols. These properties may have relevant information about or references to other symbols. Because the `*Id` properties are simply numeric ordinal identifiers of their related properties, they are omitted from further discussions. They are referred to only where needed for parameter clarification.  
  
 When trying to access the property, if no error occurs and the symbol property has been assigned a value, the property's "get" method returns `S_OK`. A return value of `S_FALSE` indicates that the property is not valid for the current symbol.  
  
## In This Section  
 [Symbol Locations](../VS_debugger/Symbol-Locations.md)  
 Describes the different kinds of locations a symbol can have.  
  
 [Lexical Hierarchy of Symbol Types](../VS_debugger/Lexical-Hierarchy-of-Symbol-Types.md)  
 Describes the symbol types that form lexical hierarchies such as files, modules, and functions.  
  
 [Class Hierarchy of Symbol Types](../VS_debugger/Class-Hierarchy-of-Symbol-Types.md)  
 Describes the symbol types that correspond to different language elements such as classes, arrays, and function return types.  
  
## See Also  
 [Debug Interface Access SDK](../VS_debugger/Debug-Interface-Access-SDK.md)