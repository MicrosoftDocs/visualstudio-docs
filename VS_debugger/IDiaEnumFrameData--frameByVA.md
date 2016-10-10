---
title: "IDiaEnumFrameData::frameByVA"
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
ms.assetid: 0b1e441b-710a-46d8-8060-bed39071c834
caps.latest.revision: 8
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
# IDiaEnumFrameData::frameByVA
Returns a frame by virtual address (VA).  
  
## Syntax  
  
```cpp#  
HRESULT frameByVA(   
   ULONGLONG       virtualAddress,  
   IDiaFrameData** frame  
);  
```  
  
#### Parameters  
 virtualAddress  
 [in] VA of the frame of interest.  
  
 frame  
 [out] Returns an [IDiaFrameData](../VS_debugger/IDiaFrameData.md) object that represents the frame that contains the address provided.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if no frame data matches the specified address. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumFrameData](../VS_debugger/IDiaEnumFrameData.md)   
 [IDiaFrameData](../VS_debugger/IDiaFrameData.md)