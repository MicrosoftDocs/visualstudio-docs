---
title: "IDiaAddressMap::put_relativeVirtualAddressEnabled"
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
ms.assetid: 767c078e-8ad7-4940-9e00-cae7704aadee
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
# IDiaAddressMap::put_relativeVirtualAddressEnabled
Allows the client to enable or disable the calculation and use of relative virtual addresses (RVA).  
  
## Syntax  
  
```cpp#  
HRESULT put_relativeVirtualAddressEnabled (   
   BOOL NewVal  
);  
```  
  
#### Parameters  
 NewVal  
 [in] Set to `TRUE` to enable, or `FALSE` to disable.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Addresses for debug objects described by DIA interfaces, and relative to the executable's image base, can be retrieved as relative virtual addresses.  
  
 The use of RVAs is enabled when segments are initially loaded from a PDB file. To get the current state of the use of RVAs, call the [IDiaAddressMap::get_relativeVirtualAddressEnabled](../VS_debugger/IDiaAddressMap--get_relativeVirtualAddressEnabled.md) method.  
  
 The `put_relativeVirtualAddress` method must be called to enable RVAs after a successful call to the [IDiaAddressMap::set_imageHeaders](../VS_debugger/IDiaAddressMap--set_imageHeaders.md) method has established new image headers.  
  
## See Also  
 [IDiaAddressMap](../VS_debugger/IDiaAddressMap.md)   
 [IDiaAddressMap::get_relativeVirtualAddressEnabled](../VS_debugger/IDiaAddressMap--get_relativeVirtualAddressEnabled.md)   
 [IDiaAddressMap::set_imageHeaders](../VS_debugger/IDiaAddressMap--set_imageHeaders.md)