---
title: "IDiaSymbol::get_offset | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_offset method"
ms.assetid: 8292bb08-4dc8-4663-beb4-258f5d5a448d
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_offset
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the offset of the symbol location. Use when the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md) is `LocIsRegRel` or `LocIsBitField`.  
  
## Syntax  
  
```cpp#  
HRESULT get_offset (   
   LONG* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the offset in bytes of the symbol location.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.  
  
## Remarks  
 The offset is from some known point previously determined. For example, the offset for a `LocIsBitField` location type is typically from the start of the containing class.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md)
