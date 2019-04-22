---
title: "IDiaSymbol::get_liveRangeStartAddressSection | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSymbol::get_liveRangeStartAddressSection"
ms.assetid: 892b80ff-5957-4233-b4d7-6144167be289
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSymbol::get_liveRangeStartAddressSection
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Returns the section part of the starting address of the range in which the local symbol is valid.  
  
## Syntax  
  
```cpp#  
HRESULT get_liveRangeStartAddressSection (   
   DWORD* section  
);  
```  
  
#### Parameters  
 `section`  
 [out] Returns the section part of the starting address range.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
> [!NOTE]
> A returned error code means that the symbol does not have live range information.  
  
## Remarks  
 The address formed by the section and offset is the beginning of the range in which the symbol is valid.  
  
 To get the offset part of the address, use [IDiaSymbol::get_liveRangeStartAddressOffset](../../debugger/debug-interface-access/idiasymbol-get-liverangestartaddressoffset.md).  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia100.dll  
  
## See Also  
 [IDiaSymbol](../../debugger/debug-interface-access/idiasymbol.md)
