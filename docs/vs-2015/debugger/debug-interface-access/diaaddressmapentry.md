---
title: "DiaAddressMapEntry | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DiaAddressMapEntry enumeration"
ms.assetid: 5d0ae226-981d-4541-a801-fc4993fe663b
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# DiaAddressMapEntry
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Describes an entry in an address map.  
  
## Syntax  
  
```cpp#  
struct DiaAddressMapEntry {   
   DWORD rva,  
   DWORD rvaTo  
};  
```  
  
## Elements  
 `rva`  
 A relative virtual address (RVA) in image A.  
  
 `rvaTo`  
 The relative virtual address `rva` is mapped to in image B.  
  
## Remarks  
 An address map provides a translation from one image layout (A) to another (B). An array of `DiaAddressMapEntry` structures sorted by `rva` defines an address map.  
  
 To translate an address, `addrA`, in image A to an address, `addrB`, in image B, perform the following steps:  
  
1. Search the map for the entry, `e`, with the largest `rva` less than or equal to `addrA`.  
  
2. Set `delta = addrA – e.rva`.  
  
3. Set `addrB = e.rvaTo + delta`.  
  
   An array of `DiaAddressMapEntry` structures is passed to the [IDiaAddressMap::set_addressMap](../../debugger/debug-interface-access/idiaaddressmap-set-addressmap.md) method.  
  
## Requirements  
 Header: dia2.h  
  
## See Also  
 [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)   
 [IDiaAddressMap::set_addressMap](../../debugger/debug-interface-access/idiaaddressmap-set-addressmap.md)
