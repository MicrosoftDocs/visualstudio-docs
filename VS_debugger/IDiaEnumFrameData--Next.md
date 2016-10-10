---
title: "IDiaEnumFrameData::Next"
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
ms.assetid: 546e2e23-efb2-425a-96a1-808c67c519fb
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
# IDiaEnumFrameData::Next
Retrieves a specified number of frame data elements in the enumeration sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Next (   
   ULONG           celt,   
   IDiaFrameData** rgelt,  
   ULONG*          pceltFetched  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of frame data elements in the enumerator to be retrieved.  
  
 rgelt  
 [out] An array of [IDiaFrameData](../VS_debugger/IDiaFrameData.md) objects to be filled in with the requested frame data elements.  
  
 pceltFetched  
 [out] Returns the number of frame data elements in the fetched enumerator.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more records. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumFrameData](../VS_debugger/IDiaEnumFrameData.md)   
 [IDiaFrameData](../VS_debugger/IDiaFrameData.md)