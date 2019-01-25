---
title: "IDiaEnumDebugStreamData::Clone | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumDebugStreamData::Clone method"
ms.assetid: e7f17750-0694-4634-bf34-c821cd265c2f
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaEnumDebugStreamData::Clone
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Creates an enumerator that contains the same enumerated sequence as the current enumerator.  
  
## Syntax  
  
```cpp#  
HRESULT Clone (   
   IDiaEnumDebugStreamData** ppenum  
);  
```  
  
#### Parameters  
 ppenum  
 [out] Returns an [IDiaEnumDebugStreamData](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md) object that contains the duplicated sequence of debug data stream records.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumDebugStreamData](../../debugger/debug-interface-access/idiaenumdebugstreamdata.md)
