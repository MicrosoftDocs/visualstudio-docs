---
title: "IDiaEnumFrameData::Skip | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumFrameData::Skip method"
ms.assetid: 67140b4c-7125-4895-932d-42412326da29
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumFrameData::Skip
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Skips a specified number of frame data elements in an enumeration sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Skip (   
   ULONG celt  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of frame data elements in the enumeration sequence to skip.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` if there are no more records to skip.  
  
## See Also  
 [IDiaEnumFrameData](../../debugger/debug-interface-access/idiaenumframedata.md)
