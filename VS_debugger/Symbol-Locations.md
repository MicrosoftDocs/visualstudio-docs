---
title: "Symbol Locations"
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
ms.assetid: 7c8cd8fe-169e-4161-9cff-5e9015984add
caps.latest.revision: 7
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
# Symbol Locations
Most symbols have a defined location within the image file. A symbol's location is specified with a value from the [LocationType Enumeration](../VS_debugger/LocationType.md) enumeration. The symbol may support additional properties depending on its location.  
  
 The following table shows the most commonly used location types and their additional properties.  
  
|Location type|Additional properties|  
|-------------------|---------------------------|  
|`LocIsNull`|none|  
|`LocIsStatic`|[IDiaSymbol::get_addressOffset](../VS_debugger/IDiaSymbol--get_addressOffset.md)<br /><br /> [IDiaSymbol::get_addressSection](../VS_debugger/IDiaSymbol--get_addressSection.md)<br /><br /> [IDiaSymbol::get_relativeVirtualAddress](../VS_debugger/IDiaSymbol--get_relativeVirtualAddress.md) (if relative virtual addresses are enabled)<br /><br /> [IDiaSymbol::get_virtualAddress](../VS_debugger/IDiaSymbol--get_virtualAddress.md) (if the image base has been set to nonzero)|  
|`LocIsTLS`|[IDiaSymbol::get_addressSection](../VS_debugger/IDiaSymbol--get_addressSection.md)<br /><br /> [IDiaSymbol::get_addressOffset](../VS_debugger/IDiaSymbol--get_addressOffset.md)|  
|`LocIsRegRel`|[IDiaSymbol::get_registerId](../VS_debugger/IDiaSymbol--get_registerId.md)<br /><br /> [IDiaSymbol::get_offset](../VS_debugger/IDiaSymbol--get_offset.md)|  
|`LocIsThisRel`|[IDiaSymbol::get_offset](../VS_debugger/IDiaSymbol--get_offset.md)|  
|`LocIsEnregistered`|[IDiaSymbol::get_registerId](../VS_debugger/IDiaSymbol--get_registerId.md)|  
|`LocIsBitField`|[IDiaSymbol::get_bitPosition](../VS_debugger/IDiaSymbol--get_bitPosition.md)<br /><br /> [IDiaSymbol::get_length](../VS_debugger/IDiaSymbol--get_length.md)<br /><br /> [IDiaSymbol::get_offset](../VS_debugger/IDiaSymbol--get_offset.md)|  
|`LocIsSlot`|[IDiaSymbol::get_slot](../VS_debugger/IDiaSymbol--get_slot.md)|  
|`LocIsIlRel`|[IDiaSymbol::get_offset](../VS_debugger/IDiaSymbol--get_offset.md)|  
|`LocInMetaData`|[IDiaSymbol::get_token](../VS_debugger/IDiaSymbol--get_token.md)|  
|`LocIsConstant`|[IDiaSymbol::get_value](../VS_debugger/IDiaSymbol--get_value.md)|  
  
## See Also  
 [IDiaSymbol::get_addressOffset](../VS_debugger/IDiaSymbol--get_addressOffset.md)   
 [IDiaSymbol::get_addressSection](../VS_debugger/IDiaSymbol--get_addressSection.md)   
 [IDiaSymbol::get_bitPosition](../VS_debugger/IDiaSymbol--get_bitPosition.md)   
 [IDiaSymbol::get_length](../VS_debugger/IDiaSymbol--get_length.md)   
 [IDiaSymbol::get_locationType](../VS_debugger/IDiaSymbol--get_locationType.md)   
 [IDiaSymbol::get_offset](../VS_debugger/IDiaSymbol--get_offset.md)   
 [IDiaSymbol::get_registerId](../VS_debugger/IDiaSymbol--get_registerId.md)   
 [IDiaSymbol::get_relativeVirtualAddress](../VS_debugger/IDiaSymbol--get_relativeVirtualAddress.md)   
 [IDiaSymbol::get_slot](../VS_debugger/IDiaSymbol--get_slot.md)   
 [IDiaSymbol::get_token](../VS_debugger/IDiaSymbol--get_token.md)   
 [IDiaSymbol::get_value](../VS_debugger/IDiaSymbol--get_value.md)   
 [IDiaSymbol::get_virtualAddress](../VS_debugger/IDiaSymbol--get_virtualAddress.md)   
 [LocationType Enumeration](../VS_debugger/LocationType.md)   
 [Symbols and Symbol Tags](../VS_debugger/Symbols-and-Symbol-Tags.md)