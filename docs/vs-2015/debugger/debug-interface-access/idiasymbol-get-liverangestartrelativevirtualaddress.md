---
title: "IDiaSymbol::get_liveRangeStartRelativeVirtualAddress | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_liveRangeStartRelativeVirtualAddress"
ms.assetid: 1da52539-9872-4c20-8eaa-74b6cb5f3b02
caps.latest.revision: 11
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_liveRangeStartRelativeVirtualAddress
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Returns the beginning of the address range in which the local symbol is valid.  
  
## Syntax  
  
```cpp#  
HRESULT get_liveRangeStartRelativeVirtualAddress (   
   DWORD* address  
);  
```  
  
#### Parameters  
 `address`  
 [out] Returns the start of the address range.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. The relative virtual address returned is the beginning of the range in which the symbol is valid.  
  
> [!NOTE]
> A returned error code means that the symbol does not have live range information.  
  
## Remarks  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia100.dll  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
