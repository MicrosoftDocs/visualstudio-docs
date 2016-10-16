---
title: "Symbol Locations"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LocationType values"
  - "symbols [DIA SDK], locations"
ms.assetid: 7c8cd8fe-169e-4161-9cff-5e9015984add
caps.latest.revision: 7
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Symbol Locations
Most symbols have a defined location within the image file. A symbol's location is specified with a value from the [LocationType Enumeration](../debugger/locationtype.md) enumeration. The symbol may support additional properties depending on its location.  
  
 The following table shows the most commonly used location types and their additional properties.  
  
|Location type|Additional properties|  
|-------------------|---------------------------|  
|`LocIsNull`|none|  
|`LocIsStatic`|[IDiaSymbol::get_addressOffset](../debugger/idiasymbol--get_addressoffset.md)<br /><br /> [IDiaSymbol::get_addressSection](../debugger/idiasymbol--get_addresssection.md)<br /><br /> [IDiaSymbol::get_relativeVirtualAddress](../debugger/idiasymbol--get_relativevirtualaddress.md) (if relative virtual addresses are enabled)<br /><br /> [IDiaSymbol::get_virtualAddress](../debugger/idiasymbol--get_virtualaddress.md) (if the image base has been set to nonzero)|  
|`LocIsTLS`|[IDiaSymbol::get_addressSection](../debugger/idiasymbol--get_addresssection.md)<br /><br /> [IDiaSymbol::get_addressOffset](../debugger/idiasymbol--get_addressoffset.md)|  
|`LocIsRegRel`|[IDiaSymbol::get_registerId](../debugger/idiasymbol--get_registerid.md)<br /><br /> [IDiaSymbol::get_offset](../debugger/idiasymbol--get_offset.md)|  
|`LocIsThisRel`|[IDiaSymbol::get_offset](../debugger/idiasymbol--get_offset.md)|  
|`LocIsEnregistered`|[IDiaSymbol::get_registerId](../debugger/idiasymbol--get_registerid.md)|  
|`LocIsBitField`|[IDiaSymbol::get_bitPosition](../debugger/idiasymbol--get_bitposition.md)<br /><br /> [IDiaSymbol::get_length](../debugger/idiasymbol--get_length.md)<br /><br /> [IDiaSymbol::get_offset](../debugger/idiasymbol--get_offset.md)|  
|`LocIsSlot`|[IDiaSymbol::get_slot](../debugger/idiasymbol--get_slot.md)|  
|`LocIsIlRel`|[IDiaSymbol::get_offset](../debugger/idiasymbol--get_offset.md)|  
|`LocInMetaData`|[IDiaSymbol::get_token](../debugger/idiasymbol--get_token.md)|  
|`LocIsConstant`|[IDiaSymbol::get_value](../debugger/idiasymbol--get_value.md)|  
  
## See Also  
 [IDiaSymbol::get_addressOffset](../debugger/idiasymbol--get_addressoffset.md)   
 [IDiaSymbol::get_addressSection](../debugger/idiasymbol--get_addresssection.md)   
 [IDiaSymbol::get_bitPosition](../debugger/idiasymbol--get_bitposition.md)   
 [IDiaSymbol::get_length](../debugger/idiasymbol--get_length.md)   
 [IDiaSymbol::get_locationType](../debugger/idiasymbol--get_locationtype.md)   
 [IDiaSymbol::get_offset](../debugger/idiasymbol--get_offset.md)   
 [IDiaSymbol::get_registerId](../debugger/idiasymbol--get_registerid.md)   
 [IDiaSymbol::get_relativeVirtualAddress](../debugger/idiasymbol--get_relativevirtualaddress.md)   
 [IDiaSymbol::get_slot](../debugger/idiasymbol--get_slot.md)   
 [IDiaSymbol::get_token](../debugger/idiasymbol--get_token.md)   
 [IDiaSymbol::get_value](../debugger/idiasymbol--get_value.md)   
 [IDiaSymbol::get_virtualAddress](../debugger/idiasymbol--get_virtualaddress.md)   
 [LocationType Enumeration](../debugger/locationtype.md)   
 [Symbols and Symbol Tags](../debugger/symbols-and-symbol-tags.md)