---
title: "IDiaSymbol::get_locationType | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_locationType method"
ms.assetid: fbb09c43-ebb7-4b4f-be53-ccff86eb183a
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_locationType
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the location type of a data symbol.  
  
## Syntax  
  
```cpp#  
HRESULT get_locationType (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns a value from the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md) enumeration that specifies the location type of a data symbol, such as `static` or `local`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md)
