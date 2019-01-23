---
title: "IDiaAddressMap::put_addressMapEnabled | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaAddressMap::put_addressMapEnabled method"
ms.assetid: 0f205337-4e59-4383-8059-7b1d207d6dcd
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaAddressMap::put_addressMapEnabled
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Specifies whether the address map should be used to translate symbol addresses.  
  
## Syntax  
  
```cpp#  
HRESULT put_addressMapEnabled (   
   BOOL NewVal  
);  
```  
  
#### Parameters  
 NewVal  
 [in] Set to `TRUE` to enable the translation of symbols, or `FALSE` to disable.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Executable post-processors sometimes update the executable. DIA contains a mechanism to support the translation of symbols to the new layout.  
  
 When a PDB file is loaded, the address map stored in the file is enabled. There are times, however, when a client application may need to supply its own address map by calling the [IDiaAddressMap::set_addressMap](../../debugger/debug-interface-access/idiaaddressmap-set-addressmap.md) method. If the `set_addressMap` method is successful, the client application must call the `put_addressMapEnabled` method with a `NewVal` parameter of `TRUE` to enable the use of that address map.  
  
 The current state of the address map being enabled can be retrieved with a call to the [IDiaAddressMap::get_addressMapEnabled](../../debugger/debug-interface-access/idiaaddressmap-get-addressmapenabled.md) method.  
  
## See Also  
 [IDiaAddressMap](../../debugger/debug-interface-access/idiaaddressmap.md)   
 [IDiaAddressMap::set_addressMap](../../debugger/debug-interface-access/idiaaddressmap-set-addressmap.md)   
 [IDiaAddressMap::get_addressMapEnabled](../../debugger/debug-interface-access/idiaaddressmap-get-addressmapenabled.md)
