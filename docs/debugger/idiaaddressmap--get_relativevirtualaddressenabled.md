---
title: "IDiaAddressMap::get_relativeVirtualAddressEnabled"
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
  - "IDiaAddressMap::get_relativeVirtualAddressEnabled method"
ms.assetid: 4c48af81-7148-4d9a-818e-dbe62cbfc638
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
# IDiaAddressMap::get_relativeVirtualAddressEnabled
Indicates whether the calculation and use of relative virtual addresses (RVA) is enabled.  
  
## Syntax  
  
```cpp#  
HRESULT get_relativeVirtualAddressEnabled (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 pRetVal  
 [out] Returns `TRUE` if the calculation of RVAs is enabled.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 RVAs are enabled if the segments have been initially loaded from a PDB file. The use of RVAs can be temporarily disabled by calling the [IDiaAddressMap::put_relativeVirtualAddressEnabled](../debugger/idiaaddressmap--put_relativevirtualaddressenabled.md) method.  
  
 Also, new image headers can be established by calling the [IDiaAddressMap::set_imageHeaders](../debugger/idiaaddressmap--set_imageheaders.md) method followed by a call to the `put_relativeVirtualAddressEnabled` method to enable use of the RVAs using the new image headers.  
  
## See Also  
 [IDiaAddressMap](../debugger/idiaaddressmap.md)   
 [IDiaAddressMap::set_imageHeaders](../debugger/idiaaddressmap--set_imageheaders.md)   
 [IDiaAddressMap::put_relativeVirtualAddressEnabled](../debugger/idiaaddressmap--put_relativevirtualaddressenabled.md)