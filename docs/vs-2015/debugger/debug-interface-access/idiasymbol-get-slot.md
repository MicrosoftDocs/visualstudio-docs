---
title: "IDiaSymbol::get_slot | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_slot method"
ms.assetid: 97e405b8-483f-4da0-91e7-ca4d88251ecd
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_slot
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Retrieves the slot number of the location. Use when the [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md) is `LocIsSlot`.  
  
## Syntax  
  
```cpp#  
HRESULT get_slot (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the slot number of the location.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
> A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)   
 [LocationType Enumeration](../../debugger/debug-interface-access/locationtype.md)
