---
title: "IDiaEnumFrameData::Item"
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
ms.assetid: 2761a72d-1868-4f5b-a32e-c2a1d9358c91
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
# IDiaEnumFrameData::Item
Retrieves a frame data element by means of an index.  
  
## Syntax  
  
```cpp#  
HRESULT Item (   
   DWORD           index,  
   IDiaFrameData** section  
);  
```  
  
#### Parameters  
 index  
 [in] Index of the [IDiaFrameData](../VS_debugger/IDiaFrameData.md) object to be retrieved. The index is in the range 0 to `count`-1, where `count` is returned by the [IDiaEnumFrameData::get_Count](../VS_debugger/IDiaEnumFrameData--get_Count.md) method.  
  
 section  
 [out] Returns an [IDiaFrameData](../VS_debugger/IDiaFrameData.md) object representing the desired frame data element.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumFrameData](../VS_debugger/IDiaEnumFrameData.md)   
 [IDiaFrameData](../VS_debugger/IDiaFrameData.md)