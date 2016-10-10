---
title: "LocationType"
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
ms.assetid: d3e1eedc-bfd3-4c91-881b-d69565138d0f
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
# LocationType
Indicates the kind of location information contained in a symbol.  
  
## Syntax  
  
```cpp#  
enum LocationType {   
   LocIsNull,  
   LocIsStatic,  
   LocIsTLS,  
   LocIsRegRel,  
   LocIsThisRel,  
   LocIsEnregistered,  
   LocIsBitField,  
   LocIsSlot,  
   LocIsIlRel,  
   LocInMetaData,  
   LocIsConstant,  
   LocTypeMax  
};  
```  
  
## Elements  
 `LocIsNull`  
 Location information is unavailable.  
  
 `LocIsStatic`  
 Location is static.  
  
 `LocIsTLS`  
 Location is in thread local storage.  
  
 `LocIsRegRel`  
 Location is register-relative.  
  
 `LocIsThisRel`  
 Location is `this`-relative.  
  
 `LocIsEnregistered`  
 Location is in a register.  
  
 `LocIsBitField`  
 Location is in a bit field.  
  
 `LocIsSlot`  
 Location is a Microsoft Intermediate Language (MSIL) slot.  
  
 `LocIsIlRel`  
 Location is MSIL-relative.  
  
 `LocInMetaData`  
 Location is in metadata.  
  
 `LocIsConstant`  
 Location is in a constant value.  
  
 `LocTypeMax`  
 The number of location types in this enumeration.  
  
## Remarks  
 The properties available to the [IDiaSymbol](../VS_debugger/IDiaSymbol.md) interface depend on the symbol's location within the image file. For more information, see [Symbol Locations](../VS_debugger/Symbol-Locations.md).  
  
 The values in this enumeration are returned by a call to the [IDiaSymbol::get_locationType](../VS_debugger/IDiaSymbol--get_locationType.md) method.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../VS_debugger/Enumerations-and-Structures.md)   
 [IDiaSymbol](../VS_debugger/IDiaSymbol.md)   
 [IDiaSymbol::get_locationType](../VS_debugger/IDiaSymbol--get_locationType.md)   
 [Symbol Locations](../VS_debugger/Symbol-Locations.md)