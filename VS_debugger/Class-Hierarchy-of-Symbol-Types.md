---
title: "Class Hierarchy of Symbol Types"
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
ms.assetid: 0ccd6990-4654-44cd-a6f3-bdd82fe90f6c
caps.latest.revision: 10
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
# Class Hierarchy of Symbol Types
The following table describes the symbol types in the class hierarchy.  
  
## Symbol Types  
  
|Symbol type|Description|  
|-----------------|-----------------|  
|[UDT](../VS_debugger/UDT.md)|Symbol used to represent each class, structure, and union.|  
|[Enum (Debug Interface Access SDK)](../VS_debugger/Enum--Debug-Interface-Access-SDK-.md)|Symbol for enumerated types.|  
|[PointerType](../VS_debugger/PointerType.md)|Symbol for pointer types.|  
|[ArrayType](../VS_debugger/ArrayType.md)|Symbol for array types.|  
|[BaseType](../VS_debugger/BaseType.md)|Symbol for base types|  
|[Typedef (Debug Interface Access SDK)](../VS_debugger/Typedef--Debug-Interface-Access-SDK-.md)|Symbol that introduces names for other types.|  
|[BaseClass](../VS_debugger/BaseClass.md)|Symbol used for each base class of a user-defined type (UDT).|  
|[Friend (Debug Interface Access SDK)](../VS_debugger/Friend--Debug-Interface-Access-SDK-.md)|Symbol for friend classes and friend functions.|  
|[FunctionType](../VS_debugger/FunctionType.md)|Symbol for each unique function signature.|  
|[FunctionArgType](../VS_debugger/FunctionArgType.md)|Symbol for each parameter to a function.|  
|[VTableShape](../VS_debugger/VTableShape.md)|Symbol for the size of the virtual table.|  
|[VTable](../VS_debugger/VTable.md)|Symbol for a virtual table.|  
|[CustomType](../VS_debugger/CustomType.md)|Symbol for vendor-defined type.|  
|[ManagedType](../VS_debugger/ManagedType.md)|Symbol for a type defined in metadata.|  
|[Dimension](../VS_debugger/Dimension.md)|Symbol for array dimensions.|  
  
> [!NOTE]
>  Each symbol can have properties that hold information about the symbol, as well as references to other symbols. These properties are listed in the individual symbol topics.  
  
## See Also  
 [CV_access_e Enumeration](../VS_debugger/CV_access_e.md)   
 [Lexical Hierarchy of Symbol Types](../VS_debugger/Lexical-Hierarchy-of-Symbol-Types.md)   
 [Symbols and Symbol Tags](../VS_debugger/Symbols-and-Symbol-Tags.md)