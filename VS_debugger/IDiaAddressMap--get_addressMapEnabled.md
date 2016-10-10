---
title: "IDiaAddressMap::get_addressMapEnabled"
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
ms.assetid: 6183dc5e-befa-4e5a-ae5a-f4aa24f3ed9e
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
  
 Client applications can set the address map for a particular session by getting the [IDiaAddressMap](../VS_debugger/IDiaAddressMap.md) interface from the [IDiaSession](../VS_debugger/IDiaSession.md) interface and calling the [IDiaAddressMap::set_addressMap](../VS_debugger/IDiaAddressMap--set_addressMap.md) method followed by a call to the [IDiaAddressMap::put_addressMapEnabled](../VS_debugger/IDiaAddressMap--put_addressMapEnabled.md) method. The `get_addressMapEnabled` method returns the results of calling the `put_addressMapEnabled` method.  
  
## See Also  
 [IDiaAddressMap](../VS_debugger/IDiaAddressMap.md)   
 [IDiaSession](../VS_debugger/IDiaSession.md)   
 [IDiaAddressMap::set_addressMap](../VS_debugger/IDiaAddressMap--set_addressMap.md)   
 [IDiaAddressMap::put_addressMapEnabled](../VS_debugger/IDiaAddressMap--put_addressMapEnabled.md)