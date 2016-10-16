---
title: "IDiaAddressMap::get_addressMapEnabled"
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
  - "IDiaAddressMap::get_addressMapEnabled method"
ms.assetid: 6183dc5e-befa-4e5a-ae5a-f4aa24f3ed9e
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
# IDiaAddressMap::get_addressMapEnabled
Indicates whether an address map has been established for a particular session.  
  
## Syntax  
  
```cpp#  
HRESULT get_addressMapEnabled (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 pRetVal  
 [out] Returns `TRUE` if the address mapping is enabled.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Executable post-processors sometimes update the executable. DIA contains a mechanism to support the translation of symbols to the new layout.  
  
 Client applications can set the address map for a particular session by getting the [IDiaAddressMap](../debugger/idiaaddressmap.md) interface from the [IDiaSession](../debugger/idiasession.md) interface and calling the [IDiaAddressMap::set_addressMap](../debugger/idiaaddressmap--set_addressmap.md) method followed by a call to the [IDiaAddressMap::put_addressMapEnabled](../debugger/idiaaddressmap--put_addressmapenabled.md) method. The `get_addressMapEnabled` method returns the results of calling the `put_addressMapEnabled` method.  
  
## See Also  
 [IDiaAddressMap](../debugger/idiaaddressmap.md)   
 [IDiaSession](../debugger/idiasession.md)   
 [IDiaAddressMap::set_addressMap](../debugger/idiaaddressmap--set_addressmap.md)   
 [IDiaAddressMap::put_addressMapEnabled](../debugger/idiaaddressmap--put_addressmapenabled.md)