---
title: "IDiaAddressMap::put_addressMapEnabled"
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
  - "IDiaAddressMap::put_addressMapEnabled method"
ms.assetid: 0f205337-4e59-4383-8059-7b1d207d6dcd
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
# IDiaAddressMap::put_addressMapEnabled
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
  
 When a PDB file is loaded, the address map stored in the file is enabled. There are times, however, when a client application may need to supply its own address map by calling the [IDiaAddressMap::set_addressMap](../debugger/idiaaddressmap--set_addressmap.md) method. If the `set_addressMap` method is successful, the client application must call the `put_addressMapEnabled` method with a `NewVal` parameter of `TRUE` to enable the use of that address map.  
  
 The current state of the address map being enabled can be retrieved with a call to the [IDiaAddressMap::get_addressMapEnabled](../debugger/idiaaddressmap--get_addressmapenabled.md) method.  
  
## See Also  
 [IDiaAddressMap](../debugger/idiaaddressmap.md)   
 [IDiaAddressMap::set_addressMap](../debugger/idiaaddressmap--set_addressmap.md)   
 [IDiaAddressMap::get_addressMapEnabled](../debugger/idiaaddressmap--get_addressmapenabled.md)