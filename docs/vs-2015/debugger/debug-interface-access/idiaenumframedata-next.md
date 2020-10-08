---
title: "IDiaEnumFrameData::Next | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumFrameData::Next method"
ms.assetid: 546e2e23-efb2-425a-96a1-808c67c519fb
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumFrameData::Next
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

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
 [out] An array of [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) objects to be filled in with the requested frame data elements.  
  
 pceltFetched  
 [out] Returns the number of frame data elements in the fetched enumerator.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more records. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumFrameData](../../debugger/debug-interface-access/idiaenumframedata.md)   
 [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)
