---
title: "Lexical Hierarchy of Symbol Types"
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
ms.assetid: 912da653-ddfe-45a4-84aa-64281283739a
caps.latest.revision: 15
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
# Lexical Hierarchy of Symbol Types
The following table shows the symbol types in the lexical hierarchy.  
  
## Symbol Types  
  
|Symbol type|Description|  
|-----------------|-----------------|  
|[Annotation](../VS_debugger/Annotation.md)|Specifies an annotated location in program code.|  
|[Block](../VS_debugger/Block.md)|Specifies nested scopes in functions.|  
|`Compiland`|Specifies a `compiland` linked to the .exe file.|  
|[CompilandDetails](../VS_debugger/CompilandDetails.md)|Specifies compiland data that may require loading additional compiland details and thus incur run-time overhead to retrieve.|  
|[CompilandEnv](../VS_debugger/CompilandEnv.md)|Specifies any additional environment variables significant to the compilation of the compiland.|  
|[Custom (Debug Interface Access SDK)](../VS_debugger/Custom--Debug-Interface-Access-SDK-.md)|Specifies a user-defined symbol.|  
|[Data (Debug Interface Access SDK)](../VS_debugger/Data--Debug-Interface-Access-SDK-.md)|Specifies such variables as parameters, local variables, global variables, and class members.|  
|[Exe](../VS_debugger/Exe.md)|Specifies the global scope of the data; corresponds to an entire .exe or .dll file.|  
|[FuncDebugEnd](../VS_debugger/FuncDebugEnd.md)|Specifies a function that has a defined point at which debugging is to end.|  
|[FuncDebugStart](../VS_debugger/FuncDebugStart.md)|Specifies a function that has a defined point at which debugging is to begin.|  
|[Function (Debug Interface Access SDK)](../VS_debugger/Function--Debug-Interface-Access-SDK-.md)|Specifies a function.|  
|[Label (Debug Interface Access SDK)](../VS_debugger/Label--Debug-Interface-Access-SDK-.md)|Specifies a location in program code.|  
|[PublicSymbol](../VS_debugger/PublicSymbol.md)|Specifies an external symbol that appears when building the executable program.|  
|[Thunk](../VS_debugger/Thunk.md)|Specifies a `thunk`.|  
|[UsingNameSpace](../VS_debugger/UsingNameSpace.md)|Specifies a `namespace`identifier.|  
  
> [!NOTE]
>  Additional symbol properties may be available depending on the symbol type. These properties are listed in the individual symbol topics.  
  
## See Also  
 [Class Hierarchy of Symbol Types](../VS_debugger/Class-Hierarchy-of-Symbol-Types.md)   
 [IDiaSymbol::get_symTag](../VS_debugger/IDiaSymbol--get_symTag.md)   
 [Symbols and Symbol Tags](../VS_debugger/Symbols-and-Symbol-Tags.md)   
 [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md)